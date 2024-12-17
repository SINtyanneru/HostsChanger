namespace HostsChanger
{
    partial class SettingForm
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
            HomeHostsContentsListView = new ListView();
            DomainHeader = new ColumnHeader();
            IP_Header = new ColumnHeader();
            button1 = new Button();
            home_add_button = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // HomeHostsContentsListView
            // 
            HomeHostsContentsListView.Columns.AddRange(new ColumnHeader[] { DomainHeader, IP_Header });
            HomeHostsContentsListView.Location = new Point(6, 40);
            HomeHostsContentsListView.Name = "HomeHostsContentsListView";
            HomeHostsContentsListView.Size = new Size(756, 312);
            HomeHostsContentsListView.TabIndex = 0;
            HomeHostsContentsListView.UseCompatibleStateImageBehavior = false;
            HomeHostsContentsListView.View = View.Details;
            HomeHostsContentsListView.DoubleClick += HomeHostsContentsListView_DoubleClick;
            // 
            // DomainHeader
            // 
            DomainHeader.Text = "ドメイン";
            DomainHeader.Width = 440;
            // 
            // IP_Header
            // 
            IP_Header.Text = "IP";
            IP_Header.Width = 300;
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "適応";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // home_add_button
            // 
            home_add_button.Location = new Point(6, 6);
            home_add_button.Name = "home_add_button";
            home_add_button.Size = new Size(28, 28);
            home_add_button.TabIndex = 3;
            home_add_button.Text = "+";
            home_add_button.UseVisualStyleBackColor = true;
            home_add_button.Click += home_add_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 391);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(home_add_button);
            tabPage1.Controls.Add(HomeHostsContentsListView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 358);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "家に居るときのHosts";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingForm";
            Text = "Setting";
            Load += SettingForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView HomeHostsContentsListView;
        private ColumnHeader DomainHeader;
        private ColumnHeader IP_Header;
        private Button button1;
        private Button home_add_button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}