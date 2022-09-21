
namespace Password_Manager.User_Controls
{
    partial class NotesPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnAddNew = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DGVRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.AllowAnimations = true;
            this.btnAddNew.AllowMouseEffects = true;
            this.btnAddNew.AllowToggling = false;
            this.btnAddNew.AnimationSpeed = 200;
            this.btnAddNew.AutoGenerateColors = false;
            this.btnAddNew.AutoRoundBorders = false;
            this.btnAddNew.AutoSizeLeftIcon = true;
            this.btnAddNew.AutoSizeRightIcon = true;
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
            this.btnAddNew.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.ButtonText = "Add New";
            this.btnAddNew.ButtonTextMarginLeft = 0;
            this.btnAddNew.ColorContrastOnClick = 45;
            this.btnAddNew.ColorContrastOnHover = 45;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddNew.CustomizableEdges = borderEdges1;
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNew.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddNew.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddNew.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.IconLeft = null;
            this.btnAddNew.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNew.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNew.IconMarginLeft = 11;
            this.btnAddNew.IconPadding = 10;
            this.btnAddNew.IconRight = null;
            this.btnAddNew.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNew.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNew.IconSize = 25;
            this.btnAddNew.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddNew.IdleBorderRadius = 0;
            this.btnAddNew.IdleBorderThickness = 0;
            this.btnAddNew.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddNew.IdleIconLeftImage = null;
            this.btnAddNew.IdleIconRightImage = null;
            this.btnAddNew.IndicateFocus = false;
            this.btnAddNew.Location = new System.Drawing.Point(620, 20);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNew.OnDisabledState.BorderRadius = 30;
            this.btnAddNew.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.OnDisabledState.BorderThickness = 1;
            this.btnAddNew.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNew.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNew.OnDisabledState.IconLeftImage = null;
            this.btnAddNew.OnDisabledState.IconRightImage = null;
            this.btnAddNew.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNew.onHoverState.BorderRadius = 30;
            this.btnAddNew.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.onHoverState.BorderThickness = 1;
            this.btnAddNew.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNew.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.onHoverState.IconLeftImage = null;
            this.btnAddNew.onHoverState.IconRightImage = null;
            this.btnAddNew.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddNew.OnIdleState.BorderRadius = 30;
            this.btnAddNew.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.OnIdleState.BorderThickness = 1;
            this.btnAddNew.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddNew.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.OnIdleState.IconLeftImage = null;
            this.btnAddNew.OnIdleState.IconRightImage = null;
            this.btnAddNew.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddNew.OnPressedState.BorderRadius = 30;
            this.btnAddNew.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.OnPressedState.BorderThickness = 1;
            this.btnAddNew.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddNew.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.OnPressedState.IconLeftImage = null;
            this.btnAddNew.OnPressedState.IconRightImage = null;
            this.btnAddNew.Size = new System.Drawing.Size(100, 35);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNew.TextMarginLeft = 0;
            this.btnAddNew.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.btnAddNew, "");
            this.ToolTip.SetToolTipIcon(this.btnAddNew, null);
            this.ToolTip.SetToolTipTitle(this.btnAddNew, "");
            this.btnAddNew.UseDefaultRadiusAndThickness = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Notes";
            this.ToolTip.SetToolTip(this.label1, "");
            this.ToolTip.SetToolTipIcon(this.label1, null);
            this.ToolTip.SetToolTipTitle(this.label1, "");
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowCustomTheming = true;
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AllowUserToResizeColumns = false;
            this.dgvNotes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotes.ColumnHeadersHeight = 40;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNotes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dgvNotes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNotes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvNotes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNotes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNotes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dgvNotes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvNotes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dgvNotes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNotes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvNotes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotes.CurrentTheme.Name = null;
            this.dgvNotes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNotes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.dgvNotes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNotes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvNotes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotes.EnableHeadersVisualStyles = false;
            this.dgvNotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dgvNotes.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvNotes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNotes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvNotes.Location = new System.Drawing.Point(25, 70);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.RowTemplate.Height = 35;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.ShowCellToolTips = false;
            this.dgvNotes.Size = new System.Drawing.Size(695, 660);
            this.dgvNotes.TabIndex = 14;
            this.dgvNotes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.ToolTip.SetToolTip(this.dgvNotes, "");
            this.ToolTip.SetToolTipIcon(this.dgvNotes, null);
            this.ToolTip.SetToolTipTitle(this.dgvNotes, "");
            this.dgvNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            this.dgvNotes.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellMouseEnter);
            this.dgvNotes.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellMouseLeave);
            // 
            // DGVRadius
            // 
            this.DGVRadius.ElipseRadius = 20;
            this.DGVRadius.TargetControl = this.dgvNotes;
            // 
            // ToolTip
            // 
            this.ToolTip.Active = true;
            this.ToolTip.AlignTextWithTitle = false;
            this.ToolTip.AllowAutoClose = false;
            this.ToolTip.AllowFading = true;
            this.ToolTip.AutoCloseDuration = 2000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ToolTip.ClickToShowDisplayControl = false;
            this.ToolTip.ConvertNewlinesToBreakTags = true;
            this.ToolTip.DisplayControl = null;
            this.ToolTip.EntryAnimationSpeed = 350;
            this.ToolTip.ExitAnimationSpeed = 200;
            this.ToolTip.GenerateAutoCloseDuration = false;
            this.ToolTip.IconMargin = 6;
            this.ToolTip.InitialDelay = 1000;
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Opacity = 1D;
            this.ToolTip.OverrideToolTipTitles = false;
            this.ToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.ToolTip.ReshowDelay = 1000;
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ShowBorders = false;
            this.ToolTip.ShowIcons = true;
            this.ToolTip.ShowShadows = true;
            this.ToolTip.Tag = null;
            this.ToolTip.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.TextForeColor = System.Drawing.Color.Black;
            this.ToolTip.TextMargin = 2;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.ToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ToolTip.ToolTipTitle = null;
            // 
            // btnReload
            // 
            this.btnReload.AllowAnimations = true;
            this.btnReload.AllowMouseEffects = true;
            this.btnReload.AllowToggling = false;
            this.btnReload.AnimationSpeed = 200;
            this.btnReload.AutoGenerateColors = false;
            this.btnReload.AutoRoundBorders = false;
            this.btnReload.AutoSizeLeftIcon = true;
            this.btnReload.AutoSizeRightIcon = true;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.ButtonText = "";
            this.btnReload.ButtonTextMarginLeft = 0;
            this.btnReload.ColorContrastOnClick = 45;
            this.btnReload.ColorContrastOnHover = 45;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnReload.CustomizableEdges = borderEdges2;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnReload.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnReload.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.IconLeft = global::Password_Manager.Properties.Resources.Reload;
            this.btnReload.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload.IconLeftPadding = new System.Windows.Forms.Padding(8);
            this.btnReload.IconMarginLeft = 11;
            this.btnReload.IconPadding = 8;
            this.btnReload.IconRight = null;
            this.btnReload.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReload.IconSize = 25;
            this.btnReload.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnReload.IdleBorderRadius = 0;
            this.btnReload.IdleBorderThickness = 0;
            this.btnReload.IdleFillColor = System.Drawing.Color.Empty;
            this.btnReload.IdleIconLeftImage = global::Password_Manager.Properties.Resources.Reload;
            this.btnReload.IdleIconRightImage = null;
            this.btnReload.IndicateFocus = false;
            this.btnReload.Location = new System.Drawing.Point(564, 20);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.OnDisabledState.BorderRadius = 30;
            this.btnReload.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnDisabledState.BorderThickness = 1;
            this.btnReload.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload.OnDisabledState.IconLeftImage = null;
            this.btnReload.OnDisabledState.IconRightImage = null;
            this.btnReload.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReload.onHoverState.BorderRadius = 30;
            this.btnReload.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.onHoverState.BorderThickness = 1;
            this.btnReload.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReload.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload.onHoverState.IconLeftImage = null;
            this.btnReload.onHoverState.IconRightImage = null;
            this.btnReload.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReload.OnIdleState.BorderRadius = 30;
            this.btnReload.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnIdleState.BorderThickness = 1;
            this.btnReload.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReload.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnIdleState.IconLeftImage = global::Password_Manager.Properties.Resources.Reload;
            this.btnReload.OnIdleState.IconRightImage = null;
            this.btnReload.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReload.OnPressedState.BorderRadius = 30;
            this.btnReload.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnPressedState.BorderThickness = 1;
            this.btnReload.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReload.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnPressedState.IconLeftImage = null;
            this.btnReload.OnPressedState.IconRightImage = null;
            this.btnReload.Size = new System.Drawing.Size(50, 35);
            this.btnReload.TabIndex = 15;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.TextMarginLeft = 0;
            this.btnReload.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.btnReload, "");
            this.ToolTip.SetToolTipIcon(this.btnReload, null);
            this.ToolTip.SetToolTipTitle(this.btnReload, "");
            this.btnReload.UseDefaultRadiusAndThickness = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // NotesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Name = "NotesPanel";
            this.Size = new System.Drawing.Size(750, 760);
            this.ToolTip.SetToolTip(this, "");
            this.ToolTip.SetToolTipIcon(this, null);
            this.ToolTip.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.NotesPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNew;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNotes;
        private Bunifu.Framework.UI.BunifuElipse DGVRadius;
        private Bunifu.UI.WinForms.BunifuToolTip ToolTip;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
    }
}
