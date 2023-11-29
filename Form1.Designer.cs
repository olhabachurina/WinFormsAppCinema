namespace WinFormsAppCinema
{
    partial class Form1
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
            selectedSeatsLabel = new Label();
            payButton = new Button();
            panel1 = new Panel();
            SeatButton = new Button();
            flowLayoutPanelSeats = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // selectedSeatsLabel
            // 
            selectedSeatsLabel.AutoSize = true;
            selectedSeatsLabel.Location = new Point(217, 40);
            selectedSeatsLabel.Name = "selectedSeatsLabel";
            selectedSeatsLabel.Size = new Size(0, 20);
            selectedSeatsLabel.TabIndex = 0;
            selectedSeatsLabel.Click += selectedSeatsLabel_Click;
            // 
            // payButton
            // 
            payButton.BackColor = Color.FromArgb(128, 255, 128);
            payButton.Location = new Point(694, 15);
            payButton.Name = "payButton";
            payButton.Size = new Size(94, 29);
            payButton.TabIndex = 1;
            payButton.Text = "оплатить";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(SeatButton);
            panel1.Controls.Add(selectedSeatsLabel);
            panel1.Controls.Add(payButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 2;
            // 
            // SeatButton
            // 
            SeatButton.Location = new Point(3, 0);
            SeatButton.Name = "SeatButton";
            SeatButton.Size = new Size(10, 29);
            SeatButton.TabIndex = 2;
            SeatButton.UseVisualStyleBackColor = true;
            SeatButton.Click += SeatButton_Click_1;
            // 
            // flowLayoutPanelSeats
            // 
            flowLayoutPanelSeats.Dock = DockStyle.Fill;
            flowLayoutPanelSeats.Location = new Point(0, 0);
            flowLayoutPanelSeats.Name = "flowLayoutPanelSeats";
            flowLayoutPanelSeats.Size = new Size(800, 325);
            flowLayoutPanelSeats.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelSeats);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label selectedSeatsLabel;
        private Button payButton;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelSeats;
        private Button SeatButton;
    }
}