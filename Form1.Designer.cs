namespace WinFormsApp1
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
            listBox1 = new ListBox();
            cityTextBox = new TextBox();
            Add = new Button();
            listBoxCity = new ListBox();
            listBoxCountry = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(356, 86);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(53, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(678, 34);
            listBox1.TabIndex = 1;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(53, 218);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 2;
            cityTextBox.Text = "Miasto";
            // 
            // Add
            // 
            Add.Location = new Point(53, 247);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // listBoxCity
            // 
            listBoxCity.FormattingEnabled = true;
            listBoxCity.ItemHeight = 15;
            listBoxCity.Location = new Point(53, 294);
            listBoxCity.Name = "listBoxCity";
            listBoxCity.Size = new Size(719, 64);
            listBoxCity.TabIndex = 7;
            // 
            // listBoxCountry
            // 
            listBoxCountry.FormattingEnabled = true;
            listBoxCountry.ItemHeight = 15;
            listBoxCountry.Location = new Point(53, 374);
            listBoxCountry.Name = "listBoxCountry";
            listBoxCountry.Size = new Size(719, 64);
            listBoxCountry.TabIndex = 8;
            //listBoxCountry.SelectedIndexChanged += listBoxCountry_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(228, 247);
            button2.Name = "button2";
            button2.Size = new Size(128, 23);
            button2.TabIndex = 9;
            button2.Text = "Sort (by timezone)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBoxCountry);
            Controls.Add(listBoxCity);
            Controls.Add(Add);
            Controls.Add(cityTextBox);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox cityTextBox;
        private Button Add;
        private ListBox listBoxCity;
        private ListBox listBoxCountry;
        private Button button2;
    }
}
