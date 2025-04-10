using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareSmashers
{
    public partial class ACarThing : Form
    {
        UserControl? currentPage;
        dbData DB = new dbData();

        public ACarThing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLogin();
        }

        public void loadLogin()
        {
            if (currentPage != null) {hideCurrentPage();}
            Login Login = new Login();
            currentPage = Login;
            Login.Parent = this;
            Login.Show();
        }

        public void loadNewUser()
        {
            if (currentPage != null) { hideCurrentPage(); }
            NewUser NewUser = new NewUser();
            currentPage = NewUser;
            NewUser.Parent = this;
            NewUser.Show();
        }

        public void loadMenu(bool carSreen)
        {
            Menu Menu = new Menu();
            Menu.Parent = this;
            Menu.Show();

            InfoBar infoBar = new InfoBar();
            infoBar.Show();
            Menu.Show();
            try
            {
                if (carSreen)
                {
                    Menu.Controls["Btn_Menu_viewLogs"].Show();
                    Menu.Controls["Btn_Menu_editVehicle"].Show();
                }
                else
                {
                    Menu.Controls["Btn_Menu_viewLogs"].Hide();
                    Menu.Controls["Btn_Menu_editVehicle"].Hide();
                }
            } catch (NullReferenceException nre)
            {
                // Temp thing for dealing with this
            }
            
        }

        public void loadSettings()
        {
            if (currentPage != null) { hideCurrentPage(); }
            Settings Settings = new Settings();
            currentPage = Settings;
            Settings.Parent = this;
            Settings.Show();
        }

        public void loadCarList()
        {
            if (currentPage != null) { hideCurrentPage(); }
            MyCars carsList = new MyCars();
            currentPage = carsList;
            carsList.Parent = this;
            carsList.Show();
        }

        public void loadCurrCar()
        {
            if (currentPage != null) { hideCurrentPage(); }
            IndividualCar individualCar = new IndividualCar();
            currentPage = individualCar;
            individualCar.Parent = this;
            individualCar.Show();
        }

        public void loadLogs()
        {
            if (currentPage != null) { hideCurrentPage(); }
            Logs logs = new Logs();
            currentPage = logs;
            logs.Parent = this;
            logs.Show();
        }

        public void hideCurrentPage()
        {
            if (currentPage != null)
            {
                currentPage.Hide();
                currentPage = null;
            }
        }
    }
}
