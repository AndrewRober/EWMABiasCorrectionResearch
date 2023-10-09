namespace EWMABiasCorrectionResearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            CPc_NBx = new NumericUpDown();
            CPGenrateBtn = new Button();
            label3 = new Label();
            CPs_NBx = new NumericUpDown();
            tabPage2 = new TabPage();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            groupBox3 = new GroupBox();
            label7 = new Label();
            CPbNbx = new NumericUpDown();
            label6 = new Label();
            CPwNbx = new NumericUpDown();
            label5 = new Label();
            ChangeColorBtn = new Button();
            label1 = new Label();
            DescTbx = new TextBox();
            CPn_NBx = new NumericUpDown();
            label4 = new Label();
            CpcPbx = new PictureBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CPc_NBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CPs_NBx).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CPbNbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CPwNbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CPn_NBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CpcPbx).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Series Graph";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(940, 479);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(964, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 499);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Points generation";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(3, 206);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(278, 290);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(CPc_NBx);
            tabPage1.Controls.Add(CPGenrateBtn);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(CPs_NBx);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(270, 242);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Constant";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 8);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Center:";
            // 
            // CPc_NBx
            // 
            CPc_NBx.DecimalPlaces = 2;
            CPc_NBx.Location = new Point(119, 6);
            CPc_NBx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CPc_NBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            CPc_NBx.Name = "CPc_NBx";
            CPc_NBx.Size = new Size(57, 23);
            CPc_NBx.TabIndex = 3;
            CPc_NBx.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // CPGenrateBtn
            // 
            CPGenrateBtn.Location = new Point(101, 64);
            CPGenrateBtn.Name = "CPGenrateBtn";
            CPGenrateBtn.Size = new Size(75, 23);
            CPGenrateBtn.TabIndex = 6;
            CPGenrateBtn.Text = "Generate";
            CPGenrateBtn.UseVisualStyleBackColor = true;
            CPGenrateBtn.Click += GenerateCP;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Scatter:";
            // 
            // CPs_NBx
            // 
            CPs_NBx.DecimalPlaces = 2;
            CPs_NBx.Location = new Point(119, 35);
            CPs_NBx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CPs_NBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            CPs_NBx.Name = "CPs_NBx";
            CPs_NBx.Size = new Size(57, 23);
            CPs_NBx.TabIndex = 5;
            CPs_NBx.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(270, 242);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Normal Distribution";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 10);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 2;
            label8.Text = "Mean (x̄):";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(140, 8);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(122, 66);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 39);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 4;
            label9.Text = "Standard Deviation (σ):";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(140, 37);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(57, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(270, 242);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exponential";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 44);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(270, 242);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sigmoid";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 44);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(270, 242);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Polynomial";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 44);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(270, 242);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Random";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 44);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(270, 242);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Sine Wave";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(CPbNbx);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(CPwNbx);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(ChangeColorBtn);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(DescTbx);
            groupBox3.Controls.Add(CPn_NBx);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(CpcPbx);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(278, 178);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "General Properties";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "β (Beta):";
            // 
            // CPbNbx
            // 
            CPbNbx.DecimalPlaces = 2;
            CPbNbx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            CPbNbx.Location = new Point(119, 45);
            CPbNbx.Maximum = new decimal(new int[] { 99, 0, 0, 131072 });
            CPbNbx.Name = "CPbNbx";
            CPbNbx.Size = new Size(57, 23);
            CPbNbx.TabIndex = 15;
            CPbNbx.Value = new decimal(new int[] { 90, 0, 0, 131072 });
            CPbNbx.ValueChanged += BetaValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 76);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Width:";
            // 
            // CPwNbx
            // 
            CPwNbx.DecimalPlaces = 1;
            CPwNbx.Location = new Point(119, 74);
            CPwNbx.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CPwNbx.Name = "CPwNbx";
            CPwNbx.Size = new Size(57, 23);
            CPwNbx.TabIndex = 13;
            CPwNbx.Value = new decimal(new int[] { 5, 0, 0, 0 });
            CPwNbx.ValueChanged += WidthValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Description: ";
            // 
            // ChangeColorBtn
            // 
            ChangeColorBtn.Location = new Point(182, 137);
            ChangeColorBtn.Name = "ChangeColorBtn";
            ChangeColorBtn.Size = new Size(75, 23);
            ChangeColorBtn.TabIndex = 11;
            ChangeColorBtn.Text = "Change";
            ChangeColorBtn.UseVisualStyleBackColor = true;
            ChangeColorBtn.Click += ChangeSeriesColor;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 105);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of points: ";
            // 
            // DescTbx
            // 
            DescTbx.Location = new Point(119, 16);
            DescTbx.Name = "DescTbx";
            DescTbx.Size = new Size(153, 23);
            DescTbx.TabIndex = 10;
            DescTbx.Text = "Main Series";
            // 
            // CPn_NBx
            // 
            CPn_NBx.Location = new Point(119, 103);
            CPn_NBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            CPn_NBx.Name = "CPn_NBx";
            CPn_NBx.Size = new Size(57, 23);
            CPn_NBx.TabIndex = 1;
            CPn_NBx.Value = new decimal(new int[] { 100, 0, 0, 0 });
            CPn_NBx.ValueChanged += NumberOfPointsValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Color:";
            // 
            // CpcPbx
            // 
            CpcPbx.BackColor = Color.Red;
            CpcPbx.Location = new Point(119, 132);
            CpcPbx.Name = "CpcPbx";
            CpcPbx.Size = new Size(57, 36);
            CpcPbx.TabIndex = 8;
            CpcPbx.TabStop = false;
            CpcPbx.DoubleClick += ChangeSeriesColor;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 525);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CPc_NBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)CPs_NBx).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CPbNbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)CPwNbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)CPn_NBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)CpcPbx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private NumericUpDown CPn_NBx;
        private Label label1;
        private NumericUpDown CPc_NBx;
        private Label label2;
        private Button CPGenrateBtn;
        private NumericUpDown CPs_NBx;
        private Label label3;
        private ToolTip toolTip1;
        private TextBox DescTbx;
        private Label label5;
        private PictureBox CpcPbx;
        private Label label4;
        private GroupBox groupBox3;
        private Button ChangeColorBtn;
        private Label label6;
        private NumericUpDown CPwNbx;
        private Label label7;
        private NumericUpDown CPbNbx;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private Button button2;
    }
}
