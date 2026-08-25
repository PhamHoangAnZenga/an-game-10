using UnityEngine;

public class Player : MonoBehaviour
{
    static readonly int ISMOVE = Animator.StringToHash("isMove");
    static readonly int VERTICAL = Animator.StringToHash("vertical");
    static readonly int HORIZONTAL = Animator.StringToHash("horizontal");

    [SerializeField] Joystick _joystick;
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] Animator _animator;

    [SerializeField] float _moveSpeed;
    [SerializeField] float _rotateSpeed;

    bool _isMove = false;

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
        if (direction.magnitude > 0.01f)
        {
            if (!_isMove)
            {
                _isMove = true;
                _animator.SetBool(ISMOVE, true);
            }

            _animator.SetFloat(HORIZONTAL, _joystick.Horizontal);
            _animator.SetFloat(VERTICAL, _joystick.Vertical);

            _rigidbody.MovePosition(_rigidbody.position + transform.forward * _joystick.Vertical * _moveSpeed);

            transform.Rotate(Vector3.up, Mathf.Sign(_joystick.Vertical) * _joystick.Horizontal * _rotateSpeed, Space.Self);
        }
        else
        {
            if (_isMove)
            {
                _isMove = false;
                _animator.SetBool(ISMOVE, false);
            }
        }
    }
}
