﻿namespace MasterDetail
{
    partial class TicketEditView
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
            priceTextBox = new CustomControls.RJControls.RJTextBox();
            placeTextBox = new CustomControls.RJControls.RJTextBox();
            numberTextBox = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            previewLabel = new Label();
            saveButton = new UIElements.RoundedButton();
            eventTextBox = new CustomControls.RJControls.RJTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tableLayoutPanel1.Controls.Add(priceTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(placeTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(numberTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(previewLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 0, 5);
            tableLayoutPanel1.Controls.Add(eventTextBox, 1, 2);
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
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceTextBox.BackColor = Color.FromArgb(35, 42, 46);
            priceTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            priceTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            priceTextBox.BorderSize = 6;
            priceTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            priceTextBox.Location = new Point(188, 323);
            priceTextBox.Margin = new Padding(4, 4, 15, 4);
            priceTextBox.Multiline = false;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Padding = new Padding(7);
            priceTextBox.PasswordChar = false;
            priceTextBox.PlaceHolder = "Цена билета";
            priceTextBox.Size = new Size(597, 45);
            priceTextBox.TabIndex = 12;
            priceTextBox.Texts = "";
            priceTextBox.UnderlinedStyle = true;
            // 
            // placeTextBox
            // 
            placeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            placeTextBox.BackColor = Color.FromArgb(35, 42, 46);
            placeTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            placeTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            placeTextBox.BorderSize = 6;
            placeTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            placeTextBox.Location = new Point(188, 233);
            placeTextBox.Margin = new Padding(4, 4, 15, 4);
            placeTextBox.Multiline = false;
            placeTextBox.Name = "placeTextBox";
            placeTextBox.Padding = new Padding(7);
            placeTextBox.PasswordChar = false;
            placeTextBox.PlaceHolder = "Место проведения";
            placeTextBox.Size = new Size(597, 45);
            placeTextBox.TabIndex = 11;
            placeTextBox.Texts = "";
            placeTextBox.UnderlinedStyle = true;
            // 
            // numberTextBox
            // 
            numberTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numberTextBox.BackColor = Color.FromArgb(35, 42, 46);
            numberTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            numberTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            numberTextBox.BorderSize = 6;
            numberTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            numberTextBox.Location = new Point(188, 53);
            numberTextBox.Margin = new Padding(4, 4, 15, 4);
            numberTextBox.Multiline = false;
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Padding = new Padding(7);
            numberTextBox.PasswordChar = false;
            numberTextBox.PlaceHolder = "Номер билета";
            numberTextBox.Size = new Size(597, 45);
            numberTextBox.TabIndex = 10;
            numberTextBox.Texts = "";
            numberTextBox.UnderlinedStyle = true;
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
            label1.Text = "Номер:";
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
            label2.Text = "Мероприятие:";
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
            label3.Text = "Место:";
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
            label4.Text = "Цена:";
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
            previewLabel.Text = "Билет:";
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
            saveButton.Click += OnSaveButtonCLick;
            // 
            // eventTextBox
            // 
            eventTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eventTextBox.BackColor = Color.FromArgb(35, 42, 46);
            eventTextBox.BorderColor = Color.FromArgb(52, 63, 68);
            eventTextBox.BorderFocusColor = Color.FromArgb(52, 63, 68);
            eventTextBox.BorderSize = 6;
            eventTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventTextBox.ForeColor = Color.FromArgb(211, 198, 170);
            eventTextBox.Location = new Point(188, 143);
            eventTextBox.Margin = new Padding(4, 4, 15, 4);
            eventTextBox.Multiline = false;
            eventTextBox.Name = "eventTextBox";
            eventTextBox.Padding = new Padding(7);
            eventTextBox.PasswordChar = false;
            eventTextBox.PlaceHolder = "Название мероприятия";
            eventTextBox.Size = new Size(597, 45);
            eventTextBox.TabIndex = 9;
            eventTextBox.Texts = "";
            eventTextBox.UnderlinedStyle = true;
            // 
            // TicketEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 53, 59);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(816, 489);
            Name = "TicketEditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailEditView";
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
        private CustomControls.RJControls.RJTextBox eventTextBox;
        private CustomControls.RJControls.RJTextBox priceTextBox;
        private CustomControls.RJControls.RJTextBox placeTextBox;
        private CustomControls.RJControls.RJTextBox numberTextBox;
    }
}