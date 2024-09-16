using System;

public class HapticFeedbackSystem
{
    private const int ArraySize = 1000;
    private const int VibrationInterval = 100;
    private float[] amplitudeArray = new float[ArraySize];
    private int currentPointer = 0;
    private float materialConstant;
    private float maxPressure;
    private float currentPressure;
    private float boxHeight = 40f; // 4cm in mm

    public HapticFeedbackSystem(float materialConstant, float maxPressure)
    {
        this.materialConstant = materialConstant;
        this.maxPressure = maxPressure;
        InitializeAmplitudeArray();
    }

    private void InitializeAmplitudeArray()
    {
        for (int i = 0; i < ArraySize; i++)
        {
            amplitudeArray[i] = (i % VibrationInterval == 0) ? 1f : 0f;
        }
    }

    public float UpdatePressure(float newPressure)
    {
        float oldPressure = currentPressure;
        currentPressure = newPressure;

        if (materialConstant == 0) // Rigid object
        {
            return 0;
        }

        float springConstant = 1f / materialConstant;
        float compressionRatio = currentPressure / maxPressure;
        float compression = compressionRatio * springConstant * boxHeight;

        int newPointer = (int)(compression / boxHeight * ArraySize);
        newPointer = Math.Min(newPointer, ArraySize - 1);

        float vibrationAmplitude = 0;

        if (newPointer != currentPointer)
        {
            int step = Math.Sign(newPointer - currentPointer);
            while (currentPointer != newPointer)
            {
                currentPointer += step;
                if (amplitudeArray[currentPointer] > 0)
                {
                    vibrationAmplitude = amplitudeArray[currentPointer];
                    break;
                }
            }
        }

        return vibrationAmplitude;
    }

    public float GetCurrentCompression()
    {
        if (materialConstant == 0) return 0;
        float springConstant = 1f / materialConstant;
        float compressionRatio = currentPressure / maxPressure;
        return compressionRatio * springConstant * boxHeight;
    }
}