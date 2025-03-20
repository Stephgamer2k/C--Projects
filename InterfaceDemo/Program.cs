namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<iPayable> payables = new List<iPayable>();
            List<IReport> reports = new List<IReport>();
            //try catch
            //evertything you want to happen is in the try block
            try
            {
                reports.Add(new Consultant(500, 6));
                reports.Add(new Intern("Joe",45,2000));

                foreach (IReport report in reports)
                {
                    if(report is Consultant consultant)
                    {
                        consultant.DisplayReport();
                    }
                    if (report is Intern intern)
                    {
                        intern.DisplayReport();
                    }
                    Console.WriteLine($"Calculated pay: {report.CalculatePay():C}\n");


                }

                payables.Add(new FullTimeEmployee("Joe", 45, 60000));
                payables.Add(new FullTimeEmployee("Joe", 45, 60000));

                payables.Add(new Vendor("Joe", 60000));
                payables.Add(new Vendor("Joey", 200000000));


                foreach (iPayable payable in payables)
                {
                    if (payable is Employee employee)
                    {
                        employee.DisplayInfo();
                    }
                    if (payable is Vendor vendor)
                    {
                        vendor.DisplayVendorInfo();
                    }
                    Console.WriteLine($"Calculated Pay: {payable.CalculatePay():C}\n");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


        }
    }
}
