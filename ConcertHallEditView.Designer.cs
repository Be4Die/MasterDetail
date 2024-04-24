namespace MasterDetail
{
    partial class ConcertHallEditView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            openingDateTextBox = new CustomControls.RJControls.RJTextBox();
            capacityTextBox = new CustomControls.RJControls.RJTextBox();
            nameTextBox = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            previewLabel = new Label();
            saveButton = new UIElements.RoundedButton();
            addressTextBox = new CustomControls.RJControls.RJTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel1.Controls.Add(openingDateTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(capacityTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(nameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(previewLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 0, 5);
            tableLayoutPanel1.Controls.Add(addressTextBox, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // openingDateTextBox
            // 
            openingDateTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            openingDateTextBox.BackColor = Color.FromArgb(35, 42, 46);
            openingDateTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            openingDateTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            openingDateTextBox.BorderSize = 6;
            openingDateTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openingDateTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            openingDateTextBox.Location = new Point(188, 323);
            openingDateTextBox.Margin = new Padding(4, 4, 15, 4);
            openingDateTextBox.Multiline = false;
            openingDateTextBox.Name = "openingDateTextBox";
            openingDateTextBox.Padding = new Padding(7);
            openingDateTextBox.PasswordChar = false;
            openingDateTextBox.PlaceHolder = "Дата (DD.MM.YYYY)";
            openingDateTextBox.Size = new Size(597, 45);
            openingDateTextBox.TabIndex = 12;
            openingDateTextBox.Texts = "";
            openingDateTextBox.UnderlinedStyle = true;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            capacityTextBox.BackColor = Color.FromArgb(35, 42, 46);
            capacityTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            capacityTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            capacityTextBox.BorderSize = 6;
            capacityTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            capacityTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            capacityTextBox.Location = new Point(188, 233);
            capacityTextBox.Margin = new Padding(4, 4, 15, 4);
            capacityTextBox.Multiline = false;
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Padding = new Padding(7);
            capacityTextBox.PasswordChar = false;
            capacityTextBox.PlaceHolder = "Вместимость (чел.)";
            capacityTextBox.Size = new Size(597, 45);
            capacityTextBox.TabIndex = 11;
            capacityTextBox.Texts = "";
            capacityTextBox.UnderlinedStyle = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.FromArgb(35, 42, 46);
            nameTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            nameTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            nameTextBox.BorderSize = 6;
            nameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            nameTextBox.Location = new Point(188, 53);
            nameTextBox.Margin = new Padding(4, 4, 15, 4);
            nameTextBox.Multiline = false;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Padding = new Padding(7);
            nameTextBox.PasswordChar = false;
            nameTextBox.PlaceHolder = "Наименование";
            nameTextBox.Size = new Size(597, 45);
            nameTextBox.TabIndex = 10;
            nameTextBox.Texts = "";
            nameTextBox.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(211, 198, 170);
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(178, 90);
            label1.TabIndex = 4;
            label1.Text = "Название:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(211, 198, 170);
            label2.Location = new Point(3, 121);
            label2.Name = "label2";
            label2.Size = new Size(178, 90);
            label2.TabIndex = 5;
            label2.Text = "Адрес:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(211, 198, 170);
            label3.Location = new Point(3, 211);
            label3.Name = "label3";
            label3.Size = new Size(178, 90);
            label3.TabIndex = 6;
            label3.Text = "Вместимость:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(211, 198, 170);
            label4.Location = new Point(3, 301);
            label4.Name = "label4";
            label4.Size = new Size(178, 90);
            label4.TabIndex = 7;
            label4.Text = "Год открытия:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(previewLabel, 2);
            previewLabel.Dock = DockStyle.Fill;
            previewLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previewLabel.ForeColor = Color.FromArgb(211, 198, 170);
            previewLabel.Location = new Point(3, 0);
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new Size(794, 31);
            previewLabel.TabIndex = 3;
            previewLabel.Text = "Концертный зал:";
            previewLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(131, 192, 146);
            saveButton.BackgroundColor = Color.FromArgb(131, 192, 146);
            saveButton.BorderColor = Color.PaleVioletRed;
            saveButton.BorderRadius = 10;
            saveButton.BorderSize = 0;
            tableLayoutPanel1.SetColumnSpan(saveButton, 2);
            saveButton.Dock = DockStyle.Fill;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 141, 107);
            saveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(157, 230, 175);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.FromArgb(71, 102, 79);
            saveButton.Location = new Point(3, 394);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(794, 53);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранить";
            saveButton.TextColor = Color.FromArgb(71, 102, 79);
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += OnSaveButtonClick;
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.BackColor = Color.FromArgb(35, 42, 46);
            addressTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            addressTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            addressTextBox.BorderSize = 6;
            addressTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            addressTextBox.Location = new Point(188, 143);
            addressTextBox.Margin = new Padding(4, 4, 15, 4);
            addressTextBox.Multiline = false;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Padding = new Padding(7);
            addressTextBox.PasswordChar = false;
            addressTextBox.PlaceHolder = "Адрес";
            addressTextBox.Size = new Size(597, 45);
            addressTextBox.TabIndex = 9;
            addressTextBox.Texts = "";
            addressTextBox.UnderlinedStyle = true;
            // 
            // ConcertHallEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 53, 59);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(816, 489);
            Name = "ConcertHallEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование концертного зала";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label previewLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private UIElements.RoundedButton saveButton;
        private CustomControls.RJControls.RJTextBox addressTextBox;
        private CustomControls.RJControls.RJTextBox openingDateTextBox;
        private CustomControls.RJControls.RJTextBox capacityTextBox;
        private CustomControls.RJControls.RJTextBox nameTextBox;
    }
}