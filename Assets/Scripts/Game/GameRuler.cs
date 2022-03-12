using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Roulette roulette1;
    [SerializeField] private Arrow arrow2;
    [SerializeField] private Roulette roulette2;
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private int userNumber = 0;


    public UnityEvent setUserNumberEvent;
    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;

    public void SetUserNumber(int value)
    {
        setUserNumberEvent?.Invoke();
        userNumber = value;
    }

    private void OnEnable()
    {
        roulette1.endRotateEvent?.AddListener(GetResults1);
        roulette2.endRotateEvent?.AddListener(GetResults2);
    }

    private void OnDisable()
    {
        roulette1.endRotateEvent.RemoveListener(GetResults1);
        roulette2.endRotateEvent.RemoveListener(GetResults2);
    }

    public void GetResults1()
    {
        if(arrow1.collidedObject.ID == userNumber)
            arrowCoincidedEvent?.Invoke();
        else arrowNotCoincidedEvent?.Invoke();
        
    }
    public void GetResults2()
    {

        if(arrow2.collidedObject.ID == userNumber)
            arrowCoincidedEvent?.Invoke();
        else arrowNotCoincidedEvent?.Invoke();
    }
}
