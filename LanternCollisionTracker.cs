using System.Collections.Generic;
using UnityEngine;

namespace LanternTracker {
    internal class LanternCollisionTracker : MonoBehaviour {

        private void OnTriggerEnter2D(Collider2D other) {

            List<GameObject> list = new List<GameObject>() { 
                GetChildRecursive(HeroController.instance.gameObject, "Slash"),
                GetChildRecursive(HeroController.instance.gameObject, "AltSlash"),
                GetChildRecursive(HeroController.instance.gameObject, "DownSlash"),
                GetChildRecursive(HeroController.instance.gameObject, "UpSlash"),
                GetChildRecursive(HeroController.instance.gameObject, "Cyclone Slash"),
                GetChildRecursive(HeroController.instance.gameObject, "WallSlash"),
                GetChildRecursive(HeroController.instance.gameObject, "Great Slash"),
                GetChildRecursive(HeroController.instance.gameObject, "Dash Slash"),
                GetChildRecursive(HeroController.instance.gameObject, "Sharp Shadow"),
            };


            foreach (GameObject slashType in list) {
                if (slashType != null) {
                    
                    if (slashType.activeSelf) {
                        if (other.gameObject.Equals(slashType.gameObject)) {
                            TrackDestroy();
                            return;
                        }
                    }
                }
            }
        }

        private void TrackDestroy() {
            if (gameObject.GetComponent<Collider2D>() != null) {

                if (LanternTrackerMod.db.list.ContainsKey(LanternKey.FromGameObject(gameObject).Serialize())) {

                    if (LanternTrackerMod.db.list[LanternKey.FromGameObject(gameObject).Serialize()] == LanternState.DEFAULT) {

                        LanternTrackerMod.db.list[LanternKey.FromGameObject(gameObject).Serialize()] = LanternState.BROKEN;
                        LanternTrackerMod.totalBroken += 1;
                        LanternTrackerMod.brokenInRoom += 1;
                        LanternTrackerMod.Instance.UpdateUI($"scene: {gameObject.scene.name}, name: {gameObject.name}, pos: {gameObject.transform.position.x}/{gameObject.transform.position.y}");
                        LanternTrackerMod.Instance.LogDebug($"Broken {gameObject.name} +1: {LanternTrackerMod.totalBroken}");
                    }
                    
                } else if (gameObject.scene.name.Equals("Room_Tram") && gameObject.name.StartsWith("tram_lamp_single")) {
                    
                    LanternTrackerMod.db.list[new LanternKey(
                                                gameObject.scene.name, gameObject.name, 
                                                new Vector2(gameObject.transform.position.x, 
                                                gameObject.transform.position.y)).Serialize()] = LanternState.BROKEN;

                    LanternTrackerMod.totalBroken += 1;
                    LanternTrackerMod.brokenInRoom += 1;
                    LanternTrackerMod.Instance.UpdateUI($"scene: {gameObject.scene.name}, name: {gameObject.name}, pos: {gameObject.transform.position.x}/{gameObject.transform.position.y}");
                    LanternTrackerMod.Instance.LogDebug($"Broken {gameObject.name} +1: {LanternTrackerMod.totalBroken}");
                }
            }
        }

        public GameObject GetChildRecursive(GameObject parent, string childName) {
            foreach (Transform child in parent.transform) {
                if (child.name == childName)
                    return child.gameObject;

                GameObject result = GetChildRecursive(child.gameObject, childName);
                if (result != null)
                    return result;
            }
            return null;
        }
    }
}
