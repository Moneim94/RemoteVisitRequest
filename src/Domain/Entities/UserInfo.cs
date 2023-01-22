using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities;
public class UserInfo
{
    public int Id { get; set; }
    public long NationalId { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string FatherName { get; set; }
    public string GrandPaName { get; set; }
    public string FamilyName { get; set; }
    public int NationalityId { get; set; }
    public int GenderId { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public IList<VisitOrder> VisitOrders { get; set; }
}
