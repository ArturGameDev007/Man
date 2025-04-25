using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager :MonoBehaviour
{
    [SerializeField] private CoinManager _coin;

    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;

        if (next < SceneManager.sceneCountInBuildSettings)
        {
            _coin.SaveToProgress();

            SceneManager.LoadScene(next);
        }
    }
}
