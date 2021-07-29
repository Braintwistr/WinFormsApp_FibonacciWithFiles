using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using static WinFormsApp_FibonacciWithFiles.Fibanacci;

namespace WinFormsApp_FibonacciWithFiles
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_makeSolution_Click(object sender, EventArgs e)
        {
            List<string> reversedLines = new List<string>();
            string inputPath = textBox_inputPath.Text;
            string outputPath = textBox_outputPath.Text;

            try
            {
                using (var inputFile = new StreamReader(inputPath))
                {
                    while (!inputFile.EndOfStream)
                    {
                        string lineFile = inputFile.ReadLine();
                        if (IsFibanacci(NumberFromString(lineFile)))
                        {
                            reversedLines.Add(ReverseString(lineFile));
                        }
                    }
                }
                using (var outputFile = new StreamWriter(outputPath, true))
                {
                    foreach (var line in reversedLines)
                    {
                        outputFile.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Application.Exit();
                label_alert.Visible = true;
                button_makeSolution.Enabled = false;
            }
            catch (UnauthorizedAccessException) 
            {
                Application.Exit();
                label_alert.Visible = true;
                button_makeSolution.Enabled = false;
            }
            catch (ArgumentException)
            {
                Application.Exit();
                label_alert.Visible = true;
                button_makeSolution.Enabled = false;
            }
            label_done.Visible = true;
            button_makeSolution.Enabled = false;
        }

        private void textBox_inputPath_TextChanged(object sender, EventArgs e)
        {
            label_done.Visible = false;
        }
    }
}
