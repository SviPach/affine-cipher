using System;

namespace affine_cipher
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        
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
            this.button_encode = new System.Windows.Forms.Button();
            this.button_decode = new System.Windows.Forms.Button();
            this.textBox_text_input = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_a_key = new System.Windows.Forms.TextBox();
            this.textBox_b_key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_text_output = new System.Windows.Forms.RichTextBox();
            this.button_keys_check = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.button_keys_change = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_text_filter = new System.Windows.Forms.Button();
            this.button_encoded_table = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_encode
            // 
            this.button_encode.Location = new System.Drawing.Point(53, 278);
            this.button_encode.Name = "button_encode";
            this.button_encode.Size = new System.Drawing.Size(102, 30);
            this.button_encode.TabIndex = 0;
            this.button_encode.Text = "Encode";
            this.button_encode.UseVisualStyleBackColor = true;
            this.button_encode.Click += new System.EventHandler(this.button_encode_Click);
            // 
            // button_decode
            // 
            this.button_decode.Location = new System.Drawing.Point(282, 278);
            this.button_decode.Name = "button_decode";
            this.button_decode.Size = new System.Drawing.Size(102, 30);
            this.button_decode.TabIndex = 1;
            this.button_decode.Text = "Decode";
            this.button_decode.UseVisualStyleBackColor = true;
            this.button_decode.Click += new System.EventHandler(this.button_decode_Click);
            // 
            // textBox_text_input
            // 
            this.textBox_text_input.Location = new System.Drawing.Point(53, 176);
            this.textBox_text_input.Name = "textBox_text_input";
            this.textBox_text_input.Size = new System.Drawing.Size(331, 96);
            this.textBox_text_input.TabIndex = 2;
            this.textBox_text_input.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input text:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(579, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output text:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keys:";
            // 
            // textBox_a_key
            // 
            this.textBox_a_key.Location = new System.Drawing.Point(83, 72);
            this.textBox_a_key.Name = "textBox_a_key";
            this.textBox_a_key.Size = new System.Drawing.Size(100, 22);
            this.textBox_a_key.TabIndex = 7;
            // 
            // textBox_b_key
            // 
            this.textBox_b_key.Location = new System.Drawing.Point(284, 71);
            this.textBox_b_key.Name = "textBox_b_key";
            this.textBox_b_key.Size = new System.Drawing.Size(100, 22);
            this.textBox_b_key.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(257, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "B:";
            // 
            // textBox_text_output
            // 
            this.textBox_text_output.Location = new System.Drawing.Point(579, 44);
            this.textBox_text_output.Name = "textBox_text_output";
            this.textBox_text_output.Size = new System.Drawing.Size(385, 373);
            this.textBox_text_output.TabIndex = 12;
            this.textBox_text_output.Text = "";
            // 
            // button_keys_check
            // 
            this.button_keys_check.Location = new System.Drawing.Point(83, 100);
            this.button_keys_check.Name = "button_keys_check";
            this.button_keys_check.Size = new System.Drawing.Size(137, 28);
            this.button_keys_check.TabIndex = 13;
            this.button_keys_check.Text = "Check keys";
            this.button_keys_check.UseVisualStyleBackColor = true;
            this.button_keys_check.Click += new System.EventHandler(this.button_keys_check_Click);
            // 
            // button_info
            // 
            this.button_info.Location = new System.Drawing.Point(55, 394);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(75, 23);
            this.button_info.TabIndex = 14;
            this.button_info.Text = "Info";
            this.button_info.UseMnemonic = false;
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_keys_change
            // 
            this.button_keys_change.Location = new System.Drawing.Point(238, 100);
            this.button_keys_change.Name = "button_keys_change";
            this.button_keys_change.Size = new System.Drawing.Size(146, 28);
            this.button_keys_change.TabIndex = 15;
            this.button_keys_change.Text = "Change keys";
            this.button_keys_change.UseVisualStyleBackColor = true;
            this.button_keys_change.Click += new System.EventHandler(this.button_keys_change_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(309, 394);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_text_filter
            // 
            this.button_text_filter.Location = new System.Drawing.Point(161, 278);
            this.button_text_filter.Name = "button_text_filter";
            this.button_text_filter.Size = new System.Drawing.Size(115, 30);
            this.button_text_filter.TabIndex = 17;
            this.button_text_filter.Text = "Filter";
            this.button_text_filter.UseVisualStyleBackColor = true;
            this.button_text_filter.Click += new System.EventHandler(this.button_text_filter_Click);
            // 
            // button_encoded_table
            // 
            this.button_encoded_table.Location = new System.Drawing.Point(158, 394);
            this.button_encoded_table.Name = "button_encoded_table";
            this.button_encoded_table.Size = new System.Drawing.Size(120, 23);
            this.button_encoded_table.TabIndex = 18;
            this.button_encoded_table.Text = "Encoded table";
            this.button_encoded_table.UseVisualStyleBackColor = true;
            this.button_encoded_table.Click += new System.EventHandler(this.button_encoded_table_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.button_encoded_table);
            this.Controls.Add(this.button_text_filter);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_keys_change);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_keys_check);
            this.Controls.Add(this.textBox_text_output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_b_key);
            this.Controls.Add(this.textBox_a_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_text_input);
            this.Controls.Add(this.button_decode);
            this.Controls.Add(this.button_encode);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_encoded_table;

        private System.Windows.Forms.Button button_text_filter;

        private System.Windows.Forms.Button button_exit;

        private System.Windows.Forms.Button button_keys_change;

        private System.Windows.Forms.Button button_info;

        private System.Windows.Forms.Button button_keys_check;

        private System.Windows.Forms.RichTextBox textBox_text_output;

        private System.Windows.Forms.TextBox textBox_a_key;
        private System.Windows.Forms.TextBox textBox_b_key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox_text_input;

        private System.Windows.Forms.Button button_encode;
        private System.Windows.Forms.Button button_decode;

        #endregion
    }
}