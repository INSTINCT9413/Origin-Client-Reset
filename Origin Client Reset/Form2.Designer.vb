<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.OriginForm1 = New Origin_Client_Reset.OriginForm()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OriginButton1 = New Origin_Client_Reset.OriginButton()
        Me.OriginTopButton1 = New Origin_Client_Reset.OriginTopButton()
        Me.OriginForm1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OriginForm1
        '
        Me.OriginForm1.BackColor = System.Drawing.Color.White
        Me.OriginForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.OriginForm1.BottomStyle = Origin_Client_Reset.OriginForm.BottomType.Rounded
        Me.OriginForm1.Colors = New Origin_Client_Reset.Bloom(-1) {}
        Me.OriginForm1.Controls.Add(Me.Button1)
        Me.OriginForm1.Controls.Add(Me.Label1)
        Me.OriginForm1.Controls.Add(Me.PictureBox2)
        Me.OriginForm1.Controls.Add(Me.PictureBox1)
        Me.OriginForm1.Controls.Add(Me.OriginButton1)
        Me.OriginForm1.Controls.Add(Me.OriginTopButton1)
        Me.OriginForm1.Customization = ""
        Me.OriginForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginForm1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.OriginForm1.GreyRectangle = True
        Me.OriginForm1.Image = Nothing
        Me.OriginForm1.Location = New System.Drawing.Point(0, 0)
        Me.OriginForm1.Movable = True
        Me.OriginForm1.Name = "OriginForm1"
        Me.OriginForm1.NoRounding = False
        Me.OriginForm1.ShowIcon = True
        Me.OriginForm1.Sizable = False
        Me.OriginForm1.Size = New System.Drawing.Size(449, 379)
        Me.OriginForm1.SmartBounds = True
        Me.OriginForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.OriginForm1.TabIndex = 0
        Me.OriginForm1.Text = "Origin Client Reset Tool"
        Me.OriginForm1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginForm1.Transparent = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Checking..."
        Me.Label1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Origin_Client_Reset.My.Resources.Resources.loading
        Me.PictureBox2.Location = New System.Drawing.Point(87, 226)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 13)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Origin_Client_Reset.My.Resources.Resources.Origin_logo
        Me.PictureBox1.Location = New System.Drawing.Point(149, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'OriginButton1
        '
        Me.OriginButton1.Colors = New Origin_Client_Reset.Bloom(-1) {}
        Me.OriginButton1.Customization = ""
        Me.OriginButton1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OriginButton1.Image = Nothing
        Me.OriginButton1.Location = New System.Drawing.Point(148, 263)
        Me.OriginButton1.Name = "OriginButton1"
        Me.OriginButton1.NoRounding = False
        Me.OriginButton1.Size = New System.Drawing.Size(152, 44)
        Me.OriginButton1.TabIndex = 1
        Me.OriginButton1.Text = "RESET ORIGIN"
        Me.OriginButton1.Transparent = False
        '
        'OriginTopButton1
        '
        Me.OriginTopButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OriginTopButton1.BackColor = System.Drawing.Color.White
        Me.OriginTopButton1.ButtonType = Origin_Client_Reset.OriginTopButton.BType.Close
        Me.OriginTopButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OriginTopButton1.Font = New System.Drawing.Font("Marlett", 8.0!)
        Me.OriginTopButton1.Location = New System.Drawing.Point(423, 3)
        Me.OriginTopButton1.Name = "OriginTopButton1"
        Me.OriginTopButton1.Size = New System.Drawing.Size(23, 18)
        Me.OriginTopButton1.TabIndex = 0
        Me.OriginTopButton1.Text = "OriginTopButton1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 379)
        Me.Controls.Add(Me.OriginForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginForm1.ResumeLayout(False)
        Me.OriginForm1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OriginForm1 As OriginForm
    Friend WithEvents OriginButton1 As OriginButton
    Friend WithEvents OriginTopButton1 As OriginTopButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
