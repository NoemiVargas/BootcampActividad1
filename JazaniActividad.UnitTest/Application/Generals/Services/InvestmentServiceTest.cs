using AutoFixture;
using Xunit;
using AutoMapper;
using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesments.Profiles;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Moq;


namespace JazaniActividad.UnitTest.Application.Generals.Services
{
    public class InvestmentServiceTest
    {


        Mock<IInvesmentRepository> _mockInvestmentRepository = new Mock<IInvesmentRepository>();
        Mock<Microsoft.Extensions.Logging.ILogger<InvesmentService>> _mockILogger;
        IMapper _mapper;
        Fixture _fixture;


    
        public InvestmentServiceTest()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(c =>
            {
                c.AddProfile<InvesmentProfile>();
            });
            _mapper = mapperConfiguration.CreateMapper();
            _fixture =new Fixture();
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _mockInvestmentRepository = new Mock<IInvesmentRepository>();
            _mockILogger = new Mock<Microsoft.Extensions.Logging.ILogger<InvesmentService>>();
        }

        [Fact]
        public async void returnInvesmentDtoWhenFindByIdAsync()
        {
            //Arrange
            Invesment invesment =  _fixture.Create<Invesment>();
            
            _mockInvestmentRepository
                .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(invesment);

            //act
            IInvesmentService invesmentService = new InvesmentService(_mockInvestmentRepository.Object, _mapper);

            InvesmentDto invesmentDto = await invesmentService.FindByIdAsync(invesment.Id);

            //Assert
            Assert.Equal(invesment.Year, invesmentDto.Year);
        }


        [Fact]
        public async void returnInvesmentDtoWhenFindAllAsync()
        {
            //Arrays
            IReadOnlyList<Invesment> invesments = _fixture.CreateMany<Invesment>(5)
                .ToList();

            _mockInvestmentRepository
                .Setup(r => r.FindAllAsync())
                .ReturnsAsync(invesments);


            //Act
            IInvesmentService invesmentService = new InvesmentService(_mockInvestmentRepository.Object, _mapper);
            IReadOnlyList<InvesmentDto> invesmentDtos = await invesmentService.FindAllAsync();

            //Assert
            Assert.Equal(invesments.Count, invesmentDtos.Count);
        }


        [Fact]
        public async void returnInvesmentDtoWhenCreateAsync()
        {
  
            //Arrange
            Invesment invesment = new()
            {
                Id = 1,
                Amount = 200,
                Year = 2023,
                Description = "description",
                MiningConcessionId = 500,
                Invesmenttypeid = 1,
                CurrencyTypeId = 2,
                PeriodTypeid = 0,
                MeasureUnitId = 0,
                RegistrationDate = DateTime.Now,
                State = false,
                MonthName = "--Seleccione--",
                MonthId = 0,
                AccreditationCode = "2020",
                AccountantCode = "9090",
                HolderId = 4,
                DeclaredTypeId = 0,
                DocumentId = 5050,
                InvesmentConceptId = 2,
                Module = false,
                Frecuency = 1,
                Isdac = 1,
                Metrictons = "",
                DeclarationDate = DateTime.Now
            };
            _mockInvestmentRepository
                .Setup(r => r.SaveAsync(It.IsAny<Invesment>()))
                .ReturnsAsync(invesment);

            //Act
            InvesmentSaveDto invesmentSaveDto = new()
            {
                //Id = 1,
                Amount = 200,
                Year = 2023,
                Description = "description",
                MiningConcessionId = 500,
                Invesmenttypeid = 1,
                CurrencyTypeId = 2,
                PeriodTypeid = 0,
                MeasureUnitId = 0,
                // RegistrationDate = DateTime.Now,
                //State = false,
                MonthName = "--Seleccione--",
                MonthId = 0,
                AccreditationCode = "2020",
                AccountantCode = "9090",
                HolderId = 4,
                DeclaredTypeId = 0,
                DocumentId = 5050,
                InvesmentConceptId = 2,
                Module = false,
                Frecuency = 1,
                Isdac = 1,
                Metrictons = "",
                DeclarationDate = DateTime.Now
            };
            IInvesmentService invesmentService = new InvesmentService(_mockInvestmentRepository.Object, _mapper);
            InvesmentDto invesmentDto = await invesmentService.CreateAsync(invesmentSaveDto);


            //Assert
            Assert.Equal(invesment.Description, invesmentDto.Description);
        }


