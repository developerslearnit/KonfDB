﻿#region License and Product Information

// 
//     This file 'GrantAccess.cs' is part of KonfDB application - 
//     a project perceived and developed by Punit Ganshani.
// 
//     KonfDB is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     KonfDB is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with KonfDB.  If not, see <http://www.gnu.org/licenses/>.
// 
//     You can also view the documentation and progress of this project 'KonfDB'
//     on the project website, <http://www.konfdb.com> or on 
//     <http://www.ganshani.com/applications/konfdb>

#endregion

using KonfDB.Infrastructure.Database.Enums;
using KonfDBCF.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace KonfDBCF.Commands
{
    public class GrantAccess : ClientCommand
    {
        [JsonProperty("sid")]
        public int? SuiteId { get; set; }

        [JsonProperty("user")]
        public string Username { get; set; }

        [JsonProperty("role")]
        [JsonConverter(typeof (StringEnumConverter))]
        public RoleType Role { get; set; }

        public GrantAccess()
        {
            Command = "GrantAccess";
        }

        public override bool IsValid()
        {
            return SuiteId.HasValue && !string.IsNullOrEmpty(Username);
        }
    }
}