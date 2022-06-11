using izolabella.Notion.Objects.Databases;

namespace izolabella.Notion.Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            NotionClient C = new(Objects.Enums.IntegrationType.Internal, "", null);
            DatabaseObject<AnimeWatchlistPage>? Obj = await C.GetDatabase<AnimeWatchlistPage>("f03e2bf458d045259b0afb8a66cdea1f");
            if(Obj != null)
            {
                var BB = await Obj.GetPages<AnimeWatchlistPage>();
                foreach (PageObject<AnimeWatchlistPage>? P in (BB).Result)
                {
                    AnimeWatchlistPage? A = P.Properties;
                    Console.WriteLine(A.Notes.RichTextContent.FirstOrDefault()?.PlainText ?? "n/a");
                }
            }
        }
    }
}