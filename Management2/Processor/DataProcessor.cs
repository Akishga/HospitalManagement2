using Management2.ManagemnetEntity;
using Management2.Models;
using Management2.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Management2.Processor
{
    public class DataProcessor :Iprocessor
    {
        private readonly ManagementContext _dbcontext;
        private readonly ILogger<DataProcessor> _logger;
        public DataProcessor(ManagementContext dbcontext, ILogger<DataProcessor> logger)
        {
            _dbcontext = dbcontext;
            _logger = logger;   
        }

        public bool AddDoctor(Doctor req)
        {
            bool response = false;
            int flag = 0;
            try
            {
                 _dbcontext._AddDoc.Add(req);
                 flag= _dbcontext.SaveChanges();
                if(flag>0)
                {
                    response = true;    
                }
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at:", ex);
            }
            return response;
        }

        public List<Doctor> GetDoctorList()
        {
            IEnumerable<Doctor> listDoctor = null;
            try
            {
                listDoctor = _dbcontext._AddDoc;
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at:", ex);
            }
            return listDoctor.ToList();
        }
    }
}
