namespace developer0223.Tools.Demo
{
    // Unity
    using UnityEngine;

    public class FpsDisplayerSample : MonoBehaviour
    {
        private void Start()
        {
            FpsDisplayer fpsDisplayer = FpsDisplayer.Create(75, DisplayPosition.UpperRight);
        }
    }
}