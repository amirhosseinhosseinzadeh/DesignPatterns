using static System.Console;
using System.Collections.Generic;
using DesignPatterns.Prototype;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // var cell = new Cell();
            // cell.CellType = CellType.Date;
            // var cell2 = cell;
            // cell2.CellType = CellType.NormalString;

            // WriteLine("The cell 1 cell type is {0} \n The cell 2 cell type is {1}",
            //     cell.CellType.ToString(), // The cell 1 cell type is NormalString
            //     cell2.CellType.ToString() // The cell 2 cell type is NormalString
            // );
            //---------------------------------------------------------
            var cell1 = new Cell();
            cell1.IsItalic = true;
            cell1.ISBold = false;
            cell1.CellType = CellType.Numeric;
            var cell2 = (Cell)cell1.Clone();
            cell2.CellType = CellType.NormalString;
            var cells = new List<Cell>(new Cell[] { cell1, cell2 });
            for (var i = 0; i < cells.Count; i++)
            {
                WriteLine(i);
                var currentCell = cells[i];
                WriteLine(currentCell.CellType.ToString());
                WriteLine(currentCell.ISBold);
                WriteLine(currentCell.IsItalic);
                WriteLine("-------------------------------------------------------");
            }
        }
    }
}
