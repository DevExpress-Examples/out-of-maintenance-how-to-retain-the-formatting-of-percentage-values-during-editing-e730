Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colValue As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Value"
			Me.dataColumn1.DataType = GetType(Decimal)
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(424, 317)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colValue})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colValue
			' 
			Me.colValue.Caption = "Value"
			Me.colValue.ColumnEdit = Me.repositoryItemTextEdit1
			Me.colValue.FieldName = "Value"
			Me.colValue.Name = "colValue"
			Me.colValue.Visible = True
			Me.colValue.VisibleIndex = 0
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.DisplayFormat.FormatString = "p"
			Me.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.repositoryItemTextEdit1.EditFormat.FormatString = "p"
			Me.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
'			Me.repositoryItemTextEdit1.ParseEditValue += New DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(Me.repositoryItemTextEdit1_ParseEditValue);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(424, 317)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "How to retain the formatting of percentage values during editing"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			dataTable1.Rows.Add(New Object() {0.098})
			dataTable1.Rows.Add(New Object() {0.18})
			dataTable1.Rows.Add(New Object() {0.75})
		End Sub

		Private Sub repositoryItemTextEdit1_ParseEditValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles repositoryItemTextEdit1.ParseEditValue
			If TypeOf e.Value Is String Then
				Dim strValue As String = CStr(e.Value)
				strValue = strValue.Trim("%"c, " "c)
				Dim dblValue As Double
				If Double.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat, dblValue) Then
					dblValue /= 100.0
					e.Value = dblValue
					e.Handled = True
				End If
			End If
		End Sub
	End Class
End Namespace
