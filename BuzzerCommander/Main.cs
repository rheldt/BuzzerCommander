using BuzzerCommander.Properties;
using BuzzerCommander.Util;
using System;
using System.Media;
using System.Windows.Forms;

namespace BuzzerCommander
{
    public partial class frmMain : Form
    {
        private BuzzerService _BuzzerService;
        private Buzzer _ActivatedBuzzer;

        public frmMain()
        {
            InitializeComponent();
            _ActivatedBuzzer = Buzzer.None;
            _BuzzerService = new BuzzerService();
            _BuzzerService.BuzzerPressed += BuzzerService_BuzzerPressed;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _BuzzerService.StartCapture();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The buzzers probably aren't connected. Please connect and restart Buzzer Commander.\n\n" + ex.Message, "This is embarrassing", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _BuzzerService.StopCapture();
        }

        private void BuzzerService_BuzzerPressed(object sender, BuzzerButtonPressedEventArgs e)
        {
            if (_ActivatedBuzzer != Buzzer.None)
            {
                return;
            }

            Action buzzerAction = () =>
            {
                // Check for buzzer
                _ActivatedBuzzer = e.Buzzer;
                switch (e.Buzzer)
                {
                    case Buzzer.BuzzerA:
                        imgLeft.BackgroundImage = Resources.left;
                        break;
                    case Buzzer.BuzzerB:
                        imgRight.BackgroundImage = Resources.right;
                        break;
                }

                // Reset buzzers after 5 seconds
                Timer resetTimer = new Timer();
                resetTimer.Interval = 5000;
                resetTimer.Tick += (s, en) =>
                {
                    _ActivatedBuzzer = Buzzer.None;
                    imgLeft.BackgroundImage = Resources.off;
                    imgRight.BackgroundImage = Resources.off;
                    resetTimer.Stop();
                };
                resetTimer.Start();
            };

            if (pnlMain.InvokeRequired)
            {
                pnlMain.Invoke(buzzerAction);
                SystemSounds.Exclamation.Play();
            }
        }
    }
}