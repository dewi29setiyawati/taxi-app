using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    class Taxi
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;
        string status;

        // fungsi untuk menampilkan info taxi
        public void TaxiInfo()
        {
            // menampilkan nama driver
            Console.WriteLine("Driver Name : " + DriverName); 

            // fungsi jika OnDuty true maka status berubah menjadi yes atau sebaliknya
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }

            // fungsi jika OnDuty true maka jumlah penumpang akan menjadi 10 atau jika false maka jumlah penumpang menjadi 0
            if (OnDuty == true)
            {
                NumPassenger = 10;
            }
            else
            {
                NumPassenger = 0;
            }

            // menampilkan status driver
            Console.WriteLine("On Duty : " + status);

            // menampilkan jumlah penumpang
            Console.WriteLine("Number of Passenger : " + NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine(DriverName + " sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine(DriverName + " sedang mengantar penumpang");
        }
    }

}