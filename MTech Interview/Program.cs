using MTech_Interview;

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
	averageClass += scoreCounter;
	students.Add(student);
}

averageClass = averageClass / students.Count;

var filteredStudents = students.Where(student => student.totalScore > averageClass).ToList();

Console.WriteLine("Average: " + averageClass);

filteredStudents.ForEach(student => Console.WriteLine("Student ID: " + student.ID + ", Score: " + student.totalScore));

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