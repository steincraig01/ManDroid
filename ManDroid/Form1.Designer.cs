using System;

namespace ManDroid.ManDroid
{
    internal partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage6 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage7 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage8 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage9 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage10 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage11 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage12 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.eventRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.smallImages = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowGlyphSkinning = true;
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.BackColor = System.Drawing.Color.Transparent;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileBar1.ItemSize = 40;
            this.tileBar1.Location = new System.Drawing.Point(0, 20);
            this.tileBar1.MaxId = 8;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.SelectedItem = this.tileBarItem1;
            this.tileBar1.SelectionBorderWidth = 2;
            this.tileBar1.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar1.ShowGroupText = false;
            this.tileBar1.Size = new System.Drawing.Size(831, 62);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.WideTileWidth = 140;
            this.tileBar1.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileBar1_SelectedItemChanged);
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Items.Add(this.tileBarItem2);
            this.tileBarGroup2.Items.Add(this.tileBarItem3);
            this.tileBarGroup2.Items.Add(this.tileBarItem4);
            this.tileBarGroup2.Items.Add(this.tileBarItem5);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileBarItem1.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.electronics_tabletmac;
            tileItemElement1.Text = "Connection";
            this.tileBarItem1.Elements.Add(tileItemElement1);
            this.tileBarItem1.Id = 0;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.actions_info;
            tileItemElement2.Text = "Information";
            this.tileBarItem2.Elements.Add(tileItemElement2);
            this.tileBarItem2.Id = 1;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "tileBarItem3";
            this.tileBarItem3.Elements.Add(tileItemElement3);
            this.tileBarItem3.Id = 2;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "tileBarItem4";
            this.tileBarItem4.Elements.Add(tileItemElement4);
            this.tileBarItem4.Id = 3;
            this.tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem4.Name = "tileBarItem4";
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "tileBarItem5";
            this.tileBarItem5.Elements.Add(tileItemElement5);
            this.tileBarItem5.Id = 4;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem5.Name = "tileBarItem5";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Controls.Add(this.navigationPage3);
            this.navigationFrame1.Controls.Add(this.navigationPage4);
            this.navigationFrame1.Controls.Add(this.navigationPage5);
            this.navigationFrame1.Controls.Add(this.navigationPage6);
            this.navigationFrame1.Controls.Add(this.navigationPage7);
            this.navigationFrame1.Controls.Add(this.navigationPage8);
            this.navigationFrame1.Controls.Add(this.navigationPage9);
            this.navigationFrame1.Controls.Add(this.navigationPage10);
            this.navigationFrame1.Controls.Add(this.navigationPage11);
            this.navigationFrame1.Controls.Add(this.navigationPage12);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 82);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5,
            this.navigationPage6,
            this.navigationPage7,
            this.navigationPage8,
            this.navigationPage9,
            this.navigationPage10,
            this.navigationPage11,
            this.navigationPage12});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(831, 350);
            this.navigationFrame1.TabIndex = 8;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.TransitionAnimationProperties.FrameCount = 300;
            this.navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.PushFade;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.groupControl2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(831, 350);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(-5, 3, 3, 3);
            this.groupControl2.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.Controls.Add(this.xtraScrollableControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(831, 350);
            this.groupControl2.TabIndex = 0;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.labelControl2);
            this.xtraScrollableControl2.Controls.Add(this.simpleButton2);
            this.xtraScrollableControl2.Controls.Add(this.labelControl1);
            this.xtraScrollableControl2.Controls.Add(this.listBoxControl1);
            this.xtraScrollableControl2.Controls.Add(this.simpleButton1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(827, 346);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(202, 35);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Device Connection";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(742, 294);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(721, 153);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "labelControl1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(441, 52);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(350, 95);
            this.listBoxControl1.TabIndex = 1;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(441, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(102, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.groupControl3);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(831, 350);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.xtraScrollableControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(831, 350);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "groupControl3";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2, 27);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(827, 321);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // navigationPage3
            // 
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage5
            // 
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage6
            // 
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage7
            // 
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage8
            // 
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage9
            // 
            this.navigationPage9.Name = "navigationPage9";
            this.navigationPage9.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage10
            // 
            this.navigationPage10.Name = "navigationPage10";
            this.navigationPage10.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage11
            // 
            this.navigationPage11.Name = "navigationPage11";
            this.navigationPage11.Size = new System.Drawing.Size(831, 350);
            // 
            // navigationPage12
            // 
            this.navigationPage12.Name = "navigationPage12";
            this.navigationPage12.Size = new System.Drawing.Size(831, 350);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(75, 103);
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(831, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 597);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(831, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 577);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(831, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 577);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(-5, 0, 3, 0);
            this.groupControl1.CaptionImageOptions.SvgImage = global::ManDroid.Properties.Resources.agendaview;
            this.groupControl1.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(0, 432);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(831, 165);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Event Log";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.eventRecordBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(827, 136);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eventRecordBindingSource
            // 
            this.eventRecordBindingSource.DataSource = typeof(ManDroid.EventRecord);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colType,
            this.colTime,
            this.colOperation,
            this.colDescription});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PaintStyleName = "Skin";
            this.gridView1.RowHeight = 16;
            // 
            // colType
            // 
            this.colType.Caption = "-";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.OptionsColumn.AllowFocus = false;
            this.colType.OptionsColumn.AllowMove = false;
            this.colType.OptionsColumn.FixedWidth = true;
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 0;
            this.colType.Width = 25;
            // 
            // colTime
            // 
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.OptionsColumn.AllowEdit = false;
            this.colTime.OptionsColumn.FixedWidth = true;
            this.colTime.OptionsColumn.ReadOnly = true;
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 1;
            // 
            // colOperation
            // 
            this.colOperation.FieldName = "Operation";
            this.colOperation.Name = "colOperation";
            this.colOperation.OptionsColumn.AllowEdit = false;
            this.colOperation.OptionsColumn.FixedWidth = true;
            this.colOperation.OptionsColumn.ReadOnly = true;
            this.colOperation.Visible = true;
            this.colOperation.VisibleIndex = 2;
            this.colOperation.Width = 128;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.FixedWidth = true;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 536;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // smallImages
            // 
            this.smallImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImages.ImageStream")));
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.info_16x161, "Info", typeof(global::ManDroid.Properties.Resources), 0, "info_16x161");
            this.smallImages.Images.SetKeyName(0, "Info");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.close_16x16, "Error", typeof(global::ManDroid.Properties.Resources), 1, "close_16x16");
            this.smallImages.Images.SetKeyName(1, "Error");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.iconsetsymbols3_16x16, "Complete", typeof(global::ManDroid.Properties.Resources), 2, "iconsetsymbols3_16x16");
            this.smallImages.Images.SetKeyName(2, "Complete");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.warning_16x16, "Warning", typeof(global::ManDroid.Properties.Resources), 3, "warning_16x16");
            this.smallImages.Images.SetKeyName(3, "Warning");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.iconsetsigns3_16x16, "Success", typeof(global::ManDroid.Properties.Resources), 4, "iconsetsigns3_16x16");
            this.smallImages.Images.SetKeyName(4, "Success");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.iconsetredtoblack4_16x16, "Fail", typeof(global::ManDroid.Properties.Resources), 5, "iconsetredtoblack4_16x16");
            this.smallImages.Images.SetKeyName(5, "Fail");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.properties_16x16, "System", typeof(global::ManDroid.Properties.Resources), 6, "properties_16x16");
            this.smallImages.Images.SetKeyName(6, "System");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.about_16x16, "about_16x16", typeof(global::ManDroid.Properties.Resources), 7);
            this.smallImages.Images.SetKeyName(7, "about_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.phone_16x16, "Device", typeof(global::ManDroid.Properties.Resources), 8, "phone_16x16");
            this.smallImages.Images.SetKeyName(8, "Device");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.add_16x16, "add_16x16", typeof(global::ManDroid.Properties.Resources), 9);
            this.smallImages.Images.SetKeyName(9, "add_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.apply_16x16, "apply_16x16", typeof(global::ManDroid.Properties.Resources), 10);
            this.smallImages.Images.SetKeyName(10, "apply_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.cancel_16x16, "cancel_16x16", typeof(global::ManDroid.Properties.Resources), 11);
            this.smallImages.Images.SetKeyName(11, "cancel_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.changeview_16x16, "changeview_16x16", typeof(global::ManDroid.Properties.Resources), 12);
            this.smallImages.Images.SetKeyName(12, "changeview_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.ide_16x16, "ide_16x16", typeof(global::ManDroid.Properties.Resources), 13);
            this.smallImages.Images.SetKeyName(13, "ide_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.removepivotfield_16x16, "removepivotfield_16x16", typeof(global::ManDroid.Properties.Resources), 14);
            this.smallImages.Images.SetKeyName(14, "removepivotfield_16x16");
            this.smallImages.InsertImage(global::ManDroid.Properties.Resources.error_16x16, "Error2", typeof(global::ManDroid.Properties.Resources), 15, "error_16x16");
            this.smallImages.Images.SetKeyName(15, "Error2");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 621);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "ManDroid Toolbox v0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem4;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem5;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage6;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage7;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage8;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage9;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage10;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage11;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage12;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.ImageCollection smallImages;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource eventRecordBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn colOperation;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

