using Domain.Models;

var post1 = new Post();
post1.PostId = 1;
post1.PostTime = DateTime.Now;

Console.Write("Add a Post Title: ");
post1.PostTitle = Console.ReadLine();

Console.Write("How many comments do you want to add? ");
var commentSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add comments");
for (int i = 0; i < commentSize; i++)
{
    post1.AddComment(Console.ReadLine());
}

Console.Write("How many likes do you want to add? ");
var likeSize = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < likeSize; i++)
{
    post1.AddLike();
}


post1.PublishProcessing();
post1.GetFullInfo();
