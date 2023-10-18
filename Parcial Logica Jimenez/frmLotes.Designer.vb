<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textAncho = New System.Windows.Forms.TextBox()
        Me.textLargo = New System.Windows.Forms.TextBox()
        Me.btnCalcularLotes = New System.Windows.Forms.Button()
        Me.textLotesFinal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar Largo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingresar Ancho"
        '
        'textAncho
        '
        Me.textAncho.Location = New System.Drawing.Point(264, 103)
        Me.textAncho.Name = "textAncho"
        Me.textAncho.Size = New System.Drawing.Size(100, 23)
        Me.textAncho.TabIndex = 2
        '
        'textLargo
        '
        Me.textLargo.Location = New System.Drawing.Point(264, 39)
        Me.textLargo.Name = "textLargo"
        Me.textLargo.Size = New System.Drawing.Size(100, 23)
        Me.textLargo.TabIndex = 3
        '
        'btnCalcularLotes
        '
        Me.btnCalcularLotes.Location = New System.Drawing.Point(453, 68)
        Me.btnCalcularLotes.Name = "btnCalcularLotes"
        Me.btnCalcularLotes.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcularLotes.TabIndex = 4
        Me.btnCalcularLotes.Text = "Calcular"
        Me.btnCalcularLotes.UseVisualStyleBackColor = True
        '
        'textLotesFinal
        '
        Me.textLotesFinal.Location = New System.Drawing.Point(207, 233)
        Me.textLotesFinal.Name = "textLotesFinal"
        Me.textLotesFinal.Size = New System.Drawing.Size(216, 23)
        Me.textLotesFinal.TabIndex = 5
        '
        'frmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 330)
        Me.Controls.Add(Me.textLotesFinal)
        Me.Controls.Add(Me.btnCalcularLotes)
        Me.Controls.Add(Me.textLargo)
        Me.Controls.Add(Me.textAncho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textAncho As TextBox
    Friend WithEvents textLargo As TextBox
    Friend WithEvents btnCalcularLotes As Button
    Friend WithEvents textLotesFinal As TextBox
End Class
