using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCinema
{
    public class SeatInfo
    {
        public int RowNumber { get; }
        public int SeatNumber { get; }
        public bool IsAvailable { get; set; }
        public bool IsSelected { get; set; }

        public SeatInfo(int rowNumber, int seatNumber, bool isAvailable)
        {
            RowNumber = rowNumber;
            SeatNumber = seatNumber;
            IsAvailable = isAvailable;
            IsSelected = false;
        }

        public override string ToString()
        {
            return $"Row {RowNumber}, Seat {SeatNumber}";
        }
    }
}

