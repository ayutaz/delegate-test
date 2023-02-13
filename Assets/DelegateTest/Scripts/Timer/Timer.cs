using UnityEngine;

namespace DelegateTest.Timer
{
    public class Timer
    {
        public delegate void OnCompleteDelegate();
        public OnCompleteDelegate OnComplete;

        public void CountDown()
        {
            // 本当はちゃんと3秒かけてカウントする
            Debug.Log(3);
            Debug.Log(2);
            Debug.Log(1);

            // コールバック
            OnComplete();
        }

        public delegate void OnCountDownDelegate(bool isComplete);
        public void CountDownCallback(OnCountDownDelegate onCountDownDelegate)
        {
            Debug.Log("カウントダウン開始");
            Debug.Log("3");
            Debug.Log("2");
            Debug.Log("1");
            Debug.Log("カウントダウン終了");
            onCountDownDelegate?.Invoke(true);
        }
    }
}