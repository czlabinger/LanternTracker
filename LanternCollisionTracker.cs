using System.Collections.Generic;
using UnityEngine;

namespace LumaflyLanternTracker {
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

            if (gameObject.GetComponent<BoxCollider2D>() != null) {

                if (LumaflyLanternDB.list.ContainsKey(LanternKey.FromGameObject(gameObject).Serialize())) {

                    if (LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] == LanternState.DEFAULT) {

                        LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] = LanternState.BROKEN;
                        LumaflyLanternTrackerMod.totalBroken += 1;
                        LumaflyLanternTrackerMod.brokenInRoom += 1;
                        LumaflyLanternTrackerMod.Instance.UpdateUI(gameObject.name);
                        LumaflyLanternTrackerMod.Instance.LogDebug($"Broken {gameObject.name} +1: {LumaflyLanternTrackerMod.totalBroken}");
                        
                    }
                    
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
