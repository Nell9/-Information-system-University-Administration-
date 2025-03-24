<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
        Me.UniversityDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПомещенияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПомещенияTableAdapter = New WindowsApp1.universityDataSetTableAdapters.ПомещенияTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ПомещенияBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.КорпусаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КорпусаTableAdapter = New WindowsApp1.universityDataSetTableAdapters.КорпусаTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Me.Виды_помещенийTableAdapter1 = New WindowsApp1.universityDataSetTableAdapters.Виды_помещенийTableAdapter()
        Me.КорпусаBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ПомещенияDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Номер_корпусаComboBox = New System.Windows.Forms.ComboBox()
        Me.КорпусаBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.КорпусаBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversityDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПомещенияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ПомещенияBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КорпусаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КорпусаBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПомещенияDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КорпусаBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КорпусаBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UniversityDataSetBindingSource
        '
        Me.UniversityDataSetBindingSource.DataSource = Me.UniversityDataSet
        Me.UniversityDataSetBindingSource.Position = 0
        '
        'ПомещенияBindingSource
        '
        Me.ПомещенияBindingSource.DataMember = "Помещения"
        Me.ПомещенияBindingSource.DataSource = Me.UniversityDataSetBindingSource
        '
        'ПомещенияTableAdapter
        '
        Me.ПомещенияTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(603, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 397)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировка"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(9, 242)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(154, 17)
        Me.RadioButton2.TabIndex = 55
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Сортировка по убыванию"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 219)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(170, 17)
        Me.RadioButton1.TabIndex = 54
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Сортировка по возрастанию"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(47, 345)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(197, 23)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "Сортировать"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Поле для сортировки"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"[номер корпуса]", "[номер помещения]", "[этаж]", "[площадь]", "[объем]", "[вид помещения]", "[конструктивные особенности]", "[категория электро - безопасности]", "[категория пожаро-безопасности]", "[потребляемая мощность электроэнергии]", "[дата последнего капитального ремонта]", "[даты очередного текущего капитального ремонта]"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(283, 173)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(130, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 23)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Таблица поиска помещений"
        '
        'ПомещенияBindingSource1
        '
        Me.ПомещенияBindingSource1.DataMember = "Помещения"
        Me.ПомещенияBindingSource1.DataSource = Me.UniversityDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Корпус:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 513)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Критерий:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Найти"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(301, 474)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Фильтровать"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(805, 474)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Показать все"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(805, 503)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 23)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'КорпусаBindingSource
        '
        Me.КорпусаBindingSource.DataMember = "Корпуса"
        Me.КорпусаBindingSource.DataSource = Me.UniversityDataSet
        '
        'КорпусаTableAdapter
        '
        Me.КорпусаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Me.Виды_помещенийTableAdapter1
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Nothing
        Me.TableAdapterManager.КорпусаTableAdapter = Me.КорпусаTableAdapter
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Nothing
        Me.TableAdapterManager.ПомещенияTableAdapter = Me.ПомещенияTableAdapter
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Nothing
        '
        'Виды_помещенийTableAdapter1
        '
        Me.Виды_помещенийTableAdapter1.ClearBeforeFill = True
        '
        'КорпусаBindingSource1
        '
        Me.КорпусаBindingSource1.DataMember = "Корпуса"
        Me.КорпусаBindingSource1.DataSource = Me.UniversityDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 506)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 54
        '
        'ПомещенияDataGridView
        '
        Me.ПомещенияDataGridView.AutoGenerateColumns = False
        Me.ПомещенияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПомещенияDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ПомещенияDataGridView.DataSource = Me.ПомещенияBindingSource1
        Me.ПомещенияDataGridView.Location = New System.Drawing.Point(12, 59)
        Me.ПомещенияDataGridView.Name = "ПомещенияDataGridView"
        Me.ПомещенияDataGridView.Size = New System.Drawing.Size(594, 397)
        Me.ПомещенияDataGridView.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "номер корпуса"
        Me.DataGridViewTextBoxColumn1.HeaderText = "номер корпуса"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "номер помещения"
        Me.DataGridViewTextBoxColumn2.HeaderText = "номер помещения"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "этаж"
        Me.DataGridViewTextBoxColumn3.HeaderText = "этаж"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "площадь"
        Me.DataGridViewTextBoxColumn4.HeaderText = "площадь"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "объем"
        Me.DataGridViewTextBoxColumn5.HeaderText = "объем"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "вид помещения"
        Me.DataGridViewTextBoxColumn6.HeaderText = "вид помещения"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "конструктивные особенности"
        Me.DataGridViewTextBoxColumn7.HeaderText = "конструктивные особенности"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "категория электро - безопасности"
        Me.DataGridViewTextBoxColumn8.HeaderText = "категория электро - безопасности"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "категория пожаро-безопасности"
        Me.DataGridViewTextBoxColumn9.HeaderText = "категория пожаро-безопасности"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "потребляемая мощность электроэнергии"
        Me.DataGridViewTextBoxColumn10.HeaderText = "потребляемая мощность электроэнергии"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "дата последнего капитального ремонта"
        Me.DataGridViewTextBoxColumn11.HeaderText = "дата последнего капитального ремонта"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "даты очередного текущего капитального ремонта"
        Me.DataGridViewTextBoxColumn12.HeaderText = "даты очередного текущего капитального ремонта"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Номер_корпусаComboBox
        '
        Me.Номер_корпусаComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "номер корпуса", True))
        Me.Номер_корпусаComboBox.DataSource = Me.UniversityDataSet
        Me.Номер_корпусаComboBox.DisplayMember = "Корпуса.номер корпуса"
        Me.Номер_корпусаComboBox.FormattingEnabled = True
        Me.Номер_корпусаComboBox.Location = New System.Drawing.Point(88, 472)
        Me.Номер_корпусаComboBox.Name = "Номер_корпусаComboBox"
        Me.Номер_корпусаComboBox.Size = New System.Drawing.Size(207, 21)
        Me.Номер_корпусаComboBox.TabIndex = 64
        '
        'КорпусаBindingSource2
        '
        Me.КорпусаBindingSource2.DataMember = "Корпуса"
        Me.КорпусаBindingSource2.DataSource = Me.UniversityDataSet
        '
        'КорпусаBindingSource3
        '
        Me.КорпусаBindingSource3.DataMember = "Корпуса"
        Me.КорпусаBindingSource3.DataSource = Me.UniversityDataSetBindingSource
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 565)
        Me.Controls.Add(Me.Номер_корпусаComboBox)
        Me.Controls.Add(Me.ПомещенияDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "Таблица поиска помещений"
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversityDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПомещенияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ПомещенияBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КорпусаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КорпусаBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПомещенияDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КорпусаBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КорпусаBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UniversityDataSetBindingSource As BindingSource
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents ПомещенияBindingSource As BindingSource
    Friend WithEvents ПомещенияTableAdapter As universityDataSetTableAdapters.ПомещенияTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ПомещенияBindingSource1 As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents КорпусаBindingSource As BindingSource
    Friend WithEvents КорпусаTableAdapter As universityDataSetTableAdapters.КорпусаTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents КорпусаBindingSource1 As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Виды_помещенийTableAdapter1 As universityDataSetTableAdapters.Виды_помещенийTableAdapter
    Friend WithEvents ПомещенияDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Номер_корпусаComboBox As ComboBox
    Friend WithEvents КорпусаBindingSource2 As BindingSource
    Friend WithEvents КорпусаBindingSource3 As BindingSource
End Class
