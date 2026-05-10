using UnityEngine;

public class Colliders : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) //Callback function//
    {
        print("collisioned against" + collision.gameObject.name);
    } 
    void OnCollisionExit(Collision collision)
    {
        print("collision ended with"+collision.gameObject.name);
        if(collision.gameObject.name =="Floor")
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionStay(Collision collision)
    {
        print("colliding with" + collision.gameObject.name);
    }
    void Start ()
    {
        
    }
    void Update()
    {
        
    }
}
