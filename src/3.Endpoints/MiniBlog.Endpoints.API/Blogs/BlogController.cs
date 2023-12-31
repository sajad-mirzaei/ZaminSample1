﻿using Microsoft.AspNetCore.Mvc;
using MiniBlog.Core.Contracts.Blogs.Commands.CreateBlog;
using MiniBlog.Core.Contracts.Blogs.Queries.GetBlogById;
using Zamin.EndPoints.Web.Controllers;

namespace MiniBlog.Endpoints.API.Blogs
{
    [Route("api/[controller]")]
    public class BlogController : BaseController
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand createBlog)
            => await Create<CreateBlogCommand, Guid>(createBlog);

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBlogById(GetBlogByIdQuery query)
            => await Query<GetBlogByIdQuery, BlogQr>(query);

        [HttpGet("/Clear")]
        public bool Clear()
        {
            GC.Collect(2);
            return true;
        }
    }
}
