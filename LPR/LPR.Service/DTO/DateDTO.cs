namespace LPR.Service.DTO
{
    public class DateDTO
    {
        public Guid? Id { get; set; }

        public required string Label { get; set; }

        public  DateTime? RealDate { get; set; }

        public Guid? ProfesionnalId { get; set; }
    }
}
