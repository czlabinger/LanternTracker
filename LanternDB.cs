using System.Collections.Generic;
using UnityEngine;

namespace LanternTracker {
    internal class LanternDB {

        //Serialized LanternKey, LanternState
        internal static readonly Dictionary<string[], LanternState> list = new Dictionary<string[], LanternState>(new StringArrayComparer())
        {
            #region Forgotten Crossroads
            
            // Crossroads_03
            {new LanternKey("Crossroads_03", "Stag_Pole_Break", new Vector2(7.152f, 9.695121f)).Serialize(),LanternState.DEFAULT},
            
            // Stag
            {new LanternKey("Crossroads_47", "Stag_Pole_Tall_Break (2)", new Vector2(15.91f, 8.35f)).Serialize(),LanternState.DEFAULT},

            // Crossroads_46
            {new LanternKey("Crossroads_46", "Stag_Pole_Tall_Break (2)", new Vector2(8.088165f, 13.04021f)).Serialize(),LanternState.DEFAULT},

            // Tram
            {new LanternKey("Room_Tram_RG", "tram_lamp_single (3)", new Vector2(25.89927f, 15.56113f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram_RG", "tram_lamp_single (4)", new Vector2(29.41577f, 15.56113f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram_RG", "tram_lamp_single (2)", new Vector2(22.53327f, 15.56113f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram_RG", "tram_lamp_single (1)", new Vector2(18.81027f, 15.56113f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram_RG", "tram_lamp_single", new Vector2(15.50727f, 15.56113f)).Serialize(), LanternState.DEFAULT},

            // Crossroads_49
            {new LanternKey("Crossroads_49", "Stag_Pole_Tall_Break", new Vector2(25.51f, 162.71f)).Serialize(), LanternState.DEFAULT},

            //TODO: Mender room

            #endregion

            #region Greenpath
            // Bench
            {new LanternKey("Fungus1_01b", "fung_lamp3", new Vector2(20.53f, 34.22f)).Serialize(),LanternState.DEFAULT},

            // Funguns1_10
            {new LanternKey("Fungus1_10", "fung_lamp3 (1)", new Vector2(143.35f, 10.89803f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus1_10", "fung_lamp3", new Vector2(126.62f, 10.89803f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus1_10", "fung_lamp2", new Vector2(58.89f, 10.69f)).Serialize(),LanternState.DEFAULT},

            // Fungus1_11
            {new LanternKey("Fungus1_11", "fung_lamp2", new Vector2(27.79021f, 19.69721f)).Serialize(),LanternState.DEFAULT},

            // Fungus1_19
            {new LanternKey("Fungus1_19", "fung_lamp2", new Vector2(59.51746f, 10.64184f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus1_19", "fung_lamp3", new Vector2(29.34f, 7.98f)).Serialize(),LanternState.DEFAULT},

            //Fungus1_22
            {new LanternKey("Fungus1_22", "Stag_Pole_Break", new Vector2(10.94482f, 104.61f)).Serialize(),LanternState.DEFAULT},

            // Fungun1_31
            {new LanternKey("Fungus1_31", "fung_lamp2 (1)", new Vector2(30.05f, 32.63f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus1_31", "fung_lamp2", new Vector2(17.7f, 60.71f)).Serialize(),LanternState.DEFAULT},

            // Stag
            {new LanternKey("Fungus1_16_alt", "Stag_Pole_Tall_Break (2)", new Vector2(15.91f, 8.35f)).Serialize(),LanternState.DEFAULT},

            // Fungus1_04
            {new LanternKey("Fungus1_04", "fung_lamp2", new Vector2(9.72849f, 7.601756f)).Serialize(),LanternState.DEFAULT},

            #endregion

            #region Fungal Wastes

            // Fungus2_03
            {new LanternKey("Fungus2_03", "Stag_Pole_Break", new Vector2(11.39f, 15.66789f)).Serialize(),LanternState.DEFAULT},
            
            // Queens
            {new LanternKey("Fungus2_01", "fung_lamp2 (1)", new Vector2(39.09f, 41.66f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus2_01", "fung_lamp4", new Vector2(22.15341f, 39.96693f)).Serialize(),LanternState.DEFAULT},
            
            
            //{new LLanternKey("Fungus2_01", "Stag_Pole_Break", new Vector2(8.612524f, 19.65337f)).Serialize(),LanternState.DEFAULT}, 
            
            
            {new LanternKey("Fungus2_01", "fung_lamp5", new Vector2(22.73f, 17.04f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus2_01", "Stag_Pole_Break (1)", new Vector2(7.16f, 6.7f)).Serialize(),LanternState.DEFAULT},

            // Stag
            {new LanternKey("Fungus2_02", "Stag_Pole_Tall_Break (2)", new Vector2(15.91f, 8.35f)).Serialize(),LanternState.DEFAULT},

            // Fungus2_10
            {new LanternKey("Fungus2_10", "fung_lamp3", new Vector2(24.19f, 17.05f)).Serialize(),LanternState.DEFAULT},

            // Fungus2_13
            {new LanternKey("Fungus2_13", "Stag_Pole_Tall_Break (2)", new Vector2(17.94415f, 9.5745f)).Serialize(),LanternState.DEFAULT},

            #endregion

            #region City Of Tears

            // Ruins1_01
            {new LanternKey("Ruins1_01", "ruind_dressing_light_08 (1)", new Vector2(75.22f, 22.54f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_01", "ruind_dressing_light_08", new Vector2(81.62f, 22.15f)).Serialize(),LanternState.DEFAULT},

            // Ruins1_02
            {new LanternKey("Ruins1_02", "ruind_dressing_light_03", new Vector2(30.79f, 49.7f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_04", new Vector2(27.69f, 47.45f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_05", new Vector2(19.35f, 49.63f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_09", new Vector2(16.21f, 20.37f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_10", new Vector2(19.9f, 19.03f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_12", new Vector2(27.09f, 19.65f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_13", new Vector2(32.29f, 19.76f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_02", "ruind_dressing_light_11", new Vector2(8.77f, 6.54f)).Serialize(),LanternState.DEFAULT},

            //Ruins1_05c
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_03 (12)", new Vector2(36.25f, 42.68f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (8)", new Vector2(31.93f, 64.86f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (12)", new Vector2(13.021f, 71.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (7)", new Vector2(6.9294f, 80.97f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (4)", new Vector2(8.52f, 96.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (5)", new Vector2(13.141f, 96.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (6)", new Vector2(17.66f, 96.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (11)", new Vector2(34.19f, 96.07f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05c", "ruind_dressing_light_02 (9)", new Vector2(50.05f, 95.96f)).Serialize(),LanternState.DEFAULT},

            //Ruins1_05
            {new LanternKey("Ruins1_05", "ruind_dressing_light_02 (10)", new Vector2(55.4f, 114.07f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_03", new Vector2(55.85f, 127.38f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_03 (4)", new Vector2(53.21f, 138.43f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_03 (5)", new Vector2(56.13f, 144.54f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_02 (2)", new Vector2(9.5399f, 119.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_02 (1)", new Vector2(14.39f, 119.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_02 (3)", new Vector2(19.26f, 119.11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_05", "ruind_dressing_light_02", new Vector2(14.1f, 129.9f)).Serialize(),LanternState.DEFAULT},

            //Ruins1_06
            {new LanternKey("Ruins1_06", "ruind_dressing_light_03 (3)", new Vector2(55.24f, 24.03f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_06", "ruind_dressing_light_03 (5)", new Vector2(72.33f, 24.7f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_06", "ruind_dressing_light_03 (4)", new Vector2(43.14f, 24.41f)).Serialize(),LanternState.DEFAULT},

            //Ruins1_17
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (4)", new Vector2(76.81f, 6.35f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (2)", new Vector2(72.94f, 8.06f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (1)", new Vector2(67.49f, 6.9f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (5)", new Vector2(15.5f, 6.32f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (6)", new Vector2(8.21f, 7.23f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (7)", new Vector2(75.69f, 30.38f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (8)", new Vector2(70.86f, 43f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (9)", new Vector2(78.55f, 42.51f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (10)", new Vector2(68.77f, 54.98f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (11)", new Vector2(72.4f, 53.93f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_17", "ruind_dressing_light_03 (12)", new Vector2(78.51f, 54.77f)).Serialize(),LanternState.DEFAULT},

            //Ruins1_28
            {new LanternKey("Ruins1_28", "ruind_dressing_light_03 (2)", new Vector2(80.92f, 7.71f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_28", "ruind_dressing_light_03 (5)", new Vector2(14.13f, 13.48f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_28", "ruind_dressing_light_03 (4)", new Vector2(10.18f, 12.53f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_28", "ruind_dressing_light_03 (3)", new Vector2(3.73f, 13.02f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_28", "Stag_Pole_Break", new Vector2(111.6665f, 19.66169f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_28", "ruind_dressing_light_03", new Vector2(106.69f, 21.25f)).Serialize(),LanternState.DEFAULT},


            //Ruins1_29
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (4)", new Vector2(6.29f, 11.34f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (1)", new Vector2(13.04f, 10.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_29", "ruind_dressing_light_03 (2)", new Vector2(19.23f, 11.66f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_29", "Stag_Pole_Tall_Break (2)", new Vector2(32.2386f, 8.360001f)).Serialize(),LanternState.DEFAULT},


            //Ruins1_23
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (7)", new Vector2(20.95f, 8.61f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (6)", new Vector2(41.89f, 13.73f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (5)", new Vector2(36.37f, 33.41f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (4)", new Vector2(13.17f, 42.1f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (3)", new Vector2(35.18f, 44.64f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (1)", new Vector2(30.86f, 53.2f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (2)", new Vector2(21.42f, 53.45f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2", new Vector2(28.35f, 68.25f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_23", "ruin_detail_lamp2 (8)", new Vector2(13.68f, 77.43f)).Serialize(),LanternState.DEFAULT},


            //Ruins1_25
            {new LanternKey("Ruins1_25", "ruin_detail_lamp2", new Vector2(7.96f, 26.04f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_25", "ruin_detail_lamp2 (1)", new Vector2(3.33f, 43.16f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_25", "ruin_detail_lamp2 (2)", new Vector2(5.53f, 80.28f)).Serialize(),LanternState.DEFAULT},


            //Ruins1_30
            {new LanternKey("Ruins1_30", "ruin_detail_lamp2 (4)", new Vector2(70.85f, 8.59f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruin_detail_lamp2 (2)", new Vector2(53.19f, 8.12f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruin_detail_lamp2", new Vector2(59.68f, 25.1f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruin_detail_lamp2 (3)", new Vector2(54.28f, 25.07f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruin_detail_lamp2 (1)", new Vector2(9.06f, 18.13f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruin_detail_lamp2 (5)", new Vector2(6.79f, 30.89f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (8)", new Vector2(8.72f, 29.96f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (7)", new Vector2(14.81f, 31.45f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (4)", new Vector2(19.7f, 30.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (3)", new Vector2(25.571f, 56.26f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (1)", new Vector2(32.75f, 59.1f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (2)", new Vector2(36.5f, 59.9f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03", new Vector2(47.45881f, 59.6f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_30", "ruind_dressing_light_03 (5)", new Vector2(58.75f, 56.2f)).Serialize(),LanternState.DEFAULT},
            
            //Ruins1_32
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2 (7)", new Vector2(42.25f, 54.41f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2 (6)", new Vector2(28.36f, 38.92f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2 (5)", new Vector2(38.39f, 81.98f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2 (2)", new Vector2(22.27f, 81.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2 (4)", new Vector2(36.93f, 102.26f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2", new Vector2(11.31f, 70.12f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_32", "ruin_detail_lamp2 (1)", new Vector2(21.4f, 70.12f)).Serialize(),LanternState.DEFAULT},

            //Ruins1_18
            {new LanternKey("Ruins1_18", "ruind_dressing_light_02 (4)", new Vector2(77.49f, 24.42f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_18", "ruind_dressing_light_02 (3)", new Vector2(64.32f, 24.42f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_18", "ruind_dressing_light_02 (2)", new Vector2(51.19f, 24.42f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_18", "ruind_dressing_light_02 (1)", new Vector2(37.63f, 24.42f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_18", "ruind_dressing_light_02", new Vector2(24.72f, 24.42f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins1_18", "ruind_dressing_light_02 (5)", new Vector2(11.29f, 24.26f)).Serialize(),LanternState.DEFAULT},

            //Ruins2_04
            {new LanternKey("Ruins2_04", "Stag_Pole_Break", new Vector2(140.0139f, 7.65847f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_04", "Stag_Pole_Break (1)", new Vector2(135.19f, 51.65f)).Serialize(),LanternState.DEFAULT},

            //Ruins_House_02
            {new LanternKey("Ruins_House_02", "ruind_dressing_light_03", new Vector2(20.45f, 16.35f)).Serialize(),LanternState.DEFAULT},

            //Ruins_House_01
            {new LanternKey("Ruins_House_01", "ruind_dressing_light_03", new Vector2(20.45f, 16.35f)).Serialize(),LanternState.DEFAULT},

            //Abyss_01
            {new LanternKey("Abyss_01", "Stag_Pole_Tall_Break (2)", new Vector2(25.09f, 162.28f)).Serialize(),LanternState.DEFAULT},

            //Ruins2_06
            {new LanternKey("Ruins2_06", "Stag_Pole_Break", new Vector2(48.90189f, 6.639233f)).Serialize(),LanternState.DEFAULT}, 
            {new LanternKey("Ruins2_06", "Stag_Pole_Break (1)", new Vector2(39.17262f, 32.64556f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_07", "ruind_dressing_light_03 (1)", new Vector2(15.67f, 10.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_07", "ruind_dressing_light_03 (3)", new Vector2(24.13f, 11f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_07", "Stag_Pole_Tall_Break (2)", new Vector2(32.62f, 8.42f)).Serialize(),LanternState.DEFAULT},


            //Ruins2_08
            {new LanternKey("Ruins2_08", "ruind_dressing_light_03 (1)", new Vector2(13.04f, 10.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_08", "ruind_dressing_light_03 (3)", new Vector2(24.13f, 11.49f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_08", "Stag_Pole_Tall_Break", new Vector2(33.09f, 8.79f)).Serialize(),LanternState.DEFAULT},

            //Ruins2_09
            {new LanternKey("Ruins2_09", "ruind_dressing_light_03 (2)", new Vector2(33.69f, 16.45f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_09", "ruind_dressing_light_03 (1)", new Vector2(50.88f, 14.7f)).Serialize(),LanternState.DEFAULT},

            //Ruins_Elevator
            {new LanternKey("Ruins_Elevator", "ruind_dressing_light_03", new Vector2(19.4f, 10.62f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins_Elevator", "ruind_dressing_light_03 (1)", new Vector2(24.51f, 33.68f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins_Elevator", "ruind_dressing_light_03 (2)", new Vector2(36.63f, 56.46f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins_Elevator", "ruind_dressing_light_03 (4)", new Vector2(23.92f, 100.66f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins_Elevator", "ruind_dressing_light_03 (5)", new Vector2(36.53f, 100.66f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins_Elevator", "ruind_dressing_light_03 (6)", new Vector2(23.92f, 122.39f)).Serialize(),LanternState.DEFAULT},

            #endregion

            #region Crystal Peak

            //Mines_01
            {new LanternKey("Mines_01", "mine_globe_04", new Vector2(4.92f, 7f)).Serialize(),LanternState.DEFAULT},

            //Mines_02
            {new LanternKey("Mines_02", "mine_globe_01 (6)", new Vector2(35.1f, 9.65f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_02", "mine_globe_01 (5)", new Vector2(52.09f, 12.04f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_02", "mine_globe_01 (2)", new Vector2(122.34f, 18.94f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_02", "mine_globe_01", new Vector2(135.54f, 9.15f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_02", "mine_globe_01 (1)", new Vector2(142.67f, 8.97f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_02", "mine_globe_01 (4)", new Vector2(141.72f, 25.95f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_02", "mine_globe_01 (3)", new Vector2(125.9f, 33.04f)).Serialize(),LanternState.DEFAULT},

            //Mines_04
            {new LanternKey("Mines_04", "mine_globe_01", new Vector2(13.11f, 58.09f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_04", "mine_globe_01 (1)", new Vector2(17.17f, 72.03f)).Serialize(),LanternState.DEFAULT},

            //Mines_37
            {new LanternKey("Mines_37", "mine_globe_01 (10)", new Vector2(35.4f, 8.136544f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_37", "mine_globe_01 (9)", new Vector2(39.05523f, 8.136544f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_37", "mine_globe_01", new Vector2(24.47399f, 42.01061f)).Serialize(),LanternState.DEFAULT},

            //Mines_20
            {new LanternKey("Mines_20", "mine_globe_01", new Vector2(34.73f, 68.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_20", "mine_globe_01 (1)", new Vector2(20.41f, 67.12f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_20", "mine_globe_01 (2)", new Vector2(8.11f, 67.12f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_20", "mine_globe_01 (3)", new Vector2(27.79f, 80.08f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_20", "mine_globe_01 (4)", new Vector2(23.82f, 80.08f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_20", "mine_globe_01 (6)", new Vector2(21.33f, 156.75f)).Serialize(),LanternState.DEFAULT},

            //Mines_11
            {new LanternKey("Mines_11", "mine_globe_01 (3)", new Vector2(12.22f, 62.17f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (2)", new Vector2(14.98f, 44.13f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (7)", new Vector2(10.61f, 37.99f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (6)", new Vector2(16.6f, 33.24f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (8)", new Vector2(8.48f, 29.25f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (5)", new Vector2(17.38f, 28.37f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (9)", new Vector2(11.37f, 17.47f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01", new Vector2(29.74f, 8.38f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_11", "mine_globe_01 (1)", new Vector2(22.08f, 8.34f)).Serialize(),LanternState.DEFAULT},

            //Mines_32
            {new LanternKey("Mines_32", "mine_globe_01", new Vector2(55.2f, 8.98f)).Serialize(),LanternState.DEFAULT},

            //Mines_31
            {new LanternKey("Mines_31", "mine_globe_01 (2)", new Vector2(225.34f, 33.24f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_31", "mine_globe_01 (1)", new Vector2(217.75f, 33.29f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Mines_31", "mine_globe_01", new Vector2(209.4656f, 32.69827f)).Serialize(),LanternState.DEFAULT},

            #endregion

            #region Anchient Basin

            //Abyss_22
            {new LanternKey("Abyss_22", "Stag_Pole_Tall_Break", new Vector2(33.09f, 8.79f)).Serialize(),LanternState.DEFAULT},

            //Tram
            {new LanternKey("Room_Tram", "tram_lamp_single (2)", new Vector2(22.624f, 15.55893f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram", "tram_lamp_single (1)", new Vector2(18.901f, 15.55893f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram", "tram_lamp_single", new Vector2(15.598f, 15.55893f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram", "tram_lamp_single (3)", new Vector2(25.99f, 15.55893f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Room_Tram", "tram_lamp_single (4)", new Vector2(29.5065f, 15.55893f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region The Abyss

            // 0

            #endregion

            #region Deepnest

            // Deepnest_37
            {new LanternKey("Deepnest_37", "d_break_0048_deep_lamp1", new Vector2(69.16f, 6.76f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_37", "d_break_0048_deep_lamp1 (1)", new Vector2(43.13f, 6.79f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_37", "d_break_0048_deep_lamp1 (2)", new Vector2(12.11f, 6.62f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_44
            {new LanternKey("Deepnest_44", "d_break_0046_deep_lamp3", new Vector2(24.75f, 55.28f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_17
            {new LanternKey("Deepnest_17", "d_break_0046_deep_lamp3 (3)", new Vector2(13.34487f, 9.914454f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_17", "d_break_0047_deep_lamp2", new Vector2(1.91f, 21.59f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_17", "d_break_0046_deep_lamp3", new Vector2(5.288195f, 37.701f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_17", "d_break_0046_deep_lamp3 (2)", new Vector2(26.08f, 59.19f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_17", "d_break_0046_deep_lamp3 (1)", new Vector2(5.73f, 59.07f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_16
            {new LanternKey("Deepnest_16", "d_break_0047_deep_lamp2", new Vector2(4.21f, 12.98f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_16", "d_break_0046_deep_lamp3", new Vector2(55.40868f, 46.02955f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_16", "d_break_0046_deep_lamp3 (1)", new Vector2(62.47f, 46.02955f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_16", "d_break_0046_deep_lamp3 (2)", new Vector2(80.53f, 17.93f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_01b
            {new LanternKey("Deepnest_01b", "d_break_0046_deep_lamp3 (5)", new Vector2(35.11f, 9.66f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_01b", "d_break_0046_deep_lamp3 (4)", new Vector2(19.57f, 10.04633f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_01b", "d_break_0044_deep_lamp5 (1)", new Vector2(8.994297f, 8.338173f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_01b", "d_break_0046_deep_lamp3 (6)", new Vector2(42.88f, 7.23f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_01b", "d_break_0048_deep_lamp1 (1)", new Vector2(12.03f, 46.28f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_01b", "d_break_0046_deep_lamp3 (3)", new Vector2(13.48f, 62.38f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_01b", "d_break_0047_deep_lamp2 (2)", new Vector2(3.07f, 69.39f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_02
            {new LanternKey("Deepnest_02", "d_break_0047_deep_lamp2", new Vector2(26.96f, 29.55f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_02", "d_break_0047_deep_lamp2 (1)", new Vector2(2.68f, 57.98f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_02", "d_break_0046_deep_lamp3", new Vector2(23.10012f, 73.22f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_02", "d_break_0046_deep_lamp3 (1)", new Vector2(9.77f, 73.27f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_36
            {new LanternKey("Deepnest_36", "d_break_0047_deep_lamp2", new Vector2(31.61f, 13.34f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_14
            {new LanternKey("Deepnest_14", "d_break_0046_deep_lamp3 (1)", new Vector2(71f, 14.63f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_14", "d_break_0044_deep_lamp5", new Vector2(38.98f, 8.9f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_14", "d_break_0046_deep_lamp3", new Vector2(58.99f, 23.83f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_14", "d_break_0048_deep_lamp1", new Vector2(32.85f, 27.77f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_03
            {new LanternKey("Deepnest_03", "d_break_0046_deep_lamp3", new Vector2(36.28f, 17.94f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_03", "d_break_0047_deep_lamp2 (1)", new Vector2(46.03f, 34.95f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_03", "d_break_0046_deep_lamp3 (1)", new Vector2(29.6f, 36.67f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_03", "d_break_0044_deep_lamp5 (1)", new Vector2(55.19f, 54.65f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_03", "d_break_0046_deep_lamp3 (2)", new Vector2(15.25f, 54.49f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_03", "d_break_0047_deep_lamp2", new Vector2(7.35f, 63.29f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_33
            {new LanternKey("Deepnest_33", "d_break_0047_deep_lamp2", new Vector2(81.84f, 15.89f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_33", "d_break_0048_deep_lamp1", new Vector2(65.56551f, 24.97464f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_33", "d_break_0048_deep_lamp1 (1)", new Vector2(69.63f, 32.47f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_33", "d_break_0046_deep_lamp3", new Vector2(26.96683f, 41.16278f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_45_v02
            {new LanternKey("Deepnest_45_v02", "spider_lamp_01 (4)", new Vector2(30.72f, 19.91f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_45_v02", "spider_lamp_01 (3)", new Vector2(42.83f, 19.91f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_45_v02", "spider_lamp_02", new Vector2(86.13508f, 13.87699f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_45_v02", "spider_lamp_01", new Vector2(116.9759f, 19.73584f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_45_v02", "spider_lamp_02 (1)", new Vector2(119.13f, 13.65f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_45_v02", "spider_lamp_01 (1)", new Vector2(125.27f, 35.6f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_45_v02", "spider_lamp_02 (3)", new Vector2(35.47f, 46.63f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_10
            {new LanternKey("Deepnest_10", "Stag_Pole_Break", new Vector2(67.71f, 139.6098f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_Spider_Town
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_01 (5)", new Vector2(33.87f, 87.53f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02", new Vector2(9.82f, 85.14f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (1)", new Vector2(16.06f, 99.09f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (2)", new Vector2(9.12f, 111.02f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (18)", new Vector2(56.62f, 111.19f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (17)", new Vector2(72.13f, 111.19f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (3)", new Vector2(6.24f, 119.3f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_01 (1)", new Vector2(7.38f, 137.74f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (4)", new Vector2(16.07f, 135f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (9)", new Vector2(44.81f, 133.1f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (11)", new Vector2(65.23f, 133f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_01 (4)", new Vector2(85.23f, 136.75f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (13)", new Vector2(96.88f, 119.25f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (14)", new Vector2(111.84f, 103.94f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (15)", new Vector2(95.377f, 103.94f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (6)", new Vector2(34.33f, 151.97f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (5)", new Vector2(22.1f, 151.97f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_01 (2)", new Vector2(15.68f, 155.68f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_01", new Vector2(50.82f, 102.84f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (10)", new Vector2(55.63f, 133.1f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Deepnest_Spider_Town", "spider_lamp_02 (16)", new Vector2(78.25f, 82.16f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_09
            {new LanternKey("Deepnest_09", "Stag_Pole_Tall_Break (2)", new Vector2(32.239f, 8.31f)).Serialize(), LanternState.DEFAULT},


            #endregion

            #region Dirtmouth

            // Room_Town_Stag_Station
            {new LanternKey("Room_Town_Stag_Station", "Stag_Pole_Tall_Break (2)", new Vector2(56.15667f, 8.35f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region Fog Canyon

            // Fungus3_44
            {new LanternKey("Fungus3_44", "fung_lamp2", new Vector2(44.44f, 18.68955f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_44", "fung_lamp3", new Vector2(56.36f, 18.88f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_02
            {new LanternKey("Fungus3_02", "Stag_Pole_Break", new Vector2(21.62f, 4.73f)).Serialize(), LanternState.DEFAULT},

            //Fungus3_47
             {new LanternKey("Fungus3_47", "Jelly_lamp", new Vector2(38.11583f, 7.281714f)).Serialize(), LanternState.DEFAULT},
             {new LanternKey("Fungus3_47", "Jelly_lamp (1)", new Vector2(48.88f, 7.464476f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_Archive_02
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp (6)", new Vector2(63.06f, 184.06f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp (5)", new Vector2(13.62f, 144.07f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp (4)", new Vector2(49.4f, 144.07f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp (3)", new Vector2(56.72f, 144.07f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp (1)", new Vector2(23.41f, 106.1528f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp", new Vector2(28.90582f, 106.1528f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_archive_02", "Jelly_lamp (2)", new Vector2(75.7f, 106.1528f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region Howling Cliffs

            // 0

            #endregion

            #region Godhome

            // 0

            #endregion

            #region Kingdom's Edge

            // Abyss_03_c
            {new LanternKey("Abyss_03_c", "Stag_Pole_Tall_Break (2)", new Vector2(62.232f, 12.5425f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region Queen's Gardens

            // Fungus3_34
            {new LanternKey("Fungus3_34", "fung_lamp3 (2)", new Vector2(118.8f, 9.99f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_34", "fung_lamp3", new Vector2(91.61f, 7.93f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_34", "fung_lamp2", new Vector2(72.79f, 7.6f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_34", "fung_lamp2 (1)", new Vector2(42.95f, 7.71f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_34", "fung_lamp3 (4)", new Vector2(21.08f, 12.34f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_04
            {new LanternKey("Fungus3_04", "fung_lamp2 (4)", new Vector2(33.97f, 58.61f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_04", "fung_lamp2 (2)", new Vector2(13.62f, 68.57f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_04", "fung_lamp2 (3)", new Vector2(27.26f, 72.5f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_04", "fung_lamp2", new Vector2(30.25f, 23.76f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_04", "fung_lamp3 (1)", new Vector2(31.28f, 7.918348f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_04", "fung_lamp3", new Vector2(6.19f, 7.918348f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_05
            {new LanternKey("Fungus3_05", "fung_lamp2", new Vector2(54.84f, 41.53f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_11
            {new LanternKey("Fungus3_11", "fung_lamp2 (2)", new Vector2(15.7f, 56.61f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_11", "fung_lamp2 (1)", new Vector2(22.37f, 36.58f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_11", "fung_lamp2", new Vector2(10.09251f, 11.55f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_11", "fung_lamp3", new Vector2(38.09f, 38.99521f)).Serialize(), LanternState.DEFAULT},

            // Deepnest_43
            {new LanternKey("Deepnest_43", "fung_lamp3", new Vector2(16.72762f, 116.9327f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_10
            {new LanternKey("Fungus3_10", "fung_lamp2 (4)", new Vector2(95.48f, 13.57f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_13
            {new LanternKey("Fungus3_13", "Stag_Pole_Break", new Vector2(24.77f, 20.66739f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_13", "fung_lamp2", new Vector2(22.14f, 46.57f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_40
            {new LanternKey("Fungus3_40", "Stag_Pole_Tall_Break (2)", new Vector2(155.99f, 15.33f)).Serialize(), LanternState.DEFAULT},

            // Fungus3_22
            {new LanternKey("Fungus3_22", "fung_lamp2", new Vector2(13.33f, 27.13f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_22", "fung_lamp3", new Vector2(19.55884f, 39.92697f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Fungus3_22", "fung_lamp2 (1)", new Vector2(11.33f, 67.55f)).Serialize(), LanternState.DEFAULT},

            // Fungus1_23
            {new LanternKey("Fungus1_23", "fung_lamp2", new Vector2(134.6f, 9.59f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region Resting Grounds

            // RestingGrounds_06
            {new LanternKey("RestingGrounds_06", "Stag_Pole_Tall_Break (2)", new Vector2(103.76f, 9.29007f)).Serialize(), LanternState.DEFAULT},

            //Ruins2_10
            {new LanternKey("Ruins2_10", "Stag_Pole_Tall_Break (2)", new Vector2(25.09f, 162.28f)).Serialize(), LanternState.DEFAULT},

            // Room_mansion
            {new LanternKey("Room_Mansion", "ruind_dressing_light_03", new Vector2(20.21f, 15.94f)).Serialize(), LanternState.DEFAULT},

            // RestingGrounds_02
            {new LanternKey("RestingGrounds_02", "Stag_Pole_Break", new Vector2(21.52058f, 9.633305f)).Serialize(), LanternState.DEFAULT},

            // RestingGrounds_05
            {new LanternKey("RestingGrounds_05", "Stag_Pole_Break", new Vector2(35.09097f, 55.64841f)).Serialize(), LanternState.DEFAULT},

            // RestingGrounds_09
            {new LanternKey("RestingGrounds_09", "Stag_Pole_Tall_Break (2)", new Vector2(32.2386f, 8.360001f)).Serialize(), LanternState.DEFAULT},

            // Crossroads_46b
            {new LanternKey("Crossroads_46b", "Stag_Pole_Tall_Break (2)", new Vector2(47.26208f, 13.05107f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region Royal Waterways

            // Waterways_04
            {new LanternKey("Waterways_04", "waterways_lamp (7)", new Vector2(144.12f, 38.96f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp (1)", new Vector2(130.92f, 25.43f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp (2)", new Vector2(123.97f, 25.43f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp (6)", new Vector2(39.48f, 12.57f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp (5)", new Vector2(26.87f, 12.57f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp", new Vector2(7.3f, 13.2f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp (4)", new Vector2(33.28f, 36.52f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_04", "waterways_lamp (3)", new Vector2(45.17f, 36.52f)).Serialize(), LanternState.DEFAULT},

            // Waterways_09
            {new LanternKey("Waterways_09", "waterways_lamp (2)", new Vector2(33.64f, 24.57665f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_09", "waterways_lamp", new Vector2(23.79968f, 24.57665f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_09", "waterways_lamp (1)", new Vector2(14.74f, 24.57665f)).Serialize(), LanternState.DEFAULT},

            // Waterways_02
            {new LanternKey("Waterways_02", "waterways_lamp", new Vector2(13.69529f, 25.6722f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_02", "waterways_lamp (1)", new Vector2(29.41f, 26.28f)).Serialize(), LanternState.DEFAULT},

            // Waterways_06
            {new LanternKey("Waterways_06", "waterways_lamp (2)", new Vector2(86.29f, 47.78f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_06", "waterways_lamp", new Vector2(49.00217f, 20.09124f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_06", "waterways_lamp (1)", new Vector2(55.54f, 20.09124f)).Serialize(), LanternState.DEFAULT},

            // Waterways_14
            {new LanternKey("Waterways_14", "waterways_lamp (2)", new Vector2(14.59f, 20.49f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_14", "waterways_lamp (1)", new Vector2(33.59f, 24.45f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Waterways_14", "waterways_lamp", new Vector2(44.15f, 24.45f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region The Hive

            // Hive_01
            {new LanternKey("Hive_01", "Hive_Break_lamp_hang", new Vector2(82.46f, 17.82f)).Serialize(), LanternState.DEFAULT},

            // Hive_02
            {new LanternKey("Hive_02", "Hive_Break_lamp_hang", new Vector2(128.98f, 79.81f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_02", "Hive_Break_lamp_hang (1)", new Vector2(142.96f, 78.428f)).Serialize(), LanternState.DEFAULT},

            // Hive_03_c
            {new LanternKey("Hive_03_c", "Hive_Break_lamp_hang (1)", new Vector2(47.165f, 83.72f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_03_c", "Hive_Break_lamp_hang", new Vector2(35.85f, 84.83f)).Serialize(), LanternState.DEFAULT},

            // Hive_05
            {new LanternKey("Hive_05", "Hive_Break_lamp_hang (3)", new Vector2(18f, 33.18f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey ("Hive_05", "Hive_Break_lamp_hang (2)", new Vector2(25.21f, 32.51f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_05", "Hive_Break_lamp_hang", new Vector2(29.63f, 33.31f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_05", "Hive_Break_Pillar (7)", new Vector2(27.25f, 27.47f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_05", "Hive_Break_lamp_hang (1)", new Vector2(37.56f, 33.69f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_05", "Hive_Break_lamp_hang (5)", new Vector2(60.31f, 40.51f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("Hive_05", "Hive_Break_lamp_hang (4)", new Vector2(96.73f, 30f)).Serialize(), LanternState.DEFAULT},

            #endregion

            #region White Palace

            // White_Palace_03_Hub
            {new LanternKey("White_Palace_03_hub", "wp_globe_upright0000 (7)", new Vector2(10.58f, 35.48f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_03_hub", "wp_globe_upright0000 (6)", new Vector2(3.98f, 35.48f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_03_hub", "wp_globe_upright0000 (2)", new Vector2(89.18f, 64.5f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_03_hub", "wp_globe_upright0000 (3)", new Vector2(96.02f, 64.5f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_03_hub", "wp_globe_upright0000 (5)", new Vector2(13.92f, 24.4f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_03_hub", "wp_globe_upright0000 (4)", new Vector2(27.97f, 24.4f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_01
            {new LanternKey("White_Palace_01", "wp_globe_upright0000 (6)", new Vector2(99.01f, 130.65f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_01", "wp_globe_upright0000 (5)", new Vector2(110.82f, 130.65f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_01", "wp_globe_upright0000 (7)", new Vector2(137.8f, 130.65f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_01", "wp_globe_upright0000 (2)", new Vector2(64.24f, 34.69f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_01", "wp_globe_upright0000", new Vector2(80.51f, 34.69f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_01", "wp_globe_upright0000 (4)", new Vector2(92.93f, 28.58f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_14
            {new LanternKey("White_Palace_14", "wp_globe_upright0000", new Vector2(26.02002f, 72.44754f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_14", "wp_globe_upright0000", new Vector2(97.01642f, 130.4f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_17
            {new LanternKey("White_Palace_17", "wp_globe_upright0000 (1)", new Vector2(104.26f, 34.66f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_07
            {new LanternKey("White_Palace_07", "wp_globe_upright0000 (8)", new Vector2(28.93f, 69.54f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_07", "wp_globe_upright0000 (9)", new Vector2(36.44f, 69.54f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_12
            {new LanternKey("White_Palace_12", "wp_globe_upright0000 (6)", new Vector2(40.53f, 136.55f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_12", "wp_globe_upright0000 (7)", new Vector2(19.17f, 136.55f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_12", "wp_globe_upright0000 (1)", new Vector2(64.08f, 198.59f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_13
            {new LanternKey("White_Palace_13", "wp_globe_upright0000 (6)", new Vector2(5.87f, 136.3952f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_13", "wp_globe_upright0000", new Vector2(24.57f, 136.3952f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_13", "wp_globe_upright0000 (1)", new Vector2(43.1f, 136.3952f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_13", "wp_globe_upright0000 (5)", new Vector2(102.95f, 203.46f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_13", "wp_globe_upright0000 (4)", new Vector2(107.7f, 203.46f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_13", "wp_globe_upright0000 (2)", new Vector2(112.39f, 203.43f)).Serialize(), LanternState.DEFAULT},

            // White_Palace_09
            {new LanternKey("White_Palace_09", "wp_globe_upright0000", new Vector2(30.52816f, 10.44391f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_09", "wp_globe_upright0000 (1)", new Vector2(24.89f, 10.44391f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_09", "wp_globe_upright0000 (2)", new Vector2(36.16f, 40.39f)).Serialize(), LanternState.DEFAULT},
            {new LanternKey("White_Palace_09", "wp_globe_upright0000 (3)", new Vector2(18.41f, 95.42f)).Serialize(), LanternState.DEFAULT},

            #endregion
        };
    }
}
