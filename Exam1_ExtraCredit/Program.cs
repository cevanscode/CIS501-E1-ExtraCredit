namespace Exam1_ExtraCredit {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();

            Model m = new Model();
            Controller c = new(m);
            LibraryView lv = new LibraryView(c.BookFileLoad);

            lv.handleNext = c.PageNext;
            lv.handlePrev = c.PagePrev;
            lv.handleJump = c.PageJump;
            lv.handleBMA = c.BookMarkAdd;
            lv.handleBMR = c.BookMarkRemove;

            c.handleUpdate = lv.UpdateTheBookList;


            Application.Run(lv);
        }
    }
}