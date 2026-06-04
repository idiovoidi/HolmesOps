using System.IO;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    // The score to save
    public int playerScore = 0;
    public string playerName = "Player";

    // Path to the save file
    private string filePath;

    void Start()
    {
        // Set the file path 
        filePath = Application.persistentDataPath + "/highscore.txt";

        LoadHighScore();
    }

    // Save the current score to a .txt file
    public void SaveHighScore()
    {
        string scoreText = playerName + " - " + playerScore;
        File.WriteAllText(filePath, scoreText);
        Debug.Log("Highscore saved: " + scoreText);
    }
}
