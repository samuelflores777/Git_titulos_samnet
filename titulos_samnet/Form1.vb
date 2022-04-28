Imports System.IO
Imports System.Data.OleDb
Imports System.ComponentModel
Public Class Form1
    Public wc As New Net.WebClient
    Dim EntryCount
    Dim nombres, cargos, comentarios, ipconfig As String
    Dim valida As Boolean
    Dim valida2 As Boolean
    Dim validaip As Boolean
    Dim filaActual As Integer
    Dim filaActual2 As Integer
    Dim filaActualip As Integer
    Dim validad As Boolean
    Dim validad2 As Boolean
    Dim validadip As Boolean
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox12.Text = TextBox1.Text + "/api/?Function=OverlayInput" + TextBox9.Text + "&Input=" + TextBox10.Text
        Try
            wc.DownloadString(TextBox12.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("FALTA CONECTAR EL IP DEL MIX", MsgBoxStyle.Critical, "INFORMACION DEL SISTEMA")
        End Try
    End Sub
    Private Sub ASIGOVERLAYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGOVERLAYToolStripMenuItem.Click
        If ASIG = "BTN10" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button10.Text = NOMB
            TextBox11.Text = NOMB
        End If
        If ASIG = "BTN11" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button11.Text = NOMB
            TextBox14.Text = NOMB
        End If
        If ASIG = "BTN12" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button12.Text = NOMB
            TextBox18.Text = NOMB
        End If
        If ASIG = "BTN13" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button13.Text = NOMB
            TextBox22.Text = NOMB
        End If
        If ASIG = "BTN14" Then
            Dim NOMB As String
            NOMB = InputBox("COLOCAR NOMBRE", "NUEVO")
            Button14.Text = NOMB
            TextBox26.Text = NOMB
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            wc.DownloadString(TextBox1.Text + "/API/?Function=SetText&SelectedIndex=0&Input=" + TextBox7.Text + "&Value=" + TextBox8.Text)
            wc.DownloadString(TextBox1.Text + "/api/?Function=OverlayInput" + TextBox6.Text + "in&Input=" + TextBox7.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox8.Focus()
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://samnetvisual.com")
    End Sub
    Private Sub Overlay01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay01ToolStripMenuItem.Click
        If ASIG = "BTN10" Then
            TextBox9.Text = "1"
        End If

        If ASIG = "BTN11" Then
            TextBox16.Text = "1"
        End If

        If ASIG = "BTN12" Then
            TextBox20.Text = "1"
        End If

        If ASIG = "BTN13" Then
            TextBox24.Text = "1"
        End If

        If ASIG = "BTN14" Then
            TextBox28.Text = "1"
        End If
    End Sub

    Private Sub Overlay02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay02ToolStripMenuItem.Click
        If ASIG = "BTN10" Then
            TextBox9.Text = "2"
        End If

        If ASIG = "BTN11" Then
            TextBox16.Text = "2"
        End If

        If ASIG = "BTN12" Then
            TextBox20.Text = "2"
        End If

        If ASIG = "BTN13" Then
            TextBox24.Text = "2"
        End If

        If ASIG = "BTN14" Then
            TextBox28.Text = "2"
        End If
    End Sub

    Private Sub Overlay03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay03ToolStripMenuItem.Click
        If ASIG = "BTN10" Then
            TextBox9.Text = "3"
        End If

        If ASIG = "BTN11" Then
            TextBox16.Text = "3"
        End If

        If ASIG = "BTN12" Then
            TextBox20.Text = "3"
        End If

        If ASIG = "BTN13" Then
            TextBox24.Text = "3"
        End If

        If ASIG = "BTN14" Then
            TextBox28.Text = "3"
        End If
    End Sub

    Private Sub Overlay04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Overlay04ToolStripMenuItem.Click
        If ASIG = "BTN10" Then
            TextBox9.Text = "4"
        End If

        If ASIG = "BTN11" Then
            TextBox16.Text = "4"
        End If

        If ASIG = "BTN12" Then
            TextBox20.Text = "4"
        End If

        If ASIG = "BTN13" Then
            TextBox24.Text = "4"
        End If

        If ASIG = "BTN14" Then
            TextBox28.Text = "4"
        End If
    End Sub

    Private Sub ASIGPISTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGPISTAToolStripMenuItem.Click
        If ASIG = "BTN10" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox10.Text = BTN
        End If
        If ASIG = "BTN11" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox15.Text = BTN
        End If
        If ASIG = "BTN12" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox19.Text = BTN
        End If
        If ASIG = "BTN13" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox23.Text = BTN
        End If
        If ASIG = "BTN14" Then
            Dim BTN As String
            BTN = InputBox("ESCRIBA NUMERO DE PISTA", "PISTA")
            TextBox27.Text = BTN
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox13.Text = TextBox1.Text + "/api/?Function=OverlayInput" + TextBox16.Text + "&Input=" + TextBox15.Text
        Try
            wc.DownloadString(TextBox13.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("FALTA CONECTAR EL IP DEL MIX", MsgBoxStyle.Critical, "INFORMACION DEL SISTEMA")
        End Try


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox17.Text = TextBox1.Text + "/api/?Function=OverlayInput" + TextBox20.Text + "&Input=" + TextBox19.Text
        Try
            wc.DownloadString(TextBox17.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("FALTA CONECTAR EL IP DEL MIX", MsgBoxStyle.Critical, "INFORMACION DEL SISTEMA")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox21.Text = TextBox1.Text + "/api/?Function=OverlayInput" + TextBox24.Text + "&Input=" + TextBox23.Text
        Try
            wc.DownloadString(TextBox21.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("FALTA CONECTAR EL IP DEL MIX", MsgBoxStyle.Critical, "INFORMACION DEL SISTEMA")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox25.Text = TextBox1.Text + "/api/?Function=OverlayInput" + TextBox28.Text + "&Input=" + TextBox27.Text
        Try
            wc.DownloadString(TextBox25.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("FALTA CONECTAR EL IP DEL MIX", MsgBoxStyle.Critical, "INFORMACION DEL SISTEMA")
        End Try
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Button10.Text = TextBox11.Text
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Button11.Text = TextBox14.Text
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        Button12.Text = TextBox18.Text
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged
        Button13.Text = TextBox22.Text
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged
        Button14.Text = TextBox26.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nombres = TextBox4.Text
        cargos = TextBox5.Text
        valida = validardatos(nombres, cargos)

        If valida = True Then
            DataGridView1.Rows.Add(nombres, cargos)
            MsgBox("NOMBRES AÑADIDO A LISTA", MsgBoxStyle.Information, "INFORMACIÓN SOSTEMA")
            limpiar()
            TextBox4.Focus()
        End If
    End Sub
    Function validardatos(parnombres As String, parcargos As String) As Boolean
        If parnombres = "" Then
            MsgBox("INGRESO DE NOMBRES FALTANTTES", MsgBoxStyle.Critical, "INFORMACIÓN SOSTEMA")
            ErrorProvider1.SetError(TextBox4, "INGRESE NOMBRES")
            valida = False
        ElseIf parcargos = "" Then
            MsgBox("INGRESO DE CARGOS FALTANTTES", MsgBoxStyle.Critical, "INFORMACIÓN SOSTEMA")
            ErrorProvider1.SetError(TextBox5, "INGRESE CARGOS")
            valida = False
        Else
            valida = True
            ErrorProvider1.SetError(TextBox4, "")
            ErrorProvider1.SetError(TextBox5, "")
        End If
        Return valida
    End Function
    Function validardatosip(paripconfig As String) As Boolean
        If paripconfig = "" Then
            MsgBox("IP VMIX ESTA VACIO", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            ErrorProvider1.SetError(TextBox1, "INGRESE IP VMIX")
            TextBox1.Focus()
            valida = False
        Else
            valida = True
            ErrorProvider1.SetError(TextBox1, "")
            guardardatosip()
        End If
        Return valida
    End Function
    Private Sub guardardatosip()
        Dim archivo_escritura As StreamWriter
        Dim linea As String
        archivo_escritura = New StreamWriter("./samnetip.txt")
        With DataGridView3
            For y = 0 To .RowCount - 1
                linea = .Rows(y).Cells("ColumnIP").Value & ";"
                archivo_escritura.WriteLine(linea)
            Next

        End With
        archivo_escritura.Close()
    End Sub
    Function validardatos2(parcomentarios As String) As Boolean
        If parcomentarios = "" Then
            MsgBox("NO HAY COMENTARIOS", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            ErrorProvider1.SetError(TextBox8, "INGRESE COMENTARIO")
            valida2 = False
        Else
            valida = True
            ErrorProvider1.SetError(TextBox8, "")
        End If
        Return valida
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activarbotones()
        activarbotones2()
        Try

            Dim archivo_leer As StreamReader
            archivo_leer = New StreamReader("./samnet.txt")
            While Not archivo_leer.EndOfStream
                Dim cadena As String = archivo_leer.ReadLine
                Dim leer As String() = cadena.Split(New Char() {";"})
                DataGridView1.Rows.Add(leer)
            End While
            archivo_leer.Close()

            Dim archivo_leer2 As StreamReader
            archivo_leer2 = New StreamReader("./samnet2.txt")
            While Not archivo_leer2.EndOfStream
                Dim cadena2 As String = archivo_leer2.ReadLine
                Dim leer2 As String() = cadena2.Split(New Char() {";"})
                DataGridView2.Rows.Add(leer2)
            End While
            archivo_leer2.Close()

            Dim archivo_leerip As StreamReader
            archivo_leerip = New StreamReader("./samnetip.txt")
            While Not archivo_leerip.EndOfStream
                Dim cadenaip As String = archivo_leerip.ReadLine
                Dim leerip As String() = cadenaip.Split(New Char() {";"})
                DataGridView3.Rows.Add(leerip)
                filaActualip = DataGridView3.CurrentRow.Index
                TextBox1.Text = DataGridView3.Rows(filaActualip).Cells("ColumnIP").Value
            End While
            archivo_leerip.Close()

        Catch ex As Exception
        End Try
        If TextBox1.Text = "" Then
            Button20.Text = "GUARDAR_IP"
        Else
            Button20.Text = "CAMBIAR_IP"
        End If
    End Sub
    Private Sub Button10_MouseDown(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ASIG = "BTN10"
        End If
    End Sub

    Private Sub Button11_MouseDown(sender As Object, e As MouseEventArgs) Handles Button11.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ASIG = "BTN11"
        End If
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ASIG = "BTN12"
        End If
    End Sub

    Private Sub Button13_MouseDown(sender As Object, e As MouseEventArgs) Handles Button13.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ASIG = "BTN13"
        End If
    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ASIG = "BTN14"
        End If
    End Sub
    Private Sub limpiar()
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub limpiar2()
        TextBox8.Text = ""
    End Sub
    Private Sub activarbotones()
        Button2.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = True
    End Sub

    Private Sub activarbotones2()
        Button4.Enabled = True
        Button6.Enabled = False
        Button5.Enabled = False
        Button16.Enabled = True
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        nombres = TextBox4.Text
        cargos = TextBox5.Text
        valida = validardatos(nombres, cargos)
        filaActual = DataGridView1.CurrentRow.Index
        If valida = True Then
            DataGridView1.Rows(filaActual).Cells("ColumnNOM").Value = nombres
            DataGridView1.Rows(filaActual).Cells("ColumnCARG").Value = cargos
            MsgBox("REGISTRO ACTUALIZADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
            activarbotones()
            limpiar()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim pregnta As String
        pregnta = MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo, "INFORMACION SAMNET")
        If pregnta = vbYes Then
            filaActual = DataGridView1.CurrentRow.Index
            DataGridView1.Rows.Remove(DataGridView1.Rows(filaActual))
            MsgBox("REGISTRO ELIMINADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
            activarbotones()
            limpiar()
        End If
    End Sub
    Private Sub desactivarbotones()
        Button2.Enabled = False
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = False
    End Sub
    Private Sub desactivarbotones2()
        Button4.Enabled = False
        Button6.Enabled = True
        Button5.Enabled = True
        Button16.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        guardardatos()
    End Sub
    Private Sub guardardatos()
        Dim archivo_escritura As StreamWriter
        Dim linea As String
        archivo_escritura = New StreamWriter("./samnet.txt")
        With DataGridView1
            For y = 0 To .RowCount - 1
                linea = .Rows(y).Cells("ColumnNOM").Value & ";" &
                .Rows(y).Cells("ColumnCARG").Value & ";"
                archivo_escritura.WriteLine(linea)
            Next
            'MsgBox("REGISTRO GUARDADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
        End With
        archivo_escritura.Close()
    End Sub
    Private Sub guardardatos2()
        Dim archivo_escritura As StreamWriter
        Dim linea As String
        archivo_escritura = New StreamWriter("./samnet2.txt")
        With DataGridView2
            For y = 0 To .RowCount - 1
                linea = .Rows(y).Cells("ColumnCOMEN").Value & ";"
                archivo_escritura.WriteLine(linea)
            Next
            'MsgBox("REGISTRO GUARDADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
        End With
        archivo_escritura.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        comentarios = TextBox8.Text
        valida2 = validardatos2(comentarios)

        If valida2 = True Then
            DataGridView2.Rows.Add(comentarios)
            'MsgBox("REGISTRADO CON EXITO", MsgBoxStyle.Information, "INFORMACIÓN SOSTEMA")
            limpiar2()
            TextBox8.Focus()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        comentarios = TextBox8.Text
        valida2 = validardatos2(comentarios)
        filaActual2 = DataGridView2.CurrentRow.Index
        If valida2 = True Then
            DataGridView2.Rows(filaActual2).Cells("ColumnCOMEN").Value = comentarios
            MsgBox("REGISTRO ACTUALIZADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
            activarbotones()
            limpiar2()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pregnta As String
        pregnta = MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo, "INFORMACION SAMNET")
        If pregnta = vbYes Then
            filaActual2 = DataGridView2.CurrentRow.Index
            DataGridView2.Rows.Remove(DataGridView2.Rows(filaActual2))
            MsgBox("REGISTRO ELIMINADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
            activarbotones2()
            limpiar2()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        guardardatos2()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        filaActual = DataGridView1.CurrentRow.Index
        TextBox4.Text = DataGridView1.Rows(filaActual).Cells("ColumnNOM").Value
        TextBox5.Text = DataGridView1.Rows(filaActual).Cells("ColumnCARG").Value
        desactivarbotones()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            wc.DownloadString(TextBox1.Text + "/api/?Function=OverlayInput" + TextBox6.Text + "out&Input=" + TextBox7.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox8.Focus()
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        activarbotones()
        TextBox4.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox8.Text = ""
        activarbotones2()
        TextBox8.Focus()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim guardar As String
        guardar = Button20.Text
        Select Case guardar
            Case "GUARDAR_IP"
                ipconfig = TextBox1.Text
                validaip = validardatosip(ipconfig)
                If validaip = True Then
                    DataGridView3.Rows.Add(ipconfig)
                    TextBox4.Focus()
                    guardardatosip()
                    TextBox1.Enabled = False
                    Button20.Text = "CAMBIAR_IP"
                End If
            Case "CAMBIAR_IP"
                TextBox1.Enabled = True
                TextBox1.Text = ""
                TextBox1.Focus()
                Button20.Text = "GUARDAR_CAMBIO"

            Case "GUARDAR_CAMBIO"
                ipconfig = TextBox1.Text
                validaip = validardatosip(ipconfig)
                filaActualip = DataGridView3.CurrentRow.Index
                If validaip = True Then
                    DataGridView3.Rows(filaActualip).Cells("ColumnIP").Value = ipconfig
                    MsgBox("IP VMIX ACTUALIZADO", MsgBoxStyle.Information, "INFORMACIÓN SAMNET")
                    TextBox1.Enabled = False
                    Button20.Text = "CAMBIAR_IP"
                End If
        End Select
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        filaActual2 = DataGridView2.CurrentRow.Index
        TextBox8.Text = DataGridView2.Rows(filaActual2).Cells("ColumnCOMEN").Value
        desactivarbotones2()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Overlay 01" Then
            TextBox2.Text = 1
        End If
        If ComboBox1.Text = "Overlay 02" Then
            TextBox2.Text = 2
        End If
        If ComboBox1.Text = "Overlay 03" Then
            TextBox2.Text = 3
        End If
        If ComboBox1.Text = "Overlay 04" Then
            TextBox2.Text = 4
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Overlay 01" Then
            TextBox6.Text = 1
        End If
        If ComboBox2.Text = "Overlay 02" Then
            TextBox6.Text = 2
        End If
        If ComboBox2.Text = "Overlay 03" Then
            TextBox6.Text = 3
        End If
        If ComboBox2.Text = "Overlay 04" Then
            TextBox6.Text = 4
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim pregnta As String
        pregnta = MsgBox("DESEA GUARDAR LOS DATOS?", MsgBoxStyle.YesNo, "INFORMACION SAMNET")
        If pregnta = vbYes Then
            guardardatos2()
            guardardatos()
            guardardatosip()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            wc.DownloadString(TextBox1.Text + "/api/?Function=OverlayInput" + TextBox2.Text + "out&Input=" + TextBox3.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox1.Focus()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            wc.DownloadString(TextBox1.Text + "/API/?Function=SetText&SelectedIndex=0&Input=" + TextBox3.Text + "&Value=" + TextBox4.Text)
            wc.DownloadString(TextBox1.Text + "/API/?Function=SetText&SelectedIndex=1&Input=" + TextBox3.Text + "&Value=" + TextBox5.Text)
            wc.DownloadString(TextBox1.Text + "/api/?Function=OverlayInput" + TextBox2.Text + "in&Input=" + TextBox3.Text)
        Catch ex As Exception
            'MsgBox(Err.Description)
            MsgBox("SIN CONEXION AL VMIX", MsgBoxStyle.Critical, "INFORMACIÓN SAMNET")
            TextBox1.Focus()
        End Try
    End Sub
End Class
