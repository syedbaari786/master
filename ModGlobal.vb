Imports System
Imports System.Math

Module Haversine

    ' Convert degrees to radians
    Function ToRadians(degrees As Double) As Double
        Return degrees * Math.PI / 180
    End Function

    ' Calculate the great-circle distance between two points on a sphere
    Function Distance(lat1 As Double, lon1 As Double, lat2 As Double, lon2 As Double) As Double
        Dim R As Double = 6371 ' Earth's radius in kilometers
        Dim dLat As Double = ToRadians(lat2 - lat1)
        Dim dLon As Double = ToRadians(lon2 - lon1)
        lat1 = ToRadians(lat1)
        lat2 = ToRadians(lat2)
        Dim a As Double = Sin(dLat / 2) * Sin(dLat / 2) + Sin(dLon / 2) * Sin(dLon / 2) * Cos(lat1) * Cos(lat2)
        Dim c As Double = 2 * Atan2(Sqrt(a), Sqrt(1 - a))
        Return R * c
    End Function

    Sub Main()
        ' Example usage
        Dim lat1 As Double = 14.06329830736286
        Dim lon1 As Double = 77.3573742657235
        Dim lat2 As Double = 14.063298337775
        Dim lon2 As Double = 77.3573778319059
        MsgBox("Distance: {0:0.00} km", Distance(lat1, lon1, lat2, lon2))
    End Sub

End Module