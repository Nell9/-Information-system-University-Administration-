<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(236, 417)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(171, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Электробезопасность"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(236, 358)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(171, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Пожаробезопасность"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(236, 303)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Виды помещений"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Конструктивные особенности"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Помещения"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Корпуса"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(168, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Администрирование университета"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 641)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Администрирование университета"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
