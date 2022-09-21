using Bunifu.UI.WinForms;
using System;
using System.Windows.Forms;

namespace Password_Manager.User_Controls
{
    public partial class WelcomeScreen : UserControl
    {
        private static WelcomeScreen _instance;

        public static WelcomeScreen Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WelcomeScreen();
                return _instance;
            }
        }

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            dbLoader.Visible = false;
            lblLoadingInfo.Visible = false;
        }

        public BunifuLoader Loader
        {
            get { return dbLoader; }
            set { dbLoader = value; }
        }

        public Label LoadingInfo
        {
            get { return lblLoadingInfo; }
            set { lblLoadingInfo = value; }
        }
    }
}
