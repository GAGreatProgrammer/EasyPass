
namespace Password_Manager
{
    partial class EasyPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyPass));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.TopPanel = new Bunifu.UI.WinForms.BunifuShapes();
            this.MainFormBorders = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LeftPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnLock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSecureNotes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPersonalInfo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCredisCards = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPasswords = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.TopPanelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LeftPanelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.bgwDecrypt = new System.ComponentModel.BackgroundWorker();
            this.bgwEncrypt = new System.ComponentModel.BackgroundWorker();
            this.bgwLock = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DBStatusSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Angle = 0F;
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TopPanel.BorderThickness = 2;
            this.TopPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TopPanel.FillShape = true;
            this.TopPanel.Location = new System.Drawing.Point(300, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Rectangle;
            this.TopPanel.Sides = 5;
            this.TopPanel.Size = new System.Drawing.Size(750, 40);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "bunifuShapes1";
            // 
            // MainFormBorders
            // 
            this.MainFormBorders.ElipseRadius = 30;
            this.MainFormBorders.TargetControl = this;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LeftPanel.BorderRadius = 0;
            this.LeftPanel.BorderThickness = 0;
            this.LeftPanel.Controls.Add(this.txtSearch);
            this.LeftPanel.Controls.Add(this.btnLock);
            this.LeftPanel.Controls.Add(this.btnLogOut);
            this.LeftPanel.Controls.Add(this.btnSecureNotes);
            this.LeftPanel.Controls.Add(this.btnSettings);
            this.LeftPanel.Controls.Add(this.btnPersonalInfo);
            this.LeftPanel.Controls.Add(this.btnCredisCards);
            this.LeftPanel.Controls.Add(this.btnPasswords);
            this.LeftPanel.Controls.Add(this.bunifuSeparator1);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.pictureBox1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShowBorders = true;
            this.LeftPanel.Size = new System.Drawing.Size(300, 800);
            this.LeftPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.txtSearch.BorderRadius = 30;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 7;
            this.txtSearch.IconRight = global::Password_Manager.Properties.Resources.Search;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(10, 160);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(280, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Search...";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.OnIconRightClick += new System.EventHandler(this.txtSearch_OnIconRightClick);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // btnLock
            // 
            this.btnLock.AllowAnimations = true;
            this.btnLock.AllowMouseEffects = true;
            this.btnLock.AllowToggling = false;
            this.btnLock.AnimationSpeed = 200;
            this.btnLock.AutoGenerateColors = false;
            this.btnLock.AutoRoundBorders = false;
            this.btnLock.AutoSizeLeftIcon = true;
            this.btnLock.AutoSizeRightIcon = true;
            this.btnLock.BackColor = System.Drawing.Color.Transparent;
            this.btnLock.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLock.BackgroundImage")));
            this.btnLock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLock.ButtonText = "Lock";
            this.btnLock.ButtonTextMarginLeft = 0;
            this.btnLock.ColorContrastOnClick = 45;
            this.btnLock.ColorContrastOnHover = 45;
            this.btnLock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLock.CustomizableEdges = borderEdges1;
            this.btnLock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLock.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLock.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.IconLeft = global::Password_Manager.Properties.Resources.LockButton;
            this.btnLock.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLock.IconLeftPadding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnLock.IconMarginLeft = 11;
            this.btnLock.IconPadding = 20;
            this.btnLock.IconRight = null;
            this.btnLock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLock.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnLock.IconSize = 25;
            this.btnLock.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLock.IdleBorderRadius = 0;
            this.btnLock.IdleBorderThickness = 0;
            this.btnLock.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLock.IdleIconLeftImage = global::Password_Manager.Properties.Resources.LockButton;
            this.btnLock.IdleIconRightImage = null;
            this.btnLock.IndicateFocus = false;
            this.btnLock.Location = new System.Drawing.Point(100, 730);
            this.btnLock.Name = "btnLock";
            this.btnLock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLock.OnDisabledState.BorderRadius = 0;
            this.btnLock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLock.OnDisabledState.BorderThickness = 1;
            this.btnLock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLock.OnDisabledState.IconLeftImage = null;
            this.btnLock.OnDisabledState.IconRightImage = null;
            this.btnLock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnLock.onHoverState.BorderRadius = 0;
            this.btnLock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLock.onHoverState.BorderThickness = 1;
            this.btnLock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnLock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLock.onHoverState.IconLeftImage = null;
            this.btnLock.onHoverState.IconRightImage = null;
            this.btnLock.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLock.OnIdleState.BorderRadius = 0;
            this.btnLock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLock.OnIdleState.BorderThickness = 1;
            this.btnLock.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLock.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.LockButton;
            this.btnLock.OnIdleState.IconRightImage = null;
            this.btnLock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLock.OnPressedState.BorderRadius = 0;
            this.btnLock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLock.OnPressedState.BorderThickness = 1;
            this.btnLock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLock.OnPressedState.IconLeftImage = null;
            this.btnLock.OnPressedState.IconRightImage = null;
            this.btnLock.Size = new System.Drawing.Size(100, 70);
            this.btnLock.TabIndex = 11;
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLock.TextMarginLeft = 0;
            this.btnLock.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLock.UseDefaultRadiusAndThickness = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AllowAnimations = true;
            this.btnLogOut.AllowMouseEffects = true;
            this.btnLogOut.AllowToggling = false;
            this.btnLogOut.AnimationSpeed = 200;
            this.btnLogOut.AutoGenerateColors = false;
            this.btnLogOut.AutoRoundBorders = false;
            this.btnLogOut.AutoSizeLeftIcon = true;
            this.btnLogOut.AutoSizeRightIcon = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.ButtonText = "Log Out";
            this.btnLogOut.ButtonTextMarginLeft = 0;
            this.btnLogOut.ColorContrastOnClick = 45;
            this.btnLogOut.ColorContrastOnHover = 45;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLogOut.CustomizableEdges = borderEdges2;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogOut.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLogOut.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLogOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconLeft = global::Password_Manager.Properties.Resources.Log_Out;
            this.btnLogOut.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconLeftPadding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnLogOut.IconMarginLeft = 11;
            this.btnLogOut.IconPadding = 20;
            this.btnLogOut.IconRight = null;
            this.btnLogOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnLogOut.IconSize = 25;
            this.btnLogOut.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLogOut.IdleBorderRadius = 0;
            this.btnLogOut.IdleBorderThickness = 0;
            this.btnLogOut.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLogOut.IdleIconLeftImage = global::Password_Manager.Properties.Resources.Log_Out;
            this.btnLogOut.IdleIconRightImage = null;
            this.btnLogOut.IndicateFocus = false;
            this.btnLogOut.Location = new System.Drawing.Point(200, 730);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogOut.OnDisabledState.BorderRadius = 0;
            this.btnLogOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnDisabledState.BorderThickness = 1;
            this.btnLogOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLogOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogOut.OnDisabledState.IconLeftImage = null;
            this.btnLogOut.OnDisabledState.IconRightImage = null;
            this.btnLogOut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnLogOut.onHoverState.BorderRadius = 0;
            this.btnLogOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.onHoverState.BorderThickness = 1;
            this.btnLogOut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnLogOut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.onHoverState.IconLeftImage = null;
            this.btnLogOut.onHoverState.IconRightImage = null;
            this.btnLogOut.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLogOut.OnIdleState.BorderRadius = 0;
            this.btnLogOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnIdleState.BorderThickness = 1;
            this.btnLogOut.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLogOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.Log_Out;
            this.btnLogOut.OnIdleState.IconRightImage = null;
            this.btnLogOut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLogOut.OnPressedState.BorderRadius = 0;
            this.btnLogOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnPressedState.BorderThickness = 1;
            this.btnLogOut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLogOut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnPressedState.IconLeftImage = null;
            this.btnLogOut.OnPressedState.IconRightImage = null;
            this.btnLogOut.Size = new System.Drawing.Size(100, 70);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.TextMarginLeft = 0;
            this.btnLogOut.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLogOut.UseDefaultRadiusAndThickness = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSecureNotes
            // 
            this.btnSecureNotes.AllowAnimations = true;
            this.btnSecureNotes.AllowMouseEffects = true;
            this.btnSecureNotes.AllowToggling = false;
            this.btnSecureNotes.AnimationSpeed = 200;
            this.btnSecureNotes.AutoGenerateColors = false;
            this.btnSecureNotes.AutoRoundBorders = false;
            this.btnSecureNotes.AutoSizeLeftIcon = true;
            this.btnSecureNotes.AutoSizeRightIcon = true;
            this.btnSecureNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnSecureNotes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSecureNotes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecureNotes.BackgroundImage")));
            this.btnSecureNotes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecureNotes.ButtonText = "Notes";
            this.btnSecureNotes.ButtonTextMarginLeft = 0;
            this.btnSecureNotes.ColorContrastOnClick = 45;
            this.btnSecureNotes.ColorContrastOnHover = 45;
            this.btnSecureNotes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSecureNotes.CustomizableEdges = borderEdges3;
            this.btnSecureNotes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSecureNotes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSecureNotes.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSecureNotes.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSecureNotes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSecureNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecureNotes.ForeColor = System.Drawing.Color.White;
            this.btnSecureNotes.IconLeft = global::Password_Manager.Properties.Resources.SecureNotesButton;
            this.btnSecureNotes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecureNotes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSecureNotes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSecureNotes.IconMarginLeft = 11;
            this.btnSecureNotes.IconPadding = 8;
            this.btnSecureNotes.IconRight = null;
            this.btnSecureNotes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecureNotes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSecureNotes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSecureNotes.IconSize = 25;
            this.btnSecureNotes.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSecureNotes.IdleBorderRadius = 0;
            this.btnSecureNotes.IdleBorderThickness = 0;
            this.btnSecureNotes.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSecureNotes.IdleIconLeftImage = global::Password_Manager.Properties.Resources.SecureNotesButton;
            this.btnSecureNotes.IdleIconRightImage = null;
            this.btnSecureNotes.IndicateFocus = false;
            this.btnSecureNotes.Location = new System.Drawing.Point(0, 435);
            this.btnSecureNotes.Name = "btnSecureNotes";
            this.btnSecureNotes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSecureNotes.OnDisabledState.BorderRadius = 1;
            this.btnSecureNotes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecureNotes.OnDisabledState.BorderThickness = 1;
            this.btnSecureNotes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSecureNotes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSecureNotes.OnDisabledState.IconLeftImage = null;
            this.btnSecureNotes.OnDisabledState.IconRightImage = null;
            this.btnSecureNotes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnSecureNotes.onHoverState.BorderRadius = 1;
            this.btnSecureNotes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecureNotes.onHoverState.BorderThickness = 1;
            this.btnSecureNotes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnSecureNotes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSecureNotes.onHoverState.IconLeftImage = null;
            this.btnSecureNotes.onHoverState.IconRightImage = null;
            this.btnSecureNotes.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSecureNotes.OnIdleState.BorderRadius = 1;
            this.btnSecureNotes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecureNotes.OnIdleState.BorderThickness = 1;
            this.btnSecureNotes.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSecureNotes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSecureNotes.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.SecureNotesButton;
            this.btnSecureNotes.OnIdleState.IconRightImage = null;
            this.btnSecureNotes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSecureNotes.OnPressedState.BorderRadius = 1;
            this.btnSecureNotes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecureNotes.OnPressedState.BorderThickness = 1;
            this.btnSecureNotes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSecureNotes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSecureNotes.OnPressedState.IconLeftImage = null;
            this.btnSecureNotes.OnPressedState.IconRightImage = null;
            this.btnSecureNotes.Size = new System.Drawing.Size(300, 39);
            this.btnSecureNotes.TabIndex = 8;
            this.btnSecureNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecureNotes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSecureNotes.TextMarginLeft = 0;
            this.btnSecureNotes.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSecureNotes.UseDefaultRadiusAndThickness = true;
            this.btnSecureNotes.Click += new System.EventHandler(this.btnSecureNotes_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowMouseEffects = true;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AnimationSpeed = 200;
            this.btnSettings.AutoGenerateColors = false;
            this.btnSettings.AutoRoundBorders = false;
            this.btnSettings.AutoSizeLeftIcon = true;
            this.btnSettings.AutoSizeRightIcon = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.ButtonTextMarginLeft = 0;
            this.btnSettings.ColorContrastOnClick = 45;
            this.btnSettings.ColorContrastOnHover = 45;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges4;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSettings.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSettings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconLeft = global::Password_Manager.Properties.Resources.SettingsButton;
            this.btnSettings.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconLeftPadding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnSettings.IconMarginLeft = 11;
            this.btnSettings.IconPadding = 20;
            this.btnSettings.IconRight = null;
            this.btnSettings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnSettings.IconSize = 25;
            this.btnSettings.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSettings.IdleBorderRadius = 0;
            this.btnSettings.IdleBorderThickness = 0;
            this.btnSettings.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSettings.IdleIconLeftImage = global::Password_Manager.Properties.Resources.SettingsButton;
            this.btnSettings.IdleIconRightImage = null;
            this.btnSettings.IndicateFocus = false;
            this.btnSettings.Location = new System.Drawing.Point(-1, 730);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.OnDisabledState.BorderRadius = 0;
            this.btnSettings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnDisabledState.BorderThickness = 1;
            this.btnSettings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.OnDisabledState.IconLeftImage = null;
            this.btnSettings.OnDisabledState.IconRightImage = null;
            this.btnSettings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnSettings.onHoverState.BorderRadius = 0;
            this.btnSettings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.onHoverState.BorderThickness = 1;
            this.btnSettings.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnSettings.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.onHoverState.IconLeftImage = null;
            this.btnSettings.onHoverState.IconRightImage = null;
            this.btnSettings.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnSettings.OnIdleState.BorderRadius = 0;
            this.btnSettings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnIdleState.BorderThickness = 1;
            this.btnSettings.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.SettingsButton;
            this.btnSettings.OnIdleState.IconRightImage = null;
            this.btnSettings.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.OnPressedState.BorderRadius = 0;
            this.btnSettings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnPressedState.BorderThickness = 1;
            this.btnSettings.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnPressedState.IconLeftImage = null;
            this.btnSettings.OnPressedState.IconRightImage = null;
            this.btnSettings.Size = new System.Drawing.Size(101, 70);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.TextMarginLeft = 0;
            this.btnSettings.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnSettings.UseDefaultRadiusAndThickness = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.AllowAnimations = true;
            this.btnPersonalInfo.AllowMouseEffects = true;
            this.btnPersonalInfo.AllowToggling = false;
            this.btnPersonalInfo.AnimationSpeed = 200;
            this.btnPersonalInfo.AutoGenerateColors = false;
            this.btnPersonalInfo.AutoRoundBorders = false;
            this.btnPersonalInfo.AutoSizeLeftIcon = true;
            this.btnPersonalInfo.AutoSizeRightIcon = true;
            this.btnPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalInfo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPersonalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonalInfo.BackgroundImage")));
            this.btnPersonalInfo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPersonalInfo.ButtonText = "Personal Info";
            this.btnPersonalInfo.ButtonTextMarginLeft = 0;
            this.btnPersonalInfo.ColorContrastOnClick = 45;
            this.btnPersonalInfo.ColorContrastOnHover = 45;
            this.btnPersonalInfo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPersonalInfo.CustomizableEdges = borderEdges5;
            this.btnPersonalInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPersonalInfo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPersonalInfo.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPersonalInfo.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPersonalInfo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.IconLeft = global::Password_Manager.Properties.Resources.PersonalInfoButton;
            this.btnPersonalInfo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPersonalInfo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPersonalInfo.IconMarginLeft = 11;
            this.btnPersonalInfo.IconPadding = 8;
            this.btnPersonalInfo.IconRight = null;
            this.btnPersonalInfo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalInfo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPersonalInfo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPersonalInfo.IconSize = 25;
            this.btnPersonalInfo.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPersonalInfo.IdleBorderRadius = 0;
            this.btnPersonalInfo.IdleBorderThickness = 0;
            this.btnPersonalInfo.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPersonalInfo.IdleIconLeftImage = global::Password_Manager.Properties.Resources.PersonalInfoButton;
            this.btnPersonalInfo.IdleIconRightImage = null;
            this.btnPersonalInfo.IndicateFocus = false;
            this.btnPersonalInfo.Location = new System.Drawing.Point(0, 370);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPersonalInfo.OnDisabledState.BorderRadius = 1;
            this.btnPersonalInfo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPersonalInfo.OnDisabledState.BorderThickness = 1;
            this.btnPersonalInfo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPersonalInfo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPersonalInfo.OnDisabledState.IconLeftImage = null;
            this.btnPersonalInfo.OnDisabledState.IconRightImage = null;
            this.btnPersonalInfo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnPersonalInfo.onHoverState.BorderRadius = 1;
            this.btnPersonalInfo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPersonalInfo.onHoverState.BorderThickness = 1;
            this.btnPersonalInfo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnPersonalInfo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.onHoverState.IconLeftImage = null;
            this.btnPersonalInfo.onHoverState.IconRightImage = null;
            this.btnPersonalInfo.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPersonalInfo.OnIdleState.BorderRadius = 1;
            this.btnPersonalInfo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPersonalInfo.OnIdleState.BorderThickness = 1;
            this.btnPersonalInfo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPersonalInfo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.PersonalInfoButton;
            this.btnPersonalInfo.OnIdleState.IconRightImage = null;
            this.btnPersonalInfo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPersonalInfo.OnPressedState.BorderRadius = 1;
            this.btnPersonalInfo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPersonalInfo.OnPressedState.BorderThickness = 1;
            this.btnPersonalInfo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPersonalInfo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.OnPressedState.IconLeftImage = null;
            this.btnPersonalInfo.OnPressedState.IconRightImage = null;
            this.btnPersonalInfo.Size = new System.Drawing.Size(300, 39);
            this.btnPersonalInfo.TabIndex = 7;
            this.btnPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPersonalInfo.TextMarginLeft = 0;
            this.btnPersonalInfo.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnPersonalInfo.UseDefaultRadiusAndThickness = true;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // btnCredisCards
            // 
            this.btnCredisCards.AllowAnimations = true;
            this.btnCredisCards.AllowMouseEffects = true;
            this.btnCredisCards.AllowToggling = false;
            this.btnCredisCards.AnimationSpeed = 200;
            this.btnCredisCards.AutoGenerateColors = false;
            this.btnCredisCards.AutoRoundBorders = false;
            this.btnCredisCards.AutoSizeLeftIcon = true;
            this.btnCredisCards.AutoSizeRightIcon = true;
            this.btnCredisCards.BackColor = System.Drawing.Color.Transparent;
            this.btnCredisCards.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCredisCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCredisCards.BackgroundImage")));
            this.btnCredisCards.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCredisCards.ButtonText = "Credit Cards";
            this.btnCredisCards.ButtonTextMarginLeft = 0;
            this.btnCredisCards.ColorContrastOnClick = 45;
            this.btnCredisCards.ColorContrastOnHover = 45;
            this.btnCredisCards.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnCredisCards.CustomizableEdges = borderEdges6;
            this.btnCredisCards.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCredisCards.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCredisCards.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCredisCards.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCredisCards.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCredisCards.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredisCards.ForeColor = System.Drawing.Color.White;
            this.btnCredisCards.IconLeft = global::Password_Manager.Properties.Resources.CreditCardButton;
            this.btnCredisCards.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredisCards.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCredisCards.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCredisCards.IconMarginLeft = 11;
            this.btnCredisCards.IconPadding = 8;
            this.btnCredisCards.IconRight = null;
            this.btnCredisCards.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCredisCards.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCredisCards.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCredisCards.IconSize = 25;
            this.btnCredisCards.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCredisCards.IdleBorderRadius = 0;
            this.btnCredisCards.IdleBorderThickness = 0;
            this.btnCredisCards.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCredisCards.IdleIconLeftImage = global::Password_Manager.Properties.Resources.CreditCardButton;
            this.btnCredisCards.IdleIconRightImage = null;
            this.btnCredisCards.IndicateFocus = false;
            this.btnCredisCards.Location = new System.Drawing.Point(0, 305);
            this.btnCredisCards.Name = "btnCredisCards";
            this.btnCredisCards.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCredisCards.OnDisabledState.BorderRadius = 1;
            this.btnCredisCards.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCredisCards.OnDisabledState.BorderThickness = 1;
            this.btnCredisCards.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCredisCards.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCredisCards.OnDisabledState.IconLeftImage = null;
            this.btnCredisCards.OnDisabledState.IconRightImage = null;
            this.btnCredisCards.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnCredisCards.onHoverState.BorderRadius = 1;
            this.btnCredisCards.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCredisCards.onHoverState.BorderThickness = 1;
            this.btnCredisCards.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnCredisCards.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCredisCards.onHoverState.IconLeftImage = null;
            this.btnCredisCards.onHoverState.IconRightImage = null;
            this.btnCredisCards.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCredisCards.OnIdleState.BorderRadius = 1;
            this.btnCredisCards.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCredisCards.OnIdleState.BorderThickness = 1;
            this.btnCredisCards.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCredisCards.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCredisCards.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.CreditCardButton;
            this.btnCredisCards.OnIdleState.IconRightImage = null;
            this.btnCredisCards.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCredisCards.OnPressedState.BorderRadius = 1;
            this.btnCredisCards.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCredisCards.OnPressedState.BorderThickness = 1;
            this.btnCredisCards.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCredisCards.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCredisCards.OnPressedState.IconLeftImage = null;
            this.btnCredisCards.OnPressedState.IconRightImage = null;
            this.btnCredisCards.Size = new System.Drawing.Size(300, 39);
            this.btnCredisCards.TabIndex = 6;
            this.btnCredisCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredisCards.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCredisCards.TextMarginLeft = 0;
            this.btnCredisCards.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCredisCards.UseDefaultRadiusAndThickness = true;
            this.btnCredisCards.Click += new System.EventHandler(this.btnCredisCards_Click);
            // 
            // btnPasswords
            // 
            this.btnPasswords.AllowAnimations = true;
            this.btnPasswords.AllowMouseEffects = true;
            this.btnPasswords.AllowToggling = false;
            this.btnPasswords.AnimationSpeed = 200;
            this.btnPasswords.AutoGenerateColors = false;
            this.btnPasswords.AutoRoundBorders = false;
            this.btnPasswords.AutoSizeLeftIcon = true;
            this.btnPasswords.AutoSizeRightIcon = true;
            this.btnPasswords.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswords.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPasswords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasswords.BackgroundImage")));
            this.btnPasswords.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPasswords.ButtonText = "Passwords";
            this.btnPasswords.ButtonTextMarginLeft = 0;
            this.btnPasswords.ColorContrastOnClick = 45;
            this.btnPasswords.ColorContrastOnHover = 45;
            this.btnPasswords.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnPasswords.CustomizableEdges = borderEdges7;
            this.btnPasswords.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPasswords.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPasswords.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPasswords.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPasswords.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPasswords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswords.ForeColor = System.Drawing.Color.White;
            this.btnPasswords.IconLeft = global::Password_Manager.Properties.Resources.PasswordsButton;
            this.btnPasswords.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswords.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPasswords.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPasswords.IconMarginLeft = 11;
            this.btnPasswords.IconPadding = 8;
            this.btnPasswords.IconRight = null;
            this.btnPasswords.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPasswords.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPasswords.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPasswords.IconSize = 25;
            this.btnPasswords.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPasswords.IdleBorderRadius = 0;
            this.btnPasswords.IdleBorderThickness = 0;
            this.btnPasswords.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPasswords.IdleIconLeftImage = global::Password_Manager.Properties.Resources.PasswordsButton;
            this.btnPasswords.IdleIconRightImage = null;
            this.btnPasswords.IndicateFocus = false;
            this.btnPasswords.Location = new System.Drawing.Point(0, 240);
            this.btnPasswords.Name = "btnPasswords";
            this.btnPasswords.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPasswords.OnDisabledState.BorderRadius = 1;
            this.btnPasswords.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPasswords.OnDisabledState.BorderThickness = 1;
            this.btnPasswords.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPasswords.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPasswords.OnDisabledState.IconLeftImage = null;
            this.btnPasswords.OnDisabledState.IconRightImage = null;
            this.btnPasswords.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnPasswords.onHoverState.BorderRadius = 1;
            this.btnPasswords.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPasswords.onHoverState.BorderThickness = 1;
            this.btnPasswords.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(129)))));
            this.btnPasswords.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPasswords.onHoverState.IconLeftImage = null;
            this.btnPasswords.onHoverState.IconRightImage = null;
            this.btnPasswords.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPasswords.OnIdleState.BorderRadius = 1;
            this.btnPasswords.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPasswords.OnIdleState.BorderThickness = 1;
            this.btnPasswords.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPasswords.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPasswords.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.PasswordsButton;
            this.btnPasswords.OnIdleState.IconRightImage = null;
            this.btnPasswords.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPasswords.OnPressedState.BorderRadius = 1;
            this.btnPasswords.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPasswords.OnPressedState.BorderThickness = 1;
            this.btnPasswords.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPasswords.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPasswords.OnPressedState.IconLeftImage = null;
            this.btnPasswords.OnPressedState.IconRightImage = null;
            this.btnPasswords.Size = new System.Drawing.Size(300, 39);
            this.btnPasswords.TabIndex = 5;
            this.btnPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswords.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPasswords.TextMarginLeft = 0;
            this.btnPasswords.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnPasswords.UseDefaultRadiusAndThickness = true;
            this.btnPasswords.Click += new System.EventHandler(this.btnPasswords_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 722);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(300, 14);
            this.bunifuSeparator1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "EasyPass";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pictureBox1.Image = global::Password_Manager.Properties.Resources.Password;
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClose.Image = global::Password_Manager.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1018, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnMinimize.Image = global::Password_Manager.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(988, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.Fixed = true;
            this.TopPanelDragControl.Horizontal = true;
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            this.TopPanelDragControl.Vertical = true;
            // 
            // LeftPanelDragControl
            // 
            this.LeftPanelDragControl.Fixed = true;
            this.LeftPanelDragControl.Horizontal = true;
            this.LeftPanelDragControl.TargetControl = this.LeftPanel;
            this.LeftPanelDragControl.Vertical = true;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(300, 40);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(750, 760);
            this.ContentPanel.TabIndex = 15;
            // 
            // bgwDecrypt
            // 
            this.bgwDecrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDecrypt_DoWork);
            // 
            // bgwEncrypt
            // 
            this.bgwEncrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEncrypt_DoWork);
            // 
            // bgwLock
            // 
            this.bgwLock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLock_DoWork);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "EasyPass";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // DBStatusSnackbar
            // 
            this.DBStatusSnackbar.AllowDragging = false;
            this.DBStatusSnackbar.AllowMultipleViews = true;
            this.DBStatusSnackbar.ClickToClose = true;
            this.DBStatusSnackbar.DoubleClickToClose = true;
            this.DBStatusSnackbar.DurationAfterIdle = 3000;
            this.DBStatusSnackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.ErrorOptions.ActionBorderRadius = 1;
            this.DBStatusSnackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.DBStatusSnackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.DBStatusSnackbar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DBStatusSnackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.DBStatusSnackbar.ErrorOptions.IconLeftMargin = 12;
            this.DBStatusSnackbar.FadeCloseIcon = false;
            this.DBStatusSnackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.DBStatusSnackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.InformationOptions.ActionBorderRadius = 1;
            this.DBStatusSnackbar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.DBStatusSnackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DBStatusSnackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.DBStatusSnackbar.InformationOptions.IconLeftMargin = 12;
            this.DBStatusSnackbar.Margin = 10;
            this.DBStatusSnackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.DBStatusSnackbar.MaximumViews = 7;
            this.DBStatusSnackbar.MessageRightMargin = 15;
            this.DBStatusSnackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.DBStatusSnackbar.ShowBorders = false;
            this.DBStatusSnackbar.ShowCloseIcon = true;
            this.DBStatusSnackbar.ShowIcon = true;
            this.DBStatusSnackbar.ShowShadows = true;
            this.DBStatusSnackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.SuccessOptions.ActionBorderRadius = 1;
            this.DBStatusSnackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBStatusSnackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBStatusSnackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.DBStatusSnackbar.SuccessOptions.IconLeftMargin = 12;
            this.DBStatusSnackbar.ViewsMargin = 7;
            this.DBStatusSnackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBStatusSnackbar.WarningOptions.ActionBorderRadius = 1;
            this.DBStatusSnackbar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.DBStatusSnackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.DBStatusSnackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.DBStatusSnackbar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DBStatusSnackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.DBStatusSnackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.DBStatusSnackbar.WarningOptions.IconLeftMargin = 12;
            this.DBStatusSnackbar.ZoomCloseIcon = true;
            // 
            // EasyPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 800);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EasyPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyPass";
            this.Load += new System.EventHandler(this.EasyPass_Load);
            this.Resize += new System.EventHandler(this.EasyPass_Resize);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShapes TopPanel;
        private Bunifu.UI.WinForms.BunifuPanel LeftPanel;
        private Bunifu.Framework.UI.BunifuElipse MainFormBorders;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSecureNotes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPersonalInfo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCredisCards;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPasswords;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogOut;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private Bunifu.Framework.UI.BunifuDragControl TopPanelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl LeftPanelDragControl;
        private System.Windows.Forms.Panel ContentPanel;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private System.ComponentModel.BackgroundWorker bgwDecrypt;
        private System.ComponentModel.BackgroundWorker bgwEncrypt;
        private System.ComponentModel.BackgroundWorker bgwLock;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Bunifu.UI.WinForms.BunifuSnackbar DBStatusSnackbar;
    }
}

