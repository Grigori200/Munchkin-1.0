using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Munchkin.Server;
using System.Text.RegularExpressions;

namespace Munchkin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startPanel.Visible = true;

            joinGamePanel.Location = startPanel.Location;
            joinGamePanel.Size = startPanel.Size;
            joinGamePanel.Visible = false;
            createGamePanel.Location = startPanel.Location;
            createGamePanel.Size = startPanel.Size;
            createGamePanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createGameButton_Click(object sender, EventArgs e)
        {
            WindowMenager.StartServer();
            startPanel.Visible = false;
            createGamePanel.Visible = true;
            WindowMenager.StartClient("127.0.0.1");
        }

        private void joinGameButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            joinGamePanel.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            WindowMenager.Ctx.Dispose();
            this.Close();
        }

        private void nameConfirmButton_Click(object sender, EventArgs e)
        {
            WindowMenager.UserName = playerNameTextBox.Text;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = true;
            createGamePanel.Visible = false;
            WindowMenager.CloseServer();
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "...";
            messageLabel.Refresh();
            startPanel.Visible = true;
            joinGamePanel.Visible = false;
            if (WindowMenager.IsClientRunning())
            {
                WindowMenager.CloseClient();
            }
        }

        private void joinServerButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = WindowMenager.CheckIP(IPTextBox.Text);
            messageLabel.Refresh();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

            //TODO: Uruchamianie rozgrywki
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
