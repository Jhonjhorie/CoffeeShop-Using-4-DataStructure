<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OrdersummaryListBox = New System.Windows.Forms.ListBox()
        Me.txtCashTendered = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculateChange = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdDinein = New System.Windows.Forms.RadioButton()
        Me.rdTakeout = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOrderHistory = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CoffeesListBox = New System.Windows.Forms.ListBox()
        Me.TeaListBox = New System.Windows.Forms.ListBox()
        Me.PastriesListBox = New System.Windows.Forms.ListBox()
        Me.btnPushtoOrder = New System.Windows.Forms.Button()
        Me.SizeCListbox = New System.Windows.Forms.ListBox()
        Me.btnPushTea = New System.Windows.Forms.Button()
        Me.btnPushPastry = New System.Windows.Forms.Button()
        Me.SizeTListbox = New System.Windows.Forms.ListBox()
        Me.rdCIced = New System.Windows.Forms.RadioButton()
        Me.rdCHot = New System.Windows.Forms.RadioButton()
        Me.rdTIced = New System.Windows.Forms.RadioButton()
        Me.rdTHot = New System.Windows.Forms.RadioButton()
        Me.imgCoffee = New System.Windows.Forms.PictureBox()
        Me.imgTea = New System.Windows.Forms.PictureBox()
        Me.imgPastries = New System.Windows.Forms.PictureBox()
        Me.lblCoffeePrice = New System.Windows.Forms.Label()
        Me.lblCoffeeName = New System.Windows.Forms.Label()
        Me.lblTeaName = New System.Windows.Forms.Label()
        Me.lblTeaPrice = New System.Windows.Forms.Label()
        Me.lblPastryName = New System.Windows.Forms.Label()
        Me.lblPastryPrice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imgCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPastries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.btnUndo)
        Me.Panel1.Controls.Add(Me.txtcustomername)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.OrdersummaryListBox)
        Me.Panel1.Controls.Add(Me.txtCashTendered)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.TotalAmount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnConfirm)
        Me.Panel1.Controls.Add(Me.lblChange)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCalculateChange)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rdDinein)
        Me.Panel1.Controls.Add(Me.rdTakeout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(660, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 576)
        Me.Panel1.TabIndex = 0
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.White
        Me.btnUndo.ForeColor = System.Drawing.Color.Red
        Me.btnUndo.Location = New System.Drawing.Point(236, 32)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 16
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'txtcustomername
        '
        Me.txtcustomername.Location = New System.Drawing.Point(176, 477)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(100, 22)
        Me.txtcustomername.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Customer Name:"
        '
        'OrdersummaryListBox
        '
        Me.OrdersummaryListBox.FormattingEnabled = True
        Me.OrdersummaryListBox.ItemHeight = 16
        Me.OrdersummaryListBox.Location = New System.Drawing.Point(12, 59)
        Me.OrdersummaryListBox.Name = "OrdersummaryListBox"
        Me.OrdersummaryListBox.Size = New System.Drawing.Size(299, 244)
        Me.OrdersummaryListBox.TabIndex = 12
        '
        'txtCashTendered
        '
        Me.txtCashTendered.Location = New System.Drawing.Point(176, 367)
        Me.txtCashTendered.Name = "txtCashTendered"
        Me.txtCashTendered.Size = New System.Drawing.Size(100, 22)
        Me.txtCashTendered.TabIndex = 11
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(245, 344)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(17, 18)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "0"
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(20, 344)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(51, 18)
        Me.TotalAmount.TabIndex = 9
        Me.TotalAmount.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cash Tendered:"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(102, 508)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(111, 43)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Place Order"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(245, 448)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(17, 18)
        Me.lblChange.TabIndex = 5
        Me.lblChange.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Change:"
        '
        'btnCalculateChange
        '
        Me.btnCalculateChange.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnCalculateChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateChange.Location = New System.Drawing.Point(102, 398)
        Me.btnCalculateChange.Name = "btnCalculateChange"
        Me.btnCalculateChange.Size = New System.Drawing.Size(111, 43)
        Me.btnCalculateChange.TabIndex = 3
        Me.btnCalculateChange.Text = "Confirm"
        Me.btnCalculateChange.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(236, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Clear All"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Summary"
        '
        'rdDinein
        '
        Me.rdDinein.AutoSize = True
        Me.rdDinein.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDinein.Location = New System.Drawing.Point(159, 316)
        Me.rdDinein.Name = "rdDinein"
        Me.rdDinein.Size = New System.Drawing.Size(74, 22)
        Me.rdDinein.TabIndex = 3
        Me.rdDinein.TabStop = True
        Me.rdDinein.Text = "Dine in"
        Me.rdDinein.UseVisualStyleBackColor = True
        '
        'rdTakeout
        '
        Me.rdTakeout.AutoSize = True
        Me.rdTakeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTakeout.Location = New System.Drawing.Point(63, 316)
        Me.rdTakeout.Name = "rdTakeout"
        Me.rdTakeout.Size = New System.Drawing.Size(90, 22)
        Me.rdTakeout.TabIndex = 2
        Me.rdTakeout.TabStop = True
        Me.rdTakeout.Text = "Take Out"
        Me.rdTakeout.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnOrderHistory)
        Me.Panel2.Controls.Add(Me.btnOrders)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 55)
        Me.Panel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Myanmar Text", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 60)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Coffee Point"
        '
        'btnOrderHistory
        '
        Me.btnOrderHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderHistory.ForeColor = System.Drawing.Color.DarkRed
        Me.btnOrderHistory.Location = New System.Drawing.Point(317, 12)
        Me.btnOrderHistory.Name = "btnOrderHistory"
        Me.btnOrderHistory.Size = New System.Drawing.Size(192, 30)
        Me.btnOrderHistory.TabIndex = 51
        Me.btnOrderHistory.Text = "View Customers"
        Me.btnOrderHistory.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrders.ForeColor = System.Drawing.Color.DarkRed
        Me.btnOrders.Location = New System.Drawing.Point(540, 12)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(100, 30)
        Me.btnOrders.TabIndex = 50
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Coffee"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Tea"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(501, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 29)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Pastries"
        '
        'CoffeesListBox
        '
        Me.CoffeesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoffeesListBox.FormattingEnabled = True
        Me.CoffeesListBox.ItemHeight = 20
        Me.CoffeesListBox.Location = New System.Drawing.Point(78, 135)
        Me.CoffeesListBox.Name = "CoffeesListBox"
        Me.CoffeesListBox.Size = New System.Drawing.Size(139, 184)
        Me.CoffeesListBox.TabIndex = 13
        '
        'TeaListBox
        '
        Me.TeaListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeaListBox.FormattingEnabled = True
        Me.TeaListBox.ItemHeight = 20
        Me.TeaListBox.Location = New System.Drawing.Point(291, 135)
        Me.TeaListBox.Name = "TeaListBox"
        Me.TeaListBox.Size = New System.Drawing.Size(200, 184)
        Me.TeaListBox.TabIndex = 61
        '
        'PastriesListBox
        '
        Me.PastriesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PastriesListBox.FormattingEnabled = True
        Me.PastriesListBox.ItemHeight = 20
        Me.PastriesListBox.Location = New System.Drawing.Point(506, 135)
        Me.PastriesListBox.Name = "PastriesListBox"
        Me.PastriesListBox.Size = New System.Drawing.Size(138, 184)
        Me.PastriesListBox.TabIndex = 62
        '
        'btnPushtoOrder
        '
        Me.btnPushtoOrder.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPushtoOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPushtoOrder.Location = New System.Drawing.Point(42, 497)
        Me.btnPushtoOrder.Name = "btnPushtoOrder"
        Me.btnPushtoOrder.Size = New System.Drawing.Size(150, 60)
        Me.btnPushtoOrder.TabIndex = 13
        Me.btnPushtoOrder.Text = "Push Coffee to Order"
        Me.btnPushtoOrder.UseVisualStyleBackColor = False
        '
        'SizeCListbox
        '
        Me.SizeCListbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeCListbox.FormattingEnabled = True
        Me.SizeCListbox.ItemHeight = 20
        Me.SizeCListbox.Items.AddRange(New Object() {"S", "M", "L", "XL"})
        Me.SizeCListbox.Location = New System.Drawing.Point(21, 135)
        Me.SizeCListbox.Name = "SizeCListbox"
        Me.SizeCListbox.Size = New System.Drawing.Size(57, 184)
        Me.SizeCListbox.TabIndex = 63
        '
        'btnPushTea
        '
        Me.btnPushTea.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPushTea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPushTea.Location = New System.Drawing.Point(249, 497)
        Me.btnPushTea.Name = "btnPushTea"
        Me.btnPushTea.Size = New System.Drawing.Size(150, 60)
        Me.btnPushTea.TabIndex = 64
        Me.btnPushTea.Text = "Push Tea to Order"
        Me.btnPushTea.UseVisualStyleBackColor = False
        '
        'btnPushPastry
        '
        Me.btnPushPastry.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPushPastry.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPushPastry.Location = New System.Drawing.Point(457, 497)
        Me.btnPushPastry.Name = "btnPushPastry"
        Me.btnPushPastry.Size = New System.Drawing.Size(150, 60)
        Me.btnPushPastry.TabIndex = 65
        Me.btnPushPastry.Text = "Push Pastry to Order"
        Me.btnPushPastry.UseVisualStyleBackColor = False
        '
        'SizeTListbox
        '
        Me.SizeTListbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeTListbox.FormattingEnabled = True
        Me.SizeTListbox.ItemHeight = 20
        Me.SizeTListbox.Items.AddRange(New Object() {"S", "M", "L", "XL"})
        Me.SizeTListbox.Location = New System.Drawing.Point(233, 135)
        Me.SizeTListbox.Name = "SizeTListbox"
        Me.SizeTListbox.Size = New System.Drawing.Size(57, 184)
        Me.SizeTListbox.TabIndex = 66
        '
        'rdCIced
        '
        Me.rdCIced.AutoSize = True
        Me.rdCIced.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCIced.Location = New System.Drawing.Point(78, 110)
        Me.rdCIced.Name = "rdCIced"
        Me.rdCIced.Size = New System.Drawing.Size(55, 19)
        Me.rdCIced.TabIndex = 68
        Me.rdCIced.TabStop = True
        Me.rdCIced.Text = "Iced"
        Me.rdCIced.UseVisualStyleBackColor = True
        '
        'rdCHot
        '
        Me.rdCHot.AutoSize = True
        Me.rdCHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCHot.Location = New System.Drawing.Point(21, 110)
        Me.rdCHot.Name = "rdCHot"
        Me.rdCHot.Size = New System.Drawing.Size(50, 19)
        Me.rdCHot.TabIndex = 67
        Me.rdCHot.TabStop = True
        Me.rdCHot.Text = "Hot"
        Me.rdCHot.UseVisualStyleBackColor = True
        '
        'rdTIced
        '
        Me.rdTIced.AutoSize = True
        Me.rdTIced.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTIced.Location = New System.Drawing.Point(294, 110)
        Me.rdTIced.Name = "rdTIced"
        Me.rdTIced.Size = New System.Drawing.Size(55, 19)
        Me.rdTIced.TabIndex = 70
        Me.rdTIced.TabStop = True
        Me.rdTIced.Text = "Iced"
        Me.rdTIced.UseVisualStyleBackColor = True
        '
        'rdTHot
        '
        Me.rdTHot.AutoSize = True
        Me.rdTHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTHot.Location = New System.Drawing.Point(237, 110)
        Me.rdTHot.Name = "rdTHot"
        Me.rdTHot.Size = New System.Drawing.Size(50, 19)
        Me.rdTHot.TabIndex = 69
        Me.rdTHot.TabStop = True
        Me.rdTHot.Text = "Hot"
        Me.rdTHot.UseVisualStyleBackColor = True
        '
        'imgCoffee
        '
        Me.imgCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCoffee.Location = New System.Drawing.Point(42, 361)
        Me.imgCoffee.Name = "imgCoffee"
        Me.imgCoffee.Size = New System.Drawing.Size(150, 130)
        Me.imgCoffee.TabIndex = 71
        Me.imgCoffee.TabStop = False
        '
        'imgTea
        '
        Me.imgTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgTea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgTea.Location = New System.Drawing.Point(233, 361)
        Me.imgTea.Name = "imgTea"
        Me.imgTea.Size = New System.Drawing.Size(184, 130)
        Me.imgTea.TabIndex = 72
        Me.imgTea.TabStop = False
        '
        'imgPastries
        '
        Me.imgPastries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPastries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgPastries.Location = New System.Drawing.Point(457, 361)
        Me.imgPastries.Name = "imgPastries"
        Me.imgPastries.Size = New System.Drawing.Size(150, 130)
        Me.imgPastries.TabIndex = 73
        Me.imgPastries.TabStop = False
        '
        'lblCoffeePrice
        '
        Me.lblCoffeePrice.AutoSize = True
        Me.lblCoffeePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoffeePrice.Location = New System.Drawing.Point(141, 336)
        Me.lblCoffeePrice.Name = "lblCoffeePrice"
        Me.lblCoffeePrice.Size = New System.Drawing.Size(47, 18)
        Me.lblCoffeePrice.TabIndex = 16
        Me.lblCoffeePrice.Text = "Price"
        '
        'lblCoffeeName
        '
        Me.lblCoffeeName.AutoSize = True
        Me.lblCoffeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoffeeName.Location = New System.Drawing.Point(39, 336)
        Me.lblCoffeeName.Name = "lblCoffeeName"
        Me.lblCoffeeName.Size = New System.Drawing.Size(67, 18)
        Me.lblCoffeeName.TabIndex = 74
        Me.lblCoffeeName.Text = "Product"
        '
        'lblTeaName
        '
        Me.lblTeaName.AutoSize = True
        Me.lblTeaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeaName.Location = New System.Drawing.Point(230, 338)
        Me.lblTeaName.Name = "lblTeaName"
        Me.lblTeaName.Size = New System.Drawing.Size(64, 17)
        Me.lblTeaName.TabIndex = 76
        Me.lblTeaName.Text = "Product"
        '
        'lblTeaPrice
        '
        Me.lblTeaPrice.AutoSize = True
        Me.lblTeaPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeaPrice.Location = New System.Drawing.Point(361, 336)
        Me.lblTeaPrice.Name = "lblTeaPrice"
        Me.lblTeaPrice.Size = New System.Drawing.Size(47, 18)
        Me.lblTeaPrice.TabIndex = 75
        Me.lblTeaPrice.Text = "Price"
        '
        'lblPastryName
        '
        Me.lblPastryName.AutoSize = True
        Me.lblPastryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastryName.Location = New System.Drawing.Point(454, 336)
        Me.lblPastryName.Name = "lblPastryName"
        Me.lblPastryName.Size = New System.Drawing.Size(67, 18)
        Me.lblPastryName.TabIndex = 78
        Me.lblPastryName.Text = "Product"
        '
        'lblPastryPrice
        '
        Me.lblPastryPrice.AutoSize = True
        Me.lblPastryPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastryPrice.Location = New System.Drawing.Point(556, 336)
        Me.lblPastryPrice.Name = "lblPastryPrice"
        Me.lblPastryPrice.Size = New System.Drawing.Size(47, 18)
        Me.lblPastryPrice.TabIndex = 77
        Me.lblPastryPrice.Text = "Price"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.BurlyWood
        Me.PictureBox1.BackgroundImage = Global.CoffeeShop_DataStracture_.My.Resources.Resources.Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(983, 576)
        Me.Controls.Add(Me.lblPastryName)
        Me.Controls.Add(Me.lblPastryPrice)
        Me.Controls.Add(Me.lblTeaName)
        Me.Controls.Add(Me.lblTeaPrice)
        Me.Controls.Add(Me.lblCoffeeName)
        Me.Controls.Add(Me.lblCoffeePrice)
        Me.Controls.Add(Me.imgPastries)
        Me.Controls.Add(Me.imgTea)
        Me.Controls.Add(Me.imgCoffee)
        Me.Controls.Add(Me.rdTIced)
        Me.Controls.Add(Me.rdTHot)
        Me.Controls.Add(Me.rdCIced)
        Me.Controls.Add(Me.rdCHot)
        Me.Controls.Add(Me.SizeTListbox)
        Me.Controls.Add(Me.btnPushPastry)
        Me.Controls.Add(Me.btnPushTea)
        Me.Controls.Add(Me.SizeCListbox)
        Me.Controls.Add(Me.btnPushtoOrder)
        Me.Controls.Add(Me.PastriesListBox)
        Me.Controls.Add(Me.TeaListBox)
        Me.Controls.Add(Me.CoffeesListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Coffee Shop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.imgCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPastries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculateChange As Button
    Friend WithEvents txtCashTendered As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents TotalAmount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblChange As Label
    Friend WithEvents rdTakeout As RadioButton
    Friend WithEvents rdDinein As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnOrderHistory As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents OrdersummaryListBox As ListBox
    Friend WithEvents CoffeesListBox As ListBox
    Friend WithEvents TeaListBox As ListBox
    Friend WithEvents PastriesListBox As ListBox
    Friend WithEvents btnPushtoOrder As Button
    Friend WithEvents SizeCListbox As ListBox
    Friend WithEvents btnPushTea As Button
    Friend WithEvents btnPushPastry As Button
    Friend WithEvents SizeTListbox As ListBox
    Friend WithEvents rdCIced As RadioButton
    Friend WithEvents rdCHot As RadioButton
    Friend WithEvents rdTIced As RadioButton
    Friend WithEvents rdTHot As RadioButton
    Friend WithEvents txtcustomername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents imgCoffee As PictureBox
    Friend WithEvents imgTea As PictureBox
    Friend WithEvents imgPastries As PictureBox
    Friend WithEvents lblCoffeePrice As Label
    Friend WithEvents lblCoffeeName As Label
    Friend WithEvents lblTeaName As Label
    Friend WithEvents lblTeaPrice As Label
    Friend WithEvents lblPastryName As Label
    Friend WithEvents lblPastryPrice As Label
    Friend WithEvents btnUndo As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
