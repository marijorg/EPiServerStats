﻿using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Business.Property
{
    public class ChartTitlePositionSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[]
            {
                new SelectItem() { Text = "Top", Value = "Top" },
                new SelectItem() { Text = "Bottom", Value = "Bottom" }
            };
        }
    }
}