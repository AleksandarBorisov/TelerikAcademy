using System;

class Matrix
{//Поле е една променлива дефинирана вътре в класа, която се изполва за представяне състоянието на обекта.
    //Това се нарича поле на класа.
    private int[,] matrix;//Private e модификатор за достъп, Ключовата дума Private показва че единствените методи, 
    //които могат да достъпват тази матрица са вътре в този клас, т. е. това поле е видимо само в този клас.

    public Matrix(int rows, int cols)
    {//Конструктора се използва за задаване на начално състояние на нашия обект от нашия клас
        this.matrix = new int[rows, cols];
    }//Всъщност конструктора казва че нашата матрица има тези размери


    public int Rows//Това е свойство(property). То е характеристика на обекта, който сме създали в нашия клас, която представя
    {//някаква част от състоянието на обекта или някаква негова спецификация. В нашия случай това са броя редове и потребителя има право да ѝ поставя някаква стойност ако имаме метод set
        get//метод, връща каква е стойността за полето, което използваме или за горната характеристика
        {
            return this.matrix.GetLength(0);//обектът this означава че използваме текущия обект от класа
        }//в нашия случай this е firstMatrix, this съдържа свойствата, полетата и методите за текущия обект от класа
        //Полето се състои от тези два метода (get и set)
    }

    public int Columns
    {
        get//Щом има само метод get, това означава че има стойност, която може само да се взема,  т. е.
        {//потребител от друг клас неможе да променя дименсиите на матрицата
            return this.matrix.GetLength(1);
        }

    }

    public static Matrix operator +(Matrix first, Matrix second)//Посочваме обектите, върху които ще се извършва операцията събиране
    {//Статичен метод се извършва върху две инстанции на нашия клас като независим от текущата инстанция на класа
     //т.е. той ще приема обекти от класа, в който е дефиниран и работи върху самия клас
     //За да извикаме статичен метод винаги първо трябва да извикаме класа, в който е дефиниран(Console.WriteLie, int.Parse...)
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] * second[row, col];
            }
        }
        return result;
    }

    public void FillMatrix()
    {
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                this.matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }

    public int this[int row, int col]//нямаме static, индексатора е инстанционен метод
    {//get ще връща int 
        get//Връща стойност
        {
            return this.matrix[row, col];
        }
        set//Задава стойност на такущия ред и такущата колона
        {
            this.matrix[row, col] = value;//value е ключова дума в C# която показва каква стойност сме задали за текущото свойство или индексатор в случая
        }
    }//Инстанционен метод, той работи върху текущата инстанция на класа, т.е. върху текущия обект

    public override string ToString()//override означава заменям старото поведение с ново (предефинирам) за текущия клас
    {//ToString е инстанционен метод
        string result = null;
        for (int row = 0; row < this.Rows; row++)//еквивалентно е на this.matrix.GetLength(0), защото това ни връща метода на пропъртито
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result += matrix[row, col] + " ";
            }
            result += Environment.NewLine;//Използваме свойството от статичния клас Environment, по-добре е от стандартното \r\n
        }
        return result;
    }
}



//Array.Sort(array) - типичен пример за статичен метод

//class Dog
//{
//    private int legs;//Това е поле, дефинират се с първа малка буква
//    //Полето е просто една променлива, която се използва вътре във класа
//    public int Legs//Това е property, дефинират се с първа главна буква
//    {
//        set//метод, който поставя стойност на текущото свойство, а get метода взема тази стойност,
//        {//затова без get метод неможем да вземем стойността на legs
//            this.legs = 4;//Важно е да извикаме полето, а не property-то, иначе става рекурсия
//        }
//    }
//}