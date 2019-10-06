using RegawMOD.Android;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;

namespace ManDroid.ManDroid
{
    internal partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            gridView1.CustomDrawCell += GridView1_CustomDrawCell;
        }

        private AndroidController android;
        private Device device;
        private BindingList<EventRecord> Eventlist = new BindingList<EventRecord>();

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

        public class GridCell
        {
            public int RowHandle { get; set; }
            public string FieldName { get; set; }
            public Image Image { get; set; }
        }

        private void GridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Type")
            {
                switch (e.CellValue)
                {
                    case "Info":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[0], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "Error":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[1], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "Complete":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[2], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "Warning":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[3], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "Success":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[4], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "Fail":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[5], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "System":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[6], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }

                    case "Device":
                        {
                            e.DisplayText = string.Empty;
                            e.Graphics.DrawImage(smallImages.Images[7], new Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16));
                            e.Handled = true;
                            break;
                        }
                }
            }
        }

        private void TileBar1_SelectedItemChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = tileBarGroup2.Items.IndexOf(e.Item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            android = AndroidController.Instance;
            gridControl1.DataSource = Eventlist;
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

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Eventlist.Add(new EventRecord(EventType.Error, "Startup", "Starting ADB Server..."));
            ListComDevices();
        }
    }
}

