using System;
using System.Windows.Forms;

namespace Password_Manager.User_Controls
{
    public partial class SettingsPanel : UserControl
    {
        private static SettingsPanel _instance;

        public static SettingsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsPanel();
                return _instance;
            }
        }

        public SettingsPanel()
        {
            InitializeComponent();
        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            if (!SettingsContentPanel.Controls.Contains(SettingsUserPanel.Instance))
            {
                SettingsContentPanel.Controls.Add(SettingsUserPanel.Instance);
                SettingsUserPanel.Instance.Dock = DockStyle.Fill;
                SettingsUserPanel.Instance.BringToFront();
            }

            else
            {
                SettingsUserPanel.Instance.BringToFront();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EasyPass.Instance.Panel.Controls.Remove(SettingsPanel.Instance);
        }
    }
}
