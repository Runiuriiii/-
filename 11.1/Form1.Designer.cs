namespace _11._1
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
            tb1 = new TextBox();
            label1 = new Label();
            scr1 = new HScrollBar();
            label3 = new Label();
            b1 = new Button();
            b2 = new Button();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Location = new Point(12, 61);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(307, 28);
            label1.TabIndex = 1;
            label1.Text = "Введите значение n (иначе равно 0)";
            // 
            // scr1
            // 
            scr1.Location = new Point(12, 87);
            scr1.Name = "scr1";
            scr1.Size = new Size(343, 31);
            scr1.TabIndex = 2;
            scr1.Scroll += hScrollBar1_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Castellar", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 254);
            label3.Name = "label3";
            label3.Size = new Size(40, 39);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // b1
            // 
            b1.Location = new Point(12, 145);
            b1.Name = "b1";
            b1.Size = new Size(75, 23);
            b1.TabIndex = 5;
            b1.Text = "формула";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(124, 145);
            b2.Name = "b2";
            b2.Size = new Size(75, 23);
            b2.TabIndex = 6;
            b2.Text = "цикл";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(364, 329);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(label3);
            Controls.Add(scr1);
            Controls.Add(label1);
            Controls.Add(tb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private Label label1;
        private HScrollBar scr1;
        private Label label3;
        private Button b1;
        private Button b2;
    }
}
