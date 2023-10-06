using UnityEngine;

public class FollowRider : MonoBehaviour
{
    public Transform Rider;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Rider.position + offset;
    }
}
