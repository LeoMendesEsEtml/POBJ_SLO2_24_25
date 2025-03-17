namespace Ex5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtBoxMsb = new System.Windows.Forms.TextBox();
            this.txtBoxLsb = new System.Windows.Forms.TextBox();
            this.txtBoxShortHex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtraire = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnBin5 = new System.Windows.Forms.Button();
            this.btnBin4 = new System.Windows.Forms.Button();
            this.btnBin3 = new System.Windows.Forms.Button();
            this.btnBin2 = new System.Windows.Forms.Button();
            this.btnBin1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxValB = new System.Windows.Forms.TextBox();
            this.txtBoxValA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPermuter = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // gb1
            this.gb1.Controls.Add(this.txtBoxMsb);
            this.gb1.Controls.Add(this.txtBoxLsb);
            this.gb1.Controls.Add(this.txtBoxShortHex);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.btnExtraire);
            this.gb1.Location = new System.Drawing.Point(46, 22);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(675, 131);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            this.gb1.Text = "Test1";

            // btnExtraire
            this.btnExtraire.Location = new System.Drawing.Point(6, 29);
            this.btnExtraire.Name = "btnExtraire";
            this.btnExtraire.Size = new System.Drawing.Size(164, 72);
            this.btnExtraire.TabIndex = 0;
            this.btnExtraire.Text = "Extraire";
            this.btnExtraire.UseVisualStyleBackColor = true;
            this.btnExtraire.Click += new System.EventHandler(this.btnExtraire_Click);

            // gb2
            this.gb2.Controls.Add(this.txtDecimal);
            this.gb2.Controls.Add(this.btnBin5);
            this.gb2.Controls.Add(this.btnBin4);
            this.gb2.Controls.Add(this.btnBin3);
            this.gb2.Controls.Add(this.btnBin2);
            this.gb2.Controls.Add(this.btnBin1);
            this.gb2.Location = new System.Drawing.Point(46, 294);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(675, 131);
            this.gb2.TabIndex = 3;
            this.gb2.TabStop = false;
            this.gb2.Text = "Test3";

            // groupBox1
            this.groupBox1.Controls.Add(this.txtBoxValB);
            this.groupBox1.Controls.Add(this.txtBoxValA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPermuter);
            this.groupBox1.Location = new System.Drawing.Point(46, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test2";

            // btnPermuter
            this.btnPermuter.Location = new System.Drawing.Point(6, 29);
            this.btnPermuter.Name = "btnPermuter";
            this.btnPermuter.Size = new System.Drawing.Size(164, 72);
            this.btnPermuter.TabIndex = 0;
            this.btnPermuter.Text = "Permuter";
            this.btnPermuter.UseVisualStyleBackColor = true;
            this.btnPermuter.Click += new System.EventHandler(this.btnPermuter_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gb1, gb2, groupBox1;
        private System.Windows.Forms.TextBox txtBoxMsb, txtBoxLsb, txtBoxShortHex, txtDecimal, txtBoxValA, txtBoxValB;
        private System.Windows.Forms.Button btnExtraire, btnBin1, btnBin2, btnBin3, btnBin4, btnBin5, btnPermuter;
        private System.Windows.Forms.Label label1, label2, label3, label4;
    }
}

