using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace Exam1_ExtraCredit {
    public delegate void UpdateDel(IList list);
    public partial class LibraryView : Form {

        public SyncDel handleSync;
        public NextDel handleNext;
        public PrevDel handlePrev;
        public JumpDel handleJump;
        public BMADel handleBMA;
        public BMRDel handleBMR;


        public LibraryView(SyncDel s) {
            InitializeComponent();
            handleSync = s;
            OpenButton.Enabled = (LibList.Items.Count > 0);
        }

        private void OpenButton_Click(object sender, EventArgs e) {
            if (LibList.SelectedItem != null) {
                BookView book = new BookView((Book)LibList.SelectedItem!, handleNext, handlePrev, handleJump, handleBMA, handleBMR);
                book.ShowDialog();
            }
        }

        private void SyncButton_Click(object sender, EventArgs e) {
            handleSync();
        }

        /// <summary>
        /// Redraws/Updates the whole GUI
        /// </summary>
        /// <param name="list">list to update from</param>
        public void UpdateTheBookList(IList list) {

            LibList.Items.Clear();

            foreach (Book b in list) {
                LibList.Items.Add(b);
            }

            OpenButton.Enabled = (LibList.Items.Count > 0);
        }
    }
}
