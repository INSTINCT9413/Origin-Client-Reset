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
        Me.OriginTheme1 = New Origin_Client_Reset.OriginTheme()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OriginTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OriginTheme1
        '
        Me.OriginTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OriginTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.OriginTheme1.Controls.Add(Me.Button1)
        Me.OriginTheme1.Customization = "JiYn//////8="
        Me.OriginTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OriginTheme1.Image = Nothing
        Me.OriginTheme1.Location = New System.Drawing.Point(0, 0)
        Me.OriginTheme1.Movable = True
        Me.OriginTheme1.Name = "OriginTheme1"
        Me.OriginTheme1.NoRounding = False
        Me.OriginTheme1.Sizable = True
        Me.OriginTheme1.Size = New System.Drawing.Size(461, 285)
        Me.OriginTheme1.SmartBounds = True
        Me.OriginTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.OriginTheme1.TabIndex = 0
        Me.OriginTheme1.Text = "OriginTheme1"
        Me.OriginTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme1.Transparent = False
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(434, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 285)
        Me.Controls.Add(Me.OriginTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Origin Client Reset"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OriginTheme1 As OriginTheme
    Friend WithEvents Button1 As Button
End Class
