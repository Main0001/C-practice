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
         public Ukazatel(Content content)
        {
            _content = content;
        }
        public Section[] GetSections() 
        {
            var words = new Dictionary<string, int[]>();
            var manyWords = _content.Pages
                .SelectMany(p => p.Words.Select(w => new { Word = w.ToLower(), p.Number }).ToList())
                .GroupBy(p => p.Word.ToLower(), p => p.Number)
                .OrderBy(p => p.Key)
                .ToList();

           return manyWords.Select(w => new Section() { Letter = w.Key[0], Words = w.ToDictionary(p => w.Key, p => w.Select(i => i).ToArray()) })
                .ToArray();
            
        }

    }
}
