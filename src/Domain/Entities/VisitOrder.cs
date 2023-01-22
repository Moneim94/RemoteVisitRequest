using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Order.Domain.Entities;
public class VisitOrder
{
    public int Id { get; set; }
    public string VisitPurpose { get; set; }
    public string Reason { get; set; }
    public DateTime Date { get; set; }
    public VisitType VisitType { get; set; }
    public string Note { get; set; }
    public string MeetingURL { get; set; }
    public int NotificationTemplateId { get; set; }
    public NotificationTemplate NotificationTemplate { get; set; }
    public OrderStatus Status { get; set; }
    public int UserInfoId { get; set; }
    public UserInfo UserInfo { set; get; }
    public int CourtId { get; set; }
    public Court Court { get; set; }
}
