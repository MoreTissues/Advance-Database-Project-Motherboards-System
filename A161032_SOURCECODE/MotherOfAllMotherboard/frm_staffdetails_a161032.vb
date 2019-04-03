Public Class frm_staffdetails_a161032

    Private Sub frm_staffdetails_a161032_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Mother_Of_All_Motherboards.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A161032"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Gender"

    End Sub

    

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        frm_main_menu.Show()
        Me.Close()
    End Sub



    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        frm_insertstaff_a161032.Show()
        Me.Close()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        frm_updatestaff_a161032.Show()
        Me.Close()

    End Sub
  
End Class