namespace Munchkin
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.joinGamePanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.joinServerButton = new System.Windows.Forms.Button();
            this.labelPodajIP = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.backButton2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.createGamePanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.startGameButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.startPanel = new System.Windows.Forms.Panel();
            this.nameConfirmButton = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.joinGameButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createGameButton = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            this.joinGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.createGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.AccessibleName = "";
            this.backgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backgroundPanel.BackgroundImage = global::Munchkin.Properties.Resources.Background;
            this.backgroundPanel.Controls.Add(this.joinGamePanel);
            this.backgroundPanel.Controls.Add(this.createGamePanel);
            this.backgroundPanel.Controls.Add(this.startPanel);
            this.backgroundPanel.Location = new System.Drawing.Point(-6, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1018, 465);
            this.backgroundPanel.TabIndex = 2;
            // 
            // joinGamePanel
            // 
            this.joinGamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.joinGamePanel.BackColor = System.Drawing.Color.DarkRed;
            this.joinGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joinGamePanel.Controls.Add(this.messageLabel);
            this.joinGamePanel.Controls.Add(this.joinServerButton);
            this.joinGamePanel.Controls.Add(this.labelPodajIP);
            this.joinGamePanel.Controls.Add(this.IPTextBox);
            this.joinGamePanel.Controls.Add(this.backButton2);
            this.joinGamePanel.Controls.Add(this.pictureBox3);
            this.joinGamePanel.Location = new System.Drawing.Point(141, 14);
            this.joinGamePanel.Name = "joinGamePanel";
            this.joinGamePanel.Size = new System.Drawing.Size(113, 441);
            this.joinGamePanel.TabIndex = 5;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Black;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageLabel.ForeColor = System.Drawing.Color.Lime;
            this.messageLabel.Location = new System.Drawing.Point(34, 299);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(31, 29);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "...";
            // 
            // joinServerButton
            // 
            this.joinServerButton.AccessibleName = "";
            this.joinServerButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.joinServerButton.Location = new System.Drawing.Point(6, 234);
            this.joinServerButton.Name = "joinServerButton";
            this.joinServerButton.Size = new System.Drawing.Size(329, 51);
            this.joinServerButton.TabIndex = 7;
            this.joinServerButton.Text = "Dołącz";
            this.joinServerButton.UseVisualStyleBackColor = true;
            this.joinServerButton.Click += new System.EventHandler(this.joinServerButton_Click);
            // 
            // labelPodajIP
            // 
            this.labelPodajIP.AutoSize = true;
            this.labelPodajIP.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodajIP.ForeColor = System.Drawing.Color.White;
            this.labelPodajIP.Location = new System.Drawing.Point(42, 146);
            this.labelPodajIP.Name = "labelPodajIP";
            this.labelPodajIP.Size = new System.Drawing.Size(99, 35);
            this.labelPodajIP.TabIndex = 6;
            this.labelPodajIP.Text = "Podaj IP";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPTextBox.Location = new System.Drawing.Point(31, 185);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(280, 34);
            this.IPTextBox.TabIndex = 5;
            // 
            // backButton2
            // 
            this.backButton2.AccessibleName = "";
            this.backButton2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton2.Location = new System.Drawing.Point(6, 334);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(329, 51);
            this.backButton2.TabIndex = 4;
            this.backButton2.Text = "Powrót";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::Munchkin.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // createGamePanel
            // 
            this.createGamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createGamePanel.BackColor = System.Drawing.Color.DarkRed;
            this.createGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.createGamePanel.Controls.Add(this.backButton);
            this.createGamePanel.Controls.Add(this.listView1);
            this.createGamePanel.Controls.Add(this.startGameButton);
            this.createGamePanel.Controls.Add(this.pictureBox2);
            this.createGamePanel.Location = new System.Drawing.Point(62, 14);
            this.createGamePanel.Name = "createGamePanel";
            this.createGamePanel.Size = new System.Drawing.Size(57, 441);
            this.createGamePanel.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.AccessibleName = "";
            this.backButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(4, 222);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(329, 51);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 301);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(328, 128);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // startGameButton
            // 
            this.startGameButton.AccessibleName = "";
            this.startGameButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGameButton.Location = new System.Drawing.Point(3, 165);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(329, 51);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Uruchom Grę";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Munchkin.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // startPanel
            // 
            this.startPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.startPanel.BackColor = System.Drawing.Color.DarkRed;
            this.startPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startPanel.Controls.Add(this.nameConfirmButton);
            this.startPanel.Controls.Add(this.playerNameTextBox);
            this.startPanel.Controls.Add(this.exitButton);
            this.startPanel.Controls.Add(this.joinGameButton);
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Controls.Add(this.createGameButton);
            this.startPanel.Location = new System.Drawing.Point(337, 12);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(339, 441);
            this.startPanel.TabIndex = 1;
            // 
            // nameConfirmButton
            // 
            this.nameConfirmButton.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameConfirmButton.Location = new System.Drawing.Point(201, 146);
            this.nameConfirmButton.Name = "nameConfirmButton";
            this.nameConfirmButton.Size = new System.Drawing.Size(131, 68);
            this.nameConfirmButton.TabIndex = 5;
            this.nameConfirmButton.Text = "Zatwierdź nazwę";
            this.nameConfirmButton.UseVisualStyleBackColor = true;
            this.nameConfirmButton.Click += new System.EventHandler(this.nameConfirmButton_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNameTextBox.Location = new System.Drawing.Point(3, 158);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(192, 44);
            this.playerNameTextBox.TabIndex = 4;
            this.playerNameTextBox.Text = "Gracz";
            // 
            // exitButton
            // 
            this.exitButton.AccessibleName = "";
            this.exitButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.Location = new System.Drawing.Point(3, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(329, 51);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // joinGameButton
            // 
            this.joinGameButton.AccessibleName = "";
            this.joinGameButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.joinGameButton.Location = new System.Drawing.Point(3, 277);
            this.joinGameButton.Name = "joinGameButton";
            this.joinGameButton.Size = new System.Drawing.Size(329, 51);
            this.joinGameButton.TabIndex = 2;
            this.joinGameButton.Text = "Dołącz do Gry";
            this.joinGameButton.UseVisualStyleBackColor = true;
            this.joinGameButton.Click += new System.EventHandler(this.joinGameButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Munchkin.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // createGameButton
            // 
            this.createGameButton.AccessibleName = "";
            this.createGameButton.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createGameButton.Location = new System.Drawing.Point(3, 220);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(329, 51);
            this.createGameButton.TabIndex = 0;
            this.createGameButton.Text = "Stwórz Grę";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.createGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 465);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Form1";
            this.Text = "Munchkin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.joinGamePanel.ResumeLayout(false);
            this.joinGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.createGamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel createGamePanel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button joinGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button nameConfirmButton;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel joinGamePanel;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelPodajIP;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button joinServerButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

