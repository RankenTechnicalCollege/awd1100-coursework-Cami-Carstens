using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        BookContext BookData;
        List<Book> bookList;
        List<Book> selectedBooks = new List<Book>();
        private int newBooksAdded = 0;

      
        public Form1()
        {
            // Initialize the BookContext
            BookData = new BookContext();
            InitializeComponent();
            //load books from database
            //bookList = BookData.Books.ToList();

            this.Load += Form1_Load;

            // Populate the ComboBox with distinct genres from the bookList
            //cboGenre.DataSource = bookList.Select(b => b.Genre).Distinct().ToList();


            //wire up cbo on form load
            cboGenre.SelectedIndexChanged += cboGenre_SelectedIndexChanged;
            cboBookSelection.SelectedIndexChanged += cboBookSelection_SelectedIndexChanged;

        }


        private byte[] ImageToByte(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //name, author, genre, price 
            try
            {

                string addedName = txtBookName.Text;
                string addedAuthor = txtAuthor.Text;
                string addedGenre = txtGenre.Text;
                //decimal addedPrice = decimal.Parse(txtPrice.Text);

                //after getting book info add new book to list
                Book newBook = new Book
                {
                    Name = addedName,
                    Author = addedAuthor,
                    Genre = addedGenre,
                    //Price = addedPrice,
                    ImageData = ImageToByte(Properties.Resources.generic_book)

                };
                //add the new book info locally
                BookData.Books.Add(newBook);
                BookData.SaveChanges();

                RefreshBookList();
                cboGenre.SelectedItem = addedGenre;
                MessageBox.Show("Book added successfully!");

                //count the number of new books added
                newBooksAdded++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding book.");
            }
        }


        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = cboGenre.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedGenre))
            {
                var books = bookList.Where(b => b.Genre == selectedGenre).OrderBy(b => b.Name).ToList();

                cboBookSelection.DataSource = null;
                cboBookSelection.DataSource = books;
                cboBookSelection.DisplayMember = "Name";
                cboBookSelection.ValueMember = "Id";

            }
        }

        private void cboBookSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBookSelection.SelectedItem is Book selectedBook)
            {
                pbBook.Image = System.Drawing.Image.FromStream(new MemoryStream(selectedBook.ImageData));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshBookList();
            pbBook.Image = Properties.Resources.generic_book;

            if(cboGenre.Items.Count > 0)
            {
                cboGenre.SelectedIndex = 0; // Set the first genre as selected
            }
            //bookList = BookData.Books.ToList();
            //var genres = BookData.Books
            //    .Select(b => b.Genre)
            //    .Distinct()
            //    .OrderBy(g => g)
            //    .ToList();
            //cboGenre.DataSource = genres;
            //pbBook.Image = Properties.Resources.generic_book;

            //if (genres.Count > 0 && cboGenre.SelectedIndex >= 0)
            //{
            //    string selectedGenre = cboGenre.SelectedItem.ToString();
            //    var books = bookList.Where(b => b.Genre == selectedGenre).OrderBy(b => b.Name).ToList();
            //    cboBookSelection.DataSource = null;
            //    cboBookSelection.DataSource = books;
            //    cboBookSelection.DisplayMember = "Name";
            //    cboBookSelection.ValueMember = "Id";
            //}

            ////delete the book that permanetly added on testing
            //var lastBookAdded = BookData.Books.OrderByDescending(b => b.Id).FirstOrDefault();
            //if (lastBookAdded != null)
            //{
            //    BookData.Books.Remove(lastBookAdded);
            //    BookData.SaveChanges();
            //}
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //List<Book> selectedBooks = new List<Book>();


            if (cboBookSelection.SelectedItem is Book selectedBook)
            {
                selectedBooks.Add(selectedBook);

                lblBookCart.Text += $"{selectedBook.Name}\n";

            }
            else
            {
                MessageBox.Show("Please select a book.");
            }
        }


        ////send it to the popup receipt form
        //ReceiptResult receiptForm = new ReceiptResult(selectedBooks);
        //receiptForm.ShowDialog();

        //    if (cboBookSelection.SelectedItem == null)
        //    {
        //        MessageBox.Show("Please select a book first.");
        //        return;
        //    }

        //    Book selectedBook = cboBookSelection.SelectedItem as Book;

        //    if (selectedBook == null)
        //    {
        //        MessageBox.Show("Invalid book selection.");
        //        return;
        //    }

        //    selectedBooks.Add(selectedBook);

        //    // Append book info to label without clearing previous content
        //    lblBookCart.Text += $"{selectedBook.Name} by {selectedBook.Author}\n";
        //}



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //List<Book> selectedBooks = new List<Book>();
            if (cboBookSelection.SelectedItem is Book selectedBook)
            {
                selectedBooks.Add(selectedBook);
            }


            if (selectedBooks.Any())
            {
                decimal totalPrice = selectedBooks.Sum(b => b.Price);
                //discount if selling back used books
                decimal storeCredit = newBooksAdded * 2.00m;

                decimal priceAfterDiscount = totalPrice - storeCredit;

                //dont let it get negative
                if (priceAfterDiscount < 0)
                {
                    priceAfterDiscount = 0;
                }

                //send it to the popup receipt form
                ReceiptResult receiptForm = new ReceiptResult(selectedBooks, storeCredit);
                receiptForm.ShowDialog();

            }
        }
        private void RefreshBookList()
        {
            bookList = BookData.Books.ToList();

            var genres = bookList.Select(b => b.Genre).Distinct().OrderBy(g => g).ToList();

            cboGenre.DataSource = null;

            cboGenre.DataSource = genres;
        }
      
    }
}
