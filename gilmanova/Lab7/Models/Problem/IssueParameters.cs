﻿using System.Windows.Media.Effects;

namespace Numerics7
{
    internal class IssueParameters
    {
        /// <summary>
        /// Step of x-dim partition
        /// </summary>
        public double Hx { get; set; }
        
    
        /// <summary>
        /// Step of y-dim partition
        /// </summary>
        public double Hy { get; set; }



        /// <summary>
        /// The last x-dim value
        /// </summary>
        public double RightX { get; set; }

        /// <summary>
        /// The last y-dim value
        /// </summary>
        public double TopY { get; set; }

        /// <summary>
        /// The last x-dim number
        /// </summary>
        public int Nx { get; set; }

        /// <summary>
        /// The last y-dim number
        /// </summary>
        public int Ny { get; set; }

        public int To1DIndex(int xIndex, int yIndex) => (Nx + 1) * yIndex + xIndex - 1 - (yIndex >= 1 ? 1 : 0) - (yIndex == Ny ? 1 : 0);
    }
}
