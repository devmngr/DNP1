namespace WinFormMath
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
            this.first_number = new System.Windows.Forms.TextBox();
            this.second_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.mul_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.save_list_btn = new System.Windows.Forms.Button();
            this.read_list_btn = new System.Windows.Forms.Button();
            this.clear_list_btn = new System.Windows.Forms.Button();
            this.stress_test_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first_number
            // 
            this.first_number.Location = new System.Drawing.Point(332, 61);
            this.first_number.Name = "first_number";
            this.first_number.Size = new System.Drawing.Size(137, 38);
            this.first_number.TabIndex = 0;
            // 
            // second_number
            // 
            this.second_number.Location = new System.Drawing.Point(538, 61);
            this.second_number.Name = "second_number";
            this.second_number.Size = new System.Drawing.Size(137, 38);
            this.second_number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Numbers";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(34, 145);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(111, 55);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(169, 145);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(111, 55);
            this.sub_btn.TabIndex = 4;
            this.sub_btn.Text = "SUB";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // mul_btn
            // 
            this.mul_btn.Location = new System.Drawing.Point(303, 145);
            this.mul_btn.Name = "mul_btn";
            this.mul_btn.Size = new System.Drawing.Size(111, 55);
            this.mul_btn.TabIndex = 5;
            this.mul_btn.Text = "MUL";
            this.mul_btn.UseVisualStyleBackColor = true;
            this.mul_btn.Click += new System.EventHandler(this.mul_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.Location = new System.Drawing.Point(434, 145);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(111, 55);
            this.div_btn.TabIndex = 6;
            this.div_btn.Text = "DIV";
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(564, 145);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(111, 55);
            this.clr_btn.TabIndex = 7;
            this.clr_btn.Text = "CLR";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(34, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(459, 345);
            this.listBox1.TabIndex = 8;
            // 
            // save_list_btn
            // 
            this.save_list_btn.Location = new System.Drawing.Point(38, 584);
            this.save_list_btn.Name = "save_list_btn";
            this.save_list_btn.Size = new System.Drawing.Size(178, 55);
            this.save_list_btn.TabIndex = 9;
            this.save_list_btn.Text = "Save List";
            this.save_list_btn.UseVisualStyleBackColor = true;
            this.save_list_btn.Click += new System.EventHandler(this.save_list_btn_Click);
            // 
            // read_list_btn
            // 
            this.read_list_btn.Location = new System.Drawing.Point(270, 584);
            this.read_list_btn.Name = "read_list_btn";
            this.read_list_btn.Size = new System.Drawing.Size(178, 55);
            this.read_list_btn.TabIndex = 10;
            this.read_list_btn.Text = "Read List";
            this.read_list_btn.UseVisualStyleBackColor = true;
            this.read_list_btn.Click += new System.EventHandler(this.read_list_btn_Click);
            // 
            // clear_list_btn
            // 
            this.clear_list_btn.Location = new System.Drawing.Point(501, 584);
            this.clear_list_btn.Name = "clear_list_btn";
            this.clear_list_btn.Size = new System.Drawing.Size(178, 55);
            this.clear_list_btn.TabIndex = 11;
            this.clear_list_btn.Text = "Clear List";
            this.clear_list_btn.UseVisualStyleBackColor = true;
            this.clear_list_btn.Click += new System.EventHandler(this.clear_list_btn_Click);
            // 
            // stress_test_btn
            // 
            this.stress_test_btn.Location = new System.Drawing.Point(535, 342);
            this.stress_test_btn.Name = "stress_test_btn";
            this.stress_test_btn.Size = new System.Drawing.Size(140, 89);
            this.stress_test_btn.TabIndex = 12;
            this.stress_test_btn.Text = "Stress Test";
            this.stress_test_btn.UseVisualStyleBackColor = true;
            this.stress_test_btn.Click += new System.EventHandler(this.stress_test_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 671);
            this.Controls.Add(this.stress_test_btn);
            this.Controls.Add(this.clear_list_btn);
            this.Controls.Add(this.read_list_btn);
            this.Controls.Add(this.save_list_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.mul_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second_number);
            this.Controls.Add(this.first_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_number;
        private System.Windows.Forms.TextBox second_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button mul_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button save_list_btn;
        private System.Windows.Forms.Button read_list_btn;
        private System.Windows.Forms.Button clear_list_btn;
        private System.Windows.Forms.Button stress_test_btn;
    }
}

