using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Shark")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
