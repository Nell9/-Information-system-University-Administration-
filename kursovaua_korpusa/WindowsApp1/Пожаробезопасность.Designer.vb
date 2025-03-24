<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Пожаробезопасность
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
        Dim Код_пожаробезопасностиLabel As System.Windows.Forms.Label
        Dim Описание_кодаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Пожаробезопасность))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
        Me.ПожаробезопасностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПожаробезопасностьTableAdapter = New WindowsApp1.universityDataSetTableAdapters.ПожаробезопасностьTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Me.ПожаробезопасностьBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ПожаробезопасностьBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Код_пожаробезопасностиTextBox = New System.Windows.Forms.TextBox()
        Me.Описание_кодаTextBox = New System.Windows.Forms.TextBox()
        Код_пожаробезопасностиLabel = New System.Windows.Forms.Label()
        Описание_кодаLabel = New System.Windows.Forms.Label()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПожаробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПожаробезопасностьBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПожаробезопасностьBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Код_пожаробезопасностиLabel
        '
        Код_пожаробезопасностиLabel.AutoSize = True
        Код_пожаробезопасностиLabel.Location = New System.Drawing.Point(69, 123)
        Код_пожаробезопасностиLabel.Name = "Код_пожаробезопасностиLabel"
        Код_пожаробезопасностиLabel.Size = New System.Drawing.Size(141, 13)
        Код_пожаробезопасностиLabel.TabIndex = 4
        Код_пожаробезопасностиLabel.Text = "Код пожаробезопасности:"
        '
        'Описание_кодаLabel
        '
        Описание_кодаLabel.AutoSize = True
        Описание_кодаLabel.Location = New System.Drawing.Point(68, 149)
        Описание_кодаLabel.Name = "Описание_кодаLabel"
        Описание_кодаLabel.Size = New System.Drawing.Size(87, 13)
        Описание_кодаLabel.TabIndex = 5
        Описание_кодаLabel.Text = "Описание кода:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(117, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Пожаробезопасность"
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПожаробезопасностьBindingSource
        '
        Me.ПожаробезопасностьBindingSource.DataMember = "Пожаробезопасность"
        Me.ПожаробезопасностьBindingSource.DataSource = Me.UniversityDataSet
        '
        'ПожаробезопасностьTableAdapter
        '
        Me.ПожаробезопасностьTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Nothing
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Nothing
        Me.TableAdapterManager.КорпусаTableAdapter = Nothing
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Me.ПожаробезопасностьTableAdapter
        Me.TableAdapterManager.ПомещенияTableAdapter = Nothing
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Nothing
        '
        'ПожаробезопасностьBindingNavigator
        '
        Me.ПожаробезопасностьBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПожаробезопасностьBindingNavigator.BindingSource = Me.ПожаробезопасностьBindingSource
        Me.ПожаробезопасностьBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПожаробезопасностьBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПожаробезопасностьBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПожаробезопасностьBindingNavigatorSaveItem})
        Me.ПожаробезопасностьBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПожаробезопасностьBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПожаробезопасностьBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПожаробезопасностьBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПожаробезопасностьBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПожаробезопасностьBindingNavigator.Name = "ПожаробезопасностьBindingNavigator"
        Me.ПожаробезопасностьBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПожаробезопасностьBindingNavigator.Size = New System.Drawing.Size(561, 25)
        Me.ПожаробезопасностьBindingNavigator.TabIndex = 4
        Me.ПожаробезопасностьBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ПожаробезопасностьBindingNavigatorSaveItem
        '
        Me.ПожаробезопасностьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПожаробезопасностьBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПожаробезопасностьBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПожаробезопасностьBindingNavigatorSaveItem.Name = "ПожаробезопасностьBindingNavigatorSaveItem"
        Me.ПожаробезопасностьBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ПожаробезопасностьBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Код_пожаробезопасностиTextBox
        '
        Me.Код_пожаробезопасностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПожаробезопасностьBindingSource, "Код пожаробезопасности", True))
        Me.Код_пожаробезопасностиTextBox.Location = New System.Drawing.Point(286, 120)
        Me.Код_пожаробезопасностиTextBox.Name = "Код_пожаробезопасностиTextBox"
        Me.Код_пожаробезопасностиTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Код_пожаробезопасностиTextBox.TabIndex = 5
        '
        'Описание_кодаTextBox
        '
        Me.Описание_кодаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПожаробезопасностьBindingSource, "Описание кода", True))
        Me.Описание_кодаTextBox.Location = New System.Drawing.Point(286, 146)
        Me.Описание_кодаTextBox.Name = "Описание_кодаTextBox"
        Me.Описание_кодаTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Описание_кодаTextBox.TabIndex = 6
        '
        'Пожаробезопасность
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 287)
        Me.Controls.Add(Описание_кодаLabel)
        Me.Controls.Add(Me.Описание_кодаTextBox)
        Me.Controls.Add(Код_пожаробезопасностиLabel)
        Me.Controls.Add(Me.Код_пожаробезопасностиTextBox)
        Me.Controls.Add(Me.ПожаробезопасностьBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Пожаробезопасность"
        Me.Text = "Пожаробезопасность"
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПожаробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПожаробезопасностьBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПожаробезопасностьBindingNavigator.ResumeLayout(False)
        Me.ПожаробезопасностьBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents ПожаробезопасностьBindingSource As BindingSource
    Friend WithEvents ПожаробезопасностьTableAdapter As universityDataSetTableAdapters.ПожаробезопасностьTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПожаробезопасностьBindingNavigator As BindingNavigator
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
    Friend WithEvents ПожаробезопасностьBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Код_пожаробезопасностиTextBox As TextBox
    Friend WithEvents Описание_кодаTextBox As TextBox
End Class
