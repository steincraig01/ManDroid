Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace ManDroid
    Friend Module Program
        <STAThread>
        Private Sub Main()
            Application.EnableVisualStyles
            Application.SetCompatibleTextRenderingDefault(False)
            BonusSkins.Register
            Application.Run(New Form1)
        End Sub
    End Module
End Namespace
