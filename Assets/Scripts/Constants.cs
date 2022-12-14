using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants {
    public const int PLAYER_MAX_LIVES = 3;
    public const int MAX_PLAYER_COUNT = 6;

    public const string PLAYER_LIVES = "PlayerLives";
    public const string PLAYER_READY = "IsPlayerReady";
    public const string PLAYER_LOADED_LEVEL = "PlayerLoadedLevel";

    public const float MAX_SOULS = 100f;

    public static Color GetColor(int colorChoice) {
        switch (colorChoice) {
            case 0: return Color.red;
            case 1: return Color.green;
            case 2: return Color.blue;
            case 3: return Color.yellow;
            case 4: return Color.cyan;
            case 5: return Color.grey;
            case 6: return Color.magenta;
            case 7: return Color.white;
        }

        return Color.black;
    }
}
