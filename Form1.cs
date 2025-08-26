using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace affine_cipher
{
    public partial class Form1 : Form
    {
        Dictionary <char, int> alphabet = new Dictionary <char, int>();

        Dictionary <int, string> numbers = new Dictionary <int, string>()
        {
            {0, "XZEROX"},
            {1, "XONEX"},
            {2, "XTWOX"},
            {3, "XTHREEX"},
            {4, "XFOURX"},
            {5, "XFIVEX"},
            {6, "XSIXX"},
            {7, "XSEVENX"},
            {8, "XEIGHTX"},
            {9, "XNINEX"}
        };
    
        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 26; i++) { alphabet.Add((char)(i+65), i); }

            button_keys_change.Enabled = false;
            textBox_text_input.Enabled = false;
            button_encode.Enabled = false;
            button_text_filter.Enabled = false;
            button_decode.Enabled = false;
            button_encoded_table.Enabled = false;
        }

        private void button_encode_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_a_key.Text);
            int b = int.Parse(textBox_b_key.Text);

            if (textBox_text_input.Text == "")
            {
                MessageBox.Show("Please enter a text!");
            }
            
            string filtratedString = FilterString(textBox_text_input.Text);
            string encodedString = EncodeString(filtratedString, a, b);
            string encodedStringDivided = "";
            int i = 1;
            foreach (char c in encodedString)
            {
                encodedStringDivided += c;
                if (i == 5) {
                    encodedStringDivided += ' ';
                    i = 0;
                }
                i++;
            }
            textBox_text_output.Text = encodedStringDivided;
        }
        
        private void button_decode_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_a_key.Text);
            int b = int.Parse(textBox_b_key.Text);
            
            if (textBox_text_input.Text == "")
            {
                MessageBox.Show("Please enter a text!");
            }

            string encodedString = textBox_text_input.Text.ToUpper();
            encodedString = encodedString.Replace(" ", "");
            encodedString = encodedString.Replace("\n", "");
            string decodedString = DecodeString(encodedString, a, b);
            string defiltratedString = DefilterString(decodedString);
            
            textBox_text_output.Text = defiltratedString;
        }
        
        private void button_text_filter_Click(object sender, EventArgs e)
        {
            textBox_text_output.Text = FilterString(textBox_text_input.Text);
        }

        private void button_keys_check_Click(object sender, EventArgs e)
        {
            string a_str = textBox_a_key.Text;
            string b = textBox_b_key.Text;

            if (a_str == "" || b == "")
            {
                MessageBox.Show("Please enter a valid keys!");
                return;
            }
            
            int a = int.Parse(a_str);
            
            if (a < 0)
            {
                while (a < 0)
                {
                    a = a + 26;
                }
                textBox_a_key.Text = a.ToString();
                MessageBox.Show("Changed A key to positive!");
            }
            else if (GCD(a, 26) != 1)
            {
                MessageBox.Show($"GCD({a}, 26) != 1.");
            }
            else
            {
                MessageBox.Show("Keys are ok!");
                textBox_a_key.Enabled = false;
                textBox_b_key.Enabled = false;
                button_keys_check.Enabled = false;
                button_keys_change.Enabled = true;
                textBox_text_input.Enabled = true;
                button_encode.Enabled = true;
                button_text_filter.Enabled = true;
                button_decode.Enabled = true;
                button_encoded_table.Enabled = true;
            }
        }
        
        private void button_keys_change_Click(object sender, EventArgs e)
        {
            textBox_a_key.Enabled = true;
            textBox_b_key.Enabled = true;
            button_keys_check.Enabled = true;
            button_keys_change.Enabled = false;
            textBox_text_input.Enabled = false;
            button_encode.Enabled = false;
            button_text_filter.Enabled = false;
            button_decode.Enabled = false;
            button_encoded_table.Enabled = false;
        }
        
        string EncodeString(string inputText, int a, int b)
        {
            int[] encodedArray = new int[inputText.Length];
            int j = 0;

            foreach (char c in inputText)
            {
                int temp = (a*alphabet[c] + b)%26;
                encodedArray[j] = temp;
                j++;
            }

            string encodedString = "";

            foreach (int i in encodedArray)
            {
                encodedString += alphabet.Keys.ElementAt(i);
            }
    
    
            return encodedString;
        }

        string FilterString(string openText)
        {
            string normalizedText = openText.Normalize(NormalizationForm.FormD);

            string filteredText = "";

            foreach (char c in normalizedText)
            {
                if (Char.IsUpper(c))
                {
                    filteredText = filteredText + c;
                }
                else if (Char.IsLower(c))
                {
                    char new_c = (char)((int)c - 32);
                    filteredText = filteredText + new_c;
                }
                else if (c == ' ')
                {
                    filteredText = filteredText + "XSPACEX";
                }
                else if (char.IsDigit(c))
                {
                    filteredText += numbers[(int)char.GetNumericValue(c)];
                }
            }
            return filteredText;
        }
        
        string DecodeString(string encodedText, int a, int b)
        {
            int[] decodedArray = new int[encodedText.Length];
            int j = 0;
            int step = 0;
    
            foreach (char c in encodedText)
            {
                float temp = (alphabet[c] - b) / (float)a;
        
                while (Math.Abs(temp - Math.Round(temp)) > 0.00001 || temp < 0)
                {
                    step += 26;
                    temp = (alphabet[c] - b + step) / (float)a;
                }
        
                decodedArray[j] = (int)temp;

                j++;
                step = 0;
            }
    
            string decodedString = "";
    
            foreach (int i in decodedArray)
            {
                decodedString += alphabet.Keys.ElementAt(i);
            }
    
            return decodedString;
        }

        string DefilterString(string text_input)
        {
            string defilteredText = text_input.Replace("XSPACEX", " ");
            for (int i = 0; i < 10; i++)
            {
                defilteredText = defilteredText.Replace($"{numbers[i]}", $"{numbers.Keys.ElementAt(i)}");
            }
            return defilteredText;
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            string info1 = "";
            string numbers1 = "";
            
            for(int i = 0; i<26; i++)
            {
                info1 += alphabet.Keys.ElementAt(i) + " ";
                numbers1 += i + " ";
            }
            
            string info2 = "";
            string numbers2 = "";
            for (int i = 0; i < 10; i++)
            {
                info2 += numbers.Keys.ElementAt(i) + " ";
                numbers2 += numbers[i] + " ";
            }

            MessageBox.Show(
                $"{info1}, represented as numbers:\n{numbers1} \n\n{info2}, represented as codes:\n{numbers2}" +
                $"\n\nSpaces represented as XSPACEX" +
                $"\n\nAll special symbols will be deleted. Each symbol translates to uppercase.");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_encoded_table_Click(object sender, EventArgs e)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int a = int.Parse(textBox_a_key.Text);
            int b = int.Parse(textBox_b_key.Text);

            MessageBox.Show($"Encoded table:\n{EncodeString(abc, a, b)}");
        }
    }
}