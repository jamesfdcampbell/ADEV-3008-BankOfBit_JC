using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBanking
{
    public partial class BatchProcess : Form
    {
        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        public BatchProcess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Always display the form in the top right corner of the frame.
        /// </summary>
        private void BatchProcess_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            IQueryable<Institution> institutionList = from results
                                                      in db.Institutions
                                                      select results;

            institutionBindingSource.DataSource = institutionList.ToList();
        }

        private void lnkProcess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //given:  Ensure key has been entered.  Note: for use with Assignment 9
            //if (txtKey.Text.Length == 0)
            //{
            //    MessageBox.Show("Please enter a key to decrypt the input file(s).", "Key Required");
            //}

            if (radSelect.Checked)
            {
                Batch batch = new Batch();

                string institution = institutionComboBox.SelectedValue.ToString();
                string key = txtKey.Text;

                batch.ProcessTransmission(institution, key);
                rtxtLog.Text += batch.WriteLogData();
            }

            else if (radAll.Checked)
            {
                Batch batch = new Batch();
                string key = txtKey.Text;

                foreach (Institution i in institutionComboBox.Items)
                {
                    string institution = i.InstitutionNumber.ToString();
                    batch.ProcessTransmission(institution, key);
                    rtxtLog.Text += batch.WriteLogData();
                }
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (radSelect.Checked)
            {
                institutionComboBox.Enabled = true;
            }
            else
            {
                institutionComboBox.Enabled = false;
            }
        }
    }
}
