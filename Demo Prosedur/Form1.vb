Public Class Form1
    Sub TampilPesan()
        'Ini adalah sebuah prosedur yang menampilkan sebuah pesan.
        listKeluaran.Items.Add("")
        listKeluaran.Items.Add("Hallo dari prosedur TampilPesan.")
        listKeluaran.Items.Add("")
    End Sub

    Private Sub tombolJalankan_Click(sender As Object, e As EventArgs) Handles tombolJalankan.Click
        'Menampilkan teks tertentu di dalam kotak list.
        listKeluaran.Items.Add("Hallo dari prosedur tombolJalankan_Click.")
        listKeluaran.Items.Add("Sekarang, Saya memanggil prosedur TampilPesan.")

        'Memanggil prosedur TampilPesan
        TampilPesan()

        'Menampilkan teks tertentu pada kotak list
        listKeluaran.Items.Add("Sekarang, Saya kembali ke prosedur tombolJalankan_Click.")
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        Application.Exit()
    End Sub
End Class