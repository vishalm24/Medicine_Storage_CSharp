using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_Storage
{
    internal class MedicalStore
    {

        private List<Medicine> medicines = new List<Medicine>();
        public List<Medicine> GetMedicines(string[] readText)
        {
            int i = 0;
            foreach (var line in readText)
            {
                string[] List = line.Split(",");
                medicines.Add(new Medicine());
                medicines[i].id = Int32.Parse(List[0]);
                medicines[i].name = List[1];
                medicines[i].amount = Double.Parse(List[2]);
                medicines[i].quantity = Int32.Parse(List[3]);
                i++;
            }
            if (i == 0)
            {
                throw new NoMedicineFoundException("There is no data available inside file...:(");
            }
            return medicines;
        }
        public double GetPurchaseAmount()
        {
            double totalAmount=0;
            int i = 0;
            Boolean flag = false;
            foreach (Medicine meds in medicines)
            {
                if (medicines[i].quantity <= 20 || medicines[i].amount < 500)
                {
                    totalAmount += medicines[i].amount * (20 - medicines[i].quantity + 1);
                    flag = true;
                }
                i++;

            }
            if (flag==false)
            {
                throw new NoMedicineFoundException("No medicines to order at present...:(");
            }
            return totalAmount;
        }

    }
}
