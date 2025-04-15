using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorManager : MonoBehaviour
{
    [System.Serializable]
    public class KeyDoorPair
    {
        public GameObject keyObject;
        public Animator doorAnimator;
        public string doorAnimationTrigger = "CollectedTrigger";
    }

    public List<KeyDoorPair> keyDoorPairs = new List<KeyDoorPair>();

    public List<GameObject> collectedKeys = new List<GameObject>();

    public void CollectedKey(GameObject key)
    {
        collectedKeys.Add(key);
    }

    public void TriggerDoorAnimationForKey(GameObject collectedKey)
    {
        foreach (KeyDoorPair pair in keyDoorPairs)
        {
            if (pair.keyObject == collectedKey)
            {
                pair.doorAnimator.SetTrigger(pair.doorAnimationTrigger);
                return;
            }
        }

        Debug.LogWarning("No door found for the collected key.");
    }
}
