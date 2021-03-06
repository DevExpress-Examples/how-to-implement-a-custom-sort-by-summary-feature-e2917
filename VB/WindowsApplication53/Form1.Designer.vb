Namespace WindowsApplication53
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldValueCount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
            Me.dataTable1.TableName = "Data"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Name"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(Date)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Decimal)
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "Value2"
            Me.dataColumn4.DataType = GetType(Decimal)
            ' 
            ' fieldDate1
            ' 
            Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate1.AreaIndex = 1
            Me.fieldDate1.Caption = "Date"
            Me.fieldDate1.FieldName = "Date"
            Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
            Me.fieldDate1.Name = "fieldDate1"
            Me.fieldDate1.UnboundFieldName = "fieldDate1"
            ' 
            ' fieldValue
            ' 
            Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue.AreaIndex = 0
            Me.fieldValue.FieldName = "Value"
            Me.fieldValue.Name = "fieldValue"
            ' 
            ' fieldDate
            ' 
            Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate.AreaIndex = 0
            Me.fieldDate.Caption = "Year"
            Me.fieldDate.FieldName = "Date"
            Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldDate.Name = "fieldDate"
            Me.fieldDate.UnboundFieldName = "fieldDate"
            ' 
            ' fieldName
            ' 
            Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName.AreaIndex = 0
            Me.fieldName.FieldName = "Name"
            Me.fieldName.Name = "fieldName"
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldName, Me.fieldDate, Me.fieldValue, Me.fieldDate1, Me.fieldValueCount})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(796, 292)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' fieldValueCount
            ' 
            Me.fieldValueCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValueCount.AreaIndex = 1
            Me.fieldValueCount.Caption = "Count"
            Me.fieldValueCount.FieldName = "Value"
            Me.fieldValueCount.Name = "fieldValueCount"
            Me.fieldValueCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(481, 0)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(254, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Apply custom Sort By Summary"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(796, 292)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dataSet1 As System.Data.DataSet
        Private dataTable1 As System.Data.DataTable
        Private dataColumn1 As System.Data.DataColumn
        Private dataColumn2 As System.Data.DataColumn
        Private dataColumn3 As System.Data.DataColumn
        Private dataColumn4 As System.Data.DataColumn
        Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldName As DevExpress.XtraPivotGrid.PivotGridField
        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private fieldValueCount As DevExpress.XtraPivotGrid.PivotGridField
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

