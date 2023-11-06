using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class HoleTeleport : MonoBehaviour
{
    public GameObject hole1;
    public GameObject hole2;
    public GameObject hole3;
    public GameObject hole4;
    public GameObject hole5;
    public GameObject hole6;
    public GameObject hole7;
    public GameObject hole8;
    private Rigidbody2D rb;
    private string hole;
    private static float lastTeleportTime;
    public static float teleportCooldown = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastTeleportTime = -teleportCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(Time.time - lastTeleportTime >= teleportCooldown){
            hole = gameObject.name;

            GameObject chosenTeleportDestination = DetermineTeleportDestination(hole);
                    //hole = collision.GetComponent
            TeleportPlayer(collision.gameObject, chosenTeleportDestination);
            lastTeleportTime = Time.time;
        }

    }

        void TeleportPlayer(GameObject player, GameObject teleportDestination)
    {
        //player's current position
        //Vector3 playerPosition = transform.position;

        // Determine which teleport destination to use based on the player's position


        if (teleportDestination != null) {
            player.transform.position = teleportDestination.transform.position;
            player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
         }else {
            Debug.LogError("Teleport destination not determined!");
         }
    }
    GameObject DetermineTeleportDestination(string hole)
    {
        if (hole == "hole1") {
            return hole2;
        }
        else if (hole == "hole2") {
            return hole1;
        }
        else if (hole == "hole3") {
            return hole4;
        }
        else if (hole == "hole4") {
            return hole3;
        }
        else if (hole == "hole5") {
            return hole6;
        }
        else if (hole == "hole6") {
            return hole5;
        }
        if (hole == "hole7") {
            return hole8;
        }
        else if (hole == "hole8") {
            return hole7;
        }
        return null;
    }

}

