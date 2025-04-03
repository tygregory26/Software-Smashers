namespace SoftwareSmashers
{
    public partial class ACarThing : Form
    {

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
            Login Login = new Login();
            Login.Parent = this;
            Login.Show();
        }

        public void loadNewUser()
        {
            NewUser NewUser = new NewUser();
            NewUser.Parent = this;
            NewUser.Show();
        }

        public void loadMenu()
        {
            Menu Menu = new Menu();
            Menu.Parent = this;
            Menu.Show();
        }

        public void loadSettings()
        {
            Settings Settings = new Settings();
            Settings.Parent = this;
            Settings.Show();
        }

        public void loadCarList()
        {
            MyCars carsList = new MyCars();
            carsList.Parent = this;
            carsList.Show();
        }

        public void loadCurrCar()
        {
            IndividualCar individualCar = new IndividualCar();
            individualCar.Parent = this;
            individualCar.Show();
        }
    }
}
