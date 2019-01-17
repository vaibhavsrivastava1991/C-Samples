using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserializeListOfObjectIntoJson
{
	class Test
	{
		public Test()
		{
			Prop22 = new List<Test2>();
		}
		public int Prop1 { get; set; }
		public int Prop2 { get; set; }
		public List<Test2> Prop22 { get; set; }
	}
	class Test2
	{
		public int Prop1 { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Test> t1 = new List<Test>();
			for (int i = 1; i < 6; i++)
			{
				t1.Add(new Test
				{
					Prop1 = i,
					Prop2 = i + 1,
					Prop22 = new List<Test2>()
					{
						new Test2
						{
							Prop1 = i + 2
						}

					}
				});
			}

			//Using NewtonSoft Json -> Install From Nuget Package Manager

			//Serializing List<Test> Object In to Json
			string serializedData = JsonConvert.SerializeObject(t1);

			//Deserializing Json to List<Test> 
			t1 = JsonConvert.DeserializeObject<List<Test>>(serializedData);
		}
	}
}
