﻿// 
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// 
using System.Runtime.Serialization;

namespace Dnn.PersonaBar.Pages.Services.Dto
{
    [DataContract]
    public class CopyThemeRequest
    {
        [DataMember(Name = "pageId")]
        public int PageId { get; set; }

        [DataMember(Name = "theme")]
        public Theme Theme { get; set; }
    }
}
