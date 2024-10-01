using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_ExtraCredit {
    public partial class BookView : Form {

        public Book openBook;

        public NextDel handleNext;
        public PrevDel handlePrev;
        public JumpDel handleJump;
        public BMADel handleBMA;
        public BMRDel handleBMR;


        public BookView(Book b, NextDel n, PrevDel p, JumpDel j, BMADel bma, BMRDel bmr) {
            InitializeComponent();

            this.handleNext = n;
            this.handlePrev = p;
            this.handleJump = j;
            this.handleBMA = bma;
            this.handleBMR = bmr;

            this.openBook = b;
            this.FixForm();
        }

        private void NextButton_Click(object sender, EventArgs e) {
            handleNext(openBook);
            this.FixForm();
        }

        private void PrevButton_Click(object sender, EventArgs e) {
            handlePrev(openBook);
            this.FixForm();
        }

        private void JumpButton_Click(object sender, EventArgs e) {

            int parsedPage;
            if (int.TryParse(GoPageBox.Text, out parsedPage) && parsedPage > 0 && parsedPage <= openBook.totalpages) {
                handleJump(openBook, parsedPage);
            }
            else {
                MessageBox.Show("Input not valid. Enter valid page.");
            }
            this.FixForm();
        }

        private void AddBMButton_Click(object sender, EventArgs e) {
            if (BMBox.Items.Count < 5) {
                handleBMA(openBook);
                this.FixForm();
                BMBox.SelectedIndex = BMBox.Items.Count - 1;
            }
            else {
                MessageBox.Show("You already have 5 bookmarks. Delete one to make another.");
            }
        }

        private void RemoveBMButton_Click(object sender, EventArgs e) {
            if (BMBox.SelectedIndex >= 0) {
                int PrevSavedIdx = BMBox.SelectedIndex;
                handleBMR(openBook, Convert.ToInt32(BMBox.SelectedItem));
                this.FixForm();
                BMBox.SelectedIndex = Math.Min(PrevSavedIdx - 1, BMBox.Items.Count - 1);
            }
        }

        private void FixForm() {
            BookTitleLabel.Text = openBook.title;
            PagePlaceLabel.Text = $"You are on page {openBook.currentpage} out of {openBook.totalpages}";
            //BMBox.DataSource = openBook.bookmarks;
            BMBox.Items.Clear();
            foreach (int i in openBook.bookmarks) {
                BMBox.Items.Add(i);
            }
            PrevButton.Enabled = openBook.currentpage > 1;
            NextButton.Enabled = openBook.currentpage < openBook.totalpages;
            AddBMButton.Enabled = openBook.bookmarks.Count < 5;
            RemoveBMButton.Enabled = openBook.bookmarks.Count > 0;
        }
    }
}
