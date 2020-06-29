Public Class MainContainer
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContainer.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub

    Private Sub AbrirFormEnPanel(Of MiForm As {Form, New})()
        Dim Formulario As Form
        Formulario = panelFormularios.Controls.OfType(Of MiForm)().FirstOrDefault() 'Busca el formulario en la coleccion'
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New MiForm()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            panelFormularios.Controls.Add(Formulario)
            panelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub ChangeOption()
        For Each ctrl As Control In panelFormularios.Controls
            If TypeOf ctrl Is Form Then
                panelFormularios.Controls.Remove(ctrl)
            End If
        Next
        ImparesButton.BackColor = Color.FromArgb(192, 192, 255)
        RaizDeDosButton.BackColor = Color.FromArgb(192, 192, 255)
        BiseccionButton.BackColor = Color.FromArgb(192, 192, 255)
        ReglaFalsaButton.BackColor = Color.FromArgb(192, 192, 255)
        NewtonRaphsonButton.BackColor = Color.FromArgb(192, 192, 255)
        JacobiButton.BackColor = Color.FromArgb(192, 192, 255)
        GaussSeidelButton.BackColor = Color.FromArgb(192, 192, 255)
        RectangulosButton.BackColor = Color.FromArgb(192, 192, 255)
        TrapeciosButton.BackColor = Color.FromArgb(192, 192, 255)
        SimpsonButton.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub ImparesButton_Click(sender As Object, e As EventArgs) Handles ImparesButton.Click
        lblProgramaActual.Text = "Impares"
        ChangeOption()
        AbrirFormEnPanel(Of Impares)()
        ImparesButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub RaizDeDosButton_Click(sender As Object, e As EventArgs) Handles RaizDeDosButton.Click
        lblProgramaActual.Text = "Raíz de dos"
        ChangeOption()
        AbrirFormEnPanel(Of RaizDeDos)()
        RaizDeDosButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub BiseccionButton_Click(sender As Object, e As EventArgs) Handles BiseccionButton.Click
        lblProgramaActual.Text = "Bisección"
        ChangeOption()
        AbrirFormEnPanel(Of Biseccion)()
        BiseccionButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub JacobiButton_Click(sender As Object, e As EventArgs) Handles JacobiButton.Click
        lblProgramaActual.Text = "Jacobi"
        ChangeOption()
        AbrirFormEnPanel(Of Jacobi)()
        JacobiButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub GaussSeidelButton_Click(sender As Object, e As EventArgs) Handles GaussSeidelButton.Click
        lblProgramaActual.Text = "Gauss-Seidel"
        ChangeOption()
        AbrirFormEnPanel(Of GaussSeidel)()
        GaussSeidelButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub RectangulosButton_Click(sender As Object, e As EventArgs) Handles RectangulosButton.Click
        lblProgramaActual.Text = "Integración por rectángulos"
        ChangeOption()
        AbrirFormEnPanel(Of IntegracionPorRectangulos)()
        RectangulosButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub TrapeciosButton_Click(sender As Object, e As EventArgs) Handles TrapeciosButton.Click
        lblProgramaActual.Text = "Integración por trapecios"
        ChangeOption()
        AbrirFormEnPanel(Of IntegracionPorTrapecios)()
        TrapeciosButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub SimpsonButton_Click(sender As Object, e As EventArgs) Handles SimpsonButton.Click
        lblProgramaActual.Text = "Integración por Simpson 1/3"
        ChangeOption()
        AbrirFormEnPanel(Of IntegracionPorSimpson)()
        SimpsonButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub ReglaFalsaButton_Click(sender As Object, e As EventArgs) Handles ReglaFalsaButton.Click
        lblProgramaActual.Text = "Regla falsa"
        ChangeOption()
        AbrirFormEnPanel(Of ReglaFalsa)()
        ReglaFalsaButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub NewtonRaphsonButton_Click(sender As Object, e As EventArgs) Handles NewtonRaphsonButton.Click
        lblProgramaActual.Text = "Newton Raphson"
        ChangeOption()
        AbrirFormEnPanel(Of NewtonRaphson)()
        NewtonRaphsonButton.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lblProgramaActual.Text = String.Empty
        ChangeOption()
    End Sub
End Class
