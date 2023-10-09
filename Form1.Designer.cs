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
            CPGenrateBtn = new Button();
            CPs_NBx = new NumericUpDown();
            label3 = new Label();
            CPc_NBx = new NumericUpDown();
            label2 = new Label();
            CPn_NBx = new NumericUpDown();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            toolTip1 = new ToolTip(components);
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CPs_NBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CPc_NBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CPn_NBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 499);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Series Graph";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(940, 477);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(964, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 499);
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 19);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(413, 477);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(CPGenrateBtn);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(405, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Constant Points";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CPGenrateBtn
            // 
            CPGenrateBtn.Location = new Point(318, 394);
            CPGenrateBtn.Name = "CPGenrateBtn";
            CPGenrateBtn.Size = new Size(75, 23);
            CPGenrateBtn.TabIndex = 6;
            CPGenrateBtn.Text = "Generate";
            CPGenrateBtn.UseVisualStyleBackColor = true;
            CPGenrateBtn.Click += CPGenrateBtn_Click;
            // 
            // CPs_NBx
            // 
            CPs_NBx.DecimalPlaces = 2;
            CPs_NBx.Location = new Point(119, 46);
            CPs_NBx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CPs_NBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            CPs_NBx.Name = "CPs_NBx";
            CPs_NBx.Size = new Size(57, 23);
            CPs_NBx.TabIndex = 5;
            CPs_NBx.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Scatter:";
            // 
            // CPc_NBx
            // 
            CPc_NBx.DecimalPlaces = 2;
            CPc_NBx.Location = new Point(119, 17);
            CPc_NBx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CPc_NBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            CPc_NBx.Name = "CPc_NBx";
            CPc_NBx.Size = new Size(57, 23);
            CPc_NBx.TabIndex = 3;
            CPc_NBx.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Center:";
            // 
            // CPn_NBx
            // 
            CPn_NBx.Location = new Point(119, 47);
            CPn_NBx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CPn_NBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            CPn_NBx.Name = "CPn_NBx";
            CPn_NBx.Size = new Size(57, 23);
            CPn_NBx.TabIndex = 1;
            CPn_NBx.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of points: ";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(405, 429);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Normal Distribution Points";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(405, 429);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exponential Points";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 44);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(405, 429);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sigmoid Points";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 44);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(405, 429);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Polynomial Points";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 44);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(405, 429);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Random Points";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 44);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(405, 429);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Sine Wave Points";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Color:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Location = new Point(119, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 36);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.DoubleClick += pictureBox2_DoubleClick;
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
            // textBox1
            // 
            textBox1.Location = new Point(119, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "Main Series";
            // 
            // button1
            // 
            button1.Location = new Point(182, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            button1.Click += pictureBox2_DoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(CPn_NBx);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 121);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "General Properties";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(CPc_NBx);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(CPs_NBx);
            groupBox4.Location = new Point(6, 133);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(281, 77);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Specific Type Properties";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 729);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CPs_NBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)CPc_NBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)CPn_NBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private TextBox textBox1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label4;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button button1;
    }
}
