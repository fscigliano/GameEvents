using UnityEngine;
using UnityEngine.Events;

namespace com.fscigliano.GameEvents
{
    /// <summary>
    /// Product Name:    GameEvents
    /// Developers:      Franco Scigliano
    /// Description:     
    /// Changelog:       
    /// </summary>
    public abstract class GameEvent2Listener<T, T2, TEvt, TUEvt> : MonoBehaviour where TEvt:GameEvent2<T, T2> where TUEvt:UnityEvent<T, T2>
    {
        [SerializeField] protected TEvt _evt;
        [SerializeField] protected TUEvt _uEvt;
        private void OnEnable()
        {
            _evt.AddListener(HandleEvt);
        }

        private void HandleEvt(T arg0, T2 arg1)
        {
            _uEvt.Invoke(arg0, arg1);
        }

        private void OnDisable()
        {
            _evt.RemoveListener(HandleEvt);
        }
    }
}