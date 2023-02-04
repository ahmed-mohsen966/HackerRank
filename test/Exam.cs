namespace test
{
    public class Exam
    {
        public string ExamName { get; set; }
        private ExamStatus status;
        public ExamStatus Status
        {
            get { return status; }
            set { status = value; }

        }
    }
    
}
