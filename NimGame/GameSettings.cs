using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etf.nim.ma150129d
{
    public partial class GameSettings : UserControl
    {
        bool saved;
        Bunifu.Framework.UI.BunifuCustomLabel[] ringLabels = new Bunifu.Framework.UI.BunifuCustomLabel[10];
        Bunifu.Framework.UI.BunifuSlider[] sliders = new Bunifu.Framework.UI.BunifuSlider[10];
        Panel[] rings = new Panel[10];

        int numberOfPillars;
        bool playerOne, playerTwo;
        int levelOne, levelTwo;
        int[] slidersValues = new int[10];

        public GameSettings()
        {
            InitializeComponent();
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {
            sliderPillars.Value = 5;
            pillarsNumberLabel.Text = sliderPillars.Value.ToString();
            bunifuiOSSwitch1.Value = false;
            panel2.Visible = false;
            bunifuiOSSwitch2.Value = true;
            panel4.Visible = true;
            bunifuDropdown1.AddItem("Easy");
            bunifuDropdown1.AddItem("Medium");
            bunifuDropdown1.AddItem("Hard");
            bunifuDropdown2.AddItem("Easy");
            bunifuDropdown2.AddItem("Medium");
            bunifuDropdown2.AddItem("Hard");
            bunifuDropdown1.selectedIndex = 0;
            bunifuDropdown2.selectedIndex = 0;

            ringLabels[0] = pillar0Label;
            ringLabels[1] = pillar1Label;
            ringLabels[2] = pillar2Label;
            ringLabels[3] = pillar3Label;
            ringLabels[4] = pillar4Label;
            ringLabels[5] = pillar5Label;
            ringLabels[6] = pillar6Label;
            ringLabels[7] = pillar7Label;
            ringLabels[8] = pillar8Label;
            ringLabels[9] = pillar9Label;

            rings[0] = ring0;
            rings[1] = ring1;
            rings[2] = ring2;
            rings[3] = ring3;
            rings[4] = ring4;
            rings[5] = ring5;
            rings[6] = ring6;
            rings[7] = ring7;
            rings[8] = ring8;
            rings[9] = ring9;

            sliders[0] = pillar0;
            sliders[1] = pillar1;
            sliders[2] = pillar2;
            sliders[3] = pillar3;
            sliders[4] = pillar4;
            sliders[5] = pillar5;
            sliders[6] = pillar6;
            sliders[7] = pillar7;
            sliders[8] = pillar8;
            sliders[9] = pillar9;

            for (int i = 0; i < 10; i++)
            {
                slidersValues[i] = sliders[i].Value = i + 1;
                ringLabels[i].Text = sliders[i].Value.ToString();
            }

            numberOfPillars = sliderPillars.Value;
            playerOne = bunifuiOSSwitch1.Value;
            playerTwo = bunifuiOSSwitch2.Value;
            levelOne = bunifuDropdown1.selectedIndex + 1;
            levelTwo = bunifuDropdown2.selectedIndex + 1;
            saved = true;
        }

        private void BunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            saved = false;
            if (bunifuiOSSwitch1.Value == true)
                panel2.Visible = true;
            else
                panel2.Visible = false;
        }

        private void BunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            saved = false;
            if (bunifuiOSSwitch2.Value == true)
                panel4.Visible = true;
            else
                panel4.Visible = false;
        }

        private void Pillar0_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[0].Text = sliders[0].Value.ToString();
        }

        private void Pillar1_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[1].Text = sliders[1].Value.ToString();
        }

        private void Pillar2_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[2].Text = sliders[2].Value.ToString();
        }

        private void Pillar3_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[3].Text = sliders[3].Value.ToString();
        }

        private void Pillar4_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[4].Text = sliders[4].Value.ToString();
        }

        private void Pillar5_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[5].Text = sliders[5].Value.ToString();
        }

        private void Pillar6_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[6].Text = sliders[6].Value.ToString();
        }

        private void Pillar7_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[7].Text = sliders[7].Value.ToString();
        }

        private void Pillar8_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[8].Text = sliders[8].Value.ToString();
        }

        private void Pillar9_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            ringLabels[9].Text = sliders[9].Value.ToString();
        }

        private void SliderPillars_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            pillarsNumberLabel.Text = sliderPillars.Value.ToString();
            for(int i=0;i<10;i++)
            {
                if (sliderPillars.Value > i)
                {
                    rings[i].Visible = true;
                }
                else
                    rings[i].Visible = false;
            }
        }

        private int ValuesCheck()
        {
            if (sliderPillars.Value == 0)
                return 1;
            HashSet<int> numbersOfRings = new HashSet<int>();
            for (int i = 0; i < sliderPillars.Value; i++)
            {
                if (sliders[i].Value == 0)
                    return 2;
                if (numbersOfRings.Contains(sliders[i].Value))
                    return 3;
                else
                    numbersOfRings.Add(sliders[i].Value);
            }
            return 0;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SaveValues();
        }

        public bool IsSaved() { return saved; }
        public int GetNumberOfPillars() { return numberOfPillars; }

        public int GetPlayerOneInfo() { return playerOne == false ? 0 : levelOne; }

        public int GetPlayerTwoInfo() { return playerTwo == false ? 0 : levelTwo; }

        public int[] GetNumbersOfRings() { return slidersValues; }

        public void ReturnOldValues()
        {
            for (int i = 0; i < 10; i++)
                sliders[i].Value = slidersValues[i];
            sliderPillars.Value = numberOfPillars;
            bunifuiOSSwitch1.Value = playerOne;
            playerTwo = bunifuiOSSwitch2.Value;
            bunifuDropdown1.selectedIndex = levelOne - 1;
            bunifuDropdown2.selectedIndex = levelTwo - 1;
            saved = true;
            MessageBox.Show("Settings returned to previous values", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool SaveValues()
        {
            int ret = ValuesCheck();
            if (ret == 1)
            {
                MessageBox.Show("Number of pillars must be greater than 0!", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ret == 2)
            {
                MessageBox.Show("Number of rings on every pillar must be greater than 0!", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
            else if (ret == 3)
            {
                MessageBox.Show("Number of rings on every pillar have to be different (unique)!", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    slidersValues[i] = sliders[i].Value;
                numberOfPillars = sliderPillars.Value;
                playerOne = bunifuiOSSwitch1.Value;
                playerTwo = bunifuiOSSwitch2.Value;
                levelOne = bunifuDropdown1.selectedIndex + 1;
                levelTwo = bunifuDropdown2.selectedIndex + 1;
                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return saved = true;
            }
            return false;
        }
    }
}
