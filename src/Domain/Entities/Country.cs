using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities;
public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Court> Courts { get; set; }
    public IList<UserInfo> UserInfos { get; set; }
}
