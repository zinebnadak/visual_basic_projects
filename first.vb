Imports System

Module Program
    Sub Main(args As String())

        Dim message As String
        Dim countMin As Integer
        Dim countMax As Integer
        Dim i As Integer
        Dim z As Boolean


        countMin = 1
        countMax = 10
        i = 0
        message = "Zineb"
        z = True

        For i = countMin To countMax

            If i > 5 Then
                z = False
            End If

            If z = True Then
                Console.WriteLine("Message: " & message & "Counter: " & i)
            Else
                Console.WriteLine("Message: " & message & "Out of bounds!: ")
            End If
        Next
    End Sub
End Module
