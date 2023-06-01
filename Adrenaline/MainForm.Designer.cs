namespace Adrenaline
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainNotifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NameMainNotifyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainNotifyIconToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ActivatedMainNotifyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowOptionsMainNotifyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainNotifyIconToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMainNotifyIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowOptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetLinkLabel = new System.Windows.Forms.LinkLabel();
            this.KeyInputLabel = new System.Windows.Forms.Label();
            this.TimeInputLabel = new System.Windows.Forms.Label();
            this.ComboBoxKeyInput = new System.Windows.Forms.ComboBox();
            this.TimeInputDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StayAwakeCheckBox = new System.Windows.Forms.CheckBox();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MakeSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomIntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MainNotifyIconContextMenuStrip.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(259, 150);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "This application will simulate a key press on your keyboard.\r\n\r\nYour computer sta" +
    "ys awake and your programs running.";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartStopButton
            // 
            this.StartStopButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartStopButton.Location = new System.Drawing.Point(0, 426);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(259, 50);
            this.StartStopButton.TabIndex = 5;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.ContextMenuStrip = this.MainNotifyIconContextMenuStrip;
            this.MainNotifyIcon.Text = "Adrenaline";
            this.MainNotifyIcon.Visible = true;
            this.MainNotifyIcon.DoubleClick += new System.EventHandler(this.MainNotifyIcon_DoubleClick);
            // 
            // MainNotifyIconContextMenuStrip
            // 
            this.MainNotifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameMainNotifyIconToolStripMenuItem,
            this.MainNotifyIconToolStripSeparator1,
            this.ActivatedMainNotifyIconToolStripMenuItem,
            this.ShowOptionsMainNotifyIconToolStripMenuItem,
            this.MainNotifyIconToolStripSeparator2,
            this.ExitMainNotifyIconToolStripMenuItem});
            this.MainNotifyIconContextMenuStrip.Name = "MainNotifyIconContextMenuStrip";
            this.MainNotifyIconContextMenuStrip.ShowCheckMargin = true;
            this.MainNotifyIconContextMenuStrip.ShowImageMargin = false;
            this.MainNotifyIconContextMenuStrip.Size = new System.Drawing.Size(147, 104);
            // 
            // NameMainNotifyIconToolStripMenuItem
            // 
            this.NameMainNotifyIconToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NameMainNotifyIconToolStripMenuItem.Name = "NameMainNotifyIconToolStripMenuItem";
            this.NameMainNotifyIconToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.NameMainNotifyIconToolStripMenuItem.Text = "Adrenaline";
            this.NameMainNotifyIconToolStripMenuItem.Click += new System.EventHandler(this.NameMainNotifyIconToolStripMenuItem_Click);
            // 
            // MainNotifyIconToolStripSeparator1
            // 
            this.MainNotifyIconToolStripSeparator1.Name = "MainNotifyIconToolStripSeparator1";
            this.MainNotifyIconToolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // ActivatedMainNotifyIconToolStripMenuItem
            // 
            this.ActivatedMainNotifyIconToolStripMenuItem.Name = "ActivatedMainNotifyIconToolStripMenuItem";
            this.ActivatedMainNotifyIconToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ActivatedMainNotifyIconToolStripMenuItem.Text = "Activated";
            this.ActivatedMainNotifyIconToolStripMenuItem.Click += new System.EventHandler(this.ActivatedMainNotifyIconToolStripMenuItem_Click);
            // 
            // ShowOptionsMainNotifyIconToolStripMenuItem
            // 
            this.ShowOptionsMainNotifyIconToolStripMenuItem.Name = "ShowOptionsMainNotifyIconToolStripMenuItem";
            this.ShowOptionsMainNotifyIconToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ShowOptionsMainNotifyIconToolStripMenuItem.Text = "Show options";
            this.ShowOptionsMainNotifyIconToolStripMenuItem.Click += new System.EventHandler(this.ShowOptionsMainNotifyIconToolStripMenuItem_Click);
            // 
            // MainNotifyIconToolStripSeparator2
            // 
            this.MainNotifyIconToolStripSeparator2.Name = "MainNotifyIconToolStripSeparator2";
            this.MainNotifyIconToolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // ExitMainNotifyIconToolStripMenuItem
            // 
            this.ExitMainNotifyIconToolStripMenuItem.Name = "ExitMainNotifyIconToolStripMenuItem";
            this.ExitMainNotifyIconToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitMainNotifyIconToolStripMenuItem.Text = "Exit";
            this.ExitMainNotifyIconToolStripMenuItem.Click += new System.EventHandler(this.ExitMainNotifyIconToolStripMenuItem_Click);
            // 
            // ShowOptionsCheckBox
            // 
            this.ShowOptionsCheckBox.Checked = true;
            this.ShowOptionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowOptionsCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowOptionsCheckBox.Location = new System.Drawing.Point(0, 150);
            this.ShowOptionsCheckBox.Name = "ShowOptionsCheckBox";
            this.ShowOptionsCheckBox.Size = new System.Drawing.Size(259, 24);
            this.ShowOptionsCheckBox.TabIndex = 6;
            this.ShowOptionsCheckBox.Text = "Show options";
            this.ShowOptionsCheckBox.UseVisualStyleBackColor = true;
            this.ShowOptionsCheckBox.CheckedChanged += new System.EventHandler(this.ShowOptionsCheckBox_CheckedChanged);
            // 
            // ResetLinkLabel
            // 
            this.ResetLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.ResetLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetLinkLabel.LinkColor = System.Drawing.SystemColors.ControlText;
            this.ResetLinkLabel.Location = new System.Drawing.Point(3, 227);
            this.ResetLinkLabel.Name = "ResetLinkLabel";
            this.ResetLinkLabel.Size = new System.Drawing.Size(253, 25);
            this.ResetLinkLabel.TabIndex = 7;
            this.ResetLinkLabel.TabStop = true;
            this.ResetLinkLabel.Text = "(reset)";
            this.ResetLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.ResetLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetLinkLabel_LinkClicked);
            // 
            // KeyInputLabel
            // 
            this.KeyInputLabel.AutoSize = true;
            this.KeyInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyInputLabel.Location = new System.Drawing.Point(3, 0);
            this.KeyInputLabel.Name = "KeyInputLabel";
            this.KeyInputLabel.Size = new System.Drawing.Size(253, 20);
            this.KeyInputLabel.TabIndex = 0;
            this.KeyInputLabel.Text = "Key to be pressed:";
            this.KeyInputLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TimeInputLabel
            // 
            this.TimeInputLabel.AutoSize = true;
            this.TimeInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeInputLabel.Location = new System.Drawing.Point(3, 45);
            this.TimeInputLabel.Name = "TimeInputLabel";
            this.TimeInputLabel.Size = new System.Drawing.Size(253, 20);
            this.TimeInputLabel.TabIndex = 1;
            this.TimeInputLabel.Text = "Each (interval):";
            this.TimeInputLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ComboBoxKeyInput
            // 
            this.ComboBoxKeyInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxKeyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxKeyInput.Items.AddRange(new object[] {
            "{ENTER}",
            "{ESC}",
            "{F1}",
            "{F2}",
            "{F3}",
            "{F4}",
            "{F5}",
            "{F6}",
            "{F7}",
            "{F8}",
            "{F9}",
            "{F10}",
            "{F11}",
            "{F12}",
            "{PRTSC}",
            "{NUMLOCK}",
            "{SCROLLLOCK}",
            "{BREAK}",
            "{INSERT}",
            "{DELETE}",
            "{HOME}",
            "{END}",
            "{PGUP}",
            "{PGDN}",
            "{BACKSPACE}",
            "{TAB}",
            "{CAPSLOCK}",
            "{HELP}",
            "{ADD}",
            "{SUBTRACT}",
            "{MULTIPLY}",
            "{DIVIDE}",
            "{LEFT}",
            "{RIGHT}",
            "{UP}",
            "{DOWN}",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ComboBoxKeyInput.Location = new System.Drawing.Point(3, 23);
            this.ComboBoxKeyInput.Name = "ComboBoxKeyInput";
            this.ComboBoxKeyInput.Size = new System.Drawing.Size(253, 21);
            this.ComboBoxKeyInput.TabIndex = 9;
            // 
            // TimeInputDateTimePicker
            // 
            this.TimeInputDateTimePicker.CustomFormat = "H\'h\' mm\'m\' ss\'s\'";
            this.TimeInputDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeInputDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeInputDateTimePicker.Location = new System.Drawing.Point(3, 68);
            this.TimeInputDateTimePicker.MaxDate = new System.DateTime(1970, 1, 1, 15, 0, 0, 0);
            this.TimeInputDateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 1, 0);
            this.TimeInputDateTimePicker.Name = "TimeInputDateTimePicker";
            this.TimeInputDateTimePicker.ShowUpDown = true;
            this.TimeInputDateTimePicker.Size = new System.Drawing.Size(253, 20);
            this.TimeInputDateTimePicker.TabIndex = 8;
            this.TimeInputDateTimePicker.Value = new System.DateTime(1970, 1, 1, 15, 0, 0, 0);
            // 
            // StayAwakeCheckBox
            // 
            this.StayAwakeCheckBox.AutoSize = true;
            this.StayAwakeCheckBox.Checked = true;
            this.StayAwakeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StayAwakeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StayAwakeCheckBox.Location = new System.Drawing.Point(3, 138);
            this.StayAwakeCheckBox.Name = "StayAwakeCheckBox";
            this.StayAwakeCheckBox.Size = new System.Drawing.Size(253, 19);
            this.StayAwakeCheckBox.TabIndex = 4;
            this.StayAwakeCheckBox.Text = "Send signal to keep device awake.";
            this.StayAwakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.StayAwakeCheckBox, 0, 6);
            this.MainTableLayoutPanel.Controls.Add(this.TimeInputDateTimePicker, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.ComboBoxKeyInput, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.TimeInputLabel, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.KeyInputLabel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ResetLinkLabel, 0, 10);
            this.MainTableLayoutPanel.Controls.Add(this.MakeSoundCheckBox, 0, 7);
            this.MainTableLayoutPanel.Controls.Add(this.RandomIntervalCheckBox, 0, 8);
            this.MainTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.TitleTextBox, 0, 5);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 174);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 11;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(259, 252);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // MakeSoundCheckBox
            // 
            this.MakeSoundCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeSoundCheckBox.Location = new System.Drawing.Point(3, 163);
            this.MakeSoundCheckBox.Name = "MakeSoundCheckBox";
            this.MakeSoundCheckBox.Size = new System.Drawing.Size(253, 19);
            this.MakeSoundCheckBox.TabIndex = 10;
            this.MakeSoundCheckBox.Text = "Make a \"beep\" sound.";
            this.MakeSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomIntervalCheckBox
            // 
            this.RandomIntervalCheckBox.Checked = true;
            this.RandomIntervalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RandomIntervalCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomIntervalCheckBox.Location = new System.Drawing.Point(3, 188);
            this.RandomIntervalCheckBox.Name = "RandomIntervalCheckBox";
            this.RandomIntervalCheckBox.Size = new System.Drawing.Size(253, 19);
            this.RandomIntervalCheckBox.TabIndex = 11;
            this.RandomIntervalCheckBox.Text = "Randomize timer by ±10%.";
            this.RandomIntervalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Location = new System.Drawing.Point(3, 90);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(253, 20);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Application title:";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.Location = new System.Drawing.Point(3, 113);
            this.TitleTextBox.MaxLength = 50;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(253, 20);
            this.TitleTextBox.TabIndex = 13;
            this.TitleTextBox.Text = "Adrenaline";
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 476);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.ShowOptionsCheckBox);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adrenaline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainNotifyIconContextMenuStrip.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip MainNotifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ActivatedMainNotifyIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowOptionsMainNotifyIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MainNotifyIconToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitMainNotifyIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MainNotifyIconToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NameMainNotifyIconToolStripMenuItem;
        private System.Windows.Forms.CheckBox ShowOptionsCheckBox;
        private System.Windows.Forms.LinkLabel ResetLinkLabel;
        private System.Windows.Forms.Label KeyInputLabel;
        private System.Windows.Forms.Label TimeInputLabel;
        private System.Windows.Forms.ComboBox ComboBoxKeyInput;
        private System.Windows.Forms.DateTimePicker TimeInputDateTimePicker;
        private System.Windows.Forms.CheckBox StayAwakeCheckBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.CheckBox MakeSoundCheckBox;
        private System.Windows.Forms.CheckBox RandomIntervalCheckBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
    }
}

