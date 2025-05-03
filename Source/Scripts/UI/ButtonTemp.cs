using UnityEngine;

public class ButtonTemp :MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    private bool _isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            OnPauseButtonClick();
    }

    private void Start()
    {
        _panel?.SetActive(false);
    }

    public void OnPauseButtonClick()
    {
        if (_isPaused)
            ResumeGame();
        else
            PauseGame();
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        _isPaused = true;

        _panel?.SetActive(true);
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        _isPaused = false;

        _panel?.SetActive(false);
    }

}
