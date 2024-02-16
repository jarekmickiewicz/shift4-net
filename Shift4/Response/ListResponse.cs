﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shift4.Response
{
    public class ListResponse<T>{

    
        [JsonProperty("list")]
        public List<T> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }
}
