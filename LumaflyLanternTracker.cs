using GlobalEnums;
using Modding;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace LumaflyLanternTracker {
    public class LumaflyLanternTrackerMod : Mod {

        public override string GetVersion() => "0.1.7";
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

            ModHooks.AttackHook += CheckDestroy;

            /*            Log(string.Join(", ", new LanternKey("Ruins1_29", "ruind_dressing_light_03 (1)", new Vector2(13.04f, 10.87f)).Serialize()));
                        Log(string.Join(", ", new LanternKey("Ruins1_29", "ruind_dressing_light_03 (2)", new Vector2(19.23f, 11.66f)).Serialize()));
                        Log(string.Join(", ", new LanternKey("Ruins1_29", "ruind_dressing_light_03 (4)", new Vector2(6.29f, 11.34f)).Serialize()));
                        Log(string.Join(", ", new LanternKey("Ruins1_29", "ruind_dressing_light_03 (5)", new Vector2(16.89f, 11.68f)).Serialize()));
                        Log(string.Join(", ", new LanternKey("Ruins1_29", "ruind_dressing_light_03 (7)", new Vector2(9.66f, 11.26f)).Serialize()));*/


            Log("Initialized LumaflyLanternTracker");
        }

        private void CheckDestroy(AttackDirection dir) {
            foreach (GameObject gameObject in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects()) {
                Log($"Checking GO with name: {gameObject.name}");
                if (gameObject.GetComponent<BoxCollider2D>() != null) {

                    GameObject slash = HeroController.instance.transform.Find("Attacks/Slash").gameObject;

                    Log($"HasCollider: {gameObject.name}");

                    if (slash != null) {

                        Log($"GO: {gameObject.GetComponent<BoxCollider2D>().bounds} / slash: {slash.GetComponent<PolygonCollider2D>().bounds}");

                        //TODO: Not working
                        if (AreCollidersOverlapping(gameObject.GetComponent<BoxCollider2D>(), slash.GetComponent<PolygonCollider2D>())) {
                            Log("a");
                            if (LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] == LanternState.DEFAULT) {
                                Log("b");
                                LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] = LanternState.BROKEN;
                                broken += 1;
                                Log($"Broken +1: {broken}");
                            }
                        }
                    }
                    else {
                        LogError("Slash is null");
                    }
                }
            }
        }

        public static bool AreCollidersOverlapping(Collider2D collider1, Collider2D collider2) {
            ContactFilter2D filter = new ContactFilter2D().NoFilter();
            List<Collider2D> results = new List<Collider2D>();
            if (Physics2D.OverlapCollider(collider1, filter, results) > 0) {
                return results.Contains(collider2);
            }
            return false;
        }
    }
}
