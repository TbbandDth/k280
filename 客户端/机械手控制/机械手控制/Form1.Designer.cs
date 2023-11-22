namespace 机械手控制
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            btnConnetct = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConnetct);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "串口连接";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 1;
            label1.Text = "串口名称";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(96, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 32);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 3;
            label2.Text = "波特率";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(708, 56);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 7;
            label3.Text = "校验位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 56);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 5;
            label4.Text = "数据位";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 30);
            textBox1.TabIndex = 9;
            textBox1.Text = "8";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(793, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 30);
            textBox2.TabIndex = 10;
            textBox2.Text = "None";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1042, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 30);
            textBox3.TabIndex = 12;
            textBox3.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(957, 56);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 11;
            label5.Text = "停止位";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(315, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 30);
            textBox4.TabIndex = 13;
            textBox4.Text = "115200";
            // 
            // btnConnetct
            // 
            btnConnetct.Location = new Point(544, 114);
            btnConnetct.Name = "btnConnetct";
            btnConnetct.Size = new Size(112, 34);
            btnConnetct.TabIndex = 14;
            btnConnetct.Text = "连接";
            btnConnetct.UseVisualStyleBackColor = true;
            btnConnetct.Click += btnConnetct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 655);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Button btnConnetct;
        private TextBox textBox4;
    }
}
