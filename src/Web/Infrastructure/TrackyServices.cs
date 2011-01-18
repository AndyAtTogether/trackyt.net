﻿using AutoMapper;
using Ninject.Modules;
using Trackyt.Core.DAL.Repositories;
using Trackyt.Core.DAL.Repositories.Impl;
using Trackyt.Core.Security;
using Trackyt.Core.Services;
using Web.Infrastructure.Helpers;

namespace Web.Infrastructure
{
    [CoverageExcludeAttribute]
    class TrackyServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsersRepository>().To<UsersRepository>();
            Bind<ITasksRepository>().To<TasksRepository>();
            Bind<IFormsAuthentication>().To<TrackyFormsAuthentication>();
            Bind<IPathHelper>().To<PathHelper>();
            Bind<IMappingEngine>().ToConstant(Mapper.Engine);
            Bind<IBlogPostsRepository>().To<BlogPostsRepository>();
            Bind<IAuthenticationService>().To<AuthenticationService>();
            Bind<IHashService>().To<HashService>();
            Bind<IApiService>().To<ApiService>();
            Bind<IDateTimeProviderService>().To<DateTimeProviderService>();
        }
    }
}
