using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace UniformGrid
{
    public class UniformGrid : Grid
    {

        public UniformGrid()
        {

        }

        /// <summary>
        ///  Gets the number of columns that are in the grid.
        /// </summary>
        public int Columns { get; private set; }

        /// <summary>
        /// Gets  the number of rows that are in the grid.
        /// </summary>
        public int Rows { get; private set; }


        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            base.LayoutChildren(x, y, width, height);
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
            RefreshLayout();

        }
        protected override void OnChildRemoved(Element child)
        {
            base.OnChildRemoved(child);
            RefreshLayout();
        }

        private void RefreshLayout()
        {
            this.ColumnDefinitions.Clear();
            int ColsRows = (int)Math.Round(((double)this.Children.Count) / 2, 0);
            for (int i = 0; i < ColsRows; i++)
            {
                this.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }

            int row = 0;
            int column = 0;

            for (int i = 0; i < this.Children.Count; i++)
            {
                if (column >= ColsRows)
                {
                    row++;
                    column = 0;
                }
                Grid.SetColumn(this.Children[i], column);
                Grid.SetRow(this.Children[i], row);
                column++;
            }
            OnChildMeasureInvalidated();
            this.Rows =
            this.Columns = ColsRows;
        }
    }
}
