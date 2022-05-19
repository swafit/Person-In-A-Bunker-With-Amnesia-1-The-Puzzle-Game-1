using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class saveScript : MonoBehaviour
{
    public string saveFile;


    // Start is called before the first frame update
    void Start()
    {
        saveFile = Application.persistentDataPath + "/save.json";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toSave()
    {

        saveInfo sv = new saveInfo();
        sv.inv = playerInfo.Inventory;
        sv.lev = playerInfo.LevelNum;
        sv.heal = playerInfo.Health;
        sv.full = optionInfo.fullscreenVal;
        sv.mute = optionInfo.muteVal;
        sv.vol = optionInfo.volumeVal;

        string json = JsonUtility.ToJson(sv);
        if (File.Exists(saveFile))
        {
            File.Delete(saveFile);
        }
        File.WriteAllText(saveFile, json);
    }
    public void toLoad()
    {
        playerInfo pi = new playerInfo();

        if (File.Exists(saveFile))
        {
            string loadInfo = File.ReadAllText(saveFile);
            saveInfo data = JsonUtility.FromJson<saveInfo>(loadInfo);
            playerInfo.Health = data.heal;
            playerInfo.Inventory = data.inv;
            playerInfo.LevelNum = data.lev;
            optionInfo.muteVal = data.mute;
            optionInfo.volumeVal = data.vol;
            optionInfo.fullscreenVal = data.full;

            switch (playerInfo.LevelNum)
            {
                case 1: SceneManager.LoadScene("1stLevel");
                        break;
                case 2: SceneManager.LoadScene("2ndLevel");
                        break;
                case 3: SceneManager.LoadScene("FinalLevel");
                    break;
            }
        }

    }
}
