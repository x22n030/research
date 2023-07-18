using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("201");
        }
    }
}