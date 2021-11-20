
namespace betterAutostart
{
    partial class profilePanel
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
            this.btn_addBlankProfile = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_addBlankProfile
            // 
            this.btn_addBlankProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_addBlankProfile.FlatAppearance.BorderSize = 0;
            this.btn_addBlankProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBlankProfile.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.btn_addBlankProfile.ForeColor = System.Drawing.Color.White;
            this.btn_addBlankProfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_addBlankProfile.Location = new System.Drawing.Point(705, -7);
            this.btn_addBlankProfile.Name = "btn_addBlankProfile";
            this.btn_addBlankProfile.Size = new System.Drawing.Size(34, 41);
            this.btn_addBlankProfile.TabIndex = 1;
            this.btn_addBlankProfile.Text = "+";
            this.btn_addBlankProfile.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip.SetToolTip(this.btn_addBlankProfile, "Add a new blank Profile");
            this.btn_addBlankProfile.UseVisualStyleBackColor = false;
            this.btn_addBlankProfile.Click += new System.EventHandler(this.btn_addBlankProfile_Click);
            // 
            // profilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(751, 605);
            this.Controls.Add(this.btn_addBlankProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profilePanel";
            this.Text = "profilePanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addBlankProfile;
        private System.Windows.Forms.ToolTip toolTip;
    }
}