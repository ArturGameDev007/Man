using System;
using UnityEngine;

public class Player :MonoBehaviour
{
    [Header("Player Behavior")]
    [SerializeField] private PlayerAnimator _animator;
    [SerializeField] private PlayerMove _move;

    public event Action Finished;
    public event Action Died;

    public void StartLevel()
    {
        _move.Enable();
    }

    public void Idle()
    {
        _animator.SetIdle();
    }

    public void Run()
    {
        _animator.SetRun();
    }

    public void Finish()
    {
        _move.Disable();
        _animator.SetFinish();

        Finished?.Invoke();
    }

    public void Die()
    {
        _move.Disable();
        _animator.SetDie();

        Died?.Invoke();
    }
}
