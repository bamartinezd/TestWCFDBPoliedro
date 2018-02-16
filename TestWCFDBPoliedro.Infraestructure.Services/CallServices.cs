using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Infraestructure.Services.ServiceActivation;

namespace TestWCFDBPoliedro.Infraestructure.Services
{
    public class CallServices
    {
        private readonly ValidationServiceContractClient _serviceActivation;

        public CallServices(){
            _serviceActivation = new ValidationServiceContractClient();
        }

        public List<Validator> GetValidateActivation(decimal activationUID, int companyId)
        {
            CategoryCollection category = new CategoryCollection();
            CreditSecurityContextRequest creditSecurity = new CreditSecurityContextRequest();
            CategoryCollection validatorResults = new CategoryCollection();
            List<CategoryCollection> listCategory = new List<CategoryCollection>();
            bool globalResult = true;
            List<Validator> listValidator = new List<Validator>();

            string[] result = _serviceActivation.ValidateActivation(activationUID, companyId, creditSecurity, 
                                                                    out globalResult, out validatorResults);
            listCategory.Add(validatorResults);

            for (int i = 0; i < listCategory.Count; i++)
            {
                for (int j = 0; j < listCategory[i].Count; j++)
                {
                    listValidator.AddRange(listCategory[i][j].Validators);   
                }                 
            }

            return listValidator.ToList();
        }

    }
}
