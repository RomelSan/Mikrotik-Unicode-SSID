using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MikrotikEmoji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Got the idea from https://r-1.ch/mikrotik-unicode-ssid-generator.php
        private void Label_emojiLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://unicode.org/emoji/charts/full-emoji-list.html");
        }
        private void Button_encode_Click(object sender, EventArgs e)
        {
            string emoji = textBox_source.Text;
            string hex = ConvertStringToHex(emoji, System.Text.Encoding.UTF8);
            textBox_byte.Text = hex;

            string mikrotik = Regex.Replace(hex, ".{2}(?!$)", "$0\\");
            textBox_code.Text = "/interface wireless set [find name=\"wlan1\"] ssid=\"\\" + mikrotik + "\"";
        }
        private void Button_unicode_Click(object sender, EventArgs e)
        {
            try
            {
            string emoji = textBox_source.Text;
            string result = ConvertEmoji2UnicodeHex(emoji);
            textBox_destination.Text = @"U+" + result.ToUpper();
            }
            catch
            {
                textBox_destination.Text = "Input one emoji only";
            }
        }

        #region Conversions
        public static string ConvertStringToHex(string emoji, System.Text.Encoding encoding)
        {
            Byte[] stringBytes = encoding.GetBytes(emoji);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.AppendFormat("{0:X2}", b);
            }
            return sbBytes.ToString();
        }
        public static string ConvertHexToString(String hexInput, System.Text.Encoding encoding)
        {
            int numberChars = hexInput.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }

        public static string ConvertEmoji2UnicodeHex(string emoji)
        {
            // Emoji to Unicode Hex ( U+ )
            if (string.IsNullOrWhiteSpace(emoji))
                return emoji;

            byte[] bytes = Encoding.UTF8.GetBytes(emoji);
            string firstItem = Convert.ToString(bytes[0], 2);

            int iv;
            if (bytes.Length == 1)
            {
                iv = Convert.ToInt32(firstItem, 2);
            }
            else
            {
                StringBuilder sbBinary = new StringBuilder();
                sbBinary.Append(firstItem.Substring(bytes.Length + 1).TrimStart('0'));
                for (int i = 1; i < bytes.Length; i++)
                {
                    string item = Convert.ToString(bytes[i], 2);
                    item = item.Substring(2);
                    sbBinary.Append(item);
                }

                iv = Convert.ToInt32(sbBinary.ToString(), 2);
            }

            return Convert.ToString(iv, 16).PadLeft(4, '0');
        }
        #endregion
        #region Keyboard send Command
        private void TextBox_source_Click(object sender, EventArgs e)
        {
            KeyboardSend.KeyDown(Keys.LWin);
            KeyboardSend.KeyDown(Keys.OemPeriod);
            KeyboardSend.KeyUp(Keys.LWin);
            KeyboardSend.KeyUp(Keys.OemPeriod);
        }
        static class KeyboardSend
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

            private const int KEYEVENTF_EXTENDEDKEY = 1;
            private const int KEYEVENTF_KEYUP = 2;

            public static void KeyDown(Keys vKey)
            {
                keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
            }

            public static void KeyUp(Keys vKey)
            {
                keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
            /* USAGE (Send Windows Key)
             * KeyboardSend.KeyDown(Keys.LWin);
                KeyboardSend.KeyUp(Keys.LWin);
            */
        }
        #endregion

    }
}
