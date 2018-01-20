Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
'Imports System.Text.UTF8Encoding
Imports System.Data
Imports System.Globalization



Public Class Form1

    Dim strExport As Object
    Public Numero_mayor_arreglo As UInteger = 0
    Public Editar As Boolean = False



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'empezamos a buscar nuestra base de datos.

        Dim TextLine As String = ""

        Dim SplitLine() As String

        Try
            Dim objReader As New System.IO.StreamReader(Application.StartupPath + "\ARCHIVOS\Listado composturas.csv", System.Text.Encoding.Default)

            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()

                SplitLine = Split(TextLine, ";")

                Me.DataGridView_RESUMEN.Rows.Add(SplitLine)
            Loop

            For i = 0 To DataGridView_RESUMEN.Rows.Count - 1
                'chequeo el numero más alto de compostura para añadir uno al nuevo
                If DataGridView_RESUMEN.Rows(i).Cells(0).Value > Numero_mayor_arreglo And DataGridView_RESUMEN.Rows(i).Cells(0).Value <> "" Then
                    Numero_mayor_arreglo = DataGridView_RESUMEN.Rows(i).Cells(0).Value
                End If



            Next
            Comprobar_Colores()
            Comprobar_atrasos()
            objReader.Dispose()
            objReader.Close()


            'Leemos las entregadas

            Dim objReader_entreg As New System.IO.StreamReader(Application.StartupPath + "\ARCHIVOS\Listado Entregados.csv", System.Text.Encoding.Default)

            Do While objReader_entreg.Peek() <> -1

                TextLine = objReader_entreg.ReadLine()

                SplitLine = Split(TextLine, ";")

                Entregados.DataGridView_entregados.Rows.Add(SplitLine)
            Loop
            objReader_entreg.Dispose()
            objReader_entreg.Close()

            DataGridView_RESUMEN.Sort(Column1, ComponentModel.ListSortDirection.Descending)




        Catch ex As Exception
            MsgBox(ex.ToString + "Listado composturas.csv no encontrado!!!!!, hablar con Héctorrrrr")
            'Me.Close()

        End Try


        


    End Sub

    Private Sub Button_add_Click(sender As System.Object, e As System.EventArgs) Handles Button_add.Click

        Me.Hide()
        addArreglo.ShowDialog()


    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Grabar()
        ' Dim dlgRes As DialogResult
        'dlgRes = MessageBox.Show("Desea Cerrar y Guardar los Cambios Efectuados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If dlgRes = Windows.Forms.DialogResult.Yes Then
        'Grabar()

        'ElseIf dlgRes = Windows.Forms.DialogResult.No Then
        'no guardar archivo
        'Me.Dispose()
        'End If
    End Sub

    Private Sub ButtonGrabar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGrabar.Click
        Grabar()
        MsgBox("Archivos Guardados Correctamente!")


    End Sub

    Private Sub Button_delete_Click(sender As System.Object, e As System.EventArgs) Handles Button_delete.Click
        'Comprobamos que tenemos seleccionado algun arreglo
        If DataGridView_RESUMEN.SelectedCells IsNot Nothing Then
            Dim dlgRes As DialogResult
            'Si eligen si borramos la fila
            dlgRes = MessageBox.Show("Estás seguro de borrar el arreglo " & DataGridView_RESUMEN.CurrentRow.Cells(0).Value.ToString & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dlgRes = Windows.Forms.DialogResult.Yes Then

                DataGridView_RESUMEN.Rows.RemoveAt(DataGridView_RESUMEN.CurrentRow.Index)

            End If

        Else
            MsgBox("Selecciona el arreglo a borrar")

        End If
    End Sub

    Private Sub Button_edit_Click(sender As System.Object, e As System.EventArgs) Handles Button_edit.Click
        Me.Hide()
        Editar = True
        addArreglo.ShowDialog()
        DataGridView_ATRASO_COMP.Rows.Clear()
        DataGridView_Atrasos_presup.Rows.Clear()
        Comprobar_atrasos()
        Comprobar_Colores()
        Editar = False

    End Sub

    Private Sub DataGridView_RESUMEN_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGridView_RESUMEN.DoubleClick
        Me.Hide()
        Editar = True
        addArreglo.ShowDialog()
        DataGridView_ATRASO_COMP.Rows.Clear()
        DataGridView_Atrasos_presup.Rows.Clear()
        Comprobar_atrasos()
        Comprobar_Colores()
        Editar = False
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If (TextBox_buscar.Text <> String.Empty) Then

            Dim Indice_comienzo As UInteger = DataGridView_RESUMEN.CurrentCell.RowIndex + 1
            If Indice_comienzo > DataGridView_RESUMEN.Rows.Count - 1 Then
                Indice_comienzo = 0
            End If
            DataGridView_RESUMEN.ClearSelection()
            Dim i As UInteger = 0
            Dim Encontrado As Boolean = False
            ' For i = Indice_comienzo To DataGridView_coach.Rows.Count - 1
            i = Indice_comienzo

            While (Encontrado = False) And (i < DataGridView_RESUMEN.Rows.Count - 1)

                For Each cell As DataGridViewCell In DataGridView_RESUMEN.Rows(i).Cells
                    If cell.Value.ToString.Contains(TextBox_buscar.Text) Then
                        'This is the cell we want to select
                        cell.Selected = True
                        Encontrado = True
                        'Yellow background for all matches
                    End If

                Next
                i += 1

            End While
            ' Next

            If Encontrado = False Then
                MsgBox(TextBox_buscar.Text + " No encontrado" + TextBox_buscar.Text + " en toda la tabla, lo siento.")
                DataGridView_RESUMEN.Rows(0).Cells(0).Selected = True
            End If


        End If



    End Sub

    Private Sub TextBox_buscar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox_buscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1_Click(PictureBox1, Nothing)

        End If
    End Sub

    Private Sub Comprobar_atrasos()

        Dim Hoy As Date = Date.Today
        Dim Dia_sup_entrega_taller As Date
        
        For i = 0 To DataGridView_RESUMEN.Rows.Count - 1

            'compruebo presupuestos atrasados
            Dia_sup_entrega_taller = DataGridView_RESUMEN.Rows(i).Cells(9).Value
            Dim Dia_de_apuntado_orig As Date = DataGridView_RESUMEN.Rows(i).Cells(7).Value
            Dim Dias_atraso_tot As Integer = DateDiff(DateInterval.Day, Dia_de_apuntado_orig, Hoy)

            'comprobamos presupuesto, si marcado 
            If DataGridView_RESUMEN.Rows(i).Cells(6).Value = "Si" And DataGridView_RESUMEN.Rows(i).Cells(16).Value = "No" And DataGridView_RESUMEN.Rows(i).Cells(12).Value = 0 Then

                Dim Dia_de_apuntado As Date = DataGridView_RESUMEN.Rows(i).Cells(7).Value
                Dim num_dias As Integer = DateDiff(DateInterval.Day, Dia_de_apuntado, Hoy)

                If num_dias > 3 Then
                    DataGridView_Atrasos_presup.Rows.Add(DataGridView_RESUMEN.Rows(i).Cells(0).Value, num_dias, (num_dias - 3), DataGridView_RESUMEN.Rows(i).Cells(2).Value)

                End If


            ElseIf Dias_atraso_tot > 7 And DataGridView_RESUMEN.Rows(i).Cells(15).Value = "No" And DataGridView_RESUMEN.Rows(i).Cells(14).Value = "No" Then
                DataGridView_ATRASO_COMP.Rows.Add(DataGridView_RESUMEN.Rows(i).Cells(0).Value, Dias_atraso_tot, (Dias_atraso_tot - 7), DataGridView_RESUMEN.Rows(i).Cells(2).Value)

            End If

        Next



    End Sub

    Private Sub DataGridView_Atrasos_presup_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Atrasos_presup.CellDoubleClick

        Dim arreglo_sel As Integer = DataGridView_Atrasos_presup.CurrentRow.Cells(0).Value
        For i = 0 To DataGridView_RESUMEN.Rows.Count - 1
            If DataGridView_RESUMEN.Rows(i).Cells(0).Value = arreglo_sel Then
                DataGridView_RESUMEN.Rows(i).Cells(0).Selected = True

                DataGridView_RESUMEN_DoubleClick(DataGridView_RESUMEN, Nothing)
            End If

        Next


    End Sub

    Private Sub DataGridView_ATRASO_COMP_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_ATRASO_COMP.CellDoubleClick

        Dim arreglo_sel As Integer = DataGridView_ATRASO_COMP.CurrentRow.Cells(0).Value
        For i = 0 To DataGridView_RESUMEN.Rows.Count - 1
            If DataGridView_RESUMEN.Rows(i).Cells(0).Value = arreglo_sel Then
                DataGridView_RESUMEN.Rows(i).Cells(0).Selected = True

                DataGridView_RESUMEN_DoubleClick(DataGridView_RESUMEN, Nothing)
            End If

        Next

    End Sub

    Private Sub Grabar()
        'guardar archivo exportamos datagridview al csv
        Dim strExport As String = ""
        'Loop through all the columns in DataGridView to Set the 
        'Column Heading
        'Este bloque es para escribir las cabeceras.
        ' For Each dc As DataGridViewColumn In DataGridView_RESUMEN.Columns
        'strExport += dc.HeaderText + ";"
        'Next
        'strExport = strExport.Substring(0, strExport.Length - 1) + Environment.NewLine.ToString()


        'Loop through all the row and append the value with 3 spaces
        For Each dr As DataGridViewRow In DataGridView_RESUMEN.Rows
            For Each dc As DataGridViewCell In dr.Cells
                If dc.Value IsNot Nothing Then
                    strExport += dc.Value.ToString() + ";"
                Else : strExport += ";"
                End If
            Next
            strExport += Environment.NewLine.ToString()
        Next


        strExport = strExport.Substring(0, strExport.Length - 1) '+ Environment.NewLine.ToString()
        'Create a TextWrite object to write to file, select a file name with .csv extention
        'Borramos la ultima copia para reemplazar por esta.

        Dim fechaHora As String = DateTime.Now.ToString("dd-MM-yyyy H-mm-ss")

        FileSystem.FileCopy(Application.StartupPath + "\ARCHIVOS\Listado composturas.csv", Application.StartupPath + "\ARCHIVOS\BACKUPS\" + fechaHora + ".hcv")


        If System.IO.File.Exists(Application.StartupPath + "\ARCHIVOS\Listado composturas.bak") Then
            System.IO.File.Delete(Application.StartupPath + "\ARCHIVOS\Listado composturas.bak")
        End If

        FileSystem.Rename(Application.StartupPath + "\ARCHIVOS\Listado composturas.csv", Application.StartupPath + "\ARCHIVOS\Listado composturas.bak")

        Dim tw As System.IO.TextWriter = New System.IO.StreamWriter(Application.StartupPath + "\ARCHIVOS\Listado composturas.csv", False, System.Text.Encoding.UTF8)

        'Write the Text to file
        tw.Write(strExport)
        'Close the Textwrite
        tw.Close()

        'Grabamos los entregados
        'guardar archivo exportamos datagridview al csv
        Dim strExport_entreg As String = ""
        'Loop through all the columns in DataGridView to Set the 
        'Column Heading
        'Este bloque es para escribir las cabeceras.
        ' For Each dc As DataGridViewColumn In DataGridView_RESUMEN.Columns
        'strExport += dc.HeaderText + ";"
        'Next
        'strExport = strExport.Substring(0, strExport.Length - 1) + Environment.NewLine.ToString()


        'Loop through all the row and append the value with 3 spaces
        For Each dr_entreg As DataGridViewRow In Entregados.DataGridView_entregados.Rows
            For Each dc_entreg As DataGridViewCell In dr_entreg.Cells
                If dc_entreg.Value IsNot Nothing Then
                    strExport_entreg += dc_entreg.Value.ToString() + ";"
                Else : strExport_entreg += ";"
                End If
            Next
            strExport_entreg += Environment.NewLine.ToString()
        Next


        strExport_entreg = strExport_entreg.Substring(0, strExport_entreg.Length - 1) '+ Environment.NewLine.ToString()
        'Create a TextWrite object to write to file, select a file name with .csv extention
        'Borramos la ultima copia para reemplazar por esta.

        Dim fechaHora_entreg As String = DateTime.Now.ToString("dd-MM-yyyy H-mm-ss")

        FileSystem.FileCopy(Application.StartupPath + "\ARCHIVOS\Listado Entregados.csv", Application.StartupPath + "\ARCHIVOS\BACKUPS\" + fechaHora_entreg + ".entreg")


        If System.IO.File.Exists(Application.StartupPath + "\ARCHIVOS\Listado Entregados.bak") Then
            System.IO.File.Delete(Application.StartupPath + "\ARCHIVOS\Listado Entregados.bak")
        End If

        FileSystem.Rename(Application.StartupPath + "\ARCHIVOS\Listado Entregados.csv", Application.StartupPath + "\ARCHIVOS\Listado Entregados.bak")

        Dim tw_entreg As System.IO.TextWriter = New System.IO.StreamWriter(Application.StartupPath + "\ARCHIVOS\Listado Entregados.csv", False, System.Text.Encoding.UTF8)

        'Write the Text to file
        tw_entreg.Write(strExport_entreg)
        'Close the Textwrite
        tw_entreg.Close()


    End Sub

    Private Sub Comprobar_Colores()

        For i = 0 To DataGridView_RESUMEN.Rows.Count - 1




            'Chequeo si está recibido para cambiarle el color de fondo.
                If DataGridView_RESUMEN.Rows(i).Cells(14).Value = "Si" And DataGridView_RESUMEN.Rows(i).Cells(14).Value IsNot Nothing Then
                    DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                'Chequeo si Entregado
                If DataGridView_RESUMEN.Rows(i).Cells(15).Value = "Si" And DataGridView_RESUMEN.Rows(i).Cells(15).Value IsNot Nothing Then
                    DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
                End If


                'Chequeo Presupuestos 
            ElseIf DataGridView_RESUMEN.Rows(i).Cells(6).Value = "Si" Then
                DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.Aquamarine

                'Si presupuesto Recibido
                If DataGridView_RESUMEN.Rows(i).Cells(12).Value <> 0 And DataGridView_RESUMEN.Rows(i).Cells(16).Value = "No" And DataGridView_RESUMEN.Rows(i).Cells(17).Value = "No" Then
                    DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.OliveDrab

                    'Si presupuesto Dado
                ElseIf DataGridView_RESUMEN.Rows(i).Cells(12).Value <> 0 And DataGridView_RESUMEN.Rows(i).Cells(16).Value = "Si" And DataGridView_RESUMEN.Rows(i).Cells(17).Value = "No" Then
                    DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.Thistle


                    'Si presupuesto Aceptado
                ElseIf DataGridView_RESUMEN.Rows(i).Cells(12).Value <> 0 And DataGridView_RESUMEN.Rows(i).Cells(16).Value = "Si" And DataGridView_RESUMEN.Rows(i).Cells(17).Value = "Si" Then
                    DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If


            Else
                DataGridView_RESUMEN.Rows(i).DefaultCellStyle.BackColor = Color.White

            End If

        Next
    End Sub

    Private Sub TextBox_buscar_Enter(sender As System.Object, e As System.EventArgs) Handles TextBox_buscar.Enter
        TextBox_buscar.Clear()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Boton_enviar.Click

        'copio los entregados
        For i = 0 To DataGridView_RESUMEN.Rows.Count - 1
            If DataGridView_RESUMEN.Rows(i).Cells(15).Value = "Si" Then
                Dim Fila_A_copiar(DataGridView_RESUMEN.Rows(i).Cells.Count - 1) As String
                For j = 0 To DataGridView_RESUMEN.Rows(i).Cells.Count - 1
                    Fila_A_copiar(j) = DataGridView_RESUMEN.Rows(i).Cells(j).Value.ToString
                Next
                Entregados.DataGridView_entregados.Rows.Add(Fila_A_copiar)
            End If


        Next
        'borro los copiados

        For Row As Integer = DataGridView_RESUMEN.Rows.Count - 1 To 0 Step -1
            If DataGridView_RESUMEN.Rows(Row).Cells(15).Value = "Si" Then
                DataGridView_RESUMEN.Rows.RemoveAt(Row)
            End If
        Next


        MsgBox("Arreglos enviados a Entregados")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Boton_verEntregados.Click
        Me.Hide()
        Entregados.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Boton_EditarTalleres.Click
        Me.Hide()
        Talleres.ShowDialog()

    End Sub
End Class
