using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDetail
{
    public partial class TicketEditView : Form
    {
        private TicketModel _model;
        public TicketEditView()
        {
            InitializeComponent();
        }

        public void Initialize(TicketModel model)
        {
            _model = model;
            numberTextBox.Texts = _model.Number.ToString();
            placeTextBox.Texts = _model.PlaceName.ToString();
            eventTextBox.Texts = _model.EventName.ToString();
            priceTextBox.Texts = _model.Price.ToString();
        }

        private void OnSaveButtonCLick(object sender, EventArgs e)
        {
            _model.Number = int.Parse(numberTextBox.Texts);
            _model.PlaceName = placeTextBox.Texts;
            _model.EventName = eventTextBox.Texts;
            _model.Price = int.Parse(priceTextBox.Texts);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
