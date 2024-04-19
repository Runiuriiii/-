namespace _10._2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            otvet = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(154, 249);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 0;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(48, 23);
            label1.Name = "label1";
            label1.Size = new Size(319, 156);
            label1.TabIndex = 1;
            label1.Text = "Введите число n, а мы постараемся вывести сумму(если получится, то даже правильную)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(154, 307);
            label2.Name = "label2";
            label2.Size = new Size(113, 26);
            label2.TabIndex = 3;
            label2.Text = "Ваша сумма";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 4;
            label3.Text = "Ваше число n";
            label3.Click += label3_Click;
            // 
            // otvet
            // 
            otvet.AutoSize = true;
            otvet.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            otvet.Location = new Point(186, 351);
            otvet.Name = "otvet";
            otvet.Size = new Size(54, 64);
            otvet.TabIndex = 5;
            otvet.Text = "0";
            otvet.TextAlign = ContentAlignment.MiddleLeft;
            otvet.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(418, 450);
            Controls.Add(otvet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label otvet;
    }
}
