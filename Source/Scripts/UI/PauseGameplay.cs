﻿using UnityEngine;

public class PauseGameplay :MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private PausePanel _menu;

    private bool _isPaused = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            OnPauseButtonClick();
    }

    private void Start()
    {
        _panel?.SetActive(false);
    }

    public void OnPauseButtonClick()
    {
        if (_isPaused)
        {
            ResumeGame();
            _menu.Play();
        }
        else
        {
            PauseGame();
            _menu.Pause();
        }
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
