
using System.ComponentModel;

namespace connectDB2
{
    public partial class Form1 : Form
    {
        BindingList<User> _lstUsers;
        DBrequest _dbRequest = new();

        public Form1()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            _lstUsers = new();
            bsUtilisateurs.DataSource = _lstUsers;
            userDataView.DataSource = bsUtilisateurs;
            TxtNom.DataBindings.Add("Text", bsUtilisateurs, "Nom", false, DataSourceUpdateMode.Never);
            TxtPrenom.DataBindings.Add("Text", bsUtilisateurs, "Prenom", false, DataSourceUpdateMode.Never);
            dtpDtNaiss.DataBindings.Add("Text", bsUtilisateurs, "DtNaiss", false, DataSourceUpdateMode.Never);
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            var us = _dbRequest.GetUsers();
            _lstUsers.Clear();
            foreach (User u in us)
            {
                _lstUsers.Add(u);
            }
        }

        private void BTadd_Click(object sender, EventArgs e)
        {
            _dbRequest.InsertUser(TxtNom.Text, TxtPrenom.Text, dtpDtNaiss.Value);
            BtActualiser.PerformClick();

            TxtNom.Clear();
            TxtPrenom.Clear();

        }

        private void BTdelete_Click(object sender, EventArgs e)
        {
            var current = bsUtilisateurs.Current as User;

            if (current is not null)
            {
                _dbRequest.DeleteUser(current.Id);
                BtActualiser.PerformClick();
            }
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            var CurrentUser = bsUtilisateurs.Current as User;
            if (CurrentUser is not null)
            {

                _dbRequest.UpdateUser(CurrentUser.Id, TxtNom.Text, TxtPrenom.Text, dtpDtNaiss.Value, CurrentUser.Nom, CurrentUser.Prenom, CurrentUser.DtNaiss);
                BtActualiser.PerformClick();
            }
        }
    }
}