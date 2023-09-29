using UnityEngine;
using UnityEngine.SceneManagement;

public class ka_door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("2kai");
        }
    } 
}

