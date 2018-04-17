Public Class Form1

   
    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click

        'toma el foco en text.box1
        TextBox1.Focus()
        If TextBox1.Text.Trim = "" Then
            'toma el foco de nuevo en textbox1


            Exit Sub
        End If

        'quita los blancos del comienzo
        TextBox1.Text.Trim()
        'quita los blancos de atras
        TextBox1.Text.TrimEnd()
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
End Class
