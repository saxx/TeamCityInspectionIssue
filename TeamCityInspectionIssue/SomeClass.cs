using JetBrains.Annotations;

namespace TeamCityInspectionIssue
{
    public class SomeClass
    {

        [NotNull]
        public object SomeMethod([CanBeNull]object someParameter)
        {
            return null;
        }
    }
}