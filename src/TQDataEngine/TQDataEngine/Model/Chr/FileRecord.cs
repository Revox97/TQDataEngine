namespace TQDataEngine.Model.Chr
{
    internal class FileRecord
    {
        public string Key { get; set; } = string.Empty;
        public ChrRecordType Type { get; set; }
        public object? Value { get; set; } = null;
        public List<FileRecord> Children = [];
        public int KeyStart { get; set; }
        public int KeyEnd { get; set; }
        public int ValueStart { get; set; }
        public int ValueEnd { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        public long Length => End - Start;
        public long KeyLength => KeyEnd - KeyStart;
        public long ValueLength => ValueEnd - ValueStart;
    }
}
