Public Class Form1
    Dim total, bayar, kembali As Double
    Dim bycuci, tottambah, totmakan As Double
    Dim makan As CheckBox()
    Dim tambah As CheckBox()
    Dim txttambah As TextBox()
    Dim txtmakan As TextBox()
    Dim txtjumlah As TextBox()
    Dim hargamakan() As Double = {12000, 10000, 8000, 4000, 3000}
    Dim hargatambah() As Double = {10000, 15000, 25000}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        makan = New CheckBox() {makan1, makan2, makan3, makan4, makan5}
        txtmakan = New TextBox() {txtmakan1, txtmakan2, txtmakan3, txtmakan4, txtmakan5}
        txtjumlah = New TextBox() {txtjumlah1, txtjumlah2, txtjumlah3, txtjumlah4, txtjumlah5}
        tambah = New CheckBox() {tambah1, tambah2, tambah3}
        txttambah = New TextBox() {txttambah1, txttambah2, txttambah3}

        For i = 0 To 4
            txtmakan(i).Text = "Rp. " & Format(hargamakan(i), "#,#.##")
        Next

        For i = 0 To 2
            txttambah(i).Text = "Rp, " & Format(hargatambah(i), "#,#.##")
        Next
        bycuci = 0

    End Sub

    Private Sub jenis1_CheckedChanged(sender As Object, e As EventArgs) Handles jenis1.CheckedChanged
        bycuci = 15000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis2_CheckedChanged(sender As Object, e As EventArgs) Handles jenis2.CheckedChanged
        bycuci = 25000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis3_CheckedChanged(sender As Object, e As EventArgs) Handles jenis3.CheckedChanged
        bycuci = 30000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub jenis4_CheckedChanged(sender As Object, e As EventArgs) Handles jenis4.CheckedChanged
        bycuci = 50000
        TxtByCuci.Text = "Rp. " & Format(bycuci, "#,#.##")
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim i As Integer
        totmakan = 0
        tottambah = 0
        For i = 0 To 2
            If tambah(i).Checked Then
                tottambah = tottambah + hargatambah(i)
            End If
        Next
        For i = 0 To 4
            If makan(i).Checked Then
                totmakan = totmakan + (hargamakan(i) * Val(txtjumlah(i).Text))
            End If
        Next
        total = bycuci + tottambah + totmakan
        txttotal.Text = "Rp. " & Format(total, "#,#.##")
    End Sub

    Private Sub txtbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            kembali = Val(txtbayar.Text) - total
            txtkembali.Text = "Rp. " & Format(kembali, "#,#.##")
        End If
    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Dim i As Integer
        For i = 0 To 4
            makan(i).Checked = False
        Next
        For i = 0 To 4
            txtjumlah(i).Text = 0
        Next
        For i = 0 To 2
            tambah(i).Checked = False
        Next
        txttotal.Clear()
        txtbayar.Clear()
        txtkembali.Clear()
    End Sub
End Class

