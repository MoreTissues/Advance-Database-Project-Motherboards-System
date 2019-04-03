Public Class frm_updateproducts_a161032
    Dim current_id As String
    Dim defaultpicture As String = Application.StartupPath & "\Pictures\nophoto.png"


    Private Sub frm_updateproducts_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price(RM)"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Model"
        grd_products.Columns(5).HeaderText = "Quantity"
        grd_products.Columns(6).HeaderText = "Year Manufactured"

    End Sub

    Private Sub refresh_grid()
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161032 ORDER BY FLD_PRODUCT_ID")

    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_model.Text = ""
        txt_quantity.Text = ""
        txt_year_manu.Text = ""
    End Sub

    Private Sub grd_products_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_id = grd_products(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_brand.Text = grd_products(3, current_row).Value
        txt_model.Text = grd_products(4, current_row).Value
        txt_quantity.Text = grd_products(5, current_row).Value
        txt_year_manu.Text = grd_products(6, current_row).Value
    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim update_confirmation = MsgBox("Are you sure you would like to update the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If update_confirmation = MsgBoxResult.Yes Then
            run_sql_command("UPDATE TBL_PRODUCTS_A161032 SET FLD_PRODUCT_NAME = '" & txt_name.Text & "', FLD_PRICE = '" & txt_price.Text & "', FLD_BRAND = '" & txt_brand.Text & "', FLD_MODEL = '" & txt_model.Text & "', FLD_QUANTITY = '" & txt_quantity.Text & "', FLD_YEAR_MANUFACTURED = '" & txt_year_manu.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")
            Beep()
            MsgBox("If There is an Error Occur Please do Make Sure you have Entered the CORRECT INFORMATION, if NOT then you have Successfully Updated " & current_id & "!!!")

        End If



        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A161032 WHERE FLD_PRODUCT_ID = '" & current_id & "'")
            My.Computer.FileSystem.DeleteFile("Pictures\" & current_id & ".jpg")
            Beep()
            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If


    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_products_a161032.Show()
        Me.Close()

    End Sub


End Class