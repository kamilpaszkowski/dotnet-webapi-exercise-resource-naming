namespace Euvic.WebAPI.ResourcesNaming.Controllers.Requests
{
    public class UpdateTrainingRequest
    {
        public int TrainingDate { get; set; }
        public int DurationInMinutes { get; set; }
        public string Description { get; set; }
    }
}
