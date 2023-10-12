

using AutoFixture;
using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Holders.Profiles;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes.Profiles;
using JazaniActividad.Application.Generals.Services.Implementations;
using JazaniActividad.Domain.Generals.Repositories;
using Moq;

namespace JazaniActividad.UnitTest.Application.Generals.Services
{
    public class HolderServiceTest
    {


        Mock<IHolderRepository> _mockHolderRepository = new Mock<IHolderRepository>();
        Mock<Microsoft.Extensions.Logging.ILogger<InvesmenttypeService>> _mockILogger;
        IMapper _mapper;
        Fixture _fixture;


        public HolderServiceTest()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(c =>
            {
                c.AddProfile<HolderProfile>();
            });
            _mapper = mapperConfiguration.CreateMapper();
            _fixture = new Fixture();
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _mockHolderRepository = new Mock<IHolderRepository>();
            //_mockILogger = new Mock<Microsoft.Extensions.Logging.ILogger<HolderService>>();

        }
    }
}