        [Fact]
        public async void returnInvesmentDtoWhenEditAsync()
        {
            // 
            int id = 1;
            //Arrange
            Invesment invesment = new()
            {
                Id = 1,
                Amount = 200,
                Year = 2023,
                Description = "description",
                MiningConcessionId = 500,
                Invesmenttypeid = 1,
                CurrencyTypeId = 2,
                PeriodTypeid = 0,
                MeasureUnitId = 0,
                RegistrationDate = DateTime.Now,
                State = false,
                MonthName = "--Seleccione--",
                MonthId = 0,
                AccreditationCode = "2020",
                AccountantCode = "9090",
                HolderId = 4,
                DeclaredTypeId = 0,
                DocumentId = 5050,
                InvesmentConceptId = 2,
                Module = false,
                Frecuency = 1,
                Isdac = 1,
                Metrictons = "",
                DeclarationDate = DateTime.Now
            };

            _mockInvestmentRepository
             .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
             .ReturnsAsync(invesment);

            _mockInvestmentRepository
                .Setup(r => r.SaveAsync(It.IsAny<Invesment>()))
                .ReturnsAsync(invesment);

         


            //Act
            InvesmentSaveDto invesmentSaveDto = new()
            {
                //Id = 1,
                Amount = 200,
                Year = 2023,
                Description = "description",
                MiningConcessionId = 500,
                Invesmenttypeid = 1,
                CurrencyTypeId = 2,
                PeriodTypeid = 0,
                MeasureUnitId = 0,
                // RegistrationDate = DateTime.Now,
                //State = false,
                MonthName = "--Seleccione--",
                MonthId = 0,
                AccreditationCode = "2020",
                AccountantCode = "9090",
                HolderId = 4,
                DeclaredTypeId = 0,
                DocumentId = 5050,
                InvesmentConceptId = 2,
                Module = false,
                Frecuency = 1,
                Isdac = 1,
                Metrictons = "",
                DeclarationDate = DateTime.Now
            };
            IInvesmentService invesmentService = new InvesmentService(_mockInvestmentRepository.Object, _mapper);
            InvesmentDto invesmentDto = await invesmentService.EditAsync(id, invesmentSaveDto);


            //Assert
            Assert.Equal(invesment.Id, invesmentDto.Id);
        }

        [Fact]
        public async void returnInvesmentDtoWhenDisableAsync()
        {
    // 
            int id = 1;
            //Arrange
            Invesment invesment = new()
            {
                Id = 1,
                Amount = 200,
                Year = 2023,
                Description = "description",
                MiningConcessionId = 500,
                Invesmenttypeid = 1,
                CurrencyTypeId = 2,
                PeriodTypeid = 0,
                MeasureUnitId = 0,
                RegistrationDate = DateTime.Now,
                State = false,
                MonthName = "--Seleccione--",
                MonthId = 0,
                AccreditationCode = "2020",
                AccountantCode = "9090",
                HolderId = 4,
                DeclaredTypeId = 0,
                DocumentId = 5050,
                InvesmentConceptId = 2,
                Module = false,
                Frecuency = 1,
                Isdac = 1,
                Metrictons = "",
                DeclarationDate = DateTime.Now
            };

            _mockInvestmentRepository
             .Setup(r => r.FindByIdAsync(It.IsAny<int>()))
             .ReturnsAsync(invesment);

            _mockInvestmentRepository
                .Setup(r => r.SaveAsync(It.IsAny<Invesment>()))
                .ReturnsAsync(invesment);

            //Act
            IInvesmentService invesmentService = new InvesmentService(_mockInvestmentRepository.Object, _mapper);
            InvesmentDto invesmentDto = await invesmentService.DisabledAsync(id);


            //Assert
            Assert.Equal(invesment.Id, invesmentDto.Id);
        }
    }

}
