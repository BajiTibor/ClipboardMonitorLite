namespace ClipboardMonitorLite
{
    partial class SetConnectedClients
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
            this.Group_GroupSettings = new System.Windows.Forms.GroupBox();
            this.txt_GroupId = new System.Windows.Forms.TextBox();
            this.Label_GroupId = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Group_GroupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group_GroupSettings
            // 
            this.Group_GroupSettings.Controls.Add(this.Btn_Generate);
            this.Group_GroupSettings.Controls.Add(this.Btn_ShowPassword);
            this.Group_GroupSettings.Controls.Add(this.Btn_Update);
            this.Group_GroupSettings.Controls.Add(this.Label_Password);
            this.Group_GroupSettings.Controls.Add(this.txt_Password);
            this.Group_GroupSettings.Controls.Add(this.Label_GroupId);
            this.Group_GroupSettings.Controls.Add(this.txt_GroupId);
            this.Group_GroupSettings.Location = new System.Drawing.Point(12, 12);
            this.Group_GroupSettings.Name = "Group_GroupSettings";
            this.Group_GroupSettings.Size = new System.Drawing.Size(315, 171);
            this.Group_GroupSettings.TabIndex = 0;
            this.Group_GroupSettings.TabStop = false;
            this.Group_GroupSettings.Text = "Connections";
            // 
            // txt_GroupId
            // 
            this.txt_GroupId.Location = new System.Drawing.Point(6, 47);
            this.txt_GroupId.Name = "txt_GroupId";
            this.txt_GroupId.Size = new System.Drawing.Size(222, 22);
            this.txt_GroupId.TabIndex = 0;
            // 
            // Label_GroupId
            // 
            this.Label_GroupId.AutoSize = true;
            this.Label_GroupId.Location = new System.Drawing.Point(6, 27);
            this.Label_GroupId.Name = "Label_GroupId";
            this.Label_GroupId.Size = new System.Drawing.Size(138, 17);
            this.Label_GroupId.TabIndex = 1;
            this.Label_GroupId.Text = "Username (GroupId)";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(6, 103);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(222, 22);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(6, 83);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(69, 17);
            this.Label_Password.TabIndex = 3;
            this.Label_Password.Text = "Password";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(6, 135);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(80, 30);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.Location = new System.Drawing.Point(234, 93);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(70, 40);
            this.Btn_ShowPassword.TabIndex = 5;
            this.Btn_ShowPassword.Text = "Show";
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(234, 38);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(70, 40);
            this.Btn_Generate.TabIndex = 6;
            this.Btn_Generate.Text = "Random";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            // 
            // SetConnectedClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 192);
            this.Controls.Add(this.Group_GroupSettings);
            this.Name = "SetConnectedClients";
            this.Text = "SetConnectedClients";
            this.Group_GroupSettings.ResumeLayout(false);
            this.Group_GroupSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Group_GroupSettings;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label Label_GroupId;
        private System.Windows.Forms.TextBox txt_GroupId;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Button Btn_ShowPassword;
    }
}