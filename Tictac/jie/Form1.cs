using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jie
{
    public partial class Form1 : Form
    {
        string promption = "Player '1' turn";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(lblPlayer.Text == promption)
            {
                btnOne.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnOne.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnOne.Enabled = false;

            Rule();
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnTwo.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnTwo.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnTwo.Enabled = false;
            Rule();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnThree.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnThree.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnThree.Enabled = false;
            Rule();
            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnFour.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnFour.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnFour.Enabled = false;
            Rule();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnFive.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnFive.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnFive.Enabled = false;
            Rule();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnSix.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnSix.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnSix.Enabled = false;
            Rule();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnSeven.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnSeven.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnSeven.Enabled = false;
            Rule();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnEight.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnEight.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnEight.Enabled = false;
            Rule();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == promption)
            {
                btnNine.Text = "1";
                lblPlayer.Text = "Player '0' turn";
            }
            else
            {
                btnNine.Text = "0";
                lblPlayer.Text = "Player '1' turn";
            }
            btnNine.Enabled = false;
            Rule();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            lblPlayer.Text = promption;

            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;

            btnOne.Text = "";
            btnTwo.Text = "";
            btnThree.Text = "";
            btnFour.Text = "";
            btnFive.Text = "";
            btnSix.Text = "";
            btnSeven.Text = "";
            btnEight.Text = "";
            btnNine.Text = "";
        }

        // [0,0,0],[0,0,0],[0,0,0]
        public void Rule()
        {
            if ((btnOne.Text == "1" && btnTwo.Text == "1" && btnThree.Text == "1") ||
                (btnOne.Text == "1" && btnFour.Text == "1" && btnSeven.Text == "1") ||
                (btnOne.Text == "1" && btnFive.Text == "1" && btnNine.Text == "1") ||
                (btnTwo.Text == "1" && btnFive.Text == "1" && btnEight.Text == "1") ||
                (btnThree.Text == "1" && btnSix.Text == "1" && btnNine.Text == "1") ||
                (btnThree.Text == "1" && btnFive.Text == "1" && btnSeven.Text == "1") ||
                (btnFour.Text == "1" && btnFive.Text == "1" && btnSix.Text == "1") ||
                (btnSeven.Text == "1" && btnEight.Text =="1" && btnNine.Text == "1"))
            {
                MessageBox.Show("Player '1' win!");
                Reset();
            }

            if((btnOne.Text == "0" && btnTwo.Text == "0" && btnThree.Text == "0") ||
                (btnOne.Text == "0" && btnFour.Text == "0" && btnSeven.Text == "0") ||
                (btnOne.Text == "0" && btnFive.Text == "0" && btnNine.Text == "0") ||
                (btnTwo.Text == "0" && btnFive.Text == "0" && btnEight.Text == "0") ||
                (btnThree.Text == "0" && btnSix.Text == "0" && btnNine.Text == "0") ||
                (btnThree.Text == "0" && btnFive.Text == "0" && btnSeven.Text == "0") ||
                (btnFour.Text == "0" && btnFive.Text == "0" && btnSix.Text == "0") ||
                (btnSeven.Text == "0" && btnEight.Text == "0" && btnNine.Text == "0"))
            {
                MessageBox.Show("Player '0' win!");
                Reset();
            }
        }

    }
}
