using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GarageManager : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI playerLevelText;
    public TextMeshProUGUI selectedCarText;

    public Button upgradeEngineButton;
    public Button upgradeTiresButton;
    public Button upgradeNitroButton;

    private PlayerProgress currentProgress;

    private void Start()
    {
        LoadProgress();
        RefreshUI();
    }

    public void LoadProgress()
    {
        currentProgress = SaveSystem.Load();
    }

    public void RefreshUI()
    {
        if (currentProgress == null)
            currentProgress = SaveSystem.Load();

        if (coinsText != null)
            coinsText.text = "Coins: " + currentProgress.coins;

        if (playerLevelText != null)
            playerLevelText.text = "Level: " + currentProgress.level;

        if (selectedCarText != null)
            selectedCarText.text = "Selected Car: " + currentProgress.selectedCarId;
    }

    public void UpgradeEngine()
    {
        if (currentProgress == null)
            return;

        if (currentProgress.coins < 200)
        {
            Debug.Log("Not enough coins for engine upgrade.");
            return;
        }

        currentProgress.coins -= 200;
        currentProgress.upgrades.engine += 1;
        SaveSystem.Save(currentProgress);
        RefreshUI();
    }

    public void UpgradeTires()
    {
        if (currentProgress == null)
            return;

        if (currentProgress.coins < 180)
        {
            Debug.Log("Not enough coins for tire upgrade.");
            return;
        }

        currentProgress.coins -= 180;
        currentProgress.upgrades.tires += 1;
        SaveSystem.Save(currentProgress);
        RefreshUI();
    }

    public void UpgradeNitro()
    {
        if (currentProgress == null)
            return;

        if (currentProgress.coins < 220)
        {
            Debug.Log("Not enough coins for nitro upgrade.");
            return;
        }

        currentProgress.coins -= 220;
        currentProgress.upgrades.nitro += 1;
        SaveSystem.Save(currentProgress);
        RefreshUI();
    }

    public void AddCoins(int amount)
    {
        currentProgress.coins += amount;
        SaveSystem.Save(currentProgress);
        RefreshUI();
    }
}
