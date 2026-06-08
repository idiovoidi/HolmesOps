using System.IO;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    // Score to save
    public int playerScore = 0;
    public string playerName = "Player";

    // Path to the save file
    private string filePath;

    void Start()
    {
        // Set the file path to the persistent data folder
        filePath = Application.persistentDataPath + "/highscore.txt";
    }

    // Save current score to .txt file
    public void SaveHighScore()
    {
        string scoreText = playerName + " - " + playerScore;
        File.WriteAllText(filePath, scoreText);
        Debug.Log("Highscore saved: " + scoreText);
    }
}
