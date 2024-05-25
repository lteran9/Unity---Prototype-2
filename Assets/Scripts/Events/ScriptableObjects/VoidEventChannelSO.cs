using System;
using UnityEngine;
using UnityEngine.Events;

namespace Prototype2.Events.ScriptableObjects {
   [CreateAssetMenu(menuName = "Events/Void Event Channel")]
   public class VoidEventChannelSO : EventChannelSO {
      public void Subscribe(UnityAction callback) {
         OnEventRaised += callback;
      }

      public void Unsubscribe(UnityAction callback) {
         OnEventRaised -= callback;
      }
   }
}

