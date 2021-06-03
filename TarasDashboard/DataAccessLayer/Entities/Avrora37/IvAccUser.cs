using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvAccUser
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public short UserId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public string DocName { get; set; }
        public string TableDesc { get; set; }
        public byte? AccRead { get; set; }
        public string Чтение { get; set; }
        public byte? AccInsert { get; set; }
        public string Добавление { get; set; }
        public byte? AccUpdate { get; set; }
        public string Изменение { get; set; }
        public byte? AccDelete { get; set; }
        public string Удаление { get; set; }
        public int Количество { get; set; }
    }
}
