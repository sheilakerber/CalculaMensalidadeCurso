Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNome.Enabled = False
        rbtFeminino.Enabled = False
        rbtMasculino.Enabled = False
        cbxCurso.Enabled = False
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtNome.Enabled = True
        txtNome.Text = Nothing
        rbtFeminino.Enabled = True
        rbtFeminino.Checked = False
        rbtMasculino.Enabled = True
        rbtMasculino.Checked = False
        cbxCurso.Enabled = True
        cbxCurso.Text = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNome.Enabled = False
        txtNome.Text = Nothing
        rbtFeminino.Enabled = False
        rbtFeminino.Checked = False
        rbtMasculino.Enabled = False
        rbtMasculino.Checked = False
        cbxCurso.Enabled = False
        cbxCurso.Text = Nothing
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If (txtNome.Text = Nothing Or IsNumeric(txtNome.Text)) Then
            MessageBox.Show("O campo 'nome' não foi preenchido.")
            Exit Sub

        ElseIf (Not rbtFeminino.Checked And Not rbtMasculino.Checked) Then
            MessageBox.Show("Por favor, selecione o sexo.")
            Exit Sub
        ElseIf (cbxCurso.Text = Nothing) Then
            MessageBox.Show("Por favor, selecione um curso.")
            Exit Sub
        End If

        Dim curso As String = cbxCurso.Text

        If (curso = "Administração") Then
            If (rbtMasculino.Checked) Then
                MessageBox.Show("Prezado " & txtNome.Text & ", o valor da sua mensalidade para o curso de Administração será de " & Format(11560 / 12, "R$ ###0.00."))

            ElseIf (rbtFeminino.Checked) Then
                MessageBox.Show("Prezada " & txtNome.Text & ", o valor da sua mensalidade para o curso de Administração será de " & Format(11560 * 0.92 / 12, "R$ ###0.00."))
            End If
        End If

        If (curso = "Engenharia") Then
            If (rbtMasculino.Checked) Then
                MessageBox.Show("Prezado " & txtNome.Text & ", o valor da sua mensalidade para o curso de Engenharia será de " & Format(21600 / 12, "R$ ###0.00."))

            ElseIf (rbtFeminino.Checked) Then
                MessageBox.Show("Prezada " & txtNome.Text & ", o valor da sua mensalidade para o curso de Engenharia será de " & Format(21600 * 0.92 / 12, "R$ ###0.00."))
            End If
        End If

        If (curso = "Medicina") Then
            If (rbtMasculino.Checked) Then
                MessageBox.Show("Prezado " & txtNome.Text & ", o valor da sua mensalidade para o curso de Medicina será de " & Format(60000 / 12, "R$ ###0.00."))

            ElseIf (rbtFeminino.Checked) Then
                MessageBox.Show("Prezada " & txtNome.Text & ", o valor da sua mensalidade para o curso de Medicina será de " & Format(60000 * 0.92 / 12, "R$ ###0.00."))
            End If
        End If

        If (curso = "Computação") Then
            If (rbtMasculino.Checked) Then
                MessageBox.Show("Prezado " & txtNome.Text & ", o valor da sua mensalidade para o curso de Computação será de " & Format(14000 / 12, "R$ ###0.00."))

            ElseIf (rbtFeminino.Checked) Then
                MessageBox.Show("Prezada " & txtNome.Text & ", o valor da sua mensalidade para o curso de Computação será de " & Format(14000 * 0.92 / 12, "R$ ###0.00."))
            End If
        End If
    End Sub
End Class
