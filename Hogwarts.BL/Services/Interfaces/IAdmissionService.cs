using Hogwarts.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.BL.Services.Interfaces
{
    public interface IAdmissionService
    {
        public bool AddAdmissionRequest(AdmissionRequestDto AdmissionRequestDto);
        public List<AdmissionRequest> GetAllAdmissionRequest();

        public bool UpdateAdmissionRequest(AdmissionRequestDto AdmissionRequestDto);
        public bool DeleteAdmissionRequest(string Identification);
    }
}
