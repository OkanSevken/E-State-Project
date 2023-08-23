using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GeneralSettingsManager : GeneralSettingsService
    {
        IGeneralSettingsRepository _generalSettingsRepository;
        public GeneralSettingsManager(IGeneralSettingsRepository generalSettingsRepository)
        {
            _generalSettingsRepository = generalSettingsRepository;
        }
        public void Add(GeneralSettings p)
        {
            _generalSettingsRepository.Add(p);  
        }

        public void Delete(GeneralSettings p)
        {
            _generalSettingsRepository.Delete(p);
        }

        public GeneralSettings GetById(int id)
        {
            return _generalSettingsRepository.GetById(id);
        }

        public List<GeneralSettings> List()
        {
            return _generalSettingsRepository.List();
        }

        public List<GeneralSettings> List(Expression<Func<GeneralSettings, bool>> filter)
        {
            return _generalSettingsRepository.List(filter);
        }

        public void Update(GeneralSettings p)
        {
            _generalSettingsRepository.Update(p);
        }
    }
}
