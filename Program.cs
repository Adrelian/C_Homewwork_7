void CreatAndShowArray(int rows, int columns)  
{      
    // Инициализация массива
    int[,] newArray = new int[rows, columns];  
    
    if( rows > 0 && columns > 0)
    {
        // создание массива
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
            newArray[i,j] = new Random().Next(1, 11);
            }
        }

        // Отображение массива
        for(int i = 0; i < rows ;i++ ) 
            {
                for(int j = 0; j < columns; j++)  
                {
                Console.Write(newArray[i,j] + " ");
                }
                Console.WriteLine(); 
            }
    }
    else Console.WriteLine("Ошибка ввода данных");
}

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

CreatAndShowArray(rows, columns);