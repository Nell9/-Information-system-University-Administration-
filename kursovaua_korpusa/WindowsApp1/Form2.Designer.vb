<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim Даты_очередного_текущего_капитального_ремонтаLabel As System.Windows.Forms.Label
        Dim Дата_последнего_капитального_ремонтаLabel As System.Windows.Forms.Label
        Dim Потребляемая_мощность_электроэнергииLabel As System.Windows.Forms.Label
        Dim Категория_пожаро_безопасностиLabel As System.Windows.Forms.Label
        Dim Категория_электро___безопасностиLabel As System.Windows.Forms.Label
        Dim Конструктивные_особенностиLabel As System.Windows.Forms.Label
        Dim Вид_помещенияLabel As System.Windows.Forms.Label
        Dim ОбъемLabel As System.Windows.Forms.Label
        Dim ПлощадьLabel As System.Windows.Forms.Label
        Dim ЭтажLabel As System.Windows.Forms.Label
        Dim Номер_помещенияLabel As System.Windows.Forms.Label
        Dim Номер_корпусаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ПомещенияBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ПомещенияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniversityDataSet = New WindowsApp1.universityDataSet()
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
        Me.ПомещенияBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Номер_корпусаComboBox = New System.Windows.Forms.ComboBox()
        Me.Номер_помещенияTextBox = New System.Windows.Forms.TextBox()
        Me.ЭтажTextBox = New System.Windows.Forms.TextBox()
        Me.ПлощадьTextBox = New System.Windows.Forms.TextBox()
        Me.ОбъемTextBox = New System.Windows.Forms.TextBox()
        Me.Вид_помещенияComboBox = New System.Windows.Forms.ComboBox()
        Me.Конструктивные_особенностиComboBox = New System.Windows.Forms.ComboBox()
        Me.Категория_электро___безопасностиComboBox = New System.Windows.Forms.ComboBox()
        Me.Категория_пожаро_безопасностиComboBox = New System.Windows.Forms.ComboBox()
        Me.Потребляемая_мощность_электроэнергииTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_последнего_капитального_ремонтаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ПомещенияTableAdapter = New WindowsApp1.universityDataSetTableAdapters.ПомещенияTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.universityDataSetTableAdapters.TableAdapterManager()
        Даты_очередного_текущего_капитального_ремонтаLabel = New System.Windows.Forms.Label()
        Дата_последнего_капитального_ремонтаLabel = New System.Windows.Forms.Label()
        Потребляемая_мощность_электроэнергииLabel = New System.Windows.Forms.Label()
        Категория_пожаро_безопасностиLabel = New System.Windows.Forms.Label()
        Категория_электро___безопасностиLabel = New System.Windows.Forms.Label()
        Конструктивные_особенностиLabel = New System.Windows.Forms.Label()
        Вид_помещенияLabel = New System.Windows.Forms.Label()
        ОбъемLabel = New System.Windows.Forms.Label()
        ПлощадьLabel = New System.Windows.Forms.Label()
        ЭтажLabel = New System.Windows.Forms.Label()
        Номер_помещенияLabel = New System.Windows.Forms.Label()
        Номер_корпусаLabel = New System.Windows.Forms.Label()
        CType(Me.ПомещенияBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПомещенияBindingNavigator.SuspendLayout()
        CType(Me.ПомещенияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Даты_очередного_текущего_капитального_ремонтаLabel
        '
        Даты_очередного_текущего_капитального_ремонтаLabel.Location = New System.Drawing.Point(12, 344)
        Даты_очередного_текущего_капитального_ремонтаLabel.Name = "Даты_очередного_текущего_капитального_ремонтаLabel"
        Даты_очередного_текущего_капитального_ремонтаLabel.Size = New System.Drawing.Size(214, 32)
        Даты_очередного_текущего_капитального_ремонтаLabel.TabIndex = 69
        Даты_очередного_текущего_капитального_ремонтаLabel.Text = "даты очередного текущего капитального ремонта:"

        '
        'Дата_последнего_капитального_ремонтаLabel
        '
        Дата_последнего_капитального_ремонтаLabel.AutoSize = True
        Дата_последнего_капитального_ремонтаLabel.Location = New System.Drawing.Point(12, 319)
        Дата_последнего_капитального_ремонтаLabel.Name = "Дата_последнего_капитального_ремонтаLabel"
        Дата_последнего_капитального_ремонтаLabel.Size = New System.Drawing.Size(214, 13)
        Дата_последнего_капитального_ремонтаLabel.TabIndex = 68
        Дата_последнего_капитального_ремонтаLabel.Text = "дата последнего капитального ремонта:"
        '
        'Потребляемая_мощность_электроэнергииLabel
        '
        Потребляемая_мощность_электроэнергииLabel.AutoSize = True
        Потребляемая_мощность_электроэнергииLabel.Location = New System.Drawing.Point(12, 294)
        Потребляемая_мощность_электроэнергииLabel.Name = "Потребляемая_мощность_электроэнергииLabel"
        Потребляемая_мощность_электроэнергииLabel.Size = New System.Drawing.Size(223, 13)
        Потребляемая_мощность_электроэнергииLabel.TabIndex = 67
        Потребляемая_мощность_электроэнергииLabel.Text = "потребляемая мощность электроэнергии:"
        '
        'Категория_пожаро_безопасностиLabel
        '
        Категория_пожаро_безопасностиLabel.AutoSize = True
        Категория_пожаро_безопасностиLabel.Location = New System.Drawing.Point(12, 269)
        Категория_пожаро_безопасностиLabel.Name = "Категория_пожаро_безопасностиLabel"
        Категория_пожаро_безопасностиLabel.Size = New System.Drawing.Size(177, 13)
        Категория_пожаро_безопасностиLabel.TabIndex = 66
        Категория_пожаро_безопасностиLabel.Text = "категория пожаро-безопасности:"
        '
        'Категория_электро___безопасностиLabel
        '
        Категория_электро___безопасностиLabel.AutoSize = True
        Категория_электро___безопасностиLabel.Location = New System.Drawing.Point(12, 244)
        Категория_электро___безопасностиLabel.Name = "Категория_электро___безопасностиLabel"
        Категория_электро___безопасностиLabel.Size = New System.Drawing.Size(186, 13)
        Категория_электро___безопасностиLabel.TabIndex = 65
        Категория_электро___безопасностиLabel.Text = "категория электро - безопасности:"
        '
        'Конструктивные_особенностиLabel
        '
        Конструктивные_особенностиLabel.AutoSize = True
        Конструктивные_особенностиLabel.Location = New System.Drawing.Point(12, 219)
        Конструктивные_особенностиLabel.Name = "Конструктивные_особенностиLabel"
        Конструктивные_особенностиLabel.Size = New System.Drawing.Size(161, 13)
        Конструктивные_особенностиLabel.TabIndex = 64
        Конструктивные_особенностиLabel.Text = "конструктивные особенности:"
        '
        'Вид_помещенияLabel
        '
        Вид_помещенияLabel.AutoSize = True
        Вид_помещенияLabel.Location = New System.Drawing.Point(12, 194)
        Вид_помещенияLabel.Name = "Вид_помещенияLabel"
        Вид_помещенияLabel.Size = New System.Drawing.Size(90, 13)
        Вид_помещенияLabel.TabIndex = 63
        Вид_помещенияLabel.Text = "вид помещения:"
        '
        'ОбъемLabel
        '
        ОбъемLabel.AutoSize = True
        ОбъемLabel.Location = New System.Drawing.Point(12, 169)
        ОбъемLabel.Name = "ОбъемLabel"
        ОбъемLabel.Size = New System.Drawing.Size(43, 13)
        ОбъемLabel.TabIndex = 62
        ОбъемLabel.Text = "объем:"
        '
        'ПлощадьLabel
        '
        ПлощадьLabel.AutoSize = True
        ПлощадьLabel.Location = New System.Drawing.Point(12, 144)
        ПлощадьLabel.Name = "ПлощадьLabel"
        ПлощадьLabel.Size = New System.Drawing.Size(55, 13)
        ПлощадьLabel.TabIndex = 61
        ПлощадьLabel.Text = "площадь:"
        '
        'ЭтажLabel
        '
        ЭтажLabel.AutoSize = True
        ЭтажLabel.Location = New System.Drawing.Point(12, 119)
        ЭтажLabel.Name = "ЭтажLabel"
        ЭтажLabel.Size = New System.Drawing.Size(35, 13)
        ЭтажLabel.TabIndex = 60
        ЭтажLabel.Text = "этаж:"
        '
        'Номер_помещенияLabel
        '
        Номер_помещенияLabel.AutoSize = True
        Номер_помещенияLabel.Location = New System.Drawing.Point(12, 94)
        Номер_помещенияLabel.Name = "Номер_помещенияLabel"
        Номер_помещенияLabel.Size = New System.Drawing.Size(104, 13)
        Номер_помещенияLabel.TabIndex = 59
        Номер_помещенияLabel.Text = "номер помещения:"

        '
        'Номер_корпусаLabel
        '
        Номер_корпусаLabel.AutoSize = True
        Номер_корпусаLabel.Location = New System.Drawing.Point(12, 69)
        Номер_корпусаLabel.Name = "Номер_корпусаLabel"
        Номер_корпусаLabel.Size = New System.Drawing.Size(86, 13)
        Номер_корпусаLabel.TabIndex = 58
        Номер_корпусаLabel.Text = "номер корпуса:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(145, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Помещения"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(342, 470)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 23)
        Me.Button7.TabIndex = 99
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(242, 470)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 23)
        Me.Button6.TabIndex = 98
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(130, 470)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 23)
        Me.Button5.TabIndex = 97
        Me.Button5.Text = "Следующий"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(25, 470)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 23)
        Me.Button4.TabIndex = 96
        Me.Button4.Text = "Последний"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(242, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 95
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "Предыдущий"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(25, 430)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 23)
        Me.Button8.TabIndex = 93
        Me.Button8.Text = "Первый"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 34)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Таблица поиска помещений"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ПомещенияBindingNavigator
        '
        Me.ПомещенияBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПомещенияBindingNavigator.BindingSource = Me.ПомещенияBindingSource
        Me.ПомещенияBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПомещенияBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПомещенияBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПомещенияBindingNavigatorSaveItem})
        Me.ПомещенияBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПомещенияBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПомещенияBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПомещенияBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПомещенияBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПомещенияBindingNavigator.Name = "ПомещенияBindingNavigator"
        Me.ПомещенияBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПомещенияBindingNavigator.Size = New System.Drawing.Size(454, 25)
        Me.ПомещенияBindingNavigator.TabIndex = 100
        Me.ПомещенияBindingNavigator.Text = "BindingNavigator1"
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
        'ПомещенияBindingSource
        '
        Me.ПомещенияBindingSource.DataMember = "Помещения"
        Me.ПомещенияBindingSource.DataSource = Me.UniversityDataSet
        '
        'UniversityDataSet
        '
        Me.UniversityDataSet.DataSetName = "universityDataSet"
        Me.UniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ПомещенияBindingNavigatorSaveItem
        '
        Me.ПомещенияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПомещенияBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПомещенияBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПомещенияBindingNavigatorSaveItem.Name = "ПомещенияBindingNavigatorSaveItem"
        Me.ПомещенияBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ПомещенияBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Номер_корпусаComboBox
        '
        Me.Номер_корпусаComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "номер корпуса", True))
        Me.Номер_корпусаComboBox.FormattingEnabled = True
        Me.Номер_корпусаComboBox.Location = New System.Drawing.Point(240, 63)
        Me.Номер_корпусаComboBox.Name = "Номер_корпусаComboBox"
        Me.Номер_корпусаComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Номер_корпусаComboBox.TabIndex = 101
        '
        'Номер_помещенияTextBox
        '
        Me.Номер_помещенияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "номер помещения", True))
        Me.Номер_помещенияTextBox.Location = New System.Drawing.Point(240, 88)
        Me.Номер_помещенияTextBox.Name = "Номер_помещенияTextBox"
        Me.Номер_помещенияTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Номер_помещенияTextBox.TabIndex = 102
        '
        'ЭтажTextBox
        '
        Me.ЭтажTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "этаж", True))
        Me.ЭтажTextBox.Location = New System.Drawing.Point(240, 113)
        Me.ЭтажTextBox.Name = "ЭтажTextBox"
        Me.ЭтажTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ЭтажTextBox.TabIndex = 103
        '
        'ПлощадьTextBox
        '
        Me.ПлощадьTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "площадь", True))
        Me.ПлощадьTextBox.Location = New System.Drawing.Point(240, 138)
        Me.ПлощадьTextBox.Name = "ПлощадьTextBox"
        Me.ПлощадьTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ПлощадьTextBox.TabIndex = 104
        '
        'ОбъемTextBox
        '
        Me.ОбъемTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "объем", True))
        Me.ОбъемTextBox.Location = New System.Drawing.Point(240, 163)
        Me.ОбъемTextBox.Name = "ОбъемTextBox"
        Me.ОбъемTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ОбъемTextBox.TabIndex = 105
        '
        'Вид_помещенияComboBox
        '
        Me.Вид_помещенияComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "вид помещения", True))
        Me.Вид_помещенияComboBox.FormattingEnabled = True
        Me.Вид_помещенияComboBox.Location = New System.Drawing.Point(240, 188)
        Me.Вид_помещенияComboBox.Name = "Вид_помещенияComboBox"
        Me.Вид_помещенияComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Вид_помещенияComboBox.TabIndex = 106
        '
        'Конструктивные_особенностиComboBox
        '
        Me.Конструктивные_особенностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "конструктивные особенности", True))
        Me.Конструктивные_особенностиComboBox.FormattingEnabled = True
        Me.Конструктивные_особенностиComboBox.Location = New System.Drawing.Point(240, 213)
        Me.Конструктивные_особенностиComboBox.Name = "Конструктивные_особенностиComboBox"
        Me.Конструктивные_особенностиComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Конструктивные_особенностиComboBox.TabIndex = 107
        '
        'Категория_электро___безопасностиComboBox
        '
        Me.Категория_электро___безопасностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "категория электро - безопасности", True))
        Me.Категория_электро___безопасностиComboBox.FormattingEnabled = True
        Me.Категория_электро___безопасностиComboBox.Location = New System.Drawing.Point(240, 238)
        Me.Категория_электро___безопасностиComboBox.Name = "Категория_электро___безопасностиComboBox"
        Me.Категория_электро___безопасностиComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Категория_электро___безопасностиComboBox.TabIndex = 108
        '
        'Категория_пожаро_безопасностиComboBox
        '
        Me.Категория_пожаро_безопасностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "категория пожаро-безопасности", True))
        Me.Категория_пожаро_безопасностиComboBox.FormattingEnabled = True
        Me.Категория_пожаро_безопасностиComboBox.Location = New System.Drawing.Point(240, 263)
        Me.Категория_пожаро_безопасностиComboBox.Name = "Категория_пожаро_безопасностиComboBox"
        Me.Категория_пожаро_безопасностиComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Категория_пожаро_безопасностиComboBox.TabIndex = 109
        '
        'Потребляемая_мощность_электроэнергииTextBox
        '
        Me.Потребляемая_мощность_электроэнергииTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПомещенияBindingSource, "потребляемая мощность электроэнергии", True))
        Me.Потребляемая_мощность_электроэнергииTextBox.Location = New System.Drawing.Point(240, 288)
        Me.Потребляемая_мощность_электроэнергииTextBox.Name = "Потребляемая_мощность_электроэнергииTextBox"
        Me.Потребляемая_мощность_электроэнергииTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Потребляемая_мощность_электроэнергииTextBox.TabIndex = 110
        '
        'Дата_последнего_капитального_ремонтаDateTimePicker
        '
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ПомещенияBindingSource, "дата последнего капитального ремонта", True))
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.Location = New System.Drawing.Point(240, 313)
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.Name = "Дата_последнего_капитального_ремонтаDateTimePicker"
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_последнего_капитального_ремонтаDateTimePicker.TabIndex = 111
        '
        'Даты_очередного_текущего_капитального_ремонтаDateTimePicker
        '
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ПомещенияBindingSource, "даты очередного текущего капитального ремонта", True))
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.Location = New System.Drawing.Point(240, 338)
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.Name = "Даты_очередного_текущего_капитального_ремонтаDateTimePicker"
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker.TabIndex = 112
        '
        'ПомещенияTableAdapter
        '
        Me.ПомещенияTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.universityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_помещенийTableAdapter = Nothing
        Me.TableAdapterManager.конструктивная_особенностьTableAdapter = Nothing
        Me.TableAdapterManager.КорпусаTableAdapter = Nothing
        Me.TableAdapterManager.ПожаробезопасностьTableAdapter = Nothing
        Me.TableAdapterManager.ПомещенияTableAdapter = Me.ПомещенияTableAdapter
        Me.TableAdapterManager.ЭлектробезопасностьTableAdapter = Nothing
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 572)
        Me.Controls.Add(Me.Даты_очередного_текущего_капитального_ремонтаDateTimePicker)
        Me.Controls.Add(Me.Дата_последнего_капитального_ремонтаDateTimePicker)
        Me.Controls.Add(Me.Потребляемая_мощность_электроэнергииTextBox)
        Me.Controls.Add(Me.Категория_пожаро_безопасностиComboBox)
        Me.Controls.Add(Me.Категория_электро___безопасностиComboBox)
        Me.Controls.Add(Me.Конструктивные_особенностиComboBox)
        Me.Controls.Add(Me.Вид_помещенияComboBox)
        Me.Controls.Add(Me.ОбъемTextBox)
        Me.Controls.Add(Me.ПлощадьTextBox)
        Me.Controls.Add(Me.ЭтажTextBox)
        Me.Controls.Add(Me.Номер_помещенияTextBox)
        Me.Controls.Add(Me.Номер_корпусаComboBox)
        Me.Controls.Add(Me.ПомещенияBindingNavigator)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Даты_очередного_текущего_капитального_ремонтаLabel)
        Me.Controls.Add(Дата_последнего_капитального_ремонтаLabel)
        Me.Controls.Add(Потребляемая_мощность_электроэнергииLabel)
        Me.Controls.Add(Категория_пожаро_безопасностиLabel)
        Me.Controls.Add(Категория_электро___безопасностиLabel)
        Me.Controls.Add(Конструктивные_особенностиLabel)
        Me.Controls.Add(Вид_помещенияLabel)
        Me.Controls.Add(ОбъемLabel)
        Me.Controls.Add(ПлощадьLabel)
        Me.Controls.Add(ЭтажLabel)
        Me.Controls.Add(Номер_помещенияLabel)
        Me.Controls.Add(Номер_корпусаLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Помещения"
        CType(Me.ПомещенияBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПомещенияBindingNavigator.ResumeLayout(False)
        Me.ПомещенияBindingNavigator.PerformLayout()
        CType(Me.ПомещенияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UniversityDataSet As universityDataSet
    Friend WithEvents ПомещенияBindingSource As BindingSource
    Friend WithEvents ПомещенияTableAdapter As universityDataSetTableAdapters.ПомещенияTableAdapter
    Friend WithEvents TableAdapterManager As universityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПомещенияBindingNavigator As BindingNavigator
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
    Friend WithEvents ПомещенияBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Номер_корпусаComboBox As ComboBox
    Friend WithEvents Номер_помещенияTextBox As TextBox
    Friend WithEvents ЭтажTextBox As TextBox
    Friend WithEvents ПлощадьTextBox As TextBox
    Friend WithEvents ОбъемTextBox As TextBox
    Friend WithEvents Вид_помещенияComboBox As ComboBox
    Friend WithEvents Конструктивные_особенностиComboBox As ComboBox
    Friend WithEvents Категория_электро___безопасностиComboBox As ComboBox
    Friend WithEvents Категория_пожаро_безопасностиComboBox As ComboBox
    Friend WithEvents Потребляемая_мощность_электроэнергииTextBox As TextBox
    Friend WithEvents Дата_последнего_капитального_ремонтаDateTimePicker As DateTimePicker
    Friend WithEvents Даты_очередного_текущего_капитального_ремонтаDateTimePicker As DateTimePicker
End Class
