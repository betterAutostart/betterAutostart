
namespace betterAutostart.Application
{
    partial class executableAppPanel
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
            this.pnl_background = new System.Windows.Forms.Panel();
            this.lbl_txtBxError = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_eAttributes = new System.Windows.Forms.Label();
            this.btn_editPath = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.lbl_pathHeader = new System.Windows.Forms.Label();
            this.lbl_eNameMaxChars = new System.Windows.Forms.Label();
            this.lbl_eName = new System.Windows.Forms.Label();
            this.txtBx_eName = new System.Windows.Forms.TextBox();
            this.pnl_eAttributes = new System.Windows.Forms.Panel();
            this.chkBx_execAsAdmin = new System.Windows.Forms.CheckBox();
            this.btn_deleteExecutableApp = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.chkBx_autoRestart = new System.Windows.Forms.CheckBox();
            this.pnl_background.SuspendLayout();
            this.pnl_eAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnl_background.Controls.Add(this.lbl_txtBxError);
            this.pnl_background.Controls.Add(this.btn_exit);
            this.pnl_background.Controls.Add(this.lbl_eAttributes);
            this.pnl_background.Controls.Add(this.btn_editPath);
            this.pnl_background.Controls.Add(this.lbl_path);
            this.pnl_background.Controls.Add(this.lbl_pathHeader);
            this.pnl_background.Controls.Add(this.lbl_eNameMaxChars);
            this.pnl_background.Controls.Add(this.lbl_eName);
            this.pnl_background.Controls.Add(this.txtBx_eName);
            this.pnl_background.Controls.Add(this.pnl_eAttributes);
            this.pnl_background.Controls.Add(this.btn_deleteExecutableApp);
            this.pnl_background.Controls.Add(this.btn_saveChanges);
            this.pnl_background.Location = new System.Drawing.Point(2, 2);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(312, 370);
            this.pnl_background.TabIndex = 27;
            // 
            // lbl_txtBxError
            // 
            this.lbl_txtBxError.AutoSize = true;
            this.lbl_txtBxError.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lbl_txtBxError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_txtBxError.Location = new System.Drawing.Point(100, 19);
            this.lbl_txtBxError.Name = "lbl_txtBxError";
            this.lbl_txtBxError.Size = new System.Drawing.Size(66, 20);
            this.lbl_txtBxError.TabIndex = 38;
            this.lbl_txtBxError.Text = "lbl_errBx";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(287, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(25, 25);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_eAttributes
            // 
            this.lbl_eAttributes.AutoSize = true;
            this.lbl_eAttributes.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_eAttributes.ForeColor = System.Drawing.Color.White;
            this.lbl_eAttributes.Location = new System.Drawing.Point(-1, 216);
            this.lbl_eAttributes.Name = "lbl_eAttributes";
            this.lbl_eAttributes.Size = new System.Drawing.Size(101, 25);
            this.lbl_eAttributes.TabIndex = 35;
            this.lbl_eAttributes.Text = "Attributes";
            // 
            // btn_editPath
            // 
            this.btn_editPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_editPath.FlatAppearance.BorderSize = 0;
            this.btn_editPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editPath.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btn_editPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_editPath.Location = new System.Drawing.Point(3, 171);
            this.btn_editPath.Name = "btn_editPath";
            this.btn_editPath.Size = new System.Drawing.Size(75, 23);
            this.btn_editPath.TabIndex = 34;
            this.btn_editPath.Text = "Edit";
            this.btn_editPath.UseVisualStyleBackColor = false;
            this.btn_editPath.Click += new System.EventHandler(this.btn_editPath_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lbl_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_path.Location = new System.Drawing.Point(0, 139);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(166, 20);
            this.lbl_path.TabIndex = 33;
            this.lbl_path.Text = "C: \\\\user\\\\fortniteplayer";
            // 
            // lbl_pathHeader
            // 
            this.lbl_pathHeader.AutoSize = true;
            this.lbl_pathHeader.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_pathHeader.ForeColor = System.Drawing.Color.White;
            this.lbl_pathHeader.Location = new System.Drawing.Point(-1, 114);
            this.lbl_pathHeader.Name = "lbl_pathHeader";
            this.lbl_pathHeader.Size = new System.Drawing.Size(51, 25);
            this.lbl_pathHeader.TabIndex = 32;
            this.lbl_pathHeader.Text = "Path";
            // 
            // lbl_eNameMaxChars
            // 
            this.lbl_eNameMaxChars.AutoSize = true;
            this.lbl_eNameMaxChars.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lbl_eNameMaxChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_eNameMaxChars.Location = new System.Drawing.Point(-1, 69);
            this.lbl_eNameMaxChars.Name = "lbl_eNameMaxChars";
            this.lbl_eNameMaxChars.Size = new System.Drawing.Size(133, 20);
            this.lbl_eNameMaxChars.TabIndex = 31;
            this.lbl_eNameMaxChars.Text = "max. 16 Characters";
            // 
            // lbl_eName
            // 
            this.lbl_eName.AutoSize = true;
            this.lbl_eName.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_eName.ForeColor = System.Drawing.Color.White;
            this.lbl_eName.Location = new System.Drawing.Point(-1, 11);
            this.lbl_eName.Name = "lbl_eName";
            this.lbl_eName.Size = new System.Drawing.Size(64, 25);
            this.lbl_eName.TabIndex = 30;
            this.lbl_eName.Text = "Name";
            // 
            // txtBx_eName
            // 
            this.txtBx_eName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtBx_eName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_eName.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.txtBx_eName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBx_eName.Location = new System.Drawing.Point(4, 42);
            this.txtBx_eName.Name = "txtBx_eName";
            this.txtBx_eName.Size = new System.Drawing.Size(287, 24);
            this.txtBx_eName.TabIndex = 29;
            this.txtBx_eName.TextChanged += new System.EventHandler(this.txtBx_eName_TextChanged);
            // 
            // pnl_eAttributes
            // 
            this.pnl_eAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnl_eAttributes.Controls.Add(this.chkBx_autoRestart);
            this.pnl_eAttributes.Controls.Add(this.chkBx_execAsAdmin);
            this.pnl_eAttributes.Location = new System.Drawing.Point(4, 244);
            this.pnl_eAttributes.Name = "pnl_eAttributes";
            this.pnl_eAttributes.Size = new System.Drawing.Size(273, 77);
            this.pnl_eAttributes.TabIndex = 36;
            // 
            // chkBx_execAsAdmin
            // 
            this.chkBx_execAsAdmin.AutoSize = true;
            this.chkBx_execAsAdmin.FlatAppearance.BorderSize = 0;
            this.chkBx_execAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBx_execAsAdmin.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.chkBx_execAsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.chkBx_execAsAdmin.Location = new System.Drawing.Point(12, 13);
            this.chkBx_execAsAdmin.Name = "chkBx_execAsAdmin";
            this.chkBx_execAsAdmin.Size = new System.Drawing.Size(223, 29);
            this.chkBx_execAsAdmin.TabIndex = 1;
            this.chkBx_execAsAdmin.Text = "Execute as Administrator";
            this.chkBx_execAsAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_deleteExecutableApp
            // 
            this.btn_deleteExecutableApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_deleteExecutableApp.FlatAppearance.BorderSize = 0;
            this.btn_deleteExecutableApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteExecutableApp.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.btn_deleteExecutableApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_deleteExecutableApp.Location = new System.Drawing.Point(4, 333);
            this.btn_deleteExecutableApp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_deleteExecutableApp.Name = "btn_deleteExecutableApp";
            this.btn_deleteExecutableApp.Size = new System.Drawing.Size(127, 30);
            this.btn_deleteExecutableApp.TabIndex = 28;
            this.btn_deleteExecutableApp.Text = "Delete";
            this.btn_deleteExecutableApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_deleteExecutableApp.UseVisualStyleBackColor = false;
            this.btn_deleteExecutableApp.Click += new System.EventHandler(this.btn_deleteExecutableApp_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_saveChanges.FlatAppearance.BorderSize = 0;
            this.btn_saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveChanges.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.btn_saveChanges.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_saveChanges.Location = new System.Drawing.Point(178, 333);
            this.btn_saveChanges.Margin = new System.Windows.Forms.Padding(0);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(127, 30);
            this.btn_saveChanges.TabIndex = 27;
            this.btn_saveChanges.Text = "Save";
            this.btn_saveChanges.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // chkBx_autoRestart
            // 
            this.chkBx_autoRestart.AutoSize = true;
            this.chkBx_autoRestart.FlatAppearance.BorderSize = 0;
            this.chkBx_autoRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBx_autoRestart.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.chkBx_autoRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.chkBx_autoRestart.Location = new System.Drawing.Point(12, 45);
            this.chkBx_autoRestart.Name = "chkBx_autoRestart";
            this.chkBx_autoRestart.Size = new System.Drawing.Size(127, 29);
            this.chkBx_autoRestart.TabIndex = 2;
            this.chkBx_autoRestart.Text = "Auto Restart";
            this.chkBx_autoRestart.UseVisualStyleBackColor = true;
            // 
            // executableAppPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(316, 374);
            this.Controls.Add(this.pnl_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "executableAppPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "executableAppPanel";
            this.pnl_background.ResumeLayout(false);
            this.pnl_background.PerformLayout();
            this.pnl_eAttributes.ResumeLayout(false);
            this.pnl_eAttributes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_background;
        private System.Windows.Forms.Label lbl_txtBxError;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_eAttributes;
        private System.Windows.Forms.Button btn_editPath;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_pathHeader;
        private System.Windows.Forms.Label lbl_eNameMaxChars;
        private System.Windows.Forms.Label lbl_eName;
        private System.Windows.Forms.TextBox txtBx_eName;
        private System.Windows.Forms.Panel pnl_eAttributes;
        private System.Windows.Forms.CheckBox chkBx_execAsAdmin;
        private System.Windows.Forms.Button btn_deleteExecutableApp;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.CheckBox chkBx_autoRestart;
    }
}