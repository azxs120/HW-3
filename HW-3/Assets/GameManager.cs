using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    bool gameHasEnded = false;
    CoinPicker coinPicker;

    public float restarDelay = 1f;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");

            gameOverScreen.Setup();
        }
    }

    public void setGameHasEnded()
    {
        gameHasEnded = true;
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Won!");
    }

    void Restart()
    {
        // SceneManager
    }

}
