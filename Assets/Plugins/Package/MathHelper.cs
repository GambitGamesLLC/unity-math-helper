using UnityEngine;

namespace gambit.mathhelper
{
    public static class MathHelper
    {
        /// <summary>
        /// Remaps a value from one range to another.
        /// </summary>
        /// <param name="value">The input value to remap.</param>
        /// <param name="inMin">The original range's minimum.</param>
        /// <param name="inMax">The original range's maximum.</param>
        /// <param name="outMin">The new range's minimum.</param>
        /// <param name="outMax">The new range's maximum.</param>
        /// <returns>The remapped value in the target range.</returns>
        //--------------------------------------------------------------------------------------------//
        public static float Map(float value, float inMin, float inMax, float outMin, float outMax)
        //--------------------------------------------------------------------------------------------//
        {
            if (Mathf.Approximately(inMax - inMin, 0f))
            {
                Debug.LogWarning("[MathHelper] Input range is zero. Returning outMin.");
                return outMin;
            }

            float normalized = (value - inMin) / (inMax - inMin);
            return outMin + (normalized * (outMax - outMin));

        } //END Map
    
    } //END MathHelper class

} //END gambit.mathhelper namespace