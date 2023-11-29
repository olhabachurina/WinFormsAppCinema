namespace WinFormsAppCinema
{
    partial class PaymentForm
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
            selectedSeatsLabel = new Label();
            paymentTypeComboBox = new ComboBox();
            totalAmountLabel = new Label();
            confirmPaymentButton = new Button();
            SuspendLayout();
            // 
            // selectedSeatsLabel
            // 
            selectedSeatsLabel.AutoSize = true;
            selectedSeatsLabel.Location = new Point(403, 126);
            selectedSeatsLabel.Name = "selectedSeatsLabel";
            selectedSeatsLabel.Size = new Size(50, 20);
            selectedSeatsLabel.TabIndex = 0;
            selectedSeatsLabel.Text = "label1";
            // 
            // paymentTypeComboBox
            // 
            paymentTypeComboBox.FormattingEnabled = true;
            paymentTypeComboBox.Location = new Point(353, 223);
            paymentTypeComboBox.Name = "paymentTypeComboBox";
            paymentTypeComboBox.Size = new Size(151, 28);
            paymentTypeComboBox.TabIndex = 1;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new Point(353, 322);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(50, 20);
            totalAmountLabel.TabIndex = 2;
            totalAmountLabel.Text = "label2";
            // 
            // confirmPaymentButton
            // 
            confirmPaymentButton.BackColor = Color.FromArgb(128, 255, 128);
            confirmPaymentButton.Location = new Point(495, 338);
            confirmPaymentButton.Name = "confirmPaymentButton";
            confirmPaymentButton.Size = new Size(94, 29);
            confirmPaymentButton.TabIndex = 3;
            confirmPaymentButton.Text = "оплатить";
            confirmPaymentButton.UseVisualStyleBackColor = false;
            confirmPaymentButton.Click += confirmPaymentButton_Click_1;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmPaymentButton);
            Controls.Add(totalAmountLabel);
            Controls.Add(paymentTypeComboBox);
            Controls.Add(selectedSeatsLabel);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectedSeatsLabel;
        private ComboBox paymentTypeComboBox;
        private Label totalAmountLabel;
        private Button confirmPaymentButton;
    }
}