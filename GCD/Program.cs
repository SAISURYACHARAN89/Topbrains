class Program
{
    static int Euclid(int a,int b,int r)
    {
        if(r == 0){return a;}
        //a = bq + r
        if(a > b)
        {
            r = a % b;
            return Euclid(b,r,r);
        }
        else
        {
            r = b % a;
            return Euclid(a,r,r);
        }
    }
    static void Main()
    {
        Console.WriteLine(Euclid(120,25,1));

    }
}