namespace MasterDetail
{
    partial class MasterDetailView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            masterListBox = new UIElements.SeparatorListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            addMasterButton = new UIElements.RoundedButton();
            editMasterButton = new UIElements.RoundedButton();
            deleteMasterButton = new UIElements.RoundedButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            addDetailButton = new UIElements.RoundedButton();
            editDetailButton = new UIElements.RoundedButton();
            deleteDetailButton = new UIElements.RoundedButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            detailListBox = new UIElements.SeparatorListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            loadButton = new UIElements.RoundedButton();
            saveButton = new UIElements.RoundedButton();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(masterListBox, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(407, 365);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(211, 198, 170);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 36);
            label1.TabIndex = 0;
            label1.Text = "Концертные залы";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // masterListBox
            // 
            masterListBox.AutoAdjustItemHeight = true;
            masterListBox.BackColor = Color.FromArgb(52, 63, 68);
            masterListBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(masterListBox, 2);
            masterListBox.Dock = DockStyle.Fill;
            masterListBox.DrawMode = DrawMode.OwnerDrawVariable;
            masterListBox.Font = new Font("Segoe UI", 14F);
            masterListBox.ForeColor = Color.FromArgb(211, 198, 170);
            masterListBox.FormattingEnabled = true;
            masterListBox.ItemHeight = 25;
            masterListBox.Items.AddRange(new object[] { "123123123", "2312341234", "32445345" });
            masterListBox.Location = new Point(0, 36);
            masterListBox.Margin = new Padding(0);
            masterListBox.Name = "masterListBox";
            masterListBox.SeparatorColor = Color.FromArgb(80, 87, 93);
            masterListBox.SeparatorMargin = 2;
            masterListBox.SeparatorStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            masterListBox.SeparatorWidth = 2;
            masterListBox.Size = new Size(407, 329);
            masterListBox.TabIndex = 1;
            masterListBox.SelectedIndexChanged += OnMasterSelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(827, 464);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(addMasterButton, 0, 0);
            tableLayoutPanel6.Controls.Add(editMasterButton, 0, 0);
            tableLayoutPanel6.Controls.Add(deleteMasterButton, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 374);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(407, 40);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // addMasterButton
            // 
            addMasterButton.BackColor = Color.FromArgb(131, 192, 146);
            addMasterButton.BackgroundColor = Color.FromArgb(131, 192, 146);
            addMasterButton.BorderColor = Color.PaleVioletRed;
            addMasterButton.BorderRadius = 9;
            addMasterButton.BorderSize = 0;
            addMasterButton.Dock = DockStyle.Fill;
            addMasterButton.FlatAppearance.BorderSize = 0;
            addMasterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 141, 107);
            addMasterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(157, 230, 175);
            addMasterButton.FlatStyle = FlatStyle.Flat;
            addMasterButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMasterButton.ForeColor = Color.FromArgb(71, 102, 79);
            addMasterButton.Location = new Point(138, 3);
            addMasterButton.Name = "addMasterButton";
            addMasterButton.Size = new Size(129, 34);
            addMasterButton.TabIndex = 6;
            addMasterButton.Text = "+ Новая";
            addMasterButton.TextColor = Color.FromArgb(71, 102, 79);
            addMasterButton.UseVisualStyleBackColor = false;
            addMasterButton.Click += OnAddMasterButtonClick;
            // 
            // editMasterButton
            // 
            editMasterButton.BackColor = Color.FromArgb(219, 188, 127);
            editMasterButton.BackgroundColor = Color.FromArgb(219, 188, 127);
            editMasterButton.BorderColor = Color.PaleVioletRed;
            editMasterButton.BorderRadius = 9;
            editMasterButton.BorderSize = 0;
            editMasterButton.Dock = DockStyle.Fill;
            editMasterButton.FlatAppearance.BorderSize = 0;
            editMasterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(167, 144, 97);
            editMasterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 226, 147);
            editMasterButton.FlatStyle = FlatStyle.Flat;
            editMasterButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMasterButton.ForeColor = Color.FromArgb(124, 107, 74);
            editMasterButton.Location = new Point(3, 3);
            editMasterButton.Name = "editMasterButton";
            editMasterButton.Size = new Size(129, 34);
            editMasterButton.TabIndex = 4;
            editMasterButton.Text = "Изменить";
            editMasterButton.TextColor = Color.FromArgb(124, 107, 74);
            editMasterButton.UseVisualStyleBackColor = false;
            editMasterButton.Click += OnEditMasterButtonClick;
            // 
            // deleteMasterButton
            // 
            deleteMasterButton.BackColor = Color.FromArgb(230, 126, 128);
            deleteMasterButton.BackgroundColor = Color.FromArgb(230, 126, 128);
            deleteMasterButton.BorderColor = Color.PaleVioletRed;
            deleteMasterButton.BorderRadius = 9;
            deleteMasterButton.BorderSize = 0;
            deleteMasterButton.Dock = DockStyle.Fill;
            deleteMasterButton.FlatAppearance.BorderSize = 0;
            deleteMasterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(179, 98, 99);
            deleteMasterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 139, 139);
            deleteMasterButton.FlatStyle = FlatStyle.Flat;
            deleteMasterButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMasterButton.ForeColor = Color.FromArgb(132, 75, 76);
            deleteMasterButton.Location = new Point(273, 3);
            deleteMasterButton.Name = "deleteMasterButton";
            deleteMasterButton.Size = new Size(131, 34);
            deleteMasterButton.TabIndex = 5;
            deleteMasterButton.Text = "- Удалить";
            deleteMasterButton.TextColor = Color.FromArgb(132, 75, 76);
            deleteMasterButton.UseVisualStyleBackColor = false;
            deleteMasterButton.Click += OnDeleteMasterButtonClick;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(addDetailButton, 0, 0);
            tableLayoutPanel5.Controls.Add(editDetailButton, 0, 0);
            tableLayoutPanel5.Controls.Add(deleteDetailButton, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(416, 374);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(408, 40);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // addDetailButton
            // 
            addDetailButton.BackColor = Color.FromArgb(131, 192, 146);
            addDetailButton.BackgroundColor = Color.FromArgb(131, 192, 146);
            addDetailButton.BorderColor = Color.PaleVioletRed;
            addDetailButton.BorderRadius = 9;
            addDetailButton.BorderSize = 0;
            addDetailButton.Dock = DockStyle.Fill;
            addDetailButton.FlatAppearance.BorderSize = 0;
            addDetailButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 141, 107);
            addDetailButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(157, 230, 175);
            addDetailButton.FlatStyle = FlatStyle.Flat;
            addDetailButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDetailButton.ForeColor = Color.FromArgb(71, 102, 79);
            addDetailButton.Location = new Point(138, 3);
            addDetailButton.Name = "addDetailButton";
            addDetailButton.Size = new Size(129, 34);
            addDetailButton.TabIndex = 6;
            addDetailButton.Text = "+ Новая";
            addDetailButton.TextColor = Color.FromArgb(71, 102, 79);
            addDetailButton.UseVisualStyleBackColor = false;
            addDetailButton.Click += OnAddDetailButtonClick;
            // 
            // editDetailButton
            // 
            editDetailButton.BackColor = Color.FromArgb(219, 188, 127);
            editDetailButton.BackgroundColor = Color.FromArgb(219, 188, 127);
            editDetailButton.BorderColor = Color.PaleVioletRed;
            editDetailButton.BorderRadius = 9;
            editDetailButton.BorderSize = 0;
            editDetailButton.Dock = DockStyle.Fill;
            editDetailButton.FlatAppearance.BorderSize = 0;
            editDetailButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(167, 144, 97);
            editDetailButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 226, 147);
            editDetailButton.FlatStyle = FlatStyle.Flat;
            editDetailButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDetailButton.ForeColor = Color.FromArgb(124, 107, 74);
            editDetailButton.Location = new Point(3, 3);
            editDetailButton.Name = "editDetailButton";
            editDetailButton.Size = new Size(129, 34);
            editDetailButton.TabIndex = 4;
            editDetailButton.Text = "Изменить";
            editDetailButton.TextColor = Color.FromArgb(124, 107, 74);
            editDetailButton.UseVisualStyleBackColor = false;
            editDetailButton.Click += OnEditDetailButtonClick;
            // 
            // deleteDetailButton
            // 
            deleteDetailButton.BackColor = Color.FromArgb(230, 126, 128);
            deleteDetailButton.BackgroundColor = Color.FromArgb(230, 126, 128);
            deleteDetailButton.BorderColor = Color.PaleVioletRed;
            deleteDetailButton.BorderRadius = 9;
            deleteDetailButton.BorderSize = 0;
            deleteDetailButton.Dock = DockStyle.Fill;
            deleteDetailButton.FlatAppearance.BorderSize = 0;
            deleteDetailButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(179, 98, 99);
            deleteDetailButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 139, 139);
            deleteDetailButton.FlatStyle = FlatStyle.Flat;
            deleteDetailButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteDetailButton.ForeColor = Color.FromArgb(132, 75, 76);
            deleteDetailButton.Location = new Point(273, 3);
            deleteDetailButton.Name = "deleteDetailButton";
            deleteDetailButton.Size = new Size(132, 34);
            deleteDetailButton.TabIndex = 5;
            deleteDetailButton.Text = "- Удалить";
            deleteDetailButton.TextColor = Color.FromArgb(132, 75, 76);
            deleteDetailButton.UseVisualStyleBackColor = false;
            deleteDetailButton.Click += OnDeleteDetailButtonClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(detailListBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(416, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(408, 365);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(211, 198, 170);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 36);
            label2.TabIndex = 0;
            label2.Text = "Билеты";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // detailListBox
            // 
            detailListBox.AutoAdjustItemHeight = true;
            detailListBox.BackColor = Color.FromArgb(52, 63, 68);
            detailListBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(detailListBox, 2);
            detailListBox.Dock = DockStyle.Fill;
            detailListBox.DrawMode = DrawMode.OwnerDrawVariable;
            detailListBox.Font = new Font("Segoe UI", 14F);
            detailListBox.ForeColor = Color.FromArgb(211, 198, 170);
            detailListBox.FormattingEnabled = true;
            detailListBox.ItemHeight = 25;
            detailListBox.Items.AddRange(new object[] { "123123123", "2312341234", "32445345" });
            detailListBox.Location = new Point(0, 36);
            detailListBox.Margin = new Padding(0);
            detailListBox.Name = "detailListBox";
            detailListBox.SeparatorColor = Color.FromArgb(80, 87, 93);
            detailListBox.SeparatorMargin = 2;
            detailListBox.SeparatorStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            detailListBox.SeparatorWidth = 2;
            detailListBox.Size = new Size(408, 329);
            detailListBox.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(loadButton, 1, 0);
            tableLayoutPanel4.Controls.Add(saveButton, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 420);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(821, 41);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(211, 198, 170);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 41);
            label3.TabIndex = 2;
            label3.Text = "Файл";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.FromArgb(214, 153, 182);
            loadButton.BackgroundColor = Color.FromArgb(214, 153, 182);
            loadButton.BorderColor = Color.PaleVioletRed;
            loadButton.BorderRadius = 9;
            loadButton.BorderSize = 0;
            loadButton.Dock = DockStyle.Fill;
            loadButton.FlatAppearance.BorderSize = 0;
            loadButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(163, 116, 138);
            loadButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 180, 214);
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadButton.ForeColor = Color.FromArgb(120, 87, 103);
            loadButton.Location = new Point(126, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(342, 35);
            loadButton.TabIndex = 0;
            loadButton.Text = "Загрузить";
            loadButton.TextColor = Color.FromArgb(120, 87, 103);
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += OnLoadButtonClick;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(131, 192, 146);
            saveButton.BackgroundColor = Color.FromArgb(131, 192, 146);
            saveButton.BorderColor = Color.PaleVioletRed;
            saveButton.BorderRadius = 9;
            saveButton.BorderSize = 0;
            saveButton.Dock = DockStyle.Fill;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 141, 107);
            saveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(157, 230, 175);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.FromArgb(71, 102, 79);
            saveButton.Location = new Point(474, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(344, 35);
            saveButton.TabIndex = 1;
            saveButton.Text = "Сохранить";
            saveButton.TextColor = Color.FromArgb(71, 102, 79);
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += OnSaveButtonClick;
            // 
            // MasterDetailView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 53, 59);
            ClientSize = new Size(827, 464);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(843, 503);
            Name = "MasterDetailView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterDetail - Лабораторная 2";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private UIElements.SeparatorListBox masterListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private UIElements.SeparatorListBox detailListBox;
        private TableLayoutPanel tableLayoutPanel4;
        private UIElements.RoundedButton loadButton;
        private UIElements.RoundedButton saveButton;
        private TableLayoutPanel tableLayoutPanel5;
        private UIElements.RoundedButton editDetailButton;
        private Label label3;
        private UIElements.RoundedButton deleteDetailButton;
        private TableLayoutPanel tableLayoutPanel6;
        private UIElements.RoundedButton addMasterButton;
        private UIElements.RoundedButton editMasterButton;
        private UIElements.RoundedButton deleteMasterButton;
        private UIElements.RoundedButton addDetailButton;
    }
}
