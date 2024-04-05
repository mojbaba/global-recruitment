using GlobalRecruitment.Console;
using GlobalRecruitment.Console.Clients;

namespace GlobalRecruitment.Test;

public class MockedCandidateClient : ICandidateClient
{
  private readonly string _candidatesJson = @"[
  {
    ""candidateId"": ""a4a2f368-ee54-49df-aebd-82e9b5698c34"",
    ""fullName"": ""Darrel Balistreri"",
    ""firstName"": ""Darrel"",
    ""lastName"": ""Balistreri"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/402.jpg"",
    ""email"": ""Darrel_Balistreri50@gmail.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Kirk Homenick"",
    ""mom"": ""Marion Kertzmann"",
    ""canSwim"": false,
    ""barcode"": ""9820903792397"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""d0477304-a5de-4eb0-afb4-5091ec884cbd"",
    ""fullName"": ""Eula Kuhlman"",
    ""firstName"": ""Eula"",
    ""lastName"": ""Kuhlman"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/684.jpg"",
    ""email"": ""Eula.Kuhlman58@hotmail.com"",
    ""favoriteMusicGenre"": ""Pop"",
    ""dad"": ""Colin Jones"",
    ""mom"": ""Juanita Blick"",
    ""canSwim"": true,
    ""barcode"": ""5672986939701"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""3b033388-703b-4dbb-98c7-eadc5dd8eeeb"",
    ""fullName"": ""Dianne Kris"",
    ""firstName"": ""Dianne"",
    ""lastName"": ""Kris"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/513.jpg"",
    ""email"": ""Dianne.Kris@yahoo.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Howard Kuhic"",
    ""mom"": ""Regina Fahey"",
    ""canSwim"": true,
    ""barcode"": ""2484890117815"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""50f7d4c0-e4df-4cb6-a6ca-174c775b538f"",
    ""fullName"": ""Ramiro Monahan"",
    ""firstName"": ""Ramiro"",
    ""lastName"": ""Monahan"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/890.jpg"",
    ""email"": ""Ramiro.Monahan@yahoo.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Andre Beier"",
    ""mom"": ""Viola DuBuque"",
    ""canSwim"": false,
    ""barcode"": ""3178021225379"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""718f240f-535b-45c4-b080-9b383f197b83"",
    ""fullName"": ""Lonnie Hermann"",
    ""firstName"": ""Lonnie"",
    ""lastName"": ""Hermann"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/737.jpg"",
    ""email"": ""Lonnie.Hermann14@yahoo.com"",
    ""favoriteMusicGenre"": ""Blues"",
    ""dad"": ""Abel Rogahn"",
    ""mom"": ""Lucille Maggio"",
    ""canSwim"": false,
    ""barcode"": ""0842754838429"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""ab4b095c-996e-481d-98f7-11d316bab1c5"",
    ""fullName"": ""Emmett Lubowitz"",
    ""firstName"": ""Emmett"",
    ""lastName"": ""Lubowitz"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/111.jpg"",
    ""email"": ""Emmett.Lubowitz26@gmail.com"",
    ""favoriteMusicGenre"": ""Rap"",
    ""dad"": ""Jeremiah Beahan"",
    ""mom"": ""Antoinette Leuschke"",
    ""canSwim"": false,
    ""barcode"": ""3317303051385"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""4ca13734-9f50-4cc4-b51b-36a82e56255a"",
    ""fullName"": ""Sophia Volkman"",
    ""firstName"": ""Sophia"",
    ""lastName"": ""Volkman"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/912.jpg"",
    ""email"": ""Sophia.Volkman65@hotmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Reginald Cassin"",
    ""mom"": ""Regina Moen"",
    ""canSwim"": false,
    ""barcode"": ""6847803974244"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 2
      }
    ]
  },
  {
    ""candidateId"": ""c459054d-f4a0-4709-a3ec-4692be9a301e"",
    ""fullName"": ""Rochelle Dickens"",
    ""firstName"": ""Rochelle"",
    ""lastName"": ""Dickens"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1102.jpg"",
    ""email"": ""Rochelle78@hotmail.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Gregory Larson"",
    ""mom"": ""Stella Weissnat"",
    ""canSwim"": false,
    ""barcode"": ""7633797260260"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""ebed8f1b-13d6-4f88-bcaf-e43f03810a9d"",
    ""fullName"": ""Dwight Kulas"",
    ""firstName"": ""Dwight"",
    ""lastName"": ""Kulas"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/497.jpg"",
    ""email"": ""Dwight92@yahoo.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Erick Rosenbaum"",
    ""mom"": ""Sonja Wunsch"",
    ""canSwim"": false,
    ""barcode"": ""2312406510938"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""f4a96189-6320-4f8b-b985-3deb64c16c5f"",
    ""fullName"": ""Megan Christiansen"",
    ""firstName"": ""Megan"",
    ""lastName"": ""Christiansen"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1226.jpg"",
    ""email"": ""Megan.Christiansen54@yahoo.com"",
    ""favoriteMusicGenre"": ""Blues"",
    ""dad"": ""Tim Terry"",
    ""mom"": ""Bonnie King"",
    ""canSwim"": true,
    ""barcode"": ""0039920892457"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 4
      }
    ]
  },
  {
    ""candidateId"": ""149ce42e-b15d-4a82-a3a3-331185f4f1af"",
    ""fullName"": ""Maryann Wisoky"",
    ""firstName"": ""Maryann"",
    ""lastName"": ""Wisoky"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/980.jpg"",
    ""email"": ""Maryann40@gmail.com"",
    ""favoriteMusicGenre"": ""Pop"",
    ""dad"": ""Willard Harris"",
    ""mom"": ""Lucy O'Hara"",
    ""canSwim"": true,
    ""barcode"": ""7367015868999"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""76ef900c-2fff-40a2-97b4-67d8ca814a46"",
    ""fullName"": ""Mike Upton"",
    ""firstName"": ""Mike"",
    ""lastName"": ""Upton"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/607.jpg"",
    ""email"": ""Mike_Upton@yahoo.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Frankie Gutmann"",
    ""mom"": ""Opal Terry"",
    ""canSwim"": true,
    ""barcode"": ""8605674924281"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""4b66fb46-fe44-4285-842d-21aa4d59c6a4"",
    ""fullName"": ""Emma Toy"",
    ""firstName"": ""Emma"",
    ""lastName"": ""Toy"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1110.jpg"",
    ""email"": ""Emma44@gmail.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Roosevelt Marks"",
    ""mom"": ""Antonia Ziemann"",
    ""canSwim"": false,
    ""barcode"": ""0978274617661"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""8a140542-83f4-43d1-a4e9-12476c38e01c"",
    ""fullName"": ""Ebony Lueilwitz"",
    ""firstName"": ""Ebony"",
    ""lastName"": ""Lueilwitz"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/593.jpg"",
    ""email"": ""Ebony.Lueilwitz@hotmail.com"",
    ""favoriteMusicGenre"": ""Latin"",
    ""dad"": ""George Shanahan"",
    ""mom"": ""Pearl Mosciski"",
    ""canSwim"": true,
    ""barcode"": ""4424775201329"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 2
      }
    ]
  },
  {
    ""candidateId"": ""3d6b8c46-99b8-4113-87d4-58c086b4b108"",
    ""fullName"": ""Irving Armstrong"",
    ""firstName"": ""Irving"",
    ""lastName"": ""Armstrong"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/96.jpg"",
    ""email"": ""Irving_Armstrong@gmail.com"",
    ""favoriteMusicGenre"": ""Pop"",
    ""dad"": ""Tyler Stoltenberg"",
    ""mom"": ""Adrienne Casper"",
    ""canSwim"": false,
    ""barcode"": ""2140912458228"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""9fd55997-0c45-4c5e-8f62-dc80cbe72473"",
    ""fullName"": ""Noel Ebert"",
    ""firstName"": ""Noel"",
    ""lastName"": ""Ebert"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/636.jpg"",
    ""email"": ""Noel8@yahoo.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Alejandro Crist"",
    ""mom"": ""Edith Hermiston"",
    ""canSwim"": false,
    ""barcode"": ""1209402086431"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""b1c5a438-f81c-48be-98a2-e4afee12f802"",
    ""fullName"": ""Adrienne Strosin"",
    ""firstName"": ""Adrienne"",
    ""lastName"": ""Strosin"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/27.jpg"",
    ""email"": ""Adrienne_Strosin2@hotmail.com"",
    ""favoriteMusicGenre"": ""Non Music"",
    ""dad"": ""Jackie Dibbert"",
    ""mom"": ""Gretchen Hettinger"",
    ""canSwim"": false,
    ""barcode"": ""1730333738057"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""226c214f-a698-4288-a054-62d8f33be9b3"",
    ""fullName"": ""Lonnie McKenzie"",
    ""firstName"": ""Lonnie"",
    ""lastName"": ""McKenzie"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg"",
    ""email"": ""Lonnie.McKenzie@gmail.com"",
    ""favoriteMusicGenre"": ""Pop"",
    ""dad"": ""Chester Berge"",
    ""mom"": ""Michelle Bauch"",
    ""canSwim"": false,
    ""barcode"": ""6903744240920"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""91062a2e-bcb9-41e7-a9b9-618ab5e0594e"",
    ""fullName"": ""Tracy Schinner"",
    ""firstName"": ""Tracy"",
    ""lastName"": ""Schinner"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/799.jpg"",
    ""email"": ""Tracy.Schinner66@gmail.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Guy Hand"",
    ""mom"": ""Marianne O'Hara"",
    ""canSwim"": true,
    ""barcode"": ""2787974946128"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 2
      }
    ]
  },
  {
    ""candidateId"": ""43fa14ba-6f3b-4313-a869-9d10d1958655"",
    ""fullName"": ""Billy O'Kon"",
    ""firstName"": ""Billy"",
    ""lastName"": ""O'Kon"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1091.jpg"",
    ""email"": ""Billy70@hotmail.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Alberto Fadel"",
    ""mom"": ""Miriam Jacobi"",
    ""canSwim"": true,
    ""barcode"": ""2759639221475"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""a38da546-49e0-4ceb-b317-cd39faa2534b"",
    ""fullName"": ""Lewis Orn"",
    ""firstName"": ""Lewis"",
    ""lastName"": ""Orn"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/206.jpg"",
    ""email"": ""Lewis.Orn@yahoo.com"",
    ""favoriteMusicGenre"": ""Electronic"",
    ""dad"": ""Cornelius Ritchie"",
    ""mom"": ""Roberta Hoeger"",
    ""canSwim"": true,
    ""barcode"": ""3474663890204"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""db015a75-d572-4fbe-85b7-cc7368c70af0"",
    ""fullName"": ""Stacy Tremblay"",
    ""firstName"": ""Stacy"",
    ""lastName"": ""Tremblay"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1024.jpg"",
    ""email"": ""Stacy_Tremblay1@gmail.com"",
    ""favoriteMusicGenre"": ""Non Music"",
    ""dad"": ""Brian Paucek"",
    ""mom"": ""Marianne Kuhn"",
    ""canSwim"": false,
    ""barcode"": ""0200057534057"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""ddf8dd64-3249-48f0-82ff-077cd89a121f"",
    ""fullName"": ""Jessie Koelpin"",
    ""firstName"": ""Jessie"",
    ""lastName"": ""Koelpin"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/633.jpg"",
    ""email"": ""Jessie_Koelpin53@gmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Mark Frami"",
    ""mom"": ""Carole Stroman"",
    ""canSwim"": false,
    ""barcode"": ""0221305868304"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""bdb41e1f-ea57-42af-bb72-23f0f41a38c6"",
    ""fullName"": ""Dana Bartell"",
    ""firstName"": ""Dana"",
    ""lastName"": ""Bartell"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/552.jpg"",
    ""email"": ""Dana28@yahoo.com"",
    ""favoriteMusicGenre"": ""Rap"",
    ""dad"": ""Jimmie Farrell"",
    ""mom"": ""Vicki Koch"",
    ""canSwim"": true,
    ""barcode"": ""9416031732116"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""8d2addf7-c234-41ec-9d6f-cebda700f6e7"",
    ""fullName"": ""Jeanne Emard"",
    ""firstName"": ""Jeanne"",
    ""lastName"": ""Emard"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/394.jpg"",
    ""email"": ""Jeanne0@yahoo.com"",
    ""favoriteMusicGenre"": ""Electronic"",
    ""dad"": ""Gregory Muller"",
    ""mom"": ""May Marquardt"",
    ""canSwim"": false,
    ""barcode"": ""9888712203824"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""ab9d0af1-b5dc-4b73-a38b-ee7867a2d90c"",
    ""fullName"": ""Patrick Tremblay"",
    ""firstName"": ""Patrick"",
    ""lastName"": ""Tremblay"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/435.jpg"",
    ""email"": ""Patrick.Tremblay@yahoo.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Scott Marquardt"",
    ""mom"": ""Stacy Parisian"",
    ""canSwim"": true,
    ""barcode"": ""6315181340307"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""75f2972b-62b7-4607-b2e5-cfa55f92b298"",
    ""fullName"": ""Sylvia Lynch"",
    ""firstName"": ""Sylvia"",
    ""lastName"": ""Lynch"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/966.jpg"",
    ""email"": ""Sylvia.Lynch@gmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Ira Powlowski"",
    ""mom"": ""Janice Prohaska"",
    ""canSwim"": false,
    ""barcode"": ""6608754770909"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""4137e3ed-c4a5-43d2-9100-626d7dc9fea0"",
    ""fullName"": ""Christy Schaden"",
    ""firstName"": ""Christy"",
    ""lastName"": ""Schaden"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1084.jpg"",
    ""email"": ""Christy.Schaden@gmail.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Aubrey Olson"",
    ""mom"": ""Alexis Abshire"",
    ""canSwim"": false,
    ""barcode"": ""3430305348014"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""1d23fc4c-0470-49a1-a69e-b376c7faa650"",
    ""fullName"": ""Marvin Wuckert"",
    ""firstName"": ""Marvin"",
    ""lastName"": ""Wuckert"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/393.jpg"",
    ""email"": ""Marvin_Wuckert26@hotmail.com"",
    ""favoriteMusicGenre"": ""Hip Hop"",
    ""dad"": ""Damon Rempel"",
    ""mom"": ""Pearl Marvin"",
    ""canSwim"": true,
    ""barcode"": ""2708861712671"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""ad6bd313-7c77-40ff-b65b-22bdb64fc1ee"",
    ""fullName"": ""Manuel Larkin"",
    ""firstName"": ""Manuel"",
    ""lastName"": ""Larkin"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/436.jpg"",
    ""email"": ""Manuel.Larkin@gmail.com"",
    ""favoriteMusicGenre"": ""Jazz"",
    ""dad"": ""Phil Turner"",
    ""mom"": ""Jody Wolf"",
    ""canSwim"": true,
    ""barcode"": ""3739335167177"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""b6562117-48a6-45a6-b46d-a990111f128c"",
    ""fullName"": ""Dwight Morar"",
    ""firstName"": ""Dwight"",
    ""lastName"": ""Morar"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/231.jpg"",
    ""email"": ""Dwight_Morar@hotmail.com"",
    ""favoriteMusicGenre"": ""Country"",
    ""dad"": ""Hector Rodriguez"",
    ""mom"": ""Amelia Franecki"",
    ""canSwim"": true,
    ""barcode"": ""3539084500443"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 1
      }
    ]
  },
  {
    ""candidateId"": ""f11e67fa-2d4d-46ba-8bc7-496859e037c3"",
    ""fullName"": ""Stacy Cronin"",
    ""firstName"": ""Stacy"",
    ""lastName"": ""Cronin"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/451.jpg"",
    ""email"": ""Stacy_Cronin@hotmail.com"",
    ""favoriteMusicGenre"": ""Hip Hop"",
    ""dad"": ""Rafael Waters"",
    ""mom"": ""Kayla Mills"",
    ""canSwim"": false,
    ""barcode"": ""9399407236497"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""d2095d49-2e81-41fc-906c-5ae414baa266"",
    ""fullName"": ""Thomas McDermott"",
    ""firstName"": ""Thomas"",
    ""lastName"": ""McDermott"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1031.jpg"",
    ""email"": ""Thomas_McDermott33@yahoo.com"",
    ""favoriteMusicGenre"": ""Jazz"",
    ""dad"": ""Matt Cummings"",
    ""mom"": ""Sylvia Zulauf"",
    ""canSwim"": true,
    ""barcode"": ""0542558577387"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""7c524e13-cf8f-40ed-86b7-ae248c955554"",
    ""fullName"": ""Mack Baumbach"",
    ""firstName"": ""Mack"",
    ""lastName"": ""Baumbach"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1119.jpg"",
    ""email"": ""Mack.Baumbach@gmail.com"",
    ""favoriteMusicGenre"": ""Jazz"",
    ""dad"": ""Jose Cremin"",
    ""mom"": ""Evelyn Wilderman"",
    ""canSwim"": false,
    ""barcode"": ""9343830185846"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""2e0d3e80-6ed9-434f-be6d-0ff635bcbaf2"",
    ""fullName"": ""Nathaniel Will"",
    ""firstName"": ""Nathaniel"",
    ""lastName"": ""Will"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/950.jpg"",
    ""email"": ""Nathaniel_Will@hotmail.com"",
    ""favoriteMusicGenre"": ""Pop"",
    ""dad"": ""Cory Hoppe"",
    ""mom"": ""Bernice Friesen"",
    ""canSwim"": false,
    ""barcode"": ""6330084752132"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""892d8fbc-049f-40eb-a812-05fec2ec4e58"",
    ""fullName"": ""Bryan Batz"",
    ""firstName"": ""Bryan"",
    ""lastName"": ""Batz"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/524.jpg"",
    ""email"": ""Bryan.Batz55@hotmail.com"",
    ""favoriteMusicGenre"": ""Non Music"",
    ""dad"": ""Kevin Langosh"",
    ""mom"": ""Krista Gulgowski"",
    ""canSwim"": true,
    ""barcode"": ""4171843506755"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 4
      }
    ]
  },
  {
    ""candidateId"": ""d9494afa-9090-42e8-9dc8-3e68ba67516b"",
    ""fullName"": ""Andres Runolfsson"",
    ""firstName"": ""Andres"",
    ""lastName"": ""Runolfsson"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/702.jpg"",
    ""email"": ""Andres.Runolfsson34@hotmail.com"",
    ""favoriteMusicGenre"": ""Hip Hop"",
    ""dad"": ""Santiago Larson"",
    ""mom"": ""Antoinette Kemmer"",
    ""canSwim"": true,
    ""barcode"": ""0160972771039"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""a675c07b-af4c-4cf1-91ba-4b95df576a69"",
    ""fullName"": ""Ken Kub"",
    ""firstName"": ""Ken"",
    ""lastName"": ""Kub"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1052.jpg"",
    ""email"": ""Ken76@yahoo.com"",
    ""favoriteMusicGenre"": ""Electronic"",
    ""dad"": ""Seth Stamm"",
    ""mom"": ""Ella Kihn"",
    ""canSwim"": true,
    ""barcode"": ""0505290796430"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""8677a9a9-839f-4816-9d8c-2b3e06941a0f"",
    ""fullName"": ""Guadalupe Donnelly"",
    ""firstName"": ""Guadalupe"",
    ""lastName"": ""Donnelly"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/199.jpg"",
    ""email"": ""Guadalupe_Donnelly@yahoo.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Kurt Kohler"",
    ""mom"": ""Lucille Rau"",
    ""canSwim"": false,
    ""barcode"": ""1867561709044"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 1
      }
    ]
  },
  {
    ""candidateId"": ""5775551a-d94a-4f5e-b1a3-fb95c5e12b01"",
    ""fullName"": ""Renee Ledner"",
    ""firstName"": ""Renee"",
    ""lastName"": ""Ledner"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/862.jpg"",
    ""email"": ""Renee_Ledner38@gmail.com"",
    ""favoriteMusicGenre"": ""Reggae"",
    ""dad"": ""Sean Quigley"",
    ""mom"": ""Ida Maggio"",
    ""canSwim"": false,
    ""barcode"": ""9849115052884"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 2
      }
    ]
  },
  {
    ""candidateId"": ""1808a08b-5abb-479f-bfbf-9eff997bb930"",
    ""fullName"": ""Elias Collier"",
    ""firstName"": ""Elias"",
    ""lastName"": ""Collier"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1176.jpg"",
    ""email"": ""Elias86@hotmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Lloyd Lubowitz"",
    ""mom"": ""Eileen Shanahan"",
    ""canSwim"": false,
    ""barcode"": ""3005015147839"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 1
      }
    ]
  },
  {
    ""candidateId"": ""353c2e40-d3cd-4b6e-90e5-6319e7be72f0"",
    ""fullName"": ""Emmett Stark"",
    ""firstName"": ""Emmett"",
    ""lastName"": ""Stark"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1187.jpg"",
    ""email"": ""Emmett.Stark37@yahoo.com"",
    ""favoriteMusicGenre"": ""Electronic"",
    ""dad"": ""Matt Goodwin"",
    ""mom"": ""Wendy Ernser"",
    ""canSwim"": false,
    ""barcode"": ""6109410713600"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""166c6090-5dc3-4d94-a1a5-9afd24f9d863"",
    ""fullName"": ""Bobby Nolan"",
    ""firstName"": ""Bobby"",
    ""lastName"": ""Nolan"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/482.jpg"",
    ""email"": ""Bobby76@gmail.com"",
    ""favoriteMusicGenre"": ""World"",
    ""dad"": ""Lyle Lindgren"",
    ""mom"": ""Gwendolyn Mitchell"",
    ""canSwim"": false,
    ""barcode"": ""5467369685364"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""6c337472-2ed9-41dd-99fd-73938403979d"",
    ""fullName"": ""Susan Kertzmann"",
    ""firstName"": ""Susan"",
    ""lastName"": ""Kertzmann"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/751.jpg"",
    ""email"": ""Susan.Kertzmann50@gmail.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Mathew Greenfelder"",
    ""mom"": ""Flora Witting"",
    ""canSwim"": true,
    ""barcode"": ""7031052163743"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""ec146478-9af5-49be-a823-5a1f99f775c1"",
    ""fullName"": ""Abel Kirlin"",
    ""firstName"": ""Abel"",
    ""lastName"": ""Kirlin"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/248.jpg"",
    ""email"": ""Abel83@gmail.com"",
    ""favoriteMusicGenre"": ""Reggae"",
    ""dad"": ""Jake Heller"",
    ""mom"": ""Jacqueline Ernser"",
    ""canSwim"": true,
    ""barcode"": ""5644858034319"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""b51f63fe-a13e-4a7f-9409-6168873ef45f"",
    ""fullName"": ""Kevin Gleason"",
    ""firstName"": ""Kevin"",
    ""lastName"": ""Gleason"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1077.jpg"",
    ""email"": ""Kevin.Gleason87@gmail.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Dominick O'Kon"",
    ""mom"": ""Johanna Schaden"",
    ""canSwim"": false,
    ""barcode"": ""8035387650038"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""436ccefc-8124-481a-be8f-b0c67e97b9b4"",
    ""fullName"": ""Joe Kunde"",
    ""firstName"": ""Joe"",
    ""lastName"": ""Kunde"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg"",
    ""email"": ""Joe55@yahoo.com"",
    ""favoriteMusicGenre"": ""Latin"",
    ""dad"": ""Dale Green"",
    ""mom"": ""Nina Predovic"",
    ""canSwim"": true,
    ""barcode"": ""6119452744852"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""17307832-f8e7-461b-8c55-27e28930a2f1"",
    ""fullName"": ""Patricia Rogahn"",
    ""firstName"": ""Patricia"",
    ""lastName"": ""Rogahn"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1088.jpg"",
    ""email"": ""Patricia.Rogahn@gmail.com"",
    ""favoriteMusicGenre"": ""Blues"",
    ""dad"": ""Nicolas Cassin"",
    ""mom"": ""Paulette Schroeder"",
    ""canSwim"": false,
    ""barcode"": ""4049151412665"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""b2cc4b59-40c4-44be-92b9-2a1895574201"",
    ""fullName"": ""Sam Price"",
    ""firstName"": ""Sam"",
    ""lastName"": ""Price"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/577.jpg"",
    ""email"": ""Sam0@hotmail.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Erik Walker"",
    ""mom"": ""Jacqueline Raynor"",
    ""canSwim"": false,
    ""barcode"": ""3314786053479"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""e7251b91-0f8a-4217-bb61-fdbd2cbf56e9"",
    ""fullName"": ""Joyce Swaniawski"",
    ""firstName"": ""Joyce"",
    ""lastName"": ""Swaniawski"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/75.jpg"",
    ""email"": ""Joyce.Swaniawski16@hotmail.com"",
    ""favoriteMusicGenre"": ""Latin"",
    ""dad"": ""Ernesto Daugherty"",
    ""mom"": ""Guadalupe Mertz"",
    ""canSwim"": true,
    ""barcode"": ""9773032662928"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""0f3ffb00-1efb-4af2-9695-412e0fa9b6ee"",
    ""fullName"": ""Ellis Jacobs"",
    ""firstName"": ""Ellis"",
    ""lastName"": ""Jacobs"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/25.jpg"",
    ""email"": ""Ellis16@hotmail.com"",
    ""favoriteMusicGenre"": ""Jazz"",
    ""dad"": ""Victor Kihn"",
    ""mom"": ""Paulette Crona"",
    ""canSwim"": false,
    ""barcode"": ""5664082946165"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""043723bb-7ab9-4e49-9e10-d67675145032"",
    ""fullName"": ""Sophia Hamill"",
    ""firstName"": ""Sophia"",
    ""lastName"": ""Hamill"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/362.jpg"",
    ""email"": ""Sophia13@yahoo.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Edmund Stamm"",
    ""mom"": ""Ginger Boyer"",
    ""canSwim"": true,
    ""barcode"": ""0352722862245"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""71bf8412-f484-4e59-b7dd-0246d63e65ed"",
    ""fullName"": ""Adrienne Hilpert"",
    ""firstName"": ""Adrienne"",
    ""lastName"": ""Hilpert"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/210.jpg"",
    ""email"": ""Adrienne.Hilpert69@hotmail.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Spencer Strosin"",
    ""mom"": ""Patsy Heidenreich"",
    ""canSwim"": false,
    ""barcode"": ""8861343260856"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""87dacf8a-4fec-4909-b6ce-579b7ff90e5e"",
    ""fullName"": ""Willie Flatley"",
    ""firstName"": ""Willie"",
    ""lastName"": ""Flatley"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg"",
    ""email"": ""Willie6@yahoo.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Craig Cartwright"",
    ""mom"": ""Toni Carroll"",
    ""canSwim"": false,
    ""barcode"": ""9691112122448"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""5d6465c8-e7f9-4f51-a564-fa0184db50dc"",
    ""fullName"": ""Chris Willms"",
    ""firstName"": ""Chris"",
    ""lastName"": ""Willms"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg"",
    ""email"": ""Chris.Willms64@yahoo.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Rene Morar"",
    ""mom"": ""Jacqueline Halvorson"",
    ""canSwim"": true,
    ""barcode"": ""7311912530060"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""72130f87-87f5-4105-af67-6e9cc38df49c"",
    ""fullName"": ""Jenna Hudson"",
    ""firstName"": ""Jenna"",
    ""lastName"": ""Hudson"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/195.jpg"",
    ""email"": ""Jenna_Hudson@hotmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Brendan Shanahan"",
    ""mom"": ""Jaime Harris"",
    ""canSwim"": false,
    ""barcode"": ""6048221205891"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""da7dfad5-4982-4066-bfde-bd6cd1a05ec5"",
    ""fullName"": ""Gladys Volkman"",
    ""firstName"": ""Gladys"",
    ""lastName"": ""Volkman"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/869.jpg"",
    ""email"": ""Gladys37@hotmail.com"",
    ""favoriteMusicGenre"": ""Electronic"",
    ""dad"": ""Santos Halvorson"",
    ""mom"": ""Gina Moen"",
    ""canSwim"": true,
    ""barcode"": ""2314064056261"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""3a45e890-8dab-414e-9155-ffb26ebe03b3"",
    ""fullName"": ""Sherry Langworth"",
    ""firstName"": ""Sherry"",
    ""lastName"": ""Langworth"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/947.jpg"",
    ""email"": ""Sherry_Langworth81@hotmail.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Roderick Dicki"",
    ""mom"": ""Kristi Steuber"",
    ""canSwim"": false,
    ""barcode"": ""7247984672561"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""047e64b4-f012-4fd7-b20a-ef293e5b656b"",
    ""fullName"": ""Nancy Bogisich"",
    ""firstName"": ""Nancy"",
    ""lastName"": ""Bogisich"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/33.jpg"",
    ""email"": ""Nancy.Bogisich74@gmail.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Edwin Schimmel"",
    ""mom"": ""Esther Lubowitz"",
    ""canSwim"": true,
    ""barcode"": ""3690790043737"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""dc0184e8-83b7-4daa-bc6f-533c25ca1883"",
    ""fullName"": ""Blanca Ondricka"",
    ""firstName"": ""Blanca"",
    ""lastName"": ""Ondricka"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/95.jpg"",
    ""email"": ""Blanca_Ondricka83@gmail.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Rickey Grimes"",
    ""mom"": ""Katie Metz"",
    ""canSwim"": true,
    ""barcode"": ""6562177663777"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""158f201d-eb72-403d-a14e-6d1e390635c3"",
    ""fullName"": ""Salvatore Veum"",
    ""firstName"": ""Salvatore"",
    ""lastName"": ""Veum"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/400.jpg"",
    ""email"": ""Salvatore.Veum@hotmail.com"",
    ""favoriteMusicGenre"": ""Soul"",
    ""dad"": ""Charles Buckridge"",
    ""mom"": ""Josephine Toy"",
    ""canSwim"": false,
    ""barcode"": ""6166555150035"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""b2d1cf8b-a85c-4e82-92c4-8f7f3b3d204d"",
    ""fullName"": ""Cesar Balistreri"",
    ""firstName"": ""Cesar"",
    ""lastName"": ""Balistreri"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1080.jpg"",
    ""email"": ""Cesar_Balistreri@gmail.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Richard Feest"",
    ""mom"": ""Melody Romaguera"",
    ""canSwim"": false,
    ""barcode"": ""7610138740063"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""af5cc372-bced-4c1a-8d0c-30da7d0f4273"",
    ""fullName"": ""Traci Jenkins"",
    ""firstName"": ""Traci"",
    ""lastName"": ""Jenkins"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/385.jpg"",
    ""email"": ""Traci.Jenkins61@gmail.com"",
    ""favoriteMusicGenre"": ""Non Music"",
    ""dad"": ""Kristopher Lebsack"",
    ""mom"": ""Pearl Strosin"",
    ""canSwim"": false,
    ""barcode"": ""0241229170697"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""5adbcbf6-94b3-48a3-9845-2af66ea0e757"",
    ""fullName"": ""Charlotte Boehm"",
    ""firstName"": ""Charlotte"",
    ""lastName"": ""Boehm"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/782.jpg"",
    ""email"": ""Charlotte_Boehm30@gmail.com"",
    ""favoriteMusicGenre"": ""Country"",
    ""dad"": ""Wm Raynor"",
    ""mom"": ""Teresa Fadel"",
    ""canSwim"": false,
    ""barcode"": ""2625654483894"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 2
      }
    ]
  },
  {
    ""candidateId"": ""3836c56f-7e66-4015-9da2-f34bf32d7ed7"",
    ""fullName"": ""Gretchen Senger"",
    ""firstName"": ""Gretchen"",
    ""lastName"": ""Senger"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/88.jpg"",
    ""email"": ""Gretchen.Senger37@gmail.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Edward Bayer"",
    ""mom"": ""Danielle Wuckert"",
    ""canSwim"": true,
    ""barcode"": ""5214434593440"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""0061f5f8-ca08-4730-841f-e3f4e815f3ab"",
    ""fullName"": ""Alyssa Towne"",
    ""firstName"": ""Alyssa"",
    ""lastName"": ""Towne"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/112.jpg"",
    ""email"": ""Alyssa14@hotmail.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Tyler Rutherford"",
    ""mom"": ""Valerie Kuvalis"",
    ""canSwim"": true,
    ""barcode"": ""3616936095675"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 2
      }
    ]
  },
  {
    ""candidateId"": ""bb08f407-47a9-41bd-ba67-ac512ce3b75d"",
    ""fullName"": ""Kayla Bins"",
    ""firstName"": ""Kayla"",
    ""lastName"": ""Bins"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/465.jpg"",
    ""email"": ""Kayla_Bins@gmail.com"",
    ""favoriteMusicGenre"": ""Country"",
    ""dad"": ""Eduardo Gleason"",
    ""mom"": ""Clara Heidenreich"",
    ""canSwim"": true,
    ""barcode"": ""0680653519922"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""fe1fbb40-0a5e-40f8-a833-a705ff7e547b"",
    ""fullName"": ""Jermaine Metz"",
    ""firstName"": ""Jermaine"",
    ""lastName"": ""Metz"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg"",
    ""email"": ""Jermaine.Metz@yahoo.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Wm Hartmann"",
    ""mom"": ""Kelli Schaden"",
    ""canSwim"": false,
    ""barcode"": ""3413927604157"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""e6f7edc7-699d-4c87-ada5-48bab33a254a"",
    ""fullName"": ""Michelle Abshire"",
    ""firstName"": ""Michelle"",
    ""lastName"": ""Abshire"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/989.jpg"",
    ""email"": ""Michelle50@hotmail.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Merle Rodriguez"",
    ""mom"": ""Brittany Adams"",
    ""canSwim"": false,
    ""barcode"": ""2265105666232"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""ab08e4ed-a3cd-4263-8812-b2fa8449d83c"",
    ""fullName"": ""Cynthia Thiel"",
    ""firstName"": ""Cynthia"",
    ""lastName"": ""Thiel"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1230.jpg"",
    ""email"": ""Cynthia.Thiel60@yahoo.com"",
    ""favoriteMusicGenre"": ""Jazz"",
    ""dad"": ""Bryan Hegmann"",
    ""mom"": ""Patricia Kuhn"",
    ""canSwim"": false,
    ""barcode"": ""1753506863035"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""9f8ea8bc-b0ea-485a-a50a-673719944d43"",
    ""fullName"": ""Katherine Braun"",
    ""firstName"": ""Katherine"",
    ""lastName"": ""Braun"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/71.jpg"",
    ""email"": ""Katherine_Braun86@hotmail.com"",
    ""favoriteMusicGenre"": ""Country"",
    ""dad"": ""Spencer Bechtelar"",
    ""mom"": ""Yolanda Turner"",
    ""canSwim"": true,
    ""barcode"": ""4301591396043"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""121979ae-1fae-4a11-8377-cc79126ecb1c"",
    ""fullName"": ""Simon Boehm"",
    ""firstName"": ""Simon"",
    ""lastName"": ""Boehm"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/301.jpg"",
    ""email"": ""Simon87@yahoo.com"",
    ""favoriteMusicGenre"": ""Non Music"",
    ""dad"": ""Gerard Rodriguez"",
    ""mom"": ""Lillie Cole"",
    ""canSwim"": true,
    ""barcode"": ""5269369273240"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""54f7c277-c870-4047-90be-db7042de36af"",
    ""fullName"": ""Marjorie Howell"",
    ""firstName"": ""Marjorie"",
    ""lastName"": ""Howell"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/90.jpg"",
    ""email"": ""Marjorie_Howell4@yahoo.com"",
    ""favoriteMusicGenre"": ""Classical"",
    ""dad"": ""Hugo Wisoky"",
    ""mom"": ""Lillian Gibson"",
    ""canSwim"": false,
    ""barcode"": ""2300929348756"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""ba3a5139-a53d-48e3-9309-764c335c8a70"",
    ""fullName"": ""Leonard Waelchi"",
    ""firstName"": ""Leonard"",
    ""lastName"": ""Waelchi"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1129.jpg"",
    ""email"": ""Leonard22@hotmail.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Arturo Ankunding"",
    ""mom"": ""Marilyn Will"",
    ""canSwim"": false,
    ""barcode"": ""1378955585392"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""28c8906c-d9f4-49bd-938d-5c3db034bb74"",
    ""fullName"": ""Johanna Kilback"",
    ""firstName"": ""Johanna"",
    ""lastName"": ""Kilback"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1127.jpg"",
    ""email"": ""Johanna19@yahoo.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Adam Ankunding"",
    ""mom"": ""Beverly Dare"",
    ""canSwim"": false,
    ""barcode"": ""2291524793945"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 4
      }
    ]
  },
  {
    ""candidateId"": ""fe37e424-176e-4248-a3f9-e02f8b34f3d9"",
    ""fullName"": ""Philip Langworth"",
    ""firstName"": ""Philip"",
    ""lastName"": ""Langworth"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/881.jpg"",
    ""email"": ""Philip_Langworth@yahoo.com"",
    ""favoriteMusicGenre"": ""World"",
    ""dad"": ""Spencer Lesch"",
    ""mom"": ""Sherri O'Hara"",
    ""canSwim"": false,
    ""barcode"": ""2561377005541"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""146aa715-7cdc-41b7-9b0e-9ea514cc82e3"",
    ""fullName"": ""Hector Witting"",
    ""firstName"": ""Hector"",
    ""lastName"": ""Witting"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/454.jpg"",
    ""email"": ""Hector39@gmail.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Julio Kulas"",
    ""mom"": ""Lana Thiel"",
    ""canSwim"": true,
    ""barcode"": ""7181970469233"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 10
      }
    ]
  },
  {
    ""candidateId"": ""e49c1d80-b9c8-4374-bde4-5cae4e20070c"",
    ""fullName"": ""Luis Gutmann"",
    ""firstName"": ""Luis"",
    ""lastName"": ""Gutmann"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1210.jpg"",
    ""email"": ""Luis46@hotmail.com"",
    ""favoriteMusicGenre"": ""Jazz"",
    ""dad"": ""Kenneth Jacobs"",
    ""mom"": ""Leona Kris"",
    ""canSwim"": true,
    ""barcode"": ""7482578352126"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""08b52539-c8cf-481c-85ed-90974f45309e"",
    ""fullName"": ""Billy Kulas"",
    ""firstName"": ""Billy"",
    ""lastName"": ""Kulas"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/520.jpg"",
    ""email"": ""Billy_Kulas52@gmail.com"",
    ""favoriteMusicGenre"": ""Hip Hop"",
    ""dad"": ""Loren Harris"",
    ""mom"": ""Rhonda Gorczany"",
    ""canSwim"": false,
    ""barcode"": ""8387200727565"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""b499bcae-9efa-4aab-86e5-8e09dd01501b"",
    ""fullName"": ""Laverne Schmitt"",
    ""firstName"": ""Laverne"",
    ""lastName"": ""Schmitt"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/629.jpg"",
    ""email"": ""Laverne73@hotmail.com"",
    ""favoriteMusicGenre"": ""Rap"",
    ""dad"": ""Homer Gaylord"",
    ""mom"": ""Marcia Lubowitz"",
    ""canSwim"": false,
    ""barcode"": ""2843336387852"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""c1c2b87e-ad5b-4866-b16b-d73c81627f5e"",
    ""fullName"": ""Milton Becker"",
    ""firstName"": ""Milton"",
    ""lastName"": ""Becker"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/273.jpg"",
    ""email"": ""Milton.Becker76@yahoo.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Lester Herzog"",
    ""mom"": ""Sherry West"",
    ""canSwim"": false,
    ""barcode"": ""8056621029984"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 3
      }
    ]
  },
  {
    ""candidateId"": ""9971d399-2c10-4ee4-8d3a-24ecfe73f82f"",
    ""fullName"": ""Edgar Crist"",
    ""firstName"": ""Edgar"",
    ""lastName"": ""Crist"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/975.jpg"",
    ""email"": ""Edgar_Crist@yahoo.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Clarence Keeling"",
    ""mom"": ""Lillie Tillman"",
    ""canSwim"": false,
    ""barcode"": ""9977021920260"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""fcc755a1-48a1-43d9-ad66-424559e0e067"",
    ""fullName"": ""Ernesto Kassulke"",
    ""firstName"": ""Ernesto"",
    ""lastName"": ""Kassulke"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1029.jpg"",
    ""email"": ""Ernesto_Kassulke1@gmail.com"",
    ""favoriteMusicGenre"": ""Reggae"",
    ""dad"": ""Jamie Hyatt"",
    ""mom"": ""Catherine Rodriguez"",
    ""canSwim"": true,
    ""barcode"": ""9448512238169"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""b7fd34e4-cddf-4e7b-b80c-c98f243d9410"",
    ""fullName"": ""Alex Walker"",
    ""firstName"": ""Alex"",
    ""lastName"": ""Walker"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1124.jpg"",
    ""email"": ""Alex_Walker@gmail.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Alan Koss"",
    ""mom"": ""Tabitha Littel"",
    ""canSwim"": true,
    ""barcode"": ""8252983135640"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""904d2d7d-c56e-470c-8fc7-250ba1762fee"",
    ""fullName"": ""Doris Lehner"",
    ""firstName"": ""Doris"",
    ""lastName"": ""Lehner"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1162.jpg"",
    ""email"": ""Doris.Lehner@gmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Tommie DuBuque"",
    ""mom"": ""Audrey Hane"",
    ""canSwim"": false,
    ""barcode"": ""8085654497248"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""4755afdc-9f8a-487a-85a5-bf979003f230"",
    ""fullName"": ""Roy Walsh"",
    ""firstName"": ""Roy"",
    ""lastName"": ""Walsh"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1080.jpg"",
    ""email"": ""Roy5@gmail.com"",
    ""favoriteMusicGenre"": ""World"",
    ""dad"": ""Richard Hamill"",
    ""mom"": ""Lula Emmerich"",
    ""canSwim"": false,
    ""barcode"": ""2722954654006"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 1
      }
    ]
  },
  {
    ""candidateId"": ""1e62ad14-09e4-40e1-8ea8-a1bdbb646e66"",
    ""fullName"": ""Natasha Walker"",
    ""firstName"": ""Natasha"",
    ""lastName"": ""Walker"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1030.jpg"",
    ""email"": ""Natasha_Walker95@gmail.com"",
    ""favoriteMusicGenre"": ""Stage And Screen"",
    ""dad"": ""Sam Krajcik"",
    ""mom"": ""Eleanor Ullrich"",
    ""canSwim"": true,
    ""barcode"": ""9541286608685"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 8
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""d8f21b83-d30e-4b21-9f53-089888e8a330"",
    ""fullName"": ""Alex Vandervort"",
    ""firstName"": ""Alex"",
    ""lastName"": ""Vandervort"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/0.jpg"",
    ""email"": ""Alex62@yahoo.com"",
    ""favoriteMusicGenre"": ""Latin"",
    ""dad"": ""Stephen Mayer"",
    ""mom"": ""Loretta Morissette"",
    ""canSwim"": false,
    ""barcode"": ""7873693950142"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 10
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 5
      }
    ]
  },
  {
    ""candidateId"": ""4a960df7-345b-4e8e-a948-1b747f718029"",
    ""fullName"": ""Dawn McKenzie"",
    ""firstName"": ""Dawn"",
    ""lastName"": ""McKenzie"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/167.jpg"",
    ""email"": ""Dawn.McKenzie@hotmail.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Jackie Gulgowski"",
    ""mom"": ""Maggie Gislason"",
    ""canSwim"": false,
    ""barcode"": ""6994245772751"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""dbc808e9-1757-45f9-9bb4-7b6b03c98f23"",
    ""fullName"": ""Carolyn Barton"",
    ""firstName"": ""Carolyn"",
    ""lastName"": ""Barton"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/546.jpg"",
    ""email"": ""Carolyn.Barton@gmail.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Lloyd Wiegand"",
    ""mom"": ""Janis Jerde"",
    ""canSwim"": false,
    ""barcode"": ""7519620185972"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 9
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 7
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""63223cf5-1ab7-4b07-aedd-a049fda6e903"",
    ""fullName"": ""Jennie Gibson"",
    ""firstName"": ""Jennie"",
    ""lastName"": ""Gibson"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/657.jpg"",
    ""email"": ""Jennie75@yahoo.com"",
    ""favoriteMusicGenre"": ""Pop"",
    ""dad"": ""Allen Sanford"",
    ""mom"": ""Vivian Zieme"",
    ""canSwim"": false,
    ""barcode"": ""4244325775076"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 6
      }
    ]
  },
  {
    ""candidateId"": ""b4e7f105-0cff-467a-bb3f-8b5a5c9f839d"",
    ""fullName"": ""Lula Moen"",
    ""firstName"": ""Lula"",
    ""lastName"": ""Moen"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/111.jpg"",
    ""email"": ""Lula84@gmail.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Tom Wilkinson"",
    ""mom"": ""Cheryl Torphy"",
    ""canSwim"": true,
    ""barcode"": ""5799450823707"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 9
      }
    ]
  },
  {
    ""candidateId"": ""2d628538-8955-42a7-b98b-fccf4576e61a"",
    ""fullName"": ""Armando Dach"",
    ""firstName"": ""Armando"",
    ""lastName"": ""Dach"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1012.jpg"",
    ""email"": ""Armando63@yahoo.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Mario Schmitt"",
    ""mom"": ""Emma Hettinger"",
    ""canSwim"": true,
    ""barcode"": ""9274276663806"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""f6f6f4b2-5e10-46ca-9b59-499c0704053c"",
    ""fullName"": ""Winifred Friesen"",
    ""firstName"": ""Winifred"",
    ""lastName"": ""Friesen"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1170.jpg"",
    ""email"": ""Winifred.Friesen@yahoo.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Jeffrey Hilll"",
    ""mom"": ""Pat Boyer"",
    ""canSwim"": true,
    ""barcode"": ""8994260906450"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 4
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 1
      }
    ]
  },
  {
    ""candidateId"": ""1331bc65-5144-44d9-8710-41afd7cecde4"",
    ""fullName"": ""Don Bruen"",
    ""firstName"": ""Don"",
    ""lastName"": ""Bruen"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/435.jpg"",
    ""email"": ""Don_Bruen1@gmail.com"",
    ""favoriteMusicGenre"": ""Rock"",
    ""dad"": ""Chester Fahey"",
    ""mom"": ""Vivian Daniel"",
    ""canSwim"": false,
    ""barcode"": ""6337586638377"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 4
      }
    ]
  },
  {
    ""candidateId"": ""e2d91604-1ec3-49f8-8b27-534644941709"",
    ""fullName"": ""Rose Johns"",
    ""firstName"": ""Rose"",
    ""lastName"": ""Johns"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/644.jpg"",
    ""email"": ""Rose.Johns95@hotmail.com"",
    ""favoriteMusicGenre"": ""Non Music"",
    ""dad"": ""Kenneth Greenfelder"",
    ""mom"": ""Velma Welch"",
    ""canSwim"": true,
    ""barcode"": ""1538899633799"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 7
      }
    ]
  },
  {
    ""candidateId"": ""c2ffa095-fae4-4b1a-8f49-563d58977ba3"",
    ""fullName"": ""Carole Bauch"",
    ""firstName"": ""Carole"",
    ""lastName"": ""Bauch"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/426.jpg"",
    ""email"": ""Carole.Bauch1@gmail.com"",
    ""favoriteMusicGenre"": ""Funk"",
    ""dad"": ""Donnie Hane"",
    ""mom"": ""Esther Spinka"",
    ""canSwim"": false,
    ""barcode"": ""5062119253178"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""dbb9f44d-27c7-47db-82c4-25f4c3861d45"",
    ""fullName"": ""Rose Hessel"",
    ""firstName"": ""Rose"",
    ""lastName"": ""Hessel"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/849.jpg"",
    ""email"": ""Rose48@hotmail.com"",
    ""favoriteMusicGenre"": ""Folk"",
    ""dad"": ""Spencer Batz"",
    ""mom"": ""Henrietta Stokes"",
    ""canSwim"": false,
    ""barcode"": ""3610061867411"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 1
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 2
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12"",
        ""yearsOfExperience"": 8
      }
    ]
  },
  {
    ""candidateId"": ""91bf9a2e-0fea-4340-a9f4-a14c20531f32"",
    ""fullName"": ""Hazel Stracke"",
    ""firstName"": ""Hazel"",
    ""lastName"": ""Stracke"",
    ""gender"": 1,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/166.jpg"",
    ""email"": ""Hazel.Stracke69@yahoo.com"",
    ""favoriteMusicGenre"": ""Metal"",
    ""dad"": ""Gordon Hickle"",
    ""mom"": ""Traci Ratke"",
    ""canSwim"": true,
    ""barcode"": ""1982174689399"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11"",
        ""yearsOfExperience"": 6
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15"",
        ""yearsOfExperience"": 4
      }
    ]
  },
  {
    ""candidateId"": ""2d54c90e-5ea5-4cf3-bc24-3b9a8f52eb78"",
    ""fullName"": ""Casey Mayert"",
    ""firstName"": ""Casey"",
    ""lastName"": ""Mayert"",
    ""gender"": 0,
    ""profilePicture"": ""https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/580.jpg"",
    ""email"": ""Casey.Mayert@yahoo.com"",
    ""favoriteMusicGenre"": ""Hip Hop"",
    ""dad"": ""Walter Wilderman"",
    ""mom"": ""Alexis Armstrong"",
    ""canSwim"": true,
    ""barcode"": ""0056140728496"",
    ""experience"": [
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13"",
        ""yearsOfExperience"": 5
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14"",
        ""yearsOfExperience"": 3
      },
      {
        ""technologyId"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04"",
        ""yearsOfExperience"": 10
      }
    ]
  }
]";
  
  
    public Task<IEnumerable<Candidate>> GetCandidatesAsync()
    {
      var candidates = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Candidate>>(_candidatesJson);
        return Task.FromResult(candidates);
    }
}