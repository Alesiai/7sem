using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookCore.Models
{
    public class PhoneContext: DbContext, IPhoneDictionary
    {
        public DbSet<Phone> phone { get; set; }

        public PhoneContext(DbContextOptions<PhoneContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }



        public List<Phone> SelectAll()
        {
            var telephones = this.phone;
            return telephones.OrderBy(t => t.Name).ToList();
        }

        public Phone SelectById(int id)
        {
            Phone tel = this.phone.Find(id);
            return tel == null ? null : tel;
        }

        public bool Insert(string name, string phoneNumber)
        {
            if (name != null && phoneNumber != null)
            {
                Phone tel = new Phone();
                tel.PhoneNumber = phoneNumber;
                tel.Name = name;

                this.phone.Add(tel);
                this.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(int? id, string name, string phoneNumber)
        {
            if (id != null && name != null && phoneNumber != null)
            {
                var telephones = this.phone;

                Phone tel = this.phone.Find(id);
                if (tel != null)
                {
                    tel.Name = name;
                    tel.PhoneNumber = phoneNumber;
                    this.Entry(tel).State = EntityState.Modified;
                    this.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            if (id != null)
            {
                Phone tel = this.phone.Find(id);
                if (tel != null)
                {
                    this.phone.Remove(tel);
                    this.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
