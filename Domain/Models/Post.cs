using System.Threading;

namespace Domain.Models;
public class Post
{
    public int PostId { get; set; } 
    public string? PostTitle { get; set; }
    public DateTime PostTime { get; set; }
    public int LikeCount { get; set; } = 0;
    public List<string>? CommentsList { get; set; } = new List<string>();

    public void PublishProcessing()
    {
        Thread.Sleep(4000);
        Console.WriteLine($"Processing : 20%");
        Thread.Sleep(4000);
        Console.WriteLine($"Processing : 50%");
        Thread.Sleep(4000);
        Console.WriteLine($"Processing : 80%");
        Thread.Sleep(4000);
        Console.WriteLine($"Post is published!");
    }

    public void AddLike()
    {
        LikeCount++;
    }

    public void AddComment(string comment)
    {
        CommentsList.Add(comment);
    }

    public void GetFullInfo()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine(PostTitle);
        Console.WriteLine($"____________________██████{Environment.NewLine}_________▓▓▓▓____█████████{Environment.NewLine}__ Ƹ̵̡Ӝ̵̨̄Ʒ▓▓▓▓▓=▓____▓=▓▓▓▓▓{Environment.NewLine}__ ▓▓▓_▓▓▓▓░●____●░░▓▓▓▓{Environment.NewLine}_▓▓▓▓_▓▓▓▓▓░░__░░░░▓▓▓▓{Environment.NewLine}_ ▓▓▓▓_▓▓▓▓░░♥__♥░░░▓▓▓{Environment.NewLine}__ ▓▓▓___▓▓░░_____░░░▓▓{Environment.NewLine}▓▓▓▓▓____▓░░_____░░▓{Environment.NewLine}_ ▓▓____ ▒▓▒▓▒___ ████{Environment.NewLine}_______ ▒▓▒▓▒▓▒_ ██████{Environment.NewLine}_______▒▓▒▓▒▓▒ ████████{Environment.NewLine}_____ ▒▓▒▓▒▓▒_██████ ███{Environment.NewLine}_ ___▒▓▒▓▒▓▒__██████ _███{Environment.NewLine}_▓▓X▓▓▓▓▓▓▓__██████_ ███{Environment.NewLine}▓▓_██████▓▓__██████_ ███{Environment.NewLine}▓_███████▓▓__██████_ ███{Environment.NewLine}_████████▓▓__██████ _███{Environment.NewLine}_████████▓▓__▓▓▓▓▓▓_▒▒{Environment.NewLine}_████████▓▓__▓▓▓▓▓▓{Environment.NewLine}_████████▓▓__▓▓▓▓▓▓{Environment.NewLine}__████████▓___▓▓▓▓▓▓{Environment.NewLine}_______▒▒▒▒▒____▓▓▓▓▓▓{Environment.NewLine}_______▒▒▒▒▒ _____▓▓▓▓▓{Environment.NewLine}_______▒▒▒▒▒_____ ▓▓▓▓▓{Environment.NewLine}_______▒▒▒▒▒ _____▓▓▓▓▓{Environment.NewLine}________▒▒▒▒______▓▓▓▓▓{Environment.NewLine}________█████____█████{Environment.NewLine}_'▀█║────────────▄▄───────────​─▄──▄_{Environment.NewLine}──█║───────▄─▄─█▄▄█║──────▄▄──​█║─█║{Environment.NewLine}──█║───▄▄──█║█║█║─▄║▄──▄║█║─█║​█║▄█║{Environment.NewLine}──█║──█║─█║█║█║─▀▀──█║─█║█║─█║​─▀─▀{Environment.NewLine}──█║▄║█║─█║─▀───────█║▄█║─▀▀{Environment.NewLine}──▀▀▀──▀▀────────────▀─█║{Environment.NewLine}───────▄▄─▄▄▀▀▄▀▀▄──▀▄▄▀{Environment.NewLine}──────███████───▄▀{Environment.NewLine}──────▀█████▀▀▄▀{Environment.NewLine}────────▀█▀{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Likes: {LikeCount}{Environment.NewLine}{Environment.NewLine}Comments: {CommentsList.Count}");
        foreach (var comment in CommentsList)
        {
            Console.WriteLine(comment);
        }
        Console.WriteLine(PostTime);
    }

}
