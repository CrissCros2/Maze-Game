<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charts
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Charts))
        Me.ChrtScore = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChrtScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChrtScore
        '
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.Name = "ChartArea1"
        Me.ChrtScore.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChrtScore.Legends.Add(Legend1)
        Me.ChrtScore.Location = New System.Drawing.Point(0, 0)
        Me.ChrtScore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChrtScore.Name = "ChrtScore"
        Me.ChrtScore.Size = New System.Drawing.Size(1203, 694)
        Me.ChrtScore.TabIndex = 0
        Me.ChrtScore.Text = "Chart1"
        '
        'Charts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.ChrtScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Charts"
        Me.Text = "Graphs"
        CType(Me.ChrtScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChrtScore As DataVisualization.Charting.Chart
End Class
