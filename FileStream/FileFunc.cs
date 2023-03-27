using System.Text;

namespace FileFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {

                FileStream file = new FileStream("C:\\Users\\priya\\Documents\\File handling demo\\demofile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                string str = "File context is written usinf FileStream";
                //file.Write(Convert.FromBase64String("This is some text!"));
                file.WriteByte(66);
                Stream stream = new MemoryStream();
                String strText = "This is a String that needs to be convert in stream";
                byte[] byteArray = Encoding.UTF8.GetBytes(strText);
                file.Write(byteArray);

                file.Close();
                var p = "C:\\Users\\priya\\Documents\\File handling demo\\demofile.txt";
                File.AppendAllText(p, "This is Me! Priya");

        }
    }
}
        
