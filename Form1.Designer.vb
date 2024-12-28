<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisor))
        Me.btnSeleccionarImagen = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PicMostrarImagen = New System.Windows.Forms.PictureBox()
        Me.ofdSeleccionarImagen = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicMostrarImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionarImagen
        '
        Me.btnSeleccionarImagen.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSeleccionarImagen.BackgroundImage = CType(resources.GetObject("btnSeleccionarImagen.BackgroundImage"), System.Drawing.Image)
        Me.btnSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSeleccionarImagen.Location = New System.Drawing.Point(346, 12)
        Me.btnSeleccionarImagen.Name = "btnSeleccionarImagen"
        Me.btnSeleccionarImagen.Size = New System.Drawing.Size(63, 57)
        Me.btnSeleccionarImagen.TabIndex = 0
        Me.btnSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(346, 75)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(63, 57)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PicMostrarImagen
        '
        Me.PicMostrarImagen.Image = CType(resources.GetObject("PicMostrarImagen.Image"), System.Drawing.Image)
        Me.PicMostrarImagen.Location = New System.Drawing.Point(12, 12)
        Me.PicMostrarImagen.Name = "PicMostrarImagen"
        Me.PicMostrarImagen.Size = New System.Drawing.Size(328, 330)
        Me.PicMostrarImagen.TabIndex = 2
        Me.PicMostrarImagen.TabStop = False
        '
        'ofdSeleccionarImagen
        '
        Me.ofdSeleccionarImagen.FileName = "OpenFileDialog1"
        Me.ofdSeleccionarImagen.Filter = "Archivos de mapa de bits|*.BMP|JPEG|*.JPG"
        Me.ofdSeleccionarImagen.Title = "Seleccionar Imagen"
        '
        'FrmVisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(416, 353)
        Me.Controls.Add(Me.PicMostrarImagen)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSeleccionarImagen)
        Me.Font = New System.Drawing.Font("Bodoni MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmVisor"
        Me.Text = "Visor de Imagenes"
        CType(Me.PicMostrarImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeleccionarImagen As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PicMostrarImagen As PictureBox
    Friend WithEvents ofdSeleccionarImagen As OpenFileDialog
End Class
