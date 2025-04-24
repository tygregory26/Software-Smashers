using System.ComponentModel.DataAnnotations.Schema;
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
            this.userID = userID;
            NewUser NewUser = new NewUser();
            currentPage = NewUser;
            NewUser.Parent = this;
            NewUser.Show();
        }

        public void loadMenu(int userID)
        {
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
            Settings Settings = new Settings();
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
