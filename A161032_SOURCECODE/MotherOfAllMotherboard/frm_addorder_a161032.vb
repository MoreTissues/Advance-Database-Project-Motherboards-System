Public Class frm_addorder_a161032

    Private Sub frm_addorder_a161032_Load_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_order_id.Text = generate_id()


        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A161032"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_product.DataSource = mydatatable
        list_product.DisplayMember = "FLD_PRODUCT_ID"
        refresh_ProductText(list_product.Text)

        Dim mysql2 As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A161032"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        list_staff.DataSource = mydatatable2
        list_staff.DisplayMember = "FLD_STAFF_ID"
        refresh_StaffText(list_staff.Text)

        Dim mysql3 As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A161032"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        list_customer.DataSource = mydatatable3
        list_customer.DisplayMember = "FLD_CUSTOMER_ID"
        refresh_CustomerText(list_customer.Text)
        quantity.Value = 1
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A161032").Rows(0).Item("LASTID")
        Dim newid As String = "O" & Mid(lastid, 2) + 1
        Beep()
        MsgBox("New Order ID " & newid & " is Added")
        Return newid

    End Function

    Private Sub refresh_ProductText(ByVal PID As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161032 WHERE FLD_PRODUCT_ID = '" & PID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_model.Text = mydatatable.Rows(0).Item("FLD_MODEL")
        txt_year_manu.Text = mydatatable.Rows(0).Item("FLD_YEAR_MANUFACTURED")
        txt_price.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRICE"))

        If quantity.Value = 1 Then
            txt_subtotal.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRICE"))

        ElseIf quantity.Value > 1 Then
            txt_subtotal.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRICE") * quantity.Value)

        ElseIf quantity.Value = 0 Then
            txt_subtotal.Text = FormatCurrency(0)

        End If

        Try
            pic_products.BackgroundImage = Image.FromFile("Pictures/" & list_product.Text & ".jpg")

        Catch ex As Exception
            pic_products.BackgroundImage = Image.FromFile("Pictures/nophoto.png")

        End Try

    End Sub

    Private Sub refresh_StaffText(ByVal SID As String)
        Dim mysql2 As String = "SELECT * FROM TBL_STAFF_A161032 WHERE FLD_STAFF_ID = '" & SID & "'"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        txt_staff_name.Text = mydatatable2.Rows(0).Item("FLD_STAFF_NAME")
        txt_staff_gender.Text = mydatatable2.Rows(0).Item("FLD_STAFF_GENDER")

    End Sub

    Private Sub refresh_CustomerText(ByVal CID As String)
        Dim mysql3 As String = "SELECT * FROM TBL_CUSTOMER_A161032 WHERE FLD_CUSTOMER_ID = '" & CID & "'"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        txt_cust_name.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_cust_gender.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_GENDER")

    End Sub

    Private Sub list_product_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_product.MouseClick
        refresh_ProductText(list_product.Text)

    End Sub

    Private Sub order_quantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quantity.ValueChanged
        refresh_ProductText(list_product.Text)

    End Sub

    Private Sub list_staff_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_staff.MouseClick
        refresh_StaffText(list_staff.Text)

    End Sub

    Private Sub list_customer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_customer.MouseClick
        refresh_CustomerText(list_customer.Text)

    End Sub

    Private Sub btn_add_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_order.Click

        If quantity.Value = 0 Then
                Beep()
            MsgBox("Please enter the quantity of the item you want to order")
        Else
            grd_order.Rows.Add(New String() {pick_date.Text, list_product.Text, txt_name.Text, txt_price.Text, quantity.Value, txt_subtotal.Text})
            refresh_total()
        End If

        quantity.Value = 1
        
    End Sub

    Private Sub refresh_total()
        If grd_order.RowCount >= 1 Then
            Dim sum = 0

            For index As Integer = 0 To grd_order.RowCount - 1
                sum += grd_order.Rows(index).Cells(5).Value

            Next

            txt_total.Text = FormatCurrency(sum)

        ElseIf grd_order.RowCount = 0 Then
            txt_total.Text = FormatCurrency(0)

        End If
    End Sub

    Private Sub btn_checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_checkout.Click
        If grd_order.RowCount >= 1 Then
            Beep()
            Dim result = MsgBox("Are you sure you would like confirm your order?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Dim mytransaction As OleDb.OleDbTransaction
                myconnection2.Open()
                mytransaction = myconnection2.BeginTransaction

                Try
                    Dim mysql As String = "INSERT INTO TBL_ORDER_A161032 VALUES('" & txt_order_id.Text & "', '" & list_staff.Text & "', '" & list_customer.Text & "', '" & pick_date.Text & "')"
                    Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                    mywriter.ExecuteNonQuery()

                    For i As Integer = 0 To grd_order.RowCount - 1
                        Dim order_date As String = grd_order(0, i).Value
                        Dim product_id As String = grd_order(1, i).Value
                        Dim product_name As String = grd_order(2, i).Value
                        Dim price As String = grd_order(3, i).Value
                        Dim quantity As String = grd_order(4, i).Value
                        Dim subtotal As String = grd_order(5, i).Value
                        Dim mysql2 As String = "INSERT INTO TBL_ORDERLIST_A161032 VALUES('" & txt_order_id.Text & "', '" & product_id & "', '" & product_name & "', '" & price & "', " & quantity & ", '" & subtotal & "')"
                        Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
                        mywriter2.ExecuteNonQuery()

                    Next

                    mytransaction.Commit()
                    myconnection2.Close()
                    Beep()
                    MsgBox("Order " & txt_order_id.Text & " Successfully Added")
                    grd_order.Rows.Clear()
                    txt_order_id.Text = generate_id()


                Catch ex As Exception
                    Beep()
                    MsgBox("Please make sure there is no duplicate of products. Thanks")
                    mytransaction.Rollback()
                    myconnection2.Close()

                End Try
            End If
        Else
            Beep()
            MsgBox("Please make sure you have at least one order")

        End If
        txt_total.Text = ""
        quantity.Value = 1

    End Sub

    Private Sub btn_back_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Close()
        frm_main_menu.Show()
    End Sub

    Private Sub btn_delete_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_order.Click

        If grd_order.RowCount >= 1 Then
                grd_order.Rows.Remove(grd_order.CurrentRow)
                refresh_total()
        Else
            Beep()
            MsgBox("There is no records to delete")

        End If
       

    End Sub

End Class