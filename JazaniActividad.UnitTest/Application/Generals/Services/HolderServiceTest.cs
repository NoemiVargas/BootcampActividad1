

using AutoFixture;
using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Holders;
using JazaniActividad.Application.Generals.Dtos.Holders.Profiles;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Moq;
using Xunit;

namespace JazaniActividad.UnitTest.Application.Generals.Services
{
    public class HolderServiceTest
    {
        Mock<IHolderRepository> _mockHolderRepository = new Mock<IHolderRepository>();
        Mock<Microsoft.Extensions.Logging.ILogger<HolderService>> _mockILogger;
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
            _mockILogger = new Mock<Microsoft.Extensions.Logging.ILogger<HolderService>>();

        }


        [Fact]
        public async void returnHolderDtoWhenFindByIdAsync()
        {
            //Arrange
            Holder holder = _fixture.Create<Holder>();

            _mockHolderRepository
                .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(holder);

            //act
            IHolderService holderService = new HolderService(_mockHolderRepository.Object, _mapper);

            HolderDto holderDto = await holderService.FindByIdAsync(holder.Id);

            //Assert
            Assert.Equal(holder.Name, holderDto.Name);
        }


        [Fact]
        public async void returnHolderDtoWhenFindAllAsync()
        {
            //Arrays
            IReadOnlyList<Holder> holders = _fixture.CreateMany<Holder>(5)
                .ToList();

            _mockHolderRepository
                .Setup(r => r.FindAllAsync())
                .ReturnsAsync(holders);


            //Act
            IHolderService holderService = new HolderService(_mockHolderRepository.Object, _mapper);
            IReadOnlyList<HolderDto> holderDtos = await holderService.FindAllAsync();

            //Assert
            Assert.Equal(holders.Count, holderDtos.Count);
        }


  


    }
}
