namespace Ex1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDevises = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConvert = new System.Windows.Forms.Button();
            this.rdSwiss = new System.Windows.Forms.RadioButton();
            this.rbUSA = new System.Windows.Forms.RadioButton();
            this.rbUK = new System.Windows.Forms.RadioButton();
            this.rbJAP = new System.Windows.Forms.RadioButton();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDevises)).BeginInit();
            this.SuspendLayout();
            // 
            // picDevises
            // 
            this.picDevises.InitialImage = global::Ex1.Properties.Resources.la_suisse;
            this.picDevises.Location = new System.Drawing.Point(279, 12);
            this.picDevises.Name = "picDevises";
            this.picDevises.Size = new System.Drawing.Size(231, 224);
            this.picDevises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDevises.TabIndex = 0;
            this.picDevises.TabStop = false;
            this.picDevises.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Montant ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résultat en euro";
            // 
            // btConvert
            // 
            this.btConvert.Location = new System.Drawing.Point(203, 297);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(144, 83);
            this.btConvert.TabIndex = 3;
            this.btConvert.Text = "Convertir";
            this.btConvert.UseVisualStyleBackColor = true;
            this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
            // 
            // rdSwiss
            // 
            this.rdSwiss.AutoSize = true;
            this.rdSwiss.Location = new System.Drawing.Point(57, 53);
            this.rdSwiss.Name = "rdSwiss";
            this.rdSwiss.Size = new System.Drawing.Size(91, 17);
            this.rdSwiss.TabIndex = 4;
            this.rdSwiss.TabStop = true;
            this.rdSwiss.Text = "Francs Suisse";
            this.rdSwiss.UseVisualStyleBackColor = true;
            this.rdSwiss.CheckedChanged += new System.EventHandler(this.rdSwiss_CheckedChanged);
            // 
            // rbUSA
            // 
            this.rbUSA.AutoSize = true;
            this.rbUSA.Location = new System.Drawing.Point(57, 76);
            this.rbUSA.Name = "rbUSA";
            this.rbUSA.Size = new System.Drawing.Size(75, 17);
            this.rbUSA.TabIndex = 5;
            this.rbUSA.TabStop = true;
            this.rbUSA.Text = "US Dollars";
            this.rbUSA.UseVisualStyleBackColor = true;
            this.rbUSA.CheckedChanged += new System.EventHandler(this.rbUSA_CheckedChanged);
            // 
            // rbUK
            // 
            this.rbUK.AutoSize = true;
            this.rbUK.Location = new System.Drawing.Point(57, 99);
            this.rbUK.Name = "rbUK";
            this.rbUK.Size = new System.Drawing.Size(86, 17);
            this.rbUK.TabIndex = 6;
            this.rbUK.TabStop = true;
            this.rbUK.Text = "Livre Sterling";
            this.rbUK.UseVisualStyleBackColor = true;
            this.rbUK.CheckedChanged += new System.EventHandler(this.rbUK_CheckedChanged);
            // 
            // rbJAP
            // 
            this.rbJAP.AutoSize = true;
            this.rbJAP.Location = new System.Drawing.Point(57, 122);
            this.rbJAP.Name = "rbJAP";
            this.rbJAP.Size = new System.Drawing.Size(86, 17);
            this.rbJAP.TabIndex = 7;
            this.rbJAP.TabStop = true;
            this.rbJAP.Text = "Yen japonais";
            this.rbJAP.UseVisualStyleBackColor = true;
            this.rbJAP.CheckedChanged += new System.EventHandler(this.rbJAP_CheckedChanged);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(410, 329);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 8;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(42, 329);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "la-suisse.png");
            this.imageList1.Images.SetKeyName(1, "etats-unis.png");
            this.imageList1.Images.SetKeyName(2, "royaume-uni.png");
            this.imageList1.Images.SetKeyName(3, "japon.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(553, 392);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.rbJAP);
            this.Controls.Add(this.rbUK);
            this.Controls.Add(this.rbUSA);
            this.Controls.Add(this.rdSwiss);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDevises);
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Convertisseur de dévise";
            ((System.ComponentModel.ISupportInitialize)(this.picDevises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDevises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConvert;
        private System.Windows.Forms.RadioButton rdSwiss;
        private System.Windows.Forms.RadioButton rbUSA;
        private System.Windows.Forms.RadioButton rbUK;
        private System.Windows.Forms.RadioButton rbJAP;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.ImageList imageList1;
    }
}

