using System.Collections.Generic;
using NET_Lab1.Instruments;
using NET_Lab1.Entity;

namespace NET_Lab1
{
    internal static class Data
    {
        internal static List<Magazine> Mags;
        internal static List<Author> Authors;
        internal static List<Article> Articles;
        internal static List<EditorDoc> Docs;

        internal static List<Author> au1;
        internal static List<Author> au2;

        internal static void MagWithCheck(List<Magazine> mags)
        {
            foreach (Magazine m in mags) DateTimeAccuracyMonitor.CheckDate(m.Est);
        }

        internal static void DocWithCheck(List<EditorDoc> docs)
        {
            foreach (EditorDoc d in docs) DateTimeAccuracyMonitor.CheckDate(d.Date);
        }
    }
}
