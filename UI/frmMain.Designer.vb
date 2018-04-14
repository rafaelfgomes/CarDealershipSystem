<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogin})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mainMenu.Size = New System.Drawing.Size(726, 24)
        Me.mainMenu.TabIndex = 1
        Me.mainMenu.Text = "MenuStrip1"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.Size = New System.Drawing.Size(49, 20)
        Me.menuLogin.Text = "Login"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 389)
        Me.Controls.Add(Me.mainMenu)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cozema Concessionária"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents menuLogin As ToolStripMenuItem
End Class
