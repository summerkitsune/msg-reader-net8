namespace net8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var fs = System.IO.File.Open("testmessage.msg", FileMode.Open))
            {
                using (var b = new BinaryReader(fs))
                {
                    byte[] blob = b.ReadBytes((int)fs.Length);
                    using (var msg = new MsgReader.Outlook.Storage.Message(new MemoryStream(blob)))
                    {
                        Console.WriteLine(msg.Subject);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
