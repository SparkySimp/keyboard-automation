Public Class FrmAutoKey
    Private Sub btnNote_Click(sender As Object, e As EventArgs) Handles btnNoteG.Click, btnNoteF.Click, btnNoteE.Click, btnNoteD.Click, btnNoteC.Click, btnNoteB.Click, btnNoteA.Click
        Dim btn As Button = CType(sender, Button) ' Get Clicked Button
        My.Computer.Keyboard.SendKeys(CType(btn.Tag, String)) ' Button tags represent the notes associated with the button
    End Sub
End Class
