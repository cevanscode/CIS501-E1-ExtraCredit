using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_ExtraCredit {
    public class Book {

        /// <summary>
        /// The book's title
        /// </summary>
        public string title;

        /// <summary>
        /// The total amount of pages in the book
        /// </summary>
        public int totalpages;

        /// <summary>
        /// The page the book is currently on; default first page
        /// </summary>
        public int currentpage = 1;

        /// <summary>
        /// List of bookmarks for the given book
        /// up to 5 per book
        /// </summary>
        public List<int> bookmarks = new List<int>(5);

        /// <summary>
        /// Creates a new book object with the specified details
        /// </summary>
        /// <param name="t">The book's title</param>
        /// <param name="p">The total number of pages</param>
        public Book(string t, int p) { this.title = t; this.totalpages = p; }

        public override string ToString() {
            return this.title;
        }
    }
}
