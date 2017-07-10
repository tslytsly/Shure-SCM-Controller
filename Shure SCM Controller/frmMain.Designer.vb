<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnMuteCh1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bgdWorkerNetRead = New System.ComponentModel.BackgroundWorker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMuteCh2 = New System.Windows.Forms.Button()
        Me.btnMuteCh3 = New System.Windows.Forms.Button()
        Me.btnMuteCh4 = New System.Windows.Forms.Button()
        Me.btnMuteCh5 = New System.Windows.Forms.Button()
        Me.btnMuteCh6 = New System.Windows.Forms.Button()
        Me.btnMuteCh7 = New System.Windows.Forms.Button()
        Me.btnMuteCh8 = New System.Windows.Forms.Button()
        Me.bgdWorkerNetWrite = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'btnMuteCh1
        '
        Me.btnMuteCh1.Location = New System.Drawing.Point(12, 317)
        Me.btnMuteCh1.Name = "btnMuteCh1"
        Me.btnMuteCh1.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh1.TabIndex = 0
        Me.btnMuteCh1.Text = "Channel 1"
        Me.btnMuteCh1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 218)
        Me.TextBox1.TabIndex = 1
        '
        'bgdWorkerNetRead
        '
        Me.bgdWorkerNetRead.WorkerReportsProgress = True
        Me.bgdWorkerNetRead.WorkerSupportsCancellation = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(388, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnMuteCh2
        '
        Me.btnMuteCh2.Location = New System.Drawing.Point(93, 317)
        Me.btnMuteCh2.Name = "btnMuteCh2"
        Me.btnMuteCh2.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh2.TabIndex = 0
        Me.btnMuteCh2.Text = "Channel 2"
        Me.btnMuteCh2.UseVisualStyleBackColor = True
        '
        'btnMuteCh3
        '
        Me.btnMuteCh3.Location = New System.Drawing.Point(174, 317)
        Me.btnMuteCh3.Name = "btnMuteCh3"
        Me.btnMuteCh3.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh3.TabIndex = 0
        Me.btnMuteCh3.Text = "Channel 3"
        Me.btnMuteCh3.UseVisualStyleBackColor = True
        '
        'btnMuteCh4
        '
        Me.btnMuteCh4.Location = New System.Drawing.Point(255, 317)
        Me.btnMuteCh4.Name = "btnMuteCh4"
        Me.btnMuteCh4.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh4.TabIndex = 0
        Me.btnMuteCh4.Text = "Channel 4"
        Me.btnMuteCh4.UseVisualStyleBackColor = True
        '
        'btnMuteCh5
        '
        Me.btnMuteCh5.Location = New System.Drawing.Point(336, 317)
        Me.btnMuteCh5.Name = "btnMuteCh5"
        Me.btnMuteCh5.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh5.TabIndex = 0
        Me.btnMuteCh5.Text = "Channel 5"
        Me.btnMuteCh5.UseVisualStyleBackColor = True
        '
        'btnMuteCh6
        '
        Me.btnMuteCh6.Location = New System.Drawing.Point(417, 317)
        Me.btnMuteCh6.Name = "btnMuteCh6"
        Me.btnMuteCh6.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh6.TabIndex = 0
        Me.btnMuteCh6.Text = "Channel 6"
        Me.btnMuteCh6.UseVisualStyleBackColor = True
        '
        'btnMuteCh7
        '
        Me.btnMuteCh7.Location = New System.Drawing.Point(498, 317)
        Me.btnMuteCh7.Name = "btnMuteCh7"
        Me.btnMuteCh7.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh7.TabIndex = 0
        Me.btnMuteCh7.Text = "Channel 7"
        Me.btnMuteCh7.UseVisualStyleBackColor = True
        '
        'btnMuteCh8
        '
        Me.btnMuteCh8.Location = New System.Drawing.Point(579, 317)
        Me.btnMuteCh8.Name = "btnMuteCh8"
        Me.btnMuteCh8.Size = New System.Drawing.Size(75, 23)
        Me.btnMuteCh8.TabIndex = 0
        Me.btnMuteCh8.Text = "Channel 8"
        Me.btnMuteCh8.UseVisualStyleBackColor = True
        '
        'bgdWorkerNetWrite
        '
        Me.bgdWorkerNetWrite.WorkerReportsProgress = True
        Me.bgdWorkerNetWrite.WorkerSupportsCancellation = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 352)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnMuteCh8)
        Me.Controls.Add(Me.btnMuteCh7)
        Me.Controls.Add(Me.btnMuteCh6)
        Me.Controls.Add(Me.btnMuteCh5)
        Me.Controls.Add(Me.btnMuteCh4)
        Me.Controls.Add(Me.btnMuteCh3)
        Me.Controls.Add(Me.btnMuteCh2)
        Me.Controls.Add(Me.btnMuteCh1)
        Me.Name = "frmMain"
        Me.Text = "im "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMuteCh1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bgdWorkerNetRead As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnMuteCh2 As Button
    Friend WithEvents btnMuteCh3 As Button
    Friend WithEvents btnMuteCh4 As Button
    Friend WithEvents btnMuteCh5 As Button
    Friend WithEvents btnMuteCh6 As Button
    Friend WithEvents btnMuteCh7 As Button
    Friend WithEvents btnMuteCh8 As Button
    Friend WithEvents bgdWorkerNetWrite As System.ComponentModel.BackgroundWorker
End Class
