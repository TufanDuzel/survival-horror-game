using UnityEngine;

public class UIController : MonoBehaviour
{
    public static string actionText;
    public static string commandText;
    public static bool uiActive;

    [SerializeField] GameObject actionBox;
    [SerializeField] GameObject commandBox;
    [SerializeField] GameObject interactCross;

    void Update()
    {
        if (uiActive == true)
        {
            actionBox.SetActive(true);
            commandBox.SetActive(true);
            interactCross.SetActive(true);

            actionBox.GetComponent<TMPro.TMP_Text>().text = actionText;
            commandBox.GetComponent<TMPro.TMP_Text>().text = "[E] " + commandText;
        }
        else
        {
            actionBox.SetActive(false);
            commandBox.SetActive(false);
            interactCross.SetActive(false);
        }
    }
}
