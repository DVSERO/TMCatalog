using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace TMCatalog.Common.Behaviors
{
    public class TreeViewSelectedItemBehavior : Behavior<TreeView>
    {
        public static readonly DependencyProperty TreeViewSelectedItemProperty =
                  DependencyProperty.RegisterAttached("TreeViewSelectedItem", typeof(object), 
                      typeof(TreeViewSelectedItemBehavior), null);

        public object TreeViewSelectedItem
        {
            get { return (object)GetValue(TreeViewSelectedItemProperty); }
            set { SetValue(TreeViewSelectedItemProperty, value); }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.SelectedItemChanged += AssociatedObject_SelectedItemChanged;
        }


        protected override void OnDetaching()
        {
            this.AssociatedObject.SelectedItemChanged -= AssociatedObject_SelectedItemChanged;
            base.OnDetaching();
        }

        private void AssociatedObject_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            this.TreeViewSelectedItem = e.NewValue;
        }
    }
}