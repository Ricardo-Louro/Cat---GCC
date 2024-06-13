using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class CompleteObjective : MonoBehaviour
{
    public List<RequiredItem> requiredItemList;
    private CatBed catBed;

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private TextMeshProUGUI objectiveMessage;
    [SerializeField] private TextMeshProUGUI completionMessage;

    private void Awake()
    {
        requiredItemList.Clear();
        catBed = FindObjectOfType<CatBed>();
    }

    public void CheckObjectiveCompletion()
    {
        if (requiredItemList.Count() == 0)
        {
            audioSource.Play();
            catBed.enabled = true;

            objectiveMessage.enabled = false;
            completionMessage.enabled = true;
        }
    }
}