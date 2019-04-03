<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main_menu))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_subtext = New System.Windows.Forms.Label()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.brn_product = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_orders1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Showcard Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_title.Location = New System.Drawing.Point(341, 80)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(572, 119)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "MAIN MENU"
        '
        'lbl_subtext
        '
        Me.lbl_subtext.AutoSize = True
        Me.lbl_subtext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_subtext.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtext.Location = New System.Drawing.Point(367, 199)
        Me.lbl_subtext.Name = "lbl_subtext"
        Me.lbl_subtext.Size = New System.Drawing.Size(314, 23)
        Me.lbl_subtext.TabIndex = 1
        Me.lbl_subtext.Text = "Please Choose Which You Wish To View"
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.Red
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_customer.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.ForeColor = System.Drawing.Color.White
        Me.btn_customer.Location = New System.Drawing.Point(240, 334)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(167, 53)
        Me.btn_customer.TabIndex = 2
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.Red
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_staff.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.Color.White
        Me.btn_staff.Location = New System.Drawing.Point(453, 334)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(167, 53)
        Me.btn_staff.TabIndex = 3
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'brn_product
        '
        Me.brn_product.BackColor = System.Drawing.Color.Red
        Me.brn_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.brn_product.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brn_product.ForeColor = System.Drawing.Color.White
        Me.brn_product.Location = New System.Drawing.Point(38, 293)
        Me.brn_product.Name = "brn_product"
        Me.brn_product.Size = New System.Drawing.Size(167, 54)
        Me.brn_product.TabIndex = 4
        Me.brn_product.Text = "Products Table"
        Me.brn_product.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.Red
        Me.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orders.ForeColor = System.Drawing.Color.White
        Me.btn_orders.Location = New System.Drawing.Point(678, 293)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(139, 53)
        Me.btn_orders.TabIndex = 6
        Me.btn_orders.Text = "Make an Order"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'btn_orders1
        '
        Me.btn_orders1.BackColor = System.Drawing.Color.Red
        Me.btn_orders1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_orders1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orders1.ForeColor = System.Drawing.Color.White
        Me.btn_orders1.Location = New System.Drawing.Point(678, 375)
        Me.btn_orders1.Name = "btn_orders1"
        Me.btn_orders1.Size = New System.Drawing.Size(139, 54)
        Me.btn_orders1.TabIndex = 7
        Me.btn_orders1.Text = "Invoice"
        Me.btn_orders1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MotherOfAllMotherboard.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(2, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImage = Global.MotherOfAllMotherboard.My.Resources.Resources._13165939071654987882logout_hi
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(806, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 65)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(38, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 54)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Catalog"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(687, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(31, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 40)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(233, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 40)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CUSTOMER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(487, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 40)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Staff"
        '
        'frm_main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MotherOfAllMotherboard.My.Resources.Resources.amazing_animal_beautiful_beautifull
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(909, 477)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_orders1)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.brn_product)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.lbl_subtext)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_subtext As System.Windows.Forms.Label
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents brn_product As System.Windows.Forms.Button
    Friend WithEvents btn_orders As System.Windows.Forms.Button
    Friend WithEvents btn_orders1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
