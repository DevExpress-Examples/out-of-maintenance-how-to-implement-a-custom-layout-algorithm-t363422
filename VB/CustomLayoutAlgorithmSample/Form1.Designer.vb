Namespace CustomLayoutAlgorithmSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim treeMapPaletteColorizer1 As New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Dim treeMapItemStorage1 As New DevExpress.XtraTreeMap.TreeMapItemStorage()
            Dim treeMapItem1 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem2 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem3 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem4 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem5 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem6 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem7 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem8 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem9 As New DevExpress.XtraTreeMap.TreeMapItem()
            Dim treeMapItem10 As New DevExpress.XtraTreeMap.TreeMapItem()
            Me.treeMap = New DevExpress.XtraTreeMap.TreeMapControl()
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeMap
            ' 
            Me.treeMap.BackColor = System.Drawing.Color.White
            treeMapPaletteColorizer1.ColorizeGroups = True
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette
            Me.treeMap.Colorizer = treeMapPaletteColorizer1
            treeMapItem1.Label = "United States"
            treeMapItem1.Value = 17.418R
            treeMapItem2.Label = "Brazil"
            treeMapItem2.Value = 2.353R
            treeMapItem3.Label = "China"
            treeMapItem3.Value = 10.38R
            treeMapItem4.Label = "Japan"
            treeMapItem4.Value = 4.616R
            treeMapItem5.Label = "India"
            treeMapItem5.Value = 2.049R
            treeMapItem6.Label = "Germany"
            treeMapItem6.Value = 3.859R
            treeMapItem7.Label = "United Kingdom"
            treeMapItem7.Value = 2.945R
            treeMapItem8.Label = "France"
            treeMapItem8.Value = 2.846R
            treeMapItem9.Label = "Italy"
            treeMapItem9.Value = 2.147R
            treeMapItem10.Label = "Russia"
            treeMapItem10.Value = 1.857R
            treeMapItemStorage1.Items.AddRange(New DevExpress.XtraTreeMap.TreeMapItem() { treeMapItem1, treeMapItem2, treeMapItem3, treeMapItem4, treeMapItem5, treeMapItem6, treeMapItem7, treeMapItem8, treeMapItem9, treeMapItem10})
            Me.treeMap.DataAdapter = treeMapItemStorage1
            Me.treeMap.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeMap.GroupStyle.Fill = System.Drawing.Color.White
            Me.treeMap.GroupStyle.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.treeMap.LeafStyle.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.treeMap.LeafTextPattern = "{L} : {V:C1} trillions"
            Me.treeMap.Location = New System.Drawing.Point(0, 0)
            Me.treeMap.Name = "treeMap"
            Me.treeMap.Size = New System.Drawing.Size(624, 321)
            Me.treeMap.TabIndex = 0
            Me.treeMap.ToolTipGroupPattern = ""
            Me.treeMap.ToolTipLeafPattern = "{L} : {V:C1} trillions"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.treeMap)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private treeMap As DevExpress.XtraTreeMap.TreeMapControl
    End Class
End Namespace

