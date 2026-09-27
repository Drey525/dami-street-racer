using System.Collections;
using TMPro;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
    public int totalLaps = 3;
    public float countdownTime = 3f;

    public TextMeshProUGUI lapText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI resultText;
    public CarController playerCar;

    private int currentLap = 1;
    private bool raceStarted = false;
    private float raceTime;
    private bool finished = false;

    private void Start()
    {
        if (playerCar != null)
            playerCar.SetRaceActive(false);

        StartCoroutine(StartRaceCountdown());
    }

    private void Update()
    {
        if (!raceStarted || finished)
            return;

        raceTime += Time.deltaTime;

        if (lapText != null)
            lapText.text = "Lap " + currentLap + "/" + totalLaps;

        if (timerText != null)
            timerText.text = FormatTime(raceTime);
    }

    private IEnumerator StartRaceCountdown()
    {
        float timer = countdownTime;

        while (timer > 0f)
        {
            if (timerText != null)
                timerText.text = Mathf.Ceil(timer).ToString();

            yield return new WaitForSeconds(1f);
            timer--;
        }

        raceStarted = true;

        if (playerCar != null)
            playerCar.SetRaceActive(true);

        if (timerText != null)
            timerText.text = "GO!";

        yield return new WaitForSeconds(0.75f);

        if (timerText != null)
            timerText.text = "";
    }

    public void CompleteLap()
    {
        if (!raceStarted || finished)
            return;

        if (currentLap < totalLaps)
        {
            currentLap++;
            if (lapText != null)
                lapText.text = "Lap " + currentLap + "/" + totalLaps;
        }
        else
        {
            FinishRace();
        }
    }

    private void FinishRace()
    {
        finished = true;
        raceStarted = false;

        if (playerCar != null)
            playerCar.SetRaceActive(false);

        if (resultText != null)
            resultText.text = "Race Finished: " + FormatTime(raceTime);

        Debug.Log("Race finished in: " + FormatTime(raceTime));
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 1000f) % 1000f);

        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}
