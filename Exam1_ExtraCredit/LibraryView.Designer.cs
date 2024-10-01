namespace Exam1_ExtraCredit {
    partial class LibraryView {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            OpenButton = new Button();
            LibList = new ListBox();
            label1 = new Label();
            SyncButton = new Button();
            SuspendLayout();
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(139, 350);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(126, 44);
            OpenButton.TabIndex = 0;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // LibList
            // 
            LibList.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LibList.FormattingEnabled = true;
            LibList.ItemHeight = 23;
            LibList.Location = new Point(78, 70);
            LibList.Name = "LibList";
            LibList.Size = new Size(495, 257);
            LibList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 26);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 2;
            label1.Text = "Mini-Kindle Library";
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(380, 350);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(126, 44);
            SyncButton.TabIndex = 3;
            SyncButton.Text = "Sync";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButton_Click;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 408);
            Controls.Add(SyncButton);
            Controls.Add(label1);
            Controls.Add(LibList);
            Controls.Add(OpenButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(683, 447);
            Name = "LibraryView";
            Text = "Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenButton;
        private ListBox LibList;
        private Label label1;
        private Button SyncButton;
    }
}
