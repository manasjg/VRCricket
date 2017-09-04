using UnityEngine;

public class BatBoxFollower : MonoBehaviour
{
    private BatPhysics BatFollower;
    private Rigidbody rigidbody;
    private Vector3 velocity;
    

   
    private float sensitivity = 100f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 destination = BatFollower.transform.position;
        rigidbody.transform.rotation = transform.rotation;

        velocity = (destination - rigidbody.transform.position) * sensitivity;

        rigidbody.velocity = velocity;
        transform.rotation = BatFollower.transform.rotation;
    }

    public void SetFollowTarget(BatPhysics batFollower,float sens)
    {
        sensitivity = sens;
        BatFollower = batFollower;
    }
   
}
