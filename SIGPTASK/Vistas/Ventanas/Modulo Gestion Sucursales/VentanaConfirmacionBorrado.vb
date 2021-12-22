Imports System.Net.Mail
Imports System.Net

Public Class VentanaConfirmacionBorrado

    Dim eliminadoExitoso As String = ""

    Private Sub btnBorrarSoloSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarSoloSucursal.Click
        manddoCorreo()
    End Sub

    Private Sub tbConfimacionDeBorrado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConfimacionDeBorrado.TextChanged
        If (tbConfimacionDeBorrado.Text.Equals("SI BORRAR") Or tbConfimacionDeBorrado.Text.Equals("YES DELETE")) Then
            btnBorrarSoloSucursal.Enabled = True
            btnBorrarTodasLasSucursales.Enabled = True
        End If
    End Sub

    Private Sub VentanaConfirmacionBorrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tbMensajeAlerta.SelectionStart = 0
        tbMensajeAlerta.Select(0, 0)
        idioma()
    End Sub

    Private Sub manddoCorreo()

        'hay que activar que google acepte ser utilizado poraplicaciones menos seguras
        'https://myaccount.google.com/lesssecureapps?pli=1

        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("Tercerobf111@gmail.com")
        mail.[To].Add("Tercerobf111@gmail.com")

        Dim hora As String = Now.ToString("HH:mm:ss")

        'set the content
        If idiomaSeleccionado.Equals("ING") Then
            mail.Subject = lblUSUARIO_CONECTADO.Text & " DELETE DATA"
            mail.Body = "Connected user are " & lblUSUARIO_CONECTADO.Text & " and deletes Company RUT: " & lblRUT_BORRAR.Text & " Subsidiary ID: " & _
                lblID_SUCURSAL_BORRAR.Text & " at: " & hora & " this email was generated automatically by log and control sistem of Task"
        Else
            mail.Subject = lblUSUARIO_CONECTADO.Text & " BORRO DATOS"
            mail.Body = "El usuario conectado es " & lblUSUARIO_CONECTADO.Text & " y borro Empresa RUT: " & lblRUT_BORRAR.Text & " Empresa Sucursal ID: " & _
                lblID_SUCURSAL_BORRAR.Text & " a la hora: " & hora & " este correo fue generado automaticamente por el sistema de registro y control de Task"
        End If
       
        'set the server
        Dim smtp As New SmtpClient()

        smtp.UseDefaultCredentials = False
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587
        smtp.Credentials = New NetworkCredential("Tercerobf111@gmail.com", "1234567BF3")
        smtp.EnableSsl = True

        'send the message
        Try
            smtp.Send(mail)
            MessageBox.Show(eliminadoExitoso)
            Me.Dispose()

            '  Response.Write("Your Email has been sent sucessfully - Thank You")
        Catch exc As Exception
            MessageBox.Show(exc.ToString)
            ' Response.Write("Send failure: " & exc.ToString())
        End Try

    End Sub

    '//MINIMIZAR
    Protected Sub pictureMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    '//SOMBRA
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property
    '//MUEVO LA WINDOW
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '//MUEVO LA WINDOW FIN




    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub

    Private Sub idioma()
        If idiomaSeleccionado.Equals("ING") Then
            btnBorrarSoloSucursal.Text = "Delete only Subsidiary"
            btnBorrarTodasLasSucursales.Text = "Delete Company"

            tbMensajeAlerta.Text = "delete action it's a big deal if you are sure with delete something, write ""YES DELETE"" " &
            "inside of text area and press witch you want to delete""" &
             " also this action has be register for legal pruporses use under your risk; YOU'RE awared"
        Else
            tbMensajeAlerta.Text = "Borrar es una accion arriesgada, por favor verifique que realemente" &
                "tenga intenciones de borrar algo, esta accion sera monitoreada con fines legales, usela bajo su propio riesgo; ESTA AVISADO " &
            "Si realemnte desea borrar escriba en el cuadro de texto, ""SI BORRAR"" y confirme"

        End If
        eliminadoExitoso = lenguaje.eliminadoExitoso(eliminadoExitoso)

    End Sub

End Class