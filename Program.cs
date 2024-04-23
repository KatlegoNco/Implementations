
using System;

interface IStorable
{
    void Store();

    void Read();
}

interface ICompressible
{
    void Compress();

    void LogOriginalSize();

    void LogSavedBytes();
}
interface IEncryptable
{
    void Encrypt();
}
class Document : IStorable, ICompressible, IEncryptable
{
    public void Store()
    {
        Console.WriteLine("Document stored.");
    }
    public void Read()
    {
        Console.WriteLine("Document read.");
    }
    public void Compress()
    {
        Console.WriteLine("Document compressed.");
    }
    public void LogOriginalSize()
    {
        Console.WriteLine("Original size logged.");
    }
    public void LogSavedBytes()
    {
        Console.WriteLine("Saved bytes logged.");
    }
    public void Encrypt()
    {
        Console.WriteLine("Document encrypted.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();
        // Storing document
        document.Store();
        // Reading document
        document.Read();
        // Compressing document
        document.Compress();
        document.LogOriginalSize();
        document.LogSavedBytes();
        // Encrypting document
        document.Encrypt();
    }
}