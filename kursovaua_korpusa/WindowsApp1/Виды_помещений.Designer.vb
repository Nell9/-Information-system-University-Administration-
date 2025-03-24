<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Виды_помещений
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Виды_помещений))
        Dim Вид_помещенияLabel As System.Windows.Forms.Label
        Dim Описание_вида_помещенияLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
        Me.Виды_помещенийBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Виды_помещенийTableAdapter = New WindowsApp1.universityDataSetTableAdapters.Виды_помещенийTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Me.Виды_помещенийBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Виды_помещенийBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Вид_помещенияTextBox = New System.Windows.Forms.TextBox()
        Me.Описание_вида_помещенияTextBox = New System.Windows.Forms.TextBox()
        Вид_помещенияLabel = New System.Windows.Forms.Label()
        Описание_вида_помещенияLabel = New System.Windows.Forms.Label()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_помещенийBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_помещенийBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Виды_помещенийBindingNavigator.SuspendLayout()
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
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Виды помещений"
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Виды_помещенийBindingSource
        '
        Me.Виды_помещенийBindingSource.DataMember = "Виды помещений"
        Me.Виды_помещенийBindingSource.DataSource = Me.UniversityDataSet
        '
        'Виды_помещенийTableAdapter
        '
        Me.Виды_помещенийTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Me.Виды_помещенийTableAdapter
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Nothing
        Me.TableAdapterManager.КорпусаTableAdapter = Nothing
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Nothing
        Me.TableAdapterManager.ПомещенияTableAdapter = Nothing
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Nothing
        '
        'Виды_помещенийBindingNavigator
        '
        Me.Виды_помещенийBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Виды_помещенийBindingNavigator.BindingSource = Me.Виды_помещенийBindingSource
        Me.Виды_помещенийBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Виды_помещенийBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Виды_помещенийBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Виды_помещенийBindingNavigatorSaveItem})
        Me.Виды_помещенийBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Виды_помещенийBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Виды_помещенийBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Виды_помещенийBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Виды_помещенийBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Виды_помещенийBindingNavigator.Name = "Виды_помещенийBindingNavigator"
        Me.Виды_помещенийBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Виды_помещенийBindingNavigator.Size = New System.Drawing.Size(561, 25)
        Me.Виды_помещенийBindingNavigator.TabIndex = 4
        Me.Виды_помещенийBindingNavigator.Text = "BindingNavigator1"
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
        'Виды_помещенийBindingNavigatorSaveItem
        '
        Me.Виды_помещенийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Виды_помещенийBindingNavigatorSaveItem.Image = CType(resources.GetObject("Виды_помещенийBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Виды_помещенийBindingNavigatorSaveItem.Name = "Виды_помещенийBindingNavigatorSaveItem"
        Me.Виды_помещенийBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Виды_помещенийBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Вид_помещенияLabel
        '
        Вид_помещенияLabel.AutoSize = True
        Вид_помещенияLabel.Location = New System.Drawing.Point(69, 123)
        Вид_помещенияLabel.Name = "Вид_помещенияLabel"
        Вид_помещенияLabel.Size = New System.Drawing.Size(91, 13)
        Вид_помещенияLabel.TabIndex = 4
        Вид_помещенияLabel.Text = "Вид помещения:"
        '
        'Вид_помещенияTextBox
        '
        Me.Вид_помещенияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Виды_помещенийBindingSource, "Вид помещения", True))
        Me.Вид_помещенияTextBox.Location = New System.Drawing.Point(286, 120)
        Me.Вид_помещенияTextBox.Name = "Вид_помещенияTextBox"
        Me.Вид_помещенияTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Вид_помещенияTextBox.TabIndex = 5
        '
        'Описание_вида_помещенияLabel
        '
        Описание_вида_помещенияLabel.AutoSize = True
        Описание_вида_помещенияLabel.Location = New System.Drawing.Point(68, 149)
        Описание_вида_помещенияLabel.Name = "Описание_вида_помещенияLabel"
        Описание_вида_помещенияLabel.Size = New System.Drawing.Size(149, 13)
        Описание_вида_помещенияLabel.TabIndex = 5
        Описание_вида_помещенияLabel.Text = "Описание вида помещения:"
        '
        'Описание_вида_помещенияTextBox
        '
        Me.Описание_вида_помещенияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Виды_помещенийBindingSource, "Описание вида помещения", True))
        Me.Описание_вида_помещенияTextBox.Location = New System.Drawing.Point(286, 146)
        Me.Описание_вида_помещенияTextBox.Name = "Описание_вида_помещенияTextBox"
        Me.Описание_вида_помещенияTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Описание_вида_помещенияTextBox.TabIndex = 6
        '
        'Виды_помещений
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 287)
        Me.Controls.Add(Описание_вида_помещенияLabel)
        Me.Controls.Add(Me.Описание_вида_помещенияTextBox)
        Me.Controls.Add(Вид_помещенияLabel)
        Me.Controls.Add(Me.Вид_помещенияTextBox)
        Me.Controls.Add(Me.Виды_помещенийBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Виды_помещений"
        Me.Text = "Виды_помещений"
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_помещенийBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_помещенийBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Виды_помещенийBindingNavigator.ResumeLayout(False)
        Me.Виды_помещенийBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents Виды_помещенийBindingSource As BindingSource
    Friend WithEvents Виды_помещенийTableAdapter As universityDataSetTableAdapters.Виды_помещенийTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Виды_помещенийBindingNavigator As BindingNavigator
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
    Friend WithEvents Виды_помещенийBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Вид_помещенияTextBox As TextBox
    Friend WithEvents Описание_вида_помещенияTextBox As TextBox
End Class
