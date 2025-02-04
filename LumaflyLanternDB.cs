using System.Collections.Generic;
using UnityEngine;

namespace LumaflyLanternTracker {
    internal class LumaflyLanternDB {


        //Serialized LanternKey, LanternState
        internal static readonly Dictionary<string[], LanternState> list = new Dictionary<string[], LanternState>(new StringArrayComparer())
        {
            //Check with map
            #region Crossroads
            // Front of stag room
            {new LanternKey("Crossroads_03", "Stag_Pole_Break", new Vector2(7.152f, 9.695121f)).Serialize(),LanternState.DEFAULT},
            // Stag
            {new LanternKey("Crossroads_47", "Stag_Pole_Tall_Break (2)", new Vector2(15.91f, 8.35f)).Serialize(),LanternState.DEFAULT},

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

            #region Fungal

            // Fungus2_03
            {new LanternKey("Fungus2_03", "Stag_Pole_Break", new Vector2(11.39f, 15.66789f)).Serialize(),LanternState.DEFAULT},
            
            // Queens
            {new LanternKey("Fungus2_01", "fung_lamp2 (1)", new Vector2(39.09f, 41.66f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus2_01", "fung_lamp4", new Vector2(22.15341f, 39.96693f)).Serialize(),LanternState.DEFAULT},
            
            
            //{new LanternKey("Fungus2_01", "Stag_Pole_Break", new Vector2(8.612524f, 19.65337f)).Serialize(),LanternState.DEFAULT}, // No Lumaflies
            
            
            {new LanternKey("Fungus2_01", "fung_lamp5", new Vector2(22.73f, 17.04f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Fungus2_01", "Stag_Pole_Break (1)", new Vector2(7.16f, 6.7f)).Serialize(),LanternState.DEFAULT},

            // Stag
            {new LanternKey("Fungus2_02", "Stag_Pole_Tall_Break (2)", new Vector2(15.91f, 8.35f)).Serialize(),LanternState.DEFAULT},

            // Fungus2_10
            {new LanternKey("Fungus2_10", "fung_lamp3", new Vector2(24.19f, 17.05f)).Serialize(),LanternState.DEFAULT},

            // Fungus2_13
            {new LanternKey("Fungus2_13", "Stag_Pole_Tall_Break (2)", new Vector2(17.94415f, 9.5745f)).Serialize(),LanternState.DEFAULT},

            #endregion

            #region City

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
            //{new LanternKey("Ruins2_06", "Stag_Pole_Break", new Vector2(48.90189f, 6.639233f)).Serialize(),LanternState.DEFAULT}, // No Lumaflies
            {new LanternKey("Ruins2_06", "Stag_Pole_Break (1)", new Vector2(39.17262f, 32.64556f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_07", "ruind_dressing_light_03 (1)", new Vector2(15.67f, 10.87f)).Serialize(),LanternState.DEFAULT},
            {new LanternKey("Ruins2_07", "ruind_dressing_light_03 (3)", new Vector2(24.13f, 11f)).Serialize(),LanternState.DEFAULT},
            //{new LanternKey("Ruins2_07", "Stag_Pole_Tall_Break (2)", new Vector2(32.62f, 8.42f)).Serialize(),LanternState.DEFAULT},// No Lumaflies


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
            //{new LanternKey("Ruins_Elevator", "ruind_dressing_light_03 (5)", new Vector2(36.53f, 100.66f)).Serialize(),LanternState.DEFAULT}, //No Lumaflies
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

            #endregion

            #region Abyss

            // 0

            #endregion


            //White Palace/PoP
        };
    }
}
