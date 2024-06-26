﻿using LPR.DAL.Entities;
using LPR.DAL.Interfaces.IRepositories;
using LPR.Service.DTO;
using LPR.Service.IServices;

namespace LPR.Service.Services
{
    public class ProfesionnalService : IProfesionnalService
    {
        private readonly IProfesionnalRepository profesionnalRepository;
        private readonly IDateRepository dateRepository;

        public ProfesionnalService(IProfesionnalRepository profesionnalRepository, IDateRepository dateRepository)
        {
            this.profesionnalRepository = profesionnalRepository;
            this.dateRepository = dateRepository;
        }
        public string AddProfesionnalAvailability(Guid idProfesionnal, List<SetOrAddDateDTO> profesionnalAvailability)
        {
            var result = "NotOk";
            profesionnalAvailability.ForEach(x =>
            {
                DateAvailability dateEntity = ToDateSetOrAddDtoMap(x);
                if (CheckAvailabilityExists(idProfesionnal, profesionnalAvailability) == false)
                {
                    dateRepository.AddDateByProfesionnalId(idProfesionnal, dateEntity);
                    result = "Ok";
                }
            });
            return result;
        }

        public void AddProfesionnal(ProfesionnalDTO profesionnalDTO)
        {
            var ProfesionnalEntity = new Professional()
            {
                Id = new Guid(),
                FirstName = profesionnalDTO.FirstName,
                gender = profesionnalDTO.gender
            };
            profesionnalRepository.Add(ProfesionnalEntity);
            profesionnalRepository.Save();
        }

        public List<ProfesionnalDTO>? GetAll()
        {
            var profesionnalDTOs = new List<ProfesionnalDTO>();
            profesionnalRepository.GetAll().ForEach(x =>
               {
                   profesionnalDTOs.Add(new ProfesionnalDTO()
                   {
                       Id = x.Id,
                       FirstName = x.FirstName,
                       gender = x.gender
                   });
               });
            return profesionnalDTOs;
        }
        public ProfesionnalDTO? GetProfesionnalById(Guid id)
        {
            var profesionnal = profesionnalRepository.GetSingleNonTrackingBy(x => x.Id == id && x.IsDeleted == false);
            return new ProfesionnalDTO
            {
                Id = profesionnal.Id,
                FirstName = profesionnal.FirstName,
                gender = profesionnal.gender,
            };
        }
        public List<GetDateDTO> getProfesionnalAvailability(Guid id)
        {
            var pro = profesionnalRepository.GetSingleBy(x => x.Id == id).Result;
            var proDates = dateRepository.getDatesByProfesionnalId(id, true);
            var datesDto = ToListDateDTOMap(proDates);
            List<GetDateDTO> datesToShow = ToGetDatesDtoMap(datesDto);
            return datesToShow;
        }
        public bool CheckAvailabilityExists(Guid idProfesionnal, List<SetOrAddDateDTO> profesionnalAvailabilityDatesDTO)
        {
            var exists = false;
            var datesReserved = dateRepository.getDatesByProfesionnalId(idProfesionnal,true);
            profesionnalAvailabilityDatesDTO.ForEach(x =>
            {
                var dateReserved = datesReserved.Where(y => y.Label == x.Label).FirstOrDefault();
                if (dateReserved != null)
                {
                    x.HoursDto?.ForEach(h =>
                    {
                        if (dateReserved?.HoursAvailabilities?.Any(z => z.Label == h.Label) == true)
                        {
                            exists = true;
                            return;
                        }
                    });
                }

            });
            return exists;
        }
        public static List<GetDateDTO> ToGetDatesDtoMap(List<DateDTO> datesDto)
        {
            
            var result = new List<GetDateDTO>();
            datesDto.ForEach(x =>
            {
                result.Add(ToGetDatesDtoMap(x));
            });
            return result;
        }
        public static GetDateDTO ToGetDatesDtoMap(DateDTO dateDto)
        {
            return new GetDateDTO()
            {
                IdDate = dateDto.IdDate,
                LabelDate = dateDto.Label,
                HoursDto = dateDto.HoursDto
            };
        }
        public static DateAvailability ToDateSetOrAddDtoMap(SetOrAddDateDTO profesionnalAvailability)
        {
            var dateToAdd =  new DateAvailability()
            {
                Id = new Guid(),
                Label = profesionnalAvailability.Label,
                RealDate = DateTime.Now,
            };
            dateToAdd.HoursAvailabilities = ToListHourSetOrAddDTOMap(dateToAdd.Id, profesionnalAvailability.HoursDto);
            return dateToAdd;
        }
        public static HourAvailability ToHourSetOrAddDTOMap(Guid dateId,SetOrAddHourDTO hourDto)
        {
            return new HourAvailability()
            {
                Id = new Guid(),
                Label = hourDto.Label,
                DateId = dateId,
            };
        }
        public static List<HourAvailability> ToListHourSetOrAddDTOMap(Guid dateId, List<SetOrAddHourDTO> listHourDto)
        {
            var resultList = new List<HourAvailability>();
            listHourDto.ForEach(x =>
            {
                resultList.Add(ToHourSetOrAddDTOMap(dateId, x));
            });
            return resultList;
        }

        public static HourDTO ToHourDTOMap(HourAvailability hourEntity)
        {
            return new HourDTO()
            {
                Id = hourEntity.Id,
                Label = hourEntity.Label
            };
        }
        public static List<HourDTO> ToListHourDTOMap(List<HourAvailability> hourEntities)
        {
            var list = new List<HourDTO>();
            hourEntities.ForEach(x =>
            {
                list.Add(ToHourDTOMap(x));
            });
            return list;
        }
        public static DateDTO ToDateDTOMap(DateAvailability dateEntity)
        {
            return new DateDTO()
            {
                IdDate = dateEntity.Id,
                Label = dateEntity.Label,
                HoursDto = ToListHourDTOMap(dateEntity?.HoursAvailabilities)
            };
        }
        public static List<DateDTO> ToListDateDTOMap(List<DateAvailability> dateEntities)
        {
            var list = new List<DateDTO>();
            dateEntities.ForEach(x =>
            {
                list.Add(ToDateDTOMap(x));
            });
            return list;
        }


    }
}
