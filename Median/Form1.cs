using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Median
{
    public partial class Form1 : Form
    {
        string[] filePaths;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openMedia.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                filePaths = openMedia.FileNames;
                List<string> extensions = new List<string>();
                for (int i = 0; i < filePaths.Length; i++) {
                    for (int j = filePaths[i].Length; j >= 0; j--) {
                        string extension = "";
                        if (filePaths[i][j] == '.')
                        {
                            if (extensions.Count() == 0)
                            {
                                extensions.Add(extension);
                                break;
                            }
                            else {
                                Boolean exists = false;
                                for (int k = 0; k < extensions.Count; k++) {
                                    if (extension == extensions[k]) {
                                        exists = true;
                                        break;
                                    }
                                }
                                if (!exists) {
                                    extensions.Add(extension);
                                }

                            }
                            break;
                        }
                        else {
                            extension = filePaths[i][j].ToString() + extension;
                        }
                    }
                }
            }
        }
    }
}
