namespace Exam1_ExtraCredit {
    partial class BookView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            NextButton = new Button();
            PrevButton = new Button();
            announcelabel = new Label();
            BookTitleLabel = new Label();
            PagePlaceLabel = new Label();
            label3 = new Label();
            BMBox = new ListBox();
            AddBMButton = new Button();
            RemoveBMButton = new Button();
            GoPageBox = new TextBox();
            JumpButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.Location = new Point(220, 233);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(75, 23);
            NextButton.TabIndex = 0;
            NextButton.Text = "Next  >>";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // PrevButton
            // 
            PrevButton.Location = new Point(73, 233);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(75, 23);
            PrevButton.TabIndex = 1;
            PrevButton.Text = "<< Prev";
            PrevButton.UseVisualStyleBackColor = true;
            PrevButton.Click += PrevButton_Click;
            // 
            // announcelabel
            // 
            announcelabel.AutoSize = true;
            announcelabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcelabel.Location = new Point(12, 9);
            announcelabel.Name = "announcelabel";
            announcelabel.Size = new Size(163, 30);
            announcelabel.TabIndex = 2;
            announcelabel.Text = "You are reading:";
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.AutoSize = true;
            BookTitleLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookTitleLabel.Location = new Point(83, 77);
            BookTitleLabel.MaximumSize = new Size(250, 0);
            BookTitleLabel.MinimumSize = new Size(100, 100);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new Size(124, 100);
            BookTitleLabel.TabIndex = 3;
            BookTitleLabel.Text = "[Title Here]";
            BookTitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PagePlaceLabel
            // 
            PagePlaceLabel.AutoSize = true;
            PagePlaceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PagePlaceLabel.Location = new Point(83, 166);
            PagePlaceLabel.Name = "PagePlaceLabel";
            PagePlaceLabel.Size = new Size(129, 21);
            PagePlaceLabel.TabIndex = 4;
            PagePlaceLabel.Text = "[page place here]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(369, 48);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 5;
            label3.Text = "Your Bookmarks...";
            // 
            // BMBox
            // 
            BMBox.FormattingEnabled = true;
            BMBox.ItemHeight = 15;
            BMBox.Location = new Point(370, 77);
            BMBox.Name = "BMBox";
            BMBox.Size = new Size(132, 124);
            BMBox.TabIndex = 6;
            // 
            // AddBMButton
            // 
            AddBMButton.Location = new Point(369, 220);
            AddBMButton.Name = "AddBMButton";
            AddBMButton.Size = new Size(59, 23);
            AddBMButton.TabIndex = 7;
            AddBMButton.Text = "Add";
            AddBMButton.UseVisualStyleBackColor = true;
            AddBMButton.Click += AddBMButton_Click;
            // 
            // RemoveBMButton
            // 
            RemoveBMButton.Location = new Point(438, 220);
            RemoveBMButton.Name = "RemoveBMButton";
            RemoveBMButton.Size = new Size(64, 23);
            RemoveBMButton.TabIndex = 8;
            RemoveBMButton.Text = "Remove";
            RemoveBMButton.UseVisualStyleBackColor = true;
            RemoveBMButton.Click += RemoveBMButton_Click;
            // 
            // GoPageBox
            // 
            GoPageBox.Location = new Point(247, 332);
            GoPageBox.Name = "GoPageBox";
            GoPageBox.Size = new Size(94, 23);
            GoPageBox.TabIndex = 9;
            // 
            // JumpButton
            // 
            JumpButton.Location = new Point(370, 332);
            JumpButton.Name = "JumpButton";
            JumpButton.Size = new Size(75, 23);
            JumpButton.TabIndex = 10;
            JumpButton.Text = "Go! ";
            JumpButton.UseVisualStyleBackColor = true;
            JumpButton.Click += JumpButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 332);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 11;
            label4.Text = "Jump to page...";
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 379);
            Controls.Add(label4);
            Controls.Add(JumpButton);
            Controls.Add(GoPageBox);
            Controls.Add(RemoveBMButton);
            Controls.Add(AddBMButton);
            Controls.Add(BMBox);
            Controls.Add(label3);
            Controls.Add(PagePlaceLabel);
            Controls.Add(BookTitleLabel);
            Controls.Add(announcelabel);
            Controls.Add(PrevButton);
            Controls.Add(NextButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(590, 418);
            Name = "BookView";
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NextButton;
        private Button PrevButton;
        private Label announcelabel;
        private Label BookTitleLabel;
        private Label PagePlaceLabel;
        private Label label3;
        private ListBox BMBox;
        private Button AddBMButton;
        private Button RemoveBMButton;
        private TextBox GoPageBox;
        private Button JumpButton;
        private Label label4;
    }
}