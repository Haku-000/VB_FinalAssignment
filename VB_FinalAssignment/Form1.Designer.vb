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
        Me.components = New System.ComponentModel.Container()
        Dim IDEmpleadoLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel1 As System.Windows.Forms.Label
        Dim FechaNacimientoLabel1 As System.Windows.Forms.Label
        Dim GradoObtenidoLabel1 As System.Windows.Forms.Label
        Dim PuestoOcuparLabel1 As System.Windows.Forms.Label
        Dim TasaSalarialLabel1 As System.Windows.Forms.Label
        Dim FechaContratoLabel1 As System.Windows.Forms.Label
        Dim Habilidades_CertificacionesLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._VBA_6_1DataSet = New VB_FinalAssignment._VBA_6_1DataSet()
        Me.RegistrodeEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrodeEmpleadosTableAdapter = New VB_FinalAssignment._VBA_6_1DataSetTableAdapters.RegistrodeEmpleadosTableAdapter()
        Me.TableAdapterManager = New VB_FinalAssignment._VBA_6_1DataSetTableAdapters.TableAdapterManager()
        Me.RegistrodeEmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RegistrodeEmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.IDEmpleadoTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox1 = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoTextBox1 = New System.Windows.Forms.TextBox()
        Me.GradoObtenidoTextBox1 = New System.Windows.Forms.TextBox()
        Me.PuestoOcuparTextBox1 = New System.Windows.Forms.TextBox()
        Me.TasaSalarialTextBox1 = New System.Windows.Forms.TextBox()
        Me.FechaContratoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Habilidades_CertificacionesTextBox1 = New System.Windows.Forms.TextBox()
        IDEmpleadoLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel1 = New System.Windows.Forms.Label()
        FechaNacimientoLabel1 = New System.Windows.Forms.Label()
        GradoObtenidoLabel1 = New System.Windows.Forms.Label()
        PuestoOcuparLabel1 = New System.Windows.Forms.Label()
        TasaSalarialLabel1 = New System.Windows.Forms.Label()
        FechaContratoLabel1 = New System.Windows.Forms.Label()
        Habilidades_CertificacionesLabel1 = New System.Windows.Forms.Label()
        CType(Me._VBA_6_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrodeEmpleadosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDEmpleadoLabel1
        '
        IDEmpleadoLabel1.AutoSize = True
        IDEmpleadoLabel1.BackColor = System.Drawing.Color.Lavender
        IDEmpleadoLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDEmpleadoLabel1.Location = New System.Drawing.Point(429, 75)
        IDEmpleadoLabel1.Name = "IDEmpleadoLabel1"
        IDEmpleadoLabel1.Size = New System.Drawing.Size(136, 23)
        IDEmpleadoLabel1.TabIndex = 24
        IDEmpleadoLabel1.Text = "IDEmpleado:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.BackColor = System.Drawing.Color.Lavender
        NombreLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel1.Location = New System.Drawing.Point(429, 107)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(96, 23)
        NombreLabel1.TabIndex = 26
        NombreLabel1.Text = "Nombre:"
        '
        'ApellidoLabel1
        '
        ApellidoLabel1.AutoSize = True
        ApellidoLabel1.BackColor = System.Drawing.Color.Lavender
        ApellidoLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel1.Location = New System.Drawing.Point(429, 139)
        ApellidoLabel1.Name = "ApellidoLabel1"
        ApellidoLabel1.Size = New System.Drawing.Size(96, 23)
        ApellidoLabel1.TabIndex = 28
        ApellidoLabel1.Text = "Apellido:"
        '
        'FechaNacimientoLabel1
        '
        FechaNacimientoLabel1.AutoSize = True
        FechaNacimientoLabel1.BackColor = System.Drawing.Color.Lavender
        FechaNacimientoLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaNacimientoLabel1.Location = New System.Drawing.Point(429, 171)
        FechaNacimientoLabel1.Name = "FechaNacimientoLabel1"
        FechaNacimientoLabel1.Size = New System.Drawing.Size(190, 23)
        FechaNacimientoLabel1.TabIndex = 30
        FechaNacimientoLabel1.Text = "Fecha Nacimiento:"
        '
        'GradoObtenidoLabel1
        '
        GradoObtenidoLabel1.AutoSize = True
        GradoObtenidoLabel1.BackColor = System.Drawing.Color.Lavender
        GradoObtenidoLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradoObtenidoLabel1.Location = New System.Drawing.Point(429, 203)
        GradoObtenidoLabel1.Name = "GradoObtenidoLabel1"
        GradoObtenidoLabel1.Size = New System.Drawing.Size(173, 23)
        GradoObtenidoLabel1.TabIndex = 32
        GradoObtenidoLabel1.Text = "Grado Obtenido:"
        '
        'PuestoOcuparLabel1
        '
        PuestoOcuparLabel1.AutoSize = True
        PuestoOcuparLabel1.BackColor = System.Drawing.Color.Lavender
        PuestoOcuparLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PuestoOcuparLabel1.Location = New System.Drawing.Point(429, 235)
        PuestoOcuparLabel1.Name = "PuestoOcuparLabel1"
        PuestoOcuparLabel1.Size = New System.Drawing.Size(159, 23)
        PuestoOcuparLabel1.TabIndex = 34
        PuestoOcuparLabel1.Text = "Puesto Ocupar:"
        '
        'TasaSalarialLabel1
        '
        TasaSalarialLabel1.AutoSize = True
        TasaSalarialLabel1.BackColor = System.Drawing.Color.Lavender
        TasaSalarialLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TasaSalarialLabel1.Location = New System.Drawing.Point(429, 267)
        TasaSalarialLabel1.Name = "TasaSalarialLabel1"
        TasaSalarialLabel1.Size = New System.Drawing.Size(137, 23)
        TasaSalarialLabel1.TabIndex = 36
        TasaSalarialLabel1.Text = "Tasa Salarial:"
        '
        'FechaContratoLabel1
        '
        FechaContratoLabel1.AutoSize = True
        FechaContratoLabel1.BackColor = System.Drawing.Color.Lavender
        FechaContratoLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaContratoLabel1.Location = New System.Drawing.Point(429, 299)
        FechaContratoLabel1.Name = "FechaContratoLabel1"
        FechaContratoLabel1.Size = New System.Drawing.Size(164, 23)
        FechaContratoLabel1.TabIndex = 38
        FechaContratoLabel1.Text = "Fecha Contrato:"
        '
        'Habilidades_CertificacionesLabel1
        '
        Habilidades_CertificacionesLabel1.AutoSize = True
        Habilidades_CertificacionesLabel1.BackColor = System.Drawing.Color.Lavender
        Habilidades_CertificacionesLabel1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Habilidades_CertificacionesLabel1.Location = New System.Drawing.Point(429, 332)
        Habilidades_CertificacionesLabel1.Name = "Habilidades_CertificacionesLabel1"
        Habilidades_CertificacionesLabel1.Size = New System.Drawing.Size(284, 23)
        Habilidades_CertificacionesLabel1.TabIndex = 40
        Habilidades_CertificacionesLabel1.Text = "Habilidades-Certificaciones:"
        '
        '_VBA_6_1DataSet
        '
        Me._VBA_6_1DataSet.DataSetName = "_VBA_6_1DataSet"
        Me._VBA_6_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrodeEmpleadosBindingSource
        '
        Me.RegistrodeEmpleadosBindingSource.DataMember = "RegistrodeEmpleados"
        Me.RegistrodeEmpleadosBindingSource.DataSource = Me._VBA_6_1DataSet
        '
        'RegistrodeEmpleadosTableAdapter
        '
        Me.RegistrodeEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegistrodeEmpleadosTableAdapter = Me.RegistrodeEmpleadosTableAdapter
        Me.TableAdapterManager.UpdateOrder = VB_FinalAssignment._VBA_6_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrodeEmpleadosBindingNavigator
        '
        Me.RegistrodeEmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistrodeEmpleadosBindingNavigator.BindingSource = Me.RegistrodeEmpleadosBindingSource
        Me.RegistrodeEmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistrodeEmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistrodeEmpleadosBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.RegistrodeEmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistrodeEmpleadosBindingNavigatorSaveItem})
        Me.RegistrodeEmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistrodeEmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistrodeEmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistrodeEmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistrodeEmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistrodeEmpleadosBindingNavigator.Name = "RegistrodeEmpleadosBindingNavigator"
        Me.RegistrodeEmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistrodeEmpleadosBindingNavigator.Size = New System.Drawing.Size(907, 33)
        Me.RegistrodeEmpleadosBindingNavigator.TabIndex = 0
        Me.RegistrodeEmpleadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'RegistrodeEmpleadosBindingNavigatorSaveItem
        '
        Me.RegistrodeEmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistrodeEmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistrodeEmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistrodeEmpleadosBindingNavigatorSaveItem.Name = "RegistrodeEmpleadosBindingNavigatorSaveItem"
        Me.RegistrodeEmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.RegistrodeEmpleadosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.Lavender
        Me.BtnPrev.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(193, 75)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(164, 67)
        Me.BtnPrev.TabIndex = 19
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Lavender
        Me.BtnNext.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(193, 162)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 69)
        Me.BtnNext.TabIndex = 20
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Lavender
        Me.BtnSave.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(193, 257)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(164, 68)
        Me.BtnSave.TabIndex = 21
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.Lavender
        Me.BtnAddNew.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Location = New System.Drawing.Point(193, 347)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 76)
        Me.BtnAddNew.TabIndex = 22
        Me.BtnAddNew.Text = "New"
        Me.BtnAddNew.UseVisualStyleBackColor = False
        '
        'BtnOpen
        '
        Me.BtnOpen.BackColor = System.Drawing.Color.Lavender
        Me.BtnOpen.Font = New System.Drawing.Font("Lucida Bright", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Location = New System.Drawing.Point(24, 151)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(100, 80)
        Me.BtnOpen.TabIndex = 23
        Me.BtnOpen.Text = "Open Table"
        Me.BtnOpen.UseVisualStyleBackColor = False
        '
        'IDEmpleadoTextBox1
        '
        Me.IDEmpleadoTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.IDEmpleadoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "IDEmpleado", True))
        Me.IDEmpleadoTextBox1.Location = New System.Drawing.Point(721, 73)
        Me.IDEmpleadoTextBox1.Name = "IDEmpleadoTextBox1"
        Me.IDEmpleadoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.IDEmpleadoTextBox1.TabIndex = 25
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(721, 105)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.NombreTextBox1.TabIndex = 27
        '
        'ApellidoTextBox1
        '
        Me.ApellidoTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.ApellidoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "Apellido", True))
        Me.ApellidoTextBox1.Location = New System.Drawing.Point(721, 137)
        Me.ApellidoTextBox1.Name = "ApellidoTextBox1"
        Me.ApellidoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.ApellidoTextBox1.TabIndex = 29
        '
        'FechaNacimientoTextBox1
        '
        Me.FechaNacimientoTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.FechaNacimientoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoTextBox1.Location = New System.Drawing.Point(721, 169)
        Me.FechaNacimientoTextBox1.Name = "FechaNacimientoTextBox1"
        Me.FechaNacimientoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.FechaNacimientoTextBox1.TabIndex = 31
        '
        'GradoObtenidoTextBox1
        '
        Me.GradoObtenidoTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.GradoObtenidoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "GradoObtenido", True))
        Me.GradoObtenidoTextBox1.Location = New System.Drawing.Point(721, 201)
        Me.GradoObtenidoTextBox1.Name = "GradoObtenidoTextBox1"
        Me.GradoObtenidoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.GradoObtenidoTextBox1.TabIndex = 33
        '
        'PuestoOcuparTextBox1
        '
        Me.PuestoOcuparTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.PuestoOcuparTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "PuestoOcupar", True))
        Me.PuestoOcuparTextBox1.Location = New System.Drawing.Point(721, 233)
        Me.PuestoOcuparTextBox1.Name = "PuestoOcuparTextBox1"
        Me.PuestoOcuparTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.PuestoOcuparTextBox1.TabIndex = 35
        '
        'TasaSalarialTextBox1
        '
        Me.TasaSalarialTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TasaSalarialTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "TasaSalarial", True))
        Me.TasaSalarialTextBox1.Location = New System.Drawing.Point(721, 265)
        Me.TasaSalarialTextBox1.Name = "TasaSalarialTextBox1"
        Me.TasaSalarialTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TasaSalarialTextBox1.TabIndex = 37
        '
        'FechaContratoTextBox1
        '
        Me.FechaContratoTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.FechaContratoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "FechaContrato", True))
        Me.FechaContratoTextBox1.Location = New System.Drawing.Point(721, 297)
        Me.FechaContratoTextBox1.Name = "FechaContratoTextBox1"
        Me.FechaContratoTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.FechaContratoTextBox1.TabIndex = 39
        '
        'Habilidades_CertificacionesTextBox1
        '
        Me.Habilidades_CertificacionesTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.Habilidades_CertificacionesTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrodeEmpleadosBindingSource, "Habilidades-Certificaciones", True))
        Me.Habilidades_CertificacionesTextBox1.Location = New System.Drawing.Point(721, 329)
        Me.Habilidades_CertificacionesTextBox1.Name = "Habilidades_CertificacionesTextBox1"
        Me.Habilidades_CertificacionesTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.Habilidades_CertificacionesTextBox1.TabIndex = 41
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(907, 486)
        Me.Controls.Add(IDEmpleadoLabel1)
        Me.Controls.Add(Me.IDEmpleadoTextBox1)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreTextBox1)
        Me.Controls.Add(ApellidoLabel1)
        Me.Controls.Add(Me.ApellidoTextBox1)
        Me.Controls.Add(FechaNacimientoLabel1)
        Me.Controls.Add(Me.FechaNacimientoTextBox1)
        Me.Controls.Add(GradoObtenidoLabel1)
        Me.Controls.Add(Me.GradoObtenidoTextBox1)
        Me.Controls.Add(PuestoOcuparLabel1)
        Me.Controls.Add(Me.PuestoOcuparTextBox1)
        Me.Controls.Add(TasaSalarialLabel1)
        Me.Controls.Add(Me.TasaSalarialTextBox1)
        Me.Controls.Add(FechaContratoLabel1)
        Me.Controls.Add(Me.FechaContratoTextBox1)
        Me.Controls.Add(Habilidades_CertificacionesLabel1)
        Me.Controls.Add(Me.Habilidades_CertificacionesTextBox1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.RegistrodeEmpleadosBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._VBA_6_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrodeEmpleadosBindingNavigator.ResumeLayout(False)
        Me.RegistrodeEmpleadosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _VBA_6_1DataSet As _VBA_6_1DataSet
    Friend WithEvents RegistrodeEmpleadosBindingSource As BindingSource
    Friend WithEvents RegistrodeEmpleadosTableAdapter As _VBA_6_1DataSetTableAdapters.RegistrodeEmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As _VBA_6_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrodeEmpleadosBindingNavigator As BindingNavigator
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
    Friend WithEvents RegistrodeEmpleadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnOpen As Button
    Friend WithEvents IDEmpleadoTextBox1 As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents ApellidoTextBox1 As TextBox
    Friend WithEvents FechaNacimientoTextBox1 As TextBox
    Friend WithEvents GradoObtenidoTextBox1 As TextBox
    Friend WithEvents PuestoOcuparTextBox1 As TextBox
    Friend WithEvents TasaSalarialTextBox1 As TextBox
    Friend WithEvents FechaContratoTextBox1 As TextBox
    Friend WithEvents Habilidades_CertificacionesTextBox1 As TextBox
End Class
