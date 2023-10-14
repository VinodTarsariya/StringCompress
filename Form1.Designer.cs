namespace StringCompress
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
            richTextBox1 = new RichTextBox();
            btn_compress = new Button();
            richTextBox2 = new RichTextBox();
            btn_decompress = new Button();
            textBox1 = new TextBox();
            btn_convert_to_base64 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 155);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btn_compress
            // 
            btn_compress.Location = new Point(12, 176);
            btn_compress.Name = "btn_compress";
            btn_compress.Size = new Size(75, 23);
            btn_compress.TabIndex = 2;
            btn_compress.Text = "Compress";
            btn_compress.UseVisualStyleBackColor = true;
            btn_compress.Click += btn_compress_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 256);
            richTextBox2.Margin = new Padding(20);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(776, 269);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // btn_decompress
            // 
            btn_decompress.Location = new Point(93, 176);
            btn_decompress.Name = "btn_decompress";
            btn_decompress.Size = new Size(75, 23);
            btn_decompress.TabIndex = 4;
            btn_decompress.Text = "Decompress";
            btn_decompress.UseVisualStyleBackColor = true;
            btn_decompress.Click += btn_decompress_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 5;
            // 
            // btn_convert_to_base64
            // 
            btn_convert_to_base64.Location = new Point(381, 202);
            btn_convert_to_base64.Name = "btn_convert_to_base64";
            btn_convert_to_base64.Size = new Size(134, 23);
            btn_convert_to_base64.TabIndex = 6;
            btn_convert_to_base64.Text = "Convert to Base64";
            btn_convert_to_base64.UseVisualStyleBackColor = true;
            btn_convert_to_base64.Click += btn_convert_to_base64_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(btn_convert_to_base64);
            Controls.Add(textBox1);
            Controls.Add(btn_decompress);
            Controls.Add(richTextBox2);
            Controls.Add(btn_compress);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_compress;
        private RichTextBox richTextBox2;
        private Button btn_decompress;
        private TextBox textBox1;
        private Button btn_convert_to_base64;
    }
}