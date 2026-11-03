using Unity.VisualScripting;
using UnityEngine;

public class collisontest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
