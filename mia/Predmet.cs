using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mia
{
	internal class Predmet
	{
		public string subjectName;
		public List<double> marks = new List<double>();

		public Predmet(string subject, List<double> Marks)
		{
			subjectName = subject;
			marks = Marks;
		}
	}
}
