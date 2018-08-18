Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()

    End Function

    Function CsvReport() As ActionResult

        Dim list As List(Of Customer) = Customer.CreateList()

        Dim csvHeader As StringBuilder = New StringBuilder("Company, Name, EmailAddress").Append(vbCr)
        Dim csvBody As StringBuilder = New StringBuilder
        Dim reportBody = New StringBuilder

        'build body
        For Each c As Customer In list
            csvBody.Append(c.Company).Append(", ")
            csvBody.Append(c.Name).Append(", ")
            csvBody.Append(c.EmailAddress).Append(vbCr)
        Next

        reportBody.Append(csvHeader).Append(csvBody)

        ViewBag.CsvReport = reportBody.ToString

        Return View()

    End Function

End Class
