namespace DesignPatterns.Prototype
{
    public abstract class ExcelCell
    {
        public ExcelCell Clone() => (ExcelCell)this.MemberwiseClone();
        public bool IsItalic { get; set; }

        public bool ISBold { get; set; }

        public CellType CellType { get; set; } = CellType.NormalString;
    }
}
