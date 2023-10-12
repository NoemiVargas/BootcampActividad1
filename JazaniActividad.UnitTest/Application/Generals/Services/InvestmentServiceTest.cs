using Moq;
using AutoFixture;
using AutoMapper;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Xunit;
using Castle.Core.Logging;
using JazaniActividad.Application.Generals.Dtos.Invesments;

namespace JazaniActividad.UnitTest.Application.Generals.Services
{
    public class InvestmentServiceTest
    {


        /*
        Task<IReadOnlyList<InvesmentDto>> FindAllAsync();
        Task<InvesmentDto?> FindByIdAsync(int id);
        Task<InvesmentDto> CreateAsync(InvesmentSaveDto saveDto);
        Task<InvesmentDto> EditAsync(int id, InvesmentSaveDto saveDto);
        Task<InvesmentDto> DisabledAsync(int id);
        */
        public InvestmentServiceTest()
        {
        }

        [Fact]
        public async void returnInvesmentDtoWhenFindByIdAsync()
        {
            //Arrange
            Fixture fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            Invesment invesment = fixture.Create<Invesment>();
            
            
            Mock<IInvesmentRepository> mockInvestmentRepository = new Mock<IInvesmentRepository>();
            mockInvestmentRepository
                .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(invesment);

            MapperConfiguration mapperConfiguration = new MapperConfiguration(c =>
            {
                c.AddProfile<Invesment>();
            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            Mock<Microsoft.Extensions.Loggin.ILogger<Invesment>> mockILogger = new Mock<Microsoft.Extensions.Loggin.ILogger<Invesment>>();

            //act
            IInvesmentService invesmentService = InvesmentService(mockInvestmentRepository.Object, mapper, mockILogger.Object);

            InvesmentDto invesmentDto = await invesmentService.FindByIdAsync(invesment.Id); 

            //Assert
            Assert.Equals(invesment.Year, invesment.Description);

        }
    }

}
