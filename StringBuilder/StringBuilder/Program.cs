using TestingSB.Entities;

string title = "Traveling to New Zealand";
DateTime date = DateTime.Parse("21/06/2018 13:05:44");
string content = "I'm going to visit this wonderful country!";
int likes = 12;

Post post = new Post(date, title, content, likes);

Console.Write("How many comments do you wanna add?: ");
int resp = int.Parse(Console.ReadLine());

for (int i = 0; i < resp; i++)
{
    Console.Write("Type comment: ");
    string postComment = Console.ReadLine();
    Comment comment = new Comment(postComment);
    post.AddComment(comment);
}

Console.WriteLine("------------------------------");

Console.WriteLine(post);