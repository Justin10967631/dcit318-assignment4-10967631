namespace AddressApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_phonenumber = new TextBox();
            txt_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 96);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 161);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 227);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "PhoneNumber";
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_name.Location = new Point(232, 88);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(176, 23);
            txt_name.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Location = new Point(237, 153);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(171, 23);
            txt_email.TabIndex = 4;
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_phonenumber.Location = new Point(237, 224);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(171, 23);
            txt_phonenumber.TabIndex = 5;
            // 
            // txt_save
            // 
            txt_save.Location = new Point(333, 306);
            txt_save.Name = "txt_save";
            txt_save.Size = new Size(75, 23);
            txt_save.TabIndex = 6;
            txt_save.Text = "Save";
            txt_save.UseVisualStyleBackColor = true;
            txt_save.Click += txt_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 419);
            Controls.Add(txt_save);
            Controls.Add(txt_phonenumber);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_phonenumber;
        private Button txt_save;
    }
}
