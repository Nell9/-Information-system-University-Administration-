Public Class Form5
    Private Sub КорпусаBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КорпусаBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КорпусаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.конструктивная_особенность". При необходимости она может быть перемещена или удалена.
        Me.Конструктивная_особенностьTableAdapter.Fill(Me.UniversityDataSet.конструктивная_особенность)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.конструктивная_особенность". При необходимости она может быть перемещена или удалена.
        Me.Конструктивная_особенностьTableAdapter.Fill(Me.UniversityDataSet.конструктивная_особенность)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Электробезопасность". При необходимости она может быть перемещена или удалена.
        Me.ЭлектробезопасностьTableAdapter.Fill(Me.UniversityDataSet.Электробезопасность)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Пожаробезопасность". При необходимости она может быть перемещена или удалена.
        Me.ПожаробезопасностьTableAdapter.Fill(Me.UniversityDataSet.Пожаробезопасность)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Корпуса". При необходимости она может быть перемещена или удалена.
        Me.КорпусаTableAdapter.Fill(Me.UniversityDataSet.Корпуса)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        КорпусаBindingSource.MoveFirst()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        КорпусаBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        КорпусаBindingSource.AddNew()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        КорпусаBindingSource.MoveLast()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        КорпусаBindingSource.MoveNext()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        КорпусаBindingSource.RemoveCurrent()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.КорпусаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)
    End Sub
End Class