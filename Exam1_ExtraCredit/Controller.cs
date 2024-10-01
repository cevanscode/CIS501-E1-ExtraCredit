using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam1_ExtraCredit {
    public delegate void SyncDel();
    public delegate void NextDel(Book b);
    public delegate void PrevDel(Book b);
    public delegate void JumpDel(Book b, int dest);
    public delegate void BMADel(Book b);
    public delegate void BMRDel(Book b, int dest);

    public class Controller {

        public Model model;
        public UpdateDel handleUpdate;


        public Controller(Model m) {
            this.model = m;
        }

        /// <summary>
        /// Loads the file of books into list 
        /// will eventually display all in GUI
        /// </summary>
        public void BookFileLoad() {

            model.books.Clear();

            string path = Directory.GetCurrentDirectory();
            for (int level = 0; level < 3; level++) {
                path = Directory.GetParent(path)!.FullName;
            }

            path = path + "/Books.txt";

            try {
                using (StreamReader s = new StreamReader(path)) {
                    string each;
                    while ((each = s.ReadLine()!) != null) {

                        string[] parts = Regex.Split(each, ":::");
                        Book b = new Book(parts[0], Convert.ToInt32(parts[1]));

                        model.books.Add(b);
                    }
                }
            }
            catch (System.IO.FileNotFoundException) { File.Create(path); }
            handleUpdate(model.books);
        }

        #region bookviewmethods

        /// <summary>
        /// moves to next page
        /// </summary>
        /// <param name="b">book</param>
        public void PageNext(Book b) {
            model.Next(b);
        }

        /// <summary>
        /// moves to previous page
        /// </summary>
        /// <param name="b">book</param>
        public void PagePrev(Book b) {
            model.Prev(b);
        }

        /// <summary>
        /// jumps to requested page
        /// </summary>
        /// <param name="b">book</param>
        /// <param name="dest">destination page</param>
        public void PageJump(Book b, int dest) {
            model.MoveTo(b, dest);
        }

        /// <summary>
        /// adds bookmark at current page
        /// </summary>
        /// <param name="b"></param>
        public void BookMarkAdd(Book b) {
            model.AddBM(b);
        }

        /// <summary>
        /// removes selected bookmark
        /// </summary>
        /// <param name="b">book</param>
        /// <param name="remove">selected bookmark to remove</param>
        public void BookMarkRemove(Book b, int remove) {
            model.NoBM(b, remove);
        }

        #endregion
    }
}
