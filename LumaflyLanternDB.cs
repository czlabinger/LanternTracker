using System.Collections.Generic;
using UnityEngine;

namespace LumaflyLanternTracker {
    internal class LumaflyLanternDB {


        //Serialized LanternKey, LanternState
        internal static Dictionary<string[], LanternState> list = new Dictionary<string[], LanternState>
        {
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (1)", new Vector2(13.04f, 10.87f)).Serialize(), LanternState.DEFAULT },
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (2)", new Vector2(19.23f, 11.66f)).Serialize(), LanternState.DEFAULT },
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (4)", new Vector2(6.29f, 11.34f)).Serialize(), LanternState.DEFAULT },
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (5)", new Vector2(16.89f, 11.68f)).Serialize(), LanternState.DEFAULT },
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (7)", new Vector2(9.66f, 11.26f)).Serialize(), LanternState.DEFAULT },
        };

    }
}
