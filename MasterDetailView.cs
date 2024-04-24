using System.Reflection;

namespace MasterDetail
{
    public partial class MasterDetailView : Form
    {
        private ConcertHallEditView _editMasterModal = new();
        private TicketEditView _editDetailModal = new();
        public MasterDetailView()
        {
            InitializeComponent();
            masterListBox.DataSource = AppContext.ConcerteHalls;
        }

        private void OnEditMasterButtonClick(object sender, EventArgs e)
        {
            if (!TryGetMaster(out var model))
                return;

            _editMasterModal.Initialize(model);
            var result = _editMasterModal.ShowDialog();
            if (result == DialogResult.OK)
            {
                masterListBox.Refresh();
            }
        }

        private void OnEditDetailButtonClick(object sender, EventArgs e)
        {
            if (!TryGetMaster(out var model))
                return;

            if (!TryGetDetail(out var ticket))
                return;

            _editDetailModal.Initialize(ticket);
            var result = _editDetailModal.ShowDialog();

            if (result == DialogResult.OK)
            {
                detailListBox.Refresh();
            }
        }

        private void OnMasterSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TryGetMaster(out var model))
                return;

            detailListBox.DataSource = model.Tickets;
        }

        private void OnAddDetailButtonClick(object sender, EventArgs e)
        {
            if (!TryGetMaster(out var model))
                return;

            model.AddEmptyTicket();
        }

        private void OnDeleteDetailButtonClick(object sender, EventArgs e)
        {
            if (!TryGetMaster(out var model))
                return;

            if (!TryGetDetail(out var ticket))
                return;

            model.DeleteTicket(ticket);
        }

        private bool TryGetDetail(out TicketModel model)
        {
            model = null;
            if (detailListBox.SelectedItem == null)
                return false;

            model = detailListBox.SelectedItem as TicketModel;
            if (model == null)
                return false;

            return true;
        }

        private bool TryGetMaster(out ConcertHallModel model)
        {
            model = null;
            if (masterListBox.SelectedItem == null)
                return false;

            model = masterListBox.SelectedItem as ConcertHallModel;
            if (model == null)
                return false;

            return true;
        }

        private void OnAddMasterButtonClick(object sender, EventArgs e)
        {
            var model = AppContext.AddEmptyHall();
            masterListBox.SelectedItem = model;
            detailListBox.DataSource = model.Tickets;
        }

        private void OnDeleteMasterButtonClick(object sender, EventArgs e)
        {
            if (!TryGetMaster(out var model))
                return;

            AppContext.RemoveHall(model);
            if (AppContext.ConcerteHalls.Count == 0)
                detailListBox.DataSource = null;
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = saveFileDialog.FileName;
                AppContext.SaveData(selectedPath);
                MessageBox.Show("Данные успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnLoadButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"; // Фильтр для XML-файлов
            openFileDialog.Title = "Загрузить файл";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Начальная директория

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog.FileName;
                if (AppContext.LoadData(selectedPath))
                {
                    MessageBox.Show("Данные успешно загружены.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка загрузки данных.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
