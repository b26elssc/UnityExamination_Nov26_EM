using UnityEngine;
using UnityEngine.Events;

public class WinScreen : MonoBehaviour
{
    public counterPerhaps counter;

    public int winAmount;
    public UnityEvent onWin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.countNumber >= winAmount)
        {
            onWin.Invoke();
        }
    }

    public void WinAmountChanged()
    {
        winAmount = winAmount + 1;
    }
}
