namespace Tutorial_Manager.Models.services
{
    public interface ISubjectService
    {
        public void Add(Subject subject);
        public void Delete(long id);
        public void Update(Subject subject);
        public List<Subject> GetAll();
        public Subject GetById(long id);


    }
}
