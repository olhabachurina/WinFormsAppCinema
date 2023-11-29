using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCinema
{
    public partial class PaymentForm : Form
    {
        private List<string> selectedSeats;
        private decimal totalAmount;
        public PaymentForm(List<string> selectedSeats, decimal totalAmount)
        {
            InitializeComponent();
            this.selectedSeats = selectedSeats;
            this.totalAmount = totalAmount;

            UpdatePaymentInfo();
            InitializePaymentTypes();
            this.FormClosing += PaymentForm_FormClosing;
        }

        private void InitializePaymentTypes()
        {
            // Добавим типы оплаты в ComboBox
            paymentTypeComboBox.Items.Add("Наличные");
            paymentTypeComboBox.Items.Add("Карта");
            paymentTypeComboBox.Items.Add("Безналичный перевод");
            paymentTypeComboBox.SelectedIndex = 0; // Установим первый элемент по умолчанию
        }

        private void UpdatePaymentInfo()
        {
            selectedSeatsLabel.Text = "Выбранные места: " + string.Join(", ", selectedSeats);
            totalAmountLabel.Text = "Общая сумма: $" + totalAmount.ToString("0.00");
        }


        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите отменить оплату?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Отменяем закрытие формы
            }
        }

        private void confirmPaymentButton_Click_1(object sender, EventArgs e)
        {
            string paymentType = paymentTypeComboBox.Text;
            MessageBox.Show($"Оплата проведена успешно!\nТип оплаты: {paymentType}\nСпасибо за покупку!");
            this.DialogResult = DialogResult.OK; // Закрываем форму оплаты
            this.Close();
        }
    }
}
