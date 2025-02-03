using Modding;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LumaflyLanternTracker {
    public class LumaflyLanternTrackerMod : Mod {

        public override string GetVersion() => "0.2.0";
        internal static readonly int total = LumaflyLanternDB.list.Count;
        internal static int totalBroken = 0;
        internal static int totalInRoom = 0;
        internal static int brokenInRoom = 0;

        private LumaflyLanternUI ui;

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

            ui = new LumaflyLanternUI();
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += AttachTracker;

            Log("Initialized LumaflyLanternTracker");
        }

        private void AttachTracker(Scene oldScene, Scene newScene) {
            totalInRoom = 0;
            brokenInRoom = 0;

            foreach (GameObject gameObject in newScene.GetRootGameObjects()) {

                if (LumaflyLanternDB.list.ContainsKey(LanternKey.FromGameObject(gameObject).Serialize())) {
                    gameObject.AddComponent<LanternCollisionTracker>();
                    totalInRoom++;
                        
                    if (LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] == LanternState.BROKEN) {
                        brokenInRoom ++;
                    }
                    LogDebug($"in room: {totalInRoom}, broken in room: {brokenInRoom}, total broken: {totalBroken}");
                }
                
            }
            UpdateUI();
        }

        internal void UpdateUI() {
            ui.TotalCounter.Text = $"{totalBroken}/{total}";
            ui.RoomCounter.Text = $"{brokenInRoom}/{totalInRoom}";
        }
    }
}
