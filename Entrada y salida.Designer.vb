<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada_y_salida
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalidaRg = New System.Windows.Forms.Button()
        Me.btnEntrarRg = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAtras)
        Me.GroupBox1.Controls.Add(Me.btnSalidaRg)
        Me.GroupBox1.Controls.Add(Me.btnEntrarRg)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(427, 426)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reguistro Entrada y Salida"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(345, 382)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalidaRg
        '
        Me.btnSalidaRg.Location = New System.Drawing.Point(216, 148)
        Me.btnSalidaRg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalidaRg.Name = "btnSalidaRg"
        Me.btnSalidaRg.Size = New System.Drawing.Size(129, 23)
        Me.btnSalidaRg.TabIndex = 1
        Me.btnSalidaRg.Text = "Salida"
        Me.btnSalidaRg.UseVisualStyleBackColor = True
        '
        'btnEntrarRg
        '
        Me.btnEntrarRg.Location = New System.Drawing.Point(27, 148)
        Me.btnEntrarRg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEntrarRg.Name = "btnEntrarRg"
        Me.btnEntrarRg.Size = New System.Drawing.Size(129, 23)
        Me.btnEntrarRg.TabIndex = 0
        Me.btnEntrarRg.Text = "Entrada"
        Me.btnEntrarRg.UseVisualStyleBackColor = True
        '
        'Entrada_y_salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Entrada_y_salida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada y salida"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSalidaRg As Button
    Friend WithEvents btnEntrarRg As Button
End Class
