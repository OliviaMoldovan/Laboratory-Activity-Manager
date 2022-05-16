namespace LabzApplication
{
    public class Submission
    {
        public int SubmissionId { get; set; }

        public int StudentId { get; set; }

        public int AssignmentId { get; set; }

        public string Comment { get; set; }

        public string GitLink { get; set; }

        //fara lab id
    }
}
