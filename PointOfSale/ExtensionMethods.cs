using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Find the first ancestor in the Viusal Tree that has the specified type, 
        /// or null if no ancestor is found.
        /// </summary>
        /// <typeparam name="T">The type to search for</typeparam>
        /// <param name="dependencyObject"></param>
        /// <returns>The first ancestor of type T, or null</returns>
        public static T FindAncestor<T>(this DependencyObject dependencyObject) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(dependencyObject);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent);
        }
    }
}
