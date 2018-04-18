Public Class Form1
    Dim mayu As Boolean = False
    Dim alfa As Boolean = False
    Dim enumerado As Boolean = False


    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click

        'toma el foco en text.box1
        TextBox1.Focus()
        If TextBox1.Text.Trim = "" Then
            'toma el foco de nuevo en textbox1


            Exit Sub
        End If

        'quita los blancos del comienzo
        TextBox1.Text.Trim()

        'escribe lo del texxbox1
        ListBox1.Items.Add(TextBox1.Text.Trim)
        'limpiar
        TextBox1.Clear()

    End Sub

    Private Sub Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baja.Click
        TextBox1.Focus()
        'control de esexion(sin seleccion de lista)
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        'borra la fila del listbox1
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

        TextBox1.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        TextBox1.Focus()
        'control de esexion(sin seleccion de lista)
        If ListBox1.SelectedIndex = -1 Then Exit Sub

        'graba lo que seleccionamos en el listbox
        TextBox1.Text = ListBox1.Items.Item(ListBox1.SelectedIndex)


    End Sub


    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click

        TextBox1.Focus()
        'control de esexion(sin seleccion de lista)
        If ListBox1.SelectedIndex = -1 Then Exit Sub

        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text

        TextBox1.Clear()


    End Sub

    Private Sub enumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enumerar.Click
        Dim x As Integer
        'si esta enumerado no lo deja enumerar de nuevo
        If enumerado Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = CStr(x) + " " + ListBox1.Items.Item(x).ToString

        Next
        TextBox1.Focus()

        enumerado = True
    End Sub


    Private Sub alfabetizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alfabetizar.Click

        Dim x As Integer
        'si esta alfabetisar no lo deja de nuevo
        If alfa Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = Chr(x + 65) + " " + ListBox1.Items.Item(x).ToString

        Next
        TextBox1.Focus()

        alfa = True
    End Sub

    Private Sub mayusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mayusculas.Click
        Dim x As Integer
        'si esta mayuscula no lo deja  de nuevo
        If mayu Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).ToString.ToUpper



        Next
        TextBox1.Focus()

        mayu = True
    End Sub
End Class
