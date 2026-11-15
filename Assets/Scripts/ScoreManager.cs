using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    [SerializeField]
    private int gemsRequired = 3;
    private int score = 0;
    
    private void Awake()
    {
        Instance = this;
    }

    public void AddPoint()
    {
        score++;
        Debug.Log("Score: " + score);
        if (score >= gemsRequired)
        {
            Debug.Log("All gems collected! You win!");
        }
    }

}
