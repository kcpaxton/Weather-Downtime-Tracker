﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDowntime.MenuItems
{
    public class MasterPageItem
    {
        public string Title
        {
            get;
            set;
        }
        public string Icon
        {
            get;
            set;
        }
        public Type TargetType
        {
            get;
            set;
        }
    }
}
