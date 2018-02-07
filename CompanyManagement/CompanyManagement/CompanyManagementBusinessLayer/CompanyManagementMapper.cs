using AutoMapper;

namespace CompanyManagementBusinessLayer
{
    public class CompanyManagementMapper
    {
        public static IMapper mapper = null;

        private CompanyManagementMapper()
        {
        }

        private static void CreateMapper()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BusinessLayerEntities.BOProject, CompanyEntities.Project>();
                cfg.CreateMap<BusinessLayerEntities.BOTask, CompanyEntities.Task>();
            }
            );

            mapper = config.CreateMapper();
        }


        public static IMapper GetMapper()
        {
            if (mapper == null)
            {
                CreateMapper();
            }
            return mapper;
        }
    }
}
