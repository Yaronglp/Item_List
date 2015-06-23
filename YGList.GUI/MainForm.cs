using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using YGList.Logic;
using System.IO;

namespace YGList.GUI
{
    public partial class MainForm : Form
    {
        private readonly List<Control> r_ControlList = new List<Control>();
        private readonly List<String> r_ItemList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addControlOfMainFormToControlList()
        {
            r_ControlList.Add(addItemBtn);
            r_ControlList.Add(removeItemBtn);
            r_ControlList.Add(saveFileBtn);
            r_ControlList.Add(loadFileBtn);
            r_ControlList.Add(emailDataBtn);
            r_ControlList.Add(changeFontBtn);
            r_ControlList.Add(listBox);
            r_ControlList.Add(LabelForListItem);
        }

        private void changeFontBtn_Click(object sender, EventArgs e)
        {
            if (r_ControlList.Count == 0)
            {
                addControlOfMainFormToControlList();
            }
            // Show the dialog.
            DialogResult result = fontDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog.Font;
                foreach (Control ctrl in r_ControlList)
                {
                    ctrl.Font = font;
                }
            }
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            List<string> itemList = new List<string>();

            openFile(ref itemList);
            foreach (string item in itemList)
            {
                listBox.Items.Add(item);
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            AddItemForm itemForm = new AddItemForm();
            itemForm.AddItem += itemForm_AddItemClicked;
            itemForm.ShowDialog();
        }

        void itemForm_AddItemClicked(Product i_Product)
        {
            r_ItemList.Add(i_Product.Name);
            listBox.Items.Add(i_Product.Name);
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            string msg = "There is no items on the list";

            if (listBox.Items.Count > 0 && listBox.SelectedIndex != -1)
            {
                int idx = listBox.SelectedIndex;
                listBox.Items.RemoveAt(idx);
                r_ItemList.RemoveAt(idx);
                msg = "Item has been deleted";
            }
            MessageBox.Show(msg);
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            string msg = "Empty item list";

            if (r_ItemList.Count > 0)
            {
                msg = saveFile();
            }
            MessageBox.Show(msg);
        }

        private string saveFile()
        {
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();
            string msg = "Save action failed";

            if (result == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(saveFileDialog.FileName, true))
                    {
                        foreach (string item in r_ItemList)
                        {
                            file.WriteLine(item);
                        }
                        // BinaryFormatter bFormat = new BinaryFormatter();
                        // bFormat.Serialize(stream, r_ItemList);
                        msg = string.Format("File has been saved to {0}", saveFileDialog.FileName);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return msg;
        }

        private void openFile(ref List<string> r_List)
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    using (StreamReader file = new StreamReader(openFileDialog.FileName))
                    {
                        string line = string.Empty;
                        while ((line = file.ReadLine()) != null)
                        {
                            r_List.Add(line); 
                        }
                        // BinaryFormatter bFormat = new BinaryFormatter();
                        // r_List = (List<string>)bFormat.Deserialize(stream);
                        updateItemList(r_List);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(string.Format("File has been loaded from {0}", openFileDialog.FileName));
            }
        }

        private void emailDataBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available due to privacy content(Related Methods were deleted)");
        }

        private void updateItemList(List<string> i_List)
        {
            foreach (string item in i_List)
            {
                r_ItemList.Add(item);
            }
        }
    }
}