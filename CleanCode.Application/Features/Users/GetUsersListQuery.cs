using MediatR;
using CleanCode.Domain.Entities;

namespace CleanCode.Application.Features.Users
{
    public class GetUsersListQuery : IRequest<List<UserVm>>
    {

    }
}
