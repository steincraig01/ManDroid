Imports System

Namespace ManDroid
    Partial Friend Class Form1
        Private components As ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            components = New ComponentModel.Container
            Dim tileItemElement1 = New DevExpress.XtraEditors.TileItemElement
            Dim tileItemElement2 = New DevExpress.XtraEditors.TileItemElement
            Dim tileItemElement3 = New DevExpress.XtraEditors.TileItemElement
            Dim tileItemElement4 = New DevExpress.XtraEditors.TileItemElement
            Dim tileItemElement5 = New DevExpress.XtraEditors.TileItemElement
            Dim resources = New ComponentModel.ComponentResourceManager(GetType(Form1))
            tileBar1 = New DevExpress.XtraBars.Navigation.TileBar
            tileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup
            tileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem
            tileBarItem2 = New DevExpress.XtraBars.Navigation.TileBarItem
            tileBarItem3 = New DevExpress.XtraBars.Navigation.TileBarItem
            tileBarItem4 = New DevExpress.XtraBars.Navigation.TileBarItem
            tileBarItem5 = New DevExpress.XtraBars.Navigation.TileBarItem
            navigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame
            navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage
            groupControl2 = New DevExpress.XtraEditors.GroupControl
            xtraScrollableControl2 = New DevExpress.XtraEditors.XtraScrollableControl
            labelControl2 = New DevExpress.XtraEditors.LabelControl
            simpleButton2 = New DevExpress.XtraEditors.SimpleButton
            labelControl1 = New DevExpress.XtraEditors.LabelControl
            listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl
            simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            navigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage
            groupControl3 = New DevExpress.XtraEditors.GroupControl
            xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl
            navigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage5 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage6 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage7 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage8 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage9 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage10 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage11 = New DevExpress.XtraBars.Navigation.NavigationPage
            navigationPage12 = New DevExpress.XtraBars.Navigation.NavigationPage
            barManager1 = New DevExpress.XtraBars.BarManager(components)
            bar1 = New DevExpress.XtraBars.Bar
            bar3 = New DevExpress.XtraBars.Bar
            barStaticItem1 = New DevExpress.XtraBars.BarStaticItem
            barDockControlTop = New DevExpress.XtraBars.BarDockControl
            barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            barDockControlRight = New DevExpress.XtraBars.BarDockControl
            groupControl1 = New DevExpress.XtraEditors.GroupControl
            gridControl1 = New DevExpress.XtraGrid.GridControl
            eventRecordBindingSource = New Windows.Forms.BindingSource(components)
            gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            colType = New DevExpress.XtraGrid.Columns.GridColumn
            colTime = New DevExpress.XtraGrid.Columns.GridColumn
            colOperation = New DevExpress.XtraGrid.Columns.GridColumn
            colDescription = New DevExpress.XtraGrid.Columns.GridColumn
            repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            smallImages = New DevExpress.Utils.ImageCollection(components)
            CType(navigationFrame1, ComponentModel.ISupportInitialize).BeginInit()
            navigationFrame1.SuspendLayout()
            navigationPage1.SuspendLayout()
            CType(groupControl2, ComponentModel.ISupportInitialize).BeginInit()
            groupControl2.SuspendLayout()
            xtraScrollableControl2.SuspendLayout()
            CType(listBoxControl1, ComponentModel.ISupportInitialize).BeginInit()
            navigationPage2.SuspendLayout()
            CType(groupControl3, ComponentModel.ISupportInitialize).BeginInit()
            groupControl3.SuspendLayout()
            CType(barManager1, ComponentModel.ISupportInitialize).BeginInit()
            CType(groupControl1, ComponentModel.ISupportInitialize).BeginInit()
            groupControl1.SuspendLayout()
            CType(gridControl1, ComponentModel.ISupportInitialize).BeginInit()
            CType(eventRecordBindingSource, ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemImageComboBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(smallImages, ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            tileBar1.AllowGlyphSkinning = True
            tileBar1.AllowSelectedItem = True
            tileBar1.BackColor = Drawing.Color.Transparent
            tileBar1.Dock = Windows.Forms.DockStyle.Top
            tileBar1.DropDownOptions.BeakColor = Drawing.Color.Empty
            tileBar1.Groups.Add(tileBarGroup2)
            tileBar1.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileBar1.ItemSize = 40
            tileBar1.Location = New Drawing.Point(0, 20)
            tileBar1.MaxId = 8
            tileBar1.Name = "tileBar1"
            tileBar1.Padding = New Windows.Forms.Padding(10, 0, 10, 0)
            tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
            tileBar1.SelectedItem = tileBarItem1
            tileBar1.SelectionBorderWidth = 2
            tileBar1.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor
            tileBar1.ShowGroupText = False
            tileBar1.Size = New Drawing.Size(831, 62)
            tileBar1.TabIndex = 0
            tileBar1.WideTileWidth = 140
            AddHandler tileBar1.SelectedItemChanged, New DevExpress.XtraEditors.TileItemClickEventHandler(AddressOf Me.tileBar1_SelectedItemChanged)
            tileBarGroup2.Items.Add(tileBarItem1)
            tileBarGroup2.Items.Add(tileBarItem2)
            tileBarGroup2.Items.Add(tileBarItem3)
            tileBarGroup2.Items.Add(tileBarItem4)
            tileBarGroup2.Items.Add(tileBarItem5)
            tileBarGroup2.Name = "tileBarGroup2"
            tileBarItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            tileBarItem1.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileBarItem1.DropDownOptions.BeakColor = Drawing.Color.Empty
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            tileItemElement1.ImageOptions.SvgImage = Global.ManDroid.Properties.Resources.electronics_tabletmac
            tileItemElement1.Text = "Connection"
            tileBarItem1.Elements.Add(tileItemElement1)
            tileBarItem1.Id = 0
            tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
            tileBarItem1.Name = "tileBarItem1"
            tileBarItem2.DropDownOptions.BeakColor = Drawing.Color.Empty
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            tileItemElement2.ImageOptions.SvgImage = Global.ManDroid.Properties.Resources.actions_info
            tileItemElement2.Text = "Information"
            tileBarItem2.Elements.Add(tileItemElement2)
            tileBarItem2.Id = 1
            tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
            tileBarItem2.Name = "tileBarItem2"
            tileBarItem3.DropDownOptions.BeakColor = Drawing.Color.Empty
            tileItemElement3.Text = "tileBarItem3"
            tileBarItem3.Elements.Add(tileItemElement3)
            tileBarItem3.Id = 2
            tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
            tileBarItem3.Name = "tileBarItem3"
            tileBarItem4.DropDownOptions.BeakColor = Drawing.Color.Empty
            tileItemElement4.Text = "tileBarItem4"
            tileBarItem4.Elements.Add(tileItemElement4)
            tileBarItem4.Id = 3
            tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
            tileBarItem4.Name = "tileBarItem4"
            tileBarItem5.DropDownOptions.BeakColor = Drawing.Color.Empty
            tileItemElement5.Text = "tileBarItem5"
            tileBarItem5.Elements.Add(tileItemElement5)
            tileBarItem5.Id = 4
            tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
            tileBarItem5.Name = "tileBarItem5"
            navigationFrame1.Controls.Add(navigationPage1)
            navigationFrame1.Controls.Add(navigationPage2)
            navigationFrame1.Controls.Add(navigationPage3)
            navigationFrame1.Controls.Add(navigationPage4)
            navigationFrame1.Controls.Add(navigationPage5)
            navigationFrame1.Controls.Add(navigationPage6)
            navigationFrame1.Controls.Add(navigationPage7)
            navigationFrame1.Controls.Add(navigationPage8)
            navigationFrame1.Controls.Add(navigationPage9)
            navigationFrame1.Controls.Add(navigationPage10)
            navigationFrame1.Controls.Add(navigationPage11)
            navigationFrame1.Controls.Add(navigationPage12)
            navigationFrame1.Dock = Windows.Forms.DockStyle.Fill
            navigationFrame1.Location = New Drawing.Point(0, 82)
            navigationFrame1.Name = "navigationFrame1"
            navigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {navigationPage1, navigationPage2, navigationPage3, navigationPage4, navigationPage5, navigationPage6, navigationPage7, navigationPage8, navigationPage9, navigationPage10, navigationPage11, navigationPage12})
            navigationFrame1.SelectedPage = navigationPage1
            navigationFrame1.Size = New Drawing.Size(831, 350)
            navigationFrame1.TabIndex = 8
            navigationFrame1.Text = "navigationFrame1"
            navigationFrame1.TransitionAnimationProperties.FrameCount = 300
            navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.PushFade
            navigationPage1.Controls.Add(groupControl2)
            navigationPage1.Name = "navigationPage1"
            navigationPage1.Size = New Drawing.Size(831, 350)
            groupControl2.CaptionImageOptions.Padding = New Windows.Forms.Padding(-5, 3, 3, 3)
            groupControl2.CaptionImageOptions.SvgImage = Global.ManDroid.Properties.Resources.electronics_tabletmac
            groupControl2.CaptionImageOptions.SvgImageSize = New Drawing.Size(16, 16)
            groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top
            groupControl2.Controls.Add(xtraScrollableControl2)
            groupControl2.Dock = Windows.Forms.DockStyle.Fill
            groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card
            groupControl2.Location = New Drawing.Point(0, 0)
            groupControl2.Name = "groupControl2"
            groupControl2.Size = New Drawing.Size(831, 350)
            groupControl2.TabIndex = 0
            groupControl2.Text = "Device Connection"
            xtraScrollableControl2.Controls.Add(labelControl2)
            xtraScrollableControl2.Controls.Add(simpleButton2)
            xtraScrollableControl2.Controls.Add(labelControl1)
            xtraScrollableControl2.Controls.Add(listBoxControl1)
            xtraScrollableControl2.Controls.Add(simpleButton1)
            xtraScrollableControl2.Dock = Windows.Forms.DockStyle.Fill
            xtraScrollableControl2.Location = New Drawing.Point(2, 27)
            xtraScrollableControl2.Name = "xtraScrollableControl2"
            xtraScrollableControl2.Size = New Drawing.Size(827, 321)
            xtraScrollableControl2.TabIndex = 0
            labelControl2.Appearance.Font = New Drawing.Font("Segoe UI", 18.0F)
            labelControl2.Appearance.Options.UseFont = True
            labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            labelControl2.LineVisible = True
            labelControl2.Location = New Drawing.Point(4, 4)
            labelControl2.Name = "labelControl2"
            labelControl2.Size = New Drawing.Size(202, 35)
            labelControl2.TabIndex = 4
            labelControl2.Text = "Device Connection"
            simpleButton2.Location = New Drawing.Point(742, 294)
            simpleButton2.Name = "simpleButton2"
            simpleButton2.Size = New Drawing.Size(75, 23)
            simpleButton2.TabIndex = 3
            simpleButton2.Text = "simpleButton2"
            AddHandler simpleButton2.Click, New EventHandler(AddressOf Me.simpleButton2_Click)
            labelControl1.Location = New Drawing.Point(721, 153)
            labelControl1.Name = "labelControl1"
            labelControl1.Size = New Drawing.Size(70, 13)
            labelControl1.TabIndex = 2
            labelControl1.Text = "labelControl1"
            listBoxControl1.Location = New Drawing.Point(441, 52)
            listBoxControl1.Name = "listBoxControl1"
            listBoxControl1.Size = New Drawing.Size(350, 95)
            listBoxControl1.TabIndex = 1
            AddHandler listBoxControl1.SelectedIndexChanged, New EventHandler(AddressOf Me.listBoxControl1_SelectedIndexChanged)
            simpleButton1.Location = New Drawing.Point(441, 23)
            simpleButton1.Name = "simpleButton1"
            simpleButton1.Size = New Drawing.Size(102, 23)
            simpleButton1.TabIndex = 0
            simpleButton1.Text = "simpleButton1"
            AddHandler simpleButton1.Click, New EventHandler(AddressOf Me.simpleButton1_Click)
            navigationPage2.Controls.Add(groupControl3)
            navigationPage2.Name = "navigationPage2"
            navigationPage2.Size = New Drawing.Size(831, 350)
            groupControl3.Controls.Add(xtraScrollableControl1)
            groupControl3.Dock = Windows.Forms.DockStyle.Fill
            groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Card
            groupControl3.Location = New Drawing.Point(0, 0)
            groupControl3.Name = "groupControl3"
            groupControl3.Size = New Drawing.Size(831, 350)
            groupControl3.TabIndex = 0
            groupControl3.Text = "groupControl3"
            xtraScrollableControl1.Dock = Windows.Forms.DockStyle.Fill
            xtraScrollableControl1.Location = New Drawing.Point(2, 27)
            xtraScrollableControl1.Name = "xtraScrollableControl1"
            xtraScrollableControl1.Size = New Drawing.Size(827, 321)
            xtraScrollableControl1.TabIndex = 0
            navigationPage3.Name = "navigationPage3"
            navigationPage3.Size = New Drawing.Size(831, 350)
            navigationPage4.Name = "navigationPage4"
            navigationPage4.Size = New Drawing.Size(831, 350)
            navigationPage5.Name = "navigationPage5"
            navigationPage5.Size = New Drawing.Size(831, 350)
            navigationPage6.Name = "navigationPage6"
            navigationPage6.Size = New Drawing.Size(831, 350)
            navigationPage7.Name = "navigationPage7"
            navigationPage7.Size = New Drawing.Size(831, 350)
            navigationPage8.Name = "navigationPage8"
            navigationPage8.Size = New Drawing.Size(831, 350)
            navigationPage9.Name = "navigationPage9"
            navigationPage9.Size = New Drawing.Size(831, 350)
            navigationPage10.Name = "navigationPage10"
            navigationPage10.Size = New Drawing.Size(831, 350)
            navigationPage11.Name = "navigationPage11"
            navigationPage11.Size = New Drawing.Size(831, 350)
            navigationPage12.Name = "navigationPage12"
            navigationPage12.Size = New Drawing.Size(831, 350)
            barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {bar1, bar3})
            barManager1.DockControls.Add(barDockControlTop)
            barManager1.DockControls.Add(barDockControlBottom)
            barManager1.DockControls.Add(barDockControlLeft)
            barManager1.DockControls.Add(barDockControlRight)
            barManager1.Form = Me
            barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {barStaticItem1})
            barManager1.MaxItemId = 1
            barManager1.StatusBar = bar3
            bar1.BarName = "Tools"
            bar1.DockCol = 0
            bar1.DockRow = 0
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            bar1.FloatLocation = New Drawing.Point(75, 103)
            bar1.Offset = 1
            bar1.Text = "Tools"
            bar1.Visible = False
            bar3.BarName = "Status bar"
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            bar3.DockCol = 0
            bar3.DockRow = 0
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(barStaticItem1)})
            bar3.OptionsBar.AllowQuickCustomization = False
            bar3.OptionsBar.DrawDragBorder = False
            bar3.OptionsBar.UseWholeRow = True
            bar3.Text = "Status bar"
            barStaticItem1.Caption = "barStaticItem1"
            barStaticItem1.Id = 0
            barStaticItem1.Name = "barStaticItem1"
            barDockControlTop.CausesValidation = False
            barDockControlTop.Dock = Windows.Forms.DockStyle.Top
            barDockControlTop.Location = New Drawing.Point(0, 0)
            barDockControlTop.Manager = barManager1
            barDockControlTop.Size = New Drawing.Size(831, 20)
            barDockControlBottom.CausesValidation = False
            barDockControlBottom.Dock = Windows.Forms.DockStyle.Bottom
            barDockControlBottom.Location = New Drawing.Point(0, 597)
            barDockControlBottom.Manager = barManager1
            barDockControlBottom.Size = New Drawing.Size(831, 24)
            barDockControlLeft.CausesValidation = False
            barDockControlLeft.Dock = Windows.Forms.DockStyle.Left
            barDockControlLeft.Location = New Drawing.Point(0, 20)
            barDockControlLeft.Manager = barManager1
            barDockControlLeft.Size = New Drawing.Size(0, 577)
            barDockControlRight.CausesValidation = False
            barDockControlRight.Dock = Windows.Forms.DockStyle.Right
            barDockControlRight.Location = New Drawing.Point(831, 20)
            barDockControlRight.Manager = barManager1
            barDockControlRight.Size = New Drawing.Size(0, 577)
            groupControl1.CaptionImageOptions.Padding = New Windows.Forms.Padding(-5, 0, 3, 0)
            groupControl1.CaptionImageOptions.SvgImage = Global.ManDroid.Properties.Resources.agendaview
            groupControl1.CaptionImageOptions.SvgImageSize = New Drawing.Size(16, 16)
            groupControl1.Controls.Add(gridControl1)
            groupControl1.Dock = Windows.Forms.DockStyle.Bottom
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card
            groupControl1.Location = New Drawing.Point(0, 432)
            groupControl1.Name = "groupControl1"
            groupControl1.Size = New Drawing.Size(831, 165)
            groupControl1.TabIndex = 14
            groupControl1.Text = "Event Log"
            gridControl1.DataSource = eventRecordBindingSource
            gridControl1.Dock = Windows.Forms.DockStyle.Fill
            gridControl1.Location = New Drawing.Point(2, 27)
            gridControl1.MainView = gridView1
            gridControl1.MenuManager = barManager1
            gridControl1.Name = "gridControl1"
            gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {repositoryItemImageComboBox1})
            gridControl1.Size = New Drawing.Size(827, 136)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            eventRecordBindingSource.DataSource = GetType(ManDroid.EventRecord)
            gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {colType, colTime, colOperation, colDescription})
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
            gridView1.OptionsBehavior.AutoSelectAllInEditor = False
            gridView1.OptionsBehavior.AutoUpdateTotalSummary = False
            gridView1.OptionsBehavior.Editable = False
            gridView1.OptionsBehavior.[ReadOnly] = True
            gridView1.OptionsCustomization.AllowFilter = False
            gridView1.OptionsCustomization.AllowGroup = False
            gridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
            gridView1.OptionsCustomization.AllowSort = False
            gridView1.OptionsNavigation.AutoFocusNewRow = True
            gridView1.OptionsSelection.UseIndicatorForSelection = False
            gridView1.OptionsView.ColumnAutoWidth = False
            gridView1.OptionsView.ShowGroupPanel = False
            gridView1.OptionsView.ShowIndicator = False
            gridView1.PaintStyleName = "Skin"
            gridView1.RowHeight = 16
            colType.Caption = "-"
            colType.FieldName = "Type"
            colType.Name = "colType"
            colType.OptionsColumn.AllowEdit = False
            colType.OptionsColumn.AllowFocus = False
            colType.OptionsColumn.AllowMove = False
            colType.OptionsColumn.FixedWidth = True
            colType.OptionsColumn.[ReadOnly] = True
            colType.Visible = True
            colType.VisibleIndex = 0
            colType.Width = 25
            colTime.FieldName = "Time"
            colTime.Name = "colTime"
            colTime.OptionsColumn.AllowEdit = False
            colTime.OptionsColumn.FixedWidth = True
            colTime.OptionsColumn.[ReadOnly] = True
            colTime.Visible = True
            colTime.VisibleIndex = 1
            colOperation.FieldName = "Operation"
            colOperation.Name = "colOperation"
            colOperation.OptionsColumn.AllowEdit = False
            colOperation.OptionsColumn.FixedWidth = True
            colOperation.OptionsColumn.[ReadOnly] = True
            colOperation.Visible = True
            colOperation.VisibleIndex = 2
            colOperation.Width = 128
            colDescription.FieldName = "Description"
            colDescription.Name = "colDescription"
            colDescription.OptionsColumn.AllowEdit = False
            colDescription.OptionsColumn.FixedWidth = True
            colDescription.OptionsColumn.[ReadOnly] = True
            colDescription.Visible = True
            colDescription.VisibleIndex = 3
            colDescription.Width = 536
            repositoryItemImageComboBox1.AutoHeight = False
            repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            smallImages.ImageStream = CType(resources.GetObject("smallImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.info_16x161, "Info", GetType(Global.ManDroid.Properties.Resources), 0, "info_16x161")
            smallImages.Images.SetKeyName(0, "Info")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.close_16x16, "Error", GetType(Global.ManDroid.Properties.Resources), 1, "close_16x16")
            smallImages.Images.SetKeyName(1, "Error")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.iconsetsymbols3_16x16, "Complete", GetType(Global.ManDroid.Properties.Resources), 2, "iconsetsymbols3_16x16")
            smallImages.Images.SetKeyName(2, "Complete")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.warning_16x16, "Warning", GetType(Global.ManDroid.Properties.Resources), 3, "warning_16x16")
            smallImages.Images.SetKeyName(3, "Warning")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.iconsetsigns3_16x16, "Success", GetType(Global.ManDroid.Properties.Resources), 4, "iconsetsigns3_16x16")
            smallImages.Images.SetKeyName(4, "Success")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.iconsetredtoblack4_16x16, "Fail", GetType(Global.ManDroid.Properties.Resources), 5, "iconsetredtoblack4_16x16")
            smallImages.Images.SetKeyName(5, "Fail")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.properties_16x16, "System", GetType(Global.ManDroid.Properties.Resources), 6, "properties_16x16")
            smallImages.Images.SetKeyName(6, "System")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.about_16x16, "about_16x16", GetType(Global.ManDroid.Properties.Resources), 7)
            smallImages.Images.SetKeyName(7, "about_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.phone_16x16, "Device", GetType(Global.ManDroid.Properties.Resources), 8, "phone_16x16")
            smallImages.Images.SetKeyName(8, "Device")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.add_16x16, "add_16x16", GetType(Global.ManDroid.Properties.Resources), 9)
            smallImages.Images.SetKeyName(9, "add_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.apply_16x16, "apply_16x16", GetType(Global.ManDroid.Properties.Resources), 10)
            smallImages.Images.SetKeyName(10, "apply_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.cancel_16x16, "cancel_16x16", GetType(Global.ManDroid.Properties.Resources), 11)
            smallImages.Images.SetKeyName(11, "cancel_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.changeview_16x16, "changeview_16x16", GetType(Global.ManDroid.Properties.Resources), 12)
            smallImages.Images.SetKeyName(12, "changeview_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.ide_16x16, "ide_16x16", GetType(Global.ManDroid.Properties.Resources), 13)
            smallImages.Images.SetKeyName(13, "ide_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.removepivotfield_16x16, "removepivotfield_16x16", GetType(Global.ManDroid.Properties.Resources), 14)
            smallImages.Images.SetKeyName(14, "removepivotfield_16x16")
            smallImages.InsertImage(Global.ManDroid.Properties.Resources.error_16x16, "Error2", GetType(Global.ManDroid.Properties.Resources), 15, "error_16x16")
            smallImages.Images.SetKeyName(15, "Error2")
            Me.AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New Drawing.Size(831, 621)
            Me.Controls.Add(navigationFrame1)
            Me.Controls.Add(groupControl1)
            Me.Controls.Add(tileBar1)
            Me.Controls.Add(barDockControlLeft)
            Me.Controls.Add(barDockControlRight)
            Me.Controls.Add(barDockControlBottom)
            Me.Controls.Add(barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "ManDroid Toolbox v0.1"
            AddHandler Me.FormClosed, New Windows.Forms.FormClosedEventHandler(AddressOf Me.Form1_FormClosed)
            AddHandler Me.Load, New EventHandler(AddressOf Me.Form1_Load)
            CType(navigationFrame1, ComponentModel.ISupportInitialize).EndInit()
            navigationFrame1.ResumeLayout(False)
            navigationPage1.ResumeLayout(False)
            CType(groupControl2, ComponentModel.ISupportInitialize).EndInit()
            groupControl2.ResumeLayout(False)
            xtraScrollableControl2.ResumeLayout(False)
            xtraScrollableControl2.PerformLayout()
            CType(listBoxControl1, ComponentModel.ISupportInitialize).EndInit()
            navigationPage2.ResumeLayout(False)
            CType(groupControl3, ComponentModel.ISupportInitialize).EndInit()
            groupControl3.ResumeLayout(False)
            CType(barManager1, ComponentModel.ISupportInitialize).EndInit()
            CType(groupControl1, ComponentModel.ISupportInitialize).EndInit()
            groupControl1.ResumeLayout(False)
            CType(gridControl1, ComponentModel.ISupportInitialize).EndInit()
            CType(eventRecordBindingSource, ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemImageComboBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(smallImages, ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private tileBar1 As DevExpress.XtraBars.Navigation.TileBar
        Private tileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
        Private tileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
        Private tileBarItem2 As DevExpress.XtraBars.Navigation.TileBarItem
        Private tileBarItem3 As DevExpress.XtraBars.Navigation.TileBarItem
        Private tileBarItem4 As DevExpress.XtraBars.Navigation.TileBarItem
        Private tileBarItem5 As DevExpress.XtraBars.Navigation.TileBarItem
        Private navigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
        Private groupControl2 As DevExpress.XtraEditors.GroupControl
        Private xtraScrollableControl2 As DevExpress.XtraEditors.XtraScrollableControl
        Private navigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
        Private groupControl3 As DevExpress.XtraEditors.GroupControl
        Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
        Private navigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage5 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage6 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage7 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage8 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage9 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage10 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage11 As DevExpress.XtraBars.Navigation.NavigationPage
        Private navigationPage12 As DevExpress.XtraBars.Navigation.NavigationPage
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
        Private groupControl1 As DevExpress.XtraEditors.GroupControl
        Private smallImages As DevExpress.Utils.ImageCollection
        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private eventRecordBindingSource As Windows.Forms.BindingSource
        Private colTime As DevExpress.XtraGrid.Columns.GridColumn
        Private colOperation As DevExpress.XtraGrid.Columns.GridColumn
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private colType As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
