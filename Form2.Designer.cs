namespace WinFormsApp1
{
    partial class Form2
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
            imagem = new PictureBox();
            txt5 = new TextBox();
            txt6 = new TextBox();
            txt7 = new TextBox();
            txt8 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            txt1 = new TextBox();
            txt2 = new TextBox();
            button4 = new Button();
            txt10 = new TextBox();
            txt9 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            imagem2 = new PictureBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)imagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // imagem
            // 
            imagem.Location = new Point(213, 12);
            imagem.Name = "imagem";
            imagem.Size = new Size(282, 146);
            imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            imagem.TabIndex = 7;
            imagem.TabStop = false;
            imagem.Click += imagem_Click;
            // 
            // txt5
            // 
            txt5.BackColor = SystemColors.Control;
            txt5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt5.ForeColor = SystemColors.WindowText;
            txt5.Location = new Point(-7, 163);
            txt5.Name = "txt5";
            txt5.ReadOnly = true;
            txt5.Size = new Size(216, 29);
            txt5.TabIndex = 16;
            txt5.TextAlign = HorizontalAlignment.Center;
            // 
            // txt6
            // 
            txt6.BackColor = SystemColors.Control;
            txt6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.ForeColor = SystemColors.WindowText;
            txt6.Location = new Point(-7, 212);
            txt6.Name = "txt6";
            txt6.ReadOnly = true;
            txt6.Size = new Size(216, 29);
            txt6.TabIndex = 15;
            txt6.TextAlign = HorizontalAlignment.Center;
            txt6.TextChanged += txt5_TextChanged;
            // 
            // txt7
            // 
            txt7.BackColor = SystemColors.Control;
            txt7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt7.ForeColor = SystemColors.WindowText;
            txt7.Location = new Point(-7, 256);
            txt7.Name = "txt7";
            txt7.ReadOnly = true;
            txt7.Size = new Size(216, 29);
            txt7.TabIndex = 20;
            txt7.TextAlign = HorizontalAlignment.Center;
            txt7.TextChanged += txt7_TextChanged;
            // 
            // txt8
            // 
            txt8.BackColor = SystemColors.Control;
            txt8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt8.ForeColor = SystemColors.WindowText;
            txt8.Location = new Point(-7, 301);
            txt8.Name = "txt8";
            txt8.ReadOnly = true;
            txt8.Size = new Size(216, 29);
            txt8.TabIndex = 19;
            txt8.TextAlign = HorizontalAlignment.Center;
            // 
            // txt3
            // 
            txt3.BackColor = SystemColors.Control;
            txt3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt3.ForeColor = SystemColors.WindowText;
            txt3.Location = new Point(-7, 93);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(216, 29);
            txt3.TabIndex = 24;
            txt3.TextAlign = HorizontalAlignment.Center;
            // 
            // txt4
            // 
            txt4.BackColor = SystemColors.Control;
            txt4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt4.ForeColor = SystemColors.WindowText;
            txt4.Location = new Point(-7, 128);
            txt4.Name = "txt4";
            txt4.ReadOnly = true;
            txt4.Size = new Size(216, 29);
            txt4.TabIndex = 23;
            txt4.TextAlign = HorizontalAlignment.Center;
            txt4.TextChanged += txt4_TextChanged;
            // 
            // txt1
            // 
            txt1.BackColor = SystemColors.Control;
            txt1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.ForeColor = SystemColors.WindowText;
            txt1.Location = new Point(-7, 28);
            txt1.Name = "txt1";
            txt1.ReadOnly = true;
            txt1.Size = new Size(216, 29);
            txt1.TabIndex = 22;
            txt1.TextAlign = HorizontalAlignment.Center;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.BackColor = SystemColors.Control;
            txt2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.ForeColor = SystemColors.WindowText;
            txt2.Location = new Point(-7, 64);
            txt2.Name = "txt2";
            txt2.ReadOnly = true;
            txt2.Size = new Size(216, 29);
            txt2.TabIndex = 21;
            txt2.TextAlign = HorizontalAlignment.Center;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(235, 366);
            button4.Name = "button4";
            button4.Size = new Size(184, 23);
            button4.TabIndex = 25;
            button4.Text = "ENVIAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txt10
            // 
            txt10.Location = new Point(235, 337);
            txt10.Name = "txt10";
            txt10.Size = new Size(184, 23);
            txt10.TabIndex = 26;
            // 
            // txt9
            // 
            txt9.Location = new Point(213, 1);
            txt9.Multiline = true;
            txt9.Name = "txt9";
            txt9.ReadOnly = true;
            txt9.Size = new Size(298, 23);
            txt9.TabIndex = 27;
            txt9.Text = "INSIRA O PAÍS";
            txt9.TextChanged += textBox8_TextChanged;
            // 
            // imagem2
            // 
            imagem2.BackColor = SystemColors.Control;
            imagem2.Location = new Point(213, 163);
            imagem2.Name = "imagem2";
            imagem2.Size = new Size(138, 135);
            imagem2.SizeMode = PictureBoxSizeMode.StretchImage;
            imagem2.TabIndex = 29;
            imagem2.TabStop = false;
            imagem2.Click += imagem2_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(501, 1);
            webView21.Name = "webView21";
            webView21.Size = new Size(299, 454);
            webView21.Source = new Uri("https://www.openstreetmap.org/relation", UriKind.Absolute);
            webView21.TabIndex = 30;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(-7, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 454);
            listBox1.TabIndex = 31;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(webView21);
            Controls.Add(imagem2);
            Controls.Add(txt9);
            Controls.Add(txt10);
            Controls.Add(button4);
            Controls.Add(txt3);
            Controls.Add(txt4);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(txt7);
            Controls.Add(txt8);
            Controls.Add(txt5);
            Controls.Add(txt6);
            Controls.Add(imagem);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)imagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imagem;
        private TextBox txt5;
        private TextBox txt6;
        private TextBox txt7;
        private TextBox txt8;
        private TextBox txt3;
        private TextBox txt4;
        private TextBox txt1;
        private TextBox txt2;
        private Button button4;
        private TextBox txt10;
        private TextBox txt9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox imagem2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ListBox listBox1;
    }
}