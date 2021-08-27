<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rbtFeminino = New System.Windows.Forms.RadioButton()
        Me.rbtMasculino = New System.Windows.Forms.RadioButton()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(41, 53)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(43, 15)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(90, 50)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(200, 23)
        Me.txtNome.TabIndex = 1
        '
        'rbtFeminino
        '
        Me.rbtFeminino.AutoSize = True
        Me.rbtFeminino.Location = New System.Drawing.Point(21, 31)
        Me.rbtFeminino.Name = "rbtFeminino"
        Me.rbtFeminino.Size = New System.Drawing.Size(75, 19)
        Me.rbtFeminino.TabIndex = 2
        Me.rbtFeminino.TabStop = True
        Me.rbtFeminino.Text = "Feminino"
        Me.rbtFeminino.UseVisualStyleBackColor = True
        '
        'rbtMasculino
        '
        Me.rbtMasculino.AutoSize = True
        Me.rbtMasculino.Location = New System.Drawing.Point(134, 31)
        Me.rbtMasculino.Name = "rbtMasculino"
        Me.rbtMasculino.Size = New System.Drawing.Size(80, 19)
        Me.rbtMasculino.TabIndex = 3
        Me.rbtMasculino.TabStop = True
        Me.rbtMasculino.Text = "Masculino"
        Me.rbtMasculino.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Text = "NotifyIcon2"
        Me.NotifyIcon2.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtMasculino)
        Me.GroupBox1.Controls.Add(Me.rbtFeminino)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 67)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo:"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(41, 199)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(41, 15)
        Me.lblCurso.TabIndex = 5
        Me.lblCurso.Text = "Curso:"
        '
        'cbxCurso
        '
        Me.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Items.AddRange(New Object() {"Administração", "Engenharia", "Medicina", "Computação"})
        Me.cbxCurso.Location = New System.Drawing.Point(88, 197)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(202, 23)
        Me.cbxCurso.TabIndex = 6
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(33, 253)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 7
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(125, 253)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 8
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(217, 253)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 339)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.cbxCurso)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "Form1"
        Me.Text = "Financeiro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents rbtFeminino As RadioButton
    Friend WithEvents rbtMasculino As RadioButton
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCurso As Label
    Friend WithEvents cbxCurso As ComboBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnCancelar As Button
End Class
