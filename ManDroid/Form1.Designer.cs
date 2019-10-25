using System;
using Events;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement4 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase2 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition6 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition7 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition8 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition9 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement5 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement6 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan4 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.eventRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smallImages = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbEvents = new DevExpress.XtraEditors.ListBoxControl();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npConnection = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.npInformation = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
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
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbDevice = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbInfo = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbRepair = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbUnlock = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbTweaks = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbFlash = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.svgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.npConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.npInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).BeginInit();
            this.SuspendLayout();
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
            this.barStaticItem1,
            this.barLargeButtonItem1,
            this.barEditItem1});
            this.barManager1.MaxItemId = 3;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
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
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemProgressBar1;
            this.barEditItem1.EditWidth = 400;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Minimum = 50;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1049, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 739);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1049, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 719);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1049, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 719);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Id = 1;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // eventRecordBindingSource
            // 
            this.eventRecordBindingSource.DataSource = typeof(Events.EventRecord);
            // 
            // smallImages
            // 
            this.smallImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImages.ImageStream")));
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.CaptionImageOptions.AllowGlyphSkinning = true;
            this.groupControl1.CaptionImageOptions.Image = global::ManDroid.Properties.Resources.ic_list_black_24dp;
            this.groupControl1.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.groupControl1.Controls.Add(this.lbEvents);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(635, 120);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(414, 619);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Event Log";
            // 
            // lbEvents
            // 
            this.lbEvents.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbEvents.DataSource = this.eventRecordBindingSource;
            this.lbEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEvents.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbEvents.ItemHeight = 53;
            this.lbEvents.Location = new System.Drawing.Point(2, 37);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbEvents.ShowFocusRect = false;
            this.lbEvents.Size = new System.Drawing.Size(410, 580);
            this.lbEvents.TabIndex = 0;
            tableColumnDefinition1.Length.Value = 28D;
            tableColumnDefinition2.Length.Value = 13D;
            tableColumnDefinition3.Length.Value = 77D;
            tableColumnDefinition4.Length.Value = 258D;
            tableColumnDefinition5.Length.Value = 30D;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            itemTemplateBase1.Columns.Add(tableColumnDefinition3);
            itemTemplateBase1.Columns.Add(tableColumnDefinition4);
            itemTemplateBase1.Columns.Add(tableColumnDefinition5);
            templatedItemElement1.ColumnIndex = 2;
            templatedItemElement1.FieldName = "Time";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            templatedItemElement1.Text = "Time";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            templatedItemElement2.ColumnIndex = 3;
            templatedItemElement2.FieldName = "Operation";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "Operation";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            templatedItemElement3.FieldName = "Icon";
            templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement3.Text = "Icon";
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.TextVisible = false;
            templatedItemElement3.Width = 0;
            templatedItemElement4.ColumnIndex = 4;
            templatedItemElement4.FieldName = "Description";
            templatedItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement4.RowIndex = 1;
            templatedItemElement4.Text = "Description";
            templatedItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Elements.Add(templatedItemElement3);
            itemTemplateBase1.Elements.Add(templatedItemElement4);
            itemTemplateBase1.Name = "parenttemplate";
            tableRowDefinition1.Length.Value = 26D;
            tableRowDefinition2.Length.Value = 23D;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            tableSpan1.RowSpan = 2;
            tableSpan2.ColumnIndex = 2;
            tableSpan2.ColumnSpan = 3;
            tableSpan2.RowIndex = 1;
            tableSpan3.ColumnIndex = 3;
            tableSpan3.ColumnSpan = 2;
            itemTemplateBase1.Spans.Add(tableSpan1);
            itemTemplateBase1.Spans.Add(tableSpan2);
            itemTemplateBase1.Spans.Add(tableSpan3);
            tableColumnDefinition6.Length.Value = 28D;
            tableColumnDefinition7.Length.Value = 51D;
            tableColumnDefinition8.Length.Value = 562D;
            tableColumnDefinition9.Length.Value = 47D;
            itemTemplateBase2.Columns.Add(tableColumnDefinition6);
            itemTemplateBase2.Columns.Add(tableColumnDefinition7);
            itemTemplateBase2.Columns.Add(tableColumnDefinition8);
            itemTemplateBase2.Columns.Add(tableColumnDefinition9);
            templatedItemElement5.ColumnIndex = 1;
            templatedItemElement5.FieldName = "Icon";
            templatedItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement5.Text = "Icon";
            templatedItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement5.TextVisible = false;
            templatedItemElement5.Width = 0;
            templatedItemElement6.ColumnIndex = 2;
            templatedItemElement6.FieldName = "Description";
            templatedItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement6.Text = "Description";
            templatedItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            itemTemplateBase2.Elements.Add(templatedItemElement5);
            itemTemplateBase2.Elements.Add(templatedItemElement6);
            itemTemplateBase2.Name = "childtemplate";
            tableRowDefinition3.Length.Value = 24D;
            itemTemplateBase2.Rows.Add(tableRowDefinition3);
            tableSpan4.RowSpan = 2;
            itemTemplateBase2.Spans.Add(tableSpan4);
            this.lbEvents.Templates.Add(itemTemplateBase1);
            this.lbEvents.Templates.Add(itemTemplateBase2);
            this.lbEvents.ValueMember = "EventListKind";
            this.lbEvents.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbEvents_MeasureItem);
            this.lbEvents.CustomItemTemplate += new DevExpress.XtraEditors.CustomItemTemplateEventHandler(this.lbEvents_CustomItemTemplate);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.npConnection);
            this.navigationFrame1.Controls.Add(this.npInformation);
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
            this.navigationFrame1.Location = new System.Drawing.Point(0, 120);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npConnection,
            this.npInformation,
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
            this.navigationFrame1.SelectedPage = this.npConnection;
            this.navigationFrame1.Size = new System.Drawing.Size(635, 619);
            this.navigationFrame1.TabIndex = 23;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.TransitionAnimationProperties.FrameCount = 300;
            this.navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.PushFade;
            // 
            // npConnection
            // 
            this.npConnection.Controls.Add(this.groupControl2);
            this.npConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npConnection.Name = "npConnection";
            this.npConnection.Size = new System.Drawing.Size(635, 619);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(-5, 3, 3, 3);
            this.groupControl2.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(635, 619);
            this.groupControl2.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.labelControl5);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.lblModel);
            this.groupControl4.Controls.Add(this.pictureEdit1);
            this.groupControl4.Controls.Add(this.btnScan);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.simpleButton3);
            this.groupControl4.Controls.Add(this.pictureEdit2);
            this.groupControl4.Controls.Add(this.simpleButton2);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Controls.Add(this.listBoxControl1);
            this.groupControl4.Controls.Add(this.simpleButton1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(631, 615);
            this.groupControl4.TabIndex = 16;
            this.groupControl4.Text = "Connected Device";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(162, 195);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(108, 17);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Baseband Version:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(162, 171);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 17);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Android Version:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(162, 147);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 17);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Build Number:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(162, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 17);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Name:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(162, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 17);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Brand:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(162, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 17);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Model:";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(225, 99);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(78, 17);
            this.lblModel.TabIndex = 21;
            this.lblModel.Text = "labelControl4";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::ManDroid.Properties.Resources.giphy1;
            this.pictureEdit1.Location = new System.Drawing.Point(552, 431);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(58, 78);
            this.pictureEdit1.TabIndex = 22;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(470, 246);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(140, 33);
            this.btnScan.TabIndex = 20;
            this.btnScan.Text = "Scan for devices";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 538);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 17);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "labelControl3";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(475, 346);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 29);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::ManDroid.Properties.Resources.mobile_phone_popular_model_samsung_galaxy_note_svgrepo_com;
            this.pictureEdit2.Location = new System.Drawing.Point(10, 58);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit2.MenuManager = this.barManager1;
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(175, 174);
            this.pictureEdit2.TabIndex = 17;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(475, 381);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(87, 30);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(446, 538);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "labelControl1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(39, 385);
            this.listBoxControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(408, 122);
            this.listBoxControl1.TabIndex = 14;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(241, 515);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 30);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // npInformation
            // 
            this.npInformation.Controls.Add(this.groupControl3);
            this.npInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npInformation.Name = "npInformation";
            this.npInformation.Size = new System.Drawing.Size(635, 619);
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(635, 619);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "groupControl3";
            // 
            // navigationPage3
            // 
            this.navigationPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage5
            // 
            this.navigationPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage6
            // 
            this.navigationPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage7
            // 
            this.navigationPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage8
            // 
            this.navigationPage8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage9
            // 
            this.navigationPage9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage9.Name = "navigationPage9";
            this.navigationPage9.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage10
            // 
            this.navigationPage10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage10.Name = "navigationPage10";
            this.navigationPage10.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage11
            // 
            this.navigationPage11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage11.Name = "navigationPage11";
            this.navigationPage11.Size = new System.Drawing.Size(635, 619);
            // 
            // navigationPage12
            // 
            this.navigationPage12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPage12.Name = "navigationPage12";
            this.navigationPage12.Size = new System.Drawing.Size(635, 619);
            // 
            // tileBar1
            // 
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar1.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileBar1.ItemSize = 70;
            this.tileBar1.Location = new System.Drawing.Point(0, 20);
            this.tileBar1.MaxId = 11;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.SelectedItem = this.tbDevice;
            this.tileBar1.SelectionBorderWidth = 3;
            this.tileBar1.SelectionColor = System.Drawing.Color.DodgerBlue;
            this.tileBar1.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar1.ShowGroupText = false;
            this.tileBar1.Size = new System.Drawing.Size(1049, 100);
            this.tileBar1.TabIndex = 28;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.WideTileWidth = 160;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tbDevice);
            this.tileBarGroup2.Items.Add(this.tbInfo);
            this.tileBarGroup2.Items.Add(this.tbRepair);
            this.tileBarGroup2.Items.Add(this.tbUnlock);
            this.tileBarGroup2.Items.Add(this.tbTweaks);
            this.tileBarGroup2.Items.Add(this.tbFlash);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tbDevice
            // 
            this.tbDevice.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.device3;
            tileItemElement1.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement1.Text = "Device";
            this.tbDevice.Elements.Add(tileItemElement1);
            this.tbDevice.Id = 4;
            this.tbDevice.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbDevice.Name = "tbDevice";
            this.tbDevice.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbDevice_ItemClick);
            // 
            // tbInfo
            // 
            this.tbInfo.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.device_info3;
            tileItemElement2.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement2.Text = "Info";
            this.tbInfo.Elements.Add(tileItemElement2);
            this.tbInfo.Id = 5;
            this.tbInfo.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbInfo_ItemClick);
            // 
            // tbRepair
            // 
            this.tbRepair.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.repair;
            tileItemElement3.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement3.Text = "Repair";
            this.tbRepair.Elements.Add(tileItemElement3);
            this.tbRepair.Id = 6;
            this.tbRepair.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbRepair.Name = "tbRepair";
            // 
            // tbUnlock
            // 
            this.tbUnlock.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.unlock;
            tileItemElement4.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement4.Text = "Unlock";
            this.tbUnlock.Elements.Add(tileItemElement4);
            this.tbUnlock.Id = 7;
            this.tbUnlock.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbUnlock.Name = "tbUnlock";
            // 
            // tbTweaks
            // 
            this.tbTweaks.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.tweaks;
            tileItemElement5.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement5.Text = "Tweaks";
            this.tbTweaks.Elements.Add(tileItemElement5);
            this.tbTweaks.Id = 8;
            this.tbTweaks.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbTweaks.Name = "tbTweaks";
            // 
            // tbFlash
            // 
            this.tbFlash.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.ImageOptions.SvgImage = global::ManDroid.Properties.Resources.flash;
            tileItemElement6.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement6.Text = "Flash";
            this.tbFlash.Elements.Add(tileItemElement6);
            this.tbFlash.Id = 10;
            this.tbFlash.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbFlash.Name = "tbFlash";
            // 
            // svgImages
            // 
            this.svgImages.ImageSize = new System.Drawing.Size(48, 48);
            this.svgImages.Add("alert_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.alert_red"))));
            this.svgImages.Add("alert_yellow", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.alert_yellow"))));
            this.svgImages.Add("android_adb", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.android_adb"))));
            this.svgImages.Add("android_com", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.android_com"))));
            this.svgImages.Add("android_green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.android_green"))));
            this.svgImages.Add("arrow_black", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.arrow_black"))));
            this.svgImages.Add("device", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.device"))));
            this.svgImages.Add("device_info", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.device_info"))));
            this.svgImages.Add("download_blue", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.download_blue"))));
            this.svgImages.Add("error_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.error_red"))));
            this.svgImages.Add("error_red_light", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.error_red_light"))));
            this.svgImages.Add("flash", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.flash"))));
            this.svgImages.Add("gear_blue", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.gear_blue"))));
            this.svgImages.Add("Icon_green_light", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Icon_green_light"))));
            this.svgImages.Add("info_blue", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.info_blue"))));
            this.svgImages.Add("info_blue_light", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.info_blue_light"))));
            this.svgImages.Add("info_green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.info_green"))));
            this.svgImages.Add("info_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.info_red"))));
            this.svgImages.Add("locked_green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.locked_green"))));
            this.svgImages.Add("locked_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.locked_red"))));
            this.svgImages.Add("phone_blue", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.phone_blue"))));
            this.svgImages.Add("phone_green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.phone_green"))));
            this.svgImages.Add("phone_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.phone_red"))));
            this.svgImages.Add("power_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.power_red"))));
            this.svgImages.Add("refresh", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.refresh"))));
            this.svgImages.Add("repair", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.repair"))));
            this.svgImages.Add("screenlock_red", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.screenlock_red"))));
            this.svgImages.Add("tick_green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.tick_green"))));
            this.svgImages.Add("tweaks", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.tweaks"))));
            this.svgImages.Add("unlock", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.unlock"))));
            this.svgImages.Add("upload_blue", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.upload_blue"))));
            this.svgImages.Add("usb_blue", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.usb_blue"))));
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(191, 261);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 17);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "labelControl9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 770);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.EnableAcrylicAccent = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ManDroid Toolbox v0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.npConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.npInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.Utils.ImageCollection smallImages;
        private System.Windows.Forms.BindingSource eventRecordBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbEvents;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage npConnection;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.Navigation.NavigationPage npInformation;
        private DevExpress.XtraEditors.GroupControl groupControl3;
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
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.Navigation.TileBarItem tbDevice;
        private DevExpress.XtraBars.Navigation.TileBarItem tbInfo;
        private DevExpress.XtraBars.Navigation.TileBarItem tbRepair;
        private DevExpress.XtraBars.Navigation.TileBarItem tbUnlock;
        private DevExpress.XtraBars.Navigation.TileBarItem tbTweaks;
        private DevExpress.XtraBars.Navigation.TileBarItem tbFlash;
        private DevExpress.Utils.SvgImageCollection svgImages;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}

