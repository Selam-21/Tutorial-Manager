namespace Tutorial_Manager.Models.services
{
    public class SubjectService : ISubjectService
    {
        private readonly TutorialContext _context;

        public SubjectService(TutorialContext context)
        {
            _context = context;
        }
        public void Add(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var data = _context.Subjects.Find(id);
            _context.Subjects.Remove(data);

            _context.SaveChanges();
        }

        public List<Subject> GetAll()
        {
            var data = _context.Subjects.ToList();

            return data;

        }

        public Subject GetById(long id)
        {
            var result = _context.Subjects.Find(id);
            return result;
        }

        public void Update(Subject subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges();
        }
    }
}
