namespace Ex5
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBin3 = new System.Windows.Forms.Button();
            this.btnBin2 = new System.Windows.Forms.Button();
            this.btnBin1 = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtBox2);
            this.gb1.Controls.Add(this.txtBox1);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.btnCalcul);
            this.gb1.Location = new System.Drawing.Point(46, 36);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(675, 131);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            this.gb1.Text = "Test1";
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(431, 56);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(210, 20);
            this.txtBox2.TabIndex = 4;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(206, 56);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sinus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angle en degrés";
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(6, 29);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(164, 72);
            this.btnCalcul.TabIndex = 0;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.textBox3);
            this.gb2.Controls.Add(this.button5);
            this.gb2.Controls.Add(this.btnBin3);
            this.gb2.Controls.Add(this.btnBin2);
            this.gb2.Controls.Add(this.btnBin1);
            this.gb2.Location = new System.Drawing.Point(46, 230);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(675, 131);
            this.gb2.TabIndex = 3;
            this.gb2.TabStop = false;
            this.gb2.Text = "Test2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(431, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBin3
            // 
            this.btnBin3.Location = new System.Drawing.Point(219, 30);
            this.btnBin3.Name = "btnBin3";
            this.btnBin3.Size = new System.Drawing.Size(87, 72);
            this.btnBin3.TabIndex = 3;
            this.btnBin3.Text = "0";
            this.btnBin3.UseVisualStyleBackColor = true;
            this.btnBin3.Click += new System.EventHandler(this.btnBin3_Click);
            // 
            // btnBin2
            // 
            this.btnBin2.Location = new System.Drawing.Point(110, 30);
            this.btnBin2.Name = "btnBin2";
            this.btnBin2.Size = new System.Drawing.Size(87, 72);
            this.btnBin2.TabIndex = 2;
            this.btnBin2.Text = "0";
            this.btnBin2.UseVisualStyleBackColor = true;
            this.btnBin2.Click += new System.EventHandler(this.btnBin2_Click);
            // 
            // btnBin1
            // 
            this.btnBin1.Location = new System.Drawing.Point(6, 30);
            this.btnBin1.Name = "btnBin1";
            this.btnBin1.Size = new System.Drawing.Size(87, 72);
            this.btnBin1.TabIndex = 1;
            this.btnBin1.Text = "0";
            this.btnBin1.UseVisualStyleBackColor = true;
            this.btnBin1.Click += new System.EventHandler(this.btnBin1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBin3;
        private System.Windows.Forms.Button btnBin2;
        private System.Windows.Forms.Button btnBin1;
    }
}

