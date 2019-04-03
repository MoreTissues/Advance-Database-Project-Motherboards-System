Public Class frm_insertstaff_a161032

    Private Sub frm_insertstaff_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("MALE")
        ComboBox1.Items.Add("FEMALE")
        refresh_grid()

        txt_id.Text = generate_id()


        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Gender"

    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A161032")
    End Sub

    Private Function generate_id()
        Dim laststaffid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A161032").Rows(0).Item("LASTID")

        MsgBox("New ID S00" & Mid(laststaffid, 2) + 1 & " Added")

        Dim newid As String = "S00" & Mid(laststaffid, 2) + 1

        Return newid
    End Function



    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        If txt_name.Text = "" Then
            Beep()
            MsgBox("Please enter a staff name")
        Else

            Dim mysql As String = "INSERT INTO TBL_STAFF_A161032 VALUES ('" & txt_id.Text & "' , '" & txt_name.Text & "', '" & ComboBox1.Text & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                refresh_grid()

                txt_id.Text = generate_id()

                clear_fields()

                refresh_grid()


            Catch ex As Exception

                Beep()
                MsgBox("There is a mistake in the data table you have entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()

            End Try
        End If
    End Sub

    Private Sub clear_fields()
        txt_name.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub grd_staff_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_staffdetails_a161032.Show()
        Me.Close()

    End Sub
   
End Class