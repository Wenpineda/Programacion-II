

//las tres partes de un LINQ Query
//1.Data Source (Fuente de datos)
int[] numbers = new int [7]{ 0, 1 ,2, 3, 4, 5, 6,};

//2.Query Creation (Creacion de consultas)
//numQuery es un Ienumerable<int>
var numQuery = 
    from num in numbers
    where (num % 2) == 0
    select num;

//3.Query execution (Ejecucion de consultas)
foreach (int num in numQuery)
{
    Console.Write(" {0,1} ", num);
}