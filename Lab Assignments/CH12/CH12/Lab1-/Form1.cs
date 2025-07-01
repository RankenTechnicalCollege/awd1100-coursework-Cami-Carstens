using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_
{
    public partial class Form1 : Form
    {
        //flashcard array           //object being created
        FlashCard[] flashCards = new FlashCard[20];
        int flashCount = 0;

        public Form1()
        {
            InitializeComponent();

            grpAddNew.Visible = false;
                        // use constructor from class. (term, definition)
            flashCards[0] = new FlashCard("object/instance", "An instance of a class. If class is a 'cookie cutter'. \n The object is a 'cookie' the instance of a class.");
            flashCards[1] = new FlashCard("access modifier", "controls access to classes and member.\n Like private and public. Security mechanism.");
            flashCards[2] = new FlashCard("class", "A class is blueprint of an object. \nLike a cookie cutter is the 'blueprint' for cookies \nand the cookies are the objects. An instance of the of the cookie cutter(class)");
            flashCards[3] = new FlashCard("method", "A function defined inside of a class.");
            flashCards[4] = new FlashCard("constructor", "A unique method that runs when an object is created. \nIt is a method that has the same name \nas the class. Can be used like mutators.To 'set' and put data in.");
            flashCards[5] = new FlashCard("accessor", "a unique method that 'get' data out. \nReturns a piece of data");
            flashCards[6] = new FlashCard("encapsulation", "Hiding internal details so you only expose what is necessary \nthrough your public methods.");
            flashCount = 7;

        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            string inputTerm = txtTerm.Text;
            grpAddNew.Visible = false;

            //look for the term from the users input
            for(int i = 0; i < flashCount; i++)
            {
                if (flashCards[i].GetTerm().ToLower() == inputTerm.ToLower())
                {
                    grpResult.Visible = true;
                    lblResult.Text = $"{flashCards[i].GetDefinition()}";
                    return;
                }
            }

            //not found 
            lblResult.Text = "Term Not Found";
            grpResult.Visible = true;
            grpAddNew.Visible = true;
            txtNewTerm.Text = inputTerm;



          
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newTerm = txtNewTerm.Text.ToLower();
            string newDefinition = txtNewDefinition.Text.ToLower();

            if (flashCount >= 21)
            {
                lblResult.Text = "Flash Card limit has been reached.";
                return;
            }

            //add new term and definition
            flashCards[flashCount] = new FlashCard(newTerm, newDefinition);
            flashCount++;
            txtTerm.Text = "";
            lblResult.Text = $"New term and definition has been added! \n\nTerm: {newTerm} \nDefinition: {newDefinition}";
           
            grpAddNew.Visible = false;
           grpResult.Visible = true;
            txtNewDefinition.Clear();
            txtNewTerm.Clear();

        }
    }
}
