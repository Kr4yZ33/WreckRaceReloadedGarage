using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpointLight;
    public Player player;
    Renderer r;

    void Awake()
    {
        r = checkpointLight.GetComponent<Renderer>();
        
    }


    void FixedUpdate()
    {
        if (player == null)
        {
            Debug.Log("Player Null");
            return;
        }

        if(gameObject.name == "1")
        {
            if(player.checkpointOne)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "2")
        {
            if (player.checkpointTwo)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "3")
        {
            if (player.checkpointThree)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "4")
        {
            if (player.checkpointFour)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "5")
        {
            if (player.checkpointFive)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "6")
        {
            if (player.checkpointSix)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "7")
        {
            if (player.checkpointSeven)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "8")
        {
            if (player.checkpointEight)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "9")
        {
            if (player.checkpointNine)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }

        if (gameObject.name == "10")
        {
            if (player.checkpointTen)
            {
                r.material.color = Color.green;
            }
            else
            {
                r.material.color = Color.red;
            }
        }
    }
}
