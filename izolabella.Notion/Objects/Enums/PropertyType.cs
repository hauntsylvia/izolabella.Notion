﻿using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PropertyType
    {
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value ="rich_text")]
        RichText,
        [EnumMember(Value ="text")]
        Text,
        [EnumMember(Value ="number")]
        Number,
        [EnumMember(Value ="select")]
        Select,
        [EnumMember(Value ="multi_select")]
        MultiSelect,
        [EnumMember(Value ="date")]
        Date,
        [EnumMember(Value ="people")]
        People,
        [EnumMember(Value ="files")]
        Files,
        [EnumMember(Value ="checkbox")]
        Checkbox,
        [EnumMember(Value ="url")]
        Url,
        [EnumMember(Value ="email")]
        Email,
        [EnumMember(Value ="phone_number")]
        PhoneNumber,
        [EnumMember(Value ="formula")]
        Formula,
        [EnumMember(Value ="relation")]
        Relation,
        [EnumMember(Value ="rollup")]
        Rollup,
        [EnumMember(Value ="created_time")]
        CreatedTime,
        [EnumMember(Value ="created_by")]
        CreatedBy,
        [EnumMember(Value ="last_edited_time")]
        LastEditedTime,
        [EnumMember(Value ="last_edited_by")]
        LastEditedBy
    }
}
