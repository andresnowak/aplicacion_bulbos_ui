Public Class Form1

    Dim operacion As String
    Dim vueltas As Nullable(Of Double) = Nothing
    Dim vueltas2 As Nullable(Of Double) = Nothing
    Dim voltaje As Nullable(Of Double) = Nothing
    Dim diametroDeAlambreDePrimario As Nullable(Of Double) = Nothing
    Dim diametroDeAlambreDeSecundario As Nullable(Of Double) = Nothing
    Dim relacionDeTransformacion As Nullable(Of Double) = Nothing
    Dim valor1 As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim sePresionaOperador As Boolean


    Private Sub ButtonOP_Click(sender As Object, e As EventArgs) Handles ButtonOP.Click
        Operacion1()
    End Sub

    Private Sub ButtonOP2_Click(sender As Object, e As EventArgs) Handles ButtonOP2.Click
        Operacion2()
    End Sub

    Private Sub ButtonOP3_Click(sender As Object, e As EventArgs) Handles ButtonOP3.Click
        Operacion3()
    End Sub

    Private Sub ButtonDp_Click(sender As Object, e As EventArgs) Handles ButtonDp.Click
        Operacion4()
    End Sub

    Private Sub ButtonDs_Click(sender As Object, e As EventArgs) Handles ButtonDs.Click
        Operacion5()
    End Sub

    Public Sub Operacion1()
        sePresionaOperador = True



        valor1 = Val(TextP.Text)
        valor2 = Val(TextTp.Text)
        voltaje = (valor1 * valor2) ^ (1 / 2)
        TextV.Text = voltaje
        TextV2.Text = voltaje
        TextTp2.Text = valor2
        TextTp3.Text = valor2

        sePresionaOperador = False

    End Sub

    Public Sub Operacion2()

        sePresionaOperador = True
        valor1 = Val(TextHz.Text)
        valor2 = Val(TextCm2.Text)
        voltaje = Val(TextV.Text)
        vueltas = (voltaje * 10000) / (valor1 * 2.664 * valor2)
        TextVueltas.Text = vueltas

        sePresionaOperador = False

    End Sub

    Public Sub Operacion3()
        sePresionaOperador = True
        valor1 = Val(TextTp2.Text)
        valor2 = Val(TextIBo.Text)
        vueltas2 = 275 * ((valor2 / valor1) ^ (1 / 2))

        TextVueltas2.Text = vueltas2
        TextTp3.Text = valor1
        TextIBo2.Text = valor2

        sePresionaOperador = False

    End Sub

    Public Sub Operacion4()
        sePresionaOperador = True
        valor1 = Val(textCorrienteDeBu.Text)
        valor2 = Val(TextX.Text)
        diametroDeAlambreDePrimario = ((4 * valor1) / (3.14 * valor2)) ^ (1 / 2)

        TextDiametroDeAlambrePrimario.Text = diametroDeAlambreDePrimario
        TextDiametroDeAlambrePrimario2.Text = diametroDeAlambreDePrimario

        sePresionaOperador = False

    End Sub

    Public Sub Operacion5()
        sePresionaOperador = True
        valor1 = Val(TextDiametroDeAlambrePrimario2.Text)
        valor2 = Val(TextN.Text)
        diametroDeAlambreDeSecundario = valor1 * (valor2 * (1 / 2))
        TextDiametroDeAlambreSecundario.Text = diametroDeAlambreDeSecundario

        sePresionaOperador = False
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        OperacionN()

    End Sub

    Public Sub OperacionN()
        sePresionaOperador = True
        valor1 = Val(TextTp3.Text)
        valor2 = Val(TextIBo2.Text)
        relacionDeTransformacion = (valor1 / valor2) ^ (1 / 2)
        TextN.Text = relacionDeTransformacion

        sePresionaOperador = False
    End Sub


    Private Sub ButtonBo1_Click(sender As Object, e As EventArgs) Handles ButtonBo1.Click
        Borrar1()
    End Sub

    Private Sub ButtonBo2_Click(sender As Object, e As EventArgs) Handles ButtonBo2.Click
        Borrar2()
    End Sub

    Private Sub ButtonBo3_Click(sender As Object, e As EventArgs) Handles ButtonBo3.Click
        Borrar3()
    End Sub

    Private Sub ButtonBo4_Click(sender As Object, e As EventArgs) Handles ButtonBo4.Click
        Borrar4()
    End Sub

    Private Sub ButtonBo5_Click(sender As Object, e As EventArgs) Handles ButtonBo5.Click
        Borrar5()
    End Sub

    Public Sub Borrar1()
        sePresionaOperador = True
        TextP.Text = ""
        TextTp.Text = ""
        sePresionaOperador = False
    End Sub

    Public Sub Borrar2()
        sePresionaOperador = True
        TextV2.Text = ""
        TextHz.Text = ""
        TextCm2.Text = ""
        sePresionaOperador = False
    End Sub

    Public Sub Borrar3()
        sePresionaOperador = True
        TextTp2.Text = ""
        TextIBo.Text = ""

        sePresionaOperador = False
    End Sub

    Public Sub Borrar4()
        sePresionaOperador = True
        TextX.Text = ""
        textCorrienteDeBu.Text = ""

        sePresionaOperador = False
    End Sub

    Public Sub Borrar5()
        sePresionaOperador = True
        TextTp3.Text = ""
        TextIBo2.Text = ""
        TextN.Text = ""
        TextDiametroDeAlambrePrimario2.Text = ""

        sePresionaOperador = False
    End Sub


End Class
