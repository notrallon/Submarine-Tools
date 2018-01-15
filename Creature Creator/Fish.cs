using UnityEngine;

[CreateAssetMenu(fileName = "New Fish", menuName = "Sea Creatures/Fish")]
public class Fish : ScriptableObject {

    [SerializeField]
    private string type;
    [SerializeField]
    private string description;
    [SerializeField]
    private float swimSpeed;
    [SerializeField]
    private float turnSpeed;

    public string Type { get { return type; } }
    public string Description { get { return description; } }
    public float SwimSpeed { get { return swimSpeed; }  }
    public float TurnSpeed { get { return turnSpeed; } }
    
    public void Print() {
        Debug.Log("Fish type " + type);
        Debug.Log("Fish desciption " + description);
        Debug.Log("Fish speed " + swimSpeed);
        Debug.Log("Fish turn speed " + turnSpeed);
    }
    
}
