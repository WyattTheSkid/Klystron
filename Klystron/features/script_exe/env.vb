Imports System.IO
Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports Microsoft.VisualBasic
Public Class env
    Private Sub execute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles execute.Click
        ' read code from textbox
        Dim Code As String = scriptbox.Text
        ' clear output textbox
        output.Clear()
        ' create fully functional assembly string
        Code = ("Imports System" & vbCrLf &
                "Imports System.Windows.Forms" & vbCrLf &
                "Imports Microsoft.Visualbasic" & vbCrLf &
                "Public Class TempClass" & vbCrLf &
                "Public Sub MyCode(ByVal output As TextBox)" & vbCrLf &
                Code & vbCrLf &
                "End Sub" & vbCrLf &
                "End Class")
        ' create the compiler
        Dim vbProv = New VBCodeProvider()
        ' create parameters to pass to the compiler
        Dim vbParams = New CompilerParameters()
        ' add referenced assemblies.  
        vbParams.ReferencedAssemblies.Add("System.dll")
        vbParams.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        vbParams.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        ' generate an assembly in memory
        vbParams.GenerateExecutable = False
        vbParams.GenerateInMemory = True
        ' give it a name
        vbParams.OutputAssembly = "MyCode"
        Dim compResults = vbProv.CompileAssemblyFromSource(vbParams, Code)
        If compResults.Errors.HasErrors Then
            Dim ErrorMsg As String = compResults.Errors.Count.ToString & " Errors:"
            For x As Integer = 0 To compResults.Errors.Count - 1
                ErrorMsg = ErrorMsg & vbCrLf & "Line: " & compResults.Errors(x).Line.ToString & " - " + compResults.Errors(x).ErrorText
            Next
            output.Text = ErrorMsg & vbCrLf & vbCrLf + Code
        Else
            Dim obj As Object = compResults.CompiledAssembly.CreateInstance("TempClass")
            Dim args() As Object = {Me.output}
            Try
                Dim result As Object = obj.GetType().InvokeMember("MyCode", BindingFlags.InvokeMethod, Nothing, obj, args)
            Catch Oops As Exception

                MessageBox.Show(Oops.Message)
            End Try
        End If
    End Sub

    Private Sub env_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class