
namespace betterAutostart
{
    partial class editProfilePanel
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
            this.txtBx_pName = new System.Windows.Forms.TextBox();
            this.lbl_pName = new System.Windows.Forms.Label();
            this.lbl_pExecutables = new System.Windows.Forms.Label();
            this.lbl_pAttributes = new System.Windows.Forms.Label();
            this.lstBx_pExecutables = new System.Windows.Forms.ListBox();
            this.pnl_pAttributes = new System.Windows.Forms.Panel();
            this.chkBx_execAsAdmin = new System.Windows.Forms.CheckBox();
            this.chkBx_autostartWSys = new System.Windows.Forms.CheckBox();
            this.pnl_hotkeySettings = new System.Windows.Forms.Panel();
            this.lbl_hotkeyStopAll = new System.Windows.Forms.Label();
            this.lbl_hotkeyStartAll = new System.Windows.Forms.Label();
            this.lbl_stopAllHotkey = new System.Windows.Forms.Label();
            this.lbl_startAllHotkey = new System.Windows.Forms.Label();
            this.lbl_pHotkeySettings = new System.Windows.Forms.Label();
            this.lbl_pNameMaxChars = new System.Windows.Forms.Label();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_deleteProfile = new System.Windows.Forms.Button();
            this.btn_addNewExecutable = new System.Windows.Forms.Button();
            this.lbl_txtBxError = new System.Windows.Forms.Label();
            this.pnl_pAttributes.SuspendLayout();
            this.pnl_hotkeySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBx_pName
            // 
            this.txtBx_pName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtBx_pName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_pName.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.txtBx_pName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBx_pName.Location = new System.Drawing.Point(12, 39);
            this.txtBx_pName.Name = "txtBx_pName";
            this.txtBx_pName.Size = new System.Drawing.Size(287, 24);
            this.txtBx_pName.TabIndex = 1;
            this.txtBx_pName.TextChanged += new System.EventHandler(this.txtBx_pName_TextChanged);
            // 
            // lbl_pName
            // 
            this.lbl_pName.AutoSize = true;
            this.lbl_pName.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_pName.ForeColor = System.Drawing.Color.White;
            this.lbl_pName.Location = new System.Drawing.Point(7, 8);
            this.lbl_pName.Name = "lbl_pName";
            this.lbl_pName.Size = new System.Drawing.Size(64, 25);
            this.lbl_pName.TabIndex = 2;
            this.lbl_pName.Text = "Name";
            // 
            // lbl_pExecutables
            // 
            this.lbl_pExecutables.AutoSize = true;
            this.lbl_pExecutables.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_pExecutables.ForeColor = System.Drawing.Color.White;
            this.lbl_pExecutables.Location = new System.Drawing.Point(7, 113);
            this.lbl_pExecutables.Name = "lbl_pExecutables";
            this.lbl_pExecutables.Size = new System.Drawing.Size(116, 25);
            this.lbl_pExecutables.TabIndex = 4;
            this.lbl_pExecutables.Text = "Executables";
            // 
            // lbl_pAttributes
            // 
            this.lbl_pAttributes.AutoSize = true;
            this.lbl_pAttributes.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_pAttributes.ForeColor = System.Drawing.Color.White;
            this.lbl_pAttributes.Location = new System.Drawing.Point(7, 384);
            this.lbl_pAttributes.Name = "lbl_pAttributes";
            this.lbl_pAttributes.Size = new System.Drawing.Size(101, 25);
            this.lbl_pAttributes.TabIndex = 6;
            this.lbl_pAttributes.Text = "Attributes";
            // 
            // lstBx_pExecutables
            // 
            this.lstBx_pExecutables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lstBx_pExecutables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBx_pExecutables.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.lstBx_pExecutables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lstBx_pExecutables.FormattingEnabled = true;
            this.lstBx_pExecutables.ItemHeight = 23;
            this.lstBx_pExecutables.Location = new System.Drawing.Point(12, 150);
            this.lstBx_pExecutables.Name = "lstBx_pExecutables";
            this.lstBx_pExecutables.Size = new System.Drawing.Size(727, 184);
            this.lstBx_pExecutables.TabIndex = 7;
            this.lstBx_pExecutables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBx_pExecutables_MouseDown);
            // 
            // pnl_pAttributes
            // 
            this.pnl_pAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnl_pAttributes.Controls.Add(this.chkBx_execAsAdmin);
            this.pnl_pAttributes.Controls.Add(this.chkBx_autostartWSys);
            this.pnl_pAttributes.Location = new System.Drawing.Point(12, 423);
            this.pnl_pAttributes.Name = "pnl_pAttributes";
            this.pnl_pAttributes.Size = new System.Drawing.Size(282, 124);
            this.pnl_pAttributes.TabIndex = 8;
            // 
            // chkBx_execAsAdmin
            // 
            this.chkBx_execAsAdmin.AutoSize = true;
            this.chkBx_execAsAdmin.FlatAppearance.BorderSize = 0;
            this.chkBx_execAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBx_execAsAdmin.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.chkBx_execAsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.chkBx_execAsAdmin.Location = new System.Drawing.Point(13, 49);
            this.chkBx_execAsAdmin.Name = "chkBx_execAsAdmin";
            this.chkBx_execAsAdmin.Size = new System.Drawing.Size(223, 29);
            this.chkBx_execAsAdmin.TabIndex = 1;
            this.chkBx_execAsAdmin.Text = "Execute as Administrator";
            this.chkBx_execAsAdmin.UseVisualStyleBackColor = true;
            // 
            // chkBx_autostartWSys
            // 
            this.chkBx_autostartWSys.AutoSize = true;
            this.chkBx_autostartWSys.FlatAppearance.BorderSize = 0;
            this.chkBx_autostartWSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBx_autostartWSys.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.chkBx_autostartWSys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.chkBx_autostartWSys.Location = new System.Drawing.Point(13, 14);
            this.chkBx_autostartWSys.Name = "chkBx_autostartWSys";
            this.chkBx_autostartWSys.Size = new System.Drawing.Size(204, 29);
            this.chkBx_autostartWSys.TabIndex = 0;
            this.chkBx_autostartWSys.Text = "Autostart with System";
            this.chkBx_autostartWSys.UseVisualStyleBackColor = true;
            // 
            // pnl_hotkeySettings
            // 
            this.pnl_hotkeySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnl_hotkeySettings.Controls.Add(this.lbl_hotkeyStopAll);
            this.pnl_hotkeySettings.Controls.Add(this.lbl_hotkeyStartAll);
            this.pnl_hotkeySettings.Controls.Add(this.lbl_stopAllHotkey);
            this.pnl_hotkeySettings.Controls.Add(this.lbl_startAllHotkey);
            this.pnl_hotkeySettings.Location = new System.Drawing.Point(457, 423);
            this.pnl_hotkeySettings.Name = "pnl_hotkeySettings";
            this.pnl_hotkeySettings.Size = new System.Drawing.Size(282, 124);
            this.pnl_hotkeySettings.TabIndex = 10;
            // 
            // lbl_hotkeyStopAll
            // 
            this.lbl_hotkeyStopAll.AutoSize = true;
            this.lbl_hotkeyStopAll.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_hotkeyStopAll.ForeColor = System.Drawing.Color.White;
            this.lbl_hotkeyStopAll.Location = new System.Drawing.Point(15, 68);
            this.lbl_hotkeyStopAll.Name = "lbl_hotkeyStopAll";
            this.lbl_hotkeyStopAll.Size = new System.Drawing.Size(61, 20);
            this.lbl_hotkeyStopAll.TabIndex = 12;
            this.lbl_hotkeyStopAll.Text = "Stop all";
            // 
            // lbl_hotkeyStartAll
            // 
            this.lbl_hotkeyStartAll.AutoSize = true;
            this.lbl_hotkeyStartAll.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_hotkeyStartAll.ForeColor = System.Drawing.Color.White;
            this.lbl_hotkeyStartAll.Location = new System.Drawing.Point(15, 9);
            this.lbl_hotkeyStartAll.Name = "lbl_hotkeyStartAll";
            this.lbl_hotkeyStartAll.Size = new System.Drawing.Size(63, 20);
            this.lbl_hotkeyStartAll.TabIndex = 11;
            this.lbl_hotkeyStartAll.Text = "Start all";
            // 
            // lbl_stopAllHotkey
            // 
            this.lbl_stopAllHotkey.AutoSize = true;
            this.lbl_stopAllHotkey.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.lbl_stopAllHotkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_stopAllHotkey.Location = new System.Drawing.Point(14, 82);
            this.lbl_stopAllHotkey.Name = "lbl_stopAllHotkey";
            this.lbl_stopAllHotkey.Size = new System.Drawing.Size(44, 25);
            this.lbl_stopAllHotkey.TabIndex = 1;
            this.lbl_stopAllHotkey.Text = "WIP";
            // 
            // lbl_startAllHotkey
            // 
            this.lbl_startAllHotkey.AutoSize = true;
            this.lbl_startAllHotkey.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.lbl_startAllHotkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_startAllHotkey.Location = new System.Drawing.Point(14, 29);
            this.lbl_startAllHotkey.Name = "lbl_startAllHotkey";
            this.lbl_startAllHotkey.Size = new System.Drawing.Size(44, 25);
            this.lbl_startAllHotkey.TabIndex = 0;
            this.lbl_startAllHotkey.Text = "WIP";
            // 
            // lbl_pHotkeySettings
            // 
            this.lbl_pHotkeySettings.AutoSize = true;
            this.lbl_pHotkeySettings.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_pHotkeySettings.ForeColor = System.Drawing.Color.White;
            this.lbl_pHotkeySettings.Location = new System.Drawing.Point(452, 384);
            this.lbl_pHotkeySettings.Name = "lbl_pHotkeySettings";
            this.lbl_pHotkeySettings.Size = new System.Drawing.Size(154, 25);
            this.lbl_pHotkeySettings.TabIndex = 9;
            this.lbl_pHotkeySettings.Text = "Hotkey Settings";
            // 
            // lbl_pNameMaxChars
            // 
            this.lbl_pNameMaxChars.AutoSize = true;
            this.lbl_pNameMaxChars.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lbl_pNameMaxChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_pNameMaxChars.Location = new System.Drawing.Point(7, 66);
            this.lbl_pNameMaxChars.Name = "lbl_pNameMaxChars";
            this.lbl_pNameMaxChars.Size = new System.Drawing.Size(133, 20);
            this.lbl_pNameMaxChars.TabIndex = 13;
            this.lbl_pNameMaxChars.Text = "max. 16 Characters";
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_saveChanges.FlatAppearance.BorderSize = 0;
            this.btn_saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveChanges.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.btn_saveChanges.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_saveChanges.Location = new System.Drawing.Point(615, 566);
            this.btn_saveChanges.Margin = new System.Windows.Forms.Padding(0);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(127, 30);
            this.btn_saveChanges.TabIndex = 14;
            this.btn_saveChanges.Text = "Save";
            this.btn_saveChanges.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_deleteProfile
            // 
            this.btn_deleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_deleteProfile.FlatAppearance.BorderSize = 0;
            this.btn_deleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteProfile.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.btn_deleteProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_deleteProfile.Location = new System.Drawing.Point(12, 566);
            this.btn_deleteProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btn_deleteProfile.Name = "btn_deleteProfile";
            this.btn_deleteProfile.Size = new System.Drawing.Size(143, 30);
            this.btn_deleteProfile.TabIndex = 15;
            this.btn_deleteProfile.Text = "Delete Profile";
            this.btn_deleteProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_deleteProfile.UseVisualStyleBackColor = false;
            this.btn_deleteProfile.Click += new System.EventHandler(this.btn_deleteProfile_Click);
            // 
            // btn_addNewExecutable
            // 
            this.btn_addNewExecutable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_addNewExecutable.FlatAppearance.BorderSize = 0;
            this.btn_addNewExecutable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNewExecutable.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.btn_addNewExecutable.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_addNewExecutable.Location = new System.Drawing.Point(612, 337);
            this.btn_addNewExecutable.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addNewExecutable.Name = "btn_addNewExecutable";
            this.btn_addNewExecutable.Size = new System.Drawing.Size(127, 30);
            this.btn_addNewExecutable.TabIndex = 16;
            this.btn_addNewExecutable.Text = "Add new";
            this.btn_addNewExecutable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addNewExecutable.UseVisualStyleBackColor = false;
            this.btn_addNewExecutable.Click += new System.EventHandler(this.btn_addNewExecutable_Click);
            // 
            // lbl_txtBxError
            // 
            this.lbl_txtBxError.AutoSize = true;
            this.lbl_txtBxError.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lbl_txtBxError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_txtBxError.Location = new System.Drawing.Point(305, 41);
            this.lbl_txtBxError.Name = "lbl_txtBxError";
            this.lbl_txtBxError.Size = new System.Drawing.Size(66, 20);
            this.lbl_txtBxError.TabIndex = 13;
            this.lbl_txtBxError.Text = "lbl_errBx";
            // 
            // editProfilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(751, 605);
            this.Controls.Add(this.lbl_txtBxError);
            this.Controls.Add(this.btn_addNewExecutable);
            this.Controls.Add(this.btn_deleteProfile);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.lbl_pNameMaxChars);
            this.Controls.Add(this.pnl_hotkeySettings);
            this.Controls.Add(this.lbl_pHotkeySettings);
            this.Controls.Add(this.pnl_pAttributes);
            this.Controls.Add(this.lstBx_pExecutables);
            this.Controls.Add(this.lbl_pAttributes);
            this.Controls.Add(this.lbl_pExecutables);
            this.Controls.Add(this.lbl_pName);
            this.Controls.Add(this.txtBx_pName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editProfilePanel";
            this.Text = "editProfilePanel";
            this.pnl_pAttributes.ResumeLayout(false);
            this.pnl_pAttributes.PerformLayout();
            this.pnl_hotkeySettings.ResumeLayout(false);
            this.pnl_hotkeySettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBx_pName;
        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.Label lbl_pExecutables;
        private System.Windows.Forms.Label lbl_pAttributes;
        private System.Windows.Forms.ListBox lstBx_pExecutables;
        private System.Windows.Forms.Panel pnl_pAttributes;
        private System.Windows.Forms.CheckBox chkBx_execAsAdmin;
        private System.Windows.Forms.CheckBox chkBx_autostartWSys;
        private System.Windows.Forms.Panel pnl_hotkeySettings;
        private System.Windows.Forms.Label lbl_pHotkeySettings;
        private System.Windows.Forms.Label lbl_stopAllHotkey;
        private System.Windows.Forms.Label lbl_startAllHotkey;
        private System.Windows.Forms.Label lbl_hotkeyStopAll;
        private System.Windows.Forms.Label lbl_hotkeyStartAll;
        private System.Windows.Forms.Label lbl_pNameMaxChars;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_deleteProfile;
        private System.Windows.Forms.Button btn_addNewExecutable;
        private System.Windows.Forms.Label lbl_txtBxError;
    }
}