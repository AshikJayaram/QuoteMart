using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Query
{
    public class InsurerBenefitDetailsService : IQueryFor<string, BenefitDetails>
    {
        public BenefitDetails ExecuteQueryWith(string input) {
            var benefitDetails = new BenefitDetails();

            switch (input)
            {
                case "1":
                    benefitDetails.Premium = 4240.00;
                    benefitDetails.Benefits = new List<Benefit>();
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Outpatient care—the kind you get without being admitted to a hospital",
                        Id = 345,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Mental health and substance use disorder services: This includes behavioral health treatment, counseling, and psychotherapy",
                        Id = 346
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Services and devices to help you recover if you are injured, or have a disability or chronic condition. This includes physical and occupational therapy, speech-language pathology, psychiatric rehabilitation, and more.",
                        Id = 347,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Preventive services including counseling, screenings, and vaccines to keep you healthy and care for managing a chronic disease.",
                        Id = 348
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Pediatric services: This includes dental care and vision care for kids",
                        Id = 349,
                        IsActive = true
                    });
                    break;

                case "2":
                    benefitDetails.Premium = 5645.00;
                    benefitDetails.Benefits = new List<Benefit>();
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Outpatient care—the kind you get without being admitted to a hospital",
                        Id = 345
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Short-Term Crisis Intervention Mental Health Counselling Benefit Information: New Mental Health Counselling Publication",
                        Id = 345,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Services and devices to help you recover if you are injured, or have a disability or chronic condition. This includes physical and occupational therapy, speech-language pathology, psychiatric rehabilitation, and more.",
                        Id = 345
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Pharmacy Benefit Information : Pharmacist Prescribing - Lice Treatment, Introduction of Dose Limit for Stimulants, Reduction in Dose Limits for Opioids and Benzodiazepines",
                        Id = 345,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Medical Supplies and Equipment Benefit Information: Improved Access to Ostomy Supplies",
                        Id = 345
                    });
                    break;

                default: benefitDetails.Premium = 5674.98;
                    benefitDetails.Benefits = new List<Benefit>();
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Outpatient care—the kind you get without being admitted to a hospital",
                        Id = 345
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Short-Term Crisis Intervention Mental Health Counselling Benefit Information: New Mental Health Counselling Publication",
                        Id = 345,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Services and devices to help you recover if you are injured, or have a disability or chronic condition. This includes physical and occupational therapy, speech-language pathology, psychiatric rehabilitation, and more.",
                        Id = 345,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Mental health and substance use disorder services: This includes behavioral health treatment, counseling, and psychotherapy",
                        Id = 345,
                        IsActive = true
                    });
                    benefitDetails.Benefits.Add(new Benefit
                    {
                        Description = "Medical Supplies and Equipment Benefit Information: Improved Access to Ostomy Supplies",
                        Id = 345
                    });
                    break;
            }

            return benefitDetails;
           
        }
    }
}

