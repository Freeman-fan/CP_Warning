namespace CP_Warning
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Input = new System.Windows.Forms.Button();
            this.pictureBox_Input = new System.Windows.Forms.PictureBox();
            this.pictureBox_Output = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_CPName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Output)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(636, 27);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(104, 35);
            this.btn_Input.TabIndex = 4;
            this.btn_Input.Text = "选择图像";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // pictureBox_Input
            // 
            this.pictureBox_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Input.Location = new System.Drawing.Point(3, 21);
            this.pictureBox_Input.Name = "pictureBox_Input";
            this.pictureBox_Input.Size = new System.Drawing.Size(302, 527);
            this.pictureBox_Input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Input.TabIndex = 6;
            this.pictureBox_Input.TabStop = false;
            // 
            // pictureBox_Output
            // 
            this.pictureBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Output.Location = new System.Drawing.Point(3, 21);
            this.pictureBox_Output.Name = "pictureBox_Output";
            this.pictureBox_Output.Size = new System.Drawing.Size(302, 527);
            this.pictureBox_Output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Output.TabIndex = 7;
            this.pictureBox_Output.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "生成预览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "输出图像";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(636, 94);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(105, 25);
            this.textBox_Width.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "宽(px)";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(637, 143);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(105, 25);
            this.textBox_Height.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "高(px)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "CP文本";
            // 
            // textBox_CPName
            // 
            this.textBox_CPName.Location = new System.Drawing.Point(639, 197);
            this.textBox_CPName.Name = "textBox_CPName";
            this.textBox_CPName.Size = new System.Drawing.Size(102, 25);
            this.textBox_CPName.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 551);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入图像";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_Output);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 551);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预览图象";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 575);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_CPName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "生成CP预警图";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Output)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.PictureBox pictureBox_Input;
        private System.Windows.Forms.PictureBox pictureBox_Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CPName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

