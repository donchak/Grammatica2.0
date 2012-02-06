using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Grammatica2._0 {
    public class GramText : XPLiteObject {
        private Guid oid;
        [Key(true)]
        public Guid Oid {
            get { return oid; }
            set { SetPropertyValue("Oid", ref oid, value); }
        }
        private string title;
        public string Title {
            get { return title; }
            set { SetPropertyValue("Title", ref title, value); }
        }
        private string text;
        [Size(SizeAttribute.Unlimited)]
        public string Text {
            get { return text; }
            set { SetPropertyValue("Text", ref text, value); }
        }
        [Association("GramText-Tests"), Aggregated]
        public XPCollection<GramTest> Tests {
            get {
                return GetCollection<GramTest>("Tests");
            }
        }
        public GramText(Session session)
            : base(session) {
        }
    }
    public class GramTest : XPLiteObject {
        private Guid oid;
        [Key(true)]
        public Guid Oid {
            get { return oid; }
            set { SetPropertyValue("Oid", ref oid, value); }
        }
        private int num;
        public int Num {
            get { return num; }
            set { SetPropertyValue("Num", ref num, value); }
        }
        private string title;
        public string Title {
            get { return title; }
            set { SetPropertyValue("Title", ref title, value); }
        }
        private GramText text;
        [Association("GramText-Tests")]
        public GramText Text {
            get { return text; }
            set { SetPropertyValue<GramText>("Text", ref text, value); }
        }
        private ReadOnlyCollection<TextPiece> pieces;
        [ValueConverter(typeof(TextPiecesConverter))]
        public ReadOnlyCollection<TextPiece> Pieces {
            get { return pieces; }
            set { SetPropertyValue("Pieces", ref pieces, value); }
        }
        private string question;
        public string Question {
            get { return question; }
            set { SetPropertyValue("Question", ref question, value); }
        }
        [PersistentAlias("ToStr(Num) + ': ' + Title")]
        public string DisplayName {
            get { return (string)EvaluateAlias("DisplayName"); }
        }
        public GramTest(Session session)
            : base(session) {
        }
    }

    public class TextPiece {
        public int Start;
        public int Length;
        public TextPiece(int start, int length) {
            Start = start;
            Length = length;
        }
        public TextPiece(string str) {
            string[] parts = str.Split('-');
            int start;
            int length;
            if (parts.Length == 2 && int.TryParse(parts[0], out start) && int.TryParse(parts[1], out length)) {
                Start = start;
                Length = length;
            }
        }
        public override string ToString() {
            return string.Format("{0}-{1}", Start, Length);
        }        
    }

    public class TextPiecesConverter : ValueConverter {
        public override object ConvertFromStorageType(object value) {
            if (value == null) return null;
            string[] pieces = ((string)value).Split(';');
            TextPiece[] pieceArray = new TextPiece[pieces.Length];
            for (int i = 0; i < pieces.Length; i++) {
                pieceArray[i] = new TextPiece(pieces[i]);
            }
            return Array.AsReadOnly<TextPiece>(pieceArray);
        }
        public override object ConvertToStorageType(object value) {            
            if(value == null) return null;
            ReadOnlyCollection<TextPiece> list = (ReadOnlyCollection<TextPiece>)value;
            StringBuilder sb = new StringBuilder();
            foreach (TextPiece item in list) {
                if (sb.Length > 0) {
                    sb.Append(";");
                }
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
        public override Type StorageType {
            get { return typeof(string); }
        }
    }

}