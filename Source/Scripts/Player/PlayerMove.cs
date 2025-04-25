using UnityEngine;

public class PlayerMove :MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private Player _player;

    [Space(10)]

    [Header("Setting Player")]
    [SerializeField] private float _speed;
    [SerializeField] private float _sentivity;
    [SerializeField] private float _minRotationY;
    [SerializeField] private float _maxRotationY;

    private float _lastMousePosition;
    private float _rotationY;
    private float _boundPositionX = 2.5f;

    private void Start()
    {
        Disable();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Enable();
            _player.StartLevel();
        }

        if (Input.GetMouseButton(0))
        {
            Move();
            _player.Run();
        }

        if (Input.GetMouseButtonUp(0))
        {
            _player.Idle();
        }
    }

    public void Enable()
    {
        _lastMousePosition = Input.mousePosition.x;
        enabled = true;
    }

    public void Disable()
    {
        enabled = false;
    }

    private void Move()
    {
        Vector3 direction = transform.position + transform.forward * _speed * Time.deltaTime;
        direction.x = Mathf.Clamp(direction.x, -_boundPositionX, _boundPositionX);
        transform.position = direction;

        RotateDuringMove();
    }

    private void RotateDuringMove()
    {
        float deltaX = (Input.mousePosition.x - _lastMousePosition) * _sentivity;
        _lastMousePosition = Input.mousePosition.x;

        _rotationY += deltaX;
        _rotationY = Mathf.Clamp(_rotationY, _minRotationY, _maxRotationY);
        transform.eulerAngles = new Vector3(0, _rotationY, 0);
    }
}
