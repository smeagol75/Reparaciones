Public Class Talleres
    Public cambiado As Boolean = False
    Private Sub Talleres_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        TextBox1.Clear()

        Dim objReader As New System.IO.StreamReader(Application.StartupPath + "\ARCHIVOS\Talleres.txt", System.Text.Encoding.Default)
        Dim TextLine As String = ""
        Do While objReader.Peek() <> -1

            TextLine = objReader.ReadLine()
            ListBox1.Items.Add(TextLine)
        Loop

        objReader.Dispose()
        objReader.Close()


    End Sub




    Private Sub Talleres_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If cambiado = True Then


            Dim dlgRes As DialogResult
            dlgRes = MessageBox.Show("Desea Cerrar y Guardar los Cambios Efectuados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgRes = Windows.Forms.DialogResult.Yes Then

                If System.IO.File.Exists(Application.StartupPath + "\ARCHIVOS\Talleres.bak") Then
                    System.IO.File.Delete(Application.StartupPath + "\ARCHIVOS\Talleres.bak")
                End If

                FileSystem.Rename(Application.StartupPath + "\ARCHIVOS\Talleres.txt", Application.StartupPath + "\ARCHIVOS\Talleres.bak")

                Dim tw As System.IO.TextWriter = New System.IO.StreamWriter(Application.StartupPath + "\ARCHIVOS\Talleres.txt", False, System.Text.Encoding.UTF8)
                For Each Line In ListBox1.Items
                    tw.WriteLine(Line)
                Next
                tw.Dispose()
                tw.Close()
                MsgBox("Talleres Grabados correctamente")
            ElseIf dlgRes = Windows.Forms.DialogResult.No Then
                'no guardar archivo
                Me.Dispose()
            End If

        End If

        Form1.Show()

    End Sub

    Private Sub Talleres_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text IsNot "" Then
            ListBox1.Items.Add(TextBox1.Text)
            cambiado = True
        Else
            MsgBox("Introduce primero el nombre del taller")
        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim dlgRes As DialogResult
            Dim Texto_nuevo As String = TextBox1.Text
            dlgRes = MessageBox.Show("Desea Cambiar El taller " + ListBox1.SelectedItem + " por " + TextBox1.Text, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgRes = Windows.Forms.DialogResult.Yes Then
                Dim Index As UInt32 = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(Index)
                ListBox1.Items.Insert(Index, Texto_nuevo)
                MsgBox("Cambiado correctamente")
                cambiado = True
            ElseIf dlgRes = Windows.Forms.DialogResult.No Then

            End If


        Else : MsgBox("Selecciona el Taller a modificar primero.")
        End If
    End Sub

   

    
End Class