using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barbMove : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    [SerializeField] private GameObject _camera;

    [SerializeField] private float _senssensitivity = 20f;


    Quaternion StartingRotation;

    private float RotHor, RotVer;

    private Vector3 _direction;


    private void Awake()
    {
        _direction = Vector3.zero;
    }

    void Start()
    {
        StartingRotation = transform.rotation;

    }

    void Update()
    {


        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RotHor += Input.GetAxis("Mouse X") * _senssensitivity;
            RotVer += Input.GetAxis("Mouse Y") * _senssensitivity;

            RotVer = Mathf.Clamp(RotVer, -60, 60);

            Quaternion RotY = Quaternion.AngleAxis(RotHor, Vector3.up);
            Quaternion RotX = Quaternion.AngleAxis(-RotVer, Vector3.right);

            _camera.transform.rotation = StartingRotation * transform.rotation * RotX;
            transform.rotation = StartingRotation * RotY;
        }


        var speed = _direction.normalized * _speed * Time.fixedDeltaTime;
        transform.Translate(speed);

    }
}
