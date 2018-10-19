
namespace GradeBook.GradeBooks 
{
    public class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name, bool isWeighted) : base(name, isWeighted)
        {

            Type = Enums.GradeBookType.Standard;
        }

    }
}
