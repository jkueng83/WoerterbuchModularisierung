using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoerterbuchLogic;

namespace WoerterbuchModularisierung
{
    public partial class Dictionary : Form
    {
        WoerterbuchController _woerterbuchController;
        string _filePath;
        public Dictionary()
        {
            InitializeComponent();
            _woerterbuchController = new WoerterbuchController();
            _filePath = "dictonary.csv";
        }

        private void btReadDataFromFile_Click(object sender, EventArgs e)
        {
            _woerterbuchController.ReadDictionary(_filePath);
            writeDataInListBoxABC();
        }

        private void btWriteDataToFile_Click(object sender, EventArgs e)
        {
            _woerterbuchController.WriteToFile(_filePath);
        }

       

        private void writeDataInListBoxABC()
        {
            lBoxABC.DataSource = _woerterbuchController.GetAlphabet();
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            lBoxSearchResult.DataSource = _woerterbuchController.FindResults(tBoxSearch.Text, false);
        }

        private void lBoxABC_MouseClick(object sender, MouseEventArgs e)
        {
            lBoxSearchResult.DataSource = _woerterbuchController.FindResults(lBoxABC.SelectedItem.ToString(), true);
        }
    }
}
