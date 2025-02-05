using System;
using System.Text;
using UnityEngine;

namespace LumaflyLanternTracker {

    readonly struct LumaflyLanternKey {

        public readonly string SceneName;
        public readonly string ObjectName;
        public readonly Vector2 Position;
        private const int SerializationTokens = 4;

        public LumaflyLanternKey(string sceneName, string objectName, Vector2 position) {
            this.SceneName = sceneName;
            this.ObjectName = objectName;
            this.Position = position;
        }

        public static LumaflyLanternKey FromGameObject(GameObject obj) {
            return new LumaflyLanternKey(obj.scene.name, obj.name, new Vector2(obj.transform.position.x, obj.transform.position.y));
        }

        private (string, string, Vector2) ToTuple() {
            return (SceneName, ObjectName, Position);
        }

        public override int GetHashCode() {
            return ToTuple().GetHashCode();
        }

        public override bool Equals(object obj) {
            if (obj is LumaflyLanternKey otherLantern) {
                return ToTuple().Equals(otherLantern.ToTuple());
            }
            else {
                return false;
            }
        }

        public static bool operator ==(LumaflyLanternKey left, LumaflyLanternKey right) {
            return left.Equals(right);
        }

        public static bool operator !=(LumaflyLanternKey left, LumaflyLanternKey right) {
            return !left.Equals(right);
        }

        public override string ToString() {
            return $"{SceneName}/{ObjectName} ({Position.x}/{Position.y})";
        }

        private static string ToBase64(string str) {
            return Convert.ToBase64String(
                // Read "Unicode" as UTF-16
                Encoding.Unicode.GetBytes(str));
        }

        // Decodes a base 64 string into what should be valid UTF-16 which we
        // then convert to a string (which should be a no-op for the same
        // reason as above).
        private static string StringFromBase64(string str) {
            return Encoding.Unicode.GetString(
                Convert.FromBase64String(str));
        }

        private static string ToBase64(float num) {
            byte[] bytes = BitConverter.GetBytes(num);
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(bytes);
            }

            return Convert.ToBase64String(bytes);
        }

        private static float FloatFromBase64(string str) {
            byte[] bytes = Convert.FromBase64String(str);
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(bytes);
            }

            return BitConverter.ToSingle(bytes, 0);
        }

        public string[] Serialize() {
            return [
                ToBase64(SceneName),
                ToBase64(ObjectName),
                ToBase64(Position.x),
                ToBase64(Position.y),
            ];
        }

        public static LumaflyLanternKey Deserialize(string[] serialized) {
            if (serialized.Length != SerializationTokens) {
                throw new ArgumentException(
                    $"Got {serialized.Length} tokens for " +
                    $"LanternKey.Deserialize. Expected " +
                    $"{SerializationTokens}.");
            }

            return new LumaflyLanternKey(
                StringFromBase64(serialized[0]),
                StringFromBase64(serialized[1]),
                new Vector2(
                    FloatFromBase64(serialized[2]),
                    FloatFromBase64(serialized[3])));
        }

        public static LumaflyLanternKey FromSerializedString(string serialized) {
            return Deserialize(serialized.Split(';'));

        }
    }
}
