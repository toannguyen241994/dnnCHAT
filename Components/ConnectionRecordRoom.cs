﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using DotNetNuke.ComponentModel.DataAnnotations;

namespace Christoc.Modules.DnnChat.Components
{
    [TableName("DnnChat_ConnectionRecordRooms")]
    //setup the primary key for table
    [PrimaryKey("ConnectionRecordId,RoomId", AutoIncrement = false)]
    //configure caching using PetaPoco
    [Cacheable("ConnectRecordRoom", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ConnectionRecordId,RoomId")]
    public class ConnectionRecordRoom
    {
        ///<summary>
        /// The ConnectionRecordId of the user
        ///</summary>
        public int ConnectionRecordId { get; set; }

        ///<summary>
        /// The ID of the Room
        ///</summary>
        public Guid RoomId { get; set; }

        ///<summary>
        /// The date the user joined the room
        ///</summary>
        public DateTime JoinDate { get; set; }

        ///<summary>
        /// The date the user departed the room
        ///</summary>
        public DateTime? DepartedDate { get; set; }
        
       
    }
}