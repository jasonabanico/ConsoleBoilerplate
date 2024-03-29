﻿using ConsoleBoilerplate.Models;
using ConsoleBoilerplate.Services.Interfaces;

namespace ConsoleBoilerplate.Services
{
    public class BusinessHelper
    {
        public static void Process(ParentItem parentItem)
        {
            parentItem.IsProcessed = true;
            if (parentItem.ChildItems != null)
            {
                foreach (var childItem in parentItem.ChildItems)
                {
                    childItem.IsProcessed = true;
                }
            }
        }

        public static void Process(ParentItem[] parentItems)
        {
            foreach (var parentItem in parentItems)
            {
                Process(parentItem);
            }
        }
    }
}
