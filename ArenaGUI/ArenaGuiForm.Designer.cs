namespace ArenaGUI
{
    partial class ArenaGuiForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.programArgumentsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectProgramButton = new System.Windows.Forms.Button();
            this.evilArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.environmentArgumentsLabel = new System.Windows.Forms.Label();
            this.playerArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.playerArgumentsLabel = new System.Windows.Forms.Label();
            this.extraArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.extraArgumentsLabel = new System.Windows.Forms.Label();
            this.debugModeCheckBox = new System.Windows.Forms.CheckBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.recordGroupBox = new System.Windows.Forms.GroupBox();
            this.recordRichTextBox = new System.Windows.Forms.RichTextBox();
            this.messageGroupBox = new System.Windows.Forms.GroupBox();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.commandGroupBox = new System.Windows.Forms.GroupBox();
            this.sendCommandButton = new System.Windows.Forms.Button();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.evilNameLabel = new System.Windows.Forms.Label();
            this.evilNameTextBox = new System.Windows.Forms.TextBox();
            this.playNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.playNameTextBox = new System.Windows.Forms.TextBox();
            this.renameGroupBox = new System.Windows.Forms.GroupBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.statusButton = new System.Windows.Forms.Button();
            this.programOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.connectionSettingGroupBox.SuspendLayout();
            this.programArgumentsGroupBox.SuspendLayout();
            this.recordGroupBox.SuspendLayout();
            this.messageGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.commandGroupBox.SuspendLayout();
            this.registerGroupBox.SuspendLayout();
            this.renameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionSettingGroupBox
            // 
            this.connectionSettingGroupBox.Controls.Add(this.portTextBox);
            this.connectionSettingGroupBox.Controls.Add(this.portLabel);
            this.connectionSettingGroupBox.Controls.Add(this.ipTextBox);
            this.connectionSettingGroupBox.Controls.Add(this.ipLabel);
            this.connectionSettingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.connectionSettingGroupBox.Name = "connectionSettingGroupBox";
            this.connectionSettingGroupBox.Size = new System.Drawing.Size(184, 87);
            this.connectionSettingGroupBox.TabIndex = 1;
            this.connectionSettingGroupBox.TabStop = false;
            this.connectionSettingGroupBox.Text = "連線設定";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(35, 45);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(137, 22);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "10000";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(7, 50);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(27, 12);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(35, 17);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(137, 22);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "140.113.86.124";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(7, 22);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(18, 12);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP:";
            // 
            // programArgumentsGroupBox
            // 
            this.programArgumentsGroupBox.Controls.Add(this.selectProgramButton);
            this.programArgumentsGroupBox.Controls.Add(this.evilArgumentsTextBox);
            this.programArgumentsGroupBox.Controls.Add(this.environmentArgumentsLabel);
            this.programArgumentsGroupBox.Controls.Add(this.playerArgumentsTextBox);
            this.programArgumentsGroupBox.Controls.Add(this.playerArgumentsLabel);
            this.programArgumentsGroupBox.Controls.Add(this.extraArgumentsTextBox);
            this.programArgumentsGroupBox.Controls.Add(this.extraArgumentsLabel);
            this.programArgumentsGroupBox.Controls.Add(this.debugModeCheckBox);
            this.programArgumentsGroupBox.Location = new System.Drawing.Point(202, 12);
            this.programArgumentsGroupBox.Name = "programArgumentsGroupBox";
            this.programArgumentsGroupBox.Size = new System.Drawing.Size(756, 87);
            this.programArgumentsGroupBox.TabIndex = 2;
            this.programArgumentsGroupBox.TabStop = false;
            this.programArgumentsGroupBox.Text = "程式參數";
            // 
            // selectProgramButton
            // 
            this.selectProgramButton.Location = new System.Drawing.Point(91, 16);
            this.selectProgramButton.Name = "selectProgramButton";
            this.selectProgramButton.Size = new System.Drawing.Size(88, 23);
            this.selectProgramButton.TabIndex = 8;
            this.selectProgramButton.Text = "選擇執行檔";
            this.selectProgramButton.UseVisualStyleBackColor = true;
            this.selectProgramButton.Click += new System.EventHandler(this.selectProgramButton_Click);
            // 
            // evilArgumentsTextBox
            // 
            this.evilArgumentsTextBox.Location = new System.Drawing.Point(276, 48);
            this.evilArgumentsTextBox.Name = "evilArgumentsTextBox";
            this.evilArgumentsTextBox.Size = new System.Drawing.Size(467, 22);
            this.evilArgumentsTextBox.TabIndex = 7;
            this.evilArgumentsTextBox.Text = "load=new_weight3_4000000_0001 search=1 ex_tile=1 name=DSphantasm_v3";
            // 
            // environmentArgumentsLabel
            // 
            this.environmentArgumentsLabel.AutoSize = true;
            this.environmentArgumentsLabel.Location = new System.Drawing.Point(185, 53);
            this.environmentArgumentsLabel.Name = "environmentArgumentsLabel";
            this.environmentArgumentsLabel.Size = new System.Drawing.Size(81, 12);
            this.environmentArgumentsLabel.TabIndex = 6;
            this.environmentArgumentsLabel.Text = "Evil Arguments:";
            // 
            // playerArgumentsTextBox
            // 
            this.playerArgumentsTextBox.Location = new System.Drawing.Point(276, 15);
            this.playerArgumentsTextBox.Name = "playerArgumentsTextBox";
            this.playerArgumentsTextBox.Size = new System.Drawing.Size(467, 22);
            this.playerArgumentsTextBox.TabIndex = 5;
            this.playerArgumentsTextBox.Text = "alpha=0 load=new_weight3_4000000_0001 search=1 name=DSzenith_v3";
            // 
            // playerArgumentsLabel
            // 
            this.playerArgumentsLabel.AutoSize = true;
            this.playerArgumentsLabel.Location = new System.Drawing.Point(185, 20);
            this.playerArgumentsLabel.Name = "playerArgumentsLabel";
            this.playerArgumentsLabel.Size = new System.Drawing.Size(91, 12);
            this.playerArgumentsLabel.TabIndex = 4;
            this.playerArgumentsLabel.Text = "Player Arguments:";
            // 
            // extraArgumentsTextBox
            // 
            this.extraArgumentsTextBox.Location = new System.Drawing.Point(6, 54);
            this.extraArgumentsTextBox.Name = "extraArgumentsTextBox";
            this.extraArgumentsTextBox.Size = new System.Drawing.Size(170, 22);
            this.extraArgumentsTextBox.TabIndex = 2;
            this.extraArgumentsTextBox.Text = "--shell";
            // 
            // extraArgumentsLabel
            // 
            this.extraArgumentsLabel.AutoSize = true;
            this.extraArgumentsLabel.Location = new System.Drawing.Point(6, 39);
            this.extraArgumentsLabel.Name = "extraArgumentsLabel";
            this.extraArgumentsLabel.Size = new System.Drawing.Size(56, 12);
            this.extraArgumentsLabel.TabIndex = 1;
            this.extraArgumentsLabel.Text = "額外參數:";
            // 
            // debugModeCheckBox
            // 
            this.debugModeCheckBox.AutoSize = true;
            this.debugModeCheckBox.Location = new System.Drawing.Point(6, 17);
            this.debugModeCheckBox.Name = "debugModeCheckBox";
            this.debugModeCheckBox.Size = new System.Drawing.Size(55, 16);
            this.debugModeCheckBox.TabIndex = 0;
            this.debugModeCheckBox.Text = "Debug";
            this.debugModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.SystemColors.Control;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.launchButton.Location = new System.Drawing.Point(790, 124);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(69, 35);
            this.launchButton.TabIndex = 3;
            this.launchButton.Text = "啟動";
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resetButton.Location = new System.Drawing.Point(889, 124);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(69, 35);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "重設";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // recordGroupBox
            // 
            this.recordGroupBox.Controls.Add(this.recordRichTextBox);
            this.recordGroupBox.Location = new System.Drawing.Point(12, 105);
            this.recordGroupBox.Name = "recordGroupBox";
            this.recordGroupBox.Size = new System.Drawing.Size(766, 113);
            this.recordGroupBox.TabIndex = 5;
            this.recordGroupBox.TabStop = false;
            this.recordGroupBox.Text = "歷史戰績";
            // 
            // recordRichTextBox
            // 
            this.recordRichTextBox.Location = new System.Drawing.Point(11, 19);
            this.recordRichTextBox.Name = "recordRichTextBox";
            this.recordRichTextBox.ReadOnly = true;
            this.recordRichTextBox.Size = new System.Drawing.Size(749, 88);
            this.recordRichTextBox.TabIndex = 0;
            this.recordRichTextBox.Text = "";
            // 
            // messageGroupBox
            // 
            this.messageGroupBox.Controls.Add(this.messageRichTextBox);
            this.messageGroupBox.Location = new System.Drawing.Point(12, 224);
            this.messageGroupBox.Name = "messageGroupBox";
            this.messageGroupBox.Size = new System.Drawing.Size(766, 309);
            this.messageGroupBox.TabIndex = 6;
            this.messageGroupBox.TabStop = false;
            this.messageGroupBox.Text = "訊息視窗";
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Location = new System.Drawing.Point(11, 19);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.ReadOnly = true;
            this.messageRichTextBox.Size = new System.Drawing.Size(749, 284);
            this.messageRichTextBox.TabIndex = 0;
            this.messageRichTextBox.Text = "";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.commandGroupBox);
            this.controlGroupBox.Controls.Add(this.registerGroupBox);
            this.controlGroupBox.Controls.Add(this.renameGroupBox);
            this.controlGroupBox.Controls.Add(this.statusButton);
            this.controlGroupBox.Enabled = false;
            this.controlGroupBox.Location = new System.Drawing.Point(784, 179);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(174, 354);
            this.controlGroupBox.TabIndex = 7;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "控制面板";
            // 
            // commandGroupBox
            // 
            this.commandGroupBox.Controls.Add(this.sendCommandButton);
            this.commandGroupBox.Controls.Add(this.commandTextBox);
            this.commandGroupBox.Location = new System.Drawing.Point(6, 265);
            this.commandGroupBox.Name = "commandGroupBox";
            this.commandGroupBox.Size = new System.Drawing.Size(161, 82);
            this.commandGroupBox.TabIndex = 9;
            this.commandGroupBox.TabStop = false;
            this.commandGroupBox.Text = "指令";
            // 
            // sendCommandButton
            // 
            this.sendCommandButton.BackColor = System.Drawing.SystemColors.Control;
            this.sendCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendCommandButton.Location = new System.Drawing.Point(39, 49);
            this.sendCommandButton.Name = "sendCommandButton";
            this.sendCommandButton.Size = new System.Drawing.Size(84, 23);
            this.sendCommandButton.TabIndex = 8;
            this.sendCommandButton.Text = "送出";
            this.sendCommandButton.UseVisualStyleBackColor = false;
            this.sendCommandButton.Click += new System.EventHandler(this.sendCommandButton_Click);
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(8, 21);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(147, 22);
            this.commandTextBox.TabIndex = 0;
            this.commandTextBox.Text = "match open DSzenith_v3:DSphantasm_v3";
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Controls.Add(this.evilNameLabel);
            this.registerGroupBox.Controls.Add(this.evilNameTextBox);
            this.registerGroupBox.Controls.Add(this.playNameLabel);
            this.registerGroupBox.Controls.Add(this.button1);
            this.registerGroupBox.Controls.Add(this.playNameTextBox);
            this.registerGroupBox.Location = new System.Drawing.Point(6, 145);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Size = new System.Drawing.Size(161, 114);
            this.registerGroupBox.TabIndex = 9;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "註冊";
            // 
            // evilNameLabel
            // 
            this.evilNameLabel.AutoSize = true;
            this.evilNameLabel.Location = new System.Drawing.Point(6, 49);
            this.evilNameLabel.Name = "evilNameLabel";
            this.evilNameLabel.Size = new System.Drawing.Size(28, 12);
            this.evilNameLabel.TabIndex = 11;
            this.evilNameLabel.Text = "evil: ";
            // 
            // evilNameTextBox
            // 
            this.evilNameTextBox.Location = new System.Drawing.Point(43, 46);
            this.evilNameTextBox.Name = "evilNameTextBox";
            this.evilNameTextBox.Size = new System.Drawing.Size(112, 22);
            this.evilNameTextBox.TabIndex = 10;
            this.evilNameTextBox.Text = "DSphantasm_v3";
            // 
            // playNameLabel
            // 
            this.playNameLabel.AutoSize = true;
            this.playNameLabel.Location = new System.Drawing.Point(6, 24);
            this.playNameLabel.Name = "playNameLabel";
            this.playNameLabel.Size = new System.Drawing.Size(31, 12);
            this.playNameLabel.TabIndex = 9;
            this.playNameLabel.Text = "play: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(35, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playNameTextBox
            // 
            this.playNameTextBox.Location = new System.Drawing.Point(43, 21);
            this.playNameTextBox.Name = "playNameTextBox";
            this.playNameTextBox.Size = new System.Drawing.Size(112, 22);
            this.playNameTextBox.TabIndex = 0;
            this.playNameTextBox.Text = "DSzenith_v3";
            // 
            // renameGroupBox
            // 
            this.renameGroupBox.Controls.Add(this.renameButton);
            this.renameGroupBox.Controls.Add(this.usernameTextBox);
            this.renameGroupBox.Location = new System.Drawing.Point(6, 61);
            this.renameGroupBox.Name = "renameGroupBox";
            this.renameGroupBox.Size = new System.Drawing.Size(161, 78);
            this.renameGroupBox.TabIndex = 1;
            this.renameGroupBox.TabStop = false;
            this.renameGroupBox.Text = "更名";
            // 
            // renameButton
            // 
            this.renameButton.BackColor = System.Drawing.SystemColors.Control;
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.renameButton.Location = new System.Drawing.Point(39, 49);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(84, 23);
            this.renameButton.TabIndex = 8;
            this.renameButton.Text = "確認";
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(8, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(147, 22);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "Heptagram";
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(6, 21);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(162, 34);
            this.statusButton.TabIndex = 0;
            this.statusButton.Text = "Status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // ArenaGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 545);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.messageGroupBox);
            this.Controls.Add(this.recordGroupBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.programArgumentsGroupBox);
            this.Controls.Add(this.connectionSettingGroupBox);
            this.Name = "ArenaGuiForm";
            this.Text = "ArenaGUI";
            this.connectionSettingGroupBox.ResumeLayout(false);
            this.connectionSettingGroupBox.PerformLayout();
            this.programArgumentsGroupBox.ResumeLayout(false);
            this.programArgumentsGroupBox.PerformLayout();
            this.recordGroupBox.ResumeLayout(false);
            this.messageGroupBox.ResumeLayout(false);
            this.controlGroupBox.ResumeLayout(false);
            this.commandGroupBox.ResumeLayout(false);
            this.commandGroupBox.PerformLayout();
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.renameGroupBox.ResumeLayout(false);
            this.renameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionSettingGroupBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.GroupBox programArgumentsGroupBox;
        private System.Windows.Forms.CheckBox debugModeCheckBox;
        private System.Windows.Forms.TextBox extraArgumentsTextBox;
        private System.Windows.Forms.Label extraArgumentsLabel;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.TextBox evilArgumentsTextBox;
        private System.Windows.Forms.Label environmentArgumentsLabel;
        private System.Windows.Forms.TextBox playerArgumentsTextBox;
        private System.Windows.Forms.Label playerArgumentsLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox recordGroupBox;
        private System.Windows.Forms.RichTextBox recordRichTextBox;
        private System.Windows.Forms.GroupBox messageGroupBox;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.GroupBox renameGroupBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox commandGroupBox;
        private System.Windows.Forms.Button sendCommandButton;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.Label evilNameLabel;
        private System.Windows.Forms.TextBox evilNameTextBox;
        private System.Windows.Forms.Label playNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox playNameTextBox;
        private System.Windows.Forms.Button selectProgramButton;
        private System.Windows.Forms.OpenFileDialog programOpenFileDialog;
    }
}

