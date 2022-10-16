// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[,] pic = new int[,]
{
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image) // метод задаем матрицу
{
    for (int i = 0; i < image.GetLength(0); i++) // столбцы
    {
        for (int j = 0; j < image.GetLength(1); j++) // столбцы
        {
            // Console.Write($"{image[i, j]}  ");
            if (image[i, j] == 0)
                Console.Write($"  "); // печатаем пробел
            else
                Console.Write($"+"); // печатаем плюс
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col) // метод закраски русунка
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col); //правило закраски накрест
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic); // печатаем картинку
FillImage(6,6);
PrintImage(pic);
