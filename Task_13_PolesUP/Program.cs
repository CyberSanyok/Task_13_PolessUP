internal class Program
{
    private static void Main(string[] args)
    {
        string version1 = "2.13.001";
        string version2 = "2.13.011";
        Console.WriteLine(CompareVersions(version1,version2));
    }
    public static int CompareVersions(string version1,string version2) 
    {
        string[] vers1Split = version1.Split('.');
        string[] vers2Split = version2.Split('.');
        for (int i = 0; i < vers1Split.Length; i++)
        {
            if (Convert.ToInt32(vers1Split[i]) > Convert.ToInt32(vers2Split[i])) return 1;
            if(Convert.ToInt32(vers1Split[i]) < Convert.ToInt32(vers2Split[i])) return -1;
        }
        return 0;
    }
}