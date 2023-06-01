using System;
using System.Windows.Forms;

namespace Adrenaline
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        protected bool TrayNotificationSent;
        protected Random Rand;

        public MainForm(string AppTitle)
        {
            InitializeComponent();
            this.TitleTextBox.Text = AppTitle;
            this.MainTimer.Enabled = false;
            this.StopTimer.Enabled = false;
            this.TrayNotificationSent = false;
            this.Rand = new Random();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MainLabel.Text = Utils.GetString("MainForm_MainLabel");
            this.ShowOptionsCheckBox.Text = Utils.GetString("MainForm_ShowOptionsCheckBox");
            this.KeyInputLabel.Text = Utils.GetString("MainForm_KeyInputLabel");
            this.TimeInputLabel.Text = Utils.GetString("MainForm_TimeInputLabel");
            this.TimeInputDateTimePicker.CustomFormat = Utils.GetString("MainForm_TimeInputDateTimePicker");
            this.StopAutomaticallyInputLabel.Text = Utils.GetString("MainForm_StopAutomaticallyCheckBox");
            this.StopInputDateTimePicker.CustomFormat = Utils.GetString("MainForm_TimeInputDateTimePicker");
            this.TitleLabel.Text = Utils.GetString("MainForm_TitleLabel");
            this.StayAwakeCheckBox.Text = Utils.GetString("MainForm_StayAwakeCheckBox");
            this.MakeSoundCheckBox.Text = Utils.GetString("MainForm_MakeSoundCheckBox");
            this.RandomIntervalCheckBox.Text = Utils.GetString("MainForm_RandomIntervalCheckBox");
            this.ResetLinkLabel.Text = Utils.GetString("MainForm_ResetLinkLabel");
            this.StartStopButton.Text = Utils.GetString("MainForm_StartStopButton_Start");
            this.ActivatedMainNotifyIconToolStripMenuItem.Text = Utils.GetString("MainForm_ActivatedMainNotifyIconToolStripMenuItem");
            this.ShowOptionsMainNotifyIconToolStripMenuItem.Text = Utils.GetString("MainForm_ShowOptionsMainNotifyIconToolStripMenuItem");
            this.ExitMainNotifyIconToolStripMenuItem.Text = Utils.GetString("MainForm_ExitMainNotifyIconToolStripMenuItem");
            this.ComboBoxKeyInput.Text = "{BREAK}";
            this.TimeInputDateTimePicker.Value = new DateTime(1970, 1, 1, 0, 1, 0);
            this.StopInputDateTimePicker.Value = new DateTime(1970, 1, 1, 1, 0, 0);
            this.StopInputDateTimePicker.Checked = false;
            this.StayAwakeCheckBox.Checked = true;
            this.MakeSoundCheckBox.Checked = false;
            this.RandomIntervalCheckBox.Checked = true;
            this.ShowOptionsCheckBox.Checked = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MainTimer.Enabled == true)
            {
                this.Visible = false;
                e.Cancel = true;
                return;
            }
            MainNotifyIcon.Visible = false;
        }

        private void UpdateTimerInterval()
        {
            DateTime interval = this.TimeInputDateTimePicker.Value;
            DateTime stopInterval = this.StopInputDateTimePicker.Value;
            int intervalMs = interval.Hour * 60 * 60 * 1000 + interval.Minute * 60 * 1000 + interval.Second * 1000;
            int stopIntervalMs = stopInterval.Hour * 60 * 60 * 1000 + stopInterval.Minute * 60 * 1000 + stopInterval.Second * 1000;
            if (this.RandomIntervalCheckBox.Checked)
            {
                intervalMs = (int)(intervalMs * (0.9 + this.Rand.NextDouble() * 0.2));
            }
            this.MainTimer.Interval = Math.Max(intervalMs, 1000);
            this.StopTimer.Interval = Math.Max(stopIntervalMs, 1000);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                SendKeys.Send(ComboBoxKeyInput.Text);
            } catch
            {
                this.MainNotifyIcon.ShowBalloonTip(10, this.TitleTextBox.Text, Utils.GetString("MainForm_MainNotifyIcon_ErrorTipText"), ToolTipIcon.Warning);
            }
            if (this.MakeSoundCheckBox.Checked)
            {
                System.Media.SystemSounds.Beep.Play();
            }
            UpdateTimerInterval();
        }
        
        private void StopTimer_Tick(object sender, EventArgs e)
        {
            Stop();
            this.MainNotifyIcon.ShowBalloonTip(10, this.TitleTextBox.Text, Utils.GetString("MainForm_MainNotifyIcon_StopTipText"), ToolTipIcon.Info);
        }

        private void Start()
        {
            this.MainTableLayoutPanel.Enabled = false;
            this.ActivatedMainNotifyIconToolStripMenuItem.Checked = true;
            this.StartStopButton.Text = Utils.GetString("MainForm_StartStopButton_Stop");
            this.StartStopButton.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Highlight);
            this.MainTimer.Enabled = true;
            UpdateTimerInterval();
            if(this.StopInputDateTimePicker.Checked)
            {
                this.StopTimer.Enabled = true;
            }
            if (this.StayAwakeCheckBox.Checked)
            {
                Utils.SendAwakeSignal(true);
            }
            if (!this.TrayNotificationSent)
            {
                this.Visible = false;
                this.MainNotifyIcon.ShowBalloonTip(10, this.TitleTextBox.Text, Utils.GetString("MainForm_MainNotifyIcon_StartTipText"), ToolTipIcon.Info);
                this.TrayNotificationSent = true;
            }
            this.MainNotifyIcon.Icon = Adrenaline.Properties.Resources.logo;
        }

        private void Stop()
        {
            this.MainTimer.Enabled = false;
            this.StopTimer.Enabled = false;
            if (this.StayAwakeCheckBox.Checked)
            {
                Utils.SendAwakeSignal(false);
            }
            this.ActivatedMainNotifyIconToolStripMenuItem.Checked = false;
            this.MainTableLayoutPanel.Enabled = true;
            this.StartStopButton.Text = Utils.GetString("MainForm_StartStopButton_Start");
            this.StartStopButton.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
            this.MainNotifyIcon.Icon = Adrenaline.Properties.Resources.logo_line;
        }

        private void ShowOptionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.MainTableLayoutPanel.Visible = this.ShowOptionsCheckBox.Checked;
            if (this.MainTableLayoutPanel.Visible)
            {
                this.Height = 565;
            }
            else
            {
                this.Height = 275;
            }
        }

        private void ResetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.TitleTextBox.Text = Utils.GetString("MainForm");
            this.ComboBoxKeyInput.Text = "{BREAK}";
            this.TimeInputDateTimePicker.Value = new DateTime(1970, 1, 1, 0, 1, 0);
            this.StopInputDateTimePicker.Value = new DateTime(1970, 1, 1, 1, 0, 0);
            this.StopInputDateTimePicker.Checked = false;
            this.StayAwakeCheckBox.Checked = true;
            this.MakeSoundCheckBox.Checked = false;
            this.RandomIntervalCheckBox.Checked = true;
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (this.MainTimer.Enabled == true)
            {
                Stop();
                return;
            }
            Start();
        }

        private void MainNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            if (this.Visible)
            {
                this.Activate();
            }
        }

        private void NameMainNotifyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.Website);
        }

        private void ActivatedMainNotifyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MainTimer.Enabled == true)
            {
                Stop();
                return;
            }
            Start();
        }

        private void ShowOptionsMainNotifyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowOptionsCheckBox.Checked = true;
            this.Activate();
        }

        private void ExitMainNotifyIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
            this.Close();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = this.TitleTextBox.Text;
            this.MainNotifyIcon.Text = this.TitleTextBox.Text;
            this.NameMainNotifyIconToolStripMenuItem.Text = this.TitleTextBox.Text;
        }

    }
}