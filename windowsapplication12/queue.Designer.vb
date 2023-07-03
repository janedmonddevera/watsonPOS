<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class queue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(queue))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SystemDataSet8 = New WindowsApplication12.systemDataSet8()
        Me.QueuelistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueuelistTableAdapter = New WindowsApplication12.systemDataSet8TableAdapters.queuelistTableAdapter()
        Me.SystemDataSet7 = New WindowsApplication12.systemDataSet7()
        Me.ListtableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListtableTableAdapter = New WindowsApplication12.systemDataSet7TableAdapters.listtableTableAdapter()
        Me.TableAdapterManager = New WindowsApplication12.systemDataSet7TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.QueueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueueTableAdapter = New WindowsApplication12.systemDataSet8TableAdapters.queueTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication12.systemDataSet8TableAdapters.TableAdapterManager()
        Me.QueueDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueuelistDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SystemDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueuelistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListtableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueuelistDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SystemDataSet8
        '
        Me.SystemDataSet8.DataSetName = "systemDataSet8"
        Me.SystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QueuelistBindingSource
        '
        Me.QueuelistBindingSource.DataMember = "queuelist"
        Me.QueuelistBindingSource.DataSource = Me.SystemDataSet8
        '
        'QueuelistTableAdapter
        '
        Me.QueuelistTableAdapter.ClearBeforeFill = True
        '
        'SystemDataSet7
        '
        Me.SystemDataSet7.DataSetName = "systemDataSet7"
        Me.SystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListtableBindingSource
        '
        Me.ListtableBindingSource.DataMember = "listtable"
        Me.ListtableBindingSource.DataSource = Me.SystemDataSet7
        '
        'ListtableTableAdapter
        '
        Me.ListtableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_noTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.listtableTableAdapter = Me.ListtableTableAdapter
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.productsTableAdapter = Nothing
        Me.TableAdapterManager.recieptTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.table1TableAdapter = Nothing
        Me.TableAdapterManager.table2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication12.systemDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "PROCEED"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QueueBindingSource
        '
        Me.QueueBindingSource.DataMember = "queue"
        Me.QueueBindingSource.DataSource = Me.SystemDataSet8
        '
        'QueueTableAdapter
        '
        Me.QueueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.adminTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.customer_noTableAdapter = Nothing
        Me.TableAdapterManager1.employeeTableAdapter = Nothing
        Me.TableAdapterManager1.listtableTableAdapter = Nothing
        Me.TableAdapterManager1.loginTableAdapter = Nothing
        Me.TableAdapterManager1.productsTableAdapter = Nothing
        Me.TableAdapterManager1.queuelistTableAdapter = Me.QueuelistTableAdapter
        Me.TableAdapterManager1.queueTableAdapter = Me.QueueTableAdapter
        Me.TableAdapterManager1.recieptTableAdapter = Nothing
        Me.TableAdapterManager1.salesTableAdapter = Nothing
        Me.TableAdapterManager1.table1TableAdapter = Nothing
        Me.TableAdapterManager1.table2TableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication12.systemDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QueueDataGridView
        '
        Me.QueueDataGridView.AllowUserToAddRows = False
        Me.QueueDataGridView.AllowUserToDeleteRows = False
        Me.QueueDataGridView.AutoGenerateColumns = False
        Me.QueueDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.QueueDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QueueDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.QueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11})
        Me.QueueDataGridView.DataSource = Me.QueueBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QueueDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.QueueDataGridView.GridColor = System.Drawing.Color.Black
        Me.QueueDataGridView.Location = New System.Drawing.Point(297, 1)
        Me.QueueDataGridView.Name = "QueueDataGridView"
        Me.QueueDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QueueDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.QueueDataGridView.RowHeadersVisible = False
        Me.QueueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.QueueDataGridView.Size = New System.Drawing.Size(606, 294)
        Me.QueueDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Unit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QTY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ITEM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Tax"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TAX"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'QueuelistDataGridView
        '
        Me.QueuelistDataGridView.AllowUserToAddRows = False
        Me.QueuelistDataGridView.AllowUserToDeleteRows = False
        Me.QueuelistDataGridView.AllowUserToResizeColumns = False
        Me.QueuelistDataGridView.AllowUserToResizeRows = False
        Me.QueuelistDataGridView.AutoGenerateColumns = False
        Me.QueuelistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.QueuelistDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.QueuelistDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QueuelistDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.QueuelistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueuelistDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.QueuelistDataGridView.DataSource = Me.QueuelistBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QueuelistDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.QueuelistDataGridView.GridColor = System.Drawing.Color.Black
        Me.QueuelistDataGridView.Location = New System.Drawing.Point(191, 1)
        Me.QueuelistDataGridView.Name = "QueuelistDataGridView"
        Me.QueuelistDataGridView.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QueuelistDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.QueuelistDataGridView.RowHeadersVisible = False
        Me.QueuelistDataGridView.ShowEditingIcon = False
        Me.QueuelistDataGridView.Size = New System.Drawing.Size(100, 294)
        Me.QueuelistDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "queue"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 111
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(0, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 47)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "BACK"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(556, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 294)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUSTOMER NO."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QUEUE"
        '
        'queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 297)
        Me.Controls.Add(Me.QueuelistDataGridView)
        Me.Controls.Add(Me.QueueDataGridView)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "queue"
        Me.Text = "cash"
        CType(Me.SystemDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueuelistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListtableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueuelistDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemDataSet8 As WindowsApplication12.systemDataSet8
    Friend WithEvents QueuelistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueuelistTableAdapter As WindowsApplication12.systemDataSet8TableAdapters.queuelistTableAdapter
    Friend WithEvents SystemDataSet7 As WindowsApplication12.systemDataSet7
    Friend WithEvents ListtableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListtableTableAdapter As WindowsApplication12.systemDataSet7TableAdapters.listtableTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication12.systemDataSet7TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents QueueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueueTableAdapter As WindowsApplication12.systemDataSet8TableAdapters.queueTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication12.systemDataSet8TableAdapters.TableAdapterManager
    Friend WithEvents QueueDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents QueuelistDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
