Imports MySql.Data.MySqlClient
Public Class Votantes

    Private Sub Votantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        conn()

        Try
            sql = ("select * from votantes")
            adap = New MySqlDataAdapter(sql, conexion)
            dt = New DataSet
            adap.Fill(dt, "votantes")
            GunaDataGridView1.DataSource = dt
            GunaDataGridView1.DataMember = "votantes"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Registro.Show()
        Me.Close()
    End Sub

    Private Sub BT_HOME_Click_1(sender As Object, e As EventArgs) Handles BT_HOME.Click
        Me.Close()
    End Sub
End Class