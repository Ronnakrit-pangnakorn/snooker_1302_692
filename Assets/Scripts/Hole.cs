using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        scripts_balls b = other.GetComponent<scripts_balls>();
        
        if (b != null)
        {
            if (b.Point == 0)

            {
                Gamemanager.instance.Showstring($"White ball Drop!\nYou Lose");
                Time.timeScale = 0f;
            }
            else
            {
                Gamemanager.instance.ShowScoreText(b.Point);
                Destroy(b.gameObject);
            }
        }

    }

}
