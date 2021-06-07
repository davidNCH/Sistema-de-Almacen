
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Text
'Imports System.IO

Public Class Form1
    '    Inherits System.Windows.Forms.Form
    Dim llama As New validacion
    '    Dim Cn As New SqlConnection("Data Source=.;Initial Catalog=planilla;Integrated Security=True")
    '    'Private Cn As New SqlConnection("Data Source= LABXX-XX ;Initial Catalog=planilla;Integrated Security=True")
    '    ' Private Cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\visual studio\ALMACEN\ALMACEN.mdf;integrated security=true;Connect Timeout=30;User instance=true")
    '    Private cmd As New SqlCommand("", Cn)
    '    Private stb As New StringBuilder()
    '    Private adaptador As SqlDataAdapter
    '    Private data As DataSet
    '    Private Fila As Integer
    '    Public reg, I As Integer
    '    Dim dvw As New DataView
    '    Private pc As String

    '    Sub CONTROLA()
    '        Data = New DataSet()
    '        Cn.Open()
    '        adaptador.Fill(data, "ALMACEN")
    '        Cn.Close()
    '    End Sub
    '    Sub ACTIVA()
    '        Dim X As Control
    '        For Each X In Controls
    '            If TypeOf X Is TextBox Then
    '                X.Enabled = True
    '            End If
    '        Next
    '        perecible.Enabled = True
    '        fechavence.Enabled = True

    '    End Sub
    '    Sub DESACTIVA()
    '        Dim X As Control
    '        For Each X In Controls
    '            If TypeOf X Is TextBox Then
    '                X.Enabled = False
    '            End If
    '        Next

    '        perecible.Enabled = False
    '        fechavence.Enabled = False
    '    End Sub
    '    Sub CUANDOLEE()
    '        BTNNUEVO.Enabled = True
    '        BTNCANCELAR.Enabled = False
    '        BTNELIMINAR.Enabled = True
    '        BTNMODIFICAR.Enabled = True
    '        BTNGUARDAR.Enabled = False
    '        BTNCONSULTAR.Enabled = True
    '        GRBDESPLAZAMIENTO.Enabled = True
    '    End Sub
    '    Sub CUANDOINGRESA()
    '        BTNNUEVO.Enabled = False
    '        BTNCANCELAR.Enabled = True
    '        BTNELIMINAR.Enabled = False
    '        BTNMODIFICAR.Enabled = False
    '        BTNGUARDAR.Enabled = True
    '        BTNCONSULTAR.Enabled = False
    '        GRBDESPLAZAMIENTO.Enabled = False
    '    End Sub
    '    Sub CARGARDATOS()
    '        Dim oDataRow As DataRow
    '        oDataRow = data.Tables("ALMACEN").Rows(Fila)
    '        codigo.Text = oDataRow("CODIGO")
    '        descripcion.Text = oDataRow("DESCRIPCION")
    '        marca.Text = oDataRow("MARCA")
    '        umedida.Text = oDataRow("MEDIDA")
    '        stock.Text = oDataRow("STOCK")
    '        precio.Text = oDataRow("PRECIO")
    '        igv.Text = oDataRow("IGV")
    '        total.Text = oDataRow("TOTAL")
    '        fechavence.Text = oDataRow("FECHAVENCE")
    '        perecible.Text = oDataRow("PERECIBLE")
    '        TXTFOTO.Text = oDataRow("FOTO")
    '        PTBFOTO.Image = System.Drawing.Image.FromFile("G:\visual studio\almacen\img\" + TXTFOTO.Text + ".JPG")
    '    End Sub

    '    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        Dim Cmd As New SqlCommand("select getdate()", Cn)
    '        adaptador = New SqlDataAdapter("SELECT * FROM ALMACEN", Cn)
    '        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
    '        CONTROLA()
    '        dvw = data.Tables(0).DefaultView()
    '        Dim X As Control
    '        For Each X In Controls
    '            If TypeOf X Is TextBox Then
    '                X.Text = ""
    '            End If
    '        Next
    '        Fila = 0
    '        CARGARDATOS()
    '        DESACTIVA()
    '        CUANDOLEE()
    '        BTNPRIMERO.Focus()

    '    End Sub

    '    Private Sub BTNPRIMERO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNPRIMERO.Click
    '        Fila = 0
    '        CARGARDATOS()
    '    End Sub

    '    Private Sub BTNANTERIOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNANTERIOR.Click
    '        If Fila = 0 Then
    '            MessageBox.Show("Primer Registro")
    '        Else
    '            Fila -= 1
    '            CARGARDATOS()
    '        End If
    '    End Sub

    '    Private Sub BTNSIGUIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSIGUIENTE.Click
    '        If Fila = (data.Tables("ALMACEN").Rows.Count - 1) Then
    '            MessageBox.Show("Ultimo Registro")
    '        Else
    '            Fila += 1
    '            CARGARDATOS()
    '        End If
    '    End Sub

    '    Private Sub BTNULTIMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNULTIMO.Click
    '        Fila = (data.Tables("ALMACEN").Rows.Count - 1)
    '        CARGARDATOS()
    '    End Sub


    '    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
    '        Dim FEC, val As String
    '        If perecible.SelectedValue = True Then
    '            val = "SI"
    '        Else
    '            val = "NO"
    '        End If
    '        FEC = fechavence.Value.Date
    '        If I = 1 Then
    '            If codigo.Text <> "" And descripcion.Text <> "" And marca.Text <> "" And umedida.Text <> "" And stock.Text <> "" And precio.Text <> "" And igv.Text <> "" And total.Text <> "" And TXTFOTO.Text <> "" And perecible.Text <> "" And fechavence.Text <> "" Then
    '                Try
    '                    stb.Length = 0
    '                    stb.Append("Insert Into ALMACEN (CODIGO , DESCRIPCION, MARCA, STOCK, PRECIO, IGV, TOTAL) Values ('")
    '                    stb.Append(codigo.Text)
    '                    stb.Append("','")
    '                    stb.Append(descripcion.Text)
    '                    stb.Append("','")
    '                    stb.Append(marca.Text)
    '                    stb.Append("','")
    '                    stb.Append(umedida.Text)
    '                    stb.Append("','")
    '                    stb.Append(stock.Text)
    '                    stb.Append("','")
    '                    stb.Append(precio.Text)
    '                    stb.Append("','")
    '                    stb.Append(igv)
    '                    stb.Append("','")
    '                    stb.Append(total)
    '                    stb.Append("','")
    '                    stb.Append(fechavence.Text)
    '                    stb.Append("','")
    '                    stb.Append(perecible.Text)
    '                    stb.Append("','")
    '                    stb.Append(TXTFOTO.Text)
    '                    stb.Append("')")
    '                    Cn.Open()
    '                    cmd.CommandText = stb.ToString
    '                    reg = cmd.ExecuteNonQuery()
    '                    If reg > 0 Then
    '                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
    '                    Else
    '                        Throw New Exception("No se Pudo Guardar los Datos de la Persona")
    '                    End If
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Finally
    '                    If Cn.State = ConnectionState.Open Then Cn.Close()
    '                    stb.Length = 0
    '                    CONTROLA()
    '                    Fila = 0
    '                    CARGARDATOS()
    '                    DESACTIVA()
    '                    CUANDOLEE()
    '                    BTNPRIMERO.Focus()
    '                End Try
    '            End If
    '        Else
    '            If codigo.Text <> "" And descripcion.Text <> "" And marca.Text <> "" And stock.Text <> "" And precio.Text <> "" And igv.Text <> "" And total.Text <> "" And fechavence.Text <> "" And perecible.Text <> "" Then
    '                Try
    '                    stb.Length = 0
    '                    stb.Append("Update ALMACEN set CODIGO='")
    '                    stb.Append(codigo.Text)
    '                    stb.Append("',DESCRIPCION='")
    '                    stb.Append(descripcion.Text)
    '                    stb.Append("',MARCA='")
    '                    stb.Append(marca.Text)
    '                    stb.Append("', MEDIDA='")
    '                    stb.Append(umedida.Text)
    '                    stb.Append("',STOCK='")
    '                    stb.Append(stock.Text)
    '                    stb.Append("',PRECIO='")
    '                    stb.Append(precio.Text)
    '                    stb.Append("',IGV='")
    '                    stb.Append(igv.Text)
    '                    stb.Append("',TOTAL='")
    '                    stb.Append(total.Text)
    '                    stb.Append("',FECHAVENCE='")
    '                    stb.Append(fechavence.Text)
    '                    stb.Append("',PERECIBLE='")
    '                    stb.Append(perecible.Text)
    '                    stb.Append("',FOTO='")
    '                    stb.Append(TXTFOTO.Text)
    '                    stb.Append("'")
    '                    Cn.Open()
    '                    cmd.CommandText = stb.ToString
    '                    reg = cmd.ExecuteNonQuery()
    '                    If reg > 0 Then
    '                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
    '                    Else
    '                        Throw New Exception("No se Pudo Guardar los Datos de la Persona")
    '                    End If
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Finally
    '                    If Cn.State = ConnectionState.Open Then Cn.Close()
    '                    stb.Length = 0
    '                    CONTROLA()
    '                    Fila = 0
    '                    CARGARDATOS()
    '                    DESACTIVA()
    '                    CUANDOLEE()
    '                    BTNPRIMERO.Focus()
    '                End Try
    '            End If
    '        End If
    '    End Sub


    '    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
    '        Dim NUM As Integer
    '        Dim X As Control
    '        For Each X In Controls
    '            If TypeOf X Is TextBox Then
    '                X.Text = ""
    '            End If
    '        Next
    '        I = 1
    '        fechavence.Text = "Seleccione"
    '        perecible.Text = "seleccione"
    '        PTBFOTO.Image = System.Drawing.Image.FromFile("G:\visual studio\almacen\img\" + "000" + ".JPG")
    '        ACTIVA()
    '        CUANDOINGRESA()
    '        NUM = data.Tables("ALMACEN").Rows.Count
    '        NUM = NUM + 1
    '        codigo.Text = "P" + NUM.ToString("0000")
    '        codigo.ReadOnly = True
    '        descripcion.Focus()
    '    End Sub

    '    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
    '        I = 2
    '        ACTIVA()
    '        CUANDOINGRESA()
    '        descripcion.Focus()
    '    End Sub

    '    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
    '        Fila = 0
    '        CARGARDATOS()
    '        DESACTIVA()
    '        CUANDOLEE()
    '        BTNPRIMERO.Focus()
    '    End Sub

    '    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
    '        Dim oDataRow As DataRow
    '        oDataRow = data.Tables("ALMACEN").Rows(Fila)
    '        If MessageBox.Show("Desea Eliminar el Registro", "ALMACEN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
    '            oDataRow.Delete()
    '            Dim oTablaBorrados As DataTable
    '            oTablaBorrados = data.Tables("ALMACEN").GetChanges(DataRowState.Deleted)
    '            adaptador.Update(oTablaBorrados)
    '            data.Tables("ALMACEN").AcceptChanges()
    '            BTNPRIMERO.PerformClick()
    '            Exit Sub
    '        End If
    '        CONTROLA()
    '    End Sub

    '    Private Sub BTNCONSULTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCONSULTAR.Click
    '        GRBCONSULTAR.Visible = True
    '        TXTBUSCAR.Focus()
    '    End Sub

    '    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
    '        Dim X As Integer
    '        Fila = 0
    '        Dim oDataRow As DataRow
    '        Do While Fila <= (data.Tables("ALMACEN").Rows.Count - 1)
    '            oDataRow = data.Tables("ALMACEN").Rows(Fila)
    '            If TXTBUSCAR.Text = oDataRow("CODIGO") Then
    '                X = 1
    '                CARGARDATOS()
    '                Exit Do
    '            End If
    '            Fila += 1
    '        Loop
    '        If X = 0 Then
    '            MessageBox.Show("No Existe el Código Indicado")
    '        End If
    '        GRBCONSULTAR.Visible = False
    '        BTNPRIMERO.Focus()
    '    End Sub





    'Function existeusuario(ByVal usuario As String, ByVal pasword As String) As Boolean
    '    Dim conexion As New MySqlConnection
    '    Dim odataadapter As mysqldataadapter
    '    Dim odataset As New dataset
    '    Dim osql As String
    '    Dim sw As Boolean = False

    '    Try

    '        conexion.connectionstring = "server=localhost; database=almacen;user id=root ; password=;"
    '        osql = "select *from almacen where 1;"
    '        conexion.open()
    '        odataadapter = New mysqldataAdapter(osql, conexion)
    '        odataset.clear()
    '        odataadapter.fill(odataset, "almacen")
    '        If (odataset.Tables("almacen").Rows.Count() <> 0) Then


    '            MessageBox.Show("bienvenido al sistema")
    '            sw = True
    '        ElseIf ("no se conecto") Then
    '            sw = False
    '        End If
    '    Catch ex As Exception

    '    End Try


    '    Return (sw)

    'End Function






    Private Sub codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codigo.KeyPress
        llama.mixto(codigo, e, descripcion)
    End Sub

    Private Sub descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles descripcion.KeyPress
        llama.mixto(descripcion, e, marca)
    End Sub

    Private Sub marca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles marca.KeyPress
        llama.letras(marca, e, umedida)
    End Sub

    Private Sub umedida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles umedida.KeyPress
        llama.letras(umedida, e, stock)
    End Sub

    Private Sub stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stock.KeyPress
        llama.numeros(stock, e, precio)

    End Sub

    Private Sub precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles precio.KeyPress

        llama.numeros(precio, e, igv)
        igv.Text = Val(stock.Text) * 0.18

        total.Text = Val(stock.Text) * Val(precio.Text) + igv.Text

    End Sub
    Private Sub igv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles igv.KeyPress
        llama.numeros(igv, e, total)
    End Sub

    Private Sub total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles total.KeyPress
        llama.numeros(total, e, total)

    End Sub

    Private Sub fechavence_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fechavence.KeyPress
        llama.combo(fechavence, e, perecible)
    End Sub
    Private Sub perecible_GotFocus(sender As Object, e As EventArgs) Handles perecible.GotFocus
        perecible.Items.Clear()
        perecible.Items.Add("SI")
        perecible.Items.Add("NO")
    End Sub

End Class
