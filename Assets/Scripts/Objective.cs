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

            //specific for moving a chair (objective 1)

            if (gameObject.name == "Objective 1")
            {
                if(MoveChair.firstObjectiveDone == false)
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);

                    MoveChair.firstObjectiveDone = true;
                }
                else { return; }
            }


            //specific for making a mess (objective 2
            
            if (gameObject.name == "Objective 2")
            {
                if (ShelfPull.itemsPulled == 15)
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                }
                else { return; }
            }

            //specific for pushing all chairs in (objective 3)
            if (gameObject.name == "Objective 3")
            {
                if(MoveChair.chairsIn == 8) 
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                }
                else { return; }
            }

            //specific for clearing table (objective 4)
            if (gameObject.name == "Objective 4")
            {
                if(Tableclear.clearedItems == 10)
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                }
                else { return; }
            }

            //specific for trying to leave the first time (objective 5)
            if (gameObject.name == "Objective 5")
            {
                if (!Escape.hasTriedEscape)
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                    Escape.hasTriedEscape = true;
                    
                   
                }
                else { return; }
            }

            //specific for turning off all the torches (objective 6)
            if (gameObject.name == "Objective 6")
            {
                if (ToggleTorch.torchesOff == 14)
                {
                    objectiveDisplay.text = "";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                }
                else { return; }
            }

            //specific for leaving (objective 7)
            if (gameObject.name == "Objective 7")
            {
                if (Escape.hasTriedEscape)
                {
                    objectiveDisplay.text = "Game Completed";

                    OnCompleteObjective.Invoke();

                    gameObject.SetActive(false);
                   
                }
            }
        }
    }
}
