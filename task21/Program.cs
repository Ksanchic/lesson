//  программа, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3 Dпространстве

{
double ab =0;
double[] point = new double[6];                  // 0 1 2      3 4 5
Console.WriteLine ("Введите коордитаны двух точек A(x,y,z), B(x,y,z):");
   
  
for (int i=0; i < point.Length; i++)
{
    point[i]=Convert.ToDouble (Console.ReadLine());
    ab = Math.Sqrt (((point[3] - point[0]) * (point[3] - point[0])) + ((point[4] - point[1]) * (point[4] - point[1])) + ((point[5] - point[2]) * (point[5] - point[2])));
}
Console.Write("ab=");
Console.WriteLine(ab);

}
