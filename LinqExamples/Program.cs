using static System.Console;

string[] names = { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };
string[] cohort1 = { "Rachel", "Gareth", "Jonathan", "George" }; 
string[] cohort2 = { "Jack", "Stephen", "Daniel", "Jack", "Jared" }; 
string[] cohort3 = { "Declan", "Jack", "Jack", "Jasmine", "Conor" }; 
int[] nums = {12, 34, 56, 45, 46, 59, 92};

SetsAndBags.SetsAndBags.output(cohort2.DistinctBy(name => name.Substring(0, 2)));
WriteLine("Concat");
SetsAndBags.SetsAndBags.output(cohort2.Concat(cohort3));
WriteLine("Union");
SetsAndBags.SetsAndBags.output(cohort2.Union(cohort3));
WriteLine("Intersect");
SetsAndBags.SetsAndBags.output(cohort2.Intersect(cohort3));
WriteLine("Except");
SetsAndBags.SetsAndBags.output(cohort2.Except(cohort3));
WriteLine("zip");
SetsAndBags.SetsAndBags.output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} matched with {c2}"));


// var query = names.Where(name => name.EndsWith("m"));
// // below is old way of doing the above
// var query2 = from name in names where name.EndsWith("m") select name;
// var result = query.ToArray();

//foreach (string name in result)
//{
//    WriteLine(name);
//    names[2] = "Jimmy";
//}

// var query3 = names
//     .Where(name => name.Length > 4)
//     .OrderBy(name => name.Length)
//     .Take(1);
//
// foreach (string name in query3)
// {
//     WriteLine(name);
// }

