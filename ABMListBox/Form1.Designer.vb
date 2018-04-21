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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Alta = New System.Windows.Forms.Button
        Me.Baja = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.enumerar = New System.Windows.Forms.Button
        Me.alfabetizar = New System.Windows.Forms.Button
        Me.mayusculas = New System.Windows.Forms.Button
        Me.quitar = New System.Windows.Forms.Button
        Me.grabarXml = New System.Windows.Forms.Button
        Me.leer = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(179, 199)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(197, 46)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(75, 21)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Baja
        '
        Me.Baja.Location = New System.Drawing.Point(197, 73)
        Me.Baja.Name = "Baja"
        Me.Baja.Size = New System.Drawing.Size(75, 23)
        Me.Baja.TabIndex = 2
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(197, 102)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(75, 23)
        Me.modificar.TabIndex = 3
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'enumerar
        '
        Me.enumerar.Location = New System.Drawing.Point(197, 131)
        Me.enumerar.Name = "enumerar"
        Me.enumerar.Size = New System.Drawing.Size(75, 23)
        Me.enumerar.TabIndex = 4
        Me.enumerar.Text = "enumerar"
        Me.enumerar.UseVisualStyleBackColor = True
        '
        'alfabetizar
        '
        Me.alfabetizar.Location = New System.Drawing.Point(197, 158)
        Me.alfabetizar.Name = "alfabetizar"
        Me.alfabetizar.Size = New System.Drawing.Size(75, 23)
        Me.alfabetizar.TabIndex = 5
        Me.alfabetizar.Text = "alfabetizar"
        Me.alfabetizar.UseVisualStyleBackColor = True
        '
        'mayusculas
        '
        Me.mayusculas.Location = New System.Drawing.Point(197, 187)
        Me.mayusculas.Name = "mayusculas"
        Me.mayusculas.Size = New System.Drawing.Size(75, 23)
        Me.mayusculas.TabIndex = 6
        Me.mayusculas.Text = "mayusculas"
        Me.mayusculas.UseVisualStyleBackColor = True
        '
        'quitar
        '
        Me.quitar.Location = New System.Drawing.Point(197, 214)
        Me.quitar.Name = "quitar"
        Me.quitar.Size = New System.Drawing.Size(75, 23)
        Me.quitar.TabIndex = 7
        Me.quitar.Text = "quitar "
        Me.quitar.UseVisualStyleBackColor = True
        '
        'grabarXml
        '
        Me.grabarXml.Location = New System.Drawing.Point(12, 273)
        Me.grabarXml.Name = "grabarXml"
        Me.grabarXml.Size = New System.Drawing.Size(75, 23)
        Me.grabarXml.TabIndex = 8
        Me.grabarXml.Text = "grabarXml"
        Me.grabarXml.UseVisualStyleBackColor = True
        '
        'leer
        '
        Me.leer.Location = New System.Drawing.Point(116, 273)
        Me.leer.Name = "leer"
        Me.leer.Size = New System.Drawing.Size(75, 23)
        Me.leer.TabIndex = 9
        Me.leer.Text = "leer"
        Me.leer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 308)
        Me.Controls.Add(Me.leer)
        Me.Controls.Add(Me.grabarXml)
        Me.Controls.Add(Me.quitar)
        Me.Controls.Add(Me.mayusculas)
        Me.Controls.Add(Me.alfabetizar)
        Me.Controls.Add(Me.enumerar)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents Baja As System.Windows.Forms.Button
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents enumerar As System.Windows.Forms.Button
    Friend WithEvents alfabetizar As System.Windows.Forms.Button
    Friend WithEvents mayusculas As System.Windows.Forms.Button
    Friend WithEvents quitar As System.Windows.Forms.Button
    Friend WithEvents grabarXml As System.Windows.Forms.Button
    Friend WithEvents leer As System.Windows.Forms.Button

End Class
