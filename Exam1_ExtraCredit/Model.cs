using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_ExtraCredit {
    public class Model {

        public List<Book> books;

        public Model() { this.books = new List<Book>(); }

        /// <summary>
        /// Allows the travel to a specfic page by providing the page number
        /// </summary>
        /// <param name="b">The book</param>
        /// <param name="dest">The page to skip to</param>
        public void MoveTo(Book b, int dest) {
            if (dest <= b.totalpages && dest >= 1) {
                b.currentpage = dest;
            }
        }

        /// <summary>
        /// Moves to the next page
        /// </summary>
        /// <param name="b">The book</param>
        public void Next(Book b) {
            if (b.currentpage < b.totalpages) {
                b.currentpage++;
            }
        }

        /// <summary>
        /// Moves to the prev page
        /// </summary>
        /// <param name="b">The book</param>
        public void Prev(Book b) {
            if (b.currentpage > 1) {
                b.currentpage--;
            }
        }

        /// <summary>
        /// Adds a bookmark at the current page
        /// </summary>
        /// <param name="b">The book</param>
        public void AddBM(Book b) {
            if (b.bookmarks.Count < 5) {
                b.bookmarks.Add(b.currentpage);
            }
        }

        /// <summary>
        /// removes a bookmark at the selected page
        /// </summary>
        /// <param name="b">The book</param>
        /// <param name="toGo">the page to remove the bookmark from</param>
        public void NoBM(Book b, int toGo) {
            if (b.bookmarks.Count > 0 && b.bookmarks.Contains(toGo)) {
                b.bookmarks.Remove(toGo);
            }
        }
    }
}
