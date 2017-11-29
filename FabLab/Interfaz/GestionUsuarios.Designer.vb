<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FiltrarUsuariosTextBox = New System.Windows.Forms.TextBox()
        Me.NuevoUsuarioButton = New System.Windows.Forms.Button()
        Me.ConsultarUsuarioButton = New System.Windows.Forms.Button()
        Me.EditarUsuarioButton = New System.Windows.Forms.Button()
        Me.EliminarUsuarioButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 329)
        Me.DataGridView1.TabIndex = 0
        '
        'FiltrarUsuariosTextBox
        '
        Me.FiltrarUsuariosTextBox.Location = New System.Drawing.Point(12, 21)
        Me.FiltrarUsuariosTextBox.Name = "FiltrarUsuariosTextBox"
        Me.FiltrarUsuariosTextBox.Size = New System.Drawing.Size(158, 20)
        Me.FiltrarUsuariosTextBox.TabIndex = 1
        '
        'NuevoUsuarioButton
        '
        Me.NuevoUsuarioButton.Location = New System.Drawing.Point(707, 21)
        Me.NuevoUsuarioButton.Name = "NuevoUsuarioButton"
        Me.NuevoUsuarioButton.Size = New System.Drawing.Size(105, 23)
        Me.NuevoUsuarioButton.TabIndex = 2
        Me.NuevoUsuarioButton.Text = "Nuevo usuario"
        Me.NuevoUsuarioButton.UseVisualStyleBackColor = True
        '
        'ConsultarUsuarioButton
        '
        Me.ConsultarUsuarioButton.Location = New System.Drawing.Point(575, 405)
        Me.ConsultarUsuarioButton.Name = "ConsultarUsuarioButton"
        Me.ConsultarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.ConsultarUsuarioButton.TabIndex = 3
        Me.ConsultarUsuarioButton.Text = "Consultar"
        Me.ConsultarUsuarioButton.UseVisualStyleBackColor = True
        '
        'EditarUsuarioButton
        '
        Me.EditarUsuarioButton.Location = New System.Drawing.Point(656, 405)
        Me.EditarUsuarioButton.Name = "EditarUsuarioButton"
        Me.EditarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.EditarUsuarioButton.TabIndex = 4
        Me.EditarUsuarioButton.Text = "Editar"
        Me.EditarUsuarioButton.UseVisualStyleBackColor = True
        '
        'EliminarUsuarioButton
        '
        Me.EliminarUsuarioButton.Location = New System.Drawing.Point(737, 405)
        Me.EliminarUsuarioButton.Name = "EliminarUsuarioButton"
        Me.EliminarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarUsuarioButton.TabIndex = 5
        Me.EliminarUsuarioButton.Text = "Eliminar"
        Me.EliminarUsuarioButton.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.EliminarUsuarioButton)
        Me.Controls.Add(Me.EditarUsuarioButton)
        Me.Controls.Add(Me.ConsultarUsuarioButton)
        Me.Controls.Add(Me.NuevoUsuarioButton)
        Me.Controls.Add(Me.FiltrarUsuariosTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "GestionUsuarios"
        Me.Text = "GestionUsuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FiltrarUsuariosTextBox As TextBox
    Friend WithEvents NuevoUsuarioButton As Button
    Friend WithEvents ConsultarUsuarioButton As Button
    Friend WithEvents EditarUsuarioButton As Button
    Friend WithEvents EliminarUsuarioButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
