using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public float speedX = 360, speedY = 240;
    public float LimY = 40f;
    public float minDistance = 1.5f;
    public float hideDist = 2f;
    public LayerMask noPlayer;
    public LayerMask obstacles;
    private float _maxDistance;
    private Vector3 _localPosition;
    private float _currentYRotation;
    public PlayerMove PlayMove;
    private LayerMask _camOrigin;

    private Vector3 _position
    {
        get { return transform.position; }
        set { transform.position = value; }
    }

    private void Start()
    {
        _localPosition = target.InverseTransformPoint(_position);
        _maxDistance = Vector3.Distance(_position, target.position);
        _camOrigin = cam.cullingMask;
    }
    private void LateUpdate()
    {     
         _position = target.TransformPoint(_localPosition);
         ObstaclesReact();
         PlayerReact();
         _localPosition = target.InverseTransformPoint(_position);
    }
    void ObstaclesReact()
    {
        var distance = Vector3.Distance(_position, target.position);
        RaycastHit hit;
        if (Physics.Raycast(target.position, transform.position - target.position, out hit, _maxDistance, obstacles))
        {
            _position = hit.point;
        }
        else if (distance < _maxDistance && !Physics.Raycast(_position, -transform.forward, .1f, obstacles))
        {
            _position -= transform.forward * .05f;
        }
    }
    void PlayerReact()
    {
        var distance = Vector3.Distance(_position, target.position);
        if(distance < hideDist)
        {
            cam.cullingMask = noPlayer;
        }
        else
        {
            cam.cullingMask = _camOrigin;
        }
    }
}
