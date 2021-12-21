using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MeetAndGo.Services
{
    public class UserAccountService : CRUDService<Model.UserAccount, Database.UserAccount, UserAccountSearchObject, UserAccountUpsertRequest, UserAccountUpsertRequest>, IUserAccountService
    {
        public UserAccountService(meetGoContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public override IEnumerable<Model.UserAccount> Get(UserAccountSearchObject search = null)
        {
            var entity = _dbContext.Set<Database.UserAccount>().AsQueryable();

            if (search.Username != null)
            {
                entity = entity.Where(x => x.Username.Contains(search.Username));
            }

            if (search.Email != null)
            {
                entity = entity.Where(x => x.Email.Contains(search.Email));
            }

            var entities = entity.ToList();
            return _mapper.Map<IEnumerable<Model.UserAccount>>(entities);
        }
        public Model.UserAccount Register(UserAccountUpsertRequest request)
        {
            var entity = _mapper.Map<Database.UserAccount>(request);
            _dbContext.Add(entity);


            entity.DateCreated = DateTime.Now;
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            //mailService.SendEmailAsync(request.Email, "New Account", "<h1>Hey!, new Login to your account noticed.</h1>" +
            //    "<h2>Your password is : " + "</h2>" + "<strong>" + request.Sifra + "</strong>" +
            //    "<p> New login to your account at " + DateTime.Now + "</p>");


            _dbContext.SaveChanges();
            return _mapper.Map<Model.UserAccount>(entity);
        }

        //public void ForgotPassword(string email)
        //{
        //    var korisnik = _context.Korisniks.FirstOrDefault(x => x.Email == email);

        //    if (korisnik != null)
        //    {
        //        var password = CreateRandomPassword();
        //        korisnik.LozinkaSalt = GenerateSalt();
        //        korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, password);


        //        mailService.SendEmailAsync(korisnik.Email, "New Password", "<h1>Hey!, new Password to your account noticed.</h1>" +
        //            "<h2>Your password is : " + "</h2>" + "<strong>" + password + "</strong>" +
        //            "<p> New Password to your account at " + DateTime.Now + "</p>");
        //        _context.SaveChanges();
        //    }
        //    else
        //        throw new UserException("Invalid email");
        //}

        public async Task<Model.UserAccount> Login(string username, string password)
        {
            var entity = await _dbContext.UserAccount.FirstOrDefaultAsync(x => x.Username == username);
            if (entity == null)
                return null;

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
                return null;

            return _mapper.Map<Model.UserAccount>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        private static string CreateRandomPassword(int length = 7)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
    }
}
