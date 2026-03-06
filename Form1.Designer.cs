namespace MyBusinessCard
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._1111;
            pictureBox1.Location = new Point(60, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼엑스포", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(366, 71);
            label1.Name = "label1";
            label1.Size = new Size(170, 53);
            label1.TabIndex = 1;
            label1.Text = "이성현";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("함초롬바탕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(400, 149);
            label2.Name = "label2";
            label2.Size = new Size(176, 45);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터SW";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("함초롬바탕", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.FromArgb(192, 192, 0);
            label3.Location = new Point(400, 212);
            label3.Name = "label3";
            label3.Size = new Size(307, 38);
            label3.TabIndex = 3;
            label3.Text = "leetjdgus@gmail.com";
            // 
            // button1
            // 
            button1.Font = new Font("한컴 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(100, 356);
            button1.Name = "button1";
            button1.Size = new Size(178, 76);
            button1.TabIndex = 4;
            button1.Text = "배경 색 랜덤 변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(400, 277);
            button2.Name = "button2";
            button2.Size = new Size(110, 41);
            button2.TabIndex = 5;
            button2.Text = "GitHub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(400, 339);
            button3.Name = "button3";
            button3.Size = new Size(110, 41);
            button3.TabIndex = 6;
            button3.Text = "사진변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 480);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
