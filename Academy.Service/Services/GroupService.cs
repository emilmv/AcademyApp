using Academy.Core.Entities;
using Academy.Data;
using Academy.Service.Constants;
using Academy.Service.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class GroupService
    {
        public AcademyDbContext academyDbContext { get; set; }
        public GroupService()
        {
            academyDbContext = new();
        }
        public List<Group> GetAll() => academyDbContext.Groups
            .Include(g => g.Students)
            .AsNoTracking().ToList();
        public Group GetByID(int? id)
        {
            if (id is null) throw new NullInputException(ExceptionMessages.NullInputException);
            var exist = academyDbContext.Groups.AsNoTracking().FirstOrDefault(g => g.ID == id);
            if (exist is null) throw new NotFoundException(ExceptionMessages.NotFoundException);
            return exist;
        }
        public void Create(Group group)
        {
            if (academyDbContext.Groups.Any(g => g.Name.ToLower() == group.Name.ToLower())) throw new AlreadyExistsException(ExceptionMessages.AlreadyExistsException);
            academyDbContext.Groups.Add(group);
            academyDbContext.SaveChanges();
        }
        public void Update(int? id, Group group)
        {
            if (id is null) throw new NullInputException(ExceptionMessages.NullInputException);
            var exist = academyDbContext.Groups.FirstOrDefault(g => g.ID == id);
            if (academyDbContext.Groups
                .Any(g => g.Name.ToLower() == group.Name.ToLower() && g.ID != id)) throw new AlreadyExistsException(ExceptionMessages.AlreadyExistsException);
            else
            {
                exist.Name = group.Name;
                exist.Limit = group.Limit;
                academyDbContext.SaveChanges();
            }
        }

    }
}
