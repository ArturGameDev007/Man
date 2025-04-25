using UnityEngine;

public class PlayerAnimator :MonoBehaviour
{
    private readonly int Run = Animator.StringToHash(nameof(Run));
    private readonly int Finish = Animator.StringToHash(nameof(Finish));
    private readonly int Die = Animator.StringToHash(nameof(Die));

    [Header("Animator")]
    [SerializeField] private Animator _animator;

    public void SetIdle()
    {
        _animator.SetBool(Run, false);
    }

    public void SetRun()
    {
        _animator.SetBool(Run, true);
    }

    public void SetFinish()
    {
        _animator.SetTrigger(Finish);
    }

    public void SetDie()
    {
        _animator.SetTrigger(Die);
    }
}
