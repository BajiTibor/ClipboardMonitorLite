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
            this.Group_ClientConnections = new System.Windows.Forms.GroupBox();
            this.Group_AddNewConnection = new System.Windows.Forms.GroupBox();
            this.Group_RemoveConnection = new System.Windows.Forms.GroupBox();
            this.txt_ConnectedClients = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_AddConnection = new System.Windows.Forms.Button();
            this.Btn_TestConnection = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_PingConnection = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Group_ClientConnections.SuspendLayout();
            this.Group_AddNewConnection.SuspendLayout();
            this.Group_RemoveConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group_ClientConnections
            // 
            this.Group_ClientConnections.Controls.Add(this.txt_ConnectedClients);
            this.Group_ClientConnections.Location = new System.Drawing.Point(12, 12);
            this.Group_ClientConnections.Name = "Group_ClientConnections";
            this.Group_ClientConnections.Size = new System.Drawing.Size(518, 173);
            this.Group_ClientConnections.TabIndex = 0;
            this.Group_ClientConnections.TabStop = false;
            this.Group_ClientConnections.Text = "Connected Clients";
            // 
            // Group_AddNewConnection
            // 
            this.Group_AddNewConnection.Controls.Add(this.Btn_TestConnection);
            this.Group_AddNewConnection.Controls.Add(this.Btn_AddConnection);
            this.Group_AddNewConnection.Controls.Add(this.textBox1);
            this.Group_AddNewConnection.Location = new System.Drawing.Point(12, 191);
            this.Group_AddNewConnection.Name = "Group_AddNewConnection";
            this.Group_AddNewConnection.Size = new System.Drawing.Size(250, 110);
            this.Group_AddNewConnection.TabIndex = 1;
            this.Group_AddNewConnection.TabStop = false;
            this.Group_AddNewConnection.Text = "Add new connection";
            // 
            // Group_RemoveConnection
            // 
            this.Group_RemoveConnection.Controls.Add(this.Btn_Remove);
            this.Group_RemoveConnection.Controls.Add(this.Btn_PingConnection);
            this.Group_RemoveConnection.Controls.Add(this.comboBox1);
            this.Group_RemoveConnection.Location = new System.Drawing.Point(280, 191);
            this.Group_RemoveConnection.Name = "Group_RemoveConnection";
            this.Group_RemoveConnection.Size = new System.Drawing.Size(250, 110);
            this.Group_RemoveConnection.TabIndex = 2;
            this.Group_RemoveConnection.TabStop = false;
            this.Group_RemoveConnection.Text = "Remove a connected client";
            // 
            // txt_ConnectedClients
            // 
            this.txt_ConnectedClients.Location = new System.Drawing.Point(7, 22);
            this.txt_ConnectedClients.Name = "txt_ConnectedClients";
            this.txt_ConnectedClients.ReadOnly = true;
            this.txt_ConnectedClients.Size = new System.Drawing.Size(505, 145);
            this.txt_ConnectedClients.TabIndex = 0;
            this.txt_ConnectedClients.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Btn_AddConnection
            // 
            this.Btn_AddConnection.Location = new System.Drawing.Point(151, 63);
            this.Btn_AddConnection.Name = "Btn_AddConnection";
            this.Btn_AddConnection.Size = new System.Drawing.Size(93, 35);
            this.Btn_AddConnection.TabIndex = 1;
            this.Btn_AddConnection.Text = "Add";
            this.Btn_AddConnection.UseVisualStyleBackColor = true;
            // 
            // Btn_TestConnection
            // 
            this.Btn_TestConnection.Location = new System.Drawing.Point(7, 63);
            this.Btn_TestConnection.Name = "Btn_TestConnection";
            this.Btn_TestConnection.Size = new System.Drawing.Size(138, 35);
            this.Btn_TestConnection.TabIndex = 2;
            this.Btn_TestConnection.Text = "Test Connection";
            this.Btn_TestConnection.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Btn_PingConnection
            // 
            this.Btn_PingConnection.Location = new System.Drawing.Point(6, 63);
            this.Btn_PingConnection.Name = "Btn_PingConnection";
            this.Btn_PingConnection.Size = new System.Drawing.Size(124, 35);
            this.Btn_PingConnection.TabIndex = 1;
            this.Btn_PingConnection.Text = "Ping Device";
            this.Btn_PingConnection.UseVisualStyleBackColor = true;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(136, 63);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(108, 35);
            this.Btn_Remove.TabIndex = 2;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            // 
            // SetConnectedClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 313);
            this.Controls.Add(this.Group_RemoveConnection);
            this.Controls.Add(this.Group_AddNewConnection);
            this.Controls.Add(this.Group_ClientConnections);
            this.Name = "SetConnectedClients";
            this.Text = "SetConnectedClients";
            this.Group_ClientConnections.ResumeLayout(false);
            this.Group_AddNewConnection.ResumeLayout(false);
            this.Group_AddNewConnection.PerformLayout();
            this.Group_RemoveConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Group_ClientConnections;
        private System.Windows.Forms.RichTextBox txt_ConnectedClients;
        private System.Windows.Forms.GroupBox Group_AddNewConnection;
        private System.Windows.Forms.GroupBox Group_RemoveConnection;
        private System.Windows.Forms.Button Btn_TestConnection;
        private System.Windows.Forms.Button Btn_AddConnection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_PingConnection;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}