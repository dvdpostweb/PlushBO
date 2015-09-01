Public Class clsReviews

    Public Shared Function GetSelectReviewsNoManaged() As String
        Dim sql As String
        sql = "select * from common_production.reviews where reviews_check = 0"
        Return sql
    End Function

#Region "Customer"
    ''' <summary>
    ''' calcul the number of critique and average quality DVDPOST
    ''' </summary>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectCritiqueCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select customers_id,count(*) cpt_critiques,sum(dvdpost_rating) total_rating, (sum(dvdpost_rating) / count(*)) * 100 average_rating  " & _
                " from common_production.reviews where customers_id = " & customers_id & _
                " group by customers_id "

        Return sql
    End Function

    ''' <summary>
    ''' list of reviews of customer
    ''' </summary>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectReviewsCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select id reviews_id,date_added, imdb_id ,reviews_rating rating ,reviews_check open,reviews_text critique " & _
                " from common_production.reviews where customers_id = " & customers_id & _
                " order by last_modified desc "
        Return sql
    End Function

    ''' <summary>
    ''' calcul the average_quality_public
    ''' </summary>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectAverageCritiqueCustomers(ByVal customers_id) As String
        Dim sql As String

        sql = " select r.customers_id,sum(cpt) cpt_critiques ,sum(pertinente) cpt_critiques_positive,(sum(pertinente) / sum(cpt)) * 100 average_rating_critique " & _
              " from common_production.reviews r left join " & _
              "   ( " & _
              "     select review_id,count(*) cpt,sum(if(reviews_interesting = 1,1,0)) pertinente from common_production.reviews_rating group by review_id " & _
              "   ) rr on r.id = rr.review_id " & _
              " where not cpt is null and r.customers_id = " & customers_id & _
              " group by r.customers_id "

        Return sql
    End Function

    ''' <summary>
    ''' calcul the number of rating
    ''' </summary>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectRating(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select customers_id,count(*) cpt_rating from products_rating " & _
        " where customers_id = " & customers_id & _
        " group by customers_id "
        Return sql

    End Function

    ''' <summary>
    ''' calcul the list of best number of critiques
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectBestNumberCritique(ByVal isweek As Boolean) As String
        Dim sql As String

        Dim strWeek As String = ""
        If isweek Then
            strWeek = "and date_add(r.last_modified, interval 1 week) >= now() "
        End If

        sql = "  SELECT 0 INTO @x;" & _
              " select (@x:=@x+1) as rownumber, r.customers_id,count(*) cpt_critiques " & _
              " from common_production.reviews r " & _
              " join customers c on r.customers_id = c.customers_id " & _
              " where c.customers_abo = 1 " & strWeek & _
              " group by r.customers_id " & _
              " order by count(*) desc "

        Return sql
    End Function

    ''' <summary>
    ''' calcul the list of best quality dvdpost of critiques
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectBestqualityDvdpostCritique(ByVal isweek As Boolean) As String
        Dim sql As String
        Dim strWeek As String = ""
        If isweek Then
            strWeek = "and date_add(r.last_modified, interval 1 week) >= now() "
        End If

        sql = " SELECT 0 INTO @x;" & _
                " select (@x:=@x+1) as rownumber,r.customers_id, (sum(dvdpost_rating) / count(*)) * 100 average_rating  " & _
                " from common_production.reviews r " & _
                " join customers c on r.customers_id = c.customers_id " & _
                " where c.customers_abo = 1 and dvdpost_rating is not null " & strWeek & _
                " group by r.customers_id " & _
                " order by  (sum(dvdpost_rating) / count(*)) * 100 desc; "

        Return sql
    End Function

    ''' <summary>
    ''' calcul the list of best average critique of customers
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectBestCritiqueCustomers(ByVal isweek As Boolean) As String
        Dim sql As String
        Dim strWeek As String = ""
        If isweek Then
            strWeek = "and date_add(r.last_modified, interval 1 week) >= now() "
        End If
        sql = " SELECT 0 INTO @x;" & _
              " select (@x:=@x+1) as rownumber,xx.* from (" & _
              " select r.customers_id,sum(cpt)cpt_critiques,sum(pertinente) cpt_critiques_positive,(sum(pertinente) / sum(cpt)) * 100 average_rating_critique " & _
              " from common_production.reviews r left join " & _
              "   ( " & _
              "     select reviews_id,count(*) cpt,sum(if(reviews_interesting = 1,1,0)) pertinente from reviews_rating group by reviews_id " & _
              "   ) rr on r.reviews_id = rr.reviews_id " & _
                " join customers c on r.customers_id = c.customers_id " & _
              " where c.customers_abo = 1 and not cpt is null " & strWeek & _
              " group by r.customers_id having sum(cpt) > 5) xx" & _
              " order by average_rating_critique desc,cpt_critiques desc"

        Return sql
    End Function

    ''' <summary>
    ''' calcul the list of best number rating
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSelectBestRating(ByVal isweek As Boolean) As String
        Dim sql As String
        Dim strWeek As String = ""
        If isweek Then
            strWeek = "and date_add(products_rating_date, interval 1 week) >= now() "
        End If
        sql = " SELECT 0 INTO @x;" & _
              " select (@x:=@x+1) as rownumber, pr.customers_id,count(*) cpt_rating from products_rating pr " & _
              " join customers c on pr.customers_id = c.customers_id " & _
              " where c.customers_abo = 1 " & strWeek & _
              " group by pr.customers_id " & _
              " order by count(*) desc "
        Return sql

    End Function

#End Region

    Public Shared Function getSelectValueRating() As String
        Dim sql As String
        sql = " SELECT codevalue as rating_id, codedesc as rating_desc from generalglobalcode where CodeType = 'Products_Rating'"
        Return sql
    End Function
#Region "Products"
   
    Public Shared Function GetSelectReviewsProducts(ByVal products_id As Integer) As String
        Dim sql As String
        sql = " select reviews_id,date_added,customers_id,reviews_rating rating ,reviews_check open,reviews_text critique" & _
              " from common_production.reviews where products_id = " & products_id & _
              " order by last_modified desc "
        Return sql
    End Function

    Public Shared Function GetSelectAverageCritiqueProducts(ByVal products_id) As String
        Dim sql As String

        sql = " select r.products_id,sum(cpt) cpt_critiques,sum(pertinente) cpt_critiques_positive,(sum(pertinente) / sum(cpt)) * 100 average_rating_critique " & _
              " from common_production.reviews r left join " & _
              "   ( " & _
              "     select reviews_id,count(*) cpt,sum(if(reviews_interesting = 1,1,0)) pertinente from reviews_rating group by reviews_id " & _
              "   ) rr on r.reviews_id = rr.reviews_id " & _
              " where not cpt is null and r.products_id = " & products_id & _
              " group by r.products_id "

        Return sql
    End Function

    Public Shared Function GetSelectAverageRatingProducts(ByVal products_id As String) As String
        Dim sql As String
        sql = " SELECT products_id,count(*) cpt_rating ,sum(products_rating) rating_total," & _
              " (sum(products_rating) / count(*)) * 100 average_rating " & _
              " FROM products_rating p where products_id = " & products_id & _
              " group by products_id"
        Return sql
    End Function

    Public Shared Function GetSelectBestRatingProducts(ByVal isweek As Boolean) As String
        Dim sql As String
        Dim strWeek As String = ""
        If isweek Then
            strWeek = "and date_add(products_rating_date, interval 1 week) >= now() "
        End If
        sql = " SELECT 0 INTO @x;" & _
              " select (@x:=@x+1) as rownumber, pr.products_id,pd.products_name,count(*) cpt_rating from products_rating pr " & _
              " join products_description pd on pd.products_id = pr.products_id and language_id = 1 " & _
              " where 1 " & strWeek & _
              " group by pr.products_id " & _
              " order by count(*) desc "
        Return sql
    End Function

    Public Shared Function GetSelectBestProductPolemique(ByVal isweek As Boolean) As String
        Dim sql As String
        Dim strWeek As String = ""
        If isweek Then
            strWeek = "and date_add(products_rating_date, interval 1 week) >= now() "
        End If
        sql = " SELECT 0 INTO @x;" & _
               " select (@x:=@x+1) as rownumber,xx.products_id,pd.products_name,abs(xx.mauvais - xx.bon) polemique,cpt nb_rating from " & _
                " ( " & _
                " select products_id,count(*) cpt,sum(if (products_rating>=3,1,0)) bon, sum(if (products_rating>=3,0,1)) mauvais " & _
                " from products_rating where 1 " & strWeek & " group by products_id " & _
                " ) xx " & _
                " join products_description pd on pd.products_id = xx.products_id and language_id = 1 " & _
                " order by polemique,cpt desc "
        Return sql
    End Function
#End Region

  

   
End Class
