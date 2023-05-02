namespace EsercizioVerifica1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAzzera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 33;
            this.lst.Location = new System.Drawing.Point(96, 41);
            this.lst.Name = "lst";
            this.lst.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst.Size = new System.Drawing.Size(173, 334);
            this.lst.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(391, 41);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(258, 86);
            this.btn.TabIndex = 1;
            this.btn.Text = "Prezzo";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(419, 169);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(204, 73);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label1";
            // 
            // btnAzzera
            // 
            this.btnAzzera.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzzera.Location = new System.Drawing.Point(406, 290);
            this.btnAzzera.Name = "btnAzzera";
            this.btnAzzera.Size = new System.Drawing.Size(217, 59);
            this.btnAzzera.TabIndex = 3;
            this.btnAzzera.Text = "Azzera";
            this.btnAzzera.UseVisualStyleBackColor = true;
            this.btnAzzera.Click += new System.EventHandler(this.btnAzzera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzzera);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnAzzera;
    }
}

