namespace _11._2
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
            phnumber = new Label();
            find = new Button();
            resulted = new ListBox();
            all = new ListBox();
            table = new Label();
            found = new Label();
            phonenumber = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // phnumber
            // 
            phnumber.AutoSize = true;
            phnumber.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phnumber.Location = new Point(36, 26);
            phnumber.Name = "phnumber";
            phnumber.Size = new Size(132, 23);
            phnumber.TabIndex = 0;
            phnumber.Text = "Номер телефона:";
            phnumber.Click += labelPlaneModel_Click;
            // 
            // find
            // 
            find.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            find.Location = new Point(36, 134);
            find.Margin = new Padding(3, 2, 3, 2);
            find.Name = "find";
            find.Size = new Size(99, 40);
            find.TabIndex = 2;
            find.Text = "Поиск";
            find.UseVisualStyleBackColor = true;
            find.Click += buttonSearch_Click;
            // 
            // resulted
            // 
            resulted.FormattingEnabled = true;
            resulted.ItemHeight = 15;
            resulted.Location = new Point(225, 51);
            resulted.Margin = new Padding(3, 2, 3, 2);
            resulted.Name = "resulted";
            resulted.Size = new Size(465, 79);
            resulted.TabIndex = 3;
            resulted.SelectedIndexChanged += resulted_SelectedIndexChanged;
            // 
            // all
            // 
            all.FormattingEnabled = true;
            all.ItemHeight = 15;
            all.Location = new Point(225, 176);
            all.Margin = new Padding(3, 2, 3, 2);
            all.Name = "all";
            all.Size = new Size(465, 79);
            all.TabIndex = 4;
            all.SelectedIndexChanged += all_SelectedIndexChanged;
            // 
            // table
            // 
            table.AutoSize = true;
            table.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            table.Location = new Point(225, 151);
            table.Name = "table";
            table.Size = new Size(53, 23);
            table.TabIndex = 5;
            table.Text = "Табло:";
            // 
            // found
            // 
            found.AutoSize = true;
            found.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            found.Location = new Point(225, 26);
            found.Name = "found";
            found.Size = new Size(127, 23);
            found.TabIndex = 6;
            found.Text = "Найденные люди:";
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(36, 68);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(139, 23);
            phonenumber.TabIndex = 7;
            phonenumber.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(36, 179);
            button1.Name = "button1";
            button1.Size = new Size(99, 41);
            button1.TabIndex = 8;
            button1.Text = "Фильтр";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(phonenumber);
            Controls.Add(found);
            Controls.Add(table);
            Controls.Add(all);
            Controls.Add(resulted);
            Controls.Add(find);
            Controls.Add(phnumber);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label phnumber;
        private Button find;
        private ListBox resulted;
        private ListBox all;
        private Label table;
        private Label found;
        private TextBox phonenumber;
        private Button button1;
    }
}
