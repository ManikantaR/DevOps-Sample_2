using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class WebDowloader
    {
       public List<SampleModel> GetModels()
        {
            return new List<SampleModel> { new SampleModel {Name="Test",Id=1 } };
        }
    }

    public class SampleModel
    {
        public string   Name { get; set; }
        public int Id { get; set; }
    }
}
