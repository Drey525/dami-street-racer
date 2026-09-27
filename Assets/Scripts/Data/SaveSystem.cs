using System.IO;
using UnityEngine;

public static class SaveSystem
{
    public static string SavePath => Path.Combine(Application.persistentDataPath, "player_progress.json");

    public static void Save(PlayerProgress progress)
    {
        string json = JsonUtility.ToJson(progress, true);
        File.WriteAllText(SavePath, json);
        Debug.Log("Progress saved to: " + SavePath);
    }

    public static PlayerProgress Load()
    {
        if (!File.Exists(SavePath))
        {
            PlayerProgress defaultProgress = PlayerProgress.CreateDefault();
            Save(defaultProgress);
            return defaultProgress;
        }

        string json = File.ReadAllText(SavePath);
        PlayerProgress loaded = JsonUtility.FromJson<PlayerProgress>(json);

        if (loaded == null)
        {
            loaded = PlayerProgress.CreateDefault();
            Save(loaded);
        }

        return loaded;
    }
}
