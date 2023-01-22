using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities;
public class NotificationLog
{
    public int Id { get; set; }
    public string Message { get; set; }
    public int NotificationTemplateId { get; set; }
    public NotificationTemplate NotificationTemplate { get; set; }

}
