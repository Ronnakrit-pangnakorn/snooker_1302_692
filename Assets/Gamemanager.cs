using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField]
    private GameObject[] ballposition;
    
    [SerializeField]
    private GameObject ballPrefads;

    public static Gamemanager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetBall(Ballcolor.Red, 1);
        SetBall(Ballcolor.Yellow, 2);
        SetBall(Ballcolor.Green, 3);
        SetBall(Ballcolor.Brown, 4);
        SetBall(Ballcolor.Blue, 5);
        SetBall(Ballcolor.Pink, 6);
        SetBall(Ballcolor.Black, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetBall(Ballcolor col, int i)
    {
        GameObject obj = Instantiate(ballPrefads,
                    ballposition[i].transform.position,
                    Quaternion.identity);
        scripts_balls b = obj.GetComponent<scripts_balls>();
        b.SetcolorAndPoint(col);
    }
}
