using Lms.Core.Enteties;
using Bogus;

namespace Lms.Data.Data
{
	public class SeedData
	{
		private static Faker faker = null!;
		private static LmsApiContext? db;
		public static async Task InitAsync(LmsApiContext context)
		{
			if (context is null) throw new ArgumentNullException(nameof(context));
			db = context;
			//if (await db.Course.AnyAsync()) return;

			faker = new Faker("sv");
			var Courses = GenerateCourses(5);
			db.AddRange(Courses);
			await db.SaveChangesAsync();
		}
		private static IEnumerable<Course> GenerateCourses(int NumberOfCourse)
		{
			var courses = new List<Course>();
			for (int i = 0; i < NumberOfCourse; i++)
			{
				var startdate = DateTime.Now.AddDays(faker.Random.Int(-20, 20));// new DateTime();
				var title = faker.Name.FindName();
				courses.Add(new Course() { Title = title, StartDate = startdate });
			}
			return courses;
		}
	}
}


