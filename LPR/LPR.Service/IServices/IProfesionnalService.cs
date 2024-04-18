using LPR.Service.DTO;

namespace LPR.Service.IServices
{
    public interface IProfesionnalService
    {
        void AddProfesionnal(ProfesionnalDTO profesionnalDTO);
        List<ProfesionnalDTO>? GetAll();
        ProfesionnalDTO? GetProfesionnalById(Guid id);
    }
}
