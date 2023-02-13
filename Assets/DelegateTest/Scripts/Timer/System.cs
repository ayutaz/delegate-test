using UnityEngine;

namespace DelegateTest.Timer
{
    public class System : MonoBehaviour
    {
        private void Start()
        {
            var timer = new Timer();
            // timer.OnComplete += Alarm;
            // timer.CountDown();
            timer.CountDownCallback(isComplete => Debug.Log(isComplete));
        }

        private static void Alarm()
        {
            Debug.Log("カウントダウン終了");
        }
    }
}