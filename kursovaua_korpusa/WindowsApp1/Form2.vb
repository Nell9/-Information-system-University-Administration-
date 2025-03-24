Public Class Form2
    Private Sub ПомещенияBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ПомещенияBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПомещенияBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "UniversityDataSet.Помещения". При необходимости она может быть перемещена или удалена.
        Me.ПомещенияTableAdapter.Fill(Me.UniversityDataSet.Помещения)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПомещенияBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПомещенияBindingSource.AddNew()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ПомещенияBindingSource.MoveLast()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ПомещенияBindingSource.MoveNext()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ПомещенияBindingSource.RemoveCurrent()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ПомещенияBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UniversityDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ПомещенияBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub


End Class