namespace TQDataEngine.Contracts
{
    internal interface IFileParser
    {
        // Todo Find correct and unified return type
        object Parse(string path);
    }
}
