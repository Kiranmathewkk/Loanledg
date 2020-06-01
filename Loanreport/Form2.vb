Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class Form2
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\interview project\Loan Ledger\Loanreport\Loanreport\bin\Debug\Loanledger.accdb")
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoanledgerDataSet.Loan' table. You can move, or remove it, as needed.
        Me.LoanTableAdapter.Fill(Me.LoanledgerDataSet.Loan)
        'TODO: This line of code loads data into the 'LoanledgerDataSet.Loan' table. You can move, or remove it, as needed.
        Me.LoanTableAdapter.Fill(Me.LoanledgerDataSet.Loan)
        'TODO: This line of code loads data into the 'LoanledgerDataSet1.Loan' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LoanledgerDataSet.Loan' table. You can move, or remove it, as needed.
        Me.LoanTableAdapter.Fill(Me.LoanledgerDataSet.Loan)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim search As String = "Select * from Loan where LoanNo='" & ComboBox1.Text & "'"
        conn.Open()
        Dim cmd As New OleDbCommand(search, conn)
        Dim adpt As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(table)
        adpt.Fill(table)
        If table.Rows.Count <> 0 Then


            dataview1.DataSource = table.DefaultView
            conn.Close()
        Else
            MsgBox("Data not Found", MsgBoxStyle.Information)
        End If




        '  Dim reportdocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' reportdocument = New CrystalReport1
        'reportdocument.SetDataSource(table)
        'Form3.CrystalReportViewer1.ReportSource = reportdocument
        'Form3.ShowDialog()
        'Form3.Dispose()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        Dim search As String = "Select * from Loan where LoanNo='" & ComboBox1.Text & "'"


        conn.Open()
        Dim cmd As New OleDbCommand(search, conn)
        Dim adpt As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        Dim ds As New DataSet1

        'table.Rows.Add(table)
        adpt.Fill(ds.table1)
        adpt.Fill(ds.table2)
        adpt.Fill(ds.table3)
        adpt.Fill(ds.table4)
        adpt.Fill(ds.table5)
        adpt.Fill(ds.table6)
        '  adpt.Fill(ds.table7)
        conn.Close()



        Dim reportdocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdocument = New CrystalReport1
        reportdocument.SetDataSource(ds)
        '    reportdocument.SetDataSource(table1)

        Form3.CrystalReportViewer1.ReportSource = reportdocument
        Form3.ShowDialog()
        Form3.Dispose()
    End Sub
   

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class