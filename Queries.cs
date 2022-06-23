using System;
using System.Linq;
using System.Collections.Generic;
using NET_Lab1.Entity;
using NET_Lab1.Instruments;

namespace NET_Lab1
{
    internal static class Queries
    {
        //1
        public static IEnumerable<Author> GetAuthors(List<Author> authors)
        {
            return from x in authors
                   select x;
        }

        // 2 
        public static Dictionary<string, int> GetMagsNameEtEstbl(List<Magazine> mags) {
            return 
            mags.Select(y => new
            {
                Name = y.Name,
                Established = y.Est
            }).ToDictionary(mags => mags.Name, mags => mags.Established);
        }

        //3
        public static IEnumerable<Magazine> GetMagsWithNormalCirc(List<Magazine> mags)
        {
            return from z in mags
                     where z.Circ <= 20000 && z.Circ >= 2000
                     select z;
        }

        //4
        public static IEnumerable<Article> GetArticlesUnpublished(List<Article> articles, List<EditorDoc> docs)
        {
            return from art in articles
                     where !(
                            (from a in docs
                             select a.ArticleId).Contains(art.ArticleId))
                     select art;
        }

        //5
        public static IEnumerable<Author> GetAuthorsSortedByOrganisation(List<Author> authors)
        {
            return authors.OrderByDescending(x => x.Organ);
        }

        //6
        public static Magazine GetMagFirstOfIndependentUA(List<Magazine> mags)
        {
            return (from x in mags select x).FirstOrDefault(x => x.Est <= 1991);
        }

        //7
        public static Dictionary<string, IEnumerable<EditorDoc>> GetMagsAndItsArticles(List<Magazine> mags, List<EditorDoc> docs, List<Article> articles)
        {

            var q1 = (from m in mags
                      join d in docs
                        on m.MagId equals d.MagId into temp
                      select new
                      {
                          Mag = m.Name,
                          Art = temp
                      }).ToDictionary(a => a.Mag, a => a.Art);

            return q1;
        }

        //8
        public static ILookup<string, string> GetAuthorsAndItsArticles(List<Author> authors, List<Article> articles)
        {
            return (from au in authors
                    join ar in articles on au.AuthorId equals ar.AuthorId into temp
                    from t in temp.DefaultIfEmpty()
                    select new { Author = au.Surname, Article = ((t == null) ? "null" : t.Name) })
                     .ToLookup(au => au.Author, au => au.Article);

        }

        //9
        public static Dictionary<Magazine, double> GetMagsAndCirc(List<Magazine> mags)
        {
            return (mags.Select(x => new { 
                Mag = x, Amount = 12 * x.Circ * x.Freq, Freq = 12 * x.Freq, Circ = x.Circ 
            })).ToDictionary(mags => mags.Mag, mags => mags.Amount);
        }

        public static double GetCircSummary(List<Magazine> mags)
        {
            return GetMagsAndCirc(mags).Sum(x => x.Value);
        }

        //10
        public static IEnumerable<IGrouping<int, Article>> GetArticlesGroupByPublish(List<Article> articles, List<EditorDoc> docs)
        {
            return from ar in articles
                      join d in docs on ar.ArticleId equals d.ArticleId into temp
                      group ar by temp.Count();
        }

        //11
        public static Dictionary<int, IGrouping<int, EditorDoc>> GetArticlesGroupByYearOver2002(List<EditorDoc> docs, List<Article> articles)
        {
            return (from a in articles
                    join d in docs on a.ArticleId equals d.ArticleId
                    orderby d.Date.Year
                   group d by d.Date.Year into g
                   where g.Any(x => x.Date.Year > 2002)

                   select new
                   {
                       Key = g.Key,
                       Values = g,
                   }).ToDictionary(d => d.Key, d => d.Values);

        }

        //12
        public static IEnumerable<Article> GetArticlesInPotopMag(List<Article> articles, List<Magazine> mags, List<EditorDoc> docs)
        {
            return from ar in articles
                      where (
                            (from d in docs
                             join m in (
                                from m2 in mags 
                                where m2.Name == "Potop" 
                                select m2) 
                                    on d.MagId equals m.MagId
                             select d.ArticleId).Contains(ar.ArticleId)
                             )
                      select ar;
        }

        //13
        public static IEnumerable<Author> GetConcatedLists(List<Author> au1, List<Author> au2)
        {
            return au1.Concat(au2);
        }

        public static IEnumerable<Author> GetDistinctedUnionList(List<Author> au1, List<Author> au2)
        {
            return au1.Union(au2).Distinct(
                new AuthorEqualityComparer());
        }

        //14 
        public static IEnumerable<Author> GetDifferneceBetweenLists(List<Author> au1, List<Author> au2)
        {
            return au1.Except(au2, new AuthorEqualityComparer());
        }

        //15
        public static IEnumerable<Author> GetIntersectBetweenLists(List<Author> au1, List<Author> au2)
        {
            return au1.Intersect(au2, new AuthorEqualityComparer());
        }
    }
}
