namespace ListaReproduccion
{
    partial class Buscador
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
            this.Btn_repro = new System.Windows.Forms.Button();
            this.Btn_search = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Txbx_Buscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_repro
            // 
            this.Btn_repro.Location = new System.Drawing.Point(443, 270);
            this.Btn_repro.Name = "Btn_repro";
            this.Btn_repro.Size = new System.Drawing.Size(75, 42);
            this.Btn_repro.TabIndex = 0;
            this.Btn_repro.Text = "Regresar a Reproductor";
            this.Btn_repro.UseVisualStyleBackColor = true;
            this.Btn_repro.Click += new System.EventHandler(this.Btn_repro_Click);
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(492, 36);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(26, 23);
            this.Btn_search.TabIndex = 1;
            this.Btn_search.Text = "Ir:";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(341, 254);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Txbx_Buscar
            // 
            this.Txbx_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txbx_Buscar.Location = new System.Drawing.Point(359, 36);
            this.Txbx_Buscar.Name = "Txbx_Buscar";
            this.Txbx_Buscar.Size = new System.Drawing.Size(127, 22);
            this.Txbx_Buscar.TabIndex = 3;
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 324);
            this.Controls.Add(this.Txbx_Buscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.Btn_repro);
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Buscador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_repro;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox Txbx_Buscar;
    }
}