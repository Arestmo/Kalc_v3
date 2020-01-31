namespace Kalc_v3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_calc = new System.Windows.Forms.Button();
            this.Check_add = new System.Windows.Forms.CheckBox();
            this.Check_substract = new System.Windows.Forms.CheckBox();
            this.Check_multiply = new System.Windows.Forms.CheckBox();
            this.Check_divide = new System.Windows.Forms.CheckBox();
            this.Text_val1 = new System.Windows.Forms.TextBox();
            this.Text_val2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Button_calc
            // 
            this.Button_calc.Location = new System.Drawing.Point(225, 34);
            this.Button_calc.Name = "Button_calc";
            this.Button_calc.Size = new System.Drawing.Size(75, 69);
            this.Button_calc.TabIndex = 0;
            this.Button_calc.Text = "Calc";
            this.Button_calc.UseVisualStyleBackColor = true;
            this.Button_calc.Click += new System.EventHandler(this.Button_calc_Click);
            // 
            // Check_add
            // 
            this.Check_add.AutoSize = true;
            this.Check_add.Location = new System.Drawing.Point(12, 63);
            this.Check_add.Name = "Check_add";
            this.Check_add.Size = new System.Drawing.Size(45, 17);
            this.Check_add.TabIndex = 1;
            this.Check_add.Text = "Add";
            this.Check_add.UseVisualStyleBackColor = true;
            this.Check_add.CheckedChanged += new System.EventHandler(this.Check_add_CheckedChanged);
            // 
            // Check_substract
            // 
            this.Check_substract.AutoSize = true;
            this.Check_substract.Location = new System.Drawing.Point(12, 86);
            this.Check_substract.Name = "Check_substract";
            this.Check_substract.Size = new System.Drawing.Size(71, 17);
            this.Check_substract.TabIndex = 2;
            this.Check_substract.Text = "Substract";
            this.Check_substract.UseVisualStyleBackColor = true;
            this.Check_substract.CheckedChanged += new System.EventHandler(this.Check_substract_CheckedChanged);
            // 
            // Check_multiply
            // 
            this.Check_multiply.AutoSize = true;
            this.Check_multiply.Location = new System.Drawing.Point(119, 63);
            this.Check_multiply.Name = "Check_multiply";
            this.Check_multiply.Size = new System.Drawing.Size(61, 17);
            this.Check_multiply.TabIndex = 3;
            this.Check_multiply.Text = "Multiply";
            this.Check_multiply.UseVisualStyleBackColor = true;
            this.Check_multiply.CheckedChanged += new System.EventHandler(this.Check_multiply_CheckedChanged);
            // 
            // Check_divide
            // 
            this.Check_divide.AutoSize = true;
            this.Check_divide.Location = new System.Drawing.Point(119, 86);
            this.Check_divide.Name = "Check_divide";
            this.Check_divide.Size = new System.Drawing.Size(56, 17);
            this.Check_divide.TabIndex = 4;
            this.Check_divide.Text = "Divide";
            this.Check_divide.UseVisualStyleBackColor = true;
            this.Check_divide.CheckedChanged += new System.EventHandler(this.Check_divide_CheckedChanged);
            // 
            // Text_val1
            // 
            this.Text_val1.Location = new System.Drawing.Point(13, 37);
            this.Text_val1.Name = "Text_val1";
            this.Text_val1.Size = new System.Drawing.Size(100, 20);
            this.Text_val1.TabIndex = 6;
            // 
            // Text_val2
            // 
            this.Text_val2.Location = new System.Drawing.Point(119, 37);
            this.Text_val2.Name = "Text_val2";
            this.Text_val2.Size = new System.Drawing.Size(100, 20);
            this.Text_val2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Value 2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 121);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 240);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_val2);
            this.Controls.Add(this.Text_val1);
            this.Controls.Add(this.Check_divide);
            this.Controls.Add(this.Check_multiply);
            this.Controls.Add(this.Check_substract);
            this.Controls.Add(this.Check_add);
            this.Controls.Add(this.Button_calc);
            this.Name = "Form1";
            this.Text = "Calc v3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_calc;
        private System.Windows.Forms.CheckBox Check_add;
        private System.Windows.Forms.CheckBox Check_substract;
        private System.Windows.Forms.CheckBox Check_multiply;
        private System.Windows.Forms.CheckBox Check_divide;
        private System.Windows.Forms.TextBox Text_val1;
        private System.Windows.Forms.TextBox Text_val2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

