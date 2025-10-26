using UnityEngine;
using System.Collections;
public class delay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DelayObject());
    }

    IEnumerator DelayObject()
    {
        yield return new WaitForSeconds(2f);  // Wait 2 seconds

        // Do your action here (e.g., enable, move, destroy, etc.)
        Debug.Log("Action after delay");
        gameObject.SetActive(false); // example: disable the object
    }

    // Update is called once per frame

}
