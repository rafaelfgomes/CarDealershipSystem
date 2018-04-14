<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.pbLoginLogo = New System.Windows.Forms.PictureBox()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.gbLoginHeader = New System.Windows.Forms.GroupBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.pbLoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLoginHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLoginLogo
        '
        Me.pbLoginLogo.Location = New System.Drawing.Point(6, 0)
        Me.pbLoginLogo.Name = "pbLoginLogo"
        Me.pbLoginLogo.Size = New System.Drawing.Size(94, 94)
        Me.pbLoginLogo.TabIndex = 0
        Me.pbLoginLogo.TabStop = False
        '
        'lblLoginTitle
        '
        Me.lblLoginTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginTitle.Location = New System.Drawing.Point(106, 0)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New System.Drawing.Size(272, 94)
        Me.lblLoginTitle.TabIndex = 1
        Me.lblLoginTitle.Text = "Acessar o Sistema"
        Me.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbLoginHeader
        '
        Me.gbLoginHeader.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbLoginHeader.Controls.Add(Me.pbLoginLogo)
        Me.gbLoginHeader.Controls.Add(Me.lblLoginTitle)
        Me.gbLoginHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbLoginHeader.Location = New System.Drawing.Point(0, 0)
        Me.gbLoginHeader.Name = "gbLoginHeader"
        Me.gbLoginHeader.Size = New System.Drawing.Size(384, 100)
        Me.gbLoginHeader.TabIndex = 2
        Me.gbLoginHeader.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUserName.Location = New System.Drawing.Point(12, 132)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(130, 46)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Usuário:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserPassword
        '
        Me.lblUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUserPassword.Location = New System.Drawing.Point(12, 178)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(130, 46)
        Me.lblUserPassword.TabIndex = 2
        Me.lblUserPassword.Text = "Senha:"
        Me.lblUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Location = New System.Drawing.Point(148, 144)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(162, 23)
        Me.txtUserName.TabIndex = 0
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserPassword.Location = New System.Drawing.Point(148, 190)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtUserPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(145, 247)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(109, 35)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Acessar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 315)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.gbLoginHeader)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acessar"
        CType(Me.pbLoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLoginHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLoginLogo As PictureBox
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents gbLoginHeader As GroupBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserPassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtUserPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
