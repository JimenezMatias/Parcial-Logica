<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambio
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
        Me.textPesos = New System.Windows.Forms.TextBox()
        Me.textCotizacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textDolaresFinal = New System.Windows.Forms.TextBox()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar Capital en Pesos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingresar Cotizacion del Dolar"
        '
        'textPesos
        '
        Me.textPesos.Location = New System.Drawing.Point(276, 48)
        Me.textPesos.Name = "textPesos"
        Me.textPesos.Size = New System.Drawing.Size(100, 23)
        Me.textPesos.TabIndex = 2
        '
        'textCotizacion
        '
        Me.textCotizacion.Location = New System.Drawing.Point(276, 109)
        Me.textCotizacion.Name = "textCotizacion"
        Me.textCotizacion.Size = New System.Drawing.Size(100, 23)
        Me.textCotizacion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dolares Totales"
        '
        'textDolaresFinal
        '
        Me.textDolaresFinal.Location = New System.Drawing.Point(276, 244)
        Me.textDolaresFinal.Name = "textDolaresFinal"
        Me.textDolaresFinal.Size = New System.Drawing.Size(100, 23)
        Me.textDolaresFinal.TabIndex = 5
        '
        'btnCambio
        '
        Me.btnCambio.Location = New System.Drawing.Point(194, 163)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(75, 23)
        Me.btnCambio.TabIndex = 6
        Me.btnCambio.Text = "Calcular"
        Me.btnCambio.UseVisualStyleBackColor = True
        '
        'frmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 369)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.textDolaresFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textCotizacion)
        Me.Controls.Add(Me.textPesos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textPesos As TextBox
    Friend WithEvents textCotizacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textDolaresFinal As TextBox
    Friend WithEvents btnCambio As Button
End Class
