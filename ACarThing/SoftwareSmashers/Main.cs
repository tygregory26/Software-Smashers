using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareSmashers
{
    public partial class ACarThing : Form
    {
        UserControl? currentPage;
        UserControl? menuPage;
        int userID;
        int carID;
        dbData DB = new dbData();

        public ACarThing()
        {
            InitializeComponent();
            loadInfoBar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLogin();
            loadInfoBar();
        }

        private void loadInfoBar()
        {
            InfoBar infoBar = new InfoBar();
            infoBar.Parent = this;
            infoBar.Show();
            infoBar.BringToFront();
        }

        public void loadLogin()
        {
            if (currentPage != null) {hideCurrentPage();}
            Login Login = new Login();
            currentPage = Login;
            Login.Parent = this;
            Login.Show();
            loadInfoBar();
        }

        public void loadNewUser()
        {
            if (currentPage != null) { hideCurrentPage(); }
            NewUser NewUser = new NewUser();
            currentPage = NewUser;
            NewUser.Parent = this;
            NewUser.Show();
            loadInfoBar();
        }

        public void loadEditUser(int userID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.userID = userID;
            NewUser editUser = new NewUser(userID);
            currentPage = editUser;
            editUser.Parent = this;
            editUser.Show();
            loadInfoBar();
        }

        public void loadMenu(int userID)
        {
            if (menuPage != null)
            {
                menuPage.Hide();
                menuPage = null;
            }

            this.userID = userID;
            Menu Menu = new Menu(userID);
            Menu.Parent = this;
            Menu.Show();

            menuPage = Menu;

            if (currentPage != null) { hideCurrentPage();}
            background background = new background();
            currentPage = background;
            background.Parent = this;
            background.Show();

            loadInfoBar();
        }

        public void loadSettings()
        {
            if (currentPage != null) { hideCurrentPage(); }
            Settings Settings = new Settings(userID);
            currentPage = Settings;
            Settings.Parent = this;
            Settings.Show();
            loadInfoBar();
        }

        public void loadCarList()
        {
            if (currentPage != null) { hideCurrentPage(); }
            MyCars carsList = new MyCars(userID);
            currentPage = carsList;
            carsList.Parent = this;
            carsList.Show();
            loadInfoBar();
        }

        public void loadCurrCar(int carID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.carID = carID;
            IndividualCar individualCar = new IndividualCar(userID, carID);
            currentPage = individualCar;
            individualCar.Parent = this;
            individualCar.Show();
            loadInfoBar();
        }

        public void loadEditCar(int carID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.carID = carID;
            NewCar newCar = new NewCar(userID, carID);
            currentPage = newCar;
            newCar.Parent = this;
            newCar.Show();
            loadInfoBar();
        }
        public void loadNewCar(int userID)
        {
            if (currentPage != null) { hideCurrentPage(); }
            this.carID = carID;
            NewCar newCar = new NewCar(userID);
            currentPage = newCar;
            newCar.Parent = this;
            newCar.Show();
            loadInfoBar();
        }

        public void loadLogs(int carID)
        {
            this.carID = carID;
            if (currentPage != null) { hideCurrentPage(); }
            Logs logs = new Logs(carID);
            currentPage = logs;
            logs.Parent = this;
            logs.Show();
            loadInfoBar();
        }

        public void loadDeleteDriver(int carID)
        {
            this.carID = carID;
            if (currentPage != null) { hideCurrentPage(); }
            DeleteDriver deleteDriver = new DeleteDriver(carID, userID);
            currentPage = deleteDriver;
            deleteDriver.Parent = this;
            deleteDriver.Show();
            loadInfoBar();
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
