using LPR.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LPR.Service.DTO
{
    public class ProfesionnalDTO
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public string? gender { get; set; }
    }
}
