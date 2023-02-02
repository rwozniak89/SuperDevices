using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SuperDevices.Base.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Creator { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true, NullDisplayText = "", ConvertEmptyStringToNull = true)]
        [Required]
        public DateTime DateCreate { get; set; }

        public DateTime DateEdit { get; set; }

        public string Editor { get; set; } = string.Empty;

        public int Version { get; set; } = 1;

    }
}
