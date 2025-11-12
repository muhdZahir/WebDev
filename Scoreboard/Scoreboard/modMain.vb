Module modMain
    Public Function GetStateName(ByVal intStateCode As Integer) As String
        Dim strStateName As String = String.Empty
        Select Case intStateCode
            Case 1
                strStateName = "Johor"
            Case 2
                strStateName = "Kedah"
            Case 3
                strStateName = "Kelantan"
            Case 4
                strStateName = "Melaka"
            Case 5
                strStateName = "Negeri Sembilan"
            Case 6
                strStateName = "Pahang"
            Case 7
                strStateName = "Pulau Pinang"
            Case 8
                strStateName = "Perak"
            Case 9
                strStateName = "Perlis"
            Case 10
                strStateName = "Selangor"
            Case 11
                strStateName = "Terengganu"
            Case 12
                strStateName = "Sabah"
            Case 13
                strStateName = "Sarawak"
            Case 14
                strStateName = "Kuala Lumpur"
        End Select
    End Function
End Module
