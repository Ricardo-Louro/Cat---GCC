using UnityEngine;

public class RequiredItem : MonoBehaviour
{
    private CompleteObjective completeObjective;

    private void Start()
    {
        completeObjective = FindObjectOfType<CompleteObjective>();
        completeObjective.requiredItemList.Add(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            completeObjective.requiredItemList.Remove(this);
            completeObjective.CheckObjectiveCompletion();
        }
    }
}