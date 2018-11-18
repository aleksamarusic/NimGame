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
    public partial class GameBoard : UserControl
    {
        int numberOfPillars;
        int levelOne, levelTwo;
        int[] numbersOfRings;
        int sumOfRings;
        Bunifu.Framework.UI.BunifuVTrackbar[] pillars = new Bunifu.Framework.UI.BunifuVTrackbar[10];
        Bunifu.Framework.UI.BunifuCustomLabel[] pillarsLabels = new Bunifu.Framework.UI.BunifuCustomLabel[10];
        Panel[] pillarsPanels = new Panel[10];
        Player player1;
        Player player2;
        int possibleNumberOfRingsToTake;
        int zeroPillars = 0;

        public GameBoard()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                pillars[i].Value = 10 - numbersOfRings[i];
                pillarsLabels[i].Text = numbersOfRings[i].ToString();
                if (numberOfPillars > i)
                    pillarsPanels[i].Visible = true;
                else
                    pillarsPanels[i].Visible = false;
            }
            buttonTransition.HideSync(bunifuFlatButton1);
            panelTransition.ShowSync(panel1);
            buttonTransition.ShowSync(panel2);
            buttonTransition.ShowSync(panel3);
            State st;
            switch (levelOne)
            {
                case 1:
                    st = new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars);
                    player1 = new PlayerMinimax(st, 10);
                    break;
                case 2:
                    st = new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars);
                    player1 = new PlayerAlphaBeta(st, 10);
                    break;
                case 3:
                    st = new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars);
                    player1 = new PlayerHard(st, 10);
                    break;
            }
            switch (levelTwo)
            {
                case 1:
                    st = new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars);
                    player2 = new PlayerMinimax(st, 10);
                    
                    break;
                case 2:
                    st = new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars);
                    player2 = new PlayerAlphaBeta(st, 10);
                    break;
                case 3:
                    st = new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars);
                    player2 = new PlayerHard(st, 10);
                    break;
            }
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.Visible = true;
            panel1.Visible = false;
            pillars[0] = pillar0;
            pillars[1] = pillar1;
            pillars[2] = pillar2;
            pillars[3] = pillar3;
            pillars[4] = pillar4;
            pillars[5] = pillar5;
            pillars[6] = pillar6;
            pillars[7] = pillar7;
            pillars[8] = pillar8;
            pillars[9] = pillar9;

            pillarsPanels[0] = panel4;
            pillarsPanels[1] = panel5;
            pillarsPanels[2] = panel6;
            pillarsPanels[3] = panel7;
            pillarsPanels[4] = panel8;
            pillarsPanels[5] = panel9;
            pillarsPanels[6] = panel10;
            pillarsPanels[7] = panel11;
            pillarsPanels[8] = panel12;
            pillarsPanels[9] = panel13;

            pillarsLabels[0] = bunifuCustomLabel6;
            pillarsLabels[1] = bunifuCustomLabel7;
            pillarsLabels[2] = bunifuCustomLabel9;
            pillarsLabels[3] = bunifuCustomLabel11;
            pillarsLabels[4] = bunifuCustomLabel13;
            pillarsLabels[5] = bunifuCustomLabel15;
            pillarsLabels[6] = bunifuCustomLabel17;
            pillarsLabels[7] = bunifuCustomLabel19;
            pillarsLabels[8] = bunifuCustomLabel21;
            pillarsLabels[9] = bunifuCustomLabel23;

            

        }

        public void SetValues(Form1 form)
        {
            numberOfPillars = form.GetNumberOfPillars();
            levelOne = form.GetPlayerOneInfo();
            levelTwo = form.GetPlayerTwoInfo();
            numbersOfRings = form.GetNumbersOfRings();
            sumOfRings = 0;
            for (int i = 0; i < numberOfPillars; i++)
                sumOfRings += numbersOfRings[i];
            possibleNumberOfRingsToTake = 10;
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (levelOne == 0)
            {
                if (HumanMove())
                {
                    //panel2.Enabled = false;
                    //panel3.Enabled = true;
                    bunifuFlatButton2.Visible = false;
                    bunifuFlatButton3.Visible = true;
                }
            }
            else
            {
                State st = player1.PlayMove(new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars));
                int sum = 0;
                zeroPillars = 0;
                for (int i = 0; i < numberOfPillars; i++)
                {
                    if (st.NumbersOfRings[i] == 0)
                        zeroPillars++;
                    sum += st.NumbersOfRings[i];
                    numbersOfRings[i] = st.NumbersOfRings[i];
                }
                possibleNumberOfRingsToTake = 2 * (sumOfRings - sum);
                sumOfRings = sum;
                for (int i = 0; i < numberOfPillars; i++)
                {
                    pillars[i].Value = 10 - numbersOfRings[i];
                    pillarsLabels[i].Text = numbersOfRings[i].ToString();
                }
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton3.Visible = true;
            }
            if (TheEnd())
            {
                MessageBox.Show("Player One has won!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                panelTransition.HideSync(panel1);
                buttonTransition.HideSync(panel2);
                buttonTransition.HideSync(panel3);
                buttonTransition.ShowSync(bunifuFlatButton1);
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (levelTwo == 0)
            {
                if (HumanMove())
                {
                    //panel3.Enabled = false;
                    //panel2.Enabled = true;
                    bunifuFlatButton3.Visible = false;
                    bunifuFlatButton2.Visible = true;
                }
            }
            else
            {
                State st = player2.PlayMove(new State(numbersOfRings, possibleNumberOfRingsToTake, numberOfPillars));
                int sum = 0;
                zeroPillars = 0;
                for (int i = 0; i < numberOfPillars; i++)
                {
                    if (st.NumbersOfRings[i] == 0)
                        zeroPillars++;
                    sum += st.NumbersOfRings[i];
                    numbersOfRings[i] = st.NumbersOfRings[i];
                }
                possibleNumberOfRingsToTake = 2 * (sumOfRings - sum);
                sumOfRings = sum;
                for (int i = 0; i < numberOfPillars; i++)
                {
                    pillars[i].Value = 10 - numbersOfRings[i];
                    pillarsLabels[i].Text = numbersOfRings[i].ToString();
                }
                bunifuFlatButton3.Visible = false;
                bunifuFlatButton2.Visible = true;
            }
            if (TheEnd())
            {
                MessageBox.Show("Player Two has won!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panelTransition.HideSync(panel1);
                buttonTransition.HideSync(panel2);
                buttonTransition.HideSync(panel3);
                buttonTransition.ShowSync(bunifuFlatButton1);
            }
        }

        private bool CheckUnique()
        {
            HashSet<int> numOfRings = new HashSet<int>();
            for (int i = 0; i < numberOfPillars; i++)
            {
                if (10 - pillars[i].Value != 0)
                {
                    if (numOfRings.Contains(pillars[i].Value))
                        return false;
                    else
                        numOfRings.Add(pillars[i].Value);
                }
            }
            return true;
        }

        private int CheckDifference()
        {
            HashSet<int> set = new HashSet<int>();
            int counter = 0;
            for (int i = 0; i < numberOfPillars; i++)
                if (numbersOfRings[i] != 0)
                    set.Add(numbersOfRings[i]);
            for (int i = 0; i < numberOfPillars; i++)
                if (!set.Contains(10 - pillars[i].Value))
                    counter++;
            return counter - zeroPillars;
        }

        private bool CheckTaken()
        {
            int sum = 0;
            for (int i = 0; i < numberOfPillars; i++)
                sum += 10 - pillars[i].Value;
            return sumOfRings - sum > possibleNumberOfRingsToTake;
        }


        public int[] GetNumbersOfRings()
        {
            return numbersOfRings;
        }

        private bool CheckSum()
        {
            int sum = 0;
            for (int i = 0; i < numberOfPillars; i++)
                sum += 10 - pillars[i].Value;
            return sum < sumOfRings;
        }

        private void Pillar0_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[0].Text = (10 - pillars[0].Value).ToString();
        }

        private void Pillar1_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[1].Text = (10 - pillars[1].Value).ToString();
        }

        private void Pillar2_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[2].Text = (10 - pillars[2].Value).ToString();
        }

        private void Pillar3_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[3].Text = (10 - pillars[3].Value).ToString();
        }

        private void Pillar4_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[4].Text = (10 - pillars[4].Value).ToString();
        }

        private void Pillar5_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[5].Text = (10 - pillars[5].Value).ToString();
        }

        private void Pillar6_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[6].Text = (10 - pillars[6].Value).ToString();
        }

        private void Pillar7_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[7].Text = (10 - pillars[7].Value).ToString();
        }

        private void Pillar8_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[8].Text = (10 - pillars[8].Value).ToString();
        }

        private void Pillar9_ValueChanged(object sender, EventArgs e)
        {
            pillarsLabels[9].Text = (10 - pillars[9].Value).ToString();
        }

        private bool TheEnd() => zeroPillars == numberOfPillars;

        public bool HumanMove()
        {
            if (CheckUnique() == false)
            {
                MessageBox.Show(text: "Number of rings on every pillar have to be different (unique)!", caption: "Incorrect value", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if(CheckDifference() == 0)
            {
                MessageBox.Show(text: "You didn't make a move!", caption: "Incorrect value", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (CheckDifference() > 1)
            {
                MessageBox.Show(text: "You can change only one pillar", caption: "Incorrect value", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (!CheckSum())
            {
                MessageBox.Show(text: "You cannot increase the number of rings!", caption: "Incorrect value", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (CheckTaken())
            {
                MessageBox.Show(text: "You cannot take more than "+possibleNumberOfRingsToTake.ToString()+" rings!", caption: "Incorrect value", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            int sum = 0;
            zeroPillars = 0;
            for (int i = 0; i < numberOfPillars; i++)
            {
                if (10 - pillars[i].Value == 0)
                    zeroPillars++;
                sum += 10 - pillars[i].Value;
                numbersOfRings[i] = 10 - pillars[i].Value;
            }
            possibleNumberOfRingsToTake = 2 * (sumOfRings - sum);
            sumOfRings = sum;
            return true;
        }
    }
}
