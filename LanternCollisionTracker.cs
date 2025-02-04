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

            LumaflyLanternTrackerMod.Instance.UpdateUI($"scene: {gameObject.scene.name}, name: {gameObject.name}, pos: {gameObject.transform.position.x}/{gameObject.transform.position.y}");
            LumaflyLanternTrackerMod.Instance.Log($"{{new LanternKey(\"{gameObject.scene.name}\", \"{gameObject.name}\", new Vector2({gameObject.transform.position.x}f, {gameObject.transform.position.y}f)).Serialize(),LanternState.DEFAULT}},");

            if (gameObject.GetComponent<Collider2D>() != null) {

                if (LumaflyLanternDB.list.ContainsKey(LanternKey.FromGameObject(gameObject).Serialize())) {

                    if (LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] == LanternState.DEFAULT) {

                        LumaflyLanternDB.list[LanternKey.FromGameObject(gameObject).Serialize()] = LanternState.BROKEN;
                        LumaflyLanternTrackerMod.totalBroken += 1;
                        LumaflyLanternTrackerMod.brokenInRoom += 1;
                        LumaflyLanternTrackerMod.Instance.UpdateUI($"scene: {gameObject.scene.name}, name: {gameObject.name}, pos: {gameObject.transform.position.x}/{gameObject.transform.position.y}");
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
