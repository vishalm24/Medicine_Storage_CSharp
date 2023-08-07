namespace Medicine_Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../../medicines.txt";
            /*It's relative path. You can find medicines.txt in project folder"Medicnine Storage"*/
            if (File.Exists(path))
            {
                string[] readText = File.ReadAllLines(path);
                MedicalStore medStore = new MedicalStore();
                List<Medicine> medicines = medStore.GetMedicines(readText);
                Console.WriteLine("ID, Med Name, Med Price, Med Quantity");
                foreach (Medicine med in medicines)
                {
                    Console.WriteLine(med.ToString());
                }
                double totalAmount = medStore.GetPurchaseAmount();
                Console.WriteLine("Total money to purchase medicines = INR "+totalAmount+"/-");
            }
            else
            {
                Console.WriteLine("File not found...:(");
            }
        }
    }
}