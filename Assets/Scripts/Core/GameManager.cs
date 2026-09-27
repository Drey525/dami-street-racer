using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerProgress currentProgress;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        LoadProgress();
    }

    public void LoadProgress()
    {
        currentProgress = SaveSystem.Load();
    }

    public void SaveProgress()
    {
        SaveSystem.Save(currentProgress);
    }

    public void AddCoins(int amount)
    {
        currentProgress.coins += amount;
        SaveProgress();
    }

    public void SetSelectedCar(string carId)
    {
        currentProgress.selectedCarId = carId;
        SaveProgress();
    }
}
