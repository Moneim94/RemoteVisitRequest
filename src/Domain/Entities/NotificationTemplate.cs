using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities;
public  class NotificationTemplate
{
    public int Id { get; set; }
    public string Template { get; set; }
    public int NotificationLogId { get; set; }
    public NotificationLog NotificationLog { get; set; }

}
