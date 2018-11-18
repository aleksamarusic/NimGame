using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etf.nim.ma150129d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameBoard1.SetValues(this);
            gameBoard1.BringToFront();
            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 340;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logoAnimator.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                panelAnimator.ShowSync(sideMenu);
                
            }
            
        }

        private void BunifuSeparator1_Load(object sender, EventArgs e)
        {
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to exit the application?", "Do not leave :(", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                this.Close();  
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 340;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logo.Visible = false;
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                panelAnimator.ShowSync(sideMenu);
                
            }
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (gameSettingsButton.selected)
                if (gameSettings1.IsSaved() == false)
                {
                    DialogResult d = MessageBox.Show("Save settings before quiting? Your changes will be lost otherwise.", "Saving changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        if (gameSettings1.SaveValues() == false)
                            gameSettings1.ReturnOldValues();
                    }
                    else
                        gameSettings1.ReturnOldValues();
                }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            gameSettings1.BringToFront();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(gameSettingsButton.selected)
                if(gameSettings1.IsSaved() == false)
                {
                    DialogResult d = MessageBox.Show("Save settings before quiting? Your changes will be lost otherwise.", "Saving changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        if (gameSettings1.SaveValues() == false)
                            gameSettings1.ReturnOldValues();
                    }
                    else
                        gameSettings1.ReturnOldValues();
                }
            gameBoard1.SetValues(this);
            gameBoard1.BringToFront();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            if (gameSettingsButton.selected)
                if (gameSettings1.IsSaved() == false)
                {
                    DialogResult d = MessageBox.Show("Save settings before quiting? Your changes will be lost otherwise.", "Saving changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        if (gameSettings1.SaveValues() == false)
                            gameSettings1.ReturnOldValues();
                    }
                    else
                        gameSettings1.ReturnOldValues();
                }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            if (gameSettingsButton.selected)
                if (gameSettings1.IsSaved() == false)
                {
                    DialogResult d = MessageBox.Show("Save settings before quiting? Your changes will be lost otherwise.", "Saving changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        if (gameSettings1.SaveValues() == false)
                            gameSettings1.ReturnOldValues();
                    }
                    else
                        gameSettings1.ReturnOldValues();
                }
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            if (gameSettingsButton.selected)
                if (gameSettings1.IsSaved() == false)
                {
                    DialogResult d = MessageBox.Show("Save settings before quiting? Your changes will be lost otherwise.", "Saving changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        if (gameSettings1.SaveValues() == false)
                            gameSettings1.ReturnOldValues();
                    }
                    else
                        gameSettings1.ReturnOldValues();
                }
        }

        private void GameBoard1_Load(object sender, EventArgs e)
        {

        }



        public bool IsSaved() { return gameSettings1.IsSaved(); }
        public int GetNumberOfPillars() { return gameSettings1.GetNumberOfPillars(); }

        public int GetPlayerOneInfo() { return gameSettings1.GetPlayerOneInfo(); }

        public int GetPlayerTwoInfo() { return gameSettings1.GetPlayerTwoInfo(); }

        public int[] GetNumbersOfRings() { return gameSettings1.GetNumbersOfRings(); }
    }
}
