Imports VB_FinalAssignment._VBA_6_1DataSetTableAdapters

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VBA_6_1DataSet.RegistrodeEmpleados' table. You can move, or remove it, as needed.
        Me.RegistrodeEmpleadosTableAdapter.Fill(Me._VBA_6_1DataSet.RegistrodeEmpleados)

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Me.Validate()
            Me.RegistrodeEmpleadosBindingSource.EndEdit()
            Me.RegistrodeEmpleadosTableAdapter.Update(Me._VBA_6_1DataSet.RegistrodeEmpleados)
            MessageBox.Show("Saved")


        Catch ex As Exception
            MessageBox.Show("Error >.<")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        RegistrodeEmpleadosBindingSource.AddNew()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        RegistrodeEmpleadosBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        RegistrodeEmpleadosBindingSource.MoveNext()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        Form2.Show()
    End Sub

End Class
