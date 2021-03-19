using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class DaysOfWeek
	{
		public static List<DaysOfWeek> DaysOfTheWeek()
		{
			return new List<DaysOfWeek>{
				new DaysOfWeek {Day="Choose Day", Value=0 },
				new DaysOfWeek {Day="Monday", Value=1 },
				new DaysOfWeek {Day="Tuesday", Value=2 },
				new DaysOfWeek {Day="Wednesday", Value=3 },
				new DaysOfWeek {Day="Thursday", Value=4 },
				new DaysOfWeek {Day="Friday", Value=5 },
				new DaysOfWeek {Day="Saturday", Value=6 },
				new DaysOfWeek {Day="Sunday", Value=7 },
			};
		}
		public string Day { get; set; }
		public int Value { get; set; }
	}
}
