using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {
       
        List<Account> loginAccount = new List<Account>();    
        
        public Form1()
        {
            InitializeComponent();
            loginAccount.Add(new Account("JBriggs99", "dogcat1234", "Josiah", false));
            loginAccount.Add(new Account("MusiqLuv789", "HappyFeet_1998", "Trisha", true));
            loginAccount.Add(new Account("AdamDWayne88", "treescloudsflowers", "Adam", false));
            loginAccount.Add(new Account("NatureFan123", "Starlight0987", "Kali", true));
            loginAccount.Add(new Account("HaroldJBill", "Birthday456789", "Thomas", true));
            loginAccount.Add(new Account("MyName-Mychal02", "airplane98765", "Mychal", false));
            loginAccount.Add(new Account("JonesTina2", "ReadMoreBooks2025", "Tina", false));


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                if(string.IsNullOrEmpty(userName)  || string.IsNullOrEmpty(password))
                {
                    //1
                    throw new NoUsernamePasswordException("You must enter both username and password.");
                }

                Account foundInList = null;
                foreach(Account account in loginAccount)
                {
                    if(account.Username == userName && account.Password == password)
                    {
                        foundInList = account;
                        break;
                    }
                }
                //2
                if(foundInList == null)
                {
                    throw new IncorrectPasswordException("Incorrect Username/Password.");
                }
                if(foundInList.Disabled)
                {
                    //3
                    throw new AccountDisabledException("Account Disabled.");
                }
                lblResult.Text = $"Welcome: {foundInList.FirstName}!";
                
            }
           

            //1
            catch (NoUsernamePasswordException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            //2
            catch (IncorrectPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //3
            catch(AccountDisabledException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //4 catch other exceptions
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }
    }
}
