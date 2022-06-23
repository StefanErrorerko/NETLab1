using System;
using System.Collections.Generic;
using NET_Lab1.Entity;

namespace NET_Lab1
{
    internal class ConsoleViewer
    {

        //1
        public static void ShowAuthors(List<Author> authors)
        {
            ShowTitle(1, "вибiрка всiх авторiв");
            DefaultShow(Queries.GetAuthors(authors));
            Console.WriteLine('\n');
        }
        //2
        public static void ShowMagsEtEstbl(List<Magazine> mags)
        {
            ShowTitle(2, "вибiрка назв журналiв та років їх заснування");
            foreach (var x in Queries.GetMagsNameEtEstbl(mags)) Console.WriteLine(x);
            Console.WriteLine('\n');

        }
        //3
        public static void ShowMagsWithNormalCirc(List<Magazine> mags)
        {
            ShowTitle(3, "Журнали з середнiм тиражем(10000<= && <=20000)");
            DefaultShow(Queries.GetMagsWithNormalCirc(mags));
            Console.WriteLine('\n');

        }
        //4
        public static void ShowUnpublishedArticle(List<Article> articles, List<EditorDoc> docs)
        {
            ShowTitle(4, "вибрати усi статтi, що не публiкувались");
            DefaultShow(Queries.GetArticlesUnpublished(articles, docs));
            Console.WriteLine('\n');
        }
        //5
        public static void ShowAuthorsSortedByOrg(List<Author> authors)
        {
            ShowTitle(5, "вибрати усiх авторiв, вiдсортувавши їх за спiлкою, " +
                "в якiй вони знаходяться (за спаданням)");
            DefaultShow(Queries.GetAuthorsSortedByOrganisation(authors));
            Console.WriteLine('\n');
        }

        //6
        public static void ShowFirstMagOfIndependentUA(List<Magazine> mags)
        {
            ShowTitle(6, "вибрати перший журнал, що був заснований " +
                "до проголошення незалежностi");
            DefaultShow(Queries.GetMagFirstOfIndependentUA(mags));
            Console.WriteLine('\n');
        }

        //7
        public static void ShowMagsAndItsArticles(List<Magazine> mags, List<EditorDoc> docs, List<Article> articles)
        {
            ShowTitle(7, "вибрати журнал та авторiв, що друкувались " +
                "у ньому (Group Join)");
            foreach (var x in Queries.GetMagsAndItsArticles(mags, docs, articles))
            {
                Console.Write($"Articles in mag {x.Key} - ");
                foreach (var y in x.Value) Console.WriteLine(y);
            }
            Console.WriteLine('\n');
        }

        //8
        public static void ShowAuthorsAndItsArticles(List<Author> authors, List<Article> articles)
        {
            ShowTitle(8, "вибрати автори та статтi, якi тi друкувались " +
                "(Outer Join)");
            foreach (var x in Queries.GetAuthorsAndItsArticles(authors, articles))
            {
                Console.WriteLine(x.Key);
                foreach (var y in x) Console.WriteLine($"\t{y}");
            }
            Console.WriteLine('\n');
        }

        //9
        public static void ShowCircSummary(List<Magazine> mags)
        {

            ShowTitle(9, " оцiнити сумарний наклад усiх журналiв на рiк");
            foreach (var x in Queries.GetMagsAndCirc(mags)) Console.WriteLine($"Mag: {x.Key} - {x.Value}pcs/yr");
            Console.WriteLine($"Sum per yr: {Queries.GetCircSummary(mags)}");
            Console.WriteLine('\n');
        }

        //10
        public static void ShowArticlesGroupByPublish(List<Article> articles, List<EditorDoc> docs)
        {
            ShowTitle(10, "згрупувати усi статтi за кiлькiстю їх публiкацiй");
            var q = Queries.GetArticlesGroupByPublish(articles, docs);
            foreach (var x in q)
            {
                Console.WriteLine(x.Key);
                foreach (var y in x)
                {
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine('\n');
        }

        //11
        public static void ShowArticlesGroupByYearOver2002(List<EditorDoc> docs, List<Article> articles)
        {
            ShowTitle(11, "згрупувати усi статтi пiсля 2002 за роком публiкацiї (Group Any)");
            var q = Queries.GetArticlesGroupByYearOver2002(docs, articles);
            foreach (var x in q)
            {
                Console.WriteLine($"Key: {x.Key}");
                foreach (var y in x.Value)
                    Console.WriteLine(y);
            }
            Console.WriteLine('\n');
        }

        //12
        public static void ShowArticlesInPotopMag(List<Article> articles, List<Magazine> mags, List<EditorDoc> docs)
        {
            ShowTitle(12, "Вивести iнформацiю про статтi, що публiкувались у 'Potop' Mag");
            DefaultShow(Queries.GetArticlesInPotopMag(articles, mags, docs));
            Console.WriteLine('\n');
        }

        //13
        public static void ShowConcatedLists(List<Author> au1, List<Author> au2)
        {
            ShowTitle(13, "об'єднати два масиви авторiв");
            DefaultShow(Queries.GetConcatedLists(au1, au2));
            Console.WriteLine("\n\niз виключенням дублiкатiв");
            DefaultShow(Queries.GetDistinctedUnionList(au1, au2));
            Console.WriteLine('\n');
        }

        //14
        public static void ShowDifferneceBetweenLists(List<Author> au1, List<Author> au2)
        {
            ShowTitle(14, "рiзниця множин");
            DefaultShow(Queries.GetDifferneceBetweenLists(au1, au2));
            Console.WriteLine('\n');
        }


        //15
        public static void ShowIntersectBetweenLists(List<Author> au1, List<Author> au2)
        {
            ShowTitle(14, "перетин множин");
            DefaultShow(Queries.GetIntersectBetweenLists(au1, au2));
            Console.WriteLine('\n');
        }

        //==============================================
        private static void DefaultShow(IEnumerable<object> q)
        {
            foreach (var x in q) Console.WriteLine(x);
        }

        public static void DefaultShow(object obj)
        {
            Console.WriteLine(obj);
        }

        public static void ShowTitle(int num, string title)
        {
            Console.WriteLine($"=======запит {num} - {title}=======");
        }
    }
}
