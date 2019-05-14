using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace TextCoding
{
    static class Sha1
    {
        static byte[] pad(byte[] mes)
        {
            byte[] newMes = new byte[((mes.LongLength * 8 + 512 - 447) / 512 + 1) * 512 / 8];
            for (long i = 0; i < mes.LongLength; i++)
            {
                newMes[i] = mes[i];
            }
            newMes[mes.LongLength] = (1 << 7);
            ulong l = (ulong)mes.LongLength * 8;
            for (int i = 0; i < 8; i++)
            {
                newMes[newMes.LongLength - i - 1] = (byte)(l >> (i * 8));
            }
            return newMes;
        }

        static uint ch(uint x, uint y, uint z)
        {
            return (x & y) ^ ((~x) & z);
        }

        static uint parity(uint x, uint y, uint z)
        {
            return x ^ y ^ z;
        }

        static uint maj(uint x, uint y, uint z)
        {
            return (x & y) ^ (x & z) ^ (y & z);
        }

        static uint ft(uint x, uint y, uint z, int t)
        {
            if (t <= 19)
                return ch(x, y, z);
            if (t <= 39)
                return parity(x, y, z);
            if (t <= 59)
                return maj(x, y, z);
            return parity(x, y, z);
        }

        static uint rotl(uint a, int n)
        {
            return (a << n) | (a >> (32 - n));
        }

        static uint kt(int t)
        {
            if (t <= 19)
                return 0x5a827999;
            if (t <= 39)
                return 0x6ed9eba1;
            if (t <= 59)
                return 0x8f1bbcdc;
            return 0xca62c1d6;
        }

        static uint wt(byte[] mes, int i, int t)
        {
            if (t <= 15)
                return mes.Skip(i * 512 / 8 + t * 4).Take(4).Aggregate((uint)0, (cur, next) =>
                    (cur << 8) | next);
            return rotl(wt(mes, i, t - 3) ^ wt(mes, i, t - 8) ^ wt(mes, i, t - 14) ^
                wt(mes, i, t - 16), 1);
        }

        public static byte[] Hash(byte[] mes)
        {
            mes = pad(mes);
            uint a = 0x67452301;
            uint b = 0xefcdab89;
            uint c = 0x98badcfe;
            uint d = 0x10325476;
            uint e = 0xc3d2e1f0;

            for (int i = 0; i < mes.LongLength / 64; i++)
            {
                uint a1 = a;
                uint b1 = b;
                uint c1 = c;
                uint d1 = d;
                uint e1 = e;

                for (int t = 0; t <= 79; t++)
                {
                    uint T = rotl(a, 5) + ft(b, c, d, t) + e + kt(t) + wt(mes, i, t);
                    e = d;
                    d = c;
                    c = rotl(b, 30);
                    b = a;
                    a = T;
                }
                a += a1;
                b += b1;
                c += c1;
                d += d1;
                e += e1;
            }

            uint[] temp = new uint[] { a, b, c, d, e };
            byte[] hash = new byte[temp.Length * sizeof(uint)];
            Buffer.BlockCopy(temp, 0, hash, 0, hash.Length);
            for (int i = 0, j = 0; i < temp.Length; i++, j += sizeof(uint))
            {
                Array.Reverse(hash, j, sizeof(uint));
            }
            return hash;
        }
    }
}