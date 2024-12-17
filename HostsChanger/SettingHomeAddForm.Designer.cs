namespace HostsChanger
{
    partial class SettingHomeAddForm
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
            DomainTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            IP_TextBox = new TextBox();
            OKButton = new Button();
            Jametabutton = new Button();
            SuspendLayout();
            // 
            // DomainTextBox
            // 
            DomainTextBox.Location = new Point(12, 36);
            DomainTextBox.Name = "DomainTextBox";
            DomainTextBox.Size = new Size(310, 27);
            DomainTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "ドメイン";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 2;
            label2.Text = "IP";
            // 
            // IP_TextBox
            // 
            IP_TextBox.Location = new Point(12, 104);
            IP_TextBox.Name = "IP_TextBox";
            IP_TextBox.Size = new Size(310, 27);
            IP_TextBox.TabIndex = 3;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(167, 139);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(155, 29);
            OKButton.TabIndex = 4;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // Jametabutton
            // 
            Jametabutton.Location = new Point(12, 139);
            Jametabutton.Name = "Jametabutton";
            Jametabutton.Size = new Size(149, 29);
            Jametabutton.TabIndex = 5;
            Jametabutton.Text = "やめた";
            Jametabutton.UseVisualStyleBackColor = true;
            Jametabutton.Click += Jametabutton_Click;
            // 
            // SettingHomeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 180);
            Controls.Add(Jametabutton);
            Controls.Add(OKButton);
            Controls.Add(IP_TextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DomainTextBox);
            Name = "SettingHomeAddForm";
            Text = "SettingHomeAddForm";
            Load += SettingHomeAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DomainTextBox;
        private Label label1;
        private Label label2;
        private TextBox IP_TextBox;
        private Button OKButton;
        private Button Jametabutton;
    }
}