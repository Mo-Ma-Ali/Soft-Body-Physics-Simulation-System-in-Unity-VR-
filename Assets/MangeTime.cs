using UnityEngine;

public class MangeTime : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //Application.targetFrameRate = 60;
        Time.fixedDeltaTime = 0.001f;
        Time.timeScale = 1;
        //QualitySettings.vSyncCount = 1;

        DontDestroyOnLoad(gameObject);

    }
}
