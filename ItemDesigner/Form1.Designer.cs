namespace ItemDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(119, 276);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 1;
            label1.Text = "物品名称";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 3;
            label2.Text = "物品描述";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 46);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 94);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 150);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 5;
            label3.Text = "物品图形";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(199, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonShadow;
            pictureBox2.Location = new Point(333, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 288);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 8;
            label4.Text = "价格";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(227, 288);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 21);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "可使用";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(296, 287);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 21);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "可消耗";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(13, 296);
            button1.Name = "button1";
            button1.Size = new Size(53, 24);
            button1.TabIndex = 12;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 296);
            button2.Name = "button2";
            button2.Size = new Size(59, 24);
            button2.TabIndex = 13;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 326);
            button3.Name = "button3";
            button3.Size = new Size(118, 24);
            button3.TabIndex = 14;
            button3.Text = "保存";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(391, 368);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "物品编辑器";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}