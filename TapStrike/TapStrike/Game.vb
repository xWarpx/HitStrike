Imports System.Collections.Generic

Public Class Game
    Dim random As New Random()
    Dim group As New List(Of Object)
    Dim c As New Block
    Dim timeCounter As Integer = 0
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Controls.Add(c)
        group.Add(c)
        Label1.Text = group.Count
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeCounter < 1 Then
            NewBlock()
            timeCounter = 10
        End If
        timeCounter -= 1
        For i As Integer = 0 To (group.Count - 1)
            group(i).top += 5
            CheckHit(i)
        Next
        Label1.Text = group.Count

    End Sub

    Public Sub NewBlock()
        Dim x As New Block
        group.Add(x)
        Controls.Add(x)
    End Sub

    Public Sub CheckHit(item)
        If group(item).top > 900 Then
            Controls.Remove(group.Item(item))
        End If

    End Sub
End Class



