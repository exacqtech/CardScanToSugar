Public Class ProgressDialog

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ProgressCanceled = True
    End Sub
End Class