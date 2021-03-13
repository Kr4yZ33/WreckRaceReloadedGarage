using UnityEngine;

public class BoostButton : MonoBehaviour
{
    Renderer r;
    public Material originalMaterial;
    
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    public void MakeButtonGreen()
    {
        r.material.color = Color.green;
    }

    public void MakeButtonYellow()
    {
        r.material.color = Color.yellow;
    }

    public void MakeButtonRed()
    {
        r.material.color = Color.red;
    }

    public void MakeOriginalColour()
    {
        r.material = originalMaterial;
    }
}
