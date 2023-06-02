using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AyanixAutoCick.Models;
using static SysUI;

namespace AyanixAutoCick
{
    public partial class frmBOt : Form
    {
        private static DateTime DTStart = DateTime.Now;
        private static Color cCurColor = Color.Empty;
        private static bool bPlay = false;
        private static int iClicker = 0;
        
        private HotKey kC;

        public frmBOt()
        {
            base.DoubleBuffered = true;

            InitializeComponent();

            DrawingControl.SetDoubleBuffered(lv);
            DrawingControl.SetDoubleBuffered(picColorFucos);

            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Program is already running", "Ayanix Auto Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(1);
            }
        }

        private void frmBOt_Load(object sender, EventArgs e)
        {
            kC = new HotKey(Constants.CTRL,Keys.None, this);
            kC.Register();
        }

        private void frmBOt_FormClosing(object sender, FormClosingEventArgs e)
        {
            kC.Unregiser();

        }

        private void HandleAddList()
        {
            bool bFoundDuplicate = false;
            ListViewItem LST;

            // Prevent accidentally Pressing Ctrl.
            if (!bPlay)
            {
                int iX = Control.MousePosition.X;
                int iY = Control.MousePosition.Y;

                if (lv.SelectedItems.Count > 0)
                {
                    ClickInfo2 CPf = (ClickInfo2)lv.SelectedItems[0].Tag;
                    CPf.Click_X = iX;
                    CPf.Click_Y = iY;

                    lv.SelectedItems[0].SubItems[2].Text = iX.ToString() + "," + iY.ToString();

                    MessageBox.Show("Click Location. Updated!!");
                }
                else
                {
                    Color cColor = GetPixelColor(iX, iY);

                    foreach (ListViewItem ITM in lv.Items)
                    {
                        bFoundDuplicate = MatchColor(cColor, ITM.SubItems[1].BackColor, Convert.ToInt32(numcoltolerance.Value));
                    }

                    if (!bFoundDuplicate && lv.Items.Count < 10)
                    {
                        string[] arr = new string[8];

                        arr[0] = ColorTranslator.ToHtml(cColor).ToString();
                        arr[1] = iX.ToString() + "," + iY.ToString();
                        arr[2] = iX.ToString() + "," + iY.ToString();
                        arr[3] = "0";
                        arr[4] = lblwintitle.Text;


                        Models.ClickInfo2 CPf = new Models.ClickInfo2
                        {
                            Color = cColor,
                            Pixel_X = iX,
                            Pixel_Y = iY,
                            Click_X = iX,
                            Click_Y = iY
                        };

                        LST = new ListViewItem(arr);
                        LST.Checked = true;
                        LST.BackColor = cColor;
                        LST.UseItemStyleForSubItems = false;
                        LST.Tag = CPf;          // Bind Model as Tag Object

                        lv.Items.Add(LST);
                    }
                }
            }           
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID) HandleAddList();         
            base.WndProc(ref m);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "PLAY")
            {
                if(lv.Items.Count == 0)
                {
                    MessageBox.Show("No Rules Found", "Rules", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // timer speed in ms
                timer_click.Interval = Convert.ToInt32(numDelay.Value);

                // reset counters
                foreach (ListViewItem ITM in lv.Items)
                {
                    Models.ClickInfo2 Cpf = (Models.ClickInfo2)ITM.Tag;

                    Cpf.Counter = 0;

                    ITM.SubItems[3].Text = Cpf.Counter.ToString();
                }

                Application.DoEvents();

                bPlay = true;
                DTStart = DateTime.Now;
            }
            else
            {
                bPlay = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
        }
   
        private void lv_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnDelItem.Visible = e.IsSelected && !bPlay ? true : false;
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem LST in lv.Items)
            {
                if (LST.Selected) lv.Items.Remove(LST);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------------------------------------
        // TIMERS
        // --------------------------------------------------------------------------------------------------------------------------------------------------------------

        // 100 ms  Fixed Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bPlay)
            {
                TimeSpan TS = DateTime.Now.Subtract(DTStart);

                lblcursor.Text = "";
                lblrgb.Text = "Playing... " + string.Format("{0:D2}:{1:D2}:{2:D2}", TS.Hours, TS.Minutes, TS.Seconds);
                picColorFucos.BackColor = this.BackColor;
            }
            else
            {
                Color cl = GetPixelColor(Control.MousePosition.X, Control.MousePosition.Y);

                picColorFucos.BackColor = cl;

                
                lblcursor.Text = Control.MousePosition.X.ToString() + ", " + Control.MousePosition.Y.ToString();
                lblrgb.Text =   string.Format("RGB ({0:D3},{1:D3},{2:D3}) ",cl.R, cl.G, cl.B) + ColorTranslator.ToHtml(cl);
            }
        }

        // 500 ms
        private void timer2_Tick(object sender, EventArgs e)
        {



            if (bPlay)
            {
                Color cColorNow = Color.Empty, cColor = Color.Empty;

                foreach (ListViewItem ITM in lv.Items)
                {
                    ClickInfo2 Cpf = (ClickInfo2)ITM.Tag;

                    ITM.SubItems[3].BackColor = Color.White;                   // Reset Color  

                    cColor = Cpf.Color;                                        // Recorded Color
                    cColorNow = GetPixelColor(Cpf.Pixel_X, Cpf.Pixel_Y);       // Screen Color
                    
                    //if (cCurColor != cColorNow) iClicker = 0;


                    if (chkColor.Checked)
                    {
                        if (ITM.Checked && MatchColor(cColor, cColorNow, Convert.ToInt32(numcoltolerance.Value)) )
                        {
                            if (ITM.SubItems[4].Text != "")
                            {
                                FucosWin(ITM.SubItems[4].Text);
                            }

                            LeftClick(Cpf.Click_X, Cpf.Click_Y);

                            //txtLog.Text += ITM.SubItems[4].Text + " click " + Cpf.Click_X + " , " + Cpf.Click_Y + "   " + Environment.NewLine;

                            Cpf.Counter++;
                            ITM.SubItems[3].Text = Cpf.Counter.ToString();
                            ITM.SubItems[3].BackColor = Color.LightPink;

                            if (chkLimitClk.Checked && numLimit.Value == Cpf.Counter) 
                            {
                                if (lv.Items.Count == 1)  bPlay = false;

                                ITM.Checked = false;
                                Cpf.Counter = 0;
                            } 

                            //if (iClicker == 0)
                            //{
                            //    iClicker++;  // Repeated Click Counter
                            //    cCurColor = cColorNow;
                            //}
                        }
                    }
                    else
                    {
                        if (ITM.Checked)
                        {
                            if (ITM.SubItems[4].Text != "")
                            {
                                FucosWin(ITM.SubItems[4].Text);
                            }

                            LeftClick(Cpf.Click_X, Cpf.Click_Y);

                            //txtLog.Text += ITM.SubItems[4].Text + " click " + Cpf.Click_X + " , " + Cpf.Click_Y + "   " + Environment.NewLine;

                            Cpf.Counter++;
                            ITM.SubItems[3].Text = Cpf.Counter.ToString();
                            ITM.SubItems[3].BackColor = Color.LightPink;

                            if (chkLimitClk.Checked && numLimit.Value == Cpf.Counter)
                            {
                                if (lv.Items.Count == 1) bPlay = false;

                                ITM.Checked = false;
                                Cpf.Counter = 0;
                            }
                        }
                    }
                    
                }
            }
        }

        // 650ms  Fixed Timer
        private void timer3_Tick(object sender, EventArgs e)
        {
            WindowInfo WinInfo = GetActiveWindow();

            lblwintitle.Text = WinInfo.Title ;
            lblsize.Text = "[ " + WinInfo.Left + "," + WinInfo.Top + " ] [ " + WinInfo.Width + "," + WinInfo.Height + " ] ";

            if (lv.Items.Count == 0)
            {
                chkAll.Visible = false;
                btnReset.Visible = false;
                btnDelItem.Visible = false;

                btnPlay.Enabled = false;
            }
            else
            {
                chkAll.Visible = true;
                btnPlay.Enabled = true;

                btnReset.Visible = bPlay ? false : true;

                if (bPlay) btnDelItem.Visible = false;
            }

            timer_click.Enabled = bPlay;
            chkLimitClk.Enabled = !bPlay;
            numDelay.Enabled = !bPlay;
            numLimit.Enabled = !bPlay && chkLimitClk.Checked;

            if (bPlay)
            {
                if (btnPlay.Text == "PLAY")
                {
                    btnPlay.Text = "STOP";
                    btnPlay.BackColor = Color.LightSalmon;
                }
            }
            else
            {
                if (btnPlay.Text == "STOP")
                {
                    btnPlay.Text = "PLAY";
                    btnPlay.BackColor = this.BackColor;
                }
            }
        }

        private void chkAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LST in lv.Items) { LST.Checked = chkAll.Checked; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using app name or keyword
            //ResizeWin("MEmu", 0, 0, 1466, 691);
           // PrintWin("MEmu","d:\\temp\\MEmuTestPng.png");
          // LeftClick1("MEmu", 100, 100);
        }
    }
}
