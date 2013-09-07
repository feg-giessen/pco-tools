namespace PcoLive
{
    partial class ControlWindow
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
            this.btnLive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPlanId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFenster = new System.Windows.Forms.ComboBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLive
            // 
            this.btnLive.Location = new System.Drawing.Point(29, 105);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(75, 23);
            this.btnLive.TabIndex = 0;
            this.btnLive.Text = "Anzeigen";
            this.btnLive.UseVisualStyleBackColor = true;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plan ID";
            // 
            // txbPlanId
            // 
            this.txbPlanId.Location = new System.Drawing.Point(93, 24);
            this.txbPlanId.Name = "txbPlanId";
            this.txbPlanId.Size = new System.Drawing.Size(121, 20);
            this.txbPlanId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fenster";
            // 
            // cboFenster
            // 
            this.cboFenster.FormattingEnabled = true;
            this.cboFenster.Location = new System.Drawing.Point(93, 51);
            this.cboFenster.Name = "cboFenster";
            this.cboFenster.Size = new System.Drawing.Size(121, 21);
            this.cboFenster.TabIndex = 3;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(139, 105);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Verstecken";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 152);
            this.Controls.Add(this.cboFenster);
            this.Controls.Add(this.txbPlanId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnLive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ControlWindow";
            this.Text = "PCO Live Window Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPlanId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFenster;
        private System.Windows.Forms.Button btnHide;
    }
}

