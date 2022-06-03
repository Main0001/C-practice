using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5.Models
{
    internal static class PageParser
    {
        /// <summary>
        /// Page parser, separate text on pages
        /// </summary>
        /// <param name="content">text</param>
        /// <returns>content with pages</returns>
        public static Content Parse(string content)
        {
            var textPages = content.Split("<page>", StringSplitOptions.RemoveEmptyEntries);
            var contentPages = new Content();

            var pages = textPages
                .Select((text, index) => new Page()
                {
                    Number = index+1,
                    Words = text.Split(new char[] { '.', ' ', ',', ';','-','\n','\r','\t','(',')','\\','_', '—' }, StringSplitOptions.RemoveEmptyEntries)
                })
                .ToList();
            return new Content() { Pages = pages.ToArray() };
        }
    }
}
