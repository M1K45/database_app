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
            city = new TextBox();
            timezone = new TextBox();
            weatherBox = new TextBox();
            temp = new TextBox();
            Add = new Button();
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
            // city
            // 
            city.Location = new Point(53, 191);
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 2;
            city.Text = "Miasto";
            city.TextChanged += city_TextChanged;
            // 
            // timezone
            // 
            timezone.Location = new Point(53, 243);
            timezone.Name = "timezone";
            timezone.Size = new Size(100, 23);
            timezone.TabIndex = 3;
            timezone.Text = "Strefa czasowa";
            // 
            // weatherBox
            // 
            weatherBox.Location = new Point(53, 294);
            weatherBox.Name = "weatherBox";
            weatherBox.Size = new Size(100, 23);
            weatherBox.TabIndex = 4;
            weatherBox.Text = "Pogoda ";
            // 
            // temp
            // 
            temp.Location = new Point(53, 348);
            temp.Name = "temp";
            temp.Size = new Size(100, 23);
            temp.TabIndex = 5;
            temp.Text = "Temperatura";
            // 
            // Add
            // 
            Add.Location = new Point(213, 270);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add);
            Controls.Add(temp);
            Controls.Add(weatherBox);
            Controls.Add(timezone);
            Controls.Add(city);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox city;
        private TextBox timezone;
        private TextBox weatherBox;
        private TextBox temp;
        private Button Add;
    }
}
