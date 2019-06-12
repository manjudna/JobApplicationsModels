using System.Collections.Generic;

namespace JobApplicationModels
{
    public class ApplicantQualification
    {
        public string Name { get; set; }

        public List<ApplicantQuestion> ApplicantQuestions { get; set; }
    }
}
