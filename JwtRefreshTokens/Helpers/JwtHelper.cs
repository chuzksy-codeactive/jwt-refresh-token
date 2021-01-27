using JwtRefreshTokens.Entities;
using System;
using System.Security.Cryptography;

namespace JwtRefreshTokens.Helpers
{
    public static class JwtHelper
    {
        public static RefreshToken CreateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var generator = new RNGCryptoServiceProvider();
            generator.GetBytes(randomNumber);

            return new RefreshToken
            {
                Token = Convert.ToBase64String(randomNumber),
                Expires = DateTime.UtcNow.AddDays(10),
                Created = DateTime.UtcNow
            };
        }
    }
}
