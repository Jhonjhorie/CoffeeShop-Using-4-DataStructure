<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PendingOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblQuenumber = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPushTea = New System.Windows.Forms.Button()
        Me.OrderQueueListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCustname = New System.Windows.Forms.Label()
        Me.lbloutorin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblQuenumber)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 54)
        Me.Panel1.TabIndex = 0
        '
        'lblQuenumber
        '
        Me.lblQuenumber.AutoSize = True
        Me.lblQuenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuenumber.Location = New System.Drawing.Point(381, 9)
        Me.lblQuenumber.Name = "lblQuenumber"
        Me.lblQuenumber.Size = New System.Drawing.Size(0, 39)
        Me.lblQuenumber.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 39)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Order Queue "
        '
        'btnPushTea
        '
        Me.btnPushTea.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPushTea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPushTea.Location = New System.Drawing.Point(186, 378)
        Me.btnPushTea.Name = "btnPushTea"
        Me.btnPushTea.Size = New System.Drawing.Size(150, 60)
        Me.btnPushTea.TabIndex = 65
        Me.btnPushTea.Text = "Done"
        Me.btnPushTea.UseVisualStyleBackColor = False
        '
        'OrderQueueListBox
        '
        Me.OrderQueueListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderQueueListBox.FormattingEnabled = True
        Me.OrderQueueListBox.ItemHeight = 29
        Me.OrderQueueListBox.Location = New System.Drawing.Point(12, 92)
        Me.OrderQueueListBox.Name = "OrderQueueListBox"
        Me.OrderQueueListBox.Size = New System.Drawing.Size(506, 265)
        Me.OrderQueueListBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name:"
        '
        'LblCustname
        '
        Me.LblCustname.AutoSize = True
        Me.LblCustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustname.Location = New System.Drawing.Point(98, 61)
        Me.LblCustname.Name = "LblCustname"
        Me.LblCustname.Size = New System.Drawing.Size(0, 26)
        Me.LblCustname.TabIndex = 66
        '
        'lbloutorin
        '
        Me.lbloutorin.AutoSize = True
        Me.lbloutorin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutorin.Location = New System.Drawing.Point(391, 63)
        Me.lbloutorin.Name = "lbloutorin"
        Me.lbloutorin.Size = New System.Drawing.Size(0, 26)
        Me.lbloutorin.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "#"
        '
        'PendingOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(530, 450)
        Me.Controls.Add(Me.lbloutorin)
        Me.Controls.Add(Me.LblCustname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPushTea)
        Me.Controls.Add(Me.OrderQueueListBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PendingOrders"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPushTea As Button
    Friend WithEvents OrderQueueListBox As ListBox
    Friend WithEvents lblQuenumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCustname As Label
    Friend WithEvents lbloutorin As Label
    Friend WithEvents Label2 As Label
End Class
