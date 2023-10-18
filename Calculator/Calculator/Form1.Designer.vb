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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblOperand1 = New System.Windows.Forms.Label()
        Me.lblOperand2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.lblShowOperator = New System.Windows.Forms.Label()
        Me.lblShowResult = New System.Windows.Forms.Label()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnSubstraction = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnIntegerDivision = New System.Windows.Forms.Button()
        Me.btnFloatingPoint = New System.Windows.Forms.Button()
        Me.btnExponentiation = New System.Windows.Forms.Button()
        Me.btnModulus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShowResult)
        Me.GroupBox1.Controls.Add(Me.lblShowOperator)
        Me.GroupBox1.Controls.Add(Me.txtOperand2)
        Me.GroupBox1.Controls.Add(Me.txtOperand1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblOperand2)
        Me.GroupBox1.Controls.Add(Me.lblOperand1)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 319)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnModulus)
        Me.GroupBox2.Controls.Add(Me.btnExponentiation)
        Me.GroupBox2.Controls.Add(Me.btnFloatingPoint)
        Me.GroupBox2.Controls.Add(Me.btnIntegerDivision)
        Me.GroupBox2.Controls.Add(Me.btnMultiplication)
        Me.GroupBox2.Controls.Add(Me.btnSubstraction)
        Me.GroupBox2.Controls.Add(Me.btnAddition)
        Me.GroupBox2.Location = New System.Drawing.Point(539, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 198)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operators:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(265, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(147, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "SIMPLE CALCULATOR"
        '
        'lblOperand1
        '
        Me.lblOperand1.AutoSize = True
        Me.lblOperand1.Location = New System.Drawing.Point(6, 32)
        Me.lblOperand1.Name = "lblOperand1"
        Me.lblOperand1.Size = New System.Drawing.Size(67, 16)
        Me.lblOperand1.TabIndex = 0
        Me.lblOperand1.Text = "Operand1"
        '
        'lblOperand2
        '
        Me.lblOperand2.AutoSize = True
        Me.lblOperand2.Location = New System.Drawing.Point(3, 140)
        Me.lblOperand2.Name = "lblOperand2"
        Me.lblOperand2.Size = New System.Drawing.Size(67, 16)
        Me.lblOperand2.TabIndex = 2
        Me.lblOperand2.Text = "Operand2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Result:"
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(6, 54)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(122, 22)
        Me.txtOperand1.TabIndex = 4
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(6, 168)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(122, 22)
        Me.txtOperand2.TabIndex = 5
        '
        'lblShowOperator
        '
        Me.lblShowOperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowOperator.Location = New System.Drawing.Point(9, 90)
        Me.lblShowOperator.Name = "lblShowOperator"
        Me.lblShowOperator.Size = New System.Drawing.Size(100, 23)
        Me.lblShowOperator.TabIndex = 2
        '
        'lblShowResult
        '
        Me.lblShowResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowResult.Location = New System.Drawing.Point(6, 247)
        Me.lblShowResult.Name = "lblShowResult"
        Me.lblShowResult.Size = New System.Drawing.Size(100, 23)
        Me.lblShowResult.TabIndex = 6
        '
        'btnAddition
        '
        Me.btnAddition.Location = New System.Drawing.Point(7, 24)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(75, 23)
        Me.btnAddition.TabIndex = 0
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnSubstraction
        '
        Me.btnSubstraction.Location = New System.Drawing.Point(103, 24)
        Me.btnSubstraction.Name = "btnSubstraction"
        Me.btnSubstraction.Size = New System.Drawing.Size(75, 23)
        Me.btnSubstraction.TabIndex = 1
        Me.btnSubstraction.Text = "-"
        Me.btnSubstraction.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Location = New System.Drawing.Point(7, 73)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplication.TabIndex = 2
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnIntegerDivision
        '
        Me.btnIntegerDivision.Location = New System.Drawing.Point(103, 73)
        Me.btnIntegerDivision.Name = "btnIntegerDivision"
        Me.btnIntegerDivision.Size = New System.Drawing.Size(75, 23)
        Me.btnIntegerDivision.TabIndex = 3
        Me.btnIntegerDivision.Text = "\"
        Me.btnIntegerDivision.UseVisualStyleBackColor = True
        '
        'btnFloatingPoint
        '
        Me.btnFloatingPoint.Location = New System.Drawing.Point(6, 113)
        Me.btnFloatingPoint.Name = "btnFloatingPoint"
        Me.btnFloatingPoint.Size = New System.Drawing.Size(75, 23)
        Me.btnFloatingPoint.TabIndex = 4
        Me.btnFloatingPoint.Text = "/"
        Me.btnFloatingPoint.UseVisualStyleBackColor = True
        '
        'btnExponentiation
        '
        Me.btnExponentiation.Location = New System.Drawing.Point(103, 113)
        Me.btnExponentiation.Name = "btnExponentiation"
        Me.btnExponentiation.Size = New System.Drawing.Size(75, 23)
        Me.btnExponentiation.TabIndex = 5
        Me.btnExponentiation.Text = "^"
        Me.btnExponentiation.UseVisualStyleBackColor = True
        '
        'btnModulus
        '
        Me.btnModulus.Location = New System.Drawing.Point(7, 145)
        Me.btnModulus.Name = "btnModulus"
        Me.btnModulus.Size = New System.Drawing.Size(171, 45)
        Me.btnModulus.TabIndex = 6
        Me.btnModulus.Text = "MOD"
        Me.btnModulus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(72, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 45)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(539, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 45)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SimpleCalculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblOperand1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblOperand2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOperand2 As TextBox
    Friend WithEvents txtOperand1 As TextBox
    Friend WithEvents lblShowOperator As Label
    Friend WithEvents lblShowResult As Label
    Friend WithEvents btnIntegerDivision As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnSubstraction As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnModulus As Button
    Friend WithEvents btnExponentiation As Button
    Friend WithEvents btnFloatingPoint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
