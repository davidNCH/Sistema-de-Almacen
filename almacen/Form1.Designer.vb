<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.fechavence = New System.Windows.Forms.DateTimePicker()
        Me.perecible = New System.Windows.Forms.ComboBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.umedida = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.igv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PTBFOTO = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GRBCONSULTAR = New System.Windows.Forms.GroupBox()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BTNCONSULTAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.GRBDESPLAZAMIENTO = New System.Windows.Forms.GroupBox()
        Me.BTNULTIMO = New System.Windows.Forms.Button()
        Me.BTNSIGUIENTE = New System.Windows.Forms.Button()
        Me.BTNANTERIOR = New System.Windows.Forms.Button()
        Me.BTNPRIMERO = New System.Windows.Forms.Button()
        Me.TXTFOTO = New System.Windows.Forms.TextBox()
        CType(Me.PTBFOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBCONSULTAR.SuspendLayout()
        Me.GRBDESPLAZAMIENTO.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(9, 32)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 20)
        Me.codigo.TabIndex = 1
        '
        'fechavence
        '
        Me.fechavence.CalendarFont = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechavence.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechavence.Location = New System.Drawing.Point(9, 158)
        Me.fechavence.Name = "fechavence"
        Me.fechavence.Size = New System.Drawing.Size(200, 21)
        Me.fechavence.TabIndex = 3
        '
        'perecible
        '
        Me.perecible.FormattingEnabled = True
        Me.perecible.Location = New System.Drawing.Point(259, 157)
        Me.perecible.Name = "perecible"
        Me.perecible.Size = New System.Drawing.Size(121, 21)
        Me.perecible.TabIndex = 4
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(134, 32)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(175, 20)
        Me.descripcion.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripcion"
        '
        'marca
        '
        Me.marca.Location = New System.Drawing.Point(336, 32)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(100, 20)
        Me.marca.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "marca"
        '
        'umedida
        '
        Me.umedida.Location = New System.Drawing.Point(469, 32)
        Me.umedida.Name = "umedida"
        Me.umedida.Size = New System.Drawing.Size(100, 20)
        Me.umedida.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(490, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "U. medida"
        '
        'stock
        '
        Me.stock.Location = New System.Drawing.Point(10, 86)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(100, 20)
        Me.stock.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Stock"
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(152, 86)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(100, 20)
        Me.precio.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio"
        '
        'igv
        '
        Me.igv.Location = New System.Drawing.Point(319, 86)
        Me.igv.Name = "igv"
        Me.igv.Size = New System.Drawing.Size(100, 20)
        Me.igv.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "IGV"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(458, 86)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Importe Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 14)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "F. Vencimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 14)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Pericible"
        '
        'PTBFOTO
        '
        Me.PTBFOTO.Location = New System.Drawing.Point(458, 173)
        Me.PTBFOTO.Name = "PTBFOTO"
        Me.PTBFOTO.Size = New System.Drawing.Size(137, 129)
        Me.PTBFOTO.TabIndex = 22
        Me.PTBFOTO.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("OCR-A BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(477, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Foto"
        '
        'GRBCONSULTAR
        '
        Me.GRBCONSULTAR.BackColor = System.Drawing.Color.PowderBlue
        Me.GRBCONSULTAR.Controls.Add(Me.BTNBUSCAR)
        Me.GRBCONSULTAR.Controls.Add(Me.TXTBUSCAR)
        Me.GRBCONSULTAR.Controls.Add(Me.Label19)
        Me.GRBCONSULTAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBCONSULTAR.Location = New System.Drawing.Point(469, 354)
        Me.GRBCONSULTAR.Name = "GRBCONSULTAR"
        Me.GRBCONSULTAR.Size = New System.Drawing.Size(203, 142)
        Me.GRBCONSULTAR.TabIndex = 88
        Me.GRBCONSULTAR.TabStop = False
        Me.GRBCONSULTAR.Text = "CONSULTAR"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.Location = New System.Drawing.Point(52, 68)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(99, 26)
        Me.BTNBUSCAR.TabIndex = 45
        Me.BTNBUSCAR.Text = "BUSCAR"
        Me.BTNBUSCAR.UseVisualStyleBackColor = True
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Location = New System.Drawing.Point(44, 19)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(106, 21)
        Me.TXTBUSCAR.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(75, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 14)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "CODIGO"
        '
        'BTNCONSULTAR
        '
        Me.BTNCONSULTAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCONSULTAR.Location = New System.Drawing.Point(327, 450)
        Me.BTNCONSULTAR.Name = "BTNCONSULTAR"
        Me.BTNCONSULTAR.Size = New System.Drawing.Size(99, 26)
        Me.BTNCONSULTAR.TabIndex = 87
        Me.BTNCONSULTAR.Text = "CONSULTAR"
        Me.BTNCONSULTAR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(327, 418)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(99, 26)
        Me.BTNGUARDAR.TabIndex = 86
        Me.BTNGUARDAR.Text = "GUARDAR"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(327, 386)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(99, 26)
        Me.BTNMODIFICAR.TabIndex = 85
        Me.BTNMODIFICAR.Text = "MODIFICAR"
        Me.BTNMODIFICAR.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(221, 450)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(99, 26)
        Me.BTNELIMINAR.TabIndex = 84
        Me.BTNELIMINAR.Text = "ELIMINAR"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(221, 418)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(99, 26)
        Me.BTNCANCELAR.TabIndex = 83
        Me.BTNCANCELAR.Text = "CANCELAR"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(221, 386)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(99, 26)
        Me.BTNNUEVO.TabIndex = 82
        Me.BTNNUEVO.Text = "NUEVO"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'GRBDESPLAZAMIENTO
        '
        Me.GRBDESPLAZAMIENTO.BackColor = System.Drawing.Color.DarkGray
        Me.GRBDESPLAZAMIENTO.Controls.Add(Me.BTNULTIMO)
        Me.GRBDESPLAZAMIENTO.Controls.Add(Me.BTNSIGUIENTE)
        Me.GRBDESPLAZAMIENTO.Controls.Add(Me.BTNANTERIOR)
        Me.GRBDESPLAZAMIENTO.Controls.Add(Me.BTNPRIMERO)
        Me.GRBDESPLAZAMIENTO.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBDESPLAZAMIENTO.Location = New System.Drawing.Point(49, 318)
        Me.GRBDESPLAZAMIENTO.Name = "GRBDESPLAZAMIENTO"
        Me.GRBDESPLAZAMIENTO.Size = New System.Drawing.Size(128, 168)
        Me.GRBDESPLAZAMIENTO.TabIndex = 81
        Me.GRBDESPLAZAMIENTO.TabStop = False
        Me.GRBDESPLAZAMIENTO.Text = "DESPLAZAMIENTO"
        '
        'BTNULTIMO
        '
        Me.BTNULTIMO.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNULTIMO.Location = New System.Drawing.Point(9, 115)
        Me.BTNULTIMO.Name = "BTNULTIMO"
        Me.BTNULTIMO.Size = New System.Drawing.Size(103, 24)
        Me.BTNULTIMO.TabIndex = 3
        Me.BTNULTIMO.Text = "ULTIMO"
        Me.BTNULTIMO.UseVisualStyleBackColor = True
        '
        'BTNSIGUIENTE
        '
        Me.BTNSIGUIENTE.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIGUIENTE.Location = New System.Drawing.Point(9, 85)
        Me.BTNSIGUIENTE.Name = "BTNSIGUIENTE"
        Me.BTNSIGUIENTE.Size = New System.Drawing.Size(103, 24)
        Me.BTNSIGUIENTE.TabIndex = 2
        Me.BTNSIGUIENTE.Text = "SIGUIENTE"
        Me.BTNSIGUIENTE.UseVisualStyleBackColor = True
        '
        'BTNANTERIOR
        '
        Me.BTNANTERIOR.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNANTERIOR.Location = New System.Drawing.Point(9, 55)
        Me.BTNANTERIOR.Name = "BTNANTERIOR"
        Me.BTNANTERIOR.Size = New System.Drawing.Size(103, 24)
        Me.BTNANTERIOR.TabIndex = 1
        Me.BTNANTERIOR.Text = "ANTERIOR"
        Me.BTNANTERIOR.UseVisualStyleBackColor = True
        '
        'BTNPRIMERO
        '
        Me.BTNPRIMERO.Font = New System.Drawing.Font("OCR-A BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPRIMERO.Location = New System.Drawing.Point(9, 25)
        Me.BTNPRIMERO.Name = "BTNPRIMERO"
        Me.BTNPRIMERO.Size = New System.Drawing.Size(103, 24)
        Me.BTNPRIMERO.TabIndex = 0
        Me.BTNPRIMERO.Text = "PRIMERO"
        Me.BTNPRIMERO.UseVisualStyleBackColor = True
        '
        'TXTFOTO
        '
        Me.TXTFOTO.Location = New System.Drawing.Point(449, 147)
        Me.TXTFOTO.Name = "TXTFOTO"
        Me.TXTFOTO.Size = New System.Drawing.Size(157, 20)
        Me.TXTFOTO.TabIndex = 89
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 498)
        Me.Controls.Add(Me.TXTFOTO)
        Me.Controls.Add(Me.GRBCONSULTAR)
        Me.Controls.Add(Me.BTNCONSULTAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.GRBDESPLAZAMIENTO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PTBFOTO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.igv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.umedida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.perecible)
        Me.Controls.Add(Me.fechavence)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PTBFOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBCONSULTAR.ResumeLayout(False)
        Me.GRBCONSULTAR.PerformLayout()
        Me.GRBDESPLAZAMIENTO.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents fechavence As System.Windows.Forms.DateTimePicker
    Friend WithEvents perecible As System.Windows.Forms.ComboBox
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents marca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents umedida As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents stock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents precio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents igv As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PTBFOTO As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GRBCONSULTAR As System.Windows.Forms.GroupBox
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents TXTBUSCAR As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents BTNCONSULTAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents GRBDESPLAZAMIENTO As System.Windows.Forms.GroupBox
    Friend WithEvents BTNULTIMO As System.Windows.Forms.Button
    Friend WithEvents BTNSIGUIENTE As System.Windows.Forms.Button
    Friend WithEvents BTNANTERIOR As System.Windows.Forms.Button
    Friend WithEvents BTNPRIMERO As System.Windows.Forms.Button
    Friend WithEvents TXTFOTO As System.Windows.Forms.TextBox

End Class
