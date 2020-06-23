<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntegracionPorTrapecios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Graficar = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ta1 = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Graf
        '
        ChartArea5.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Graf.Legends.Add(Legend5)
        Me.Graf.Location = New System.Drawing.Point(470, 67)
        Me.Graf.Name = "Graf"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series2"
        Me.Graf.Series.Add(Series9)
        Me.Graf.Series.Add(Series10)
        Me.Graf.Size = New System.Drawing.Size(300, 300)
        Me.Graf.TabIndex = 38
        Me.Graf.Text = "Chart1"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(350, 145)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 37
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(350, 116)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 36
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Graficar
        '
        Me.Graficar.Location = New System.Drawing.Point(350, 87)
        Me.Graficar.Name = "Graficar"
        Me.Graficar.Size = New System.Drawing.Size(75, 23)
        Me.Graficar.TabIndex = 35
        Me.Graficar.Text = "Graficar"
        Me.Graficar.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(350, 58)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 34
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(81, 242)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(344, 150)
        Me.salida.TabIndex = 33
        '
        'Column1
        '
        Me.Column1.HeaderText = "a"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.HeaderText = "Integral"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(245, 181)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(39, 20)
        Me.tb1.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "a"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "b"
        '
        'ta1
        '
        Me.ta1.Location = New System.Drawing.Point(181, 181)
        Me.ta1.Name = "ta1"
        Me.ta1.Size = New System.Drawing.Size(39, 20)
        Me.ta1.TabIndex = 29
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(136, 151)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(38, 20)
        Me.tc.TabIndex = 28
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(81, 116)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(38, 20)
        Me.tb.TabIndex = 27
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(81, 90)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(38, 20)
        Me.ta.TabIndex = 26
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(81, 64)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(146, 20)
        Me.tf.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Dame rango de la gráfica de:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Dame el número de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cifras significativas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Dame b:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Dame a:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Dame f:"
        '
        'IntegracionPorTrapecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.Salir)
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
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents Salir As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Graficar As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ta1 As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
