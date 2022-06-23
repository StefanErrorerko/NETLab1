using System;

namespace NET_Lab1.Entity
{
    class EditorDoc
    {
        public int DocId { get; set; }
        public int ArticleId { get; set; }
        public int MagId { get; set; }
        public DateTime Date { get; set; }
        public override string ToString() => string.Format($"{Date}: Article #{ArticleId} in Mag #{MagId}");
    }
}
