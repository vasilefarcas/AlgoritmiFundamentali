int n = int.Parse(Console.ReadLine());
int p = 0, i = 0, nr;
string s = Console.ReadLine();
string[] v = s.Split(' ');
for (int j = 0; j < n; j++)
{
    nr = int.Parse(v[j]);
    if(PrimaUltima(nr)==true)
        Console.Write(nr);
}

Console.WriteLine(Math.Abs(i - p));
bool PrimaUltima(int n)
{
    int u = n % 10;
    while(n>=10)
    {
        n /= 10;
    }
    if (u == n)
        return true;
    return false;

}
bool Palindrom(int n)
{
    int inv=0,aux=n;
    while(aux!=0)
    {
        inv = inv * 10 + aux % 10;
        aux /= 10;
    }
    if (n == inv)
        return true;
    return false;
}