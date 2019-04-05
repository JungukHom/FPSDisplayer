namespace developer0223.Tools.Demo
{
    // Unity
    using UnityEngine;

    public class FpsDisplayerSample : MonoBehaviour
    {
        private void Start()
        {
            //FpsDisplayer sample_01 = FpsDisplayer.Create();
            //FpsDisplayer sample_02 = FpsDisplayer.Create(30);
            FpsDisplayer sample_03 = FpsDisplayer.Create(75, DisplayPosition.UpperRight);
        }
    }
}