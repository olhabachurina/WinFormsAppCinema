using System.Globalization;

namespace WinFormsAppCinema
{
    public partial class Form1 : Form
    {
        private List<string> selectedSeats = new List<string>();
        public Form1()
        {
            InitializeComponent();
            CreateSeatButtons();
        }

        private void CreateSeatButtons()
        {
            int rows = 10; 
            int seatsPerRow = 10; 

            for (int row = 1; row <= rows; row++)
            {
                for (int seat = 1; seat <= seatsPerRow; seat++)
                {
                    Button seatButton = new Button();
                    SeatInfo seatInfo = new SeatInfo(row, seat, isAvailable: true);

                    seatButton.Text = $"��� {row}, ����� {seat}";
                    seatButton.Tag = seatInfo; 
                    seatButton.Click += SeatButton_Click_1;
                    flowLayoutPanelSeats.Controls.Add(seatButton);
                }
            }

            UpdateSeatColors(); 
        }




        private void UpdateSelectedSeatsLabel()
        {
            selectedSeatsLabel.Text = "��������� �����: " + string.Join(", ", selectedSeats);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {
                PaymentForm paymentForm = new PaymentForm(selectedSeats, CalculateTotalAmount());
                paymentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("�������� ����� ����� �������.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private decimal CalculateTotalAmount()
        {
           
            return selectedSeats.Count * 150; 
        }
        private void UpdateSeatColors()
        {
            foreach (Control control in flowLayoutPanelSeats.Controls)
            {
                if (control is Button seatButton && seatButton.Tag is SeatInfo seatInfo)
                {
                    if (seatInfo.IsAvailable)
                    {
                        // ��������� ����� ����� ������-������ �����
                        seatButton.BackColor = SystemColors.ControlLight;
                    }
                    else if (seatInfo.IsSelected)
                    {
                        // ��������� ����� ����� �������� �����
                        seatButton.BackColor = Color.Red;
                    }
                    else
                    {
                        // ��������� ����� (�������, �� �� ���������) ����� ����� ���� �� ���������
                        seatButton.BackColor = SystemColors.Control;
                    }
                }
            }
        }



        private void selectedSeatsLabel_Click(object sender, EventArgs e)
        {
        }

        private void SeatButton_Click_1(object sender, EventArgs e)
        {
            if (sender is Button seatButton && seatButton.Tag is SeatInfo seatInfo)
            {
                if (seatInfo.IsAvailable && !seatInfo.IsSelected)
                {
                    seatInfo.IsSelected = true;
                    selectedSeats.Add(seatButton.Text); // ���������� ���������� ����� � ������
                }
                else if (seatInfo.IsSelected)
                {
                    seatInfo.IsSelected = false;
                    selectedSeats.Remove(seatButton.Text); // �������� ���������� ����� �� ������
                }

                UpdateSeatColors(); // ���������� ������ ����� ��������� ��������� ����
                UpdateSelectedSeatsLabel(); // ���������� ����������� ��������� ����
            }
        }
    }
}