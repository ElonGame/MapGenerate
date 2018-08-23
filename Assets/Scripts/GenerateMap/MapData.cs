﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EarthSimulator.MapEditor
{
    public class MapData
    {
        private static Color mapColor = Color.red;
        private static Color changeColor = Color.blue;
        private static Texture2D map = null;
        private static RawImage image;

        public static int ProvinceNum = 0;
        public static bool IsForceContinue = false;
        public static float BoarderGenerateSpeed = 10;
        public static float MapGenerateSpeed = 1;

        public static Color MapColor
        {
            get
            {
                return mapColor;
            }
            set
            {
                mapColor = value;
            }
        }

        public static Color ChangeColor
        {
            get
            {
                return changeColor;
            }
            set
            {
                changeColor = value;
            }
        }

        public static Color GetMapColor(int x, int y)
        {
            return map.GetPixel(x - 1, y);
        }

        public static Texture2D Map
        {
            get
            {
                return map;
            }
            set
            {
                if (map == null || value == null)
                    map = value;
            }
        }

        public static RawImage Image
        {
            get
            {
                return image;
            }
            set
            {
                if (image == null || value == null)
                    image = value;
            }
        }
    }
}