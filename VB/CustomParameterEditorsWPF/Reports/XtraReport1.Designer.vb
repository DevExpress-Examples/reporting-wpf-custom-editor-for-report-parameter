Namespace CustomParameterEditorsWPF.Reports
    Partial Public Class XtraReport1
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

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim MasterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.categories = New DevExpress.XtraReports.Parameters.Parameter()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'sqlDataSource1
            '
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            ColumnExpression1.ColumnName = "CategoryID"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""223"" />"
            Table1.Name = "Categories"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "CategoryName"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "Description"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "Picture"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Name = "Categories"
            SelectQuery1.Tables.Add(Table1)
            ColumnExpression5.ColumnName = "ProductID"
            Table2.Name = "Products"
            ColumnExpression5.Table = Table2
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "ProductName"
            ColumnExpression6.Table = Table2
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "SupplierID"
            ColumnExpression7.Table = Table2
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "CategoryID"
            ColumnExpression8.Table = Table2
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "QuantityPerUnit"
            ColumnExpression9.Table = Table2
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "UnitPrice"
            ColumnExpression10.Table = Table2
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "UnitsInStock"
            ColumnExpression11.Table = Table2
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "UnitsOnOrder"
            ColumnExpression12.Table = Table2
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "ReorderLevel"
            ColumnExpression13.Table = Table2
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "Discontinued"
            ColumnExpression14.Table = Table2
            Column14.Expression = ColumnExpression14
            ColumnExpression15.ColumnName = "EAN13"
            ColumnExpression15.Table = Table2
            Column15.Expression = ColumnExpression15
            SelectQuery2.Columns.Add(Column5)
            SelectQuery2.Columns.Add(Column6)
            SelectQuery2.Columns.Add(Column7)
            SelectQuery2.Columns.Add(Column8)
            SelectQuery2.Columns.Add(Column9)
            SelectQuery2.Columns.Add(Column10)
            SelectQuery2.Columns.Add(Column11)
            SelectQuery2.Columns.Add(Column12)
            SelectQuery2.Columns.Add(Column13)
            SelectQuery2.Columns.Add(Column14)
            SelectQuery2.Columns.Add(Column15)
            SelectQuery2.Name = "Products"
            SelectQuery2.Tables.Add(Table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2})
            MasterDetailInfo1.DetailQueryName = "Products"
            RelationColumnInfo1.NestedKeyColumn = "CategoryID"
            RelationColumnInfo1.ParentKeyColumn = "CategoryID"
            MasterDetailInfo1.KeyColumns.Add(RelationColumnInfo1)
            MasterDetailInfo1.MasterQueryName = "Categories"
            MasterDetailInfo1.Name = "CategoriesProducts"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {MasterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            '
            'BottomMargin
            '
            Me.BottomMargin.HeightF = 47.91667!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrTableRow2
            '
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell8})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1.0R
            '
            'xrTableCell4
            '
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell4.Weight = 1.3238065866568374R
            '
            'xrTableCell5
            '
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPerUnit]")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell5.Weight = 0.63058689324340533R
            '
            'xrTableCell6
            '
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.TextFormatString = "{0:$0.00}"
            Me.xrTableCell6.Weight = 0.47719687356310375R
            '
            'xrTableCell8
            '
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell8.Weight = 0.70978955153604151R
            '
            'xrTableRow1
            '
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell7})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1.0R
            '
            'xrTableCell1
            '
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 1.3238065866568374R
            '
            'xrTableCell2
            '
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "Quantity Per Unit"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.63058689324340533R
            '
            'xrTableCell3
            '
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "Unit Price"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.47719687356310375R
            '
            'xrTableCell7
            '
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "Units In Stock"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.70978955153604151R
            '
            'xrLabel2
            '
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel2.ForeColor = System.Drawing.Color.DimGray
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.006993612!, 50.62502!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(420.0!, 23.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'xrControlStyle1
            '
            Me.xrControlStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.xrControlStyle1.Name = "xrControlStyle1"
            Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            '
            'xrPictureBox1
            '
            Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(551.8818!, 10.00001!)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.625!, 79.99998!)
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
            Me.Detail.HeightF = 104.1667!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPanel1
            '
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel1})
            Me.xrPanel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName]")})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(17.00001!, 10.00001!)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(721.0!, 94.16666!)
            '
            'xrLabel1
            '
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.006993612!, 10.00001!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(420.0!, 29.25!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'Detail1
            '
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail1.HeightF = 25.0!
            Me.Detail1.Name = "Detail1"
            '
            'xrTable2
            '
            Me.xrTable2.BookmarkParent = Me.xrPanel1
            Me.xrTable2.BorderColor = System.Drawing.Color.LightGray
            Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.EvenStyleName = "xrControlStyle1"
            Me.xrTable2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoriesProducts.ProductName]")})
            Me.xrTable2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 0!)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(717.4999!, 25.0!)
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UsePadding = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.ReportHeader.HeightF = 25.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'xrTable1
            '
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.xrTable1.BorderColor = System.Drawing.Color.LightGray
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 0!)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(717.4999!, 25.0!)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            '
            'DetailReport
            '
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportHeader})
            Me.DetailReport.DataMember = "Categories.CategoriesProducts"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 47.91667!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'categories
            '
            Me.categories.Description = "Categories"
            Me.categories.MultiValue = True
            Me.categories.Name = "categories"
            DynamicListLookUpSettings1.DataMember = "Categories"
            DynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            DynamicListLookUpSettings1.DisplayMember = "CategoryName"
            DynamicListLookUpSettings1.FilterString = Nothing
            DynamicListLookUpSettings1.ValueMember = "CategoryName"
            Me.categories.ValueSourceSettings = DynamicListLookUpSettings1
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.FilterString = "[CategoryName] In (?categories)"
            Me.Margins = New System.Drawing.Printing.Margins(49, 53, 48, 48)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.categories})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.xrControlStyle1})
            Me.Version = "22.1"
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private categories As DevExpress.XtraReports.Parameters.Parameter
        Friend WithEvents xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
