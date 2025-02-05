using Modding;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using MagicUI.Core;
using System.Text;

namespace LumaflyLanternTracker {
    public class LumaflyLanternTrackerMod : Mod {

        public override string GetVersion() => "0.2.1";
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
            ModHooks.SavegameSaveHook += AfterSaveLoad;

            Log("Initialized LumaflyLanternTracker");
        }

        private void AttachTracker(Scene oldScene, Scene newScene) {
            totalInRoom = 0;
            brokenInRoom = 0;

            if (newScene.name.StartsWith("Menu_") ||
                newScene.name.StartsWith("Intro_") ||
                newScene.name.StartsWith("Pre_Menu_") ||
                newScene.name.StartsWith("BetaEnd") ||
                newScene.name.StartsWith("End_")) {

                    ui.vstack.Visibility = Visibility.Hidden;
            } else {
                ui.vstack.Visibility = Visibility.Visible;
            }

            foreach (GameObject gameObject in newScene.GetRootGameObjects()) {

                gameObject.AddComponent<LumaflyLanternCollisionTracker>();
                Log($"Adding tracker to: {gameObject.name}");

                StringBuilder sb = new StringBuilder();
                PrintChildrenRecursive(gameObject.transform, 0, sb);
                Log(sb.ToString());

                if ( gameObject.name.Equals("_Scenery") || gameObject.name.Equals("station_pole") || gameObject.name.Equals("tram_lamps")) {
                    CheckChildrenRecursive(gameObject.transform);
                }

                if (LumaflyLanternDB.list.ContainsKey(LumaflyLanternKey.FromGameObject(gameObject).Serialize())) {
                    //gameObject.AddComponent<LanternCollisionTracker>();
                    totalInRoom++;

                    if (LumaflyLanternDB.list[LumaflyLanternKey.FromGameObject(gameObject).Serialize()] == LumaflyLanternState.BROKEN) {
                        brokenInRoom++;
                    }
                    LogDebug($"in room: {totalInRoom}, broken in room: {brokenInRoom}, total broken: {totalBroken}");
                }

            }
            UpdateUI("");
        }

        private void AfterSaveLoad(int sg) {
            ui.vstack.Visibility = Visibility.Visible;
        }

        internal void UpdateUI(string broken) {
            ui.TotalCounter.Text = $"{totalBroken}/{total}";
            ui.RoomCounter.Text = $"{brokenInRoom}/{totalInRoom}";
            ui.DBBuildHelper.Text = $"You broke {broken}";
        }

        private void CheckChildrenRecursive(Transform parent) {
            foreach (Transform child in parent) {
                //if (LumaflyLanternDB.list.ContainsKey(LanternKey.FromGameObject(child.gameObject).Serialize())) {
                    child.gameObject.AddComponent<LumaflyLanternCollisionTracker>();
                    totalInRoom++;
                    Log($"Adding tracker to: {child.gameObject.name}");
                //}
                CheckChildrenRecursive(child);
            }
        }

        private void PrintChildrenRecursive(Transform parent, int depth, StringBuilder sb) {
            string indent = new string(' ', depth * 2);
            sb.AppendLine($"{indent}{parent.name}");

            foreach (Transform child in parent) {
                PrintChildrenRecursive(child, depth + 1, sb);
            }
        }
    }
}
