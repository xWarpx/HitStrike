Public Class Block : Inherits PictureBox
    Dim random As New Random()
    Public Sub New()

        Width = 100
        Height = 20
        BackColor = Color.Red
        Location = startLocation(random.Next(1, 5))

    End Sub

    Public Sub moveBlock()
        Top += 10
    End Sub

    Public Function startLocation(point)
        If point = 1 Then
            Dim p As Point = New Point(58, 10)
            Return p
        ElseIf point = 2 Then
            Dim p As Point = New Point(308, 10)
            Return p
        ElseIf point = 3 Then
            Dim p As Point = New Point(558, 10)
            Return p
        ElseIf point = 4 Then
            Dim p As Point = New Point(808, 10)
            Return p
        Else
            Return point(10, 10)
        End If
    End Function


End Class
