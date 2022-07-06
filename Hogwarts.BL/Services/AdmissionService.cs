using Hogwarts.BL.Services.Interfaces;
using Hogwarts.DataAccess.Context;
using Hogwarts.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.BL.Services
{
    public class AdmissionService : IAdmissionService
    {
        private readonly HowartsContext _context;
        public AdmissionService(HowartsContext context)
        {
            _context = context;
        }
        public bool AddAdmissionRequest(AdmissionRequestDto AdmissionRequestDto)
        {
            House houseSelected = _context.House.FirstOrDefault(house => house.Name.Equals(AdmissionRequestDto.House));
            _context.Add( new AdmissionRequest() 
            {
                Name = AdmissionRequestDto.Name,
                LastName = AdmissionRequestDto.LastName,
                Identification = AdmissionRequestDto.Identification,
                Age = 0,
                HouseId = houseSelected.Id
            });   
            _context.SaveChanges();
            return true;
        }
        public List<AdmissionRequest> GetAllAdmissionRequest()
        {   
            return _context.AdmissionRequest.ToList();
        }

        public bool UpdateAdmissionRequest(AdmissionRequestDto AdmissionRequestDto)
        {
            House houseSelected = _context.House.FirstOrDefault(house => house.Name.Equals(AdmissionRequestDto.House));
            var admissionRequest = _context.AdmissionRequest.FirstOrDefault(request => request.Identification.Equals(AdmissionRequestDto.Identification));
            admissionRequest.Name = AdmissionRequestDto.Name;
            admissionRequest.LastName = AdmissionRequestDto.LastName;
            admissionRequest.Identification = AdmissionRequestDto.Identification;
            admissionRequest.Age = 0;
            admissionRequest.HouseId = houseSelected.Id;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteAdmissionRequest(string Identification)
        {
            AdmissionRequest AdmissionRequestToDelete = _context.AdmissionRequest.Where(request => request.Identification.Equals(Identification)).First();
            _context.AdmissionRequest.Remove(AdmissionRequestToDelete);
            _context.SaveChanges();
            return true;
        }
    }

 
}
