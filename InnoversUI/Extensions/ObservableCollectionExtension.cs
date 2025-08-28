using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace InnoversUI.Extensions
{
    public static class ObservableCollectionExtension
    {
        public static void Sort<T>(this ObservableCollection<T> collection, Comparison<T> comparison)
        {
            var sorted = collection.ToList();
            sorted.Sort(comparison);

            collection.Clear();
            foreach (var item in sorted)
                collection.Add(item);
        }

        public static void Sort<T, TKey>(this ObservableCollection<T> collection, Func<T, TKey> keySelector)
        {
            var sorted = collection.OrderBy(keySelector).ToList();

            collection.Clear();
            foreach (var item in sorted)
                collection.Add(item);
        }

        public static void SortDescending<T, TKey>(this ObservableCollection<T> collection, Func<T, TKey> keySelector)
        {
            var sorted = collection.OrderByDescending(keySelector).ToList();

            collection.Clear();
            foreach (var item in sorted)
                collection.Add(item);
        }

        public static void SortInPlace<T>(this ObservableCollection<T> collection, Comparison<T> comparison)
        {
            var sorted = collection.OrderBy(x => x, Comparer<T>.Create(comparison)).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                var item = sorted[i];
                int oldIndex = collection.IndexOf(item);

                if (oldIndex != i)
                    collection.Move(oldIndex, i);
            }
        }

        public static void SortInPlace<T, TKey>(this ObservableCollection<T> collection, Func<T, TKey> keySelector)
        {
            var sorted = collection.OrderBy(keySelector).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                var item = sorted[i];
                int oldIndex = collection.IndexOf(item);

                if (oldIndex != i)
                    collection.Move(oldIndex, i);
            }
        }

        public static void SortInPlaceOptimized<T>(
        this ObservableCollection<T> collection,
        Comparison<T> comparison)
        {
            var sorted = collection.OrderBy(x => x, Comparer<T>.Create(comparison)).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                var item = sorted[i];
                int oldIndex = collection.IndexOf(item);

                if (oldIndex != i)
                {
                    collection.Move(oldIndex, i);
                }
            }
        }

        public static void SortInPlace<T>(
        this ObservableCollection<T> collection,
        params (Func<T, object> KeySelector, bool Descending)[] sortCriteria)
        {
            if (sortCriteria == null || sortCriteria.Length == 0)
                return;

            // Construction de l'expression LINQ dynamique
            IOrderedEnumerable<T> sorted = sortCriteria[0].Descending
                ? collection.OrderByDescending(sortCriteria[0].KeySelector)
                : collection.OrderBy(sortCriteria[0].KeySelector);

            for (int i = 1; i < sortCriteria.Length; i++)
            {
                sorted = sortCriteria[i].Descending
                    ? sorted.ThenByDescending(sortCriteria[i].KeySelector)
                    : sorted.ThenBy(sortCriteria[i].KeySelector);
            }

            var sortedList = sorted.ToList();

            // Dictionnaire pour retrouver rapidement les indices
            var indexLookup = collection
                .Select((item, idx) => new { item, idx })
                .ToDictionary(x => x.item, x => x.idx);

            // Déplacement optimisé
            for (int i = 0; i < sortedList.Count; i++)
            {
                var item = sortedList[i];
                int oldIndex = indexLookup[item];

                if (oldIndex != i)
                {
                    collection.Move(oldIndex, i);

                    // Mise à jour des indices
                    for (int j = i; j <= oldIndex; j++)
                        indexLookup[collection[j]] = j;
                }
            }
        }

        public static async Task SortInPlaceAsync<T>(
        this ObservableCollection<T> collection,
        Dispatcher dispatcher,
        params (Func<T, object> KeySelector, bool Descending)[] sortCriteria)
        {
            if (sortCriteria == null || sortCriteria.Length == 0)
                return;

            // ⚡ Tri en tâche de fond (hors UI thread)
            var sortedList = await Task.Run(() =>
            {
                IOrderedEnumerable<T> sorted = sortCriteria[0].Descending
                    ? collection.OrderByDescending(sortCriteria[0].KeySelector)
                    : collection.OrderBy(sortCriteria[0].KeySelector);

                for (int i = 1; i < sortCriteria.Length; i++)
                {
                    sorted = sortCriteria[i].Descending
                        ? sorted.ThenByDescending(sortCriteria[i].KeySelector)
                        : sorted.ThenBy(sortCriteria[i].KeySelector);
                }

                return sorted.ToList();
            });

            // ⚡ Application des Move() sur le thread UI
            await dispatcher.InvokeAsync(() =>
            {
                var indexLookup = collection
                    .Select((item, idx) => new { item, idx })
                    .ToDictionary(x => x.item, x => x.idx);

                for (int i = 0; i < sortedList.Count; i++)
                {
                    var item = sortedList[i];
                    int oldIndex = indexLookup[item];

                    if (oldIndex != i)
                    {
                        collection.Move(oldIndex, i);

                        for (int j = i; j <= oldIndex; j++)
                            indexLookup[collection[j]] = j;
                    }
                }
            });
        }
    }
}
