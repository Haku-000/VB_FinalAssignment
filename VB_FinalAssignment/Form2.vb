Imports VB_FinalAssignment._VBA_6_1DataSetTableAdapters

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VBA_6_1DataSet.RegistrodeEmpleados' table. You can move, or remove it, as needed.
        Me.RegistrodeEmpleadosTableAdapter.Fill(Me._VBA_6_1DataSet.RegistrodeEmpleados)

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        RegistrodeEmpleadosBindingSource.AddNew()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()
    End Sub



    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Validate()
            RegistrodeEmpleadosBindingSource.EndEdit()
            RegistrodeEmpleadosTableAdapter.Update(_VBA_6_1DataSet.RegistrodeEmpleados)
            MessageBox.Show("Saved")


        Catch ex As Exception
            MessageBox.Show("Error >.<")
        End Try
    End Sub
End Class