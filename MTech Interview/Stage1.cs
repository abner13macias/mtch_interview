using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTech_Interview
{
	internal class Stage1
	{
		static void Main(string[] args)
		{
			/*
				Reverse the elements in the list "hello"
	   
				Output:
				 H
				e
				l
				l
				o
				-
				M
				T
				e
				c
				h
				!!
			*/
			/*string[] hello = new string[] { "!!", "h", "c", "e", "T", "M", "-", "o", "l", "l", "e", "H" };
			List<string> helloList = new List<string>(hello);
			helloList.Reverse();

			/*	
				Count matching elements in the list that contains 'ei'
				Expected Results: Count: 1
			var words = new List<string> { "believe", "relief", "receipt", "field" };
			var wordsFiltered = words.Where( word => word.Equals("ei") );
			int matchingElements = wordsFiltered.Count();
			*/

			//STAGE 2

			/*
			 1) 
			  Create new class 'TruckWeight' with the following properties
				> TruckID (string)
				> Capacity (decimal)	   
				> Active (bool)	
			  2) 
				Create a list/collection of truck weights
				| TruckID	     |	Capacity	|	Active	|
				----------------------------------------------
				| Fuel Truck      |   10000      |   True    |
				| Tanker          |   22000		|   True	|
				| Trailer		 |   50000		|   True	|
				| Car Transporter |   30000		|   False   |
				3)
				 Find the active trucks with capacity less than 50000
			*/

			/*TruckWeight truck1 = new TruckWeight("Fuel Truck", 10000, true);
			TruckWeight truck2 = new TruckWeight("Tanker", 22000, true);
			TruckWeight truck3 = new TruckWeight("Trailer", 50000, true);
			TruckWeight truck4 = new TruckWeight("Car Transporter", 30000, false);

			List<TruckWeight> trucks = new List<TruckWeight>();

			trucks.Add(truck1);
			trucks.Add(truck2);
			trucks.Add(truck3);
			trucks.Add(truck4);

			var filteredTrucks = trucks.Where(truck => truck.Capacity < 50000 && truck.Active).ToList();

			filteredTrucks.ForEach(truck => Console.WriteLine(truck.TruckId));*/

			//STAGE 3

			/*
			 The data source for the query is a simple list of Student objects. 
			 Each Student record has a first name, last name, and an array of scores that represents their test scores in the class. 
			 1) Produce a sequence of Students whose total score is greater than the class average, together with their Student ID, Score
			 class average > 334
			 Output:
				Student ID: 113, Score: 338
				Student ID: 114, Score: 353
				Student ID: 116, Score: 369
				Student ID: 117, Score: 352
				Student ID: 118, Score: 343
				Student ID: 120, Score: 341
				Student ID: 122, Score: 368
			*/
			var data = DataSource.Students;

			List<Student> students = new List<Student>();
			double averageClass = 0;

            //Loop each Student
            foreach (var student in data)
			{
				double scoreCounter = 0;

				//Loop each Score
				foreach (var score in student.Scores)
                {
					scoreCounter += score.Score;
                }

				//Set Total Score
				student.totalScore = scoreCounter;
				averageClass = scoreCounter;
				students.Add(student);
            }

			averageClass /= data.Count;

			var filteredStudents = students.Where(student => student.totalScore > averageClass).ToList();

			filteredStudents.ForEach(student => Console.WriteLine("Student ID: " + student.ID + ", Score: " + student.totalScore));
		}
		/*public class TruckWeight
		{
			public string TruckId { get; set; }
			public decimal Capacity { get; set; }
			public bool Active { get; set; }

            public TruckWeight(string TruckId, decimal Capacity, bool Active)
            {
				this.TruckId = TruckId;
				this.Capacity = Capacity;
				this.Active = Active;
            }

		}*/

		public class Student
		{
			public int ID { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public IEnumerable<Scores> Scores;
			public double totalScore { get; set; }
		}

		public class Scores
		{
			public string Subject { get; set; }

			public int Score { get; set; }
		}

		public static class DataSource
		{
			// Create a data source by using a collection initializer.
			public static List<Student> Students = new List<Student>
			{
				new Student { FirstName="Svetlana", LastName="Omelchenko", ID=111, Scores= new List<Scores>
					{
						new Scores { Score = 97, Subject = "Math" },
						new Scores { Score = 92, Subject = "Chemistry" },
						new Scores { Score = 81, Subject = "Spanish" },
						new Scores { Score = 60, Subject = "Programming" }
					}
				},
				new Student { FirstName="Claire", LastName="O'Donnell", ID=112, Scores= new List<Scores>
					{
						new Scores { Score = 75, Subject = "Math" },
						new Scores { Score = 84, Subject = "Chemistry" },
						new Scores { Score = 91, Subject = "Spanish" },
						new Scores { Score = 39, Subject = "Programming" }
					}
				},
				new Student { FirstName="Sven", LastName="Mortensen", ID=113, Scores= new List<Scores>
					{
						new Scores { Score = 88, Subject = "Math" },
						new Scores { Score = 94, Subject = "Chemistry" },
						new Scores { Score = 65, Subject = "Spanish" },
						new Scores { Score = 91, Subject = "Programming" }
					}
				},
				new Student { FirstName="Cesar", LastName="Garcia", ID=114, Scores= new List<Scores>
					{
						new Scores { Score = 97, Subject = "Math" },
						new Scores { Score = 89, Subject = "Chemistry" },
						new Scores { Score = 85, Subject = "Spanish" },
						new Scores { Score = 82, Subject = "Programming" }
					}
				},
				new Student { FirstName="Debra", LastName="Garcia", ID=115, Scores= new List<Scores>
					{
						new Scores { Score = 35, Subject = "Math" },
						new Scores { Score = 72, Subject = "Chemistry" },
						new Scores { Score = 91, Subject = "Spanish" },
						new Scores { Score = 70, Subject = "Programming" }
					}
				},
				new Student { FirstName="Fadi", LastName="Fakhouri", ID=116, Scores= new List<Scores>
					{
						new Scores { Score = 99, Subject = "Math" },
						new Scores { Score = 86, Subject = "Chemistry" },
						new Scores { Score = 90, Subject = "Spanish" },
						new Scores { Score = 94, Subject = "Programming" }
					}
				},
				new Student { FirstName="Hanying", LastName="Feng", ID=117, Scores= new List<Scores>
					{
						new Scores { Score = 93, Subject = "Math" },
						new Scores { Score = 92, Subject = "Chemistry" },
						new Scores { Score = 80, Subject = "Spanish" },
						new Scores { Score = 87, Subject = "Programming" }
					}
				},
				new Student { FirstName="Hugo", LastName="Garcia", ID=118, Scores= new List<Scores>
					{
						new Scores { Score = 92, Subject = "Math" },
						new Scores { Score = 90, Subject = "Chemistry" },
						new Scores { Score = 83, Subject = "Spanish" },
						new Scores { Score = 78, Subject = "Programming" }
					}
				},
				new Student { FirstName="Lance", LastName="Tucker", ID=119, Scores= new List<Scores>
					{
						new Scores { Score = 68, Subject = "Math" },
						new Scores { Score = 79, Subject = "Chemistry" },
						new Scores { Score = 88, Subject = "Spanish" },
						new Scores { Score = 92, Subject = "Programming" }
					}
				},
				new Student { FirstName="Terry", LastName="Adams", ID=120, Scores= new List<Scores>
					{
						new Scores { Score = 99, Subject = "Math" },
						new Scores { Score = 82, Subject = "Chemistry" },
						new Scores { Score = 81, Subject = "Spanish" },
						new Scores { Score = 79, Subject = "Programming" }
					}
				},
				new Student { FirstName="Eugene", LastName="Zabokritski", ID=121, Scores= new List<Scores>
					{
						new Scores { Score = 96, Subject = "Math" },
						new Scores { Score = 85, Subject = "Chemistry" },
						new Scores { Score = 91, Subject = "Spanish" },
						new Scores { Score = 60, Subject = "Programming" }
					}
				},
				new Student { FirstName="Michael", LastName="Tucker", ID=122, Scores= new List<Scores>
					{
						new Scores { Score = 94, Subject = "Math" },
						new Scores { Score = 92, Subject = "Chemistry" },
						new Scores { Score = 91, Subject = "Spanish" },
						new Scores { Score = 91, Subject = "Programming" }
					}
				}
			};
		}
	}
}
