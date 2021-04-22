using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveLoadFiles 
{
    public static void SaveData(GameData myGameData)
    {
        BinaryFormatter mFormatter = new BinaryFormatter();
        //string path = Application.persistentDataPath + "/GData.game";
        string path = "C:/Users/nabou/Desktop/New folder/mySaveData.game";
        FileStream mStream = new FileStream(path, FileMode.Create);

        GameData mData = new GameData(myGameData);
        mFormatter.Serialize(mStream, mData);

        mStream.Close();

    }

    public static GameData LoadData()
    {
        //string path = Application.persistentDataPath + "/GData.game";
        string path = "d:/work/mySaveData.game";
        if (File.Exists(path))
        {
            BinaryFormatter mFormatter = new BinaryFormatter();
            FileStream mStream = new FileStream(path, FileMode.Open);

            GameData myGameData = mFormatter.Deserialize(mStream) as GameData;

            mStream.Close();

            return myGameData;

        }
        else 
        {
            Debug.LogError("file does not exist");
        }

        return new GameData();
    }
}
