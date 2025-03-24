<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Электробезопасность
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Электробезопасность))
        Dim Код_электробезопасностиLabel As System.Windows.Forms.Label
        Dim Описание_кодаLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
        Me.ЭлектробезопасностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЭлектробезопасностьTableAdapter = New WindowsApp1.universityDataSetTableAdapters.ЭлектробезопасностьTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Me.ЭлектробезопасностьBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ЭлектробезопасностьBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Код_электробезопасностиTextBox = New System.Windows.Forms.TextBox()
        Me.Описание_кодаTextBox = New System.Windows.Forms.TextBox()
        Код_электробезопасностиLabel = New System.Windows.Forms.Label()
        Описание_кодаLabel = New System.Windows.Forms.Label()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЭлектробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЭлектробезопасностьBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ЭлектробезопасностьBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(117, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Электробезопасность"
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЭлектробезопасностьBindingSource
        '
        Me.ЭлектробезопасностьBindingSource.DataMember = "Электробезопасность"
        Me.ЭлектробезопасностьBindingSource.DataSource = Me.UniversityDataSet
        '
        'ЭлектробезопасностьTableAdapter
        '
        Me.ЭлектробезопасностьTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Nothing
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Nothing
        Me.TableAdapterManager.КорпусаTableAdapter = Nothing
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Nothing
        Me.TableAdapterManager.ПомещенияTableAdapter = Nothing
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Me.ЭлектробезопасностьTableAdapter
        '
        'ЭлектробезопасностьBindingNavigator
        '
        Me.ЭлектробезопасностьBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ЭлектробезопасностьBindingNavigator.BindingSource = Me.ЭлектробезопасностьBindingSource
        Me.ЭлектробезопасностьBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ЭлектробезопасностьBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ЭлектробезопасностьBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ЭлектробезопасностьBindingNavigatorSaveItem})
        Me.ЭлектробезопасностьBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ЭлектробезопасностьBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ЭлектробезопасностьBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ЭлектробезопасностьBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ЭлектробезопасностьBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ЭлектробезопасностьBindingNavigator.Name = "ЭлектробезопасностьBindingNavigator"
        Me.ЭлектробезопасностьBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ЭлектробезопасностьBindingNavigator.Size = New System.Drawing.Size(601, 25)
        Me.ЭлектробезопасностьBindingNavigator.TabIndex = 47
        Me.ЭлектробезопасностьBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'ЭлектробезопасностьBindingNavigatorSaveItem
        '
        Me.ЭлектробезопасностьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ЭлектробезопасностьBindingNavigatorSaveItem.Image = CType(resources.GetObject("ЭлектробезопасностьBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ЭлектробезопасностьBindingNavigatorSaveItem.Name = "ЭлектробезопасностьBindingNavigatorSaveItem"
        Me.ЭлектробезопасностьBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ЭлектробезопасностьBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Код_электробезопасностиLabel
        '
        Код_электробезопасностиLabel.AutoSize = True
        Код_электробезопасностиLabel.Location = New System.Drawing.Point(69, 123)
        Код_электробезопасностиLabel.Name = "Код_электробезопасностиLabel"
        Код_электробезопасностиLabel.Size = New System.Drawing.Size(144, 13)
        Код_электробезопасностиLabel.TabIndex = 47
        Код_электробезопасностиLabel.Text = "Код электробезопасности:"
        '
        'Код_электробезопасностиTextBox
        '
        Me.Код_электробезопасностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектробезопасностьBindingSource, "Код электробезопасности", True))
        Me.Код_электробезопасностиTextBox.Location = New System.Drawing.Point(286, 120)
        Me.Код_электробезопасностиTextBox.Name = "Код_электробезопасностиTextBox"
        Me.Код_электробезопасностиTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Код_электробезопасностиTextBox.TabIndex = 48
        '
        'Описание_кодаLabel
        '
        Описание_кодаLabel.AutoSize = True
        Описание_кодаLabel.Location = New System.Drawing.Point(68, 149)
        Описание_кодаLabel.Name = "Описание_кодаLabel"
        Описание_кодаLabel.Size = New System.Drawing.Size(87, 13)
        Описание_кодаLabel.TabIndex = 48
        Описание_кодаLabel.Text = "Описание кода:"
        '
        'Описание_кодаTextBox
        '
        Me.Описание_кодаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектробезопасностьBindingSource, "Описание кода", True))
        Me.Описание_кодаTextBox.Location = New System.Drawing.Point(286, 146)
        Me.Описание_кодаTextBox.Name = "Описание_кодаTextBox"
        Me.Описание_кодаTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Описание_кодаTextBox.TabIndex = 49
        '
        'Электробезопасность
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 287)
        Me.Controls.Add(Описание_кодаLabel)
        Me.Controls.Add(Me.Описание_кодаTextBox)
        Me.Controls.Add(Код_электробезопасностиLabel)
        Me.Controls.Add(Me.Код_электробезопасностиTextBox)
        Me.Controls.Add(Me.ЭлектробезопасностьBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Электробезопасность"
        Me.Text = "Электробезопасность"
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЭлектробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЭлектробезопасностьBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ЭлектробезопасностьBindingNavigator.ResumeLayout(False)
        Me.ЭлектробезопасностьBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents ЭлектробезопасностьBindingSource As BindingSource
    Friend WithEvents ЭлектробезопасностьTableAdapter As universityDataSetTableAdapters.ЭлектробезопасностьTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ЭлектробезопасностьBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ЭлектробезопасностьBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Код_электробезопасностиTextBox As TextBox
    Friend WithEvents Описание_кодаTextBox As TextBox
End Class
