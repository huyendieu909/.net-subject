namespace bai_tap_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\source\file.txt";
            string targetPath = @"d:\target\file.txt";
            ///* 
            // Cách 1: dùng File //
            try
            {
                File.Copy(sourcePath, targetPath);
                Console.WriteLine("File copied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while copying the file: " + ex.Message);
            }
            //*/
            
            /*
            // Cách 2: Dùng StreamReader và StreamWriter //
            try
            {
                using (StreamReader streamReader = new StreamReader(sourcePath))
                {
                    using (StreamWriter streamWriter = new StreamWriter(targetPath))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            streamWriter.WriteLine(line);
                        }
                    }
                }
                Console.WriteLine("File copied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while copying the file: " + ex.Message);
            }
            */
        }
    }
}