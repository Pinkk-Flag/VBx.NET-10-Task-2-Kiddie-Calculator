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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.lblEqual = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textbox5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNumber1.Location = New System.Drawing.Point(12, 144)
        Me.txtNumber1.Multiline = True
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(164, 99)
        Me.txtNumber1.TabIndex = 0
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAnswer.Location = New System.Drawing.Point(612, 144)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(164, 99)
        Me.txtAnswer.TabIndex = 1
        '
        'txtNumber2
        '
        Me.txtNumber2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNumber2.Location = New System.Drawing.Point(333, 144)
        Me.txtNumber2.Multiline = True
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(164, 99)
        Me.txtNumber2.TabIndex = 2
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnPlus.Location = New System.Drawing.Point(216, 346)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(81, 67)
        Me.btnPlus.TabIndex = 3
        Me.btnPlus.Text = "/"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'lblEqual
        '
        Me.lblEqual.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblEqual.Location = New System.Drawing.Point(514, 160)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(81, 67)
        Me.lblEqual.TabIndex = 4
        Me.lblEqual.Text = "="
        Me.lblEqual.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(216, 254)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(81, 67)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "*"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.Location = New System.Drawing.Point(216, 160)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(81, 67)
        Me.btnMultiply.TabIndex = 6
        Me.btnMultiply.Text = "-"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnMinus.Location = New System.Drawing.Point(216, 70)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(81, 67)
        Me.btnMinus.TabIndex = 7
        Me.btnMinus.Text = "+"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(612, 298)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 67)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(612, 371)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(164, 67)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'textbox5
        '
        Me.textbox5.BackColor = System.Drawing.Color.DimGray
        Me.textbox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.textbox5.Font = New System.Drawing.Font("STIXGeneral", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textbox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.textbox5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.textbox5.Location = New System.Drawing.Point(612, 12)
        Me.textbox5.Name = "textbox5"
        Me.textbox5.Size = New System.Drawing.Size(164, 67)
        Me.textbox5.TabIndex = 11
        Me.textbox5.Text = "Help"
        Me.textbox5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.textbox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtNumber1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents lblEqual As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textbox5 As Button
End Class
