using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCameraMovement : MonoBehaviour
{
    [SerializeField] LeanTweenType tweenType;
    Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }    

    // Camera shake
    public IEnumerator CameraShake(float time, float intensity)
    {
        
        float timeToEnd = Time.time + time;
        
        while (timeToEnd > Time.time)
        {
            transform.position = transform.position + new Vector3(Random.Range(-intensity, intensity), Random.Range(-intensity, intensity));
            yield return null;
        }
        
        transform.position = originalPosition;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, originalPosition.y + (Mathf.Sin(Time.time) / 10), transform.position.z);
    }
}
