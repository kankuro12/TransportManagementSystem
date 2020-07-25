using System.Windows.Forms;
namespace CustomControls
{
    public class BetterListView : ListView
    {
        public bool sortable { get; set; }
        private ColumnHeader SortingColumn = null;

        public BetterListView()
        {
            this.View = View.Details;
            this.GridLines = true;
            this.FullRowSelect = true;
            this.sortable = false;
        }

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            if (this.sortable)
            {

                ColumnHeader new_sorting_column = this.Columns[e.Column];

                // Figure out the new sorting order.
                System.Windows.Forms.SortOrder sort_order;
                if (SortingColumn == null)
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }
                else
                {
                    // See if this is the same column.
                    if (new_sorting_column == SortingColumn)
                    {
                        // Same column. Switch the sort order.
                        if (SortingColumn.Text.StartsWith("> "))
                        {
                            sort_order = SortOrder.Descending;
                        }
                        else
                        {
                            sort_order = SortOrder.Ascending;
                        }
                    }
                    else
                    {
                        // New column. Sort ascending.
                        sort_order = SortOrder.Ascending;
                    }

                    // Remove the old sort indicator.
                    SortingColumn.Text = SortingColumn.Text.Substring(2);
                }

                // Display the new sort order.
                SortingColumn = new_sorting_column;
                if (sort_order == SortOrder.Ascending)
                {
                    SortingColumn.Text = "> " + SortingColumn.Text;
                }
                else
                {
                    SortingColumn.Text = "< " + SortingColumn.Text;
                }

                // Create a comparer.
                this.ListViewItemSorter =
                    new ListViewComparer(e.Column, sort_order);

                // Sort.
                this.Sort();
                base.OnColumnClick(e);
            }
        }

    }
}
