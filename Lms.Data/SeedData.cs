using Lms.Api.Data;
using Lms.Core.Enteties;
using Bogus;

namespace Lms.Data.Data
{
	public class SeedData
	{
		private static Faker faker = null!;
		public static async Task InitAsync(LmsApiContext db)
		{
			faker = new Faker("sv");
			var Courses = GenerateCourses(5);
			await db.AddRangeAsync(Courses);
		}
		private static IEnumerable<Course> GenerateCourses(int NumberOfCourse)
		{
			var courses = new List<Course>();
			for (int i = 0; i < NumberOfCourse; i++)
			{
				var startdate = new DateTime();
				var title = faker.Random.String();
				courses.Add(new Course() { Title = title, StartDate = startdate });
			}
			return courses;
		}
	}
}


