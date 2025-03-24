Public Class Виды_помещений
    Private Sub Виды_помещенийBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Виды_помещенийBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Виды_помещенийBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)

    End Sub

    Private Sub Виды_помещений_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Виды_помещений". При необходимости она может быть перемещена или удалена.
        Me.Виды_помещенийTableAdapter.Fill(Me.UniversityDataSet.Виды_помещений)

    End Sub
End Class