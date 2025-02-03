using System;
using System.Linq;
using UnityEngine;

namespace LumaflyLanternTracker {
    internal class LanternCollisionTracker : MonoBehaviour {

        //TODO: Check if collision is nail
        private void OnTriggerEnter2D(Collider2D other) {
            NailSlash nailSlash = HeroController.instance.GetComponent<NailSlash>();

            if (nailSlash != null) {
                if (nailSlash.gameObject != null) {
                    if (nailSlash.isActiveAndEnabled) {
                        if (other.gameObject.Equals(nailSlash.gameObject)) {
                            TrackDestroy();
                        }
                        else {
                            LumaflyLanternTrackerMod.Instance.Log($"Other != Slash: {other.name}");
                        }
                    }
                }
                else {
                    LumaflyLanternTrackerMod.Instance.Log($"Slash is null or nailSlash.isActiveAndEnabled: {nailSlash.isActiveAndEnabled}");
                }
            }
        }


        private void TrackDestroy() {

            if (gameObject.GetComponent<BoxCollider2D>() != null) {

                foreach (string[] key in LumaflyLanternDB.list.Keys) {
                    if (key.SequenceEqual(LanternKey.FromGameObject(gameObject).Serialize())) {
                        LumaflyLanternTrackerMod.Instance.Log($"Sate of {gameObject.name}: {LumaflyLanternDB.list[key]}");
                        if (LumaflyLanternDB.list[key] == LanternState.DEFAULT) {
                            LumaflyLanternDB.list[key] = LanternState.BROKEN;
                            LumaflyLanternTrackerMod.Instance.broken += 1;
                            LumaflyLanternTrackerMod.Instance.Log($"Broken +1: {LumaflyLanternTrackerMod.Instance.broken}");
                            break;
                        }
                        else {
                            LumaflyLanternTrackerMod.Instance.Log($"State was not default but was: {LumaflyLanternDB.list[key]}");
                            LumaflyLanternTrackerMod.Instance.Log($"Object: {gameObject.name}");
                        }
                    }
                }
                
            }
        }
    }
}
