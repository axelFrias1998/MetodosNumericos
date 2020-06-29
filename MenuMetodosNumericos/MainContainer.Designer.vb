<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainContainer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.panelFormularios = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.NewtonRaphsonButton = New System.Windows.Forms.Button()
        Me.ReglaFalsaButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SimpsonButton = New System.Windows.Forms.Button()
        Me.TrapeciosButton = New System.Windows.Forms.Button()
        Me.RectangulosButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GaussSeidelButton = New System.Windows.Forms.Button()
        Me.JacobiButton = New System.Windows.Forms.Button()
        Me.RaizDeDosButton = New System.Windows.Forms.Button()
        Me.BiseccionButton = New System.Windows.Forms.Button()
        Me.ImparesButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lblProgramaActual = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.PanelContainer.SuspendLayout()
        Me.panelFormularios.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.White
        Me.PanelContainer.Controls.Add(Me.panelFormularios)
        Me.PanelContainer.Controls.Add(Me.panelMenu)
        Me.PanelContainer.Controls.Add(Me.PanelTitulo)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(995, 535)
        Me.PanelContainer.TabIndex = 0
        '
        'panelFormularios
        '
        Me.panelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelFormularios.Controls.Add(Me.Label5)
        Me.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFormularios.Location = New System.Drawing.Point(200, 32)
        Me.panelFormularios.Name = "panelFormularios"
        Me.panelFormularios.Size = New System.Drawing.Size(795, 503)
        Me.panelFormularios.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PeachPuff
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(214, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(354, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Escoge el método que deseas utilizar"
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.NewtonRaphsonButton)
        Me.panelMenu.Controls.Add(Me.ReglaFalsaButton)
        Me.panelMenu.Controls.Add(Me.Label6)
        Me.panelMenu.Controls.Add(Me.SimpsonButton)
        Me.panelMenu.Controls.Add(Me.TrapeciosButton)
        Me.panelMenu.Controls.Add(Me.RectangulosButton)
        Me.panelMenu.Controls.Add(Me.Label1)
        Me.panelMenu.Controls.Add(Me.Label4)
        Me.panelMenu.Controls.Add(Me.GaussSeidelButton)
        Me.panelMenu.Controls.Add(Me.JacobiButton)
        Me.panelMenu.Controls.Add(Me.RaizDeDosButton)
        Me.panelMenu.Controls.Add(Me.BiseccionButton)
        Me.panelMenu.Controls.Add(Me.ImparesButton)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Controls.Add(Me.Label3)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 32)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(200, 503)
        Me.panelMenu.TabIndex = 1
        '
        'NewtonRaphsonButton
        '
        Me.NewtonRaphsonButton.FlatAppearance.BorderSize = 0
        Me.NewtonRaphsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewtonRaphsonButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewtonRaphsonButton.Location = New System.Drawing.Point(0, 256)
        Me.NewtonRaphsonButton.Name = "NewtonRaphsonButton"
        Me.NewtonRaphsonButton.Size = New System.Drawing.Size(200, 30)
        Me.NewtonRaphsonButton.TabIndex = 26
        Me.NewtonRaphsonButton.Text = "Newton Raphson"
        Me.NewtonRaphsonButton.UseVisualStyleBackColor = True
        '
        'ReglaFalsaButton
        '
        Me.ReglaFalsaButton.FlatAppearance.BorderSize = 0
        Me.ReglaFalsaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReglaFalsaButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReglaFalsaButton.Location = New System.Drawing.Point(0, 229)
        Me.ReglaFalsaButton.Name = "ReglaFalsaButton"
        Me.ReglaFalsaButton.Size = New System.Drawing.Size(200, 30)
        Me.ReglaFalsaButton.TabIndex = 25
        Me.ReglaFalsaButton.Text = "Regla falsa"
        Me.ReglaFalsaButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PeachPuff
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Primer parcial"
        '
        'SimpsonButton
        '
        Me.SimpsonButton.FlatAppearance.BorderSize = 0
        Me.SimpsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SimpsonButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpsonButton.Location = New System.Drawing.Point(0, 465)
        Me.SimpsonButton.Name = "SimpsonButton"
        Me.SimpsonButton.Size = New System.Drawing.Size(200, 30)
        Me.SimpsonButton.TabIndex = 23
        Me.SimpsonButton.Text = "Integración por Simpson 1/3"
        Me.SimpsonButton.UseVisualStyleBackColor = True
        '
        'TrapeciosButton
        '
        Me.TrapeciosButton.FlatAppearance.BorderSize = 0
        Me.TrapeciosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrapeciosButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrapeciosButton.Location = New System.Drawing.Point(0, 433)
        Me.TrapeciosButton.Name = "TrapeciosButton"
        Me.TrapeciosButton.Size = New System.Drawing.Size(200, 30)
        Me.TrapeciosButton.TabIndex = 22
        Me.TrapeciosButton.Text = "Integración por trapecios"
        Me.TrapeciosButton.UseVisualStyleBackColor = True
        '
        'RectangulosButton
        '
        Me.RectangulosButton.FlatAppearance.BorderSize = 0
        Me.RectangulosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RectangulosButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangulosButton.Location = New System.Drawing.Point(0, 402)
        Me.RectangulosButton.Name = "RectangulosButton"
        Me.RectangulosButton.Size = New System.Drawing.Size(200, 30)
        Me.RectangulosButton.TabIndex = 21
        Me.RectangulosButton.Text = "Integración por rectángulos"
        Me.RectangulosButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tercer parcial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PeachPuff
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(8, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Segundo parcial"
        '
        'GaussSeidelButton
        '
        Me.GaussSeidelButton.FlatAppearance.BorderSize = 0
        Me.GaussSeidelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GaussSeidelButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GaussSeidelButton.Location = New System.Drawing.Point(0, 342)
        Me.GaussSeidelButton.Name = "GaussSeidelButton"
        Me.GaussSeidelButton.Size = New System.Drawing.Size(200, 30)
        Me.GaussSeidelButton.TabIndex = 17
        Me.GaussSeidelButton.Text = "Gauss-Seidel"
        Me.GaussSeidelButton.UseVisualStyleBackColor = True
        '
        'JacobiButton
        '
        Me.JacobiButton.FlatAppearance.BorderSize = 0
        Me.JacobiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JacobiButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JacobiButton.Location = New System.Drawing.Point(0, 314)
        Me.JacobiButton.Name = "JacobiButton"
        Me.JacobiButton.Size = New System.Drawing.Size(200, 30)
        Me.JacobiButton.TabIndex = 16
        Me.JacobiButton.Text = "Jacobi"
        Me.JacobiButton.UseVisualStyleBackColor = True
        '
        'RaizDeDosButton
        '
        Me.RaizDeDosButton.FlatAppearance.BorderSize = 0
        Me.RaizDeDosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RaizDeDosButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaizDeDosButton.Location = New System.Drawing.Point(0, 177)
        Me.RaizDeDosButton.Name = "RaizDeDosButton"
        Me.RaizDeDosButton.Size = New System.Drawing.Size(200, 30)
        Me.RaizDeDosButton.TabIndex = 14
        Me.RaizDeDosButton.Text = "Raíz de dos"
        Me.RaizDeDosButton.UseVisualStyleBackColor = True
        '
        'BiseccionButton
        '
        Me.BiseccionButton.FlatAppearance.BorderSize = 0
        Me.BiseccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BiseccionButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BiseccionButton.Location = New System.Drawing.Point(0, 203)
        Me.BiseccionButton.Name = "BiseccionButton"
        Me.BiseccionButton.Size = New System.Drawing.Size(200, 30)
        Me.BiseccionButton.TabIndex = 13
        Me.BiseccionButton.Text = "Bisección"
        Me.BiseccionButton.UseVisualStyleBackColor = True
        '
        'ImparesButton
        '
        Me.ImparesButton.FlatAppearance.BorderSize = 0
        Me.ImparesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImparesButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImparesButton.Location = New System.Drawing.Point(0, 151)
        Me.ImparesButton.Name = "ImparesButton"
        Me.ImparesButton.Size = New System.Drawing.Size(200, 30)
        Me.ImparesButton.TabIndex = 11
        Me.ImparesButton.Text = "Impares"
        Me.ImparesButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MenuMetodosNumericos.My.Resources.Resources.osos
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(1, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Equipo OSOS MADUROS"
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.lblProgramaActual)
        Me.PanelTitulo.Controls.Add(Me.Label2)
        Me.PanelTitulo.Controls.Add(Me.Salir)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(995, 32)
        Me.PanelTitulo.TabIndex = 0
        '
        'lblProgramaActual
        '
        Me.lblProgramaActual.AutoSize = True
        Me.lblProgramaActual.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramaActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProgramaActual.Location = New System.Drawing.Point(423, 8)
        Me.lblProgramaActual.Name = "lblProgramaActual"
        Me.lblProgramaActual.Size = New System.Drawing.Size(0, 19)
        Me.lblProgramaActual.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proyectos Métodos Numéricos - 2NV50"
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir.Image = Global.MenuMetodosNumericos.My.Resources.Resources.close
        Me.Salir.Location = New System.Drawing.Point(961, 0)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(34, 32)
        Me.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Salir.TabIndex = 0
        Me.Salir.TabStop = False
        '
        'MainContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 535)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainContainer"
        Me.Text = "Form1"
        Me.PanelContainer.ResumeLayout(False)
        Me.panelFormularios.ResumeLayout(False)
        Me.panelFormularios.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Salir As PictureBox
    Friend WithEvents panelFormularios As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImparesButton As Button
    Friend WithEvents GaussSeidelButton As Button
    Friend WithEvents JacobiButton As Button
    Friend WithEvents RaizDeDosButton As Button
    Friend WithEvents BiseccionButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProgramaActual As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RectangulosButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TrapeciosButton As Button
    Friend WithEvents SimpsonButton As Button
    Friend WithEvents NewtonRaphsonButton As Button
    Friend WithEvents ReglaFalsaButton As Button
    Friend WithEvents Label6 As Label
End Class
