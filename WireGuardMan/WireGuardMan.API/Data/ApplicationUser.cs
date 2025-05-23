using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WireGuardMan.API.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [PersonalData]
        public string DisplayName { get; set; } = "";

        // 添加其他自定义字段（可选）
        // public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
    }
}
