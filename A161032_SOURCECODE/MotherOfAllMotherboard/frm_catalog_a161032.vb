Public Class frm_catalog_a161032

    Private Sub frm_productlist_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A161032"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        ListID.DataSource = mydatatable
        ListID.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(ListID.Text)

    End Sub

    Private Sub refresh_text(ByVal id As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161032 WHERE FLD_PRODUCT_ID = '" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = "RM" & mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_model.Text = mydatatable.Rows(0).Item("FLD_MODEL")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
        txt_year_manu.Text = mydatatable.Rows(0).Item("FLD_YEAR_MANUFACTURED")


        Try
            pic.BackgroundImage = Image.FromFile("Pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic.BackgroundImage = Image.FromFile("Pictures/nophoto.png")

        End Try
    End Sub


    Private Sub ListID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListID.MouseClick
        refresh_text(ListID.Text)
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_main_menu.Show()
        Me.Close()

    End Sub

   
End Class