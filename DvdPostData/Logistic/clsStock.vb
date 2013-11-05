Public Class clsStock
    Const MAXPARTINBOX As Integer = 5
    Const MAXNUMBERBOX As Integer = 6000

    Public Shared Function GetSelectStock(ByVal box_id As Integer, ByVal inStockOnly As Boolean) As String
        Dim sql As String
        Dim sqlStock As String = ""

        If inStockOnly Then
            sqlStock = " and pd.inout = 1"
        End If
        sql = " select pd.products_id , pd.products_dvdid , pd.pibox_id, pd.box_id,pd.inout,ss.fullname,pdsh.last_modified,pd.products_dvd_status,pds.products_dvd_status_name from" & _
                " products_dvd pd " & _
                " left join (select products_id,products_dvd_id,max(id) id from products_dvd_state_history group by products_id,products_dvd_id) hist " & _
                " on pd.products_id = hist.products_id and pd.products_dvdid = hist.products_dvd_id" & _
                " left join products_dvd_state_history pdsh  on hist.id = pdsh.id" & _
                " left join securityuser ss on ss.UserID = pdsh.user_modified" & _
                " left join products_dvd_status pds on pds.products_dvd_status_id = pd.products_dvd_status " & _
                " where pd.box_id = " & box_id & sqlStock & _
                " order by pd.pibox_id desc "
        Return sql

    End Function
    Public Shared Function getBoxEmpty() As String
        Dim sql As String
        sql = " SELECT 0 INTO @x;" & _
               " select * from " & _
               " (select (@x:=@x+1) as rownumber from products where @x <= 4500) b " & _
               " left join (select box_id,count(*) cpt from products_dvd where `inout` = 1 group by box_id) xx " & _
               "  on b.rownumber = xx.box_id " & _
               " order by cpt,rownumber; "
        Return sql
    End Function
    Public Shared Function GetLastInventory() As String
        Dim sql As String
        sql = " select box_id,max(date_added) last_inventory " & _
              " from products_dvd_state_history " & _
              " where type_process = " & ClsProducts_dvd_state.state.STOCK & " and box_id > 0   group by box_id order by max(date_added) "
        Return sql
    End Function
    Public Shared Function GetMoreEmptyBox() As String
        Dim sql As String
        sql = " SELECT 0 INTO @x;" & _
              " select ((xx.box * " & MAXPARTINBOX & ") + 1) min ,((xx.box+1)*" & MAXPARTINBOX & ") max,dvd_count from ( " & _
              " SELECT ((b.box_id -1) div " & MAXPARTINBOX & ") box, count(pd.products_id) as DVD_Count " & _
              " from  (select (@x:=@x+1) as box_id from products where @x <= " & MAXNUMBERBOX & ") b " & _
              " left join products_dvd pd on b.box_id = pd.box_id and `inout` = 1 and products_dvd_status = 1 " & _
              " where b.box_id > 0 group by ((b.box_id - 1) div " & MAXPARTINBOX & ")) xx " & _
              " order by dvd_count,min "

        Return sql
    End Function
End Class
