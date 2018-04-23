using DevExpress.TreeMap;
using DevExpress.XtraTreeMap;
using System.Collections.Generic;
using System.Linq;

namespace CustomLayoutAlgorithmSample {
    class CustomLayoutAlgorithm : ITreeMapLayoutAlgorithm, IComparer<ITreeMapItemLayout> {
        public TreeMapLayoutDirection Direction {
            get; set;
        }

        public event LayoutAlgorithmChangedEventHandler LayoutAlgorithmChanged;

        public void Calculate(IEnumerable<ITreeMapItemLayout> items, double width, double height, int groupLevel) {
            double unlayoutedItemsWeight = 0;
            foreach(var item in items)
                unlayoutedItemsWeight += item.Weight;

            var sortedItems = items.ToList();
            sortedItems.Sort(this);

            TreeMapRect emptySpace = new TreeMapRect(0, 0, width, height);
            foreach(var item in sortedItems) {
                double itemWidth;
                double itemHeight;

                double newEmptySpaceX;
                double newEmptySpaceY;
                double newEmptySpaceWidth;
                double newEmptySpaceHeight;

                if(emptySpace.Width / emptySpace.Height > 1) {
                    itemWidth = emptySpace.Width * item.Weight / unlayoutedItemsWeight;
                    itemHeight = emptySpace.Height;

                    newEmptySpaceX = emptySpace.X + itemWidth;
                    newEmptySpaceY = emptySpace.Y;
                    newEmptySpaceHeight = emptySpace.Height;

                    newEmptySpaceWidth = emptySpace.Width - itemWidth;
                    newEmptySpaceWidth = newEmptySpaceWidth < 0 ? 0 : newEmptySpaceWidth;
                }
                else {
                    itemWidth = emptySpace.Width;
                    itemHeight = emptySpace.Height * item.Weight / unlayoutedItemsWeight;

                    newEmptySpaceX = emptySpace.X;
                    newEmptySpaceY = emptySpace.Y + itemHeight;
                    newEmptySpaceWidth = emptySpace.Width;

                    newEmptySpaceHeight = emptySpace.Height - itemHeight;
                    newEmptySpaceHeight = newEmptySpaceHeight < 0 ? 0 : newEmptySpaceHeight;
                }
                item.Layout = new TreeMapRect(emptySpace.X, emptySpace.Y, itemWidth, itemHeight);
                emptySpace = new TreeMapRect(
                    newEmptySpaceX,
                    newEmptySpaceY,
                    newEmptySpaceWidth,
                    newEmptySpaceHeight);
                unlayoutedItemsWeight -= item.Weight;
            }
        }


        public int Compare(ITreeMapItemLayout x, ITreeMapItemLayout y) {
            if(x.Weight > y.Weight) return -1;
            else if(x.Weight < y.Weight) return 1;
            else return 0;
        }

    }
}
