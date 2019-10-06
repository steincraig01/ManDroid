Imports RegawMOD.Android
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Management

Namespace ManDroid
    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent
            AddHandler gridView1.CustomDrawCell, AddressOf GridView1_CustomDrawCell
        End Sub

        Private android As AndroidController
        Private device As Device
        Private Eventlist As BindingList(Of EventRecord) = New BindingList(Of EventRecord)

        Private Sub ListComDevices()
            Dim managementObjectCollection As ManagementObjectCollection
            Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = Nothing

            Using managementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity ")
                managementObjectCollection = managementObjectSearcher.[Get]
            End Using

            Try

                For Each managementBaseObject In managementObjectCollection

                    If managementBaseObject("Caption") IsNot Nothing AndAlso managementBaseObject("Caption").ToString.Contains("9008") Then
                        listBoxControl1.Items.Add(managementBaseObject.GetPropertyValue("DeviceID"))
                    ElseIf managementBaseObject("Caption") Is Nothing Then
                        listBoxControl1.Items.Add("nope")
                    End If
                Next

            Finally

                If enumerator IsNot Nothing Then
                    CType(enumerator, IDisposable).Dispose
                End If
            End Try

            managementObjectCollection.Dispose
        End Sub

        Private cells As List(Of GridCell) = New List(Of GridCell)

        Public Class GridCell
            Public Property RowHandle As Integer
            Public Property FieldName As String
            Public Property Image As Image
        End Class

        Private Sub GridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If e.Column.FieldName Is "Type" Then

                Select Case e.CellValue
                    Case "Info"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(0), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "Error"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(1), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "Complete"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(2), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "Warning"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(3), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "Success"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(4), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "Fail"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(5), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "System"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(6), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                    Case "Device"
                        e.DisplayText = String.Empty
                        e.Graphics.DrawImage(smallImages.Images(7), New Rectangle(e.Bounds.Right - 20, e.Bounds.Y, 16, 16))
                        e.Handled = True
                End Select
            End If
        End Sub

        Private Sub tileBar1_SelectedItemChanged(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
            navigationFrame1.SelectedPageIndex = tileBarGroup2.Items.IndexOf(e.Item)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            android = AndroidController.Instance
            gridControl1.DataSource = Eventlist
        End Sub

        Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As Windows.Forms.FormClosedEventArgs)
            android.Dispose
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim serial As String
            android.UpdateDeviceList
            listBoxControl1.Items.Clear
            labelControl1.Text = "-null-"

            If android.HasConnectedDevices Then
                serial = android.ConnectedDevices(0)
                device = android.GetConnectedDevice(serial)
                labelControl1.Text = serial.ToString

                For Each key In device.BuildProp.Keys
                    listBoxControl1.Items.Add(key)
                Next
            End If
        End Sub

        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Eventlist.Add(New EventRecord(EventType.[Error], "Startup", "Starting ADB Server..."))
            ListComDevices
        End Sub
    End Class
End Namespace
