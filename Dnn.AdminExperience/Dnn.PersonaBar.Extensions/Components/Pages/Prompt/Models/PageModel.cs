﻿// 
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// 
namespace Dnn.PersonaBar.Pages.Components.Prompt.Models
{
    public class PageModel : PageModelBase
    {
        public string Container { get; set; }
        public string Url { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }

        public PageModel()
        {
        }
        public PageModel(DotNetNuke.Entities.Tabs.TabInfo tab): base(tab)
        {
            Container = tab.ContainerSrc;
            Url = tab.Url;
            Keywords = tab.KeyWords;
            Description = tab.Description;
        }
    }
}
