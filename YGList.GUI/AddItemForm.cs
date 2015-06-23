using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YGList.Logic;

namespace YGList.GUI
{
    // add a delegate
    public delegate void AddItemEventHandler(Product product);
  
    public partial class AddItemForm : Form
    {
        // add an event of the delegate type
        public event AddItemEventHandler AddItem;

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void addNewItemBtn_Click(object sender, EventArgs e)
        {
            string msg = "Please fill item name";

            if (newItemTextBox.Text != string.Empty)
            {
                Product productArgs = new Product(newItemTextBox.Text);
                onAddBtnClick(productArgs);
                msg = "Item has been added";
            }
            MessageBox.Show(msg);
            this.Close();
        }

        protected virtual void onAddBtnClick(Product e)
        {
            //check if someone is listening
            if(AddItem != null)
            {
                //raise the event:
                AddItem(e);
            }
        }
    }
}