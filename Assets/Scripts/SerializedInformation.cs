using System;
using System.Collections.Generic;
using UnityEngine;

public class SerializedInformation : MonoBehaviour
{
   [SerializeField]
   private String selectInformationWith;
   
   [SerializeField]
   private List<SerializedClass> values;

   private SerializedClass _currentSerialiedClass;
   
   private void Awake()
   {
      values.ForEach((SerializedClass sClass) => {
         Debug.Log(sClass.information);  
      });

      _currentSerialiedClass = values.Find(
         (SerializedClass sClass) => sClass.information.Equals(selectInformationWith));
      if (_currentSerialiedClass == null)
      {
         Debug.LogError(selectInformationWith + " was not found!");
         Destroy(this);
      }
   }

   public float GetValueFromCurrentSerializedClass()
   {
      return _currentSerialiedClass.value;
   }
}

