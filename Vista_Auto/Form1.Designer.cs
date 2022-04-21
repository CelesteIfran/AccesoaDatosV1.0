
namespace Vista_Auto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 274);
            this.dataGridView1.TabIndex = 8;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Agregar.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Agregar.Location = new System.Drawing.Point(284, 362);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(137, 29);
            this.Agregar.TabIndex = 10;
            this.Agregar.Text = "Alta Auto";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(322, 23);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(348, 27);
            this.Header.TabIndex = 11;
            this.Header.Text = "Sistema de carga de automobiles";
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salir.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salir.Location = new System.Drawing.Point(533, 362);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(137, 29);
            this.salir.TabIndex = 12;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button salir;
    }
}

