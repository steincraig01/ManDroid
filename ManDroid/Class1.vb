Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ManDroid
    Public Class EventRecord
        Public Property Time As String
        Public Property Type As String
        Public Property Operation As String
        Public Property Description As String

        Public Sub New(ByVal type As String, ByVal operation As String, ByVal description As String)
            Time = Date.Now.ToShortTimeString
            Operation = operation
            Type = type
            Description = description
        End Sub
    End Class

    Public Module EventType
        Public ReadOnly Info As String = "Info"
        Public ReadOnly [Error] As String = "Error"
        Public ReadOnly Complete As String = "Complete"
        Public ReadOnly Warning As String = "Warning"
        Public ReadOnly Success As String = "Success"
        Public ReadOnly Fail As String = "Fail"
        Public ReadOnly System As String = "System"
        Public ReadOnly Device As String = "Device"
    End Module
End Namespace
