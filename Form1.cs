using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView.Url = new Uri("https://ya.ru");
        }

        private void btnSearchUrl_clicked(object sender, EventArgs e)
        {
            webView.Navigate(SearchString.Text);
        }

        private void btnClear_clicked(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnSaveTxt_clicked(object sender, EventArgs e)
        {
            string textContent = textBox1.Text;
            SaveFileDialog openSaveDialogTxt = new SaveFileDialog();
            openSaveDialogTxt.Filter = "TXT Files (*.txt)| *.txt";
            openSaveDialogTxt.ShowDialog();
            string path = openSaveDialogTxt.FileName;
            try
            {
                using (FileStream filestream = File.Create(path))
                {
                    byte[] content = new UTF8Encoding(true).GetBytes(textContent);
                    filestream.Write(content, 0, content.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnSaveHtml_clicked(object sender, EventArgs e)
        {
            string htmlContent = textBox1.Text;
            SaveFileDialog openSaveDialogHtml = new SaveFileDialog();
            openSaveDialogHtml.Filter = "HTML Files (*.html)| *.html";
            openSaveDialogHtml.ShowDialog();
            string path = openSaveDialogHtml.FileName;
            try
            {
                using (FileStream fileStream = File.Create(path))
                {
                    byte[] content = new UTF8Encoding(true).GetBytes(htmlContent);
                    fileStream.Write(content, 0, content.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnOpenTxt_clicked(object sender, EventArgs e)
        {
            OpenFileDialog opentxtfiledialog = new OpenFileDialog();
            opentxtfiledialog.Filter = "TXT Files (*.txt)| *.txt";
            opentxtfiledialog.ShowDialog();
            string filename = opentxtfiledialog.FileName;
            string fileTXTcontent = File.ReadAllText(filename);
            textBox1.Text = fileTXTcontent;
        }

        private void btnOpenHtml_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openhtmlfiledialog = new OpenFileDialog();
            openhtmlfiledialog.Filter = "HTML Files (*.html)| *.html";
            openhtmlfiledialog.ShowDialog();
            string filename = openhtmlfiledialog.FileName;
            string fileHTMLcontent = File.ReadAllText(filename);
            textBox1.Text = fileHTMLcontent;
        }

        private void btnFieldColor_clicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void btnTextColor_clicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog2 = new ColorDialog();
            colorDialog2.ShowDialog();
            textBox1.ForeColor = colorDialog2.Color;
        }

        private void btnSizeText_clicked(object sender, EventArgs e)
        {
            string selectedParametr = listBox1.SelectedItem.ToString();
            string selectedParametr2 = listBox2.SelectedItem.ToString();

            if (listBox1.SelectedItem == null)
            {
                return;
            }

            if (listBox2.SelectedItem == null)
            {
                return;
            }

            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                int fontNumberSize = int.Parse(selectedParametr);
                switch(fontNumberSize)
                {
                    case 8:
                        textSize.Text = "8" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 9:
                        textSize.Text = "9" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 10:
                        textSize.Text = "10" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 11:
                        textSize.Text = "11" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 12:
                        textSize.Text = "12" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 14:
                        textSize.Text = "14" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 16:
                        textSize.Text = "16" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 18:
                        textSize.Text = "18" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 20:
                        textSize.Text = "20" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 22:
                        textSize.Text = "22" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 24:
                        textSize.Text = "24" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 26:
                        textSize.Text = "26" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 28:
                        textSize.Text = "28" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 36:
                        textSize.Text = "36" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 48:
                        textSize.Text = "48" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;

                    case 72:
                        textSize.Text = "72" + " (size)";
                        textFont.Text = selectedParametr2 + " (font)";
                        textBox1.Font = new Font(selectedParametr2, fontNumberSize);
                        break;
                }
            }
        }

        private void btnDark_clicked(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            listBox1.BackColor = Color.Silver;
            listBox2.BackColor = Color.Silver;
            textSize.BackColor = Color.Silver;
            textFont.BackColor = Color.Silver;
            textBox1.BackColor = Color.Gray;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            ErrorField.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnFieldColor.BackColor = Color.Gray;
            btnFieldColor.ForeColor = Color.White;
            btnTextColor.BackColor = Color.Gray;
            btnTextColor.ForeColor = Color.White;
            OpenHtml.BackColor = Color.Gray;
            OpenHtml.ForeColor = Color.White;
            OpenTxt.BackColor = Color.Gray;
            OpenTxt.ForeColor = Color.White;
            btnSaveTxt.BackColor = Color.Gray;
            btnSaveTxt.ForeColor = Color.White;
            btnSaveHtml.BackColor = Color.Gray;
            btnSaveHtml.ForeColor = Color.White;
            btnSelectSizeText.BackColor = Color.Gray;
            btnSelectSizeText.ForeColor = Color.White;
            SearchString.BackColor = Color.Gray;
            SearchString.ForeColor = Color.White;
            btnSearchUrl.BackColor = Color.Gray;
            btnSearchUrl.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
        }

        private void btnLight_clicked(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            listBox1.BackColor = Color.White;
            listBox2.BackColor = Color.White;
            textSize.BackColor = Color.White;
            textFont.BackColor = Color.White;
            textBox1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            ErrorField.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.ForeColor = Color.Black;
            btnFieldColor.BackColor = Color.WhiteSmoke;
            btnFieldColor.ForeColor = Color.Black;
            btnTextColor.BackColor = Color.WhiteSmoke;
            btnTextColor.ForeColor = Color.Black;
            OpenHtml.BackColor = Color.WhiteSmoke;
            OpenHtml.ForeColor = Color.Black;
            OpenTxt.BackColor = Color.WhiteSmoke;
            OpenTxt.ForeColor = Color.Black;
            btnSaveTxt.BackColor = Color.WhiteSmoke;
            btnSaveTxt.ForeColor = Color.Black;
            btnSaveHtml.BackColor = Color.WhiteSmoke;
            btnSaveHtml.ForeColor = Color.Black;
            btnSelectSizeText.BackColor = Color.WhiteSmoke;
            btnSelectSizeText.ForeColor = Color.Black;
            SearchString.BackColor = Color.White;
            SearchString.ForeColor = Color.Black;
            btnSearchUrl.BackColor = Color.WhiteSmoke;
            btnSearchUrl.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
        }
    }
}
