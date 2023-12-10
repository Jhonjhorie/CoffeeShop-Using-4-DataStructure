<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerQueues
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNextQueue = New System.Windows.Forms.Button()
        Me.QueueListbox = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 54)
        Me.Panel1.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(142, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 39)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Order Queue "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 26)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Now Serving"
        '
        'btnNextQueue
        '
        Me.btnNextQueue.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnNextQueue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextQueue.Location = New System.Drawing.Point(9, 106)
        Me.btnNextQueue.Name = "btnNextQueue"
        Me.btnNextQueue.Size = New System.Drawing.Size(150, 60)
        Me.btnNextQueue.TabIndex = 71
        Me.btnNextQueue.Text = "Next"
        Me.btnNextQueue.UseVisualStyleBackColor = False
        '
        'QueueListbox
        '
        Me.QueueListbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueListbox.FormattingEnabled = True
        Me.QueueListbox.ItemHeight = 25
        Me.QueueListbox.Location = New System.Drawing.Point(165, 67)
        Me.QueueListbox.Name = "QueueListbox"
        Me.QueueListbox.Size = New System.Drawing.Size(337, 304)
        Me.QueueListbox.TabIndex = 72
        '
        'CustomerQueues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 392)
        Me.Controls.Add(Me.QueueListbox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNextQueue)
        Me.Name = "CustomerQueues"
        Me.Text = "CustomerQueues"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNextQueue As Button
    Friend WithEvents QueueListbox As ListBox
End Class
