namespace Ex2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPersonnes = new System.Windows.Forms.ListBox();
            this.cboRues = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.domVilles = new System.Windows.Forms.DomainUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(71, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Prénom, Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville";
            // 
            // lstPersonnes
            // 
            this.lstPersonnes.FormattingEnabled = true;
            this.lstPersonnes.Location = new System.Drawing.Point(12, 25);
            this.lstPersonnes.Name = "lstPersonnes";
            this.lstPersonnes.Size = new System.Drawing.Size(98, 173);
            this.lstPersonnes.TabIndex = 4;
            this.lstPersonnes.SelectedIndexChanged += new System.EventHandler(this.lstPersonnes_SelectedIndexChanged);
            // 
            // cboRues
            // 
            this.cboRues.FormattingEnabled = true;
            this.cboRues.Location = new System.Drawing.Point(116, 25);
            this.cboRues.Name = "cboRues";
            this.cboRues.Size = new System.Drawing.Size(158, 21);
            this.cboRues.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(283, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // domVilles
            // 
            this.domVilles.Location = new System.Drawing.Point(348, 25);
            this.domVilles.Name = "domVilles";
            this.domVilles.Size = new System.Drawing.Size(158, 20);
            this.domVilles.TabIndex = 7;
            this.domVilles.Text = "NPA Villes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(116, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 146);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Composer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.domVilles);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cboRues);
            this.Controls.Add(this.lstPersonnes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPersonnes;
        private System.Windows.Forms.ComboBox cboRues;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domVilles;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

