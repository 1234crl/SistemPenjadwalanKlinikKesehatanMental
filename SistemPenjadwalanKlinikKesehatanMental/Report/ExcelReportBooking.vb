Imports Microsoft.Office.Interop.Excel

Public Class ExcelReportBooking


    Dim Path As String
    Sub New()
        Path = My.Application.Info.DirectoryPath
    End Sub

    Public Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub Generate(DataBooking As Data.DataTable)
        Dim XLApp As New Application
        Dim XLWorkbook As Workbook
        Dim Sheet1 As Worksheet

        Try
            'MessageBox.Show(Path)
            XLWorkbook = XLApp.Workbooks.Open(Path & "\Report\DaftarBooking.xltx")
            Sheet1 = XLWorkbook.Sheets("Sheet1")

            Dim i As Integer = 2
            For Each row As DataRow In DataBooking.Rows
                Sheet1.Range("A" & i).Value = row.Item("IdBooking")
                Sheet1.Range("B" & i).Value = row.Item("NamaDokter")
                Sheet1.Range("C" & i).Value = row.Item("NamaPasien")
                Sheet1.Range("D" & i).Value = row.Item("JenisLayananStr")
                Sheet1.Range("E" & i).Value = (row.Item("TglSesi")).ToString()
                Sheet1.Range("F" & i).Value = (row.Item("Jam")).ToString()
                Sheet1.Range("G" & i).Value = row.Item("Durasi")
                Sheet1.Range("H" & i).Value = row.Item("StatusBooking")

                Sheet1.Range("A" & i & ":G" & i).BorderAround2(
                    ColorIndex:=3, Weight:=XlBorderWeight.xlThick,
                    LineStyle:=XlLineStyle.xlDashDotDot)

                i = i + 1
            Next

            XLApp.WindowState = XlWindowState.xlMaximized
            XLApp.Visible = True

            ReleaseObject(Sheet1)
            ReleaseObject(XLWorkbook)
            ReleaseObject(XLApp)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



End Class
