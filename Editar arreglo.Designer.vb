<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_arreglo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePickerTaller = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerEnvio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_recepcion = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox_aceptado = New System.Windows.Forms.CheckBox()
        Me.PVP_BOX = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PRESUPUESTO_BOX = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PESO_PLATA_BOX = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PESO_ORO_BOX = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DESCRIPCION_ARREGLO_BOX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TELF_CLIENTE_BOX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NOMBRE_CLIENTE_BOX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NUM_ARREGLO_BOX = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_COD_TALLER = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox_entregado = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PRESUP = New System.Windows.Forms.CheckBox()
        Me.CheckBox_presup_dado = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Recibido = New System.Windows.Forms.CheckBox()
        Me.CheckBox_rechazado = New System.Windows.Forms.CheckBox()
        CType(Me.NUM_ARREGLO_BOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerTaller
        '
        Me.DateTimePickerTaller.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTaller.Location = New System.Drawing.Point(308, 383)
        Me.DateTimePickerTaller.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerTaller.Name = "DateTimePickerTaller"
        Me.DateTimePickerTaller.Size = New System.Drawing.Size(70, 20)
        Me.DateTimePickerTaller.TabIndex = 55
        '
        'DateTimePickerEnvio
        '
        Me.DateTimePickerEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerEnvio.Location = New System.Drawing.Point(155, 384)
        Me.DateTimePickerEnvio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerEnvio.Name = "DateTimePickerEnvio"
        Me.DateTimePickerEnvio.Size = New System.Drawing.Size(70, 20)
        Me.DateTimePickerEnvio.TabIndex = 54
        Me.DateTimePickerEnvio.Value = New Date(2015, 10, 9, 12, 11, 37, 0)
        '
        'DateTimePicker_recepcion
        '
        Me.DateTimePicker_recepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_recepcion.Location = New System.Drawing.Point(15, 386)
        Me.DateTimePicker_recepcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker_recepcion.Name = "DateTimePicker_recepcion"
        Me.DateTimePicker_recepcion.Size = New System.Drawing.Size(70, 20)
        Me.DateTimePicker_recepcion.TabIndex = 53
        '
        'CheckBox_aceptado
        '
        Me.CheckBox_aceptado.AutoSize = True
        Me.CheckBox_aceptado.Location = New System.Drawing.Point(224, 244)
        Me.CheckBox_aceptado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox_aceptado.Name = "CheckBox_aceptado"
        Me.CheckBox_aceptado.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_aceptado.TabIndex = 52
        Me.CheckBox_aceptado.Text = "Aceptado"
        Me.CheckBox_aceptado.UseVisualStyleBackColor = True
        '
        'PVP_BOX
        '
        Me.PVP_BOX.Location = New System.Drawing.Point(128, 221)
        Me.PVP_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PVP_BOX.Name = "PVP_BOX"
        Me.PVP_BOX.Size = New System.Drawing.Size(56, 20)
        Me.PVP_BOX.TabIndex = 51
        Me.PVP_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(125, 204)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Pvp"
        '
        'PRESUPUESTO_BOX
        '
        Me.PRESUPUESTO_BOX.Location = New System.Drawing.Point(25, 221)
        Me.PRESUPUESTO_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PRESUPUESTO_BOX.Name = "PRESUPUESTO_BOX"
        Me.PRESUPUESTO_BOX.Size = New System.Drawing.Size(52, 20)
        Me.PRESUPUESTO_BOX.TabIndex = 49
        Me.PRESUPUESTO_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 204)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Presupuesto taller"
        '
        'PESO_PLATA_BOX
        '
        Me.PESO_PLATA_BOX.Location = New System.Drawing.Point(128, 275)
        Me.PESO_PLATA_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PESO_PLATA_BOX.Name = "PESO_PLATA_BOX"
        Me.PESO_PLATA_BOX.Size = New System.Drawing.Size(76, 20)
        Me.PESO_PLATA_BOX.TabIndex = 47
        Me.PESO_PLATA_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(125, 258)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Peso Plata"
        '
        'PESO_ORO_BOX
        '
        Me.PESO_ORO_BOX.Location = New System.Drawing.Point(27, 275)
        Me.PESO_ORO_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PESO_ORO_BOX.Name = "PESO_ORO_BOX"
        Me.PESO_ORO_BOX.Size = New System.Drawing.Size(76, 20)
        Me.PESO_ORO_BOX.TabIndex = 45
        Me.PESO_ORO_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 258)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Peso Oro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Fecha de Recepción taller"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 369)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Fecha de Envío"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 369)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Fecha de Recepción"
        '
        'DESCRIPCION_ARREGLO_BOX
        '
        Me.DESCRIPCION_ARREGLO_BOX.Location = New System.Drawing.Point(22, 175)
        Me.DESCRIPCION_ARREGLO_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DESCRIPCION_ARREGLO_BOX.Name = "DESCRIPCION_ARREGLO_BOX"
        Me.DESCRIPCION_ARREGLO_BOX.Size = New System.Drawing.Size(365, 20)
        Me.DESCRIPCION_ARREGLO_BOX.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Descripción Arreglo"
        '
        'TELF_CLIENTE_BOX
        '
        Me.TELF_CLIENTE_BOX.Location = New System.Drawing.Point(176, 121)
        Me.TELF_CLIENTE_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TELF_CLIENTE_BOX.Name = "TELF_CLIENTE_BOX"
        Me.TELF_CLIENTE_BOX.Size = New System.Drawing.Size(140, 20)
        Me.TELF_CLIENTE_BOX.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Teléfono"
        '
        'NOMBRE_CLIENTE_BOX
        '
        Me.NOMBRE_CLIENTE_BOX.Location = New System.Drawing.Point(22, 121)
        Me.NOMBRE_CLIENTE_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NOMBRE_CLIENTE_BOX.Name = "NOMBRE_CLIENTE_BOX"
        Me.NOMBRE_CLIENTE_BOX.Size = New System.Drawing.Size(140, 20)
        Me.NOMBRE_CLIENTE_BOX.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Taller"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Esteban", "Eloy", "Joyel (Richar)", "Fokkelmann", "Roberto engastador", "Elmerfor (Relojero)", "Reyforsa (Relojero)", "Marfilista Gregorio"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 46)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Arreglo nº"
        '
        'NUM_ARREGLO_BOX
        '
        Me.NUM_ARREGLO_BOX.Location = New System.Drawing.Point(22, 46)
        Me.NUM_ARREGLO_BOX.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NUM_ARREGLO_BOX.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUM_ARREGLO_BOX.Name = "NUM_ARREGLO_BOX"
        Me.NUM_ARREGLO_BOX.Size = New System.Drawing.Size(90, 20)
        Me.NUM_ARREGLO_BOX.TabIndex = 30
        Me.NUM_ARREGLO_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 291)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 41)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Añadir Cambios Arreglo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_COD_TALLER
        '
        Me.TextBox_COD_TALLER.Location = New System.Drawing.Point(388, 46)
        Me.TextBox_COD_TALLER.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_COD_TALLER.Name = "TextBox_COD_TALLER"
        Me.TextBox_COD_TALLER.Size = New System.Drawing.Size(39, 20)
        Me.TextBox_COD_TALLER.TabIndex = 57
        Me.TextBox_COD_TALLER.Text = "999"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(386, 27)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Codigo Taller"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(80, 221)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "€"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(190, 223)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "€"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(352, 409)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 41)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox_entregado
        '
        Me.CheckBox_entregado.AutoSize = True
        Me.CheckBox_entregado.Location = New System.Drawing.Point(338, 232)
        Me.CheckBox_entregado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox_entregado.Name = "CheckBox_entregado"
        Me.CheckBox_entregado.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox_entregado.TabIndex = 62
        Me.CheckBox_entregado.Text = "Entregado"
        Me.CheckBox_entregado.UseVisualStyleBackColor = True
        '
        'CheckBox_PRESUP
        '
        Me.CheckBox_PRESUP.AutoSize = True
        Me.CheckBox_PRESUP.Location = New System.Drawing.Point(224, 198)
        Me.CheckBox_PRESUP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox_PRESUP.Name = "CheckBox_PRESUP"
        Me.CheckBox_PRESUP.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox_PRESUP.TabIndex = 64
        Me.CheckBox_PRESUP.Text = "Presupuesto"
        Me.CheckBox_PRESUP.UseVisualStyleBackColor = True
        '
        'CheckBox_presup_dado
        '
        Me.CheckBox_presup_dado.AutoSize = True
        Me.CheckBox_presup_dado.Location = New System.Drawing.Point(224, 221)
        Me.CheckBox_presup_dado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox_presup_dado.Name = "CheckBox_presup_dado"
        Me.CheckBox_presup_dado.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox_presup_dado.TabIndex = 65
        Me.CheckBox_presup_dado.Text = "Presupuesto dado"
        Me.CheckBox_presup_dado.UseVisualStyleBackColor = True
        '
        'CheckBox_Recibido
        '
        Me.CheckBox_Recibido.AutoSize = True
        Me.CheckBox_Recibido.Location = New System.Drawing.Point(338, 210)
        Me.CheckBox_Recibido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox_Recibido.Name = "CheckBox_Recibido"
        Me.CheckBox_Recibido.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox_Recibido.TabIndex = 66
        Me.CheckBox_Recibido.Text = "Recibido"
        Me.CheckBox_Recibido.UseVisualStyleBackColor = True
        '
        'CheckBox_rechazado
        '
        Me.CheckBox_rechazado.AutoSize = True
        Me.CheckBox_rechazado.Location = New System.Drawing.Point(224, 267)
        Me.CheckBox_rechazado.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox_rechazado.Name = "CheckBox_rechazado"
        Me.CheckBox_rechazado.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_rechazado.TabIndex = 67
        Me.CheckBox_rechazado.Text = "Rechazado"
        Me.CheckBox_rechazado.UseVisualStyleBackColor = True
        '
        'Editar_arreglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox_rechazado)
        Me.Controls.Add(Me.CheckBox_Recibido)
        Me.Controls.Add(Me.CheckBox_presup_dado)
        Me.Controls.Add(Me.CheckBox_PRESUP)
        Me.Controls.Add(Me.CheckBox_entregado)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox_COD_TALLER)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePickerTaller)
        Me.Controls.Add(Me.DateTimePickerEnvio)
        Me.Controls.Add(Me.DateTimePicker_recepcion)
        Me.Controls.Add(Me.CheckBox_aceptado)
        Me.Controls.Add(Me.PVP_BOX)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PRESUPUESTO_BOX)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PESO_PLATA_BOX)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PESO_ORO_BOX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DESCRIPCION_ARREGLO_BOX)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TELF_CLIENTE_BOX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NOMBRE_CLIENTE_BOX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NUM_ARREGLO_BOX)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Editar_arreglo"
        Me.Text = "Editar arreglo"
        CType(Me.NUM_ARREGLO_BOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePickerTaller As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_recepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox_aceptado As System.Windows.Forms.CheckBox
    Friend WithEvents PVP_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PRESUPUESTO_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PESO_PLATA_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PESO_ORO_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DESCRIPCION_ARREGLO_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TELF_CLIENTE_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NOMBRE_CLIENTE_BOX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NUM_ARREGLO_BOX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox_COD_TALLER As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox_entregado As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_PRESUP As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_presup_dado As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Recibido As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_rechazado As System.Windows.Forms.CheckBox
End Class
