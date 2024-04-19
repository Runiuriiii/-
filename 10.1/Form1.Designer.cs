namespace _10._1
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
            find = new Button();
            a = new TextBox();
            b = new TextBox();
            angle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // find
            // 
            find.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            find.Location = new Point(12, 317);
            find.Name = "find";
            find.Size = new Size(113, 63);
            find.TabIndex = 0;
            find.Text = "Найти";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // a
            // 
            a.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            a.Location = new Point(12, 99);
            a.Name = "a";
            a.Size = new Size(333, 23);
            a.TabIndex = 1;
            a.TextChanged += textBox1_TextChanged;
            // 
            // b
            // 
            b.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            b.Location = new Point(12, 169);
            b.Name = "b";
            b.Size = new Size(333, 23);
            b.TabIndex = 2;
            b.TextChanged += textBox2_TextChanged;
            // 
            // angle
            // 
            angle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            angle.Location = new Point(12, 242);
            angle.Name = "angle";
            angle.Size = new Size(333, 23);
            angle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "Сторона a";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Сторона b";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Угол x";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Magneto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(53, 27);
            label4.Name = "label4";
            label4.Size = new Size(250, 20);
            label4.TabIndex = 7;
            label4.Text = "Площадь параллелограмма";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Yu Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(168, 317);
            label5.Name = "label5";
            label5.Size = new Size(177, 63);
            label5.TabIndex = 8;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(357, 427);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(angle);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(find);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button find;
        private TextBox a;
        private TextBox b;
        private TextBox angle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
