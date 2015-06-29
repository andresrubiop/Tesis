namespace TesisChat
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suscribirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conEstadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sinEstadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reliableToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestEffortToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 237);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 52);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.conexiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
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
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.publicarToolStripMenuItem.Text = "Publicar";
            // 
            // suscribirToolStripMenuItem
            // 
            this.suscribirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conEstadoToolStripMenuItem1,
            this.sinEstadoToolStripMenuItem1});
            this.suscribirToolStripMenuItem.Name = "suscribirToolStripMenuItem";
            this.suscribirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.suscribirToolStripMenuItem.Text = "Suscribir";
            // 
            // sinEstadoToolStripMenuItem
            // 
            this.sinEstadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem,
            this.bestEffortToolStripMenuItem});
            this.sinEstadoToolStripMenuItem.Name = "sinEstadoToolStripMenuItem";
            this.sinEstadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sinEstadoToolStripMenuItem.Text = "Sin Estado";
            // 
            // conEstadoToolStripMenuItem
            // 
            this.conEstadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem1,
            this.bestEffortToolStripMenuItem1});
            this.conEstadoToolStripMenuItem.Name = "conEstadoToolStripMenuItem";
            this.conEstadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conEstadoToolStripMenuItem.Text = "Con Estado";
            // 
            // reliableToolStripMenuItem
            // 
            this.reliableToolStripMenuItem.Name = "reliableToolStripMenuItem";
            this.reliableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reliableToolStripMenuItem.Text = "Reliable";
            // 
            // bestEffortToolStripMenuItem
            // 
            this.bestEffortToolStripMenuItem.Name = "bestEffortToolStripMenuItem";
            this.bestEffortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bestEffortToolStripMenuItem.Text = "Best-Effort";
            // 
            // reliableToolStripMenuItem1
            // 
            this.reliableToolStripMenuItem1.Name = "reliableToolStripMenuItem1";
            this.reliableToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.reliableToolStripMenuItem1.Text = "Reliable";
            // 
            // bestEffortToolStripMenuItem1
            // 
            this.bestEffortToolStripMenuItem1.Name = "bestEffortToolStripMenuItem1";
            this.bestEffortToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.bestEffortToolStripMenuItem1.Text = "Best-Effort";
            // 
            // conEstadoToolStripMenuItem1
            // 
            this.conEstadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem2,
            this.bestEffortToolStripMenuItem2});
            this.conEstadoToolStripMenuItem1.Name = "conEstadoToolStripMenuItem1";
            this.conEstadoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.conEstadoToolStripMenuItem1.Text = "Con Estado";
            // 
            // sinEstadoToolStripMenuItem1
            // 
            this.sinEstadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliableToolStripMenuItem3,
            this.bestEffortToolStripMenuItem3});
            this.sinEstadoToolStripMenuItem1.Name = "sinEstadoToolStripMenuItem1";
            this.sinEstadoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sinEstadoToolStripMenuItem1.Text = "Sin Estado";
            // 
            // reliableToolStripMenuItem2
            // 
            this.reliableToolStripMenuItem2.Name = "reliableToolStripMenuItem2";
            this.reliableToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.reliableToolStripMenuItem2.Text = "Reliable";
            // 
            // reliableToolStripMenuItem3
            // 
            this.reliableToolStripMenuItem3.Name = "reliableToolStripMenuItem3";
            this.reliableToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.reliableToolStripMenuItem3.Text = "Reliable";
            // 
            // bestEffortToolStripMenuItem2
            // 
            this.bestEffortToolStripMenuItem2.Name = "bestEffortToolStripMenuItem2";
            this.bestEffortToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.bestEffortToolStripMenuItem2.Text = "Best-Effort";
            // 
            // bestEffortToolStripMenuItem3
            // 
            this.bestEffortToolStripMenuItem3.Name = "bestEffortToolStripMenuItem3";
            this.bestEffortToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.bestEffortToolStripMenuItem3.Text = "Best-Effort";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 176);
            this.textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(388, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 323);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

