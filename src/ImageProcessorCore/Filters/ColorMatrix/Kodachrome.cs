﻿// <copyright file="Kodachrome.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessorCore.Filters
{
    using System.Numerics;

    /// <summary>
    /// Converts the colors of the image recreating an old Kodachrome camera effect.
    /// </summary>
    public class Kodachrome : ColorMatrixFilter
    {
        /// <inheritdoc/>
        public override Matrix4x4 Matrix => new Matrix4x4()
        {
            M11 = 0.6997023f,
            M22 = 0.4609577f,
            M33 = 0.397218f,
            M41 = 0.005f,
            M42 = -0.005f,
            M43 = 0.005f
        };
    }
}
