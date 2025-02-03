using GlobalEnums;
using Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LumaflyLanternTracker {
    public class LumaflyLanternTrackerMod : Mod {

        public override string GetVersion() => "0.1.8";
        internal int broken = 0;

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
                        Log($"Attaching tracker to: {gameObject.name}");
                        gameObject.AddComponent<LanternCollisionTracker>();
                        break;
                    }
                }
            }
        }
    }
}
