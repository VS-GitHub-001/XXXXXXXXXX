﻿using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimblePros.SampleToDo.UseCases.Projects.ListShallow;

public class ListProjectsShallowHandler : IQueryHandler<ListProjectsShallowQuery, Result<IEnumerable<ProjectDTO>>>
{
  private readonly IListProjectsShallowQueryService _query;

  public ListProjectsShallowHandler(IListProjectsShallowQueryService query)
  {
    _query = query;
  }

  public async Task<Result<IEnumerable<ProjectDTO>>> Handle(ListProjectsShallowQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
