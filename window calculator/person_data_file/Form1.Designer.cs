
namespace person_data_file
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.but_show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(114, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(114, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(114, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Person_age";
            // 
            // but_save
            // 
            this.but_save.BackColor = System.Drawing.Color.Transparent;
            this.but_save.Location = new System.Drawing.Point(190, 270);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 3;
            this.but_save.Text = "Save_data";
            this.but_save.UseVisualStyleBackColor = false;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(220, 75);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(146, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(220, 186);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(146, 20);
            this.txt_gender.TabIndex = 5;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(220, 127);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(146, 20);
            this.txt_age.TabIndex = 6;
            // 
            // but_show
            // 
            this.but_show.BackColor = System.Drawing.Color.Transparent;
            this.but_show.Location = new System.Drawing.Point(301, 270);
            this.but_show.Name = "but_show";
            this.but_show.Size = new System.Drawing.Size(75, 23);
            this.but_show.TabIndex = 7;
            this.but_show.Text = "Show_data";
            this.but_show.UseVisualStyleBackColor = false;
            this.but_show.Click += new System.EventHandler(this.but_show_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(220, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Person Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::person_data_file.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_show);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button but_show;
        private System.Windows.Forms.Label label4;
    }
}

