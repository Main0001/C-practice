using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5.Models
{
    internal class Ukazatel
    {
        
        private Content _content;
       
        public Section[] Sections => GetSections();
         public Ukazatel(Content content)
        {
            _content = content;
        }

        /// <summary>
        /// Section creator.
        /// </summary>
        /// <returns>array whit sections</returns>
        private Section[] GetSections()
        {
            var words = new List<WordIndex>();
            var wordsFromPage = _content.Pages.SelectMany(page => page.Words.Select(w => new WordIndex() { Value = w, Index = page.Number }));
            wordsFromPage.ToList().ForEach(words.Add);

            var groupWords = words.GroupBy(w => w.Value.ToLower(), w => w.Index)
           .OrderBy(g => g.Key);

            var groupU = groupWords.GroupBy(g => g.Key[0], g => new { Word = g.Key, Indexes = g.Distinct() });

            return groupU.Select(g=>new Section() {
                Letter = g.Key,
                Words = g.ToDictionary(p => p.Word, p => p.Indexes.ToArray()) })
                .ToArray();

           
        }

        /// <summary>
        /// Returns the occurrence pages of the word.
        /// </summary>
        /// <param name="word">word</param>
        /// <returns>array with numbers of pages</returns>
        public int[] GetWordIndexes(string word)
        {
            return Sections
                .Where(s => s.Words.ContainsKey(word))
                .Select(s => s.Words[word])
                .FirstOrDefault()
                .ToArray();
        }
    }
}
