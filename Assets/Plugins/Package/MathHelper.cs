/***********************************************
 * MathHelper.cs
 * Provides a variety of common math functions for Unity3D projects
 ***********************************************/

using UnityEngine;

namespace gambit.mathhelper
{

    /// <summary>
    /// Provides additional math functionality common in Unity3D applications
    /// </summary>
    public static class MathHelper
    {

        #region PUBLIC - MAP

        /// <summary>
        /// Remaps a value from one range to another.
        /// </summary>
        /// <param name="value">The input value to remap.</param>
        /// <param name="fromMin">The original range's minimum.</param>
        /// <param name="fromMax">The original range's maximum.</param>
        /// <param name="toMin">The new range's minimum.</param>
        /// <param name="toMax">The new range's maximum.</param>
        /// <returns>The remapped value in the target range.</returns>
        //--------------------------------------------------------------------------------------------//
        public static float Map(float value, float fromMin, float fromMax, float toMin, float toMax)
        //--------------------------------------------------------------------------------------------//
        {
            if(fromMin == fromMax)
            {
                Debug.LogError( "MathHelper.cs Map() fromMin & fromMax are equal, returning the 'toMin' value" );
                return toMin;
            }
            if(toMin == toMax)
            {
                Debug.LogError( "MathHelper.cs Map() toMin & toMax are equal, returning the 'toMin' value" );
                return toMin;
            }
            if(fromMin == toMin && fromMax == toMax)
            {
                Debug.LogError( "MathHelper.cs Map() passed in 'fromMin' is the same as 'toMin', and 'fromMax' is the same as 'toMax'. Unable to continue" );
                return toMin;
            }

            //Perform the remapping
            return ((value - fromMin) * (toMax - toMin) / (fromMax - fromMin) + toMin);

        } //END Map Method

        #endregion

    } //END MathHelper class

} //END gambit.mathhelper namespace