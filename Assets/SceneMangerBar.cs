using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerBar : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // يعيد تحميل المشهد من البداية
    }
}
