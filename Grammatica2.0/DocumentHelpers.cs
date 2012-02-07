using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Drawing;

namespace Grammatica2._0 {
    class DocumentHelpers {
        public static void UpdateDocumentPieces(RichEditControl richEdit, IEnumerable<TextPiece> currentPieces) {
            CharacterProperties allProp = richEdit.Document.BeginUpdateCharacters(richEdit.Document.Range);
            try {
                allProp.BackColor = richEdit.Document.DefaultCharacterProperties.BackColor;
            } finally {
                richEdit.Document.EndUpdateCharacters(allProp);
            }
            if (currentPieces == null) return;
            foreach (var piece in currentPieces) {
                DocumentRange range = richEdit.Document.CreateRange(piece.Start, piece.Length);
                CharacterProperties properties = richEdit.Document.BeginUpdateCharacters(range);
                try {
                    properties.BackColor = Color.LightBlue;
                } finally {
                    richEdit.Document.EndUpdateCharacters(properties);
                }
            }
        }

        public static void AddSelection(RichEditControl richEdit, IList<TextPiece> currentPieces) {
            int start = richEdit.Document.Selection.Start.ToInt();
            int length = richEdit.Document.Selection.Length;
            if (length == 0) return;
            for (int i = 0; i < currentPieces.Count; i++) {
                TextPiece currentP = currentPieces[i];
                if (currentP.Start == start && currentP.Length == length) {
                    return;
                }
                if ((currentP.Start >= start && currentP.Start <= start + length) || ((currentP.Start + currentP.Length) >= start && (currentP.Start + currentP.Length) <= start + length)
                    || (start >= currentP.Start && start <= currentP.Start + currentP.Length) || ((start + length) >= currentP.Start && (start + length) <= currentP.Start + currentP.Length)) {
                    return;
                }
            }
            currentPieces.Add(new TextPiece(start, length));            
        }
        public static void RemoveSelection(RichEditControl richEdit, IList<TextPiece> currentPieces) {
            int start = richEdit.Document.Selection.Start.ToInt();
            int length = richEdit.Document.Selection.Length;
            int foundIndex = -1;
            for (int i = 0; i < currentPieces.Count; i++) {
                TextPiece currentP = currentPieces[i];
                if ((currentP.Start >= start && currentP.Start <= start + length) || ((currentP.Start + currentP.Length) >= start && (currentP.Start + currentP.Length) <= start + length)
                    || (start >= currentP.Start && start <= currentP.Start + currentP.Length) || ((start + length) >= currentP.Start && (start + length) <= currentP.Start + currentP.Length)) {
                    foundIndex = i;
                    break;
                }
            }
            if (foundIndex >= 0) {
                currentPieces.RemoveAt(foundIndex);
            }
        }

        public static bool AlmostCorrectPieces(IList<TextPiece> currentPieces, IList<TextPiece> checkPieces) {
            if(checkPieces == null) return true;
            Dictionary<int, bool> usedPieceDict = new Dictionary<int, bool>();
            if(currentPieces.Count != checkPieces.Count) return false;
            foreach (var checkPiece in checkPieces) {
                int checkStart = checkPiece.Start;
                int checkEnd = checkPiece.Start + checkPiece.Length;
                bool found = false;
                for (int i = 0; i < currentPieces.Count; i++) {
                    if (usedPieceDict.ContainsKey(i)) continue;
                    int currentStart = currentPieces[i].Start;
                    int currentEnd = currentPieces[i].Start + currentPieces[i].Length;
                    if (Math.Abs(checkStart - currentStart) <= 1 && Math.Abs(checkEnd - currentEnd) <= 1) {
                        found = true;
                        usedPieceDict[i] = true;
                        break;
                    }
                }
                if (!found) return false;
            }
            return true;
        }
    }
}
