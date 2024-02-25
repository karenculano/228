﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="hb_filter_ids.cs" company="HandBrake Project (https://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.Interop.HbLib
{
    public enum hb_filter_ids
    {
        HB_FILTER_INVALID = 0,
        HB_FILTER_FIRST = 1,

        HB_FILTER_PRE_VT,
        // First, filters that may change the framerate (drop or dup frames)
        HB_FILTER_DETELECINE,
        HB_FILTER_COMB_DETECT,
        HB_FILTER_COMB_DETECT_VT,
        HB_FILTER_DECOMB,
        HB_FILTER_YADIF,
        HB_FILTER_YADIF_VT,
        HB_FILTER_BWDIF,
        HB_FILTER_BWDIF_VT,
        HB_FILTER_VFR,
        // Filters that must operate on the original source image are next
        HB_FILTER_DEBLOCK,
        HB_FILTER_DENOISE,
        HB_FILTER_HQDN3D = HB_FILTER_DENOISE,
        HB_FILTER_NLMEANS,
        HB_FILTER_CHROMA_SMOOTH,
        HB_FILTER_CHROMA_SMOOTH_VT,
        HB_FILTER_ROTATE,
        HB_FILTER_ROTATE_VT,
        HB_FILTER_RENDER_SUB,
        HB_FILTER_CROP_SCALE,
        HB_FILTER_CROP_SCALE_VT,
        HB_FILTER_LAPSHARP,
        HB_FILTER_LAPSHARP_VT,
        HB_FILTER_UNSHARP,
        HB_FILTER_UNSHARP_VT,
        HB_FILTER_GRAYSCALE,
        HB_FILTER_GRAYSCALE_VT,
        HB_FILTER_PAD,
        HB_FILTER_PAD_VT,
        HB_FILTER_COLORSPACE,
        HB_FILTER_FORMAT,
        HB_FILTER_RPU,

        // Finally filters that don't care what order they are in,
        // except that they must be after the above filters
        HB_FILTER_AVFILTER,

        HB_FILTER_LAST,
        // wrapper filter for frame based multi-threading of simple filters
        HB_FILTER_MT_FRAME
    }
}
