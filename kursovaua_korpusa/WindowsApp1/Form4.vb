Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Корпуса". При необходимости она может быть перемещена или удалена.
        Me.КорпусаTableAdapter.Fill(Me.UniversityDataSet.Корпуса)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Помещения". При необходимости она может быть перемещена или удалена.
        Me.ПомещенияTableAdapter.Fill(Me.UniversityDataSet.Помещения)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button6.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn2
            Case 2
                Col = DataGridViewTextBoxColumn3
            Case 3
                Col = DataGridViewTextBoxColumn4
            Case 4
                Col = DataGridViewTextBoxColumn5
            Case 5
                Col = DataGridViewTextBoxColumn6
            Case 6
                Col = DataGridViewTextBoxColumn7
            Case 7
                Col = DataGridViewTextBoxColumn8
            Case 8
                Col = DataGridViewTextBoxColumn9
            Case 9
                Col = DataGridViewTextBoxColumn10
            Case 10
                Col = DataGridViewTextBoxColumn11
            Case 11
                Col = DataGridViewTextBoxColumn12

        End Select
        If RadioButton1.Checked Then
            ПомещенияDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ПомещенияDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПомещенияBindingSource1.Filter = "[номер корпуса]='" & Номер_корпусаComboBox.Text & "'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ПомещенияBindingSource1.Filter = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To ПомещенияDataGridView.ColumnCount - 1
            For j = 0 To ПомещенияDataGridView.RowCount - 1

                ПомещенияDataGridView.Item(i, j).Style.BackColor = Color.White
                ПомещенияDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ПомещенияDataGridView.ColumnCount - 1
            For j = 0 To ПомещенияDataGridView.RowCount - 1
                If InStr(ПомещенияDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ПомещенияDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    ПомещенияDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub


    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.КорпусаTableAdapter.FillBy(Me.UniversityDataSet.Корпуса)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class