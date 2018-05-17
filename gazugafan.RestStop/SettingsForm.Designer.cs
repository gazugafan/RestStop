namespace gazugafan.RestStop
{
	partial class SettingsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.restTimeRequiredPost = new System.Windows.Forms.Label();
			this.workIntervalPost = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SoundSelect = new System.Windows.Forms.ComboBox();
			this.ReminderSoundSelect = new System.Windows.Forms.ComboBox();
			this.startupCheckbox = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.reminderIntervalPost = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.Behavior = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.reminderInterval = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.workInterval = new System.Windows.Forms.NumericUpDown();
			this.restTimeRequired = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.Behavior.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reminderInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.restTimeRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 62);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(138, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Rest Time Required:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 32);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Work Interval:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// restTimeRequiredPost
			// 
			this.restTimeRequiredPost.AutoSize = true;
			this.restTimeRequiredPost.Location = new System.Drawing.Point(262, 62);
			this.restTimeRequiredPost.Name = "restTimeRequiredPost";
			this.restTimeRequiredPost.Size = new System.Drawing.Size(61, 17);
			this.restTimeRequiredPost.TabIndex = 4;
			this.restTimeRequiredPost.Text = "seconds";
			// 
			// workIntervalPost
			// 
			this.workIntervalPost.AutoSize = true;
			this.workIntervalPost.Location = new System.Drawing.Point(262, 32);
			this.workIntervalPost.Name = "workIntervalPost";
			this.workIntervalPost.Size = new System.Drawing.Size(61, 17);
			this.workIntervalPost.TabIndex = 5;
			this.workIntervalPost.Text = "seconds";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(262, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "pixels";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(62, 93);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(88, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "Mouse Fuzz:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(308, 481);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(119, 38);
			this.SaveButton.TabIndex = 9;
			this.SaveButton.Text = "Save Changes";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ResetButton
			// 
			this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ResetButton.Location = new System.Drawing.Point(12, 481);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(140, 38);
			this.ResetButton.TabIndex = 10;
			this.ResetButton.Text = "Reset to Defaults";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.Location = new System.Drawing.Point(222, 481);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(80, 38);
			this.CancelBtn.TabIndex = 11;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 0;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ReshowDelay = 100;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "What is this?";
			// 
			// SoundSelect
			// 
			this.SoundSelect.FormattingEnabled = true;
			this.SoundSelect.Location = new System.Drawing.Point(158, 61);
			this.SoundSelect.Name = "SoundSelect";
			this.SoundSelect.Size = new System.Drawing.Size(222, 24);
			this.SoundSelect.TabIndex = 14;
			this.toolTip1.SetToolTip(this.SoundSelect, "The sound file to play when\r\na rest stop is first needed.");
			this.SoundSelect.SelectedIndexChanged += new System.EventHandler(this.SoundSelect_Change);
			this.SoundSelect.TextUpdate += new System.EventHandler(this.SoundSelect_Change);
			this.SoundSelect.Enter += new System.EventHandler(this.showTooltipOnFocus);
			this.SoundSelect.Leave += new System.EventHandler(this.hideTooltipOnBlur);
			// 
			// ReminderSoundSelect
			// 
			this.ReminderSoundSelect.FormattingEnabled = true;
			this.ReminderSoundSelect.Location = new System.Drawing.Point(158, 122);
			this.ReminderSoundSelect.Name = "ReminderSoundSelect";
			this.ReminderSoundSelect.Size = new System.Drawing.Size(222, 24);
			this.ReminderSoundSelect.TabIndex = 22;
			this.toolTip1.SetToolTip(this.ReminderSoundSelect, "The sound file to play when\r\nan extra reminder happens.");
			this.ReminderSoundSelect.SelectedIndexChanged += new System.EventHandler(this.ReminderSound_Change);
			this.ReminderSoundSelect.TextUpdate += new System.EventHandler(this.ReminderSound_Change);
			// 
			// startupCheckbox
			// 
			this.startupCheckbox.AutoSize = true;
			this.startupCheckbox.Location = new System.Drawing.Point(157, 29);
			this.startupCheckbox.Name = "startupCheckbox";
			this.startupCheckbox.Size = new System.Drawing.Size(147, 21);
			this.startupCheckbox.TabIndex = 23;
			this.startupCheckbox.Text = "Yes, run at startup";
			this.toolTip1.SetToolTip(this.startupCheckbox, "If checked, RestStop will start\r\nand run in the tray automatically\r\nwhen you turn" +
        " on your computer");
			this.startupCheckbox.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 64);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(119, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Rest Stop Sound:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// reminderIntervalPost
			// 
			this.reminderIntervalPost.AutoSize = true;
			this.reminderIntervalPost.Location = new System.Drawing.Point(262, 33);
			this.reminderIntervalPost.Name = "reminderIntervalPost";
			this.reminderIntervalPost.Size = new System.Drawing.Size(61, 17);
			this.reminderIntervalPost.TabIndex = 17;
			this.reminderIntervalPost.Text = "seconds";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(27, 33);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label9.Size = new System.Drawing.Size(123, 17);
			this.label9.TabIndex = 16;
			this.label9.Text = "Reminder Interval:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(26, 96);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label11.Size = new System.Drawing.Size(124, 17);
			this.label11.TabIndex = 19;
			this.label11.Text = "Show Notification?";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Behavior
			// 
			this.Behavior.Controls.Add(this.label14);
			this.Behavior.Controls.Add(this.startupCheckbox);
			this.Behavior.Controls.Add(this.restTimeRequired);
			this.Behavior.Controls.Add(this.label1);
			this.Behavior.Controls.Add(this.restTimeRequiredPost);
			this.Behavior.Controls.Add(this.numericUpDown3);
			this.Behavior.Controls.Add(this.label6);
			this.Behavior.Controls.Add(this.label5);
			this.Behavior.Location = new System.Drawing.Point(14, 13);
			this.Behavior.Name = "Behavior";
			this.Behavior.Size = new System.Drawing.Size(413, 131);
			this.Behavior.TabIndex = 21;
			this.Behavior.TabStop = false;
			this.Behavior.Text = "Behavior";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(11, 29);
			this.label14.Name = "label14";
			this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label14.Size = new System.Drawing.Size(138, 17);
			this.label14.TabIndex = 22;
			this.label14.Text = "Start With Windows?";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.workInterval);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.SoundSelect);
			this.groupBox1.Controls.Add(this.workIntervalPost);
			this.groupBox1.Location = new System.Drawing.Point(14, 153);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(413, 134);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rest Stop";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Webdings", 10F);
			this.button1.Location = new System.Drawing.Point(386, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "4";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.ReminderSoundSelect);
			this.groupBox2.Controls.Add(this.checkBox3);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.reminderInterval);
			this.groupBox2.Controls.Add(this.reminderIntervalPost);
			this.groupBox2.Location = new System.Drawing.Point(14, 293);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(413, 165);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Extra Reminders";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Font = new System.Drawing.Font("Webdings", 10F);
			this.button2.Location = new System.Drawing.Point(386, 122);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(21, 23);
			this.button2.TabIndex = 25;
			this.button2.Text = "4";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(32, 125);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label13.Size = new System.Drawing.Size(118, 17);
			this.label13.TabIndex = 21;
			this.label13.Text = "Reminder Sound:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(40, 92);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label12.Size = new System.Drawing.Size(109, 17);
			this.label12.TabIndex = 23;
			this.label12.Text = "Blink Tray Icon?";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(26, 62);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label10.Size = new System.Drawing.Size(124, 17);
			this.label10.TabIndex = 21;
			this.label10.Text = "Show Notification?";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = global::gazugafan.RestStop.Properties.Settings.Default.ReminderBlinkTrayIcon;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::gazugafan.RestStop.Properties.Settings.Default, "ReminderBlinkTrayIcon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox3.Location = new System.Drawing.Point(157, 92);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(149, 21);
			this.checkBox3.TabIndex = 24;
			this.checkBox3.Text = "Yes, blink tray icon";
			this.toolTip1.SetToolTip(this.checkBox3, "If checked, the tray icon will blink \r\nslowly after the first extra reminder");
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = global::gazugafan.RestStop.Properties.Settings.Default.ReminderToast;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::gazugafan.RestStop.Properties.Settings.Default, "ReminderToast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox2.Location = new System.Drawing.Point(158, 62);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(226, 21);
			this.checkBox2.TabIndex = 22;
			this.checkBox2.Text = "Yes, show reminder notification";
			this.toolTip1.SetToolTip(this.checkBox2, "If checked, a Windows toast\r\nnotification will be displayed\r\nwith each additional" +
        " reminder");
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// reminderInterval
			// 
			this.reminderInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::gazugafan.RestStop.Properties.Settings.Default, "ReminderInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.reminderInterval.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.reminderInterval.Location = new System.Drawing.Point(158, 31);
			this.reminderInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.reminderInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.reminderInterval.Name = "reminderInterval";
			this.reminderInterval.Size = new System.Drawing.Size(98, 22);
			this.reminderInterval.TabIndex = 15;
			this.toolTip1.SetToolTip(this.reminderInterval, "The number of seconds after a rest\r\nstop (or another reminder) is ignored\r\nto ini" +
        "tiate a reminder.");
			this.reminderInterval.Value = global::gazugafan.RestStop.Properties.Settings.Default.ReminderInterval;
			this.reminderInterval.ValueChanged += new System.EventHandler(this.UpdateMinutes);
			this.reminderInterval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpdateMinutes);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = global::gazugafan.RestStop.Properties.Settings.Default.ShowToast;
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::gazugafan.RestStop.Properties.Settings.Default, "ShowToast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox1.Location = new System.Drawing.Point(158, 96);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(225, 21);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Yes, show rest stop notification";
			this.toolTip1.SetToolTip(this.checkBox1, "If checked, a Windows toast\r\nnotification will be displayed\r\nwhen a rest stop is " +
        "first needed");
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// workInterval
			// 
			this.workInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::gazugafan.RestStop.Properties.Settings.Default, "WorkInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.workInterval.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.workInterval.Location = new System.Drawing.Point(158, 30);
			this.workInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.workInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.workInterval.Name = "workInterval";
			this.workInterval.Size = new System.Drawing.Size(98, 22);
			this.workInterval.TabIndex = 2;
			this.toolTip1.SetToolTip(this.workInterval, "How many seconds of continuous activity\r\nare allowed before a rest stop is recomm" +
        "ended.");
			this.workInterval.Value = global::gazugafan.RestStop.Properties.Settings.Default.WorkInterval;
			this.workInterval.ValueChanged += new System.EventHandler(this.UpdateMinutes);
			this.workInterval.Enter += new System.EventHandler(this.showTooltipOnFocus);
			this.workInterval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpdateMinutes);
			this.workInterval.Leave += new System.EventHandler(this.hideTooltipOnBlur);
			// 
			// restTimeRequired
			// 
			this.restTimeRequired.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::gazugafan.RestStop.Properties.Settings.Default, "SecondsBeforeRested", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.restTimeRequired.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.restTimeRequired.Location = new System.Drawing.Point(158, 60);
			this.restTimeRequired.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.restTimeRequired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.restTimeRequired.Name = "restTimeRequired";
			this.restTimeRequired.Size = new System.Drawing.Size(98, 22);
			this.restTimeRequired.TabIndex = 0;
			this.toolTip1.SetToolTip(this.restTimeRequired, "The number of seconds required before\r\nan inactive user is considered rested.");
			this.restTimeRequired.Value = global::gazugafan.RestStop.Properties.Settings.Default.SecondsBeforeRested;
			this.restTimeRequired.ValueChanged += new System.EventHandler(this.UpdateMinutes);
			this.restTimeRequired.Enter += new System.EventHandler(this.showTooltipOnFocus);
			this.restTimeRequired.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpdateMinutes);
			this.restTimeRequired.Leave += new System.EventHandler(this.hideTooltipOnBlur);
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::gazugafan.RestStop.Properties.Settings.Default, "MouseFuzz", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown3.Location = new System.Drawing.Point(158, 91);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(98, 22);
			this.numericUpDown3.TabIndex = 6;
			this.toolTip1.SetToolTip(this.numericUpDown3, "The mouse must move more than this in a\r\nshort period of time to be consider acti" +
        "ve.\r\n(key presses also count as activity)");
			this.numericUpDown3.Value = global::gazugafan.RestStop.Properties.Settings.Default.MouseFuzz;
			this.numericUpDown3.Enter += new System.EventHandler(this.showTooltipOnFocus);
			this.numericUpDown3.Leave += new System.EventHandler(this.hideTooltipOnBlur);
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.SaveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(439, 546);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Behavior);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.SaveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.Behavior.ResumeLayout(false);
			this.Behavior.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.reminderInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.restTimeRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown restTimeRequired;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown workInterval;
		private System.Windows.Forms.Label restTimeRequiredPost;
		private System.Windows.Forms.Label workIntervalPost;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox SoundSelect;
		private System.Windows.Forms.Label reminderIntervalPost;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown reminderInterval;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox Behavior;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox ReminderSoundSelect;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox startupCheckbox;
	}
}