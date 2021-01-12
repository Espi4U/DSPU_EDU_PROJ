using Newtonsoft.Json;

namespace DSPU_EDU_PROJ.Models
{
    public class NameIndexModel
    {
        public string Name { get; set; }

        public double Index { get; set; }

        public string DisplayName
        {
            get => $"{Name} [{Index}]";
        }
    }
}
