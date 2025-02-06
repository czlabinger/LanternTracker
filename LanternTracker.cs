using Modding;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using MagicUI.Core;
using System.Collections.Generic;

namespace LanternTracker {
    public class LanternTrackerMod : Mod, ILocalSettings<LanternDB> {

        public override string GetVersion() => "0.3.0";
        internal static LanternDB db = new LanternDB();
        internal static readonly int total = db.list.Count;
        internal static int totalBroken = 0;
        internal static int totalInRoom = 0;
        internal static int brokenInRoom = 0;

        private LanternUI ui;

        #region Genral

        private static LanternTrackerMod? _instance;
        new public string GetName() => "Lantern Tracker";


        internal static LanternTrackerMod Instance {
            get {
                if (_instance == null) {
                    throw new InvalidOperationException($"An instance of {nameof(LanternTrackerMod)} was never constructed");
                }
                return _instance;
            }
        }

        public LanternTrackerMod() : base("LanternTracker") {
            _instance = this;
        }

        #endregion

        public override void Initialize() {
            Log("Initializing LanternTracker");
            base.Initialize();

            ui = new LanternUI();
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += AttachTracker;
            ModHooks.SavegameSaveHook += AfterSaveLoad;

            Log("Initialized LanternTracker");
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

                if ( gameObject.name.Equals("_Scenery") || gameObject.name.Equals("station_pole") || 
                    gameObject.name.Equals("tram_lamps") && newScene.name.Equals("Room_Tram")) {
                    
                    Log($"{newScene.name}, checking rec: {gameObject.name}");
                    CheckChildrenRecursive(gameObject.transform);
                }

                if (db.list.ContainsKey(LanternKey.FromGameObject(gameObject).Serialize())) {
                    gameObject.AddComponent<LanternCollisionTracker>();
                    totalInRoom++;

                    if (db.list[LanternKey.FromGameObject(gameObject).Serialize()] == LanternState.BROKEN) {
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
                if (db.list.ContainsKey(LanternKey.FromGameObject(child.gameObject).Serialize())) {
                    child.gameObject.AddComponent<LanternCollisionTracker>();
                    totalInRoom++;
                    LogDebug($"Adding tracker to: {child.gameObject.name}");
                } else if (child.gameObject.scene.name.Equals("Room_Tram") && child.gameObject.name.StartsWith("tram_lamp_single")) {
                    
                    child.gameObject.AddComponent<LanternCollisionTracker>();
                    totalInRoom++;
                    LogDebug($"Adding tracker to: {child.gameObject.name}");
                }

                CheckChildrenRecursive(child);
            }
        }


        void ILocalSettings<LanternDB>.OnLoadLocal(LanternDB s) {
            db = s;
        }

        LanternDB ILocalSettings<LanternDB>.OnSaveLocal() {
            return db;
        }
    }
}
