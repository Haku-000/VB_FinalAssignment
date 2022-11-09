<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RegistrodeEmpleadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VBA61DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._VBA_6_1DataSet = New VB_FinalAssignment._VBA_6_1DataSet()
        Me.RegistrodeEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrodeEmpleadosTableAdapter = New VB_FinalAssignment._VBA_6_1DataSetTableAdapters.RegistrodeEmpleadosTableAdapter()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New VB_FinalAssignment._VBA_6_1DataSetTableAdapters.TableAdapterManager()
        Me.RegistrodeEmpleadosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrodeEmpleadosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrodeEmpleadosDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RegistrodeEmpleadosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoObtenidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuestoOcuparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaSalarialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabilidadesCertificacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RegistrodeEmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBA61DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._VBA_6_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrodeEmpleadosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrodeEmpleadosBindingSource1
        '
        Me.RegistrodeEmpleadosBindingSource1.DataMember = "RegistrodeEmpleados"
        Me.RegistrodeEmpleadosBindingSource1.DataSource = Me.VBA61DataSetBindingSource
        '
        'VBA61DataSetBindingSource
        '
        Me.VBA61DataSetBindingSource.DataSource = Me._VBA_6_1DataSet
        Me.VBA61DataSetBindingSource.Position = 0
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
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(456, 366)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(169, 70)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Lucida Bright", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(296, 366)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 70)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(694, 366)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(99, 70)
        Me.BtnClose.TabIndex = 26
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegistrodeEmpleadosTableAdapter = Me.RegistrodeEmpleadosTableAdapter
        Me.TableAdapterManager.UpdateOrder = VB_FinalAssignment._VBA_6_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrodeEmpleadosBindingSource2
        '
        Me.RegistrodeEmpleadosBindingSource2.DataMember = "RegistrodeEmpleados"
        Me.RegistrodeEmpleadosBindingSource2.DataSource = Me._VBA_6_1DataSet
        '
        'RegistrodeEmpleadosBindingSource3
        '
        Me.RegistrodeEmpleadosBindingSource3.DataMember = "RegistrodeEmpleados"
        Me.RegistrodeEmpleadosBindingSource3.DataSource = Me.VBA61DataSetBindingSource
        '
        'RegistrodeEmpleadosDataGridView1
        '
        Me.RegistrodeEmpleadosDataGridView1.AutoGenerateColumns = False
        Me.RegistrodeEmpleadosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrodeEmpleadosDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEmpleadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.GradoObtenidoDataGridViewTextBoxColumn, Me.PuestoOcuparDataGridViewTextBoxColumn, Me.TasaSalarialDataGridViewTextBoxColumn, Me.FechaContratoDataGridViewTextBoxColumn, Me.HabilidadesCertificacionesDataGridViewTextBoxColumn})
        Me.RegistrodeEmpleadosDataGridView1.DataSource = Me.RegistrodeEmpleadosBindingSource4
        Me.RegistrodeEmpleadosDataGridView1.Location = New System.Drawing.Point(34, 31)
        Me.RegistrodeEmpleadosDataGridView1.Name = "RegistrodeEmpleadosDataGridView1"
        Me.RegistrodeEmpleadosDataGridView1.RowHeadersWidth = 62
        Me.RegistrodeEmpleadosDataGridView1.RowTemplate.Height = 28
        Me.RegistrodeEmpleadosDataGridView1.Size = New System.Drawing.Size(1010, 313)
        Me.RegistrodeEmpleadosDataGridView1.TabIndex = 26
        '
        'RegistrodeEmpleadosBindingSource4
        '
        Me.RegistrodeEmpleadosBindingSource4.DataMember = "RegistrodeEmpleados"
        Me.RegistrodeEmpleadosBindingSource4.DataSource = Me.VBA61DataSetBindingSource
        '
        'IDEmpleadoDataGridViewTextBoxColumn
        '
        Me.IDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IDEmpleado"
        Me.IDEmpleadoDataGridViewTextBoxColumn.HeaderText = "IDEmpleado"
        Me.IDEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDEmpleadoDataGridViewTextBoxColumn.Name = "IDEmpleadoDataGridViewTextBoxColumn"
        Me.IDEmpleadoDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.Width = 150
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Width = 150
        '
        'GradoObtenidoDataGridViewTextBoxColumn
        '
        Me.GradoObtenidoDataGridViewTextBoxColumn.DataPropertyName = "GradoObtenido"
        Me.GradoObtenidoDataGridViewTextBoxColumn.HeaderText = "GradoObtenido"
        Me.GradoObtenidoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GradoObtenidoDataGridViewTextBoxColumn.Name = "GradoObtenidoDataGridViewTextBoxColumn"
        Me.GradoObtenidoDataGridViewTextBoxColumn.Width = 150
        '
        'PuestoOcuparDataGridViewTextBoxColumn
        '
        Me.PuestoOcuparDataGridViewTextBoxColumn.DataPropertyName = "PuestoOcupar"
        Me.PuestoOcuparDataGridViewTextBoxColumn.HeaderText = "PuestoOcupar"
        Me.PuestoOcuparDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PuestoOcuparDataGridViewTextBoxColumn.Name = "PuestoOcuparDataGridViewTextBoxColumn"
        Me.PuestoOcuparDataGridViewTextBoxColumn.Width = 150
        '
        'TasaSalarialDataGridViewTextBoxColumn
        '
        Me.TasaSalarialDataGridViewTextBoxColumn.DataPropertyName = "TasaSalarial"
        Me.TasaSalarialDataGridViewTextBoxColumn.HeaderText = "TasaSalarial"
        Me.TasaSalarialDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TasaSalarialDataGridViewTextBoxColumn.Name = "TasaSalarialDataGridViewTextBoxColumn"
        Me.TasaSalarialDataGridViewTextBoxColumn.Width = 150
        '
        'FechaContratoDataGridViewTextBoxColumn
        '
        Me.FechaContratoDataGridViewTextBoxColumn.DataPropertyName = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.HeaderText = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaContratoDataGridViewTextBoxColumn.Name = "FechaContratoDataGridViewTextBoxColumn"
        Me.FechaContratoDataGridViewTextBoxColumn.Width = 150
        '
        'HabilidadesCertificacionesDataGridViewTextBoxColumn
        '
        Me.HabilidadesCertificacionesDataGridViewTextBoxColumn.DataPropertyName = "Habilidades-Certificaciones"
        Me.HabilidadesCertificacionesDataGridViewTextBoxColumn.HeaderText = "Habilidades-Certificaciones"
        Me.HabilidadesCertificacionesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HabilidadesCertificacionesDataGridViewTextBoxColumn.Name = "HabilidadesCertificacionesDataGridViewTextBoxColumn"
        Me.HabilidadesCertificacionesDataGridViewTextBoxColumn.Width = 150
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 456)
        Me.Controls.Add(Me.RegistrodeEmpleadosDataGridView1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.RegistrodeEmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBA61DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._VBA_6_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrodeEmpleadosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _VBA_6_1DataSet As _VBA_6_1DataSet
    Friend WithEvents RegistrodeEmpleadosBindingSource As BindingSource
    Friend WithEvents RegistrodeEmpleadosTableAdapter As _VBA_6_1DataSetTableAdapters.RegistrodeEmpleadosTableAdapter
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents VBA61DataSetBindingSource As BindingSource
    Friend WithEvents RegistrodeEmpleadosBindingSource1 As BindingSource
    Friend WithEvents TableAdapterManager As _VBA_6_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrodeEmpleadosBindingSource2 As BindingSource
    Friend WithEvents RegistrodeEmpleadosBindingSource3 As BindingSource
    Friend WithEvents RegistrodeEmpleadosDataGridView1 As DataGridView
    Friend WithEvents IDEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradoObtenidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuestoOcuparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaSalarialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HabilidadesCertificacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrodeEmpleadosBindingSource4 As BindingSource
End Class
