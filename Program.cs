using System;
using System.Collections.Generic;
using NET_Lab1.Entity;
using NET_Lab1.Instruments;

namespace NET_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Magazine> mags = new List<Magazine>
            {
                new Magazine(){MagId = 1, Name = "Potop", Freq = (double)1 / 2, Circ = 200, Est =  2019 },
                new Magazine(){MagId = 2, Name = "Moloko", Freq = 1, Circ = 1000, Est = 1998 },
                new Magazine(){MagId = 3, Name = "Perets", Freq = 1, Circ = 10000, Est = 1922},
                new Magazine(){MagId = 4, Name = "Ravlyk", Freq = 1, Circ = 20000, Est = 2001},
                new Magazine(){MagId = 5, Name = "Professor Kreyd", Freq = 4, Circ = 100000, Est = 2005},
                new Magazine(){MagId = 6, Name = "Rozumashky", Freq = 4, Circ = 25000, Est = 2016},
                new Magazine(){MagId = 7, Name = "Terra Incognita", Freq = (double)1 / 12, Circ = 500, Est = 1993},
                new Magazine(){MagId = 8, Name = "Barvinok", Freq = 4, Circ = 300000, Est = 1928}
            };
                Data.MagWithCheck(mags);
                Data.Mags = mags;
                Data.Authors = new List<Author>
            {
                new Author(){AuthorId = 1, Surname = "Muzyka", Name = "Oleksandr", Secondname = "Ivanovych", Organ = "Segodnya" },
                new Author(){AuthorId = 2, Surname = "Kokotiukha", Name = "Andrii", Secondname = "Anatoliiovych", Organ = "independent" },
                new Author(){AuthorId = 3, Surname = "Yas'", Name = "Stef", Secondname = "", Organ = "Segodnya" },
                new Author(){AuthorId = 4, Surname = "Voronovych", Name = "Vasyl", Secondname = "Yosypovych", Organ = "Barvinok" },
                new Author(){AuthorId = 5, Surname = "Zhadan", Name = "Serhii", Secondname = "Viktorovych", Organ = "Association of Ukrainian literators" },
                new Author(){AuthorId = 6, Surname = "Nouneimenko", Name = "Neznayko", Secondname = "Kudykovych", Organ = "independent" }
            };
                Data.Articles = new List<Article>
            {
                new Article(){ArticleId = 1, Name = "Самi Свої - або що таке український бард", AuthorId = 1 },
                new Article(){ArticleId = 2, Name = "Солом'янський вайб", AuthorId = 3},
                new Article(){ArticleId = 3, Name = "Дива української казки", AuthorId = 4},
                new Article(){ArticleId = 4, Name = "Що таке українська лайка?", AuthorId = 3},
                new Article(){ArticleId = 5, Name = "Ми живемо серед них", AuthorId = 3},
                new Article(){ArticleId = 6, Name = "Абабагаламага", AuthorId = 3},
                new Article(){ArticleId = 7, Name = "Харкiвський рок", AuthorId = 3},
                new Article(){ArticleId = 8, Name = "Як писати масову лiтературу?", AuthorId = 2},
                new Article(){ArticleId = 9, Name = "Мама Аня, дядя Стефан, просто Яся i я", AuthorId = 1},
            };
                List<EditorDoc> docs = new List<EditorDoc>
            {
                new EditorDoc(){DocId = 1, ArticleId = 1, MagId = 1, Date = new DateTime(2022, 04, 28)},
                new EditorDoc(){DocId = 2, ArticleId = 1, MagId = 7, Date = new DateTime(2022, 03, 11)},
                new EditorDoc(){DocId = 3, ArticleId = 2, MagId = 1, Date = new DateTime(2022, 04, 28)},
                new EditorDoc(){DocId = 4, ArticleId = 2, MagId = 3, Date = new DateTime(2010, 08, 10)},
                new EditorDoc(){DocId = 5, ArticleId = 3, MagId = 4, Date = new DateTime(2009, 11, 01)},
                new EditorDoc(){DocId = 6, ArticleId = 4, MagId = 7, Date = new DateTime(2004, 01, 03)},
                new EditorDoc(){DocId = 7, ArticleId = 6, MagId = 6, Date = new DateTime(2011, 08, 11)},
                new EditorDoc(){DocId = 8, ArticleId = 6, MagId = 5, Date = new DateTime(2012, 03, 16)},
                new EditorDoc(){DocId = 9, ArticleId = 7, MagId = 7, Date = new DateTime(2010, 08, 10)},
                new EditorDoc(){DocId = 10, ArticleId = 7, MagId = 8, Date = new DateTime(2002, 04, 04)},
                new EditorDoc(){DocId = 11, ArticleId = 8, MagId = 8, Date = new DateTime(2002, 04, 04)},
            };
                Data.DocWithCheck(docs);
                Data.Docs = docs;

                Data.au1 = new List<Author>
            {
                new Author(){AuthorId = 7, Surname = "Cherednichenko", Name = "Andrii", Secondname = "Serhiiovych", Organ = "Liga" },
                new Author(){AuthorId = 8, Surname = "Sylchuk", Name = "Roman", Secondname = "Palych", Organ = "VLGG" },
                new Author(){AuthorId = 9, Surname = "Mamon", Name = "Elizaveta", Secondname = "Serzhivna", Organ = "TT" },
                new Author(){AuthorId = 10, Surname = "Hnatenko", Name = "Yaroslav", Secondname = "Yevheniiovych", Organ = "VLGG" },
                new Author(){AuthorId = 11, Surname = "Kokotiukha", Name = "Danylo", Secondname = "Andriiovych", Organ = "[Вставити текст]" }
            };
                Data.au2 = new List<Author>
            {
                new Author(){AuthorId = 12, Surname = "Cherednichenko", Name = "Andrii", Secondname = "Serhiiovych", Organ = "Liga" },
                new Author(){AuthorId = 13, Surname = "Nadobranich", Name = "Pylyp", Secondname = "Severynovych", Organ = "Morobso News" },
                new Author(){AuthorId = 14, Surname = "Lalaca", Name = "Heropes", Secondname = "Papacanski", Organ = "Radiorubka" },
                new Author(){AuthorId = 15, Surname = "Kokotiukha", Name = "Danylo", Secondname = "Andriiovych", Organ = "[Вставити текст]" }
            };

                ConsoleViewer.ShowAuthors(Data.Authors);
                ConsoleViewer.ShowMagsEtEstbl(Data.Mags);
                ConsoleViewer.ShowMagsWithNormalCirc(Data.Mags);
                ConsoleViewer.ShowUnpublishedArticle(Data.Articles, Data.Docs);
                ConsoleViewer.ShowAuthorsSortedByOrg(Data.Authors);
                ConsoleViewer.ShowFirstMagOfIndependentUA(Data.Mags);
                ConsoleViewer.ShowMagsAndItsArticles(Data.Mags, Data.Docs, Data.Articles);
                ConsoleViewer.ShowAuthorsAndItsArticles(Data.Authors, Data.Articles);
                ConsoleViewer.ShowCircSummary(Data.Mags);
                ConsoleViewer.ShowArticlesGroupByPublish(Data.Articles, Data.Docs);
                ConsoleViewer.ShowArticlesGroupByYearOver2002(Data.Docs, Data.Articles);
                ConsoleViewer.ShowArticlesInPotopMag(Data.Articles, Data.Mags, Data.Docs);
                ConsoleViewer.ShowConcatedLists(Data.au1, Data.au2);
                ConsoleViewer.ShowDifferneceBetweenLists(Data.au1, Data.au2);
                ConsoleViewer.ShowIntersectBetweenLists(Data.au1, Data.au2);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
