Public Class frm_main_menu

    Private Sub main_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_title.ForeColor = Color.Yellow
    End Sub

    Private Sub btn_customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customer.Click
        frm_customerdetails_a161032.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orders.Click
        frm_addorder_a161032.Show()
        Me.Close()
    End Sub

    Private Sub btn_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_staff.Click
        frm_staffdetails_a161032.Show()
        Me.Close()
    End Sub

    Private Sub brn_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brn_product.Click
        frm_products_a161032.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orders1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orders1.Click
        frm_invoice_a161032.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If lbl_title.ForeColor = Color.Yellow Then
            lbl_title.ForeColor = Color.Aqua
        Else
            If lbl_title.ForeColor = Color.Aqua Then
                lbl_title.ForeColor = Color.Yellow
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Beep()
        Dim result = MsgBox("Are you sure you would like Exit?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_catalog_a161032.Show()
        Me.Close()

    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label3.ForeColor = Color.Yellow Then
            Label3.ForeColor = Color.Aqua
        Else
            If Label3.ForeColor = Color.Aqua Then
                Label3.ForeColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label4.ForeColor = Color.Yellow Then
            Label4.ForeColor = Color.Aqua
        Else
            If Label4.ForeColor = Color.Aqua Then
                Label4.ForeColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label1.ForeColor = Color.Yellow Then
            Label1.ForeColor = Color.Aqua
        Else
            If Label1.ForeColor = Color.Aqua Then
                Label1.ForeColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label2.ForeColor = Color.Yellow Then
            Label2.ForeColor = Color.Aqua
        Else
            If Label2.ForeColor = Color.Aqua Then
                Label2.ForeColor = Color.Yellow
            End If
        End If
    End Sub
End Class
