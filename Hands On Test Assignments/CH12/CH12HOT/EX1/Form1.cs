using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        List<Password> list = new List<Password>(12)
        {
            new Password("buttercup9809","95df2450fcef04a1e57eb3713f6e466b"),
            new Password("Cami04","63d1cf927ea6e63d0aff1c72610cb500"),
            new Password("123456","e10adc3949ba59abbe56e057f20f883e"),
            new Password("123456789","25f9e794323b453885f5181f1b624d0b"),
            new Password("qwerty","d8578edf8458ce06fbc5bb76a58c5ca4"),
            new Password("111111","96e79218965eb72c92a549dd5a330112"),
            new Password("password","5f4dcc3b5aa765d61d8327deb882cf99"),
            new Password("qwertyuiop","6eea9b7ef19179a06954edd0f6c05ceb"),
            new Password("123321","c8837b23ff8aaa8a2dde915473ce0991"),
            new Password("google","c822c1b63853ed273b89687ac505f9fa"),
            new Password("P@ssw0rd","161ebd7d45089b3446ee4e0d86dbcf92"),
            new Password("Tr0ub4dor&3","4ece57a61323b52ccffdbef021956754")

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string hashBox = txtHash.Text.ToLower();
            string passwordResult = CrackPassword(hashBox);

            if (passwordResult != null)
            {
                lblResult.Text = $"Password found: {passwordResult}";
            }
            else
            {
                lblResult.Text = "FAIL! Password not found.";
            }
        }
        public string CrackPassword(string hash)
        {
            //loop through the list of passwords
            foreach (Password passWords in list)
            {
               
                if (passWords.Hash == hash)
                {
                   return passWords.Raw;
                 

                }
            }
            return null;
           
        }
    }
}
