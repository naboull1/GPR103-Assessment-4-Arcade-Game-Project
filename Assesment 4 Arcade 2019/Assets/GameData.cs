using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    public int lives;
    public int score;

    public void SaveData(GameData mGameData)
    {
        SaveLoadFiles.SaveData(mGameData);
    }

    public void LoadData()
    {
        GameData mGData = SaveLoadFiles.LoadData();
        lives = mGData.lives;
        score = mGData.score;
    }
    public GameData()
    {
        lives = 3;
        score = 0;
        
    }
    public GameData(GameData pGdata)
    {
        lives = pGdata.lives;
        score = pGdata.score;
    }
}
