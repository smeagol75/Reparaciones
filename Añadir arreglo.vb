Imports System
Imports System.IO
Imports Reparaciones
Imports System.Text
Imports System.Collections.Generic


Public Class Añadir_arreglo

    Private Sub Añadir_arreglo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'añadimos los talleres del archivo externo
        If System.IO.File.Exists(Application.StartupPath + "\ARCHIVOS\Talleres.txt") Then
            ComboBox1.Items.Clear()
            Dim leer_talleres As New StreamReader(Application.StartupPath + "\ARCHIVOS\Talleres.txt", System.Text.Encoding.Default)
            While leer_talleres.Peek <> -1
                Dim linea As String = leer_talleres.ReadLine

                If linea IsNot Nothing Or linea Is "" Then
                    ComboBox1.Items.Add(linea)
                End If

            End While

            leer_talleres.Dispose()
            leer_talleres.Close()

        End If
        'miramos si vamos a editar o a añadir
        If Form1.Editar = False Then
            'limpiamos campos
            NUM_ARREGLO_BOX.Value = Form1.Numero_mayor_arreglo + 1
            ComboBox1.SelectedIndex = -1
            ComboBox1.Text = ""
            TextBox_COD_TALLER.Text = 999
            NOMBRE_CLIENTE_BOX.Clear()
            TELF_CLIENTE_BOX.Clear()
            DESCRIPCION_ARREGLO_BOX.Clear()
            PRESUPUESTO_BOX.Text = 0
            PVP_BOX.Text = 0
            PESO_ORO_BOX.Text = 0
            PESO_PLATA_BOX.Text = 0
            CheckBox_aceptado.Checked = False
            CheckBox_entregado.Checked = False
            CheckBox_PRESUP.Checked = False
            CheckBox_presup_dado.Checked = False
            CheckBox_rechazado.Checked = False

            DateTimePicker_recepcion.Value = Date.Today
            DateTimePickerEnvio.Value = Date.Today.AddDays(3)
            DateTimePickerTaller.Value = Date.Today.AddDays(7)
        Else

            NUM_ARREGLO_BOX.Value = Form1.DataGridView_RESUMEN.CurrentRow.Cells(0).Value.ToString
            ComboBox1.SelectedIndex = Form1.DataGridView_RESUMEN.CurrentRow.Cells(1).Value.ToString
            TextBox_COD_TALLER.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(1).Value.ToString
            NOMBRE_CLIENTE_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(3).Value.ToString
            TELF_CLIENTE_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(4).Value.ToString
            DESCRIPCION_ARREGLO_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(5).Value.ToString
            If Form1.DataGridView_RESUMEN.CurrentRow.Cells(6).Value = "Si" Then
                CheckBox_PRESUP.Checked = True
            Else
                CheckBox_PRESUP.Checked = False
            End If

            DateTimePicker_recepcion.Value = Form1.DataGridView_RESUMEN.CurrentRow.Cells(7).Value
            DateTimePickerEnvio.Value = Form1.DataGridView_RESUMEN.CurrentRow.Cells(8).Value
            DateTimePickerTaller.Value = Form1.DataGridView_RESUMEN.CurrentRow.Cells(9).Value
            PESO_PLATA_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(10).Value.ToString
            PESO_ORO_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(11).Value.ToString
            PRESUPUESTO_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(12).Value.ToString
            PVP_BOX.Text = Form1.DataGridView_RESUMEN.CurrentRow.Cells(13).Value.ToString
            If Form1.DataGridView_RESUMEN.CurrentRow.Cells(14).Value = "Si" Then
                CheckBox_Recibido.Checked = True
            Else
                CheckBox_Recibido.Checked = False
            End If
            If Form1.DataGridView_RESUMEN.CurrentRow.Cells(15).Value = "Si" Then
                CheckBox_entregado.Checked = True
            Else
                CheckBox_entregado.Checked = False
            End If

            If Form1.DataGridView_RESUMEN.CurrentRow.Cells(16).Value = "Si" Then
                CheckBox_presup_dado.Checked = True
            Else
                CheckBox_presup_dado.Checked = False
            End If

            If Form1.DataGridView_RESUMEN.CurrentRow.Cells(17).Value = "Si" Then
                CheckBox_aceptado.Checked = True
            Else
                CheckBox_aceptado.Checked = False
            End If

            If Form1.DataGridView_RESUMEN.CurrentRow.Cells(18).Value = "Si" Then
                CheckBox_rechazado.Checked = True
            Else
                CheckBox_rechazado.Checked = False
            End If


        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            TextBox_COD_TALLER.Text = ComboBox1.SelectedIndex
        End If
    End Sub

    Private Sub TextBox_COD_TALLER_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_COD_TALLER.TextChanged
        If Convert.ToDecimal(TextBox_COD_TALLER.Text) <= ComboBox1.Items.Count Then
            ComboBox1.SelectedIndex = Convert.ToDecimal(TextBox_COD_TALLER.Text)

        Else
            If TextBox_COD_TALLER.Text <> 999 Then
                MsgBox("Poner un código de taller válido!!!!")
                TextBox_COD_TALLER.Text = 999
                ComboBox1.SelectedIndex = -1
            End If

        End If
    End Sub

    Private Sub TextBox_COD_TALLER_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_COD_TALLER.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TELF_CLIENTE_BOX_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TELF_CLIENTE_BOX.KeyPress
        If Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = False

        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub PRESUPUESTO_BOX_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PRESUPUESTO_BOX.KeyPress
        ' Referenciamos el control TextBox que ha desencadeno el evento
        '
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows. 
        ' 
        Dim separadorDecimal As String = _
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal, 
            ' deshechamos insertar otro separador más. 
            ' 
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse _
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If

                ' Insertamos el separador decimal. 
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If

        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso 
            Return

        ElseIf (e.KeyChar = "-"c) Then
            ' Únicamente si no está seleccionado el texto del control 
            If (tb.SelectionLength = 0) Then
                ' Si en el control hay ya escrito un signo menos, 
                ' deshechamos todos los que posteriormente se escriban 
                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If

                ' Solo permito el signo menos si aparece en primera posición 
                '
                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito. 
            e.Handled = True
            Return

        End If

        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de dos números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

        ' Si el texto del control actualmente está seleccionado, 
        ' permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub PVP_BOX_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PVP_BOX.KeyPress
        ' Referenciamos el control TextBox que ha desencadeno el evento
        '
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows. 
        ' 
        Dim separadorDecimal As String = _
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal, 
            ' deshechamos insertar otro separador más. 
            ' 
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse _
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If

                ' Insertamos el separador decimal. 
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso 
            Return

        ElseIf (e.KeyChar = "-"c) Then
            ' Únicamente si no está seleccionado el texto del control 
            If (tb.SelectionLength = 0) Then
                ' Si en el control hay ya escrito un signo menos, 
                ' deshechamos todos los que posteriormente se escriban 
                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If

                ' Solo permito el signo menos si aparece en primera posición 
                '
                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito. 
            e.Handled = True
            Return

        End If

        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de dos números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

        ' Si el texto del control actualmente está seleccionado, 
        ' permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub PESO_ORO_BOX_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PESO_ORO_BOX.KeyPress
        ' Referenciamos el control TextBox que ha desencadeno el evento
        '
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows. 
        ' 
        Dim separadorDecimal As String = _
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal, 
            ' deshechamos insertar otro separador más. 
            ' 
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse _
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If

                ' Insertamos el separador decimal. 
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso 
            Return

        ElseIf (e.KeyChar = "-"c) Then
            ' Únicamente si no está seleccionado el texto del control 
            If (tb.SelectionLength = 0) Then
                ' Si en el control hay ya escrito un signo menos, 
                ' deshechamos todos los que posteriormente se escriban 
                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If

                ' Solo permito el signo menos si aparece en primera posición 
                '
                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito. 
            e.Handled = True
            Return

        End If

        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de dos números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

        ' Si el texto del control actualmente está seleccionado, 
        ' permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False

    End Sub

    Private Sub PESO_PLATA_BOX_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PESO_PLATA_BOX.KeyPress
        ' Referenciamos el control TextBox que ha desencadeno el evento
        '
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows. 
        ' 
        Dim separadorDecimal As String = _
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal, 
            ' deshechamos insertar otro separador más. 
            ' 
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse _
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If

                ' Insertamos el separador decimal. 
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso 
            Return

        ElseIf (e.KeyChar = "-"c) Then
            ' Únicamente si no está seleccionado el texto del control 
            If (tb.SelectionLength = 0) Then
                ' Si en el control hay ya escrito un signo menos, 
                ' deshechamos todos los que posteriormente se escriban 
                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If

                ' Solo permito el signo menos si aparece en primera posición 
                '
                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito. 
            e.Handled = True
            Return

        End If

        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de dos números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

        ' Si el texto del control actualmente está seleccionado, 
        ' permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub

    Private Sub PRESUPUESTO_BOX_Leave(sender As System.Object, e As System.EventArgs) Handles PRESUPUESTO_BOX.Leave, PVP_BOX.Leave, PESO_PLATA_BOX.Leave, PESO_ORO_BOX.Leave
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim separadorDecimal As String = _
          Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (tb.Text.IndexOf(separadorDecimal) >= 0) Then
            If index = tb.Text.Length - 2 Then
                tb.Text = tb.Text & "0"
            ElseIf index = tb.Text.Length - 1 Then
                tb.Text = tb.Text & "00"
            End If

        Else

            tb.Text = tb.Text & ",00"

        End If





    End Sub

    Private Sub PVP_BOX_Leave(sender As System.Object, e As System.EventArgs)
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim separadorDecimal As String = _
          Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (tb.Text.IndexOf(separadorDecimal) >= 0) Then
            If index = tb.Text.Length - 2 Then
                tb.Text = tb.Text & "0"
            ElseIf index = tb.Text.Length - 1 Then
                tb.Text = tb.Text & "00"
            End If

        Else

            tb.Text = tb.Text & ",00"

        End If



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'comprobamos si es grabar o editar
        Dim comprobar_aceptado As String
        Dim comprobar_entregado As String
        Dim comprobar_presupuesto As String
        Dim comprobar_presupuesto_dado As String
        Dim comprobar_recibido As String
        Dim comprobar_rechazado As String

        If Form1.Editar = False Then
            'Dim objwriter As New System.IO.StreamWriter(Application.StartupPath + "\ARCHIVOS\Listado composturas.csv")



            If CheckBox_rechazado.Checked = True Then
                comprobar_rechazado = "Si"
            Else : comprobar_rechazado = "No"

            End If

            If CheckBox_aceptado.Checked = True Then
                comprobar_aceptado = "Si"
            Else : comprobar_aceptado = "No"

            End If

            If CheckBox_entregado.Checked = True Then
                comprobar_entregado = "Si"
            Else : comprobar_entregado = "No"


            End If

            If CheckBox_PRESUP.Checked = True Then
                comprobar_presupuesto = "Si"
            Else : comprobar_presupuesto = "No"
            End If

            If CheckBox_presup_dado.Checked = True Then
                comprobar_presupuesto_dado = "Si"
            Else : comprobar_presupuesto_dado = "No"
            End If

            If CheckBox_Recibido.Checked = True Then
                comprobar_recibido = "Si"
            Else : comprobar_recibido = "No"
            End If

            If CheckBox_rechazado.Checked = True Then
                comprobar_rechazado = "Si"
            Else : comprobar_rechazado = "No"
            End If


            If ComboBox1.SelectedItem = Nothing Then
                ComboBox1.SelectedIndex = 0
            End If

            Form1.DataGridView_RESUMEN.Rows.Add(NUM_ARREGLO_BOX.Value.ToString, TextBox_COD_TALLER.Text, ComboBox1.SelectedItem.ToString, NOMBRE_CLIENTE_BOX.Text, TELF_CLIENTE_BOX.Text, DESCRIPCION_ARREGLO_BOX.Text, comprobar_presupuesto, DateTimePicker_recepcion.Text, DateTimePickerEnvio.Text, DateTimePickerTaller.Text, PESO_PLATA_BOX.Text, PESO_ORO_BOX.Text, PRESUPUESTO_BOX.Text, PVP_BOX.Text, comprobar_recibido, comprobar_entregado, comprobar_presupuesto_dado, comprobar_aceptado, comprobar_rechazado)


            If NUM_ARREGLO_BOX.Value > Form1.Numero_mayor_arreglo Then
                Form1.Numero_mayor_arreglo = NUM_ARREGLO_BOX.Value
            End If

            'Dim linea_a_meter As String = NUM_ARREGLO_BOX.TextAlign + ";" + TextBox_COD_TALLER.Text + ";" + NOMBRE_CLIENTE_BOX.Text + ";" + TELF_CLIENTE_BOX.Text + ";" + DESCRIPCION_ARREGLO_BOX.Text + ";" + DateTimePicker_recepcion.Text + ";" + DateTimePickerEnvio.Text + ";" + DateTimePickerTaller.Text + ";" + PESO_PLATA_BOX.Text + ";" + PESO_ORO_BOX.Text + ";" + PRESUPUESTO_BOX.Text + ";" + PVP_BOX.Text + ";" + comprobar_aceptado + ";" + comprobar_entregado


            'objwriter.Write(linea_a_meter)

            MsgBox("Compostura Añadida Correctamente")
            Me.Close()
            Form1.Show()


        Else
            'Dim objwriter As New System.IO.StreamWriter(Application.StartupPath + "\ARCHIVOS\Listado composturas.csv")
           

            If CheckBox_aceptado.Checked = True Then
                comprobar_aceptado = "Si"
            Else : comprobar_aceptado = "No"

            End If

            If CheckBox_entregado.Checked = True Then
                comprobar_entregado = "Si"
            Else : comprobar_entregado = "No"


            End If

            If CheckBox_PRESUP.Checked = True Then
                comprobar_presupuesto = "Si"
            Else : comprobar_presupuesto = "No"


            End If

            If CheckBox_presup_dado.Checked = True Then
                comprobar_presupuesto_dado = "Si"
            Else : comprobar_presupuesto_dado = "No"

            End If

            If CheckBox_Recibido.Checked = True Then
                comprobar_Recibido = "Si"
            Else : comprobar_Recibido = "No"
            End If

            If CheckBox_rechazado.Checked = True Then
                comprobar_rechazado = "Si"
            Else : comprobar_rechazado = "No"
            End If

            Form1.DataGridView_RESUMEN.CurrentRow.Cells(0).Value = NUM_ARREGLO_BOX.Value.ToString
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(1).Value = TextBox_COD_TALLER.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(2).Value = ComboBox1.SelectedItem.ToString
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(3).Value = NOMBRE_CLIENTE_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(4).Value = TELF_CLIENTE_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(5).Value = DESCRIPCION_ARREGLO_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(6).Value = comprobar_presupuesto
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(7).Value = DateTimePicker_recepcion.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(8).Value = DateTimePickerEnvio.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(9).Value = DateTimePickerTaller.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(10).Value = PESO_PLATA_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(11).Value = PESO_ORO_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(12).Value = PRESUPUESTO_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(13).Value = PVP_BOX.Text
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(14).Value = comprobar_Recibido
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(15).Value = comprobar_entregado
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(16).Value = comprobar_presupuesto_dado
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(17).Value = comprobar_aceptado
            Form1.DataGridView_RESUMEN.CurrentRow.Cells(18).Value = comprobar_rechazado




            MsgBox("Compostura Editada Correctamente")
            Me.Close()
            Form1.Show()
        End If
       
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub NUM_ARREGLO_BOX_Leave(sender As System.Object, e As System.EventArgs) Handles NUM_ARREGLO_BOX.Leave
        For i = 0 To Form1.DataGridView_RESUMEN.Rows.Count - 1
            If Form1.DataGridView_RESUMEN.Rows(i).Cells(0).Value = NUM_ARREGLO_BOX.Value And Form1.Editar = False Then
                MsgBox("el número " + NUM_ARREGLO_BOX.Value.ToString + " de arreglo ya existe, elige otro por favor")
                NUM_ARREGLO_BOX.Value = Form1.Numero_mayor_arreglo + 1

            End If


        Next


    End Sub

    
   
End Class