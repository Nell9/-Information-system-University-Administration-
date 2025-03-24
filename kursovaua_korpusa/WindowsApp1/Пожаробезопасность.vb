Public Class Пожаробезопасность
    Private Sub ПожаробезопасностьBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ПожаробезопасностьBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.ПожаробезопасностьBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)

    End Sub

    Private Sub Пожаробезопасность_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Пожаробезопасность". При необходимости она может быть перемещена или удалена.
        Me.ПожаробезопасностьTableAdapter.Fill(Me.UniversityDataSet.Пожаробезопасность)

    End Sub


End Class