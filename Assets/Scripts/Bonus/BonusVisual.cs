using UnityEngine;
using UnityEngine.UI;

public class BonusVisual : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Bonuses bonuses;

    void Update()
    {
        text.text = $"{bonuses.Value}";
    }
}
