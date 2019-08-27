namespace MikrotikEmoji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.button_encode = new System.Windows.Forms.Button();
            this.label1_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_des = new System.Windows.Forms.Label();
            this.textBox_byte = new System.Windows.Forms.TextBox();
            this.label_unicode = new System.Windows.Forms.Label();
            this.label_emoji = new System.Windows.Forms.Label();
            this.button_unicode = new System.Windows.Forms.Button();
            this.label_hex = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label_mikrotik = new System.Windows.Forms.Label();
            this.label_emojiLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_source
            // 
            this.textBox_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_source.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_source.Location = new System.Drawing.Point(73, 86);
            this.textBox_source.MaxLength = 32;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(439, 29);
            this.textBox_source.TabIndex = 0;
            this.textBox_source.Click += new System.EventHandler(this.TextBox_source_Click);
            // 
            // textBox_destination
            // 
            this.textBox_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_destination.Location = new System.Drawing.Point(91, 373);
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(252, 26);
            this.textBox_destination.TabIndex = 1;
            // 
            // button_encode
            // 
            this.button_encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_encode.Location = new System.Drawing.Point(73, 238);
            this.button_encode.Name = "button_encode";
            this.button_encode.Size = new System.Drawing.Size(154, 29);
            this.button_encode.TabIndex = 2;
            this.button_encode.Text = "Transform to Hex";
            this.button_encode.UseVisualStyleBackColor = true;
            this.button_encode.Click += new System.EventHandler(this.Button_encode_Click);
            // 
            // label1_title
            // 
            this.label1_title.AutoSize = true;
            this.label1_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_title.Location = new System.Drawing.Point(108, 9);
            this.label1_title.Name = "label1_title";
            this.label1_title.Size = new System.Drawing.Size(315, 24);
            this.label1_title.TabIndex = 3;
            this.label1_title.Text = "Mikrotik Unicode SSID Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter unicode text or emojis you want to use for the SSID:";
            // 
            // label3_des
            // 
            this.label3_des.AutoSize = true;
            this.label3_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_des.Location = new System.Drawing.Point(69, 278);
            this.label3_des.Name = "label3_des";
            this.label3_des.Size = new System.Drawing.Size(401, 80);
            this.label3_des.TabIndex = 5;
            this.label3_des.Text = "SSIDs are limited to 32 bytes. \r\nUnicode characters can consume up to 4 bytes eac" +
    "h. \r\nYou can find some useful characters to copy and paste \r\nfrom the";
            // 
            // textBox_byte
            // 
            this.textBox_byte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_byte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_byte.Location = new System.Drawing.Point(73, 136);
            this.textBox_byte.Name = "textBox_byte";
            this.textBox_byte.Size = new System.Drawing.Size(439, 26);
            this.textBox_byte.TabIndex = 6;
            // 
            // label_unicode
            // 
            this.label_unicode.AutoSize = true;
            this.label_unicode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unicode.Location = new System.Drawing.Point(17, 376);
            this.label_unicode.Name = "label_unicode";
            this.label_unicode.Size = new System.Drawing.Size(68, 20);
            this.label_unicode.TabIndex = 7;
            this.label_unicode.Text = "Unicode";
            // 
            // label_emoji
            // 
            this.label_emoji.AutoSize = true;
            this.label_emoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emoji.Location = new System.Drawing.Point(19, 90);
            this.label_emoji.Name = "label_emoji";
            this.label_emoji.Size = new System.Drawing.Size(48, 20);
            this.label_emoji.TabIndex = 8;
            this.label_emoji.Text = "Emoji";
            // 
            // button_unicode
            // 
            this.button_unicode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unicode.Location = new System.Drawing.Point(349, 373);
            this.button_unicode.Name = "button_unicode";
            this.button_unicode.Size = new System.Drawing.Size(163, 26);
            this.button_unicode.TabIndex = 9;
            this.button_unicode.Text = "Get char Unicode";
            this.button_unicode.UseVisualStyleBackColor = true;
            this.button_unicode.Click += new System.EventHandler(this.Button_unicode_Click);
            // 
            // label_hex
            // 
            this.label_hex.AutoSize = true;
            this.label_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hex.Location = new System.Drawing.Point(30, 139);
            this.label_hex.Name = "label_hex";
            this.label_hex.Size = new System.Drawing.Size(37, 20);
            this.label_hex.TabIndex = 10;
            this.label_hex.Text = "Hex";
            // 
            // textBox_code
            // 
            this.textBox_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_code.Location = new System.Drawing.Point(73, 178);
            this.textBox_code.Multiline = true;
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_code.Size = new System.Drawing.Size(439, 54);
            this.textBox_code.TabIndex = 11;
            // 
            // label_mikrotik
            // 
            this.label_mikrotik.AutoSize = true;
            this.label_mikrotik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mikrotik.Location = new System.Drawing.Point(20, 194);
            this.label_mikrotik.Name = "label_mikrotik";
            this.label_mikrotik.Size = new System.Drawing.Size(47, 20);
            this.label_mikrotik.TabIndex = 12;
            this.label_mikrotik.Text = "Code";
            // 
            // label_emojiLink
            // 
            this.label_emojiLink.AutoSize = true;
            this.label_emojiLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emojiLink.ForeColor = System.Drawing.Color.Blue;
            this.label_emojiLink.Location = new System.Drawing.Point(132, 338);
            this.label_emojiLink.Name = "label_emojiLink";
            this.label_emojiLink.Size = new System.Drawing.Size(211, 20);
            this.label_emojiLink.TabIndex = 13;
            this.label_emojiLink.Text = "Unicode.org\'s Full Emoji List.";
            this.label_emojiLink.Click += new System.EventHandler(this.Label_emojiLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 424);
            this.Controls.Add(this.label_emojiLink);
            this.Controls.Add(this.label_mikrotik);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label_hex);
            this.Controls.Add(this.button_unicode);
            this.Controls.Add(this.label_emoji);
            this.Controls.Add(this.label_unicode);
            this.Controls.Add(this.textBox_byte);
            this.Controls.Add(this.label3_des);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1_title);
            this.Controls.Add(this.button_encode);
            this.Controls.Add(this.textBox_destination);
            this.Controls.Add(this.textBox_source);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 463);
            this.MinimumSize = new System.Drawing.Size(550, 463);
            this.Name = "Form1";
            this.Text = "Mikrotik Unicode SSID Generator v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.Button button_encode;
        private System.Windows.Forms.Label label1_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_des;
        private System.Windows.Forms.TextBox textBox_byte;
        private System.Windows.Forms.Label label_unicode;
        private System.Windows.Forms.Label label_emoji;
        private System.Windows.Forms.Button button_unicode;
        private System.Windows.Forms.Label label_hex;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label_mikrotik;
        private System.Windows.Forms.Label label_emojiLink;
    }
}

