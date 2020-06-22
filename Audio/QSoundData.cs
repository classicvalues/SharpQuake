﻿/* Rewritten in C# by Yury Kiselev, 2010.
 *
 * Copyright (C) 1996-1997 Id Software, Inc.
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *
 * See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */

namespace SharpQuake
{
    internal class QSoundData
    {
        public bool   gamealive;
        public bool   soundalive;
        public bool   splitbuffer;
        public int    channels;
        public int    samples;          // mono samples in buffer
        public int    submission_chunk; // don't mix less than this #
        public int    samplepos;        // in mono samples
        public int    samplebits;
        public int    speed;
        public byte[] buffer;
    }
}