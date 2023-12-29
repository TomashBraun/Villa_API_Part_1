using Microsoft.EntityFrameworkCore;
using Villa_API.Models.Villa;
using Villa_API.Models.Villa.DTO;
using Villa_API.Models.VillaNumberModel;

namespace Villa_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; } // это свойство !!!!
        public DbSet<VillaNumber> VillaNumbers { get; set; } 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details =
                        "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:",
                    ImageUrl = "https://blogger.googleusercontent.com/img/a/AVvXsEgWg40kddLWOx6d70K50ruMx4IThciIis-cnuD2vCATJTgdSDx4pgDaqGC1bHK_j_cDnwfxHPqFztcwBZRPn2Qm59JPzlMLaOxDFYGRflLjdBUGCG0vgvU9Amgpdz9FGR_FNSGPoq-2BuP3jnjzGhvraEUpIDe2mzQ6rpBai-MOyXA9_4U-lymxoQpFWbo",
                    Occupancy = 5,
                    Rate = "200",
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Villa 2",
                    Details =
                        "Эксклюзивная резиденция отеля Conrad Maldives Rangali Island действительно не имеет аналогов. Уникальная двухуровневая вилла располагает главной спальней и ванной комнатой, которые погружены под воду на 5 метров. Это самый настоящий ультрасовременный архитектурный шедевр с “эффектом аквариума”.",
                    ImageUrl = "https://blogger.googleusercontent.com/img/a/AVvXsEiIqgEFScWGxzPoWk3ndFOFBBqpQV2Z9W9Lfmh2G-esLTkWN5OeqOb3Zk98YdAxRctNeoqVahg9QbJoDtNbu5RAgDAsiPmS3R1vn76C2HjE289RYdGnLLDz_NUg6sS_YTQzjiGrFU8uGzNUr0jsdFT0hbSeZoBZ6rXo2ik0H85hMhcvdS_GqqFf5ZRLEP0",
                    Occupancy = 2,
                    Rate = "222",
                    Sqft = 220,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Villa 3",
                    Details =
                        "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:",
                    ImageUrl = "https://blogger.googleusercontent.com/img/a/AVvXsEg-t9s_PRAwhCzKgMgjd3YFZvGR2HDY2fhCBjg38QEODZKeM0bwRjsIk5V_4t2XLi3xv_8UoeW70fCT0vaCdhG_R9HdonV7rM5Yo8DxUfH8j6YAQLcRELCut9S0dw7y5UgsEuzUgux3ESXMUHrWRehMBkMJfjfuomRpVLU48p9NkhuG_mwzJkPAGNhsAao",
                    Occupancy = 3,
                    Rate = "333",
                    Sqft = 330,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Villa 4",
                    Details =
                        "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:",
                    ImageUrl = "https://blogger.googleusercontent.com/img/a/AVvXsEjT0Iy17tbcAj28-NXMvfBcXIEBZdEXTxm6pu2BBIP7az6g7t7bhnEUMTj3El3l2SEWcilwOA0XV7nUZgsRTCo64Jrc3Aa6HTF9Bs4LdKzqTR6w869x2cLE1NHu7K5Rv0iJEW4bof0RIHTjeJIL1zBK-rLaO4tqhWEy4jltigNGluMeK8noxqeNEAxJ0Ts",
                    Occupancy = 4,
                    Rate = "444",
                    Sqft = 440,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Villa 5",
                    Details =
                        "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:",
                    ImageUrl = "https://blogger.googleusercontent.com/img/a/AVvXsEgWZ8JURuTTdEGEvwJcKvRehAjLUqIz1gL5Epy9vOwwTv_vN1xqDB-hqebdZt7ZdInbjlaPvJlaasYisD_3xdvCdXqIAXDwohMaBlRRY6tWjIb29ftD_Lbolr7wiJy4rsdPOquwJJOvVT6sytoS6GJS8skSWoaq3IgEzZzckt14vM8jSrtfNVkAfJ_9BvU",
                    Occupancy = 5,
                    Rate = "555",
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
            );
            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber()
                {
                    VillaNo = 1,
                    SpecialDetails = "Это раздел отдельные Номера вилл",
                    VillaId = 1
                });
        }
    }
}
