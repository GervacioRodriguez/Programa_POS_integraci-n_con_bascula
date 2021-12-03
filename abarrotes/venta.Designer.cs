namespace abarrotes
{
    partial class venta
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.descripcioventa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidadventa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidadventa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.importeventa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalventa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descripcioventa,
            this.cantidadventa,
            this.unidadventa,
            this.importeventa,
            this.totalventa});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 204);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // descripcioventa
            // 
            this.descripcioventa.Text = "Descripcion";
            this.descripcioventa.Width = 497;
            // 
            // cantidadventa
            // 
            this.cantidadventa.Text = "Cant";
            // 
            // unidadventa
            // 
            this.unidadventa.Text = "Unidad";
            // 
            // importeventa
            // 
            this.importeventa.Text = "Importe";
            this.importeventa.Width = 67;
            // 
            // totalventa
            // 
            this.totalventa.Text = "Total";
            this.totalventa.Width = 76;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcant, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtunidad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtimporte, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txttotal, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbproducto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IMPORTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "UNIDAD";
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(497, 28);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(53, 20);
            this.txtcant.TabIndex = 1;
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(558, 28);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(54, 20);
            this.txtunidad.TabIndex = 2;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(620, 28);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(56, 20);
            this.txtimporte.TabIndex = 3;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(684, 28);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(83, 20);
            this.txttotal.TabIndex = 4;
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(5, 28);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(484, 21);
            this.cmbproducto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DESCRIPCIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CANT";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(509, 398);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(111, 40);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Name = "venta";
            this.Text = "venta";
            this.Load += new System.EventHandler(this.venta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader descripcioventa;
        private System.Windows.Forms.ColumnHeader cantidadventa;
        private System.Windows.Forms.ColumnHeader unidadventa;
        private System.Windows.Forms.ColumnHeader importeventa;
        private System.Windows.Forms.ColumnHeader totalventa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}