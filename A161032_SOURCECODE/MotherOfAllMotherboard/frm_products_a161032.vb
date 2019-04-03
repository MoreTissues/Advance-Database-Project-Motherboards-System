Public Class frm_products_a161032

    Private Sub frm_products_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Mother_Of_All_Motherboards.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161032 ORDER BY FLD_PRODUCT_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price(RM)"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Model"
        grd_products.Columns(5).HeaderText = "Quantity"
        grd_products.Columns(6).HeaderText = "Year Manufactured"

        grd_products.Columns(0).SortMode = DataGridViewColumnSortMode.Automatic




    End Sub


    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_main_menu.Show()
        Me.Close()
    End Sub




    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        frm_insertproduct_a161032.Show()
        Me.Close()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        frm_updateproducts_a161032.Show()
        Me.Close()

    End Sub


   

End Class