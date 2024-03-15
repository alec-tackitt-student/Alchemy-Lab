using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{

    [SerializeField] private string objectiveText = "objective 1";
    [SerializeField] private string completedText = "completed objective";
    [SerializeField] private Text objectiveDisplay;

    public UnityEvent OnCompleteObjective = new UnityEvent();
    // Start is called before the first frame update

    private void OnEnable() 
    {
        objectiveDisplay.text = objectiveText;
    }
    void Start()
    {
        
    }
    public void CompleteObjective()
    {
        if (gameObject.activeSelf)
        {
            //specific for making a mess
            
            if (gameObject.name == "Objective 2")
            {
                if(ShelfPull.itemsPulled == 15)
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                }
                else
                {
                    return;
                }
            }
            


            objectiveDisplay.text = "";

            OnCompleteObjective.Invoke();

            gameObject.SetActive(false);
        }
    }
}
