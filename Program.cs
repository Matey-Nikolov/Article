using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main()
        {

            string[] commandssomeOrNo = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string rename = commandssomeOrNo[0];
            string edit = commandssomeOrNo[1];
            string changeAuthor = commandssomeOrNo[2];

            Article article = new Article(rename, edit, changeAuthor);
            

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string renameeEditChangeAuthor1 = commands[0];
                string message = commands[1];

                if (renameeEditChangeAuthor1 == "Edit")
                {
                    article.Edit(message);
                }
                else if (renameeEditChangeAuthor1 == "ChangeAuthor")
                {
                    article.ChangeAuthor(message);
                }
                else if (renameeEditChangeAuthor1 == "Rename")
                {
                    article.Rename(message);
                }
            }

            Console.WriteLine(article.ToString());
           // Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

        }
    }
}
