namespace Robi
{
    partial class RobiDialog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGo = new System.Windows.Forms.Button();
            this.tbAusgabe = new System.Windows.Forms.TextBox();
            this.btnDreheRechts = new System.Windows.Forms.Button();
            this.btnDreheLinks = new System.Windows.Forms.Button();
            this.statusZeile = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbZeichenflaeche = new System.Windows.Forms.PictureBox();
            this.statusZeile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZeichenflaeche)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(658, 622);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(40, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbAusgabe
            // 
            this.tbAusgabe.Location = new System.Drawing.Point(658, 12);
            this.tbAusgabe.Multiline = true;
            this.tbAusgabe.Name = "tbAusgabe";
            this.tbAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAusgabe.Size = new System.Drawing.Size(209, 604);
            this.tbAusgabe.TabIndex = 5;
            // 
            // btnDreheRechts
            // 
            this.btnDreheRechts.Location = new System.Drawing.Point(740, 622);
            this.btnDreheRechts.Name = "btnDreheRechts";
            this.btnDreheRechts.Size = new System.Drawing.Size(30, 23);
            this.btnDreheRechts.TabIndex = 6;
            this.btnDreheRechts.Text = "->";
            this.btnDreheRechts.UseVisualStyleBackColor = true;
            this.btnDreheRechts.Click += new System.EventHandler(this.btnDreheRechts_Click);
            // 
            // btnDreheLinks
            // 
            this.btnDreheLinks.Location = new System.Drawing.Point(704, 622);
            this.btnDreheLinks.Name = "btnDreheLinks";
            this.btnDreheLinks.Size = new System.Drawing.Size(30, 23);
            this.btnDreheLinks.TabIndex = 7;
            this.btnDreheLinks.Text = "<-";
            this.btnDreheLinks.UseVisualStyleBackColor = true;
            this.btnDreheLinks.Click += new System.EventHandler(this.btnDreheLinks_Click);
            // 
            // statusZeile
            // 
            this.statusZeile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusZeile.Location = new System.Drawing.Point(0, 659);
            this.statusZeile.Name = "statusZeile";
            this.statusZeile.Size = new System.Drawing.Size(884, 22);
            this.statusZeile.TabIndex = 8;
            this.statusZeile.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel1.Text = "OK";
            // 
            // pbZeichenflaeche
            // 
            this.pbZeichenflaeche.Location = new System.Drawing.Point(12, 5);
            this.pbZeichenflaeche.Name = "pbZeichenflaeche";
            this.pbZeichenflaeche.Size = new System.Drawing.Size(640, 640);
            this.pbZeichenflaeche.TabIndex = 2;
            this.pbZeichenflaeche.TabStop = false;
            this.pbZeichenflaeche.Paint += new System.Windows.Forms.PaintEventHandler(this.pbZeichenflaeche_Paint);
            this.pbZeichenflaeche.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbZeichenflaeche_MouseMove);
            // 
            // RobiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.statusZeile);
            this.Controls.Add(this.btnDreheLinks);
            this.Controls.Add(this.btnDreheRechts);
            this.Controls.Add(this.tbAusgabe);
            this.Controls.Add(this.pbZeichenflaeche);
            this.Controls.Add(this.btnGo);
            this.Name = "RobiDialog";
            this.Text = "Robi";
            this.statusZeile.ResumeLayout(false);
            this.statusZeile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZeichenflaeche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pbZeichenflaeche;
        private System.Windows.Forms.TextBox tbAusgabe;
        private System.Windows.Forms.Button btnDreheRechts;
        private System.Windows.Forms.Button btnDreheLinks;
        private System.Windows.Forms.StatusStrip statusZeile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

