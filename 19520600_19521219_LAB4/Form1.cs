using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace _19520600_19521219_LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();
            string temp = "";
            char sp = ' ';
            data = data + " ";
            for (int i = 0; i < data.Length; i += 1)
            {
                if (data[i] != sp) temp = temp + data[i];
                else
                {
                    byteList.Add(Convert.ToByte(temp, 2));
                    temp = "";
                }
                
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
    { '0', "0000" },
    { '1', "0001" },
    { '2', "0010" },
    { '3', "0011" },
    { '4', "0100" },
    { '5', "0101" },
    { '6', "0110" },
    { '7', "0111" },
    { '8', "1000" },
    { '9', "1001" },
    { 'a', "1010" },
    { 'b', "1011" },
    { 'c', "1100" },
    { 'd', "1101" },
    { 'e', "1110" },
    { 'f', "1111" }
};

        public string HexToBinary(string hex)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in hex)
            {
                result.Append(hexCharacterToBinary[char.ToLower(c)]);
            }
            string data = result.ToString();
            string temp = "";
            for (int i = 0; i < data.Length; i+=1)
            {
                if (i % 8 == 0 && i != 0)
                {
                    temp = temp + " ";                
                }
                temp = temp + data[i];
            }
            return temp;

        }

        public static string Create_MD5(string input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);

            bs = md5.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)

            {

                s.Append(b.ToString("x2").ToLower());

            }

            input = s.ToString();

            return input;
        }

        static string Create_SHA1(string input)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);

            bs = sha1.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)

            {

                s.Append(b.ToString("x2").ToLower());

            }

            input = s.ToString();

            return input;
        }

        static string Create_SHA256(string input)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);

            bs = sha256.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)

            {

                s.Append(b.ToString("x2").ToLower());

            }

            input = s.ToString();

            return input;

        }

        static string Create_SHA512(string input)
        {
            SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);

            bs = sha512.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)

            {

                s.Append(b.ToString("x2").ToLower());

            }

            input = s.ToString();

            return input;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            string input_data = rtb_Input.Text.ToString();
            if (input_data == "")
            {
                MessageBox.Show("Plese Enter input data!");
                rtb_MD5.Text = "";
                rtb_SHA1.Text = "";
                rtb_SHA256.Text = "";
                rtb_SHA512.Text = "";
            }
            else
            {
                string data_format = cb_DataFormat.Text.ToString();
                if (data_format == "")
                {
                    MessageBox.Show("Please choose data format!");
                }
                else
                {
                    if (data_format == "Hex string")
                    {
                        input_data = HexToBinary(input_data);
                        input_data = BinaryToString(input_data);
                    }
                    if (cb_MD5.Checked) rtb_MD5.Text = Create_MD5(input_data);
                    else rtb_MD5.Text = "";
                    if (cb_SHA1.Checked) rtb_SHA1.Text = Create_SHA1(input_data);
                    else rtb_SHA1.Text = "";
                    if (cb_SHA256.Checked) rtb_SHA256.Text = Create_SHA256(input_data);
                    else rtb_SHA256.Text = "";
                    if (cb_SHA512.Checked) rtb_SHA512.Text = Create_SHA512(input_data);
                    else rtb_SHA512.Text = "";
                }
            }
        }

        private void btn_ReadBinaryFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            FileStream fs = new FileStream(of.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            rtb_Input.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}