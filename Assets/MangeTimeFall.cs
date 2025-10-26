using UnityEngine;

public class MangeTimeFall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float TimeSteps = 0.01f;
    void Start()
    {
        Time.fixedDeltaTime = TimeSteps;
    }

    // Update is called once per frame
}
