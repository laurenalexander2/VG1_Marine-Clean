using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButtonTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destination0;
    public GameObject destination1;
    public GameObject destination2;
    public GameObject destination3;
    public GameObject destination4;
    public Button teleportButton;
    private Rigidbody2D rb;
    public GameObject StartScreen;
    public DataManager data;


    void Start()
    {
    rb = GetComponent<Rigidbody2D>();

    teleportButton.onClick.AddListener(TeleportPlayer);

    }
    void TeleportPlayer()
    {
        //player's current position
        Vector3 playerPosition = transform.position;

        // Determine which teleport destination to use based on the player's position
        GameObject chosenTeleportDestination = DetermineTeleportDestination(playerPosition);

        if (chosenTeleportDestination != null)
        {
            // teleport
            StartScreen.SetActive(false);
            transform.position = chosenTeleportDestination.transform.position;
            rb.velocity = Vector2.zero;
         }else
         {
            Debug.LogError("Teleport destination not determined!");
         }
    }

    GameObject DetermineTeleportDestination(Vector3 playerPosition)
    {
        if (data.highscore1 > 0)
        {
            return destination1;
        }
        else if (data.highscore2 > 0)
        {
            return destination2;
        }
        else if (data.highscore3 > 0)
        {
            return destination3;
        }
        else if(data.highscore4 > 0)
        {
            return destination4;
        }
        else {
            StartScreen.SetActive(false);
            return destination0;
        }
    }


}

