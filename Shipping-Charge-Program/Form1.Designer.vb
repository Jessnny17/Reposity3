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
        Me.components = New System.ComponentModel.Container()
        Me.Calculate_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Pound_textbox = New System.Windows.Forms.TextBox()
        Me.Ounce_textbox = New System.Windows.Forms.TextBox()
        Me.Package_identifier = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Total_Label = New System.Windows.Forms.Label()
        Me.Total_Box = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calculate_Button
        '
        Me.Calculate_Button.Location = New System.Drawing.Point(241, 100)
        Me.Calculate_Button.Name = "Calculate_Button"
        Me.Calculate_Button.Size = New System.Drawing.Size(96, 33)
        Me.Calculate_Button.TabIndex = 2
        Me.Calculate_Button.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.Calculate_Button, "Calculate Ship-Cost")
        Me.Calculate_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(241, 136)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(96, 33)
        Me.Clear_Button.TabIndex = 3
        Me.Clear_Button.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Clear_Button, "Clear all Form Data")
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Print_Button
        '
        Me.Print_Button.Location = New System.Drawing.Point(345, 100)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(96, 33)
        Me.Print_Button.TabIndex = 4
        Me.Print_Button.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.Print_Button, "Print")
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(345, 136)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(96, 33)
        Me.Exit_Button.TabIndex = 5
        Me.Exit_Button.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.Exit_Button, "Exit Program")
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Pound_textbox
        '
        Me.Pound_textbox.Location = New System.Drawing.Point(55, 32)
        Me.Pound_textbox.Name = "Pound_textbox"
        Me.Pound_textbox.Size = New System.Drawing.Size(59, 20)
        Me.Pound_textbox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Pound_textbox, "Enter weight (in pounds)")
        '
        'Ounce_textbox
        '
        Me.Ounce_textbox.Location = New System.Drawing.Point(55, 66)
        Me.Ounce_textbox.Name = "Ounce_textbox"
        Me.Ounce_textbox.Size = New System.Drawing.Size(59, 20)
        Me.Ounce_textbox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Ounce_textbox, "Enter weight (in ounces)")
        '
        'Package_identifier
        '
        Me.Package_identifier.Location = New System.Drawing.Point(105, 21)
        Me.Package_identifier.Mask = "000000"
        Me.Package_identifier.Name = "Package_identifier"
        Me.Package_identifier.Size = New System.Drawing.Size(100, 20)
        Me.Package_identifier.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Package_identifier, "Enter Package ID code")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Package Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pounds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ounces"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Ounce_textbox)
        Me.GroupBox1.Controls.Add(Me.Pound_textbox)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 99)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please enter Object Weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(306, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Programmed by: Deon Lundy"
        '
        'Total_Label
        '
        Me.Total_Label.AutoSize = True
        Me.Total_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Label.Location = New System.Drawing.Point(251, 52)
        Me.Total_Label.Name = "Total_Label"
        Me.Total_Label.Size = New System.Drawing.Size(86, 25)
        Me.Total_Label.TabIndex = 12
        Me.Total_Label.Text = "TOTAL:"
        Me.Total_Label.Visible = False
        '
        'Total_Box
        '
        Me.Total_Box.BackColor = System.Drawing.SystemColors.Control
        Me.Total_Box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Total_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Box.ForeColor = System.Drawing.Color.Red
        Me.Total_Box.Location = New System.Drawing.Point(343, 52)
        Me.Total_Box.Name = "Total_Box"
        Me.Total_Box.ReadOnly = True
        Me.Total_Box.Size = New System.Drawing.Size(100, 24)
        Me.Total_Box.TabIndex = 13
        Me.Total_Box.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 215)
        Me.Controls.Add(Me.Total_Box)
        Me.Controls.Add(Me.Total_Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Package_identifier)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Print_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Calculate_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Calculate_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_Button As System.Windows.Forms.Button
    Friend WithEvents Print_Button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Pound_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Ounce_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Package_identifier As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Total_Label As System.Windows.Forms.Label
    Friend WithEvents Total_Box As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
