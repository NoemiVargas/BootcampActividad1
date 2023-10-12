using AutoFixture;
using Xunit;
using AutoMapper;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Moq;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes.Profiles;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;

namespace JazaniActividad.UnitTest.Application.Generals.Services
{
    public class InvestmentTypeServiceTest
    {


        Mock<IInvesmenttypeRepository> _mockInvestmenttypeRepository = new Mock<IInvesmenttypeRepository>();
        Mock<Microsoft.Extensions.Logging.ILogger<InvesmenttypeService>> _mockILogger;
        IMapper _mapper;
        Fixture _fixture;


        public InvestmentTypeServiceTest()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(c =>
            {
                c.AddProfile<InvesmenttypeProfile>();
            });
            _mapper = mapperConfiguration.CreateMapper();
            _fixture = new Fixture();
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _mockInvestmenttypeRepository = new Mock<IInvesmenttypeRepository>();
            _mockILogger = new Mock<Microsoft.Extensions.Logging.ILogger<InvesmenttypeService>>();
        }

        [Fact]
        public async void returnInvesmenttypeDtoWhenFindByIdAsync()
        {
            //Arrange
            Invesmenttype invesmenttype = _fixture.Create<Invesmenttype>();

            _mockInvestmenttypeRepository
                .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(invesmenttype);

            //act
            IInvesmenttypeService invesmentService = new InvesmenttypeService(_mockInvestmenttypeRepository.Object, _mapper);

            InvesmenttypeDto invesmenttypeDto = await invesmentService.FindByIdAsync(invesmenttype.Id);

            //Assert
            Assert.Equal(invesmenttype.Name, invesmenttypeDto.Name);
        }


        [Fact]
        public async void returnInvesmentDtoWhenFindAllAsync()
        {
            //Arrays
            IReadOnlyList<Invesmenttype> invesments = _fixture.CreateMany<Invesmenttype>(5)
                .ToList();

            _mockInvestmenttypeRepository
                .Setup(r => r.FindAllAsync())
                .ReturnsAsync(invesments);


            //Act
            IInvesmenttypeService invesmentService = new InvesmenttypeService(_mockInvestmenttypeRepository.Object, _mapper);
            IReadOnlyList<InvesmenttypeDto> invesmentDtos = await invesmentService.FindAllAsync();

            //Assert
            Assert.Equal(invesments.Count, invesmentDtos.Count);
        }


        [Fact]
        public async void returnInvesmenttypeDtoWhenCreateAsync()
        {

            //Arrange
            Invesmenttype invesment = new()
            {
                Id = 1,
                Name= "noemi",
                Description = "description",
                RegistrationDate = DateTime.Now,
                State = true
            };
            _mockInvestmenttypeRepository
                .Setup(r => r.SaveAsync(It.IsAny<Invesmenttype>()))
                .ReturnsAsync(invesment);

            //Act
            InvesmenttypeSaveDto invesmentSaveDto = new()
            {

                //Id = 1,
                Name = "noemi",
                Description = "description",
                //RegistrationDate = DateTime.Now,
               // State = true

            };
            IInvesmenttypeService invesmentService = new InvesmenttypeService(_mockInvestmenttypeRepository.Object, _mapper);
            InvesmenttypeDto invesmentDto = await invesmentService.CreateAsync(invesmentSaveDto);


            //Assert
            Assert.Equal(invesment.Description, invesmentDto.Description);
        }


        [Fact]
        public async void returnInvesmenttypeDtoWhenEditAsync()
        {
            // 
            int id = 1;
            //Arrange
            Invesmenttype invesment = new()
            {
                Id = 1,
                Name = "noemi",
                Description = "description",
                RegistrationDate = DateTime.Now,
                State = true
            };

            _mockInvestmenttypeRepository
             .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
             .ReturnsAsync(invesment);

            _mockInvestmenttypeRepository
                .Setup(r => r.SaveAsync(It.IsAny<Invesmenttype>()))
                .ReturnsAsync(invesment);



            //Act
            InvesmenttypeSaveDto invesmentSaveDto = new()
            {
                Name = "noemi",
                Description = "description",
            };
            IInvesmenttypeService invesmentService = new InvesmenttypeService(_mockInvestmenttypeRepository.Object, _mapper);
            InvesmenttypeDto invesmentDto = await invesmentService.EditAsync(id, invesmentSaveDto);


            //Assert
            Assert.Equal(invesment.Id, invesmentDto.Id);
        }

        [Fact]
        public async void returnInvesmenttypeDtoWhenDisableAsync()
        {
            // 
            int id = 1;
            //Arrange
            Invesmenttype invesment = new()
            {
                Id = 1,
                Name = "noemi",
                Description = "description",
                RegistrationDate = DateTime.Now,
                State = true
            };

            _mockInvestmenttypeRepository
             .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
             .ReturnsAsync(invesment);

            _mockInvestmenttypeRepository
                .Setup(r => r.SaveAsync(It.IsAny<Invesmenttype>()))
                .ReturnsAsync(invesment);

            //Act
            IInvesmenttypeService invesmentService = new InvesmenttypeService(_mockInvestmenttypeRepository.Object, _mapper);
            InvesmenttypeDto invesmentDto = await invesmentService.DisabledAsync(id);


            //Assert
            Assert.Equal(invesment.Id, invesmentDto.Id);
        }


    }
}
