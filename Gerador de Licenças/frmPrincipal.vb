Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Management

Public Class frmPrincipal
    Private TripleDES As New TripleDESCryptoServiceProvider
    Private MD5 As New MD5CryptoServiceProvider
    Private key As String = "Casiof-91wsw123456"
    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Private Function nomeArquivoINI() As String

        Dim nome_arquivo_ini As String = Application.StartupPath
        'nome_arquivo_ini = nome_arquivo_ini.Substring(0, nome_arquivo_ini.LastIndexOf("\"))
        Return nome_arquivo_ini & "\lic.dat"

    End Function

    Private Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String

        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return Decrypt(string_builder.ToString())

    End Function

    Private Sub gravaArquivoini()


        Dim nome_arquivo_ini As String = nomeArquivoINI()

        WritePrivateProfileString("flic", "CodApp", Encrypt(txtCodAplicacao.Text), nome_arquivo_ini)
        WritePrivateProfileString("flic", "VerApp", Encrypt(txtVersaoApp.Text), nome_arquivo_ini)
        WritePrivateProfileString("flic", "DLic", Encrypt(dtpDataExp.Text), nome_arquivo_ini)
        WritePrivateProfileString("flic", "Ra", Encrypt(txtRazaoEmpresa.Text), nome_arquivo_ini)
        WritePrivateProfileString("flic", "IDCN", Encrypt(mskCNPJ.Text), nome_arquivo_ini)
        WritePrivateProfileString("flic", "IDHf", Encrypt(txtIDH.Text), nome_arquivo_ini)

    End Sub

    Private Sub LerArquivoini()


        Dim nome_arquivo_ini As String = nomeArquivoINI()

        If Not File.Exists(nome_arquivo_ini) Then MsgBox("Será carregado os valores padrão do sistema.")
        txtCodAplicacao.Text = LeArquivoINI(nome_arquivo_ini, "flic", "CodApp", "Nenhum")
        txtVersaoApp.Text = LeArquivoINI(nome_arquivo_ini, "flic", "VerApp", "0.0")
        dtpDataExp.Text = LeArquivoINI(nome_arquivo_ini, "flic", "DLic", "13/01/1989")
        txtRazaoEmpresa.Text = LeArquivoINI(nome_arquivo_ini, "flic", "Ra", "Nenhum")
        mskCNPJ.Text = LeArquivoINI(nome_arquivo_ini, "flic", "IDCN", "00000000000000")
        txtIDH.Text = LeArquivoINI(nome_arquivo_ini, "flic", "IDHf", "Nenhum")

    End Sub

    Public Function MD5Hash(ByVal value As String) As Byte()
        ' Converte a chave para um array de bytes 
        Dim byteArray() As Byte = ASCIIEncoding.ASCII.GetBytes(value)
        Return MD5.ComputeHash(byteArray)
    End Function


    Public Function Encrypt(ByVal stringToEncrypt As String) As String

        Try

            TripleDES.Key = MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB

            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String(TripleDES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try

    End Function


    Public Function Decrypt(ByVal encryptedString As String) As String
        Try
            TripleDES.Key = MD5Hash(key)
            TripleDES.Mode = CipherMode.ECB

            ' Converte a string encriptada para bytes e decripta
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(TripleDES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try

    End Function


    Private Sub btnTestes_Click(sender As Object, e As EventArgs) Handles btnTestes.Click
        '  MessageBox.Show(dtpDataExp.Text)

        ' MessageBox.Show(mskCNPJ.Text)
        gravaArquivoini()

        'LerArquivoini()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim img As New Bitmap(pictBoxPainel.Width, pictBoxPainel.Height)
        Dim brush As New Drawing.Drawing2D.LinearGradientBrush(New PointF(0, 0), New PointF(img.Width, img.Height), SystemColors.Control, SystemColors.ControlLight)
        Dim gr As Graphics = Graphics.FromImage(img)
        gr.FillRectangle(brush, New RectangleF(0, 0, img.Width, img.Height))
        pictBoxPainel.BackgroundImage = img
        lblPainel.Parent = pictBoxPainel
        lblPainel.BackColor = Color.Transparent
        lblPainel.BringToFront()

        pictBoxLogoPainel.Parent = pictBoxPainel
        pictBoxLogoPainel.BackColor = Color.Transparent
        pictBoxLogoPainel.BringToFront()

        Dim IDH As New clsComputerInfo
        txtIDH.Text = IDH.Get_HWID()

        dtpDataExp.Text = "1" + "3" + "/" + "0" + "1" + "/" + "1" + "9" + "8" + "9"
    End Sub

    Private Sub btnTestes2_Click(sender As Object, e As EventArgs) Handles btnTestes2.Click

        LerArquivoini()
        CalcularDias()

    End Sub


    Sub CalcularDias()
        Dim strDataServidor As DateTime = Now
        Dim strDataf As String = dtpDataExp.Text

        'Dim dtDataServidor As DateTime = Convert.ToDateTime(strDataServidor)

        Dim dtDataf As DateTime = Convert.ToDateTime(strDataf)

        Dim strDiferenca As String = String.Empty

        strDiferenca = DateDiff(DateInterval.Day, strDataServidor, dtDataf).ToString

        If strDiferenca <= 0 Then
            txtDif.ForeColor = Color.Red
        Else
            txtDif.ForeColor = Color.SteelBlue
        End If

        txtDif.Text = strDiferenca
    End Sub



End Class





Public Class clsComputerInfo
    Friend Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId
    End Function
    Friend Function GetMACAddress() As String
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc
            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()
                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)
        Next
        Return MACAddress
    End Function
    Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String
        Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
        disk.Get()
        Return disk("VolumeSerialNumber").ToString()
    End Function
    Friend Function GetMotherBoardID() As String
        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherBoardID = info("SerialNumber").ToString()
        Next
        Return strMotherBoardID
    End Function


    Public Function Get_HWID() As String
        'Information Handler
        Dim hw As New clsComputerInfo
        'Decalre variables
        Dim hdd, cpu, mb, mac As String
        'Get all the values
        'cpu = hw.GetProcessorId()
        cpu = "1"
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()
        'Generate the hash
        Dim hwid As String = GenerateSHA512String(cpu & hdd & mb & mac)
        Return hwid
    End Function
    Public Function GenerateSHA512String(ByVal inputString) As String
        Dim sha512 As SHA512 = SHA512Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next
        Return stringBuilder.ToString()
    End Function
End Class

