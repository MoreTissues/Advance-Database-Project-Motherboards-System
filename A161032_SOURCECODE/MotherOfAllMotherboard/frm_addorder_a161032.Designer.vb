<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addorder_a161032
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addorder_a161032))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_order_id = New System.Windows.Forms.TextBox()
        Me.btn_add_order = New System.Windows.Forms.Button()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_staff_gender = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.list_staff = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_cust_gender = New System.Windows.Forms.TextBox()
        Me.list_customer = New System.Windows.Forms.ListBox()
        Me.txt_cust_name = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pic_products = New System.Windows.Forms.PictureBox()
        Me.quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_year_manu = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.list_product = New System.Windows.Forms.ListBox()
        Me.pick_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delete_order = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.FLD_ORDER_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRODUCT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.txt_prod_name = New System.Windows.Forms.TextBox()
        Me.text_year_manu = New System.Windows.Forms.TextBox()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.dat = New System.Windows.Forms.DateTimePicker()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(159, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label2.Location = New System.Drawing.Point(1007, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order ID"
        '
        'txt_order_id
        '
        Me.txt_order_id.Location = New System.Drawing.Point(1125, 27)
        Me.txt_order_id.Name = "txt_order_id"
        Me.txt_order_id.ReadOnly = True
        Me.txt_order_id.Size = New System.Drawing.Size(116, 23)
        Me.txt_order_id.TabIndex = 2
        '
        'btn_add_order
        '
        Me.btn_add_order.Location = New System.Drawing.Point(283, 659)
        Me.btn_add_order.Name = "btn_add_order"
        Me.btn_add_order.Size = New System.Drawing.Size(209, 58)
        Me.btn_add_order.TabIndex = 5
        Me.btn_add_order.Text = "Add Order"
        Me.btn_add_order.UseVisualStyleBackColor = True
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.Location = New System.Drawing.Point(17, 229)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(119, 32)
        Me.subtotal.TabIndex = 8
        Me.subtotal.Text = "Sub-Total"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(160, 229)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(223, 29)
        Me.txt_subtotal.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Product Name"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(101, 40)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(347, 25)
        Me.txt_name.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(267, 175)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(116, 25)
        Me.txt_price.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_staff_gender)
        Me.GroupBox1.Controls.Add(Me.txt_staff_name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.list_staff)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.GreenYellow
        Me.GroupBox1.Location = New System.Drawing.Point(24, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 150)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Of Staff's"
        '
        'txt_staff_gender
        '
        Me.txt_staff_gender.Location = New System.Drawing.Point(185, 88)
        Me.txt_staff_gender.Name = "txt_staff_gender"
        Me.txt_staff_gender.ReadOnly = True
        Me.txt_staff_gender.Size = New System.Drawing.Size(212, 27)
        Me.txt_staff_gender.TabIndex = 4
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Location = New System.Drawing.Point(185, 36)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(212, 27)
        Me.txt_staff_name.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(108, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Name"
        '
        'list_staff
        '
        Me.list_staff.FormattingEnabled = True
        Me.list_staff.ItemHeight = 20
        Me.list_staff.Location = New System.Drawing.Point(7, 22)
        Me.list_staff.Name = "list_staff"
        Me.list_staff.Size = New System.Drawing.Size(81, 104)
        Me.list_staff.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_cust_gender)
        Me.GroupBox2.Controls.Add(Me.list_customer)
        Me.GroupBox2.Controls.Add(Me.txt_cust_name)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.GreenYellow
        Me.GroupBox2.Location = New System.Drawing.Point(24, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 150)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Of Customer's"
        '
        'txt_cust_gender
        '
        Me.txt_cust_gender.Location = New System.Drawing.Point(185, 91)
        Me.txt_cust_gender.Name = "txt_cust_gender"
        Me.txt_cust_gender.ReadOnly = True
        Me.txt_cust_gender.Size = New System.Drawing.Size(212, 25)
        Me.txt_cust_gender.TabIndex = 8
        '
        'list_customer
        '
        Me.list_customer.FormattingEnabled = True
        Me.list_customer.ItemHeight = 17
        Me.list_customer.Location = New System.Drawing.Point(7, 22)
        Me.list_customer.Name = "list_customer"
        Me.list_customer.Size = New System.Drawing.Size(81, 106)
        Me.list_customer.TabIndex = 1
        '
        'txt_cust_name
        '
        Me.txt_cust_name.Location = New System.Drawing.Point(185, 36)
        Me.txt_cust_name.Name = "txt_cust_name"
        Me.txt_cust_name.ReadOnly = True
        Me.txt_cust_name.Size = New System.Drawing.Size(212, 25)
        Me.txt_cust_name.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(108, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Gender"
        '
        'pic_products
        '
        Me.pic_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_products.Location = New System.Drawing.Point(986, 102)
        Me.pic_products.Name = "pic_products"
        Me.pic_products.Size = New System.Drawing.Size(274, 267)
        Me.pic_products.TabIndex = 24
        Me.pic_products.TabStop = False
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(101, 179)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(140, 25)
        Me.quantity.TabIndex = 23
        '
        'txt_year_manu
        '
        Me.txt_year_manu.Location = New System.Drawing.Point(101, 134)
        Me.txt_year_manu.Name = "txt_year_manu"
        Me.txt_year_manu.ReadOnly = True
        Me.txt_year_manu.Size = New System.Drawing.Size(116, 25)
        Me.txt_year_manu.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(98, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Year Manufactured"
        '
        'txt_model
        '
        Me.txt_model.Location = New System.Drawing.Point(267, 83)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.ReadOnly = True
        Me.txt_model.Size = New System.Drawing.Size(116, 25)
        Me.txt_model.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Model"
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(101, 84)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(116, 25)
        Me.txt_brand.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Brand"
        '
        'list_product
        '
        Me.list_product.FormattingEnabled = True
        Me.list_product.ItemHeight = 17
        Me.list_product.Location = New System.Drawing.Point(6, 22)
        Me.list_product.Name = "list_product"
        Me.list_product.Size = New System.Drawing.Size(86, 106)
        Me.list_product.Sorted = True
        Me.list_product.TabIndex = 0
        '
        'pick_date
        '
        Me.pick_date.Location = New System.Drawing.Point(1008, 62)
        Me.pick_date.Name = "pick_date"
        Me.pick_date.Size = New System.Drawing.Size(233, 23)
        Me.pick_date.TabIndex = 21
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(1082, 670)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(116, 33)
        Me.txt_total.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label4.Location = New System.Drawing.Point(1021, 676)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total"
        '
        'btn_delete_order
        '
        Me.btn_delete_order.Location = New System.Drawing.Point(531, 659)
        Me.btn_delete_order.Name = "btn_delete_order"
        Me.btn_delete_order.Size = New System.Drawing.Size(223, 63)
        Me.btn_delete_order.TabIndex = 22
        Me.btn_delete_order.Text = "Delete Order"
        Me.btn_delete_order.UseVisualStyleBackColor = True
        '
        'btn_checkout
        '
        Me.btn_checkout.Location = New System.Drawing.Point(787, 656)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(209, 66)
        Me.btn_checkout.TabIndex = 23
        Me.btn_checkout.Text = "Confirm Order"
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FLD_ORDER_DATE, Me.FLD_PRODUCT_ID, Me.FLD_PRODUCT_NAME, Me.FLD_PRICE, Me.FLD_QUANTITY, Me.FLD_SUBTOTAL})
        Me.grd_order.Location = New System.Drawing.Point(24, 385)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.Size = New System.Drawing.Size(1317, 253)
        Me.grd_order.TabIndex = 4
        '
        'FLD_ORDER_DATE
        '
        Me.FLD_ORDER_DATE.HeaderText = "ORDER DATE"
        Me.FLD_ORDER_DATE.Name = "FLD_ORDER_DATE"
        Me.FLD_ORDER_DATE.Width = 140
        '
        'FLD_PRODUCT_ID
        '
        Me.FLD_PRODUCT_ID.HeaderText = "PRODUCT ID"
        Me.FLD_PRODUCT_ID.Name = "FLD_PRODUCT_ID"
        Me.FLD_PRODUCT_ID.Width = 140
        '
        'FLD_PRODUCT_NAME
        '
        Me.FLD_PRODUCT_NAME.FillWeight = 110.0!
        Me.FLD_PRODUCT_NAME.HeaderText = "PRODUCT NAME"
        Me.FLD_PRODUCT_NAME.Name = "FLD_PRODUCT_NAME"
        Me.FLD_PRODUCT_NAME.Width = 700
        '
        'FLD_PRICE
        '
        Me.FLD_PRICE.HeaderText = "PRICE"
        Me.FLD_PRICE.Name = "FLD_PRICE"
        '
        'FLD_QUANTITY
        '
        Me.FLD_QUANTITY.HeaderText = "QUANTITY"
        Me.FLD_QUANTITY.Name = "FLD_QUANTITY"
        '
        'FLD_SUBTOTAL
        '
        Me.FLD_SUBTOTAL.HeaderText = "SUBTOTAL"
        Me.FLD_SUBTOTAL.Name = "FLD_SUBTOTAL"
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(932, 21)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Size = New System.Drawing.Size(100, 20)
        Me.txt_orderid.TabIndex = 2
        '
        'txt_prod_name
        '
        Me.txt_prod_name.Location = New System.Drawing.Point(241, 26)
        Me.txt_prod_name.Name = "txt_prod_name"
        Me.txt_prod_name.Size = New System.Drawing.Size(316, 20)
        Me.txt_prod_name.TabIndex = 12
        '
        'text_year_manu
        '
        Me.text_year_manu.Location = New System.Drawing.Point(653, 73)
        Me.text_year_manu.Name = "text_year_manu"
        Me.text_year_manu.Size = New System.Drawing.Size(100, 20)
        Me.text_year_manu.TabIndex = 22
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic.Location = New System.Drawing.Point(1006, 19)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(100, 86)
        Me.pic.TabIndex = 24
        Me.pic.TabStop = False
        '
        'dat
        '
        Me.dat.Location = New System.Drawing.Point(951, 60)
        Me.dat.Name = "dat"
        Me.dat.Size = New System.Drawing.Size(200, 20)
        Me.dat.TabIndex = 21
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(38, 30)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 25)
        Me.btn_back.TabIndex = 24
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.list_product)
        Me.GroupBox3.Controls.Add(Me.subtotal)
        Me.GroupBox3.Controls.Add(Me.txt_brand)
        Me.GroupBox3.Controls.Add(Me.txt_subtotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.quantity)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_price)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_year_manu)
        Me.GroupBox3.Controls.Add(Me.txt_model)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_name)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.GreenYellow
        Me.GroupBox3.Location = New System.Drawing.Point(471, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(466, 307)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List Of Product's"
        '
        'frm_addorder_a161032
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MotherOfAllMotherboard.My.Resources.Resources.amazing_animal_beautiful_beautifull
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.pic_products)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.btn_delete_order)
        Me.Controls.Add(Me.pick_date)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_add_order)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.txt_order_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_addorder_a161032"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_order_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_add_order As System.Windows.Forms.Button
    Friend WithEvents subtotal As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents list_staff As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents list_customer As System.Windows.Forms.ListBox
    Friend WithEvents txt_staff_gender As System.Windows.Forms.TextBox
    Friend WithEvents txt_staff_name As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cust_gender As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust_name As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents list_product As System.Windows.Forms.ListBox
    Friend WithEvents quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_year_manu As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_model As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pick_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete_order As System.Windows.Forms.Button
    Friend WithEvents btn_checkout As System.Windows.Forms.Button
    Friend WithEvents grd_order As System.Windows.Forms.DataGridView
    Friend WithEvents txt_orderid As System.Windows.Forms.TextBox
    Friend WithEvents txt_prod_name As System.Windows.Forms.TextBox
    Friend WithEvents text_year_manu As System.Windows.Forms.TextBox
    Friend WithEvents pic_products As System.Windows.Forms.PictureBox
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents dat As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FLD_ORDER_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRODUCT_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRODUCT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLD_QUANTITY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLD_SUBTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
