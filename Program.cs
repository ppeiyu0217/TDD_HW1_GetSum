using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSum
{
   public class Program : ISum
    {
        public List<int> GetCostByCutNum(int CutNumber)
        {
            List<Data> DataLists = new List<Data>()
            {
                new Data {Id=1,Cost= 1,Revenue=11,SellPrice=21},
                new Data {Id=2,Cost= 2,Revenue=12,SellPrice=22},
                new Data {Id=3,Cost= 3,Revenue=13,SellPrice=23},
                new Data {Id=4,Cost= 4,Revenue=14,SellPrice=24},
                new Data {Id=5,Cost= 5,Revenue=15,SellPrice=25},
                new Data {Id=6,Cost= 6,Revenue=16,SellPrice=26},
                new Data {Id=7,Cost= 7,Revenue=17,SellPrice=27},
                new Data {Id=8,Cost= 8,Revenue=18,SellPrice=28},
                new Data {Id=9,Cost= 9,Revenue=19,SellPrice=29},
                new Data {Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Data {Id=11,Cost=11,Revenue=21,SellPrice=31},
            };
            var Source = DataLists.Select(r => r.Cost);

            return Calculate(Source, CutNumber);
        }

        public List<int> GetRevenueByCutNum(int CutNumber)
        {
            List<Data> DataLists = new List<Data>()
            {
                new Data {Id=1,Cost= 1,Revenue=11,SellPrice=21},
                new Data {Id=2,Cost= 2,Revenue=12,SellPrice=22},
                new Data {Id=3,Cost= 3,Revenue=13,SellPrice=23},
                new Data {Id=4,Cost= 4,Revenue=14,SellPrice=24},
                new Data {Id=5,Cost= 5,Revenue=15,SellPrice=25},
                new Data {Id=6,Cost= 6,Revenue=16,SellPrice=26},
                new Data {Id=7,Cost= 7,Revenue=17,SellPrice=27},
                new Data {Id=8,Cost= 8,Revenue=18,SellPrice=28},
                new Data {Id=9,Cost= 9,Revenue=19,SellPrice=29},
                new Data {Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Data {Id=11,Cost=11,Revenue=21,SellPrice=31},
            };
            var Source = DataLists.Select(r => r.Revenue);

            return Calculate(Source, CutNumber);
        }

        private List<int> Calculate(IEnumerable<int> Source, int CutNum)
        {
            int i = 0;
            var result = new List<int>();
            for (i = 0; i <= Source.Count() / CutNum; i++)
            {
                result.Add(Source.Skip(i * CutNum).Take(CutNum).Sum());
            }
            return result;
        }
    }

    public interface ISum
    {
        List<int> GetCostByCutNum(int CutNumber);

        List<int> GetRevenueByCutNum(int CutNumber);
    }

    public class Data
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
