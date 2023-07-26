using System;
using System.IO;
using System.Linq.Expressions;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            File file = new Music("Sth", "Metalica", 10, 20);
            File pic = new Picture("Flower", 30, 50);

            StreamProgressInfo streamProgressInfo = new StreamProgressInfo(pic);
            streamProgressInfo.CalculateCurrentPercent();
        }
    }
}
