using UnityEngine;

public class Objective : MonoBehaviour
{

    [SerializeField]private string objectiveText = "objective 1";
    // Start is called before the first frame update

    private void OnEnable() 
    {
        Debug.Log(objectiveText);
    }
    void Start()
    {
        
    }

}
