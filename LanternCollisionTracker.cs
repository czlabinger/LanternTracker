using System.Collections.Generic;
using System.Linq;
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

                foreach (string[] key in LumaflyLanternDB.list.Keys) {
                    if (key.SequenceEqual(LanternKey.FromGameObject(gameObject).Serialize())) {

                        if (LumaflyLanternDB.list[key] == LanternState.DEFAULT) {
                            LumaflyLanternDB.list[key] = LanternState.BROKEN;
                            LumaflyLanternTrackerMod.broken += 1;
                            LumaflyLanternTrackerMod.Instance.LogDebug($"Broken {gameObject.name} +1: {LumaflyLanternTrackerMod.broken}");
                            //TODO: Save in DB
                            break;
                        }
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
