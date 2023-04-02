namespace UdC
{
    partial class Form3
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
            this.wb_navegador = new System.Windows.Forms.WebBrowser();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_recargar = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wb_navegador
            // 
            this.wb_navegador.Location = new System.Drawing.Point(12, 41);
            this.wb_navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_navegador.Name = "wb_navegador";
            this.wb_navegador.Size = new System.Drawing.Size(776, 397);
            this.wb_navegador.TabIndex = 0;
            // 
            // btn_atras
            // 
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(12, 12);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(23, 23);
            this.btn_atras.TabIndex = 1;
            this.btn_atras.Text = "<";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(41, 12);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(23, 23);
            this.btn_siguiente.TabIndex = 2;
            this.btn_siguiente.Text = ">";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_recargar
            // 
            this.btn_recargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recargar.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargar.Location = new System.Drawing.Point(70, 12);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(23, 23);
            this.btn_recargar.TabIndex = 3;
            this.btn_recargar.Text = "R";
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(99, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(23, 23);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "H";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(128, 13);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(419, 22);
            this.txt_url.TabIndex = 5;
            this.txt_url.Text = "https://";
            // 
            // btn_ir
            // 
            this.btn_ir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ir.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ir.Location = new System.Drawing.Point(553, 13);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(27, 23);
            this.btn_ir.TabIndex = 6;
            this.btn_ir.Text = "IR";
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.btn_ir_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.AutoSize = true;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(691, 11);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(97, 23);
            this.btn_anterior.TabIndex = 7;
            this.btn_anterior.Text = "Anterior Ejercicio";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_ir);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.wb_navegador);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_navegador;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_recargar;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_anterior;
    }
}