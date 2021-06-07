Public Class validacion
    Public Sub letras(ByVal dato As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef otro As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If (a = 13) Then
            If dato.Text = "" Then
                MsgBox("DEBE LLENARSE DATOS")
                dato.Focus()
            Else
                otro.Focus()
            End If
        Else
            If Not (a >= 65 And a <= 90 Or a >= 97 And a <= 122 Or a >= 200 And a <= 250 Or a = 8 Or a = 32 Or a = 46) Then
                e.Handled = True

            End If
        End If

    End Sub
    Public Sub numeros(ByVal dato As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef otro As TextBox)

        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If dato.Text = "" Then
                MsgBox("debe ingresar datos")
                dato.Focus()
            Else
                otro.Focus()
            End If
        Else
            If Not (a >= 48 And a <= 57 Or a = 8 Or a = 47 Or a = 46) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub mixto(ByVal dato As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef otro As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If dato.Text = "" Then
                MsgBox("DEBE LLENARSE DATOS")
                dato.Focus()
            Else
                otro.Focus()
            End If

        Else
            If Not (a <= 18 Or a >= 48 And a <= 57 Or a >= 65 And a <= 90 Or a >= 97 And a <= 122 Or a >= 200 And a <= 250 Or a = 8 Or a = 32 Or a = 46) Then


                e.Handled = True

            End If
        End If
    End Sub
    Public Sub deciml(ByVal dato As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef otro As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If dato.Text = "" Then
                MsgBox("DEBE LLENARSE DATOS")
                dato.Focus()
            Else
                otro.Focus()
            End If
        Else
            If a = 46 Then
                If InStr(dato.Text, ".") >= 1 Then
                    e.Handled = True

                End If

                If Not (a >= 48 And a <= 57 Or a = 8 Or a = 47 Or a = 46) Then

                    e.Handled = True
                End If
            End If
        End If
    End Sub
    Public Sub fech(ByVal dato As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef otro As DateTimePicker)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If dato.Text = "" Then
                MsgBox("DEBE LLENARSE DATOS")
                dato.Focus()
            Else
                otro.Focus()
            End If
        Else
            If a = 46 Then
                If InStr(dato.Text, ".") >= 1 Then
                    e.Handled = True

                End If

                If Not (a >= 48 And a <= 57 Or a = 8 Or a = 47 Or a = 46) Then

                    e.Handled = True
                End If
            End If
        End If
    End Sub
  
    Public Sub combo(ByVal dato As DateTimePicker, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef otro As ComboBox)

    End Sub
End Class

