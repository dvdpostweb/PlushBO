Public Class clsInvoice

    Public Shared Function getSelectInvoicesAll() As String
        Dim sql As String

        sql = " select * from studio_invoices"

        Return sql
    End Function

    Public Shared Function getSelectInvoiceItems(ByVal invoice_id As Integer) As String
        Dim sql As String

        sql = " select * from studio_invoice_items where invoice_id = " & invoice_id

        Return sql
    End Function

    Public Shared Function getInsertInvoice(ByVal supplier_name As String, ByVal invoice_date As String, ByVal supplier_invoice_number As String, ByVal dvdpost_invoice_number As String, ByVal invoice_total As String) As String
        Dim sql As String

        invoice_total = invoice_total.Replace(",", ".")

        sql = " insert into studio_invoices ( supplier_name, invoice_date, supplier_invoice_number, dvdpost_invoice_number, invoice_total) " & _
        "values('" & supplier_name & "', '" & invoice_date & "', '" & supplier_invoice_number & "', '" & dvdpost_invoice_number & "', " & invoice_total & ")"

        Return sql
    End Function

    Public Shared Function getInsertInvoiceItem(ByVal invoice_id As Decimal, ByVal dvd_title As String, ByVal dvd_quantity As Integer, ByVal dvd_unit_price As String, ByVal dvd_total As String) As String
        Dim sql As String

        dvd_unit_price = dvd_unit_price.Replace(",", ".")
        dvd_total = dvd_total.Replace(",", ".")

        sql = " insert into studio_invoice_items ( invoice_id, dvd_title,  dvd_quantity, dvd_unit_price, dvd_total ) " & _
        "values(" & invoice_id & ", '" & dvd_title & "', " & dvd_quantity & ", " & dvd_unit_price & ", " & dvd_total & ")"

        Return sql
    End Function

    Public Shared Function getUpdateInvoice(ByVal ID As Integer, ByVal supplier_name As String, ByVal invoice_date As String, ByVal supplier_invoice_number As String, ByVal dvdpost_invoice_number As String, _
                                           ByVal invoice_total As String)
        Dim sql As String = ""

        invoice_total = invoice_total.Replace(",", ".")

        sql = " update studio_invoices set supplier_name = '" & supplier_name & _
                "', invoice_date = '" & invoice_date & _
                "', supplier_invoice_number = '" & supplier_invoice_number & _
                "', dvdpost_invoice_number = '" & dvdpost_invoice_number & _
                "', invoice_total = " & invoice_total & " where id = " & ID

        Return sql
    End Function

    Public Shared Function getUpdateInvoiceItem(ByVal id As Integer, ByVal invoice_id As Integer, ByVal dvd_title As String, ByVal dvd_quantity As Integer, _
                                                   ByVal dvd_unit_price As String, ByVal dvd_total As String) As String
        Dim sql As String = ""

        dvd_unit_price = dvd_unit_price.Replace(",", ".")
        dvd_total = dvd_total.Replace(",", ".")

        sql = " update studio_invoice_items set dvd_title = '" & dvd_title & _
                "', dvd_quantity = " & dvd_quantity & _
                ", dvd_unit_price = " & dvd_unit_price & _
                ", dvd_total = " & dvd_total & " where id = " & id

        Return sql
    End Function

    Public Shared Function GetDeleteInvoice(ByVal id As Integer) As String
        Dim sql As String = ""

        sql = " delete from studio_invoices where id = " & id

        Return sql
    End Function

    Public Shared Function GetDeleteInvoiceItems(ByVal id As Integer) As String
        Dim sql As String = ""

        sql = " delete from studio_invoice_items where invoice_id = " & id

        Return sql
    End Function

    Public Shared Function getSelectNewInvoiceID(ByVal supplier_name As String, ByVal invoice_date As String, ByVal supplier_invoice_number As String, ByVal dvdpost_invoice_number As String, ByVal invoice_total As String) As String
        Dim sql As String

        sql = " select id from studio_invoices where supplier_name = '" & supplier_name & "' and invoice_date = '" & invoice_date & "' and supplier_invoice_number = '" & supplier_invoice_number & "'  and dvdpost_invoice_number = '" & dvdpost_invoice_number & "' and invoice_total = " & invoice_total
        Return sql
    End Function

End Class
