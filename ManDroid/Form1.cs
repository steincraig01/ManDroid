using RegawMOD.Android;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using DevExpress.XtraEditors;
using System.Linq;
using Events;
using DevExpress.XtraBars.Navigation;
using DevExpress.Utils.Svg;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Imaging;
using DevExpress.Utils.Drawing;
using System.Collections.Generic;

namespace ManDroid.ManDroid
{
    internal partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            //gridView1.CustomDrawCell += GridView1_CustomDrawCell;
        }

        private AndroidController android;
        private Device device;
        private BindingList<EventRecord> Eventlist = new BindingList<EventRecord>();
        Dictionary<AccordionControlElement, Image> accordianImages = new Dictionary<AccordionControlElement, Image>();

        private void ListComDevices()
        {
            ManagementObjectCollection managementObjectCollection;
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = null;

            using (var managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity "))
            {
                managementObjectCollection = managementObjectSearcher.Get();
            }

            try
            {
                foreach (var managementBaseObject in managementObjectCollection)
                {
                    if (managementBaseObject["Caption"] != null && managementBaseObject["DeviceID"].ToString().Contains("USB\\"))
                        listBoxControl1.Items.Add(managementBaseObject.GetPropertyValue("Caption"));
                    else if (managementBaseObject["Caption"] == null)
                        listBoxControl1.Items.Add("nope");
                }
            }
            finally
            {
                if (enumerator != null)
                    enumerator.Dispose();
            }

            managementObjectCollection.Dispose();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            android = AndroidController.Instance;
            lbEvents.DataSource = Eventlist;
        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            android.Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string serial;
            android.UpdateDeviceList();
            listBoxControl1.Items.Clear();
            labelControl1.Text = "-null-";

            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                labelControl1.Text = serial.ToString();

                foreach (var key in device.BuildProp.Keys)
                    listBoxControl1.Items.Add(key);
            }
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {

            //lbEvents.Templates.Assign(lbEvents.Templates[0].Assign());
            Eventlist.Add(new EventRecord(EventType.Error, "Startup", "Starting ADB Server...", EventListKind.Parent, svgImages.GetImage(15)));
            //ListComDevices();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            Eventlist.Add(new EventRecord(EventType.Info, "Startup", "Starting ADB Server...", EventListKind.Child, svgImages.GetImage(1)));
        }

        private void lbEvents_CustomItemTemplate(object sender, DevExpress.XtraEditors.CustomItemTemplateEventArgs e)
        {
            ListBoxControl lb = sender as ListBoxControl;
            if (lb.GetItemValue(e.Index) == EventListKind.Parent)
            {
                e.Template = e.Templates.Where(t => t.Name == "parenttemplate").First();

            }
            else
            {
                e.Template = e.Templates.Where(t => t.Name == "childtemplate").First();
            }
        }

        private void lbEvents_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            ListBoxControl lb = sender as ListBoxControl;
            if (lb.GetItemValue(e.Index) == EventListKind.Parent)
                e.ItemHeight = 45;
            else
                e.ItemHeight = 25;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string serial;
            android.UpdateDeviceList();
            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                lblModel.Text = device.BuildProp.GetProp("ro.product.model");
            }
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelControl3.Text = device.BuildProp.GetProp(listBoxControl1.SelectedItem.ToString());
        }


        private void accordionControl1_CustomDrawElement(object sender, DevExpress.XtraBars.Navigation.CustomDrawElementEventArgs e)
        {
            if (e.Element.Style == ElementStyle.Group)
            {
                e.Handled = true;
                int offset = -20;
                Rectangle imageRect = e.ObjectInfo.ImageBounds;
                imageRect.X += offset;
                //e.DrawHeaderBackground();
                //e.Graphics.DrawString(e.ObjectInfo.Element.Text, this.Font, Brushes.Black, textRect);

                //ColorMatrix matrix = ImageColorizer.GetColorMatrix(e.ObjectInfo.PaintAppearance.ForeColor, 255);
                //e.Cache.DrawImage(image, imageRect, 0, 0, 24,24, matrix);
                //e.DrawExpandCollapseButton();
                //e.DrawText();
                e.Cache.DrawImage(accordianImages[e.ObjectInfo.Element], imageRect);




            }
        }

        private void tbDevice_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = 0;
        }

        private void tbInfo_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = 1;
        }
    }
}

