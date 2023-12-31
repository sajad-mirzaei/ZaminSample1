﻿using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Contracts.Blogs.Queries;
using MiniBlog.Core.Contracts.Blogs.Queries.GetBlogById;
using MiniBlog.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;

namespace MiniBlog.Infra.Data.Sql.Queries.Blogs;

public class BlogQueryRepository : BaseQueryRepository<MiniblogQueryDbContext>, IBlogQueryRepository
{
    public BlogQueryRepository(MiniblogQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<BlogQr> Execute(GetBlogByIdQuery query)
        => await _dbContext.Blogs.Select(c => new BlogQr()
        {
            Id = c.Id,
            BusinessId = c.BusinessId,
            Title = c.Title,
            Description = c.Description
        }).FirstOrDefaultAsync(c => c.BusinessId.Equals(query.BlogBusinessId));
}
