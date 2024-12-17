namespace HostsChanger
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
            Local_Button = new Button();
            Soto_Button = new Button();
            setting_button = new Button();
            SuspendLayout();
            // 
            // Local_Button
            // 
            Local_Button.Location = new Point(12, 48);
            Local_Button.Name = "Local_Button";
            Local_Button.Size = new Size(256, 256);
            Local_Button.TabIndex = 0;
            Local_Button.Text = "お家";
            Local_Button.UseVisualStyleBackColor = true;
            Local_Button.Click += Local_Button_Click;
            // 
            // Soto_Button
            // 
            Soto_Button.Location = new Point(274, 48);
            Soto_Button.Name = "Soto_Button";
            Soto_Button.Size = new Size(256, 256);
            Soto_Button.TabIndex = 1;
            Soto_Button.Text = "お外";
            Soto_Button.UseVisualStyleBackColor = true;
            Soto_Button.Click += Soto_Button_Click;
            // 
            // setting_button
            // 
            setting_button.Location = new Point(12, 12);
            setting_button.Name = "setting_button";
            setting_button.Size = new Size(518, 29);
            setting_button.TabIndex = 2;
            setting_button.Text = "設定";
            setting_button.UseVisualStyleBackColor = true;
            setting_button.Click += setting_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 316);
            Controls.Add(setting_button);
            Controls.Add(Soto_Button);
            Controls.Add(Local_Button);
            Name = "Form1";
            Text = "hosts書き換えくん";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Local_Button;
        private Button Soto_Button;
        private Button setting_button;
    }
}
