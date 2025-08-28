using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoversUI.Utils
{
    public class CollectionsUtils
    {
        public static void LoadObservableCollectionWithoutClear<T>(
           IEnumerable<T> Source,
           ObservableCollection<T> Cible,
           Func<T, object> IdSelector,
           Action<T, T> UpdateItemAction,
           Func<T, T> CreateItemFunc)
        {
            // Supprimer ceux qui n'existent plus
            var aSupprimer = Cible
                .Where(c => !Source.Any(s => IdSelector(s).Equals(IdSelector(c))))
                .ToList();

            foreach (var item in aSupprimer)
                Cible.Remove(item);

            // Ajouter ou mettre à jour
            foreach (var itemSource in Source)
            {
                var existant = Cible.FirstOrDefault(c => IdSelector(c).Equals(IdSelector(itemSource)));

                if (existant == null)
                {
                    // Ajout → nouvelle instance
                    Cible.Add(CreateItemFunc(itemSource));
                }
                else
                {
                    // Mise à jour → modifie l’objet existant (pas de perte de sélection)
                    UpdateItemAction(itemSource, existant);
                }
            }
        }

        public static void LoadObservableCollectionWithoutClear<T, TKey>(
            IList<T> Source,
            ObservableCollection<T> Cible,
            Func<T, TKey> IdSelector,
            Action<T, T> UpdateItemAction,
            Func<T, T> CreateItemFunc)
        {
            // --- Étape 1 : construire un dictionnaire pour rechercher rapidement ---
            var dictSource = new Dictionary<TKey, T>();
            for (int i = 0; i < Source.Count; i++)
            {
                var key = IdSelector(Source[i]);
                if (!dictSource.ContainsKey(key))
                    dictSource.Add(key, Source[i]);
            }

            // --- Étape 2 : supprimer les éléments absents ---
            for (int i = Cible.Count - 1; i >= 0; i--)
            {
                var key = IdSelector(Cible[i]);
                if (!dictSource.ContainsKey(key))
                {
                    Cible.RemoveAt(i);
                }
            }

            // --- Étape 3 : mise à jour ou ajout ---
            for (int i = 0; i < Source.Count; i++)
            {
                var srcItem = Source[i];
                var key = IdSelector(srcItem);

                bool found = false;
                for (int j = 0; j < Cible.Count; j++)
                {
                    if (EqualityComparer<TKey>.Default.Equals(IdSelector(Cible[j]), key))
                    {
                        // Mise à jour en place => garde la sélection
                        UpdateItemAction(srcItem, Cible[j]);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // Ajout => nouvelle instance via factory
                    Cible.Add(CreateItemFunc(srcItem));
                }
            }
        }
    }
}
