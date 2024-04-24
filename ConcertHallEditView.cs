using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MasterDetail
{
    public partial class ConcertHallEditView : Form
    {
        private ConcertHallModel _model;
        public ConcertHallEditView()
        {
            InitializeComponent();
        }

        public void Initialize(ConcertHallModel concertHall)
        {
            _model = concertHall;
            nameTextBox.Texts = concertHall.Name;
            addressTextBox.Texts = concertHall.Adress;
            capacityTextBox.Texts = concertHall.Capacity.ToString();
            openingDateTextBox.Texts = string.Format("{0:dd.MM.yyyy}", concertHall.OpeningDate);
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(openingDateTextBox.Texts, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var openingDate))
            {
                _model.OpeningDate = openingDate;
            }
            else
            {
                MessageBox.Show("Неверная дата: формат \"dd.MM.yyyy\"");
                return;
            }

            _model.Name = nameTextBox.Texts;
            _model.Adress = addressTextBox.Texts;
            _model.Capacity = int.Parse(capacityTextBox.Texts);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
