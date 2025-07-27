using System.Collections.ObjectModel;
using InventoryItemCrud.Models;

namespace InventoryItemCrud
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<InventoryItem> InventoryItems { get; set; } = [];


        public MainPage()
        {
            InitializeComponent();
            //seed data going into the collection
            InventoryItems.Add(new InventoryItem(1000, "Laptop", 999.99m));
            InventoryItems.Add(new InventoryItem(2000, "Mouse", 19.99m));

            // Bind the collection to the ListView in the XAML
            BindingContext = this;
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(ItemNoEntry.Text, out int itemNo)
                && !string.IsNullOrWhiteSpace(DescriptionEntry.Text)
                && decimal.TryParse(PriceEntry.Text, out decimal price)) 
            {
                //if data is valid, add it to the collection
                InventoryItems.Add(new InventoryItem(itemNo, DescriptionEntry.Text, price));
                ClearEntries();
            }
            else
            {
                DisplayAlert("Error", "Please fill in all fields.", "OK");
            }


        }

        private void Updatebtn_Clicked(object sender, EventArgs e)
        {

            if (InventoryListView.SelectedItem is InventoryItem selectedItem)
            {
                if (int.TryParse(ItemNoEntry.Text, out int itemNo)
                && !string.IsNullOrWhiteSpace(DescriptionEntry.Text)
                && decimal.TryParse(PriceEntry.Text, out decimal price))
                {
                    //if data is valid, update the selected item, updating the properties values
                    selectedItem.ItemNo = itemNo;
                    selectedItem.Description = DescriptionEntry.Text;
                    selectedItem.Price = price;

                        //get the index of the selected item in the collection
                    //InventoryItems[InventoryItems.IndexOf(selectedItem)] = selectedItem; // Update the collection
                    //ClearEntries(); 


                }
                else
                {

                }
            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            //if data type is valid creates the variable selectedItem
            if (InventoryListView.SelectedItem is InventoryItem selectedItem)
            {
                InventoryItems.Remove(selectedItem);
                ClearEntries();
            }

        }

        private void InventoryListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem is InventoryItem selectedItem)
            {
                // Populate the entries with the selected item's data
                ItemNoEntry.Text = selectedItem.ItemNo.ToString();
                DescriptionEntry.Text = selectedItem.Description;
                PriceEntry.Text = selectedItem.Price.ToString("F2");
            }
        }
        private void ClearEntries()
        {
            ItemNoEntry.Text = string.Empty;
            DescriptionEntry.Text = string.Empty;
            PriceEntry.Text = string.Empty;

        }
    }
}
