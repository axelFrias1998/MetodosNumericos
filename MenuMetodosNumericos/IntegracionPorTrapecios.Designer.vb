<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IntegracionPorTrapecios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.ta1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Graficar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIntegral = New System.Windows.Forms.TextBox()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(31, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Ingresa f:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(31, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Ingresa a:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(31, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ingresa b:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(31, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 32)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Dame el número de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cifras significativas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(33, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Dame rango de la gráfica de:"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(157, 64)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(146, 20)
        Me.tf.TabIndex = 25
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(157, 90)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(38, 20)
        Me.ta.TabIndex = 26
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(157, 116)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(38, 20)
        Me.tb.TabIndex = 27
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(157, 159)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(38, 20)
        Me.tc.TabIndex = 28
        '
        'ta1
        '
        Me.ta1.Location = New System.Drawing.Point(216, 198)
        Me.ta1.Name = "ta1"
        Me.ta1.Size = New System.Drawing.Size(39, 20)
        Me.ta1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(325, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "b"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(261, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "a"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(280, 198)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(39, 20)
        Me.tb1.TabIndex = 32
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.HeaderText = "Integral"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column1
        '
        Me.Column1.HeaderText = "a"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'salida
        '
        Me.salida.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.salida.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.salida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.salida.DefaultCellStyle = DataGridViewCellStyle4
        Me.salida.Location = New System.Drawing.Point(53, 235)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(344, 180)
        Me.salida.TabIndex = 33
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Calcular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Calcular.Location = New System.Drawing.Point(319, 62)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(95, 26)
        Me.Calcular.TabIndex = 34
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Graficar
        '
        Me.Graficar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Graficar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graficar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Graficar.Location = New System.Drawing.Point(319, 94)
        Me.Graficar.Name = "Graficar"
        Me.Graficar.Size = New System.Drawing.Size(95, 26)
        Me.Graficar.TabIndex = 35
        Me.Graficar.Text = "Graficar"
        Me.Graficar.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Limpiar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Limpiar.Location = New System.Drawing.Point(319, 126)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(95, 27)
        Me.Limpiar.TabIndex = 36
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Graf
        '
        Me.Graf.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Graf.Legends.Add(Legend2)
        Me.Graf.Location = New System.Drawing.Point(417, 41)
        Me.Graf.Name = "Graf"
        Me.Graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.Legend = "Legend1"
        Series3.Name = "Función"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Área"
        Me.Graf.Series.Add(Series3)
        Me.Graf.Series.Add(Series4)
        Me.Graf.Size = New System.Drawing.Size(385, 300)
        Me.Graf.TabIndex = 38
        Me.Graf.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(477, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Integral:"
        '
        'txtIntegral
        '
        Me.txtIntegral.Location = New System.Drawing.Point(546, 379)
        Me.txtIntegral.Name = "txtIntegral"
        Me.txtIntegral.Size = New System.Drawing.Size(110, 20)
        Me.txtIntegral.TabIndex = 40
        '
        'IntegracionPorTrapecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIntegral)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Graficar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ta1)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IntegracionPorTrapecios"
        Me.Text = "IntegracionPorTrapecios"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents ta1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents salida As DataGridView
    Friend WithEvents Calcular As Button
    Friend WithEvents Graficar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIntegral As TextBox
End Class
