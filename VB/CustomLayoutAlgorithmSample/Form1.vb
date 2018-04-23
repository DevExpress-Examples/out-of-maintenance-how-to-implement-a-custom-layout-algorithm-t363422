Imports System
Imports System.Windows.Forms

Namespace CustomLayoutAlgorithmSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            treeMap.LayoutAlgorithm = New CustomLayoutAlgorithm()
        End Sub
    End Class
End Namespace
