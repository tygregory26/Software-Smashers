using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareSmashers
{
    public partial class ACarThing : Form
    {
        UserControl? currentPage;
        int userID;
        int carID;
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

        public void loadEditUser(int userID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.userID = userID;
            NewUser editUser = new NewUser(userID);
            currentPage = editUser;
            editUser.Parent = this;
            editUser.Show();
        }

        public void loadMenu(int userID)
        {
            this.userID = userID;
            Menu Menu = new Menu(userID);
            Menu.Parent = this;
            Menu.Show();

            InfoBar infoBar = new InfoBar();
            infoBar.Show();
            Menu.Show();
        }

        public void loadIndEdit()
        {
            Menu menu = new Menu();
            menu.showEditButtons();
        }

        public void loadSettings()
        {
            if (currentPage != null) { hideCurrentPage(); }
            Settings Settings = new Settings(userID);
            currentPage = Settings;
            Settings.Parent = this;
            Settings.Show();
        }

        public void loadCarList()
        {
            if (currentPage != null) { hideCurrentPage(); }
            MyCars carsList = new MyCars(userID);
            currentPage = carsList;
            carsList.Parent = this;
            carsList.Show();
        }

        public void loadCurrCar(int carID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.carID = carID;
            IndividualCar individualCar = new IndividualCar(userID, carID);
            currentPage = individualCar;
            individualCar.Parent = this;
            individualCar.Show();
        }

        public void loadEditCar(int carID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.carID = carID;
            NewCar newCar = new NewCar(userID, carID);
            currentPage = newCar;
            newCar.Parent = this;
            newCar.Show();
        }
        public void loadNewCar(int userID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.carID = carID;
            NewCar newCar = new NewCar(userID);
            currentPage = newCar;
            newCar.Parent = this;
            newCar.Show();
        }

        public void loadLogs(int carID)
        {
            this.carID = carID;
            if (currentPage != null) { hideCurrentPage(); }
            Logs logs = new Logs(carID);
            currentPage = logs;
            logs.Parent = this;
            logs.Show();
        }

        public void loadDeleteDriver(int carID)
        {
            this.carID = carID;
            if (currentPage != null) { hideCurrentPage(); }
            DeleteDriver deleteDriver = new DeleteDriver(carID, userID);
            currentPage = deleteDriver;
            deleteDriver.Parent = this;
            deleteDriver.Show();
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
