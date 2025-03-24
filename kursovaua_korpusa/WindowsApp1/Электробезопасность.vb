Public Class Электробезопасность
    Private Sub ЭлектробезопасностьBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ЭлектробезопасностьBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.ЭлектробезопасностьBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)

    End Sub

    Private Sub Электробезопасность_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Электробезопасность". При необходимости она может быть перемещена или удалена.
        Me.ЭлектробезопасностьTableAdapter.Fill(Me.UniversityDataSet.Электробезопасность)

    End Sub
End Class