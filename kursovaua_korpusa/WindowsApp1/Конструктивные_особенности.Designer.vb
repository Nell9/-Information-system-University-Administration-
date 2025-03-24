<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Конструктивные_особенности
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Конструктивные_особенности))
        Dim Код_конструктивной_особенностиLabel As System.Windows.Forms.Label
        Dim Описание_конструктивной_особенностиLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
        Me.Конструктивная_особенностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Конструктивная_особенностьTableAdapter = New WindowsApp1.universityDataSetTableAdapters.конструктивная_особенностьTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Me.Конструктивная_особенностьBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Конструктивная_особенностьBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Код_конструктивной_особенностиTextBox = New System.Windows.Forms.TextBox()
        Me.Описание_конструктивной_особенностиTextBox = New System.Windows.Forms.TextBox()
        Код_конструктивной_особенностиLabel = New System.Windows.Forms.Label()
        Описание_конструктивной_особенностиLabel = New System.Windows.Forms.Label()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Конструктивная_особенностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Конструктивная_особенностьBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Конструктивная_особенностьBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(117, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Конструктивные особенности"
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Конструктивная_особенностьBindingSource
        '
        Me.Конструктивная_особенностьBindingSource.DataMember = "конструктивная особенность"
        Me.Конструктивная_особенностьBindingSource.DataSource = Me.UniversityDataSet
        '
        'Конструктивная_особенностьTableAdapter
        '
        Me.Конструктивная_особенностьTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Nothing
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Me.Конструктивная_особенностьTableAdapter
        Me.TableAdapterManager.КорпусаTableAdapter = Nothing
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Nothing
        Me.TableAdapterManager.ПомещенияTableAdapter = Nothing
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Nothing
        '
        'Конструктивная_особенностьBindingNavigator
        '
        Me.Конструктивная_особенностьBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Конструктивная_особенностьBindingNavigator.BindingSource = Me.Конструктивная_особенностьBindingSource
        Me.Конструктивная_особенностьBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Конструктивная_особенностьBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Конструктивная_особенностьBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Конструктивная_особенностьBindingNavigatorSaveItem})
        Me.Конструктивная_особенностьBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Конструктивная_особенностьBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Конструктивная_особенностьBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Конструктивная_особенностьBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Конструктивная_особенностьBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Конструктивная_особенностьBindingNavigator.Name = "Конструктивная_особенностьBindingNavigator"
        Me.Конструктивная_особенностьBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Конструктивная_особенностьBindingNavigator.Size = New System.Drawing.Size(561, 25)
        Me.Конструктивная_особенностьBindingNavigator.TabIndex = 3
        Me.Конструктивная_особенностьBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'Конструктивная_особенностьBindingNavigatorSaveItem
        '
        Me.Конструктивная_особенностьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Конструктивная_особенностьBindingNavigatorSaveItem.Image = CType(resources.GetObject("Конструктивная_особенностьBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Конструктивная_особенностьBindingNavigatorSaveItem.Name = "Конструктивная_особенностьBindingNavigatorSaveItem"
        Me.Конструктивная_особенностьBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Конструктивная_особенностьBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Код_конструктивной_особенностиLabel
        '
        Код_конструктивной_особенностиLabel.AutoSize = True
        Код_конструктивной_особенностиLabel.Location = New System.Drawing.Point(69, 123)
        Код_конструктивной_особенностиLabel.Name = "Код_конструктивной_особенностиLabel"
        Код_конструктивной_особенностиLabel.Size = New System.Drawing.Size(180, 13)
        Код_конструктивной_особенностиLabel.TabIndex = 3
        Код_конструктивной_особенностиLabel.Text = "код конструктивной особенности:"
        '
        'Код_конструктивной_особенностиTextBox
        '
        Me.Код_конструктивной_особенностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Конструктивная_особенностьBindingSource, "код конструктивной особенности", True))
        Me.Код_конструктивной_особенностиTextBox.Location = New System.Drawing.Point(286, 120)
        Me.Код_конструктивной_особенностиTextBox.Name = "Код_конструктивной_особенностиTextBox"
        Me.Код_конструктивной_особенностиTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Код_конструктивной_особенностиTextBox.TabIndex = 4
        '
        'Описание_конструктивной_особенностиLabel
        '
        Описание_конструктивной_особенностиLabel.AutoSize = True
        Описание_конструктивной_особенностиLabel.Location = New System.Drawing.Point(68, 149)
        Описание_конструктивной_особенностиLabel.Name = "Описание_конструктивной_особенностиLabel"
        Описание_конструктивной_особенностиLabel.Size = New System.Drawing.Size(212, 13)
        Описание_конструктивной_особенностиLabel.TabIndex = 4
        Описание_конструктивной_особенностиLabel.Text = "Описание конструктивной особенности:"
        '
        'Описание_конструктивной_особенностиTextBox
        '
        Me.Описание_конструктивной_особенностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Конструктивная_особенностьBindingSource, "Описание конструктивной особенности", True))
        Me.Описание_конструктивной_особенностиTextBox.Location = New System.Drawing.Point(286, 146)
        Me.Описание_конструктивной_особенностиTextBox.Name = "Описание_конструктивной_особенностиTextBox"
        Me.Описание_конструктивной_особенностиTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Описание_конструктивной_особенностиTextBox.TabIndex = 5
        '
        'Конструктивные_особенности
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 287)
        Me.Controls.Add(Описание_конструктивной_особенностиLabel)
        Me.Controls.Add(Me.Описание_конструктивной_особенностиTextBox)
        Me.Controls.Add(Код_конструктивной_особенностиLabel)
        Me.Controls.Add(Me.Код_конструктивной_особенностиTextBox)
        Me.Controls.Add(Me.Конструктивная_особенностьBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Конструктивные_особенности"
        Me.Text = "Конструктивные особенности"
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Конструктивная_особенностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Конструктивная_особенностьBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Конструктивная_особенностьBindingNavigator.ResumeLayout(False)
        Me.Конструктивная_особенностьBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents Конструктивная_особенностьBindingSource As BindingSource
    Friend WithEvents Конструктивная_особенностьTableAdapter As universityDataSetTableAdapters.конструктивная_особенностьTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Конструктивная_особенностьBindingNavigator As BindingNavigator
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
    Friend WithEvents Конструктивная_особенностьBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Код_конструктивной_особенностиTextBox As TextBox
    Friend WithEvents Описание_конструктивной_особенностиTextBox As TextBox
End Class
