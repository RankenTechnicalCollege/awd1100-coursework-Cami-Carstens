using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06
{
    public partial class Form1 : Form
    {
        List<string> bookNames = new List<string> {"The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Prejudice" };
        List<string> keywords = new List<string> { "The story of eccentric millionaire Jay Gatsby \n and his pursuit of his lost love.", 
            "A fictional story about the 1812 French invasion of Russia.", "The story of a sailor’s relentless hunt for a white whale.", 
            "A Shakespearean tragedy about a young man coming home from college \n after the murder of his father.", "A comedic story of love and life \n in Old England." };
        List<string> authors = new List<string> { "F. Scott Fitzgerald", "Leo Tolstoy", "Herman Melville", "William Shakespeare", "Jane Austen" };
        List<string> isbnNumbers = new List<string> { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
        public Form1()
        {
            InitializeComponent();
        }

        //author search
        private void button1_Click(object sender, EventArgs e)
        {

            ClearResults(); //clear old searches
            int index = SearchByAuthor(txtAuthor.Text);
            ShowBook(index); //call on method
        }

        //ISBN search
        private void button2_Click(object sender, EventArgs e)
        {
            ClearResults();
            int index = SearchByIsbn(txtIsbn.Text);
            ShowBook(index);
        }

        //keyword search
        private void button3_Click(object sender, EventArgs e)
        {
            ClearResults();
            int index = SearchByKeyword(txtKeyword.Text);
            ShowBook(index);

        }

        //Methods
        private void ShowBook(int index)
        {
            if (index >= 0 && index < bookNames.Count)
            {
                lblResultName.Text = $" {bookNames[index]}";
                lblResultAuthor.Text = $"{authors[index]}";
                lblResultDescript.Text = $"{keywords[index]}";
                lblResultIsbn.Text = $"{isbnNumbers[index]}";
            }
            else
            {
               
                lblResultName.Text = $"Item not found.";
                lblResultAuthor.Text = $"Item not found.";
                lblResultDescript.Text = $"Item not found";
                lblResultIsbn.Text = $"Item not found";
            }
        }
        private int SearchByAuthor(string authorName)
        {
            for (int i = 0; i < authors.Count; i++)
            { 
                if (authors[i].ToLower().Contains(authorName.ToLower()))
                    return i;
            }
            return -1;

        }
        private int SearchByIsbn(string isbnNumber)
        {
            for(int i = 0;i < isbnNumbers.Count;i++)
            {
                if (isbnNumbers[i] == isbnNumber)
                    return i;
            }
            return -1;
        }
        private int SearchByKeyword(string keyword)
        {
            for (int i = 0; i < bookNames.Count; i++)
            {
                if (bookNames[i].ToLower().Contains(keyword) || keywords[i].ToLower().Contains(keyword)) 
                    return i;
            }
            return -1;
        }
        private void ClearResults()
        {
            lblResultName.Text = string.Empty;
            lblResultAuthor.Text = string.Empty;
            lblResultDescript.Text= string.Empty;
            lblResultIsbn.Text= string.Empty;
            
        }
    }
}
