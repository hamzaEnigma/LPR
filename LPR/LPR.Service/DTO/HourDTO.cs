using LPR.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LPR.Service.DTO
{
    public class HourDTO
    {
        public Guid Id { get; set; }
        public required string Label { get; set; }
    }
}
