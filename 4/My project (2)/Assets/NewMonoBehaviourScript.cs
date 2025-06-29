using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Collider coliderCube1;
    public Collider coliderCube2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.IgnoreCollision(coliderCube1, coliderCube2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
