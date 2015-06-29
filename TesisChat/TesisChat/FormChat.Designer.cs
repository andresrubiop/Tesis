namespace TesisChat
{
    partial class frmChat
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suscribirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conEstadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sinEstadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.lsbParticipants = new System.Windows.Forms.ListBox();
            this.lsvHistory = new System.Windows.Forms.ListView();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 237);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(369, 52);
            this.txtMessage.TabIndex = 0;
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.conexiónToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(531, 24);
            this.mnsMenu.TabIndex = 1;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // conexiónToolStripMenuItem
            // 
            this.conexiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicarToolStripMenuItem,
            this.suscribirToolStripMenuItem});
            this.conexiónToolStripMenuItem.Name = "conexiónToolStripMenuItem";
            this.conexiónToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.conexiónToolStripMenuItem.Text = "Conexión";
            // 
            // publicarToolStripMenuItem
            // 
            this.publicarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinEstadoToolStripMenuItem,
            this.conEstadoToolStripMenuItem});
            this.publicarToolStripMenuItem.Name = "publicarToolStripMenuItem";
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.publicarToolStripMenuItem.Text = "Publicar";
            // 
            // sinEstadoToolStripMenuItem
            // 
            this.sinEstadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem,
            this.bestEffortToolStripMenuItem});
            this.sinEstadoToolStripMenuItem.Name = "sinEstadoToolStripMenuItem";
            this.sinEstadoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sinEstadoToolStripMenuItem.Text = "Sin Estado";
            // 
            // reliableToolStripMenuItem
            // 
            this.reliableToolStripMenuItem.Name = "reliableToolStripMenuItem";
            this.reliableToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reliableToolStripMenuItem.Text = "Reliable";
            this.reliableToolStripMenuItem.Click += new System.EventHandler(this.reliableToolStripMenuItem_Click);
            // 
            // bestEffortToolStripMenuItem
            // 
            this.bestEffortToolStripMenuItem.Name = "bestEffortToolStripMenuItem";
            this.bestEffortToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bestEffortToolStripMenuItem.Text = "Best-Effort";
            // 
            // conEstadoToolStripMenuItem
            // 
            this.conEstadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem1,
            this.bestEffortToolStripMenuItem1});
            this.conEstadoToolStripMenuItem.Name = "conEstadoToolStripMenuItem";
            this.conEstadoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.conEstadoToolStripMenuItem.Text = "Con Estado";
            this.conEstadoToolStripMenuItem.Click += new System.EventHandler(this.conEstadoToolStripMenuItem_Click);
            // 
            // reliableToolStripMenuItem1
            // 
            this.reliableToolStripMenuItem1.Name = "reliableToolStripMenuItem1";
            this.reliableToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.reliableToolStripMenuItem1.Text = "Reliable";
            this.reliableToolStripMenuItem1.Click += new System.EventHandler(this.reliableToolStripMenuItem1_Click);
            // 
            // bestEffortToolStripMenuItem1
            // 
            this.bestEffortToolStripMenuItem1.Name = "bestEffortToolStripMenuItem1";
            this.bestEffortToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.bestEffortToolStripMenuItem1.Text = "Best-Effort";
            this.bestEffortToolStripMenuItem1.Click += new System.EventHandler(this.bestEffortToolStripMenuItem1_Click);
            // 
            // suscribirToolStripMenuItem
            // 
            this.suscribirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conEstadoToolStripMenuItem1,
            this.sinEstadoToolStripMenuItem1});
            this.suscribirToolStripMenuItem.Name = "suscribirToolStripMenuItem";
            this.suscribirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.suscribirToolStripMenuItem.Text = "Suscribir";
            // 
            // conEstadoToolStripMenuItem1
            // 
            this.conEstadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem2,
            this.bestEffortToolStripMenuItem2});
            this.conEstadoToolStripMenuItem1.Name = "conEstadoToolStripMenuItem1";
            this.conEstadoToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.conEstadoToolStripMenuItem1.Text = "Con Estado";
            // 
            // reliableToolStripMenuItem2
            // 
            this.reliableToolStripMenuItem2.Name = "reliableToolStripMenuItem2";
            this.reliableToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.reliableToolStripMenuItem2.Text = "Reliable";
            this.reliableToolStripMenuItem2.Click += new System.EventHandler(this.reliableToolStripMenuItem2_Click);
            // 
            // bestEffortToolStripMenuItem2
            // 
            this.bestEffortToolStripMenuItem2.Name = "bestEffortToolStripMenuItem2";
            this.bestEffortToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.bestEffortToolStripMenuItem2.Text = "Best-Effort";
            // 
            // sinEstadoToolStripMenuItem1
            // 
            this.sinEstadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem3,
            this.bestEffortToolStripMenuItem3});
            this.sinEstadoToolStripMenuItem1.Name = "sinEstadoToolStripMenuItem1";
            this.sinEstadoToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.sinEstadoToolStripMenuItem1.Text = "Sin Estado";
            // 
            // reliableToolStripMenuItem3
            // 
            this.reliableToolStripMenuItem3.Name = "reliableToolStripMenuItem3";
            this.reliableToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.reliableToolStripMenuItem3.Text = "Reliable";
            // 
            // bestEffortToolStripMenuItem3
            // 
            this.bestEffortToolStripMenuItem3.Name = "bestEffortToolStripMenuItem3";
            this.bestEffortToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.bestEffortToolStripMenuItem3.Text = "Best-Effort";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(388, 237);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 52);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsbParticipants
            // 
            this.lsbParticipants.FormattingEnabled = true;
            this.lsbParticipants.Location = new System.Drawing.Point(388, 41);
            this.lsbParticipants.Name = "lsbParticipants";
            this.lsbParticipants.Size = new System.Drawing.Size(120, 173);
            this.lsbParticipants.TabIndex = 4;
            // 
            // lsvHistory
            // 
            this.lsvHistory.Location = new System.Drawing.Point(12, 41);
            this.lsvHistory.Name = "lsvHistory";
            this.lsvHistory.Size = new System.Drawing.Size(369, 173);
            this.lsvHistory.TabIndex = 5;
            this.lsvHistory.UseCompatibleStateImageBehavior = false;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 323);
            this.Controls.Add(this.lsvHistory);
            this.Controls.Add(this.lsbParticipants);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmChat";
            this.Text = "DDS-RTPS (Demo) Chat";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reliableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestEffortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reliableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bestEffortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suscribirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conEstadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reliableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bestEffortToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sinEstadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reliableToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bestEffortToolStripMenuItem3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lsbParticipants;
        private System.Windows.Forms.ListView lsvHistory;
    }
}

