using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM
{
    public partial class ATM : Form
    {
        static int[] billValues = { 200, 100, 50, 20 };
        static int[,] billArray = new int[billValues.Length, 2];

        static int index;
        static int withdrawValue;
        static int restToWithdraw;
        static int withdrawBillsAmount;

        static bool withdrawSuccess = true;

        const int MAX_BILLS_AMOUNT = 50;

        static Random rnd = new Random();

        static List<int> withdrawBillsList = new List<int>() { 0, 0, 0, 0 };

        public ATM()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < billValues.Length; i++)
            {
                billArray[i, 0] = rnd.Next(MAX_BILLS_AMOUNT);
                billArray[i, 1] = billValues[i];
            }

            ResetLabels(lbl200, lbl100, lbl50, lbl20);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var backupArray = billArray.Clone();

            withdrawSuccess = true;
            index = 0;

            if (!int.TryParse(tbValue.Text, out withdrawValue))
            {
                MessageBox.Show("Wrong value.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbValue.Text = "";
                withdrawSuccess = false;
            }
            else if (withdrawValue <= 0)
            {
                MessageBox.Show("Withdraw value must be greater than 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbValue.Text = "";
                withdrawSuccess = false;
            }

            restToWithdraw = withdrawValue;

            if (WithdrawCanBeMade(billArray, withdrawValue))
            {
                while (restToWithdraw > 0)
                {
                    if (index < billArray.GetLength(0))
                    {
                        if (billArray[index, 0] > 0)
                        {
                            withdrawBillsAmount = restToWithdraw / billArray[index, 1];

                            if (withdrawBillsAmount > billArray[index, 0])
                            {
                                withdrawBillsAmount = billArray[index, 0];
                                billArray[index, 0] = 0;
                            }
                            else
                            {
                                billArray[index, 0] -= withdrawBillsAmount;
                            }

                            if (withdrawBillsAmount >= 0)
                            {
                                restToWithdraw -= withdrawBillsAmount * billArray[index, 1];
                                withdrawBillsList[index] = withdrawBillsAmount;
                            }
                        }
                        index++;
                    }
                    else
                    {
                        index = 0;
                        restToWithdraw = withdrawValue;
                        billArray = (int[,])backupArray;
                        ResetBillsList();

                        do
                        {
                            for (int i = index; i < billArray.GetLength(0); i++)
                            {
                                if ((restToWithdraw % billValues[index]) % billValues[i] == 0)
                                {
                                    withdrawBillsAmount = restToWithdraw / billArray[index, 1];

                                    if (withdrawBillsAmount > billArray[index, 0])
                                    {
                                        withdrawBillsAmount = billArray[index, 0];
                                        billArray[index, 0] = 0;
                                    }
                                    else
                                    {
                                        billArray[index, 0] -= withdrawBillsAmount;
                                    }

                                    if (withdrawBillsAmount >= 0)
                                    {
                                        restToWithdraw -= withdrawBillsAmount * billArray[index, 1];
                                        withdrawBillsList[index] = withdrawBillsAmount;
                                    }
                                    break;
                                }
                            }
                            index++;
                        } while (index < billArray.GetLength(0));

                        if (restToWithdraw > 0)
                        {
                            billArray = (int[,])backupArray;
                            MessageBox.Show("The ATM does not have appropriate bills to execute this withdrawal.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbValue.Text = "";
                            withdrawSuccess = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The ATM does not have enough bills to execute this withdrawal.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbValue.Text = "";
                withdrawSuccess = false;
            }

            if (withdrawSuccess == true)
            {
                lblWithdrawn200.Text = "Amount of " + billArray[0, 1].ToString() + " bills withdrawn: " + withdrawBillsList[0];
                lblWithdrawn100.Text = "Amount of " + billArray[1, 1].ToString() + " bills withdrawn: " + withdrawBillsList[1];
                lblWithdrawn50.Text = "Amount of " + billArray[2, 1].ToString() + " bills withdrawn: " + withdrawBillsList[2];
                lblWithdrawn20.Text = "Amount of " + billArray[3, 1].ToString() + " bills withdrawn: " + withdrawBillsList[3];
            }

            ResetLabels(lbl200, lbl100, lbl50, lbl20);
        }

        private static bool WithdrawCanBeMade(int[,] billArray, int withdrawValue)
        {
            int atmCapital = 0;

            for (int i = 0; i < billArray.GetLength(0); i++)
            {
                atmCapital += billArray[i, 0] * billArray[i, 1];
            }

            return atmCapital >= withdrawValue;
        }

        public static void ResetLabels(Label label1, Label label2, Label label3, Label label4)
        {
            label1.Text = " Amount of " + billArray[0, 1].ToString() + " bills: " + billArray[0, 0].ToString();
            label2.Text = " Amount of " + billArray[1, 1].ToString() + " bills: " + billArray[1, 0].ToString();
            label3.Text = " Amount of " + billArray[2, 1].ToString() + " bills: " + billArray[2, 0].ToString();
            label4.Text = " Amount of " + billArray[3, 1].ToString() + " bills: " + billArray[3, 0].ToString();
        }

        public static void ResetBillsList()
        {
            for (int i = 0; i < withdrawBillsList.Count(); i++)
            {
                withdrawBillsList[i] = 0;
            }
        }
    }
}
