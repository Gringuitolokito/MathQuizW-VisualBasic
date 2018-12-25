<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plusLeftLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.plusRightLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.NumericUpDown()
        Me.timesRightLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.timesLeftLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.minusRightLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.minusLeftLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dividedLeftLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dividedRightLabel = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.NumericUpDown()
        Me.quotient = New System.Windows.Forms.NumericUpDown()
        Me.difference = New System.Windows.Forms.NumericUpDown()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CurrentDate = New System.Windows.Forms.Label()
        CType(Me.sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeLabel
        '
        Me.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(470, 9)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(200, 30)
        Me.timeLabel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time Left:"
        '
        'plusLeftLabel
        '
        Me.plusLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusLeftLabel.Location = New System.Drawing.Point(50, 75)
        Me.plusLeftLabel.Name = "plusLeftLabel"
        Me.plusLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.plusLeftLabel.TabIndex = 2
        Me.plusLeftLabel.Text = "?"
        Me.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plusRightLabel
        '
        Me.plusRightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusRightLabel.Location = New System.Drawing.Point(182, 75)
        Me.plusRightLabel.Name = "plusRightLabel"
        Me.plusRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.plusRightLabel.TabIndex = 4
        Me.plusRightLabel.Text = "?"
        Me.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 50)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "+"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sum
        '
        Me.sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum.Location = New System.Drawing.Point(314, 80)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(100, 41)
        Me.sum.TabIndex = 2
        '
        'timesRightLabel
        '
        Me.timesRightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timesRightLabel.Location = New System.Drawing.Point(182, 220)
        Me.timesRightLabel.Name = "timesRightLabel"
        Me.timesRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.timesRightLabel.TabIndex = 7
        Me.timesRightLabel.Text = "?"
        Me.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 50)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "×"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesLeftLabel
        '
        Me.timesLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timesLeftLabel.Location = New System.Drawing.Point(50, 220)
        Me.timesLeftLabel.Name = "timesLeftLabel"
        Me.timesLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.timesLeftLabel.TabIndex = 9
        Me.timesLeftLabel.Text = "?"
        Me.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(248, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 50)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusRightLabel
        '
        Me.minusRightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusRightLabel.Location = New System.Drawing.Point(182, 141)
        Me.minusRightLabel.Name = "minusRightLabel"
        Me.minusRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.minusRightLabel.TabIndex = 11
        Me.minusRightLabel.Text = "?"
        Me.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 50)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "-"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusLeftLabel
        '
        Me.minusLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusLeftLabel.Location = New System.Drawing.Point(50, 141)
        Me.minusLeftLabel.Name = "minusLeftLabel"
        Me.minusLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.minusLeftLabel.TabIndex = 13
        Me.minusLeftLabel.Text = "?"
        Me.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(116, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 50)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "÷"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dividedLeftLabel
        '
        Me.dividedLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividedLeftLabel.Location = New System.Drawing.Point(50, 290)
        Me.dividedLeftLabel.Name = "dividedLeftLabel"
        Me.dividedLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.dividedLeftLabel.TabIndex = 15
        Me.dividedLeftLabel.Text = "?"
        Me.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(248, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 50)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "="
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(248, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 50)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "="
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dividedRightLabel
        '
        Me.dividedRightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividedRightLabel.Location = New System.Drawing.Point(182, 290)
        Me.dividedRightLabel.Name = "dividedRightLabel"
        Me.dividedRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.dividedRightLabel.TabIndex = 18
        Me.dividedRightLabel.Text = "?"
        Me.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'product
        '
        Me.product.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product.Location = New System.Drawing.Point(314, 225)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(100, 41)
        Me.product.TabIndex = 4
        '
        'quotient
        '
        Me.quotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quotient.Location = New System.Drawing.Point(314, 295)
        Me.quotient.Name = "quotient"
        Me.quotient.Size = New System.Drawing.Size(100, 41)
        Me.quotient.TabIndex = 5
        '
        'difference
        '
        Me.difference.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difference.Location = New System.Drawing.Point(314, 146)
        Me.difference.Name = "difference"
        Me.difference.Size = New System.Drawing.Size(100, 41)
        Me.difference.TabIndex = 3
        '
        'startButton
        '
        Me.startButton.AutoSize = True
        Me.startButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(254, 406)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(172, 39)
        Me.startButton.TabIndex = 1
        Me.startButton.Text = "Start the Quiz!"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CurrentDate
        '
        Me.CurrentDate.AutoSize = True
        Me.CurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDate.Location = New System.Drawing.Point(12, 9)
        Me.CurrentDate.Name = "CurrentDate"
        Me.CurrentDate.Size = New System.Drawing.Size(0, 29)
        Me.CurrentDate.TabIndex = 19
        Me.CurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 473)
        Me.Controls.Add(Me.CurrentDate)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.difference)
        Me.Controls.Add(Me.quotient)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.dividedRightLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dividedLeftLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.minusLeftLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.minusRightLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.timesLeftLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.timesRightLabel)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.plusRightLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.plusLeftLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Erik Martinez's Math Quiz"
        CType(Me.sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusLeftLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents plusRightLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents timesRightLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents timesLeftLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents minusRightLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents minusLeftLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dividedLeftLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dividedRightLabel As Label
    Friend WithEvents product As NumericUpDown
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents startButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CurrentDate As Label
End Class
