<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.txtCodAplicacao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTestes = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVersaoApp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRazaoEmpresa = New System.Windows.Forms.TextBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtIDH = New System.Windows.Forms.TextBox()
        Me.lblDadosApp = New System.Windows.Forms.Label()
        Me.lblLinha1 = New System.Windows.Forms.Label()
        Me.lblIDH = New System.Windows.Forms.Label()
        Me.lblLinha4 = New System.Windows.Forms.Label()
        Me.lblPainel = New System.Windows.Forms.Label()
        Me.pictBoxPainel = New System.Windows.Forms.PictureBox()
        Me.btnTestes2 = New System.Windows.Forms.Button()
        Me.pictBoxLogoPainel = New System.Windows.Forms.PictureBox()
        Me.dtpDataExp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDif = New System.Windows.Forms.TextBox()
        CType(Me.pictBoxPainel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBoxLogoPainel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodAplicacao
        '
        Me.txtCodAplicacao.Location = New System.Drawing.Point(31, 160)
        Me.txtCodAplicacao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodAplicacao.Name = "txtCodAplicacao"
        Me.txtCodAplicacao.Size = New System.Drawing.Size(131, 22)
        Me.txtCodAplicacao.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código Aplicação:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data da Licença:"
        '
        'btnTestes
        '
        Me.btnTestes.Location = New System.Drawing.Point(783, 294)
        Me.btnTestes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTestes.Name = "btnTestes"
        Me.btnTestes.Size = New System.Drawing.Size(100, 31)
        Me.btnTestes.TabIndex = 5
        Me.btnTestes.Text = "Salvar"
        Me.btnTestes.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Versão:"
        '
        'txtVersaoApp
        '
        Me.txtVersaoApp.Location = New System.Drawing.Point(173, 160)
        Me.txtVersaoApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVersaoApp.Name = "txtVersaoApp"
        Me.txtVersaoApp.Size = New System.Drawing.Size(52, 22)
        Me.txtVersaoApp.TabIndex = 12
        Me.txtVersaoApp.Text = "1.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Empresa (Razão Social):"
        '
        'txtRazaoEmpresa
        '
        Me.txtRazaoEmpresa.Location = New System.Drawing.Point(377, 160)
        Me.txtRazaoEmpresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRazaoEmpresa.Name = "txtRazaoEmpresa"
        Me.txtRazaoEmpresa.Size = New System.Drawing.Size(217, 22)
        Me.txtRazaoEmpresa.TabIndex = 14
        '
        'mskCNPJ
        '
        Me.mskCNPJ.Location = New System.Drawing.Point(608, 160)
        Me.mskCNPJ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskCNPJ.Mask = "00,000,000/0000-00"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(161, 22)
        Me.mskCNPJ.TabIndex = 16
        Me.mskCNPJ.Text = "00000000000000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(604, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CNPJ:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(27, 238)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(104, 16)
        Me.lblID.TabIndex = 33
        Me.lblID.Text = "ID de Hardware:"
        '
        'txtIDH
        '
        Me.txtIDH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDH.Location = New System.Drawing.Point(28, 258)
        Me.txtIDH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDH.Multiline = True
        Me.txtIDH.Name = "txtIDH"
        Me.txtIDH.ReadOnly = True
        Me.txtIDH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDH.Size = New System.Drawing.Size(741, 66)
        Me.txtIDH.TabIndex = 32
        '
        'lblDadosApp
        '
        Me.lblDadosApp.AutoSize = True
        Me.lblDadosApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDadosApp.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblDadosApp.Location = New System.Drawing.Point(27, 103)
        Me.lblDadosApp.Name = "lblDadosApp"
        Me.lblDadosApp.Size = New System.Drawing.Size(122, 17)
        Me.lblDadosApp.TabIndex = 35
        Me.lblDadosApp.Text = "Dados da Licença"
        '
        'lblLinha1
        '
        Me.lblLinha1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLinha1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLinha1.Location = New System.Drawing.Point(156, 112)
        Me.lblLinha1.Name = "lblLinha1"
        Me.lblLinha1.Size = New System.Drawing.Size(721, 2)
        Me.lblLinha1.TabIndex = 34
        '
        'lblIDH
        '
        Me.lblIDH.AutoSize = True
        Me.lblIDH.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblIDH.Location = New System.Drawing.Point(27, 202)
        Me.lblIDH.Name = "lblIDH"
        Me.lblIDH.Size = New System.Drawing.Size(164, 16)
        Me.lblIDH.TabIndex = 39
        Me.lblIDH.Text = "Identificação do Hardware"
        '
        'lblLinha4
        '
        Me.lblLinha4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLinha4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLinha4.Location = New System.Drawing.Point(156, 210)
        Me.lblLinha4.Name = "lblLinha4"
        Me.lblLinha4.Size = New System.Drawing.Size(721, 2)
        Me.lblLinha4.TabIndex = 38
        '
        'lblPainel
        '
        Me.lblPainel.AutoSize = True
        Me.lblPainel.BackColor = System.Drawing.Color.Transparent
        Me.lblPainel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPainel.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPainel.Location = New System.Drawing.Point(116, 28)
        Me.lblPainel.Name = "lblPainel"
        Me.lblPainel.Size = New System.Drawing.Size(307, 25)
        Me.lblPainel.TabIndex = 42
        Me.lblPainel.Text = "Gerador de arquivo de licença."
        '
        'pictBoxPainel
        '
        Me.pictBoxPainel.Location = New System.Drawing.Point(-1, -1)
        Me.pictBoxPainel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictBoxPainel.Name = "pictBoxPainel"
        Me.pictBoxPainel.Size = New System.Drawing.Size(932, 84)
        Me.pictBoxPainel.TabIndex = 41
        Me.pictBoxPainel.TabStop = False
        '
        'btnTestes2
        '
        Me.btnTestes2.Location = New System.Drawing.Point(783, 257)
        Me.btnTestes2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTestes2.Name = "btnTestes2"
        Me.btnTestes2.Size = New System.Drawing.Size(100, 31)
        Me.btnTestes2.TabIndex = 43
        Me.btnTestes2.Text = "Ler"
        Me.btnTestes2.UseVisualStyleBackColor = True
        '
        'pictBoxLogoPainel
        '
        Me.pictBoxLogoPainel.Image = CType(resources.GetObject("pictBoxLogoPainel.Image"), System.Drawing.Image)
        Me.pictBoxLogoPainel.Location = New System.Drawing.Point(31, 14)
        Me.pictBoxLogoPainel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictBoxLogoPainel.Name = "pictBoxLogoPainel"
        Me.pictBoxLogoPainel.Size = New System.Drawing.Size(48, 48)
        Me.pictBoxLogoPainel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictBoxLogoPainel.TabIndex = 40
        Me.pictBoxLogoPainel.TabStop = False
        '
        'dtpDataExp
        '
        Me.dtpDataExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpDataExp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataExp.Location = New System.Drawing.Point(237, 160)
        Me.dtpDataExp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDataExp.Name = "dtpDataExp"
        Me.dtpDataExp.Size = New System.Drawing.Size(127, 23)
        Me.dtpDataExp.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(779, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Dias:"
        '
        'txtDif
        '
        Me.txtDif.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDif.Location = New System.Drawing.Point(783, 160)
        Me.txtDif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDif.Name = "txtDif"
        Me.txtDif.Size = New System.Drawing.Size(93, 22)
        Me.txtDif.TabIndex = 45
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 361)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDif)
        Me.Controls.Add(Me.btnTestes2)
        Me.Controls.Add(Me.lblPainel)
        Me.Controls.Add(Me.pictBoxLogoPainel)
        Me.Controls.Add(Me.pictBoxPainel)
        Me.Controls.Add(Me.lblIDH)
        Me.Controls.Add(Me.lblLinha4)
        Me.Controls.Add(Me.lblDadosApp)
        Me.Controls.Add(Me.lblLinha1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtIDH)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mskCNPJ)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRazaoEmpresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVersaoApp)
        Me.Controls.Add(Me.btnTestes)
        Me.Controls.Add(Me.dtpDataExp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodAplicacao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerado de Licenças"
        CType(Me.pictBoxPainel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBoxLogoPainel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodAplicacao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTestes As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVersaoApp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRazaoEmpresa As TextBox
    Friend WithEvents mskCNPJ As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtIDH As TextBox
    Friend WithEvents lblDadosApp As Label
    Friend WithEvents lblLinha1 As Label
    Friend WithEvents lblIDH As Label
    Friend WithEvents lblLinha4 As Label
    Friend WithEvents lblPainel As Label
    Friend WithEvents pictBoxPainel As PictureBox
    Friend WithEvents btnTestes2 As Button
    Friend WithEvents pictBoxLogoPainel As PictureBox
    Friend WithEvents dtpDataExp As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDif As TextBox
End Class
