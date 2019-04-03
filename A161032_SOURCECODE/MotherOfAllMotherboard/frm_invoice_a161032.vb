Public Class frm_invoice_a161032

    Private Sub frm_invoice_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A161032"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_order.DataSource = mydatatable
        list_order.DisplayMember = "FLD_ORDER_ID"
        refresh_text(list_order.Text)
        refresh_grid()
        refresh_total()


        grd_order_record.Columns(0).HeaderText = "Order ID"
        grd_order_record.Columns(1).HeaderText = "Order ID"
        grd_order_record.Columns(2).HeaderText = "Product Name"
        grd_order_record.Columns(3).HeaderText = "Price(RM)"
        grd_order_record.Columns(4).HeaderText = "Quantity"
        grd_order_record.Columns(5).HeaderText = "Subtotal"


    End Sub

    Private Sub refresh_text(ByVal ID As String)
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A161032 WHERE FLD_ORDER_ID = '" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")

    End Sub

    

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_ORDERLIST_A161032 WHERE FLD_ORDER_ID = '" & list_order.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order_record.DataSource = mydatatable

    End Sub

    Private Sub refresh_total()
        If grd_order_record.RowCount >= 1 Then
            Dim sum = 0

            For index As Integer = 0 To grd_order_record.RowCount - 1
                sum += grd_order_record.Rows(index).Cells(5).Value

            Next

            txt_total.Text = FormatCurrency(sum)

        End If
    End Sub

    Private Sub list_order_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_order.MouseClick
        refresh_text(list_order.Text)
        refresh_grid()
        refresh_total()

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Close()
        frm_main_menu.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the order """ & list_order.Text & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_ORDERLIST_A161032 WHERE FLD_ORDER_ID = '" & list_order.Text & "'")
            run_sql_command("DELETE FROM TBL_ORDER_A161032 WHERE FLD_ORDER_ID = '" & list_order.Text & "'")
            Beep()
            MsgBox("The product """ & list_order.Text & """ has been successfully deleted.")
            refresh_grid()
            refresh_total()
            refreshList()
            txt_total.Text = ""

        End If

    End Sub

    Private Sub refreshList()
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A161032"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_order.DataSource = mydatatable
        list_order.DisplayMember = "FLD_ORDER_ID"
    End Sub
End Class