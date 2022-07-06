namespace abarrotes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_principal
            // 
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_principal.Location = new System.Drawing.Point(0, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1284, 35);
            this.panel_principal.TabIndex = 1;
            // 
            // panelBarra
            // 
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarra.Location = new System.Drawing.Point(0, 35);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(200, 576);
            this.panelBarra.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panelBarra;
    }
}

