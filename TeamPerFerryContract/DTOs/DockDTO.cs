using System.Collections.Generic;

namespace TeamPerFerryContract
{
    public class DockDTO
    {
        public long DockId { get; set; }
        public string DockName { get; set; }
        public List<UserDTO> Users { get; set; }
    }
}