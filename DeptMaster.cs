using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MainProjectPhase3.Models
{
    [Table("DeptMaster")]
    public class DeptMaster
    {

        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set; } = null!;

        public ICollection<EmpProfile>? EmpProfiles { get; set; }
    }
}
