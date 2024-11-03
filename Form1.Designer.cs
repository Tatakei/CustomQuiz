namespace CustomQuiz
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            lblQuestion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(131, 270);
            button1.Name = "button1";
            button1.Size = new Size(120, 65);
            button1.TabIndex = 0;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += checkAnswerEvent;
            // 
            // button2
            // 
            button2.Location = new Point(572, 270);
            button2.Name = "button2";
            button2.Size = new Size(120, 65);
            button2.TabIndex = 1;
            button2.Tag = "2";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += checkAnswerEvent;
            // 
            // button3
            // 
            button3.Location = new Point(131, 371);
            button3.Name = "button3";
            button3.Size = new Size(120, 67);
            button3.TabIndex = 2;
            button3.Tag = "3";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checkAnswerEvent;
            // 
            // button4
            // 
            button4.Location = new Point(572, 371);
            button4.Name = "button4";
            button4.Size = new Size(120, 67);
            button4.TabIndex = 3;
            button4.Tag = "4";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += checkAnswerEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.turtle;
            pictureBox1.Location = new Point(137, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(137, 193);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(555, 41);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQuestion);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label lblQuestion;
    }
}
