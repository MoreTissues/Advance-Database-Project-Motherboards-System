Public Class frm_insertproduct_a161032
    Dim defaultpicture As String = Application.StartupPath & "\Pictures\nophoto.png"

    Private Sub frm_insertproduct_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161032 ORDER BY FLD_PRODUCT_ID")

        txt_id.Text = generate_id()

        txt_picture.Text = defaultpicture
        pic.BackgroundImage = Image.FromFile(defaultpicture)

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price(RM)"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Model"
        grd_products.Columns(5).HeaderText = "Quantity"
        grd_products.Columns(6).HeaderText = "Year Manufactured"

        grd_products.Columns(0).SortMode = DataGridViewColumnSortMode.Automatic


    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A161032").Rows(0).Item("LASTID")

        MsgBox("New ID A0" & Mid(lastid, 2) + 1 & " Added")

        Dim newid As String = "A0" & Mid(lastid, 2) + 1

        Return newid
    End Function


    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        If txt_name.Text = "" Or txt_brand.Text = "" Or txt_id.Text = "" Or txt_model.Text = "" Or txt_name.Text = "" Or txt_price.Text = "" Or txt_quantity.Text = "" Or txt_year_manu.Text = "" Then
            Beep()
            MsgBox("Please enter the required fields")
        Else

            Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A161032 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & txt_brand.Text & "', '" & txt_model.Text & "', '" & txt_quantity.Text & "', '" & txt_year_manu.Text & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                My.Computer.FileSystem.CopyFile(txt_picture.Text, "Pictures\" & txt_id.Text & ".jpg")

                grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161032 ORDER BY FLD_PRODUCT_ID")
                Beep()

                MsgBox("Product " & txt_id.Text & " Successfully Added")
                txt_id.Text = generate_id()
                txt_name.Text = ""
                txt_price.Text = ""
                txt_brand.Text = ""
                txt_model.Text = ""
                txt_quantity.Text = ""
                txt_year_manu.Text = ""
                txt_picture.Text = defaultpicture
                pic.BackgroundImage = Image.FromFile(defaultpicture)

                refreshgrid()



            Catch ex As Exception

                Beep()
                MsgBox("There is a mistake in the data table you have entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()

            End Try
        End If
    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        Try
            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog1.ShowDialog()

            pic.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            Beep()

        End Try
       

    End Sub

    Private Sub refreshgrid()
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161032 ORDER BY FLD_PRODUCT_ID")
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_products_a161032.Show()
        Me.Close()

    End Sub
   
End Class