namespace Text_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveTxt = new System.Windows.Forms.Button();
            this.OpenTxt = new System.Windows.Forms.Button();
            this.btnSaveHtml = new System.Windows.Forms.Button();
            this.OpenHtml = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.webView = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchString = new System.Windows.Forms.TextBox();
            this.btnSearchUrl = new System.Windows.Forms.Button();
            this.btnFieldColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectSizeText = new System.Windows.Forms.Button();
            this.ErrorField = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textFont = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnDark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(160, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(489, 578);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Write your text here!";
            // 
            // btnSaveTxt
            // 
            this.btnSaveTxt.AutoSize = true;
            this.btnSaveTxt.Location = new System.Drawing.Point(12, 13);
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveTxt.Size = new System.Drawing.Size(142, 23);
            this.btnSaveTxt.TabIndex = 1;
            this.btnSaveTxt.Text = "Save as (.txt)";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.btnSaveTxt_clicked);
            // 
            // OpenTxt
            // 
            this.OpenTxt.Location = new System.Drawing.Point(12, 71);
            this.OpenTxt.Name = "OpenTxt";
            this.OpenTxt.Size = new System.Drawing.Size(142, 23);
            this.OpenTxt.TabIndex = 2;
            this.OpenTxt.Text = "Open (.txt)";
            this.OpenTxt.UseVisualStyleBackColor = true;
            this.OpenTxt.Click += new System.EventHandler(this.btnOpenTxt_clicked);
            // 
            // btnSaveHtml
            // 
            this.btnSaveHtml.Location = new System.Drawing.Point(12, 42);
            this.btnSaveHtml.Name = "btnSaveHtml";
            this.btnSaveHtml.Size = new System.Drawing.Size(142, 23);
            this.btnSaveHtml.TabIndex = 3;
            this.btnSaveHtml.Text = "Save as (.html)";
            this.btnSaveHtml.UseVisualStyleBackColor = true;
            this.btnSaveHtml.Click += new System.EventHandler(this.btnSaveHtml_clicked);
            // 
            // OpenHtml
            // 
            this.OpenHtml.Location = new System.Drawing.Point(12, 100);
            this.OpenHtml.Name = "OpenHtml";
            this.OpenHtml.Size = new System.Drawing.Size(142, 23);
            this.OpenHtml.TabIndex = 4;
            this.OpenHtml.Text = "Open (.html)";
            this.OpenHtml.UseVisualStyleBackColor = true;
            this.OpenHtml.Click += new System.EventHandler(this.btnOpenHtml_clicked);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_clicked);
            // 
            // webView
            // 
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.Location = new System.Drawing.Point(655, 92);
            this.webView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(305, 486);
            this.webView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(730, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Web Browser";
            // 
            // SearchString
            // 
            this.SearchString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchString.Location = new System.Drawing.Point(655, 44);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(293, 20);
            this.SearchString.TabIndex = 8;
            this.SearchString.Text = "enter url";
            // 
            // btnSearchUrl
            // 
            this.btnSearchUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchUrl.Location = new System.Drawing.Point(655, 63);
            this.btnSearchUrl.Name = "btnSearchUrl";
            this.btnSearchUrl.Size = new System.Drawing.Size(293, 23);
            this.btnSearchUrl.TabIndex = 9;
            this.btnSearchUrl.Text = "search";
            this.btnSearchUrl.UseVisualStyleBackColor = true;
            this.btnSearchUrl.Click += new System.EventHandler(this.btnSearchUrl_clicked);
            // 
            // btnFieldColor
            // 
            this.btnFieldColor.Location = new System.Drawing.Point(12, 159);
            this.btnFieldColor.Name = "btnFieldColor";
            this.btnFieldColor.Size = new System.Drawing.Size(142, 23);
            this.btnFieldColor.TabIndex = 10;
            this.btnFieldColor.Text = "Input field color";
            this.btnFieldColor.UseVisualStyleBackColor = true;
            this.btnFieldColor.Click += new System.EventHandler(this.btnFieldColor_clicked);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(12, 188);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(142, 23);
            this.btnTextColor.TabIndex = 11;
            this.btnTextColor.Text = "Text color";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_clicked);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.listBox1.Location = new System.Drawing.Point(12, 325);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 95);
            this.listBox1.TabIndex = 12;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(12, 248);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(142, 20);
            this.textSize.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Text Font:";
            // 
            // btnSelectSizeText
            // 
            this.btnSelectSizeText.Location = new System.Drawing.Point(12, 543);
            this.btnSelectSizeText.Name = "btnSelectSizeText";
            this.btnSelectSizeText.Size = new System.Drawing.Size(142, 23);
            this.btnSelectSizeText.TabIndex = 15;
            this.btnSelectSizeText.Text = "Select";
            this.btnSelectSizeText.UseVisualStyleBackColor = true;
            this.btnSelectSizeText.Click += new System.EventHandler(this.btnSizeText_clicked);
            // 
            // ErrorField
            // 
            this.ErrorField.AutoSize = true;
            this.ErrorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorField.ForeColor = System.Drawing.Color.Black;
            this.ErrorField.Location = new System.Drawing.Point(12, 306);
            this.ErrorField.Name = "ErrorField";
            this.ErrorField.Size = new System.Drawing.Size(132, 16);
            this.ErrorField.TabIndex = 16;
            this.ErrorField.Text = "choose text size here";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Arial",
            "Verdana",
            "Microsoft Sans Serif",
            "Bold",
            "Italic",
            "Tahoma",
            "Impact",
            "Jokerman",
            "Calibri",
            "Times New Roman",
            "Segoe UI"});
            this.listBox2.Location = new System.Drawing.Point(12, 442);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(142, 95);
            this.listBox2.TabIndex = 17;
            // 
            // textFont
            // 
            this.textFont.Location = new System.Drawing.Point(12, 274);
            this.textFont.Name = "textFont";
            this.textFont.Size = new System.Drawing.Size(142, 20);
            this.textFont.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "choose text font here";
            // 
            // btnLight
            // 
            this.btnLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLight.Location = new System.Drawing.Point(655, 2);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(59, 40);
            this.btnLight.TabIndex = 20;
            this.btnLight.Text = "light theme";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_clicked);
            // 
            // btnDark
            // 
            this.btnDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDark.Location = new System.Drawing.Point(895, 2);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(63, 40);
            this.btnDark.TabIndex = 21;
            this.btnDark.Text = "dark theme";
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 578);
            this.Controls.Add(this.btnDark);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFont);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ErrorField);
            this.Controls.Add(this.btnSelectSizeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btnFieldColor);
            this.Controls.Add(this.btnSearchUrl);
            this.Controls.Add(this.SearchString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.OpenHtml);
            this.Controls.Add(this.btnSaveHtml);
            this.Controls.Add(this.OpenTxt);
            this.Controls.Add(this.btnSaveTxt);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Max Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveTxt;
        private System.Windows.Forms.Button OpenTxt;
        private System.Windows.Forms.Button btnSaveHtml;
        private System.Windows.Forms.Button OpenHtml;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.WebBrowser webView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchString;
        private System.Windows.Forms.Button btnSearchUrl;
        private System.Windows.Forms.Button btnFieldColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectSizeText;
        private System.Windows.Forms.Label ErrorField;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnDark;
    }
}

