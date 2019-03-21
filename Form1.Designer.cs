namespace ListaReproduccion
{
    partial class Reproductor
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
            this.Lst_Rep = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Upp = new System.Windows.Forms.Button();
            this.Btn_up = new System.Windows.Forms.Button();
            this.Btn_down = new System.Windows.Forms.Button();
            this.Btn_DDown = new System.Windows.Forms.Button();
            this.Btn_Ubicacion = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.Btn_play = new System.Windows.Forms.Button();
            this.Lbx_Res = new System.Windows.Forms.ListBox();
            this.Btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lst_Rep
            // 
            this.Lst_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_Rep.FormattingEnabled = true;
            this.Lst_Rep.ItemHeight = 16;
            this.Lst_Rep.Location = new System.Drawing.Point(12, 40);
            this.Lst_Rep.Name = "Lst_Rep";
            this.Lst_Rep.Size = new System.Drawing.Size(389, 292);
            this.Lst_Rep.TabIndex = 0;
            this.Lst_Rep.SelectedIndexChanged += new System.EventHandler(this.Lst_Rep_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de reproduccion";
            // 
            // Btn_Upp
            // 
            this.Btn_Upp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Upp.Location = new System.Drawing.Point(493, 209);
            this.Btn_Upp.Name = "Btn_Upp";
            this.Btn_Upp.Size = new System.Drawing.Size(53, 43);
            this.Btn_Upp.TabIndex = 3;
            this.Btn_Upp.Text = "|<";
            this.Btn_Upp.UseVisualStyleBackColor = true;
            this.Btn_Upp.Click += new System.EventHandler(this.Btn_Upp_Click);
            // 
            // Btn_up
            // 
            this.Btn_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_up.Location = new System.Drawing.Point(552, 209);
            this.Btn_up.Name = "Btn_up";
            this.Btn_up.Size = new System.Drawing.Size(53, 43);
            this.Btn_up.TabIndex = 4;
            this.Btn_up.Text = "<";
            this.Btn_up.UseVisualStyleBackColor = true;
            this.Btn_up.Click += new System.EventHandler(this.Btn_up_Click);
            // 
            // Btn_down
            // 
            this.Btn_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_down.Location = new System.Drawing.Point(611, 209);
            this.Btn_down.Name = "Btn_down";
            this.Btn_down.Size = new System.Drawing.Size(53, 43);
            this.Btn_down.TabIndex = 5;
            this.Btn_down.Text = ">";
            this.Btn_down.UseVisualStyleBackColor = true;
            this.Btn_down.Click += new System.EventHandler(this.Btn_down_Click);
            // 
            // Btn_DDown
            // 
            this.Btn_DDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DDown.Location = new System.Drawing.Point(670, 209);
            this.Btn_DDown.Name = "Btn_DDown";
            this.Btn_DDown.Size = new System.Drawing.Size(53, 43);
            this.Btn_DDown.TabIndex = 6;
            this.Btn_DDown.Text = ">|";
            this.Btn_DDown.UseVisualStyleBackColor = true;
            this.Btn_DDown.Click += new System.EventHandler(this.Btn_DDown_Click);
            // 
            // Btn_Ubicacion
            // 
            this.Btn_Ubicacion.Location = new System.Drawing.Point(407, 40);
            this.Btn_Ubicacion.Name = "Btn_Ubicacion";
            this.Btn_Ubicacion.Size = new System.Drawing.Size(75, 44);
            this.Btn_Ubicacion.TabIndex = 7;
            this.Btn_Ubicacion.Text = "Ubicacion";
            this.Btn_Ubicacion.UseVisualStyleBackColor = true;
            this.Btn_Ubicacion.Click += new System.EventHandler(this.Btn_Ubicacion_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.Location = new System.Drawing.Point(523, 289);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(53, 43);
            this.Btn_Stop.TabIndex = 9;
            this.Btn_Stop.Text = "[]";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Enabled = false;
            this.Btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pause.Location = new System.Drawing.Point(594, 289);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(53, 43);
            this.Btn_Pause.TabIndex = 10;
            this.Btn_Pause.Text = "II";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_play
            // 
            this.Btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_play.Location = new System.Drawing.Point(663, 289);
            this.Btn_play.Name = "Btn_play";
            this.Btn_play.Size = new System.Drawing.Size(53, 43);
            this.Btn_play.TabIndex = 11;
            this.Btn_play.Text = "|>";
            this.Btn_play.UseVisualStyleBackColor = true;
            this.Btn_play.Click += new System.EventHandler(this.Btn_play_Click);
            // 
            // Lbx_Res
            // 
            this.Lbx_Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_Res.FormattingEnabled = true;
            this.Lbx_Res.ItemHeight = 16;
            this.Lbx_Res.Location = new System.Drawing.Point(490, 25);
            this.Lbx_Res.Name = "Lbx_Res";
            this.Lbx_Res.Size = new System.Drawing.Size(226, 132);
            this.Lbx_Res.TabIndex = 12;
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(407, 327);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(63, 20);
            this.Btn_search.TabIndex = 13;
            this.Btn_search.Text = "Buscador";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 359);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.Lbx_Res);
            this.Controls.Add(this.Btn_play);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Ubicacion);
            this.Controls.Add(this.Btn_DDown);
            this.Controls.Add(this.Btn_down);
            this.Controls.Add(this.Btn_up);
            this.Controls.Add(this.Btn_Upp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lst_Rep);
            this.Name = "Reproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor Hitss";
            this.Load += new System.EventHandler(this.Reproductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Rep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Upp;
        private System.Windows.Forms.Button Btn_up;
        private System.Windows.Forms.Button Btn_down;
        private System.Windows.Forms.Button Btn_DDown;
        private System.Windows.Forms.Button Btn_Ubicacion;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Pause;
        private System.Windows.Forms.Button Btn_play;
        private System.Windows.Forms.ListBox Lbx_Res;
        private System.Windows.Forms.Button Btn_search;
    }
}

