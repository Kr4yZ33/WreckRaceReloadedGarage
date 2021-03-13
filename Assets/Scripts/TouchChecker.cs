using UnityEngine;

public class TouchChecker : MonoBehaviour
{

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log("Horizontal:" + Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            Debug.Log("Vertical:" + Input.GetAxis("Vertical"));
        }
    }
}
