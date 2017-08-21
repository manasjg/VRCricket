using UnityEngine;

public class BatPhysics: MonoBehaviour
{
    [SerializeField]
    private BatBoxFollower BatBoxFollowerPrefab;
    [SerializeField]
    private float sensitivity = 100;

    private void SpawnBatCapsuleFollower()
    {
        var follower = Instantiate(BatBoxFollowerPrefab);
        follower.transform.position = transform.position;
        follower.SetFollowTarget(this,sensitivity);
    }

    private void Start()
    {
        SpawnBatCapsuleFollower();
    }
}
