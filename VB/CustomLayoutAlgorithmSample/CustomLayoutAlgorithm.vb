Imports DevExpress.TreeMap
Imports DevExpress.XtraTreeMap

Namespace CustomLayoutAlgorithmSample
    Friend Class CustomLayoutAlgorithm
        Implements ITreeMapLayoutAlgorithm, IComparer(Of ITreeMapItemLayout)

        Public Property Direction() As TreeMapLayoutDirection

        Public Event LayoutAlgorithmChanged As LayoutAlgorithmChangedEventHandler Implements ITreeMapLayoutAlgorithm.LayoutAlgorithmChanged

        Public Sub Calculate(ByVal items As IEnumerable(Of ITreeMapItemLayout), ByVal width As Double, ByVal height As Double) Implements ITreeMapLayoutAlgorithm.Calculate
            Dim unlayoutedItemsWeight As Double = 0
            For Each item In items
                unlayoutedItemsWeight += item.Weight
            Next item

            Dim sortedItems = items.ToList()
            sortedItems.Sort(Me)

            Dim emptySpace As New TreeMapRect(0, 0, width, height)
            For Each item In sortedItems
                Dim itemWidth As Double
                Dim itemHeight As Double

                Dim newEmptySpaceX As Double
                Dim newEmptySpaceY As Double
                Dim newEmptySpaceWidth As Double
                Dim newEmptySpaceHeight As Double

                If (emptySpace.Width > emptySpace.Height) Then
                    itemWidth = emptySpace.Width * item.Weight / unlayoutedItemsWeight
                    itemHeight = emptySpace.Height

                    newEmptySpaceX = emptySpace.X + itemWidth
                    newEmptySpaceY = emptySpace.Y
                    newEmptySpaceHeight = emptySpace.Height

                    newEmptySpaceWidth = emptySpace.Width - itemWidth
                    newEmptySpaceWidth = If(newEmptySpaceWidth < 0, 0, newEmptySpaceWidth)
                Else
                    itemWidth = emptySpace.Width
                    itemHeight = emptySpace.Height * item.Weight / unlayoutedItemsWeight

                    newEmptySpaceX = emptySpace.X
                    newEmptySpaceY = emptySpace.Y + itemHeight
                    newEmptySpaceWidth = emptySpace.Width

                    newEmptySpaceHeight = emptySpace.Height - itemHeight
                    newEmptySpaceHeight = If(newEmptySpaceHeight < 0, 0, newEmptySpaceHeight)
                End If
                item.Layout = New TreeMapRect(emptySpace.X, emptySpace.Y, itemWidth, itemHeight)
                emptySpace = New TreeMapRect(newEmptySpaceX, newEmptySpaceY, newEmptySpaceWidth, newEmptySpaceHeight)
                unlayoutedItemsWeight -= item.Weight
            Next item
        End Sub

        Public Function Compare(ByVal x As ITreeMapItemLayout, ByVal y As ITreeMapItemLayout) As Integer Implements IComparer(Of ITreeMapItemLayout).Compare
            If x.Weight > y.Weight Then
                Return -1
            ElseIf x.Weight < y.Weight Then
                Return 1
            Else
                Return 0
            End If
        End Function

    End Class
End Namespace
