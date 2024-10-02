using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    #region Variables

    private Vector3 _offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    [SerializeField] private float rotationSpeed;
    private Vector3 _currentVelocity = Vector3.zero;

    #endregion

    #region Unity callbacks


    private void Awake() => _offset = transform.position - target.position;

    private void Update()
    {
        
    }
    private void LateUpdate()
    {
        if (target.GetComponent<Rigidbody>().velocity.magnitude == 0)
        {
            transform.RotateAround(target.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
;
        Vector3 targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }

    #endregion
}
