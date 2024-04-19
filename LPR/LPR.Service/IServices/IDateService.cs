﻿using LPR.Service.DTO;

namespace LPR.Service.IServices
{
    public interface IDateService
    {
        void addDateAvailability(ProfesionnalAvailabilityDatesDTO profesionnalAvailability);
        List<DateDTO> getDateAvailabilityByProfesionnalId(Guid profesionnalId);

    }
}
