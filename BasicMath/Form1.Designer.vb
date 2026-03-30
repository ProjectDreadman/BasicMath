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
        Me.extBnt = New System.Windows.Forms.Button()
        Me.BtnAdding = New System.Windows.Forms.Button()
        Me.btnMutiplcation = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'extBnt
        '
        Me.extBnt.Location = New System.Drawing.Point(705, 406)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(83, 32)
        Me.extBnt.TabIndex = 0
        Me.extBnt.Text = "Exit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'BtnAdding
        '
        Me.BtnAdding.Location = New System.Drawing.Point(51, 12)
        Me.BtnAdding.Name = "BtnAdding"
        Me.BtnAdding.Size = New System.Drawing.Size(93, 38)
        Me.BtnAdding.TabIndex = 1
        Me.BtnAdding.Text = "Add"
        Me.BtnAdding.UseVisualStyleBackColor = True
        '
        'btnMutiplcation
        '
        Me.btnMutiplcation.Location = New System.Drawing.Point(51, 97)
        Me.btnMutiplcation.Name = "btnMutiplcation"
        Me.btnMutiplcation.Size = New System.Drawing.Size(93, 37)
        Me.btnMutiplcation.TabIndex = 2
        Me.btnMutiplcation.Text = "Mutiply"
        Me.btnMutiplcation.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(51, 56)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(93, 35)
        Me.btnSubtract.TabIndex = 3
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(51, 140)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(93, 34)
        Me.btnDivide.TabIndex = 4
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(620, 39)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 26)
        Me.txt1.TabIndex = 5
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(620, 102)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 26)
        Me.txt2.TabIndex = 6
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(620, 241)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 26)
        Me.txtAnswer.TabIndex = 7
        '
        'txtNum1
        '
        Me.txtNum1.AutoSize = True
        Me.txtNum1.Location = New System.Drawing.Point(635, 12)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(76, 20)
        Me.txtNum1.TabIndex = 8
        Me.txtNum1.Text = "number 1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(635, 200)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 20)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Answer"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(635, 79)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 20)
        Me.label3.TabIndex = 10
        Me.label3.Text = "number 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnMutiplcation)
        Me.Controls.Add(Me.BtnAdding)
        Me.Controls.Add(Me.extBnt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents extBnt As Button
    Friend WithEvents BtnAdding As Button
    Friend WithEvents btnMutiplcation As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtNum1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
End Class
