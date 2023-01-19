using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Order.Domain.Entities;
public class VisitOrder
{
    public string VisitPurpose { get; set; }
    public string Reason { get; set; }
    public Date Date { get; set; }
    public VisitType VisitType { get; set; }
    public string Note { get; set; }
    public int UserInfoId { get; set; }
    public UserInfo UserInfo { set; get; }
}
