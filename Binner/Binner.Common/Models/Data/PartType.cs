﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Binner.Common.Models
{
    /// <summary>
    /// Defines a type of part or category/sub-category
    /// </summary>
    public class PartType
    {
        /// <summary>
        /// Primary key
        /// </summary>
        [Key]
        public long PartTypeId { get; set; }

        /// <summary>
        /// If this is a child type, indicates the parent type
        /// </summary>
        public int? ParentPartTypeId { get; set; }

        /// <summary>
        /// The name of the part type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional user id to associate
        /// </summary>
        public int? UserId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as PartType);
        }

        public bool Equals(PartType other)
        {
            return other != null && PartTypeId == other.PartTypeId && UserId == other.UserId;
        }

        public override int GetHashCode()
        {
#if (NET462 || NET471)
            return PartTypeId.GetHashCode() ^ (UserId?.GetHashCode() ?? 0);
#else
            return HashCode.Combine(PartTypeId, UserId);
#endif

        }

        public override string ToString()
        {
            return $"{PartTypeId}: {Name}";
        }
    }
}