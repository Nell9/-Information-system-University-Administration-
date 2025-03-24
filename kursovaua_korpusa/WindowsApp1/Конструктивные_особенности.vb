Public Class Конструктивные_особенности
    Private Sub Конструктивная_особенностьBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Конструктивная_особенностьBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Конструктивная_особенностьBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.конструктивная_особенность". При необходимости она может быть перемещена или удалена.
        Me.Конструктивная_особенностьTableAdapter.Fill(Me.UniversityDataSet.конструктивная_особенность)

    End Sub
End Class