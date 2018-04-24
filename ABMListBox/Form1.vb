
'espacio de nombre
Imports System.Xml

Imports System.IO
Public Class Form1
    Dim mayu As Boolean = False
    Dim alfa As Boolean = False
    Dim enumerado As Boolean = False



    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click

        'toma el foco en text.box1
        'toma el foco de nuevo en textbox1
        TextBox1.Focus()
        If TextBox1.Text.Trim = "" Then Exit Sub


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

        ListBox1.ClearSelected()

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

        ListBox1.ClearSelected()
        TextBox1.Clear()


    End Sub

    Private Sub enumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enumerar.Click
        Dim x As Integer
        'si esta enumerado no lo deja enumerar de nuevo o alfavetizar
        If enumerado Or alfa Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = CStr(x) + "-" + ListBox1.Items.Item(x).ToString

        Next
        TextBox1.Focus()

        enumerado = True
    End Sub


    Private Sub alfabetizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alfabetizar.Click

        Dim x As Integer
        'si esta alfabetisar no lo deja de nuevo o enumerar
        If alfa Or enumerado Then Exit Sub
        'chr pasa alfavetisar a partir de a
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = Chr(x + 65) + "-" + ListBox1.Items.Item(x).ToString

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


        mayu = True
        TextBox1.Focus()
    End Sub


    Private Sub quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitar.Click
        Dim x, g As Integer
        For x = 0 To ListBox1.Items.Count - 1
            'g obtiene el numero de columna donde esta el guion
            g = ListBox1.Items.Item(x).ToString.IndexOf("-")
            'debuelve a partir de g mas 1 hasta el final      recorta a partir de substring
            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).substring(g + 1).ToString.ToLower
        Next
        TextBox1.Focus()

        enumerado = False
        alfa = False
        mayu = True
    End Sub

    Private Sub grabarXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabarXml.Click

        Dim ruta As String
        ruta = CurDir.Substring(0, CurDir.Length - 9)
        Dim escritor As New XmlTextWriter(ruta + "lista.xml", System.Text.Encoding.UTF8)
        escritor.WriteStartDocument(True)
        escritor.Formatting = Formatting.Indented
        'tabulacion (es como una sangria)
        escritor.Indentation = (4)
        escritor.WriteStartElement("lista")
        Dim x As Integer
        For x = 0 To ListBox1.Items.Count - 1
            escritor.WriteStartElement("elemento")
            escritor.WriteString(ListBox1.Items.Item(x).ToString)
            escritor.WriteEndElement()
        Next
        escritor.WriteEndElement()
        escritor.WriteEndDocument()
        escritor.Close()

        MsgBox("guardado correctamente")
        TextBox1.Focus()
    End Sub

    Private Sub leer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leer.Click
        Dim xmld As New XmlDocument
        Dim listanodos As XmlNodeList
        Dim nodo As XmlNode
        Dim ruta As String
        ruta = CurDir().Substring(0, CurDir().Length - 9)
        If Not File.Exists(ruta + "lista.xml") Then Exit Sub
        xmld.Load(ruta + "lista.xml")
        listanodos = xmld.SelectNodes("lista/elemento")
        For Each nodo In listanodos
            ListBox1.Items.Add(nodo.InnerText)

        Next
        TextBox1.Focus()
    End Sub
End Class
