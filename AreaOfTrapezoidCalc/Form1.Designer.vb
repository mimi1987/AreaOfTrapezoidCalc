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
        Me.LBLowerBase = New System.Windows.Forms.Label()
        Me.TBLowerBase = New System.Windows.Forms.TextBox()
        Me.BTNCalcArea = New System.Windows.Forms.Button()
        Me.TBUpperBase = New System.Windows.Forms.TextBox()
        Me.LBUpperBase = New System.Windows.Forms.Label()
        Me.TBHeight = New System.Windows.Forms.TextBox()
        Me.LBHeight = New System.Windows.Forms.Label()
        Me.TBArea = New System.Windows.Forms.TextBox()
        Me.LBArea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLowerBase
        '
        Me.LBLowerBase.AutoSize = True
        Me.LBLowerBase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBLowerBase.Location = New System.Drawing.Point(54, 30)
        Me.LBLowerBase.Name = "LBLowerBase"
        Me.LBLowerBase.Size = New System.Drawing.Size(71, 15)
        Me.LBLowerBase.TabIndex = 0
        Me.LBLowerBase.Text = "Lower Base"
        '
        'TBLowerBase
        '
        Me.TBLowerBase.Location = New System.Drawing.Point(144, 27)
        Me.TBLowerBase.Name = "TBLowerBase"
        Me.TBLowerBase.Size = New System.Drawing.Size(100, 23)
        Me.TBLowerBase.TabIndex = 1
        '
        'BTNCalcArea
        '
        Me.BTNCalcArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNCalcArea.Location = New System.Drawing.Point(127, 242)
        Me.BTNCalcArea.Name = "BTNCalcArea"
        Me.BTNCalcArea.Size = New System.Drawing.Size(75, 23)
        Me.BTNCalcArea.TabIndex = 4
        Me.BTNCalcArea.Text = "Calc Area"
        Me.BTNCalcArea.UseVisualStyleBackColor = True
        '
        'TBUpperBase
        '
        Me.TBUpperBase.Location = New System.Drawing.Point(144, 66)
        Me.TBUpperBase.Name = "TBUpperBase"
        Me.TBUpperBase.Size = New System.Drawing.Size(100, 23)
        Me.TBUpperBase.TabIndex = 2
        '
        'LBUpperBase
        '
        Me.LBUpperBase.AutoSize = True
        Me.LBUpperBase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBUpperBase.Location = New System.Drawing.Point(54, 69)
        Me.LBUpperBase.Name = "LBUpperBase"
        Me.LBUpperBase.Size = New System.Drawing.Size(71, 15)
        Me.LBUpperBase.TabIndex = 3
        Me.LBUpperBase.Text = "Upper Base"
        '
        'TBHeight
        '
        Me.TBHeight.Location = New System.Drawing.Point(144, 112)
        Me.TBHeight.Name = "TBHeight"
        Me.TBHeight.Size = New System.Drawing.Size(100, 23)
        Me.TBHeight.TabIndex = 3
        '
        'LBHeight
        '
        Me.LBHeight.AutoSize = True
        Me.LBHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBHeight.Location = New System.Drawing.Point(54, 115)
        Me.LBHeight.Name = "LBHeight"
        Me.LBHeight.Size = New System.Drawing.Size(45, 15)
        Me.LBHeight.TabIndex = 5
        Me.LBHeight.Text = "Height"
        '
        'TBArea
        '
        Me.TBArea.Location = New System.Drawing.Point(144, 161)
        Me.TBArea.Name = "TBArea"
        Me.TBArea.Size = New System.Drawing.Size(100, 23)
        Me.TBArea.TabIndex = 5
        '
        'LBArea
        '
        Me.LBArea.AutoSize = True
        Me.LBArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBArea.Location = New System.Drawing.Point(54, 164)
        Me.LBArea.Name = "LBArea"
        Me.LBArea.Size = New System.Drawing.Size(33, 15)
        Me.LBArea.TabIndex = 7
        Me.LBArea.Text = "Area"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.TBArea)
        Me.Controls.Add(Me.LBArea)
        Me.Controls.Add(Me.TBHeight)
        Me.Controls.Add(Me.LBHeight)
        Me.Controls.Add(Me.TBUpperBase)
        Me.Controls.Add(Me.LBUpperBase)
        Me.Controls.Add(Me.BTNCalcArea)
        Me.Controls.Add(Me.TBLowerBase)
        Me.Controls.Add(Me.LBLowerBase)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area of Trapezoid Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLowerBase As Label
    Friend WithEvents TBLowerBase As TextBox
    Friend WithEvents BTNCalcArea As Button
    Friend WithEvents TBUpperBase As TextBox
    Friend WithEvents LBUpperBase As Label
    Friend WithEvents TBHeight As TextBox
    Friend WithEvents LBHeight As Label
    Friend WithEvents TBArea As TextBox
    Friend WithEvents LBArea As Label
End Class
