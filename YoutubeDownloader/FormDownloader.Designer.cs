namespace YoutubeDownloader
{
    partial class FormDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDownloader));
            label1 = new Label();
            txtURLYT = new TextBox();
            btnDescargar = new Button();
            listFormato = new ComboBox();
            btnPath = new Button();
            txtPath = new TextBox();
            label2 = new Label();
            chkVideo = new CheckBox();
            chkAudio = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 0;
            label1.Text = "URL Video";
            // 
            // txtURLYT
            // 
            txtURLYT.Font = new Font("Arial", 12F);
            txtURLYT.Location = new Point(102, 43);
            txtURLYT.Name = "txtURLYT";
            txtURLYT.Size = new Size(438, 26);
            txtURLYT.TabIndex = 1;
            // 
            // btnDescargar
            // 
            btnDescargar.Font = new Font("Arial", 12F);
            btnDescargar.Location = new Point(546, 42);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(93, 28);
            btnDescargar.TabIndex = 2;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // listFormato
            // 
            listFormato.Font = new Font("Arial", 12F);
            listFormato.FormattingEnabled = true;
            listFormato.Location = new Point(479, 79);
            listFormato.Name = "listFormato";
            listFormato.Size = new Size(160, 26);
            listFormato.TabIndex = 3;
            // 
            // btnPath
            // 
            btnPath.Font = new Font("Arial", 12F);
            btnPath.Location = new Point(572, 4);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(67, 28);
            btnPath.TabIndex = 6;
            btnPath.Text = "Buscar";
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += btnPath_Click;
            // 
            // txtPath
            // 
            txtPath.Font = new Font("Arial", 12F);
            txtPath.Location = new Point(187, 5);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(379, 26);
            txtPath.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 18);
            label2.TabIndex = 4;
            label2.Text = "Carpeta de descargas:";
            // 
            // chkVideo
            // 
            chkVideo.AutoSize = true;
            chkVideo.Checked = true;
            chkVideo.CheckState = CheckState.Checked;
            chkVideo.Font = new Font("Arial", 12F);
            chkVideo.Location = new Point(12, 81);
            chkVideo.Name = "chkVideo";
            chkVideo.Size = new Size(69, 22);
            chkVideo.TabIndex = 7;
            chkVideo.Text = "Video";
            chkVideo.UseVisualStyleBackColor = true;
            chkVideo.Click += chkChanged;
            // 
            // chkAudio
            // 
            chkAudio.AutoSize = true;
            chkAudio.Font = new Font("Arial", 12F);
            chkAudio.Location = new Point(87, 81);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(68, 22);
            chkAudio.TabIndex = 8;
            chkAudio.Text = "Audio";
            chkAudio.UseVisualStyleBackColor = true;
            chkAudio.Click += chkChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(402, 82);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 9;
            label3.Text = "Formato:";
            // 
            // FormDownloader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 114);
            Controls.Add(label3);
            Controls.Add(chkAudio);
            Controls.Add(chkVideo);
            Controls.Add(btnPath);
            Controls.Add(txtPath);
            Controls.Add(label2);
            Controls.Add(listFormato);
            Controls.Add(btnDescargar);
            Controls.Add(txtURLYT);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(666, 153);
            MinimumSize = new Size(666, 153);
            Name = "FormDownloader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Youtube Downloader";
            Load += FormDownloader_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtURLYT;
        private Button btnDescargar;
        private ComboBox listFormato;
        private Button btnPath;
        private TextBox txtPath;
        private Label label2;
        private CheckBox chkVideo;
        private CheckBox chkAudio;
        private Label label3;
    }
}
