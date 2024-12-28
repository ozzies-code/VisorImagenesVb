Public Class FrmVisor
    Private Sub btnSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles btnSeleccionarImagen.Click

        'Mostrar el cuadro de diálogo para seleccionar una imagen

        If ofdSeleccionarImagen.ShowDialog = DialogResult.OK Then
            'Mostrar la imagen seleccionada en el PictureBox
            PicMostrarImagen.Image = Image.FromFile(ofdSeleccionarImagen.FileName)
            'Mostrar el nombre del archivo como titulo del formulario
            Me.Text = "Visor de Imagenes(" & ofdSeleccionarImagen.FileName & ")"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Cerrar la ventana y salir de la aplicacion
        Me.Close()
    End Sub
End Class
