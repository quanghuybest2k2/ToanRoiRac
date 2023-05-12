Dim x, y, z, t
Dim resultFile, resultText
Set resultFile = CreateObject("Scripting.FileSystemObject").CreateTextFile("result.txt", True)

dem = 0

For x = 1 To 20
    For y = 2 To 20
        For z = 3 To 20
            For t = 4 To 20
                If x + y + z + t = 20 Then
                    dem = dem+1
                    resultText = "x = " & x & ", y = " & y & ", z = " & z & ", t = " & t
                    resultFile.WriteLine(resultText)
                End If
            Next
        Next
    Next
Next
resultFile.Close
MsgBox("Ket qua la: "&dem)