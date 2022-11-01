
// See https://aka.ms/new-console-template for more information

            try
            {
                Console.WriteLine("sayi ; ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            }
            catch(Exception error)
            {
                 Console.WriteLine(error.Message.ToString());
            }
            finally
            {
                 Console.WriteLine("finally");
            }

            try
            {
                int a = int.Parse(null);
                
            }
            catch (ArgumentException ex)
            {
                
                 Console.WriteLine("Null");
                  Console.WriteLine(ex);
            }