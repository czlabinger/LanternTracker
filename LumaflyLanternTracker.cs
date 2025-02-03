using Modding;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LumaflyLanternTracker {
    public class LumaflyLanternTrackerMod : Mod {

        public override string GetVersion() => "0.2.0";
        internal static readonly int total = LumaflyLanternDB.list.Count;
        internal static int broken = 0;
        internal static int totalInRoom = 0;
        internal static int brokenInRoom = 0;

        #region Genral

        private static LumaflyLanternTrackerMod? _instance;
        new public string GetName() => "Lumafly tracker";


        internal static LumaflyLanternTrackerMod Instance {
            get {
                if (_instance == null) {
                    throw new InvalidOperationException($"An instance of {nameof(LumaflyLanternTrackerMod)} was never constructed");
                }
                return _instance;
            }
        }

        public LumaflyLanternTrackerMod() : base("LumaflyLanternTracker") {
            _instance = this;
        }

        #endregion

        public override void Initialize() {
            Log("Initializing LumaflyLanternTracker");
            base.Initialize();

            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += AttachTracker;

            Log("Initialized LumaflyLanternTracker");
        }

        private void AttachTracker(Scene oldScene, Scene newScene) {

            foreach (GameObject gameObject in newScene.GetRootGameObjects()) {
                foreach (string[] key in LumaflyLanternDB.list.Keys) {
                     
                    if (key.SequenceEqual(LanternKey.FromGameObject(gameObject).Serialize())) {
                        gameObject.AddComponent<LanternCollisionTracker>();
                        break;
                    }
                }
            }
        }
    }
}
