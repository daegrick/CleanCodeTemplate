using AutoMapper;
using CleanCode.Application.Contracts.Persistence;
using CleanCode.Domain.Entities;
using MediatR;

namespace CleanCode.Application.Features.Users
{
    public class GetUsersListQueryHandler(IAsyncRepository<User> repository, IMapper mapper) : IRequestHandler<GetUsersListQuery, List<UserVm>>
    {
        public async Task<List<UserVm>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var allUsers = await repository.ListAllAsync();
            return mapper.Map<List<UserVm>>(allUsers);
        }
    }
}
