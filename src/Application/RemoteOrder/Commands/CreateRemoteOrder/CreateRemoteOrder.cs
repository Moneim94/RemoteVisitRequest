using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Order.Application.Common.Interfaces;
using Order.Application.TodoItems.Commands.CreateTodoItem;
using Order.Domain.Entities;
using Order.Domain.Enums;

namespace Order.Application.RemoteOrder.Commands.CreateRemoteOrder;
public record CreateVisitOrderCommand : IRequest<int>
{
    public string VisitPurpose { get; set; }
    public string Reason { get; set; }
    public DateTime Date { get; set; }
    public VisitType VisitType { get; set; }
    public string Note { get; set; }
    public string MeetingURL { get; set; }
    public int NotificationTemplateId { get; set; }
    public OrderStatus Status { get; set; }
    public int UserInfoId { get; set; }
    public int CourtId { get; set; }
}
public class CreateVisitOrderCommandHandler : IRequestHandler<CreateVisitOrderCommand, int>
{
    readonly IApplicationDbContext _applicationDbContext;
    readonly IMapper _imapper;
    public CreateVisitOrderCommandHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _imapper = mapper;
    }

    public async Task<int> Handle(CreateVisitOrderCommand request, CancellationToken cancellationToken)
    {

        VisitOrder visitOrder = _imapper.Map<VisitOrder>(request);
        _applicationDbContext.VisitOrders.Add(visitOrder);
        await _applicationDbContext.SaveChangesAsync(cancellationToken);
        return visitOrder.Id;
    }
}
