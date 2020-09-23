using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.EFCore.Dto {
    public class SystemUsersDto {
        public int UsersId { get; set; }
        public string UsersName { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string LoginIp { get; set; }
        public string IsEnable { get; set; }
        public DateTime? LoginTime { get; set; }
    }
}
