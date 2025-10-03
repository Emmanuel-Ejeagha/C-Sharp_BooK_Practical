using System;

namespace Chpt24SampleProgrammingExamTopic_1;

public class Maze
{
    public const string InputFileName = "./Labyrinth/Problem2.in";
    public const string OutputFileName = "./Labyrinth/Problem2.out";

    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Distance { get; set; }


        public Cell(int row, int column, int distance)
        {
            Row = row;
            Column = column;
            Distance = distance;
        }
    }


    private char[,] maze;
    private int size;
    private Cell startCell = null;

    public void ReadFromFile(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            // Read the maze size and create the maze
            this.size = int.Parse(reader.ReadLine());
            this.maze = new char[size, size];

            // Read the maze cells from the file
            for (int row = 0; row < this.size; row++)
            {
                string line = reader.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    this.maze[row, col] = line[col];
                    if (line[col] == '*')
                    {
                        startCell = new Cell(row, col, 0);
                    }
                }
            }
        }
    }


    public int FindShortestPath()
    {
        if (this.startCell == null)
        {
            // Start cell is missing -> no path
            return -1;
        }

        // Queue for traversing the cells in the maze
        Queue<Cell> visitedCells = new Queue<Cell>();
        VisitCell(visitedCells, startCell.Row, startCell.Column, 0);

        // Perform Breath-First Search (BFS)
        while (visitedCells.Count > 0)
        {
            Cell currentCell = visitedCells.Dequeue();
            int row = currentCell.Row;
            int column = currentCell.Column;
            int distance = currentCell.Distance;
            if ((row == 0) || (row == size - 1)
            || (column == 0) || (column == size - 1))
            {
                // We are at the maze border
                return distance + 1;
            }
            VisitCell(visitedCells, row, column + 1, distance + 1);
            VisitCell(visitedCells, row, column - 1, distance + 1);
            VisitCell(visitedCells, row + 1, column, distance + 1);
            VisitCell(visitedCells, row - 1, column, distance + 1);
        }

        // We didn't reach any cell at the maze border -> no path
        return -1;
    }

    private void VisitCell(Queue<Cell> visitedCells,
        int row, int column, int distance)
    {
        if (maze[row, column] != 'x')
        {
            // The cell is free --> visit it
            maze[row, column] = 'x';
            Cell cell = new Cell(row, column, distance);
            visitedCells.Enqueue(cell);
        }
    }

    public void SaveResult(string fileName, int result)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(result);
        }
    }
}
