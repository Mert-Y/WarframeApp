using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;

namespace WarframeApp.Utilities
{
    static class Extensions
    {
        public static void SortObservableCollection<T>(this ObservableCollection<T> collection,
            params Expression<Func<T, object>>[] expressions)
        {
            //Expressions example: x => x.category, x => x.name
            List<T> sorted;
            if (expressions.Length == 1)
            {
                sorted = collection.OrderBy(expressions[0].Compile()).ToList();
            }
            else
            {
                var query = collection.OrderBy(expressions[0].Compile());
                for (int i = 1; i < expressions.Length; i++)
                {
                    query = query.ThenBy(expressions[i].Compile());
                }
                sorted = query.ToList();
            }

            for (int i = 0; i < sorted.Count(); i++)
            {
                if (!collection[i].Equals(sorted[i]))
                {
                    collection.Move(collection.IndexOf(sorted[i]), i);
                }
            }
        }
    }
}
