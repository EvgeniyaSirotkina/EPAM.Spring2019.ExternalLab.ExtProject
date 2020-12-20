using System.Data.Entity;
using ExtProject.Web.Models;

namespace ExtProject.Web.EF.Initialize
{
    public class ArchiveDbInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext db)
        {
            db.Categories.AddRange(
                new Category[]
                {
                    new Category
                    {
                        Id = 1,
                        CategoryName = "Окончили"
                    },
                    new Category
                    {
                        Id = 2,
                        CategoryName = "Отчислены"
                    },
                    new Category
                    {
                        Id = 3,
                        CategoryName = "На списание"
                    }
                });

            db.Groups.AddRange(
                new Group[]
                {
                    new Group
                    {
                        Id = 1,
                        GroupName = "ТОМ",
                        FullGroupName = "технология машиностроения"
                    }
                });

            db.Students.AddRange(
                new Student[]
                {
                    new Student
                    {
                        Id = 1,
                        CaseNumber = "№02-22/1423-А",
                        Surname = "Алексеев",
                        Name = "Влас",
                        MiddleName = "Константинович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 2,
                        CaseNumber = "№02-22/1424-А",
                        Surname = "Артемьев",
                        Name = "Арсений",
                        MiddleName = "Филиппович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 3,
                        CaseNumber = "№02-22/1546-А",
                        Surname = "Баранов",
                        Name = "Владислав",
                        MiddleName = "Иосифович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 4,
                        CaseNumber = "№02-22/1547-Б",
                        Surname = "Белов",
                        Name = "Мирон",
                        MiddleName = "Давыдович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 5,
                        CaseNumber = "№02-22/1548-Б",
                        Surname = "Белозёров",
                        Name = "Добрыня",
                        MiddleName = "Бедросович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 6,
                        CaseNumber = "№02-22/1549-Б",
                        Surname = "Беляков",
                        Name = "Вячеслав",
                        MiddleName = "Маркович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 7,
                        CaseNumber = "№02-22/1550-Б",
                        Surname = "Беспалов",
                        Name = "Даниил",
                        MiddleName = "Артемьевич",
                        YearOfBirth = 1996,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 8,
                        CaseNumber = "№02-22/1551-Б",
                        Surname = "Блинов",
                        Name = "Альберт",
                        MiddleName = "Никодимович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 9,
                        CaseNumber = "№02-22/1552-Б",
                        Surname = "Блохин",
                        Name = "Трифон",
                        MiddleName = "Еремеевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 10,
                        CaseNumber = "№02-22/1553-Б",
                        Surname = "Бобылёв",
                        Name = "Денис",
                        MiddleName = "Афанасьевич",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 11,
                        CaseNumber = "№02-22/1554-Б",
                        Surname = "Борисов",
                        Name = "Святослав",
                        MiddleName = "Викентьевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 12,
                        CaseNumber = "№02-22/1555-Б",
                        Surname = "Борисов",
                        Name = "Георгий",
                        MiddleName = "Матвеевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2013,
                        GraduationOrDeductionRate = 2,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 13,
                        CaseNumber = "№02-22/1556-Б",
                        Surname = "Брагин",
                        Name = "Николай",
                        MiddleName = "Власович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 14,
                        CaseNumber = "№02-22/1557-Б",
                        Surname = "Быков",
                        Name = "Богдан",
                        MiddleName = "Сергеевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 15,
                        CaseNumber = "№02-22/1026-В",
                        Surname = "Вишняков",
                        Name = "Никанор",
                        MiddleName = "Владимирович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 16,
                        CaseNumber = "№02-22/1027-В",
                        Surname = "Владимиров",
                        Name = "Аркадий",
                        MiddleName = "Филимонович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 17,
                        CaseNumber = "№02-22/1028-В",
                        Surname = "Волков",
                        Name = "Лаврентий",
                        MiddleName = "Гаврилович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 18,
                        CaseNumber = "№02-22/1375-Г",
                        Surname = "Герасимов",
                        Name = "Георгий",
                        MiddleName = "Виленович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 19,
                        CaseNumber = "№02-22/1376-Г",
                        Surname = "Герасимов",
                        Name = "Герман",
                        MiddleName = "Михайлович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 1,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 20,
                        CaseNumber = "№02-22/1377-Г",
                        Surname = "Горшков",
                        Name = "Виталий",
                        MiddleName = "Фёдорович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 21,
                        CaseNumber = "№02-22/1378-Г",
                        Surname = "Гришина",
                        Name = "Галина",
                        MiddleName = "Георгиевна",
                        YearOfBirth = 1994,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 22,
                        CaseNumber = "№02-22/1379-Г",
                        Surname = "Громов",
                        Name = "Герман",
                        MiddleName = "Ермилович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 23,
                        CaseNumber = "№02-22/1380-Г",
                        Surname = "Громов",
                        Name = "Аверкий",
                        MiddleName = "Никандрович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 24,
                        CaseNumber = "№02-22/1381-Г",
                        Surname = "Гурьев",
                        Name = "Артём",
                        MiddleName = "Фокич",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 25,
                        CaseNumber = "№02-22/1152-Д",
                        Surname = "Давыдов",
                        Name = "Агафон",
                        MiddleName = "Никитич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 26,
                        CaseNumber = "№02-22/1153-Д",
                        Surname = "Данилов",
                        Name = "Святослав",
                        MiddleName = "Игнатович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 27,
                        CaseNumber = "№02-22/1154-Д",
                        Surname = "Денисов",
                        Name = "Лука",
                        MiddleName = "Еремеевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 28,
                        CaseNumber = "№02-22/1155-Д",
                        Surname = "Доронин",
                        Name = "Дмитрий",
                        MiddleName = "Батькович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 29,
                        CaseNumber = "№02-22/987-Е",
                        Surname = "Евсеев",
                        Name = "Никита",
                        MiddleName = "Владиславович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 30,
                        CaseNumber = "№02-22/988-Е",
                        Surname = "Емельянов",
                        Name = "Виссарион",
                        MiddleName = "Фадеевич",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 31,
                        CaseNumber = "№02-22/989-Е",
                        Surname = "Ефимов",
                        Name = "Леонтий",
                        MiddleName = "Емельянович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 32,
                        CaseNumber = "№02-22/845-Ж",
                        Surname = "Жданов",
                        Name = "Леонид",
                        MiddleName = "Натанович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 33,
                        CaseNumber = "№02-22/846-Ж",
                        Surname = "Журавлёв",
                        Name = "Сергей",
                        MiddleName = "Измаилович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 34,
                        CaseNumber = "№02-22/901-З",
                        Surname = "Захаров",
                        Name = "Сильвестр",
                        MiddleName = "Вениаминович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 35,
                        CaseNumber = "№02-22/902-З",
                        Surname = "Захаров",
                        Name = "Геннадий",
                        MiddleName = "Маркович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2011,
                        GraduationOrDeductionRate = 1,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 36,
                        CaseNumber = "№02-22/903-З",
                        Surname = "Зиновьева",
                        Name = "Виктория",
                        MiddleName = "Геннадиевна",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 37,
                        CaseNumber = "№02-22/904-З",
                        Surname = "Зуев",
                        Name = "Борис",
                        MiddleName = "Сидорович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 38,
                        CaseNumber = "№02-22/905-З",
                        Surname = "Зуев",
                        Name = "Николай",
                        MiddleName = "Израилевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 39,
                        CaseNumber = "№02-22/1036-И",
                        Surname = "Иванов",
                        Name = "Геннадий",
                        MiddleName = "Абрамович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 40,
                        CaseNumber = "№02-22/1037-И",
                        Surname = "Иванов",
                        Name = "Иулиан",
                        MiddleName = "Владиленович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 41,
                        CaseNumber = "№02-22/2156-К",
                        Surname = "Кабанов",
                        Name = "Иакинф",
                        MiddleName = "Андроникович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 42,
                        CaseNumber = "№02-22/2157-К",
                        Surname = "Казаков",
                        Name = "Аверкий",
                        MiddleName = "Елисеевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 43,
                        CaseNumber = "№02-22/2158-К",
                        Surname = "Калашников",
                        Name = "Зиновий",
                        MiddleName = "Андреевич",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 44,
                        CaseNumber = "№02-22/2159-К",
                        Surname = "Киселёв",
                        Name = "Михаил",
                        MiddleName = "Демидович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 45,
                        CaseNumber = "№02-22/2160-К",
                        Surname = "Колобов",
                        Name = "Тимофей",
                        MiddleName = "Елизарович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 46,
                        CaseNumber = "№02-22/2161-К",
                        Surname = "Комаров",
                        Name = "Мирослав",
                        MiddleName = "Даниилович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 47,
                        CaseNumber = "№02-22/2162-К",
                        Surname = "Кононова",
                        Name = "Глафира",
                        MiddleName = "Григорьевна",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 2,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 48,
                        CaseNumber = "№02-22/2163-К",
                        Surname = "Копылов",
                        Name = "Всеволод",
                        MiddleName = "Феодосьевич",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 49,
                        CaseNumber = "№02-22/2164-К",
                        Surname = "Королёв",
                        Name = "Лев",
                        MiddleName = "Викторович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 50,
                        CaseNumber = "№02-22/2165-К",
                        Surname = "Королёв",
                        Name = "Герасим",
                        MiddleName = "Митрофанович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2013,
                        GraduationOrDeductionRate = 1,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 51,
                        CaseNumber = "№02-22/2166-К",
                        Surname = "Крылов",
                        Name = "Созон",
                        MiddleName = "Израилевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 52,
                        CaseNumber = "№02-22/2167-К",
                        Surname = "Крюков",
                        Name = "Андрей",
                        MiddleName = "Феликсович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 53,
                        CaseNumber = "№02-22/2168-К",
                        Surname = "Кудрявцев",
                        Name = "Владимир",
                        MiddleName = "Ильич",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 54,
                        CaseNumber = "№02-22/2169-К",
                        Surname = "Кузнецов",
                        Name = "Герасим",
                        MiddleName = "Августович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 55,
                        CaseNumber = "№02-22/2170-К",
                        Surname = "Кузнецов",
                        Name = "Ким",
                        MiddleName = "Владимирович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 56,
                        CaseNumber = "№02-22/2171-К",
                        Surname = "Кузьмин",
                        Name = "Виталий",
                        MiddleName = "Игоревич",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 57,
                        CaseNumber = "№02-22/2172-К",
                        Surname = "Кулагин",
                        Name = "Игорь",
                        MiddleName = "Антонович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 58,
                        CaseNumber = "№02-22/2173-К",
                        Surname = "Кулагин",
                        Name = "Герман",
                        MiddleName = "Михайлович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 1,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 59,
                        CaseNumber = "№02-22/2174-К",
                        Surname = "Кулаков",
                        Name = "Антонин",
                        MiddleName = "Феоктистович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 60,
                        CaseNumber = "№02-22/2175-К",
                        Surname = "Кулакова",
                        Name = "Герасим",
                        MiddleName = "Митрофанович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 2,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 61,
                        CaseNumber = "№02-22/2176-К",
                        Surname = "Куликов",
                        Name = "Владлен",
                        MiddleName = "Кириллович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 62,
                        CaseNumber = "№02-22/2177-К",
                        Surname = "Куликов",
                        Name = "Георгий",
                        MiddleName = "Матвеевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 3,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 63,
                        CaseNumber = "№02-22/1789-Л",
                        Surname = "Лаврентьев",
                        Name = "Никифор",
                        MiddleName = "Владленович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 64,
                        CaseNumber = "№02-22/1790-Л",
                        Surname = "Лаврентьев",
                        Name = "Геннадий",
                        MiddleName = "Маркович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2012,
                        GraduationOrDeductionRate = 1,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 65,
                        CaseNumber = "№02-22/1791-Л",
                        Surname = "Лазарев",
                        Name = "Геласий",
                        MiddleName = "Максимович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2012,
                        GraduationOrDeductionRate = 2,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 66,
                        CaseNumber = "№02-22/1792-Л",
                        Surname = "Лапин",
                        Name = "Галактион",
                        MiddleName = "Макарович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 67,
                        CaseNumber = "№02-22/1793-Л",
                        Surname = "Ларионова",
                        Name = "Гавриил",
                        MiddleName = "Львович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 68,
                        CaseNumber = "№02-22/1794-Л",
                        Surname = "Лебедев",
                        Name = "Вячеслав",
                        MiddleName = "Леонидович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 69,
                        CaseNumber = "№02-22/1795-Л",
                        Surname = "Лебедев",
                        Name = "Авксентий",
                        MiddleName = "Адамович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 70,
                        CaseNumber = "№02-22/1796-Л",
                        Surname = "Лебедева",
                        Name = "Всеволод",
                        MiddleName = "Корнеевич",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 71,
                        CaseNumber = "№02-22/1797-Л",
                        Surname = "Лихачёва",
                        Name = "Влас",
                        MiddleName = "Константинович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 72,
                        CaseNumber = "№02-22/1798-Л",
                        Surname = "Лобанов",
                        Name = "Владлен",
                        MiddleName = "Кириллович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 73,
                        CaseNumber = "№02-22/1799-Л",
                        Surname = "Логинов",
                        Name = "Владислав",
                        MiddleName = "Иосифович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 74,
                        CaseNumber = "№02-22/1800-Л",
                        Surname = "Лукин",
                        Name = "Владимир",
                        MiddleName = "Ильич",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 75,
                        CaseNumber = "№02-22/1801-Л",
                        Surname = "Лыткина",
                        Name = "Виталий",
                        MiddleName = "Игоревич",
                        YearOfBirth = 1992,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 76,
                        CaseNumber = "№02-22/1758-М",
                        Surname = "Макаров",
                        Name = "Виссарион",
                        MiddleName = "Иванович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 77,
                        CaseNumber = "№02-22/1759-М",
                        Surname = "Макаров",
                        Name = "Мстислав",
                        MiddleName = "Демьянович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 78,
                        CaseNumber = "№02-22/1760-М",
                        Surname = "Максимов",
                        Name = "Виктор",
                        MiddleName = "Ефимович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 79,
                        CaseNumber = "№02-22/1761-М",
                        Surname = "Мартынов",
                        Name = "Виктор",
                        MiddleName = "Устинович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 80,
                        CaseNumber = "№02-22/1762-М",
                        Surname = "Мельников",
                        Name = "Александр",
                        MiddleName = "Никитович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 81,
                        CaseNumber = "№02-22/1763-М",
                        Surname = "Молчанов",
                        Name = "Аристарх",
                        MiddleName = "Филатович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 82,
                        CaseNumber = "№02-22/1764-М",
                        Surname = "Морозов",
                        Name = "Кузьма",
                        MiddleName = "Вячеславович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 83,
                        CaseNumber = "№02-22/1645-Н",
                        Surname = "Наумов",
                        Name = "Алексей",
                        MiddleName = "Наумович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 84,
                        CaseNumber = "№02-22/1646-Н",
                        Surname = "Некрасов",
                        Name = "Созон",
                        MiddleName = "Михайлович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 85,
                        CaseNumber = "№02-22/1647-Н",
                        Surname = "Николаев",
                        Name = "Сильвестр",
                        MiddleName = "Изотович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 86,
                        CaseNumber = "№02-22/1648-Н",
                        Surname = "Носков",
                        Name = "Иван",
                        MiddleName = "Анисимович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 87,
                        CaseNumber = "№02-22/1365-О",
                        Surname = "Овчинников",
                        Name = "Владислав",
                        MiddleName = "Федосьевич",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 88,
                        CaseNumber = "№02-22/1366-О",
                        Surname = "Орлов",
                        Name = "Митрофан",
                        MiddleName = "Данилович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 89,
                        CaseNumber = "№02-22/1456-П",
                        Surname = "Панов",
                        Name = "Валерий",
                        MiddleName = "Тарасович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 90,
                        CaseNumber = "№02-22/1457-П",
                        Surname = "Панфилов",
                        Name = "Влас",
                        MiddleName = "Феликсович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 91,
                        CaseNumber = "№02-22/1458-П",
                        Surname = "Петров",
                        Name = "Куприян",
                        MiddleName = "Гавриилович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 92,
                        CaseNumber = "№02-22/1459-П",
                        Surname = "Поляков",
                        Name = "Самуил",
                        MiddleName = "Иванович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 93,
                        CaseNumber = "№02-22/1460-П",
                        Surname = "Попов",
                        Name = "Семён",
                        MiddleName = "Аверьянович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 94,
                        CaseNumber = "№02-22/1461-П",
                        Surname = "Попов",
                        Name = "Климент",
                        MiddleName = "Владленович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 95,
                        CaseNumber = "№02-22/1462-П",
                        Surname = "Потапов",
                        Name = "Александр",
                        MiddleName = "Матвеевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 96,
                        CaseNumber = "№02-22/1754-Р",
                        Surname = "Рогов",
                        Name = "Антон",
                        MiddleName = "Феодосьевич",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 97,
                        CaseNumber = "№02-22/1755-Р",
                        Surname = "Романов",
                        Name = "Геласий",
                        MiddleName = "Максимович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 98,
                        CaseNumber = "№02-22/1756-Р",
                        Surname = "Романов",
                        Name = "Севастьян",
                        MiddleName = "Венедиктович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 99,
                        CaseNumber = "№02-22/1757-Р",
                        Surname = "Рыбаков",
                        Name = "Валерьян",
                        MiddleName = "Теймуразович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 100,
                        CaseNumber = "№02-22/1866-С",
                        Surname = "Савельев",
                        Name = "Валентин",
                        MiddleName = "Степанович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 101,
                        CaseNumber = "№02-22/1867-С",
                        Surname = "Селезнёв",
                        Name = "Владлен",
                        MiddleName = "Федотович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 102,
                        CaseNumber = "№02-22/1868-С",
                        Surname = "Сергеев",
                        Name = "Галактион",
                        MiddleName = "Макарович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 103,
                        CaseNumber = "№02-22/1869-С",
                        Surname = "Сергеев",
                        Name = "Геласий",
                        MiddleName = "Вахтангович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 104,
                        CaseNumber = "№02-22/1870-С",
                        Surname = "Смирнов",
                        Name = "Галактион",
                        MiddleName = "Ааронович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 105,
                        CaseNumber = "№02-22/1871-С",
                        Surname = "Смирнов",
                        Name = "Исидор",
                        MiddleName = "Витальевич",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 106,
                        CaseNumber = "№02-22/1872-С",
                        Surname = "Соколов",
                        Name = "Авдей",
                        MiddleName = "Авдеевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 107,
                        CaseNumber = "№02-22/1873-С",
                        Surname = "Соколов",
                        Name = "Кирилл",
                        MiddleName = "Владиславович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 108,
                        CaseNumber = "№02-22/1874-С",
                        Surname = "Соловьёв",
                        Name = "Лев",
                        MiddleName = "Гаджиевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 109,
                        CaseNumber = "№02-22/1875-С",
                        Surname = "Сорокин",
                        Name = "Гавриил",
                        MiddleName = "Львович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 110,
                        CaseNumber = "№02-22/1876-С",
                        Surname = "Сорокин",
                        Name = "Агафон",
                        MiddleName = "Васильевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 111,
                        CaseNumber = "№02-22/1877-С",
                        Surname = "Степанов",
                        Name = "Всеволод",
                        MiddleName = "Корнеевич",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 112,
                        CaseNumber = "№02-22/1878-С",
                        Surname = "Степанов",
                        Name = "Гавриил",
                        MiddleName = "Валерьевич",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 113,
                        CaseNumber = "№02-22/1879-С",
                        Surname = "Субботин",
                        Name = "Тимур",
                        MiddleName = "Елисеевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 114,
                        CaseNumber = "№02-22/1880-С",
                        Surname = "Суворов",
                        Name = "Варлам",
                        MiddleName = "Терентьевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 115,
                        CaseNumber = "№02-22/1545-Т",
                        Surname = "Тарасов",
                        Name = "Мелентий",
                        MiddleName = "Давидович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 116,
                        CaseNumber = "№02-22/1546-Т",
                        Surname = "Терентьев",
                        Name = "Анфим",
                        MiddleName = "Феофанович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 117,
                        CaseNumber = "№02-22/1547-Т",
                        Surname = "Титов",
                        Name = "Виссарион",
                        MiddleName = "Иванович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 118,
                        CaseNumber = "№02-22/1548-Т",
                        Surname = "Третьяков",
                        Name = "Вадим",
                        MiddleName = "Соломонович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 119,
                        CaseNumber = "№02-22/1549-Т",
                        Surname = "Туров",
                        Name = "Ириней",
                        MiddleName = "Виссарионович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 120,
                        CaseNumber = "№02-22/756-У",
                        Surname = "Уваров",
                        Name = "Демид",
                        MiddleName = "Артурович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 121,
                        CaseNumber = "№02-22/798-Ф",
                        Surname = "Филатов",
                        Name = "Анатолий",
                        MiddleName = "Федотович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 122,
                        CaseNumber = "№02-22/799-Ф",
                        Surname = "Фокин",
                        Name = "Тихон",
                        MiddleName = "Емельянович",
                        YearOfBirth = 1998,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2018,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 123,
                        CaseNumber = "№02-22/800-Ф",
                        Surname = "Фокина",
                        Name = "Глафира",
                        MiddleName = "Борисовна",
                        YearOfBirth = 1997,
                        YearOfEntry = 2014,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 3,
                        GroupId = 1,
                        CategoryId = 2,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 124,
                        CaseNumber = "№02-22/801-Ф",
                        Surname = "Фомина",
                        Name = "Галина",
                        MiddleName = "Борисовна",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 125,
                        CaseNumber = "№02-22/802-Ф",
                        Surname = "Фомин",
                        Name = "Всеволод",
                        MiddleName = "Ермолаевич",
                        YearOfBirth = 1993,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 126,
                        CaseNumber = "№02-22/803-Ф",
                        Surname = "Фомин",
                        Name = "Авксентий",
                        MiddleName = "Никанорович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 127,
                        CaseNumber = "№02-22/804-Ф",
                        Surname = "Фомичёва",
                        Name = "Виктория",
                        MiddleName = "Богдановна",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 128,
                        CaseNumber = "№02-22/645-Х",
                        Surname = "Хохлов",
                        Name = "Лукий",
                        MiddleName = "Михалыч",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 129,
                        CaseNumber = "№02-22/601-Ц",
                        Surname = "Цветков",
                        Name = "Святополк",
                        MiddleName = "Иваныч",
                        YearOfBirth = 1994,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 130,
                        CaseNumber = "№02-22/578-Ч",
                        Surname = "Чернов",
                        Name = "Владимир",
                        MiddleName = "Федосеевич",
                        YearOfBirth = 1997,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 131,
                        CaseNumber = "№02-22/765-Ш",
                        Surname = "Шашков",
                        Name = "Демьян",
                        MiddleName = "Архипович",
                        YearOfBirth = 1995,
                        YearOfEntry = 2012,
                        YearOfEndingOrDeduction = 2016,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 132,
                        CaseNumber = "№02-22/766-Ш",
                        Surname = "Шестаков",
                        Name = "Сергей",
                        MiddleName = "Елизарович",
                        YearOfBirth = 1994,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 133,
                        CaseNumber = "№02-22/546-Щ",
                        Surname = "Щербаков",
                        Name = "Алексей",
                        MiddleName = "Никифорович",
                        YearOfBirth = 1996,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 134,
                        CaseNumber = "№02-22/532-Ю",
                        Surname = "Юдин",
                        Name = "Игнатий",
                        MiddleName = "Антипович",
                        YearOfBirth = 1997,
                        YearOfEntry = 2013,
                        YearOfEndingOrDeduction = 2017,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = true
                    },
                    new Student
                    {
                        Id = 135,
                        CaseNumber = "№02-22/856-Я",
                        Surname = "Яковлев",
                        Name = "Вячеслав",
                        MiddleName = "Леонидович",
                        YearOfBirth = 1993,
                        YearOfEntry = 2010,
                        YearOfEndingOrDeduction = 2014,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    },
                    new Student
                    {
                        Id = 136,
                        CaseNumber = "№02-22/857-Я",
                        Surname = "Яковлев",
                        Name = "Лаврентий",
                        MiddleName = "Валерьянович",
                        YearOfBirth = 1992,
                        YearOfEntry = 2011,
                        YearOfEndingOrDeduction = 2015,
                        GraduationOrDeductionRate = 4,
                        GroupId = 1,
                        CategoryId = 1,
                        AvailabilityOfEducationCertificate = false
                    }


                });

            db.SaveChanges();
        }
    }
}