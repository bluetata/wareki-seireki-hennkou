
' Copyright (c) 2017-2019 Sekito Lv(bluetata) <sekito.lv@gmail.com>
'
' Permission Is hereby granted, free of charge, to any person obtaining a copy
' of this software And associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, And/Or sell
' copies of the Software, And to permit persons to whom the Software Is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice And this permission notice shall be included in all
' copies Or substantial portions of the Software.
'
' THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS Or
' IMPLIED, INCLUDING BUT Not LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE And NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS Or COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES Or OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT Or OTHERWISE, ARISING FROM,
' OUT OF Or IN CONNECTION WITH THE SOFTWARE Or THE USE Or OTHER DEALINGS IN THE
' SOFTWARE.


'================================================================================
' 西暦 → 和暦 変更ツール
'
' Date    : 01/08/2019 16:31
' Version : version(1.0)</br>
' Author  : bluetata(Sekito.Lv) / Sekito.Lv@gmail.com</br>
'================================================================================
Public Class Seireki2WarekiConversion

    ' 西暦から和暦に変換する方法
    Public Shared Function WarekiConversionApater(ByVal d1 As System.DateTime)

        ' 文字列を日付に返す
        Dim strDay As String
        Dim iYear As Integer

        ' 西暦を返還する（明治編）
        If (IsDatetimeAfter(d1, New System.DateTime(1868, 1, 24, 23, 59, 0)) And
                IsDatetimeBefore(d1, New System.DateTime(1912, 7, 30, 0, 0, 0))) Then

            ' 西暦から和暦に変換する
            iYear = d1.Year - 1867

            ' 日付を返す
            If (iYear = 1) Then
                strDay = String.Concat("明治元年", d1.Month, "月", d1.Day, "日")
            Else
                strDay = String.Concat("明治", iYear, "年", d1.Month, "月", d1.Day, "日")
            End If

            Return strDay
        End If

        ' 西暦を返還する（大正編）
        If (IsDatetimeAfter(d1, New System.DateTime(1912, 7, 29, 23, 59, 0)) And
                IsDatetimeBefore(d1, New System.DateTime(1926, 12, 25, 0, 0, 0))) Then

            ' 西暦から和暦に変換する
            iYear = d1.Year - 1911

            ' 日付を返す
            If (iYear = 1) Then
                strDay = String.Concat("大正元年", d1.Month, "月", +d1.Day, "日")
            Else
                strDay = String.Concat("大正", iYear, "年", d1.Month, "月", d1.Day, "日")
            End If

            Return strDay
        End If

        ' 西暦を返還する（昭和編）
        If (IsDatetimeAfter(d1, New System.DateTime(1926, 12, 24, 23, 59, 0)) And
                IsDatetimeBefore(d1, New System.DateTime(1989, 1, 8, 0, 0, 0))) Then

            ' 西暦から和暦に変換する
            iYear = d1.Year - 1925

            ' 日付を返す
            If (iYear = 1) Then
                strDay = String.Concat("昭和元年", d1.Month, "月", d1.Day, "日")
            Else
                strDay = String.Concat("昭和", iYear, "年", d1.Month, "月", d1.Day, "日")
            End If

            Return strDay
        End If

        ' 西暦を変換する（平成編）
        If (IsDatetimeAfter(d1, New System.DateTime(1989, 1, 7, 23, 59, 0)) And
                IsDatetimeBefore(d1, New System.DateTime(2019, 5, 1, 0, 0, 0))) Then

            ' 西暦から和暦に変換する
            iYear = d1.Year - 1988

            ' 日付を返す
            If (iYear = 1) Then
                strDay = String.Concat("平成元年", d1.Month, "月", d1.Day, "日")
            Else
                strDay = String.Concat("平成", iYear, "年", d1.Month, "月", d1.Day, "日")
            End If

            Return strDay
        End If

        ' 西暦を変換する（新元号・德仁（暫定））
        If (IsDatetimeAfter(d1, New System.DateTime(2019, 4, 30, 23, 59, 0))) Then

            ' 西暦から和暦に変換する
            iYear = d1.Year - 2019

            ' 日付を返す
            If (iYear = 0) Then
                strDay = String.Concat("新元号・德仁（暫定）元年", d1.Month, "月", d1.Day, "日")
            Else
                strDay = String.Concat("新元号・德仁（暫定）", iYear, "年", d1.Month, "月", d1.Day + "日")
            End If

            Return strDay
        End If

        ' それ以外
        strDay = "和暦は明治・大正・昭和・平成・德仁のみ対応しております"

        Return strDay

    End Function


    Public Shared Function IsDateAfter(ByVal d1 As Date, ByVal d2 As Date) As Boolean
        Return CDate(d1) > CDate(d2)
    End Function

    ' Checks if this date-time d1 is before the specified date-time d2.
    Public Shared Function IsDatetimeBefore(ByVal d1 As System.DateTime, ByVal d2 As System.DateTime) As Boolean
        If System.DateTime.Compare(d1, d2) < 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Checks if this date-time d1 is after the specified date-time d2.
    Public Shared Function IsDatetimeAfter(ByVal d1 As System.DateTime, ByVal d2 As System.DateTime) As Boolean
        If System.DateTime.Compare(d1, d2) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    ' メインテスト
    Public Shared Sub Main()

        'Dim d1 As New Date(1993, 5, 31)
        'Dim d2 As New Date(1993, 5, 30)

        'Dim d3 As New System.DateTime(1993, 5, 31, 12, 14, 0)
        'Dim d4 As New System.DateTime(1994, 5, 31, 12, 14, 0)

        Dim d5 As New System.DateTime(2019, 5, 1, 0, 0, 0)
        Dim d6 As New System.DateTime(2019, 6, 1, 0, 0, 0)

        'Console.WriteLine(IsDateAfter(d1, d2))
        'Console.WriteLine(IsDatetimeAfter(d1, d2))
        Console.WriteLine(IsDatetimeBefore(d5, d6))
        Console.WriteLine(IsDatetimeAfter(d5, d6))

        Dim arrTestDate(8) As String
        Dim sDay() As String
        Dim ldt As System.DateTime

        arrTestDate(0) = "2018/12/05"
        arrTestDate(1) = "2018/02/05"
        arrTestDate(2) = "2018/2/5"
        arrTestDate(3) = "2019/05/01"  ' 新元号

        arrTestDate(4) = "1868/11/30"  ' 明治
        arrTestDate(5) = "1988/12/27"  ' 昭和
        arrTestDate(6) = "1990/02/05"  ' 平成

        arrTestDate(7) = "2018/02/30"  ' 異常テストデータ

        For Each strTestingDate In arrTestDate
            sDay = strTestingDate.Split("/")

            ' 文字列を日付に変換する
            ldt = New System.DateTime(sDay(0), sDay(1), sDay(2), 0, 0, 0)
            Console.WriteLine(WarekiConversionApater(ldt))
        Next strTestingDate

    End Sub

End Class
