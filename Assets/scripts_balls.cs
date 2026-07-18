using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
public enum Ballcolor
{
    White,
    red,
    yellow,
    green,
    brown,
    blue,
    pink,
    black,

}
public class scripts_balls : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private int point;

    [SerializeField]
    private Ballcolor color;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(point);
        Gamemanager.instance.PlayerScore += point;
        Destroy(gameObject);
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
