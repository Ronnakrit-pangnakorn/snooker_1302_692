using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        scripts_balls b = other.GetComponent<scripts_balls>();
        
        if (b != null)
        {
            Gamemanager.instance.PlayerScore += b.Point;
            Destroy(b.gameObject);
        }

    }

}
