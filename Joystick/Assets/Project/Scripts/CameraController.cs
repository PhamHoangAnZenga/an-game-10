using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Transform _camera;

    [SerializeField] LayerMask _wallLayer;

    float _cameraMaxDistance;
    Vector3 _originPosition;

    void Awake()
    {
        _cameraMaxDistance = Vector3.Distance(_camera.position, _player.position);
        _originPosition = _camera.localPosition;
    }

    void LateUpdate()
    {
        Vector3 direction = _camera.position - _player.position;
        if (Physics.Raycast(_player.position, direction, out RaycastHit hitInfo, _cameraMaxDistance, _wallLayer))
        {
            _camera.transform.position = _player.position + (hitInfo.point - _player.position);
        }
        else
        {
            _camera.localPosition = _originPosition;
        }
    }
}
