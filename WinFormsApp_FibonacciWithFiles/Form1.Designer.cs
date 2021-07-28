
namespace WinFormsApp_FibonacciWithFiles
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
            this.label_inputPath = new System.Windows.Forms.Label();
            this.label_outputPath = new System.Windows.Forms.Label();
            this.label_infoAboutPath = new System.Windows.Forms.Label();
            this.button_makeSolution = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox_inputPath = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_outputPath = new System.Windows.Forms.TextBox();
            this.label_alert = new System.Windows.Forms.Label();
            this.label_done = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_inputPath
            // 
            this.label_inputPath.AutoSize = true;
            this.label_inputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_inputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label_inputPath.Location = new System.Drawing.Point(34, 50);
            this.label_inputPath.Name = "label_inputPath";
            this.label_inputPath.Size = new System.Drawing.Size(175, 16);
            this.label_inputPath.TabIndex = 0;
            this.label_inputPath.Text = "Путь исходного файла";
            // 
            // label_outputPath
            // 
            this.label_outputPath.AutoSize = true;
            this.label_outputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_outputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label_outputPath.Location = new System.Drawing.Point(34, 100);
            this.label_outputPath.Name = "label_outputPath";
            this.label_outputPath.Size = new System.Drawing.Size(170, 16);
            this.label_outputPath.TabIndex = 1;
            this.label_outputPath.Text = "Путь выходной файла";
            // 
            // label_infoAboutPath
            // 
            this.label_infoAboutPath.AutoSize = true;
            this.label_infoAboutPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_infoAboutPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label_infoAboutPath.Location = new System.Drawing.Point(12, 185);
            this.label_infoAboutPath.Name = "label_infoAboutPath";
            this.label_infoAboutPath.Size = new System.Drawing.Size(157, 13);
            this.label_infoAboutPath.TabIndex = 2;
            this.label_infoAboutPath.Text = "Используйте \\\\ вместо \\";
            // 
            // button_makeSolution
            // 
            this.button_makeSolution.FlatAppearance.BorderSize = 0;
            this.button_makeSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_makeSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_makeSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_makeSolution.Location = new System.Drawing.Point(446, 175);
            this.button_makeSolution.Name = "button_makeSolution";
            this.button_makeSolution.Size = new System.Drawing.Size(75, 23);
            this.button_makeSolution.TabIndex = 3;
            this.button_makeSolution.Text = "Начать";
            this.button_makeSolution.UseVisualStyleBackColor = true;
            this.button_makeSolution.Click += new System.EventHandler(this.button_makeSolution_Click);
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(493, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(28, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_inputPath
            // 
            this.textBox_inputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox_inputPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_inputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_inputPath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_inputPath.Location = new System.Drawing.Point(48, 77);
            this.textBox_inputPath.Multiline = true;
            this.textBox_inputPath.Name = "textBox_inputPath";
            this.textBox_inputPath.Size = new System.Drawing.Size(292, 20);
            this.textBox_inputPath.TabIndex = 5;
            this.textBox_inputPath.Text = "Введите путь...";
            this.textBox_inputPath.TextChanged += new System.EventHandler(this.textBox_inputPath_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label_name.Location = new System.Drawing.Point(12, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(168, 16);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Fibanacci and Reverse";
            // 
            // textBox_outputPath
            // 
            this.textBox_outputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox_outputPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_outputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_outputPath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_outputPath.Location = new System.Drawing.Point(48, 129);
            this.textBox_outputPath.Multiline = true;
            this.textBox_outputPath.Name = "textBox_outputPath";
            this.textBox_outputPath.Size = new System.Drawing.Size(292, 20);
            this.textBox_outputPath.TabIndex = 7;
            this.textBox_outputPath.Text = "Введите путь...";
            // 
            // label_alert
            // 
            this.label_alert.AutoSize = true;
            this.label_alert.ForeColor = System.Drawing.Color.Red;
            this.label_alert.Location = new System.Drawing.Point(404, 77);
            this.label_alert.Name = "label_alert";
            this.label_alert.Size = new System.Drawing.Size(117, 30);
            this.label_alert.TabIndex = 8;
            this.label_alert.Text = "Неверно указанный\r\n путь";
            this.label_alert.Visible = false;
            // 
            // label_done
            // 
            this.label_done.AutoSize = true;
            this.label_done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label_done.Location = new System.Drawing.Point(428, 134);
            this.label_done.Name = "label_done";
            this.label_done.Size = new System.Drawing.Size(45, 15);
            this.label_done.TabIndex = 9;
            this.label_done.Text = "Готово";
            this.label_done.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(533, 210);
            this.Controls.Add(this.label_done);
            this.Controls.Add(this.label_alert);
            this.Controls.Add(this.textBox_outputPath);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_inputPath);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_makeSolution);
            this.Controls.Add(this.label_infoAboutPath);
            this.Controls.Add(this.label_outputPath);
            this.Controls.Add(this.label_inputPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_inputPath;
        private System.Windows.Forms.Label label_outputPath;
        private System.Windows.Forms.Label label_infoAboutPath;
        private System.Windows.Forms.Button button_makeSolution;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox_inputPath;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_outputPath;
        private System.Windows.Forms.Label label_alert;
        private System.Windows.Forms.Label label_done;
    }
}

