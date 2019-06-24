﻿using CompeTournament.Backend.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompeTournament.Backend.Data.Entities
{
    public class Group : AuditEntity,  IBaseEntity
    {
        public string Requirements { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        public int TournamentTypeId { get; set; }
        [ForeignKey("TournamentTypeId")]
        public TournamentType TournamentType { get; set; } 
    

    }
}