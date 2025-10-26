using UnityEngine;

public class MoveRight : MonoBehaviour
{

    float steps = .1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 POs = transform.position;
        if (POs.x <= 1)
        {
            POs.x += steps*Time.deltaTime;
            transform.position = POs;
        }
    }
}
