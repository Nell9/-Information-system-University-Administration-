<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim Характеристика_электро_опасностиLabel As System.Windows.Forms.Label
        Dim Характеристика_пожаро_опасностиLabel As System.Windows.Forms.Label
        Dim Потребления_теплаLabel As System.Windows.Forms.Label
        Dim Наличие_мощных_электрических__установокLabel As System.Windows.Forms.Label
        Dim Пиковое_потреблениеLabel As System.Windows.Forms.Label
        Dim Потребление_электроэнергии_в_зимнее_времяLabel As System.Windows.Forms.Label
        Dim Потребление_электроэнергии_в_летнее_времяLabel As System.Windows.Forms.Label
        Dim Конструктивные_особенностиLabel As System.Windows.Forms.Label
        Dim Общий_объемLabel As System.Windows.Forms.Label
        Dim Учебно_вспомогательная_площадьLabel As System.Windows.Forms.Label
        Dim Учебная_площадьLabel As System.Windows.Forms.Label
        Dim Общая_площадьLabel As System.Windows.Forms.Label
        Dim Год_постройкиLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim Номер_корпусаLabel As System.Windows.Forms.Label
        Dim Дата_последнего_капитального_ремонтаLabel As System.Windows.Forms.Label
        Dim Даты_очередного_текущего_капитального_ремонтаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.КорпусаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.КорпусаTableAdapter = New WindowsApp1.universityDataSetTableAdapters.КорпусаTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Me.Конструктивная_особенностьTableAdapter = New WindowsApp1.universityDataSetTableAdapters.конструктивная_особенностьTableAdapter()
        Me.ПожаробезопасностьTableAdapter = New WindowsApp1.universityDataSetTableAdapters.ПожаробезопасностьTableAdapter()
        Me.ЭлектробезопасностьTableAdapter = New WindowsApp1.universityDataSetTableAdapters.ЭлектробезопасностьTableAdapter()
        Me.КорпусаBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.КорпусаBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Номер_корпусаTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.Год_постройкиTextBox = New System.Windows.Forms.TextBox()
        Me.Общая_площадьTextBox = New System.Windows.Forms.TextBox()
        Me.Учебная_площадьTextBox = New System.Windows.Forms.TextBox()
        Me.Учебно_вспомогательная_площадьTextBox = New System.Windows.Forms.TextBox()
        Me.Общий_объемTextBox = New System.Windows.Forms.TextBox()
        Me.Конструктивные_особенностиComboBox = New System.Windows.Forms.ComboBox()
        Me.КорпусаBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.КонструктивнаяОсобенностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Потребление_электроэнергии_в_летнее_времяTextBox = New System.Windows.Forms.TextBox()
        Me.Потребление_электроэнергии_в_зимнее_времяTextBox = New System.Windows.Forms.TextBox()
        Me.Пиковое_потреблениеTextBox = New System.Windows.Forms.TextBox()
        Me.Потребления_теплаTextBox = New System.Windows.Forms.TextBox()
        Me.Характеристика_пожаро_опасностиComboBox = New System.Windows.Forms.ComboBox()
        Me.ПожаробезопасностьBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПожаробезопасностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Характеристика_электро_опасностиComboBox = New System.Windows.Forms.ComboBox()
        Me.КорпусаBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЭлектробезопасностьBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Дата_последнего_капитального_ремонтаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Наличие_мощных_эл___установокTextBox = New System.Windows.Forms.TextBox()
        Характеристика_электро_опасностиLabel = New System.Windows.Forms.Label()
        Характеристика_пожаро_опасностиLabel = New System.Windows.Forms.Label()
        Потребления_теплаLabel = New System.Windows.Forms.Label()
        Наличие_мощных_электрических__установокLabel = New System.Windows.Forms.Label()
        Пиковое_потреблениеLabel = New System.Windows.Forms.Label()
        Потребление_электроэнергии_в_зимнее_времяLabel = New System.Windows.Forms.Label()
        Потребление_электроэнергии_в_летнее_времяLabel = New System.Windows.Forms.Label()
        Конструктивные_особенностиLabel = New System.Windows.Forms.Label()
        Общий_объемLabel = New System.Windows.Forms.Label()
        Учебно_вспомогательная_площадьLabel = New System.Windows.Forms.Label()
        Учебная_площадьLabel = New System.Windows.Forms.Label()
        Общая_площадьLabel = New System.Windows.Forms.Label()
        Год_постройкиLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        Номер_корпусаLabel = New System.Windows.Forms.Label()
        Дата_последнего_капитального_ремонтаLabel = New System.Windows.Forms.Label()
        Даты_очередного_текущего_капитального_ремонтаLabel = New System.Windows.Forms.Label()
        CType(Me.КорпусаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КорпусаBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.КорпусаBindingNavigator.SuspendLayout()
        CType(Me.КорпусаBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КонструктивнаяОсобенностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПожаробезопасностьBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПожаробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КорпусаBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЭлектробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Характеристика_электро_опасностиLabel
        '
        Характеристика_электро_опасностиLabel.AutoSize = True
        Характеристика_электро_опасностиLabel.Location = New System.Drawing.Point(18, 417)
        Характеристика_электро_опасностиLabel.Name = "Характеристика_электро_опасностиLabel"
        Характеристика_электро_опасностиLabel.Size = New System.Drawing.Size(191, 13)
        Характеристика_электро_опасностиLabel.TabIndex = 117
        Характеристика_электро_опасностиLabel.Text = "характеристика электро опасности:"
        '
        'Характеристика_пожаро_опасностиLabel
        '
        Характеристика_пожаро_опасностиLabel.AutoSize = True
        Характеристика_пожаро_опасностиLabel.Location = New System.Drawing.Point(18, 392)
        Характеристика_пожаро_опасностиLabel.Name = "Характеристика_пожаро_опасностиLabel"
        Характеристика_пожаро_опасностиLabel.Size = New System.Drawing.Size(188, 13)
        Характеристика_пожаро_опасностиLabel.TabIndex = 116
        Характеристика_пожаро_опасностиLabel.Text = "характеристика пожаро опасности:"
        '
        'Потребления_теплаLabel
        '
        Потребления_теплаLabel.AutoSize = True
        Потребления_теплаLabel.Location = New System.Drawing.Point(18, 367)
        Потребления_теплаLabel.Name = "Потребления_теплаLabel"
        Потребления_теплаLabel.Size = New System.Drawing.Size(107, 13)
        Потребления_теплаLabel.TabIndex = 115
        Потребления_теплаLabel.Text = "потребления тепла:"
        '
        'Наличие_мощных_электрических__установокLabel
        '
        Наличие_мощных_электрических__установокLabel.AutoSize = True
        Наличие_мощных_электрических__установокLabel.Location = New System.Drawing.Point(18, 342)
        Наличие_мощных_электрических__установокLabel.Name = "Наличие_мощных_электрических__установокLabel"
        Наличие_мощных_электрических__установокLabel.Size = New System.Drawing.Size(174, 26)
        Наличие_мощных_электрических__установокLabel.TabIndex = 114
        Наличие_мощных_электрических__установокLabel.Text = "наличие мощных электрических " & Global.Microsoft.VisualBasic.ChrW(10) & "установок:"
        '
        'Пиковое_потреблениеLabel
        '
        Пиковое_потреблениеLabel.AutoSize = True
        Пиковое_потреблениеLabel.Location = New System.Drawing.Point(18, 317)
        Пиковое_потреблениеLabel.Name = "Пиковое_потреблениеLabel"
        Пиковое_потреблениеLabel.Size = New System.Drawing.Size(120, 13)
        Пиковое_потреблениеLabel.TabIndex = 113
        Пиковое_потреблениеLabel.Text = "пиковое потребление:"
        '
        'Потребление_электроэнергии_в_зимнее_времяLabel
        '
        Потребление_электроэнергии_в_зимнее_времяLabel.AutoSize = True
        Потребление_электроэнергии_в_зимнее_времяLabel.Location = New System.Drawing.Point(18, 292)
        Потребление_электроэнергии_в_зимнее_времяLabel.Name = "Потребление_электроэнергии_в_зимнее_времяLabel"
        Потребление_электроэнергии_в_зимнее_времяLabel.Size = New System.Drawing.Size(245, 13)
        Потребление_электроэнергии_в_зимнее_времяLabel.TabIndex = 112
        Потребление_электроэнергии_в_зимнее_времяLabel.Text = "потребление электроэнергии в зимнее время:"
        '
        'Потребление_электроэнергии_в_летнее_времяLabel
        '
        Потребление_электроэнергии_в_летнее_времяLabel.AutoSize = True
        Потребление_электроэнергии_в_летнее_времяLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "учебная площадь", True))
        Потребление_электроэнергии_в_летнее_времяLabel.Location = New System.Drawing.Point(18, 267)
        Потребление_электроэнергии_в_летнее_времяLabel.Name = "Потребление_электроэнергии_в_летнее_времяLabel"
        Потребление_электроэнергии_в_летнее_времяLabel.Size = New System.Drawing.Size(242, 13)
        Потребление_электроэнергии_в_летнее_времяLabel.TabIndex = 111
        Потребление_электроэнергии_в_летнее_времяLabel.Text = "потребление электроэнергии в летнее время:"
        '
        'КорпусаBindingSource
        '
        Me.КорпусаBindingSource.DataMember = "Корпуса"
        Me.КорпусаBindingSource.DataSource = Me.UniversityDataSet
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Конструктивные_особенностиLabel
        '
        Конструктивные_особенностиLabel.AutoSize = True
        Конструктивные_особенностиLabel.Location = New System.Drawing.Point(18, 242)
        Конструктивные_особенностиLabel.Name = "Конструктивные_особенностиLabel"
        Конструктивные_особенностиLabel.Size = New System.Drawing.Size(161, 13)
        Конструктивные_особенностиLabel.TabIndex = 110
        Конструктивные_особенностиLabel.Text = "конструктивные особенности:"
        '
        'Общий_объемLabel
        '
        Общий_объемLabel.AutoSize = True
        Общий_объемLabel.Location = New System.Drawing.Point(18, 217)
        Общий_объемLabel.Name = "Общий_объемLabel"
        Общий_объемLabel.Size = New System.Drawing.Size(79, 13)
        Общий_объемLabel.TabIndex = 109
        Общий_объемLabel.Text = "общий объем:"
        '
        'Учебно_вспомогательная_площадьLabel
        '
        Учебно_вспомогательная_площадьLabel.AutoSize = True
        Учебно_вспомогательная_площадьLabel.Location = New System.Drawing.Point(18, 192)
        Учебно_вспомогательная_площадьLabel.Name = "Учебно_вспомогательная_площадьLabel"
        Учебно_вспомогательная_площадьLabel.Size = New System.Drawing.Size(185, 13)
        Учебно_вспомогательная_площадьLabel.TabIndex = 108
        Учебно_вспомогательная_площадьLabel.Text = "учебно-вспомогательная площадь:"
        '
        'Учебная_площадьLabel
        '
        Учебная_площадьLabel.AutoSize = True
        Учебная_площадьLabel.Location = New System.Drawing.Point(18, 167)
        Учебная_площадьLabel.Name = "Учебная_площадьLabel"
        Учебная_площадьLabel.Size = New System.Drawing.Size(98, 13)
        Учебная_площадьLabel.TabIndex = 107
        Учебная_площадьLabel.Text = "учебная площадь:"
        '
        'Общая_площадьLabel
        '
        Общая_площадьLabel.AutoSize = True
        Общая_площадьLabel.Location = New System.Drawing.Point(18, 142)
        Общая_площадьLabel.Name = "Общая_площадьLabel"
        Общая_площадьLabel.Size = New System.Drawing.Size(91, 13)
        Общая_площадьLabel.TabIndex = 106
        Общая_площадьLabel.Text = "общая площадь:"
        '
        'Год_постройкиLabel
        '
        Год_постройкиLabel.AutoSize = True
        Год_постройкиLabel.Location = New System.Drawing.Point(18, 117)
        Год_постройкиLabel.Name = "Год_постройкиLabel"
        Год_постройкиLabel.Size = New System.Drawing.Size(83, 13)
        Год_постройкиLabel.TabIndex = 105
        Год_постройкиLabel.Text = "год постройки:"
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(18, 92)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(40, 13)
        АдресLabel.TabIndex = 104
        АдресLabel.Text = "адрес:"
        '
        'Номер_корпусаLabel
        '
        Номер_корпусаLabel.AutoSize = True
        Номер_корпусаLabel.Location = New System.Drawing.Point(18, 67)
        Номер_корпусаLabel.Name = "Номер_корпусаLabel"
        Номер_корпусаLabel.Size = New System.Drawing.Size(86, 13)
        Номер_корпусаLabel.TabIndex = 103
        Номер_корпусаLabel.Text = "номер корпуса:"
        '
        'Дата_последнего_капитального_ремонтаLabel
        '
        Дата_последнего_капитального_ремонтаLabel.AutoSize = True
        Дата_последнего_капитального_ремонтаLabel.Location = New System.Drawing.Point(18, 442)
        Дата_последнего_капитального_ремонтаLabel.Name = "Дата_последнего_капитального_ремонтаLabel"
        Дата_последнего_капитального_ремонтаLabel.Size = New System.Drawing.Size(214, 13)
        Дата_последнего_капитального_ремонтаLabel.TabIndex = 118
        Дата_последнего_капитального_ремонтаLabel.Text = "дата последнего капитального ремонта:"
        '
        'Даты_очередного_текущего_капитального_ремонтаLabel
        '
        Даты_очередного_текущего_капитального_ремонтаLabel.Location = New System.Drawing.Point(18, 467)
        Даты_очередного_текущего_капитального_ремонтаLabel.Name = "Даты_очередного_текущего_капитального_ремонтаLabel"
        Даты_очередного_текущего_капитального_ремонтаLabel.Size = New System.Drawing.Size(242, 34)
        Даты_очередного_текущего_капитального_ремонтаLabel.TabIndex = 119
        Даты_очередного_текущего_капитального_ремонтаLabel.Text = "даты очередного текущего капитального ремонта:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(205, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Корпуса"
        '
        'КорпусаTableAdapter
        '
        Me.КорпусаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Nothing
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Me.Конструктивная_особенностьTableAdapter
        Me.TableAdapterManager.КорпусаTableAdapter = Me.КорпусаTableAdapter
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Me.ПожаробезопасностьTableAdapter
        Me.TableAdapterManager.ПомещенияTableAdapter = Nothing
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Me.ЭлектробезопасностьTableAdapter
        '
        'Конструктивная_особенностьTableAdapter
        '
        Me.Конструктивная_особенностьTableAdapter.ClearBeforeFill = True
        '
        'ПожаробезопасностьTableAdapter
        '
        Me.ПожаробезопасностьTableAdapter.ClearBeforeFill = True
        '
        'ЭлектробезопасностьTableAdapter
        '
        Me.ЭлектробезопасностьTableAdapter.ClearBeforeFill = True
        '
        'КорпусаBindingNavigator
        '
        Me.КорпусаBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.КорпусаBindingNavigator.BindingSource = Me.КорпусаBindingSource
        Me.КорпусаBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.КорпусаBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.КорпусаBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.КорпусаBindingNavigatorSaveItem})
        Me.КорпусаBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.КорпусаBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.КорпусаBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.КорпусаBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.КорпусаBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.КорпусаBindingNavigator.Name = "КорпусаBindingNavigator"
        Me.КорпусаBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.КорпусаBindingNavigator.Size = New System.Drawing.Size(495, 25)
        Me.КорпусаBindingNavigator.TabIndex = 120
        Me.КорпусаBindingNavigator.Text = "BindingNavigator1"
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
        'КорпусаBindingNavigatorSaveItem
        '
        Me.КорпусаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.КорпусаBindingNavigatorSaveItem.Image = CType(resources.GetObject("КорпусаBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.КорпусаBindingNavigatorSaveItem.Name = "КорпусаBindingNavigatorSaveItem"
        Me.КорпусаBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.КорпусаBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Номер_корпусаTextBox
        '
        Me.Номер_корпусаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "номер корпуса", True))
        Me.Номер_корпусаTextBox.Location = New System.Drawing.Point(275, 63)
        Me.Номер_корпусаTextBox.Name = "Номер_корпусаTextBox"
        Me.Номер_корпусаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Номер_корпусаTextBox.TabIndex = 121
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(275, 88)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(200, 20)
        Me.АдресTextBox.TabIndex = 122
        '
        'Год_постройкиTextBox
        '
        Me.Год_постройкиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "год постройки", True))
        Me.Год_постройкиTextBox.Location = New System.Drawing.Point(275, 113)
        Me.Год_постройкиTextBox.Name = "Год_постройкиTextBox"
        Me.Год_постройкиTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Год_постройкиTextBox.TabIndex = 123
        '
        'Общая_площадьTextBox
        '
        Me.Общая_площадьTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "общая площадь", True))
        Me.Общая_площадьTextBox.Location = New System.Drawing.Point(275, 138)
        Me.Общая_площадьTextBox.Name = "Общая_площадьTextBox"
        Me.Общая_площадьTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Общая_площадьTextBox.TabIndex = 124
        '
        'Учебная_площадьTextBox
        '
        Me.Учебная_площадьTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "учебная площадь", True))
        Me.Учебная_площадьTextBox.Location = New System.Drawing.Point(275, 163)
        Me.Учебная_площадьTextBox.Name = "Учебная_площадьTextBox"
        Me.Учебная_площадьTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Учебная_площадьTextBox.TabIndex = 125
        '
        'Учебно_вспомогательная_площадьTextBox
        '
        Me.Учебно_вспомогательная_площадьTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "учебно-вспомогательная площадь", True))
        Me.Учебно_вспомогательная_площадьTextBox.Location = New System.Drawing.Point(275, 188)
        Me.Учебно_вспомогательная_площадьTextBox.Name = "Учебно_вспомогательная_площадьTextBox"
        Me.Учебно_вспомогательная_площадьTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Учебно_вспомогательная_площадьTextBox.TabIndex = 126
        '
        'Общий_объемTextBox
        '
        Me.Общий_объемTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "общий объем", True))
        Me.Общий_объемTextBox.Location = New System.Drawing.Point(275, 213)
        Me.Общий_объемTextBox.Name = "Общий_объемTextBox"
        Me.Общий_объемTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Общий_объемTextBox.TabIndex = 127
        '
        'Конструктивные_особенностиComboBox
        '
        Me.Конструктивные_особенностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "конструктивные особенности", True))
        Me.Конструктивные_особенностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.КорпусаBindingSource2, "конструктивные особенности", True))
        Me.Конструктивные_особенностиComboBox.DataSource = Me.КонструктивнаяОсобенностьBindingSource
        Me.Конструктивные_особенностиComboBox.DisplayMember = "Описание конструктивной особенности"
        Me.Конструктивные_особенностиComboBox.FormattingEnabled = True
        Me.Конструктивные_особенностиComboBox.Location = New System.Drawing.Point(275, 238)
        Me.Конструктивные_особенностиComboBox.Name = "Конструктивные_особенностиComboBox"
        Me.Конструктивные_особенностиComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Конструктивные_особенностиComboBox.TabIndex = 128
        Me.Конструктивные_особенностиComboBox.ValueMember = "код конструктивной особенности"
        '
        'КорпусаBindingSource2
        '
        Me.КорпусаBindingSource2.DataMember = "Корпуса"
        Me.КорпусаBindingSource2.DataSource = Me.UniversityDataSet
        '
        'КонструктивнаяОсобенностьBindingSource
        '
        Me.КонструктивнаяОсобенностьBindingSource.DataMember = "конструктивная особенность"
        Me.КонструктивнаяОсобенностьBindingSource.DataSource = Me.UniversityDataSet
        '
        'Потребление_электроэнергии_в_летнее_времяTextBox
        '
        Me.Потребление_электроэнергии_в_летнее_времяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "потребление электроэнергии в летнее время", True))
        Me.Потребление_электроэнергии_в_летнее_времяTextBox.Location = New System.Drawing.Point(275, 263)
        Me.Потребление_электроэнергии_в_летнее_времяTextBox.Name = "Потребление_электроэнергии_в_летнее_времяTextBox"
        Me.Потребление_электроэнергии_в_летнее_времяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Потребление_электроэнергии_в_летнее_времяTextBox.TabIndex = 129
        '
        'Потребление_электроэнергии_в_зимнее_времяTextBox
        '
        Me.Потребление_электроэнергии_в_зимнее_времяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "потребление электроэнергии в зимнее время", True))
        Me.Потребление_электроэнергии_в_зимнее_времяTextBox.Location = New System.Drawing.Point(275, 288)
        Me.Потребление_электроэнергии_в_зимнее_времяTextBox.Name = "Потребление_электроэнергии_в_зимнее_времяTextBox"
        Me.Потребление_электроэнергии_в_зимнее_времяTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Потребление_электроэнергии_в_зимнее_времяTextBox.TabIndex = 130
        '
        'Пиковое_потреблениеTextBox
        '
        Me.Пиковое_потреблениеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "пиковое потребление", True))
        Me.Пиковое_потреблениеTextBox.Location = New System.Drawing.Point(275, 313)
        Me.Пиковое_потреблениеTextBox.Name = "Пиковое_потреблениеTextBox"
        Me.Пиковое_потреблениеTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Пиковое_потреблениеTextBox.TabIndex = 131
        '
        'Потребления_теплаTextBox
        '
        Me.Потребления_теплаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "потребления тепла", True))
        Me.Потребления_теплаTextBox.Location = New System.Drawing.Point(275, 363)
        Me.Потребления_теплаTextBox.Name = "Потребления_теплаTextBox"
        Me.Потребления_теплаTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Потребления_теплаTextBox.TabIndex = 133
        '
        'Характеристика_пожаро_опасностиComboBox
        '
        Me.Характеристика_пожаро_опасностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "характеристика пожаро опасности", True))
        Me.Характеристика_пожаро_опасностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ПожаробезопасностьBindingSource1, "Код пожаробезопасности", True))
        Me.Характеристика_пожаро_опасностиComboBox.DataSource = Me.ПожаробезопасностьBindingSource
        Me.Характеристика_пожаро_опасностиComboBox.DisplayMember = "Описание кода"
        Me.Характеристика_пожаро_опасностиComboBox.FormattingEnabled = True
        Me.Характеристика_пожаро_опасностиComboBox.Location = New System.Drawing.Point(275, 388)
        Me.Характеристика_пожаро_опасностиComboBox.Name = "Характеристика_пожаро_опасностиComboBox"
        Me.Характеристика_пожаро_опасностиComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Характеристика_пожаро_опасностиComboBox.TabIndex = 134
        Me.Характеристика_пожаро_опасностиComboBox.ValueMember = "Код пожаробезопасности"
        '
        'ПожаробезопасностьBindingSource1
        '
        Me.ПожаробезопасностьBindingSource1.DataMember = "Пожаробезопасность"
        Me.ПожаробезопасностьBindingSource1.DataSource = Me.UniversityDataSet
        '
        'ПожаробезопасностьBindingSource
        '
        Me.ПожаробезопасностьBindingSource.DataMember = "Пожаробезопасность"
        Me.ПожаробезопасностьBindingSource.DataSource = Me.UniversityDataSet
        '
        'Характеристика_электро_опасностиComboBox
        '
        Me.Характеристика_электро_опасностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "характеристика электро опасности", True))
        Me.Характеристика_электро_опасностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.КорпусаBindingSource1, "характеристика электро опасности", True))
        Me.Характеристика_электро_опасностиComboBox.DataSource = Me.ЭлектробезопасностьBindingSource
        Me.Характеристика_электро_опасностиComboBox.DisplayMember = "Описание кода"
        Me.Характеристика_электро_опасностиComboBox.FormattingEnabled = True
        Me.Характеристика_электро_опасностиComboBox.Location = New System.Drawing.Point(275, 413)
        Me.Характеристика_электро_опасностиComboBox.Name = "Характеристика_электро_опасностиComboBox"
        Me.Характеристика_электро_опасностиComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Характеристика_электро_опасностиComboBox.TabIndex = 135
        Me.Характеристика_электро_опасностиComboBox.ValueMember = "Код электробезопасности"
        '
        'КорпусаBindingSource1
        '
        Me.КорпусаBindingSource1.DataMember = "Корпуса"
        Me.КорпусаBindingSource1.DataSource = Me.UniversityDataSet
        '
        'ЭлектробезопасностьBindingSource
        '
        Me.ЭлектробезопасностьBindingSource.DataMember = "Электробезопасность"
        Me.ЭлектробезопасностьBindingSource.DataSource = Me.UniversityDataSet
        '
        'Дата_последнего_капитального_ремонтаDateTimePicker
        '
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.КорпусаBindingSource, "дата последнего капитального ремонта", True))
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.Location = New System.Drawing.Point(275, 438)
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.Name = "Дата_последнего_капитального_ремонтаDateTimePicker"
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.TabIndex = 136
        '
        'Даты_очередного_текущего_капитального_ремонтаDateTimePicker
        '
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.КорпусаBindingSource, "даты очередного текущего капитального ремонта", True))
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.Location = New System.Drawing.Point(275, 463)
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.Name = "Даты_очередного_текущего_капитального_ремонтаDateTimePicker"
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.TabIndex = 137
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(365, 559)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 23)
        Me.Button7.TabIndex = 144
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(265, 559)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 23)
        Me.Button6.TabIndex = 143
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(153, 559)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 23)
        Me.Button5.TabIndex = 142
        Me.Button5.Text = "Следующий"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(48, 559)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 23)
        Me.Button4.TabIndex = 141
        Me.Button4.Text = "Последний"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(265, 519)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 140
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 519)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 139
        Me.Button2.Text = "Предыдущий"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = "Первый"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Наличие_мощных_эл___установокTextBox
        '
        Me.Наличие_мощных_эл___установокTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КорпусаBindingSource, "наличие мощных эл_ " & Global.Microsoft.VisualBasic.ChrW(10) & "установок", True))
        Me.Наличие_мощных_эл___установокTextBox.Location = New System.Drawing.Point(275, 338)
        Me.Наличие_мощных_эл___установокTextBox.Name = "Наличие_мощных_эл___установокTextBox"
        Me.Наличие_мощных_эл___установокTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Наличие_мощных_эл___установокTextBox.TabIndex = 145
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 600)
        Me.Controls.Add(Me.Наличие_мощных_эл___установокTextBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker)
        Me.Controls.Add(Me.Дата_последнего_капитального_ремонтаDateTimePicker)
        Me.Controls.Add(Me.Характеристика_электро_опасностиComboBox)
        Me.Controls.Add(Me.Характеристика_пожаро_опасностиComboBox)
        Me.Controls.Add(Me.Потребления_теплаTextBox)
        Me.Controls.Add(Me.Пиковое_потреблениеTextBox)
        Me.Controls.Add(Me.Потребление_электроэнергии_в_зимнее_времяTextBox)
        Me.Controls.Add(Me.Потребление_электроэнергии_в_летнее_времяTextBox)
        Me.Controls.Add(Me.Конструктивные_особенностиComboBox)
        Me.Controls.Add(Me.Общий_объемTextBox)
        Me.Controls.Add(Me.Учебно_вспомогательная_площадьTextBox)
        Me.Controls.Add(Me.Учебная_площадьTextBox)
        Me.Controls.Add(Me.Общая_площадьTextBox)
        Me.Controls.Add(Me.Год_постройкиTextBox)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(Me.Номер_корпусаTextBox)
        Me.Controls.Add(Me.КорпусаBindingNavigator)
        Me.Controls.Add(Даты_очередного_текущего_капитального_ремонтаLabel)
        Me.Controls.Add(Дата_последнего_капитального_ремонтаLabel)
        Me.Controls.Add(Характеристика_электро_опасностиLabel)
        Me.Controls.Add(Характеристика_пожаро_опасностиLabel)
        Me.Controls.Add(Потребления_теплаLabel)
        Me.Controls.Add(Наличие_мощных_электрических__установокLabel)
        Me.Controls.Add(Пиковое_потреблениеLabel)
        Me.Controls.Add(Потребление_электроэнергии_в_зимнее_времяLabel)
        Me.Controls.Add(Потребление_электроэнергии_в_летнее_времяLabel)
        Me.Controls.Add(Конструктивные_особенностиLabel)
        Me.Controls.Add(Общий_объемLabel)
        Me.Controls.Add(Учебно_вспомогательная_площадьLabel)
        Me.Controls.Add(Учебная_площадьLabel)
        Me.Controls.Add(Общая_площадьLabel)
        Me.Controls.Add(Год_постройкиLabel)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Номер_корпусаLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form5"
        Me.Text = "Корпуса"
        CType(Me.КорпусаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КорпусаBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.КорпусаBindingNavigator.ResumeLayout(False)
        Me.КорпусаBindingNavigator.PerformLayout()
        CType(Me.КорпусаBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КонструктивнаяОсобенностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПожаробезопасностьBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПожаробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КорпусаBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЭлектробезопасностьBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents КорпусаBindingSource As BindingSource
    Friend WithEvents КорпусаTableAdapter As universityDataSetTableAdapters.КорпусаTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents КорпусаBindingNavigator As BindingNavigator
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
    Friend WithEvents КорпусаBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ПожаробезопасностьTableAdapter As universityDataSetTableAdapters.ПожаробезопасностьTableAdapter
    Friend WithEvents Номер_корпусаTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents Год_постройкиTextBox As TextBox
    Friend WithEvents Общая_площадьTextBox As TextBox
    Friend WithEvents Учебная_площадьTextBox As TextBox
    Friend WithEvents Учебно_вспомогательная_площадьTextBox As TextBox
    Friend WithEvents Общий_объемTextBox As TextBox
    Friend WithEvents Конструктивные_особенностиComboBox As ComboBox
    Friend WithEvents Потребление_электроэнергии_в_летнее_времяTextBox As TextBox
    Friend WithEvents Потребление_электроэнергии_в_зимнее_времяTextBox As TextBox
    Friend WithEvents Пиковое_потреблениеTextBox As TextBox
    Friend WithEvents Потребления_теплаTextBox As TextBox
    Friend WithEvents Характеристика_пожаро_опасностиComboBox As ComboBox
    Friend WithEvents Характеристика_электро_опасностиComboBox As ComboBox
    Friend WithEvents Дата_последнего_капитального_ремонтаDateTimePicker As DateTimePicker
    Friend WithEvents Даты_очередного_текущего_капитального_ремонтаDateTimePicker As DateTimePicker
    Friend WithEvents ПожаробезопасностьBindingSource As BindingSource
    Friend WithEvents ЭлектробезопасностьTableAdapter As universityDataSetTableAdapters.ЭлектробезопасностьTableAdapter
    Friend WithEvents ПожаробезопасностьBindingSource1 As BindingSource
    Friend WithEvents ЭлектробезопасностьBindingSource As BindingSource
    Friend WithEvents КорпусаBindingSource1 As BindingSource
    Friend WithEvents Конструктивная_особенностьTableAdapter As universityDataSetTableAdapters.конструктивная_особенностьTableAdapter
    Friend WithEvents КонструктивнаяОсобенностьBindingSource As BindingSource
    Friend WithEvents КорпусаBindingSource2 As BindingSource
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Наличие_мощных_эл___установокTextBox As TextBox
End Class
