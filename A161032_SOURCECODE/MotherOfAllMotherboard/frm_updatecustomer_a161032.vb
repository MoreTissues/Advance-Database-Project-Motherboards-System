Public Class frm_updatecustomer_a161032
    Dim current_id As String
    Private Sub frm_updatecustomer_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("MALE")
        ComboBox1.Items.Add("FEMALE")
        refresh_grid()
        get_current_id()


        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Customer Gender"
    End Sub

    Private Sub refresh_grid()
        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A161032")
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_id = grd_customer(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_customer(1, current_row).Value
        ComboBox1.Text = grd_customer(2, current_row).Value
    End Sub

    Private Sub grd_customer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim update_confirmation = MsgBox("Are you sure you would like to update customer """ & current_id & """?", MsgBoxStyle.YesNo)

        If update_confirmation = MsgBoxResult.Yes Then
            run_sql_command("UPDATE TBL_CUSTOMER_A161032 SET FLD_CUSTOMER_NAME = '" & txt_name.Text & "', FLD_CUSTOMER_GENDER = '" & ComboBox1.Text & "' WHERE FLD_CUSTOMER_ID = '" & current_id & "'")
            Beep()
            MsgBox("If There is an Error Occur Please do Make Sure you have Entered the CORRECT INFORMATION, if NOT then you have Successfully Updated " & current_id & "!!!")
        End If


       

        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A161032 WHERE FLD_CUSTOMER_ID = '" & current_id & "'")

            Beep()
            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_customerdetails_a161032.Show()
        Me.Close()

    End Sub

  
End Class