#if UNITY_EDITOR

using UnityEngine;
using System.Collections.Generic;

public class Data : MonoBehaviour
{
    [field: SerializeField] public int ID { get; set; }
    [field: SerializeField] public string name { get; set; }    

}

#endif
