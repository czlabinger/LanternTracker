using System.Collections.Generic;
using System.Linq;

namespace LanternTracker {
    internal class StringArrayComparer : IEqualityComparer<string[]> {
        public bool Equals(string[] x, string[] y) {
            if (ReferenceEquals(x, y)) return true;
            if (x == null || y == null) return false;
            return x.SequenceEqual(y);
        }

        public int GetHashCode(string[] obj) {
            unchecked // Overflow is fine
            {
                int hash = 17;
                foreach (string s in obj) {
                    hash = hash * 23 + (s?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }
    }
}
