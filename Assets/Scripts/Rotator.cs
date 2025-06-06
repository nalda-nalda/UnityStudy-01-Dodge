using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
