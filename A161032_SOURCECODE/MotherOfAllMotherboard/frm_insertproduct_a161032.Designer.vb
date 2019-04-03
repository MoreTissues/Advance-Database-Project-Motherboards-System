<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a161032
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a161032))
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.txt_year_manu = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(18, 107)
        Me.grd_products.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.Size = New System.Drawing.Size(627, 591)
        Me.grd_products.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.GreenYellow
        Me.lbl_title.Location = New System.Drawing.Point(464, 36)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(315, 40)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Insert Products"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(699, 551)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Year Manufactured"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_quantity.Location = New System.Drawing.Point(699, 481)
        Me.lbl_quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(72, 21)
        Me.lbl_quantity.TabIndex = 29
        Me.lbl_quantity.Text = "Quantity"
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Transparent
        Me.lbl_model.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_model.Location = New System.Drawing.Point(699, 320)
        Me.lbl_model.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(58, 21)
        Me.lbl_model.TabIndex = 28
        Me.lbl_model.Text = "Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(699, 247)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(699, 410)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(699, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_name.Location = New System.Drawing.Point(699, 107)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 21)
        Me.lbl_name.TabIndex = 24
        Me.lbl_name.Text = "Name"
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic.Location = New System.Drawing.Point(994, 185)
        Me.pic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(261, 298)
        Me.pic.TabIndex = 23
        Me.pic.TabStop = False
        '
        'txt_year_manu
        '
        Me.txt_year_manu.Location = New System.Drawing.Point(703, 586)
        Me.txt_year_manu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_year_manu.Name = "txt_year_manu"
        Me.txt_year_manu.Size = New System.Drawing.Size(148, 29)
        Me.txt_year_manu.TabIndex = 22
        '
        'txt_model
        '
        Me.txt_model.Location = New System.Drawing.Point(703, 359)
        Me.txt_model.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(230, 29)
        Me.txt_model.TabIndex = 21
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(703, 507)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(148, 29)
        Me.txt_quantity.TabIndex = 20
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(703, 273)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(264, 29)
        Me.txt_brand.TabIndex = 19
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(703, 436)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(148, 29)
        Me.txt_price.TabIndex = 18
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(703, 198)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(148, 29)
        Me.txt_id.TabIndex = 17
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(703, 133)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(552, 29)
        Me.txt_name.TabIndex = 16
        '
        'btn_upload
        '
        Me.btn_upload.Location = New System.Drawing.Point(1065, 551)
        Me.btn_upload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(112, 37)
        Me.btn_upload.TabIndex = 31
        Me.btn_upload.Text = "UPLOAD"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(877, 639)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(206, 49)
        Me.btn_insert.TabIndex = 32
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(1020, 507)
        Me.txt_picture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.ReadOnly = True
        Me.txt_picture.Size = New System.Drawing.Size(217, 29)
        Me.txt_picture.TabIndex = 33
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(32, 36)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(69, 60)
        Me.btn_back.TabIndex = 34
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_insertproduct_a161032
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MotherOfAllMotherboard.My.Resources.Resources.amazing_animal_beautiful_beautifull
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1268, 713)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_model)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.txt_year_manu)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_products)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_insertproduct_a161032"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Product"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_products As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_quantity As System.Windows.Forms.Label
    Friend WithEvents lbl_model As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents txt_year_manu As System.Windows.Forms.TextBox
    Friend WithEvents txt_model As System.Windows.Forms.TextBox
    Friend WithEvents txt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_upload As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents txt_picture As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class
