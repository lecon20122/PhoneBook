using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Data
{
    public class ApplicationDbSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context?.Database.EnsureCreated();

                if (!context.Contacts.Any() && !context.Phones.Any())
                {


                    List<Contact> contacts = new()
                        {
                            new Contact
                            {
                                Name = "John Doe",
                                Description = "John Doe is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = true,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }

                            },
                            new Contact
                            {
                                Name = "Jane Doe",
                                Description = "Jane Doe is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = true,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }
                            },
                            new Contact
                            {
                                Name = "John Smith",
                                Description = "John Smith is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = true,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }
                            },
                            new Contact
                            {
                                Name = "Jane Smith",
                                Description = "Jane Smith is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = true,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }
                            },
                            new Contact
                            {
                                Name = "John Doe",
                                Description = "John Doe is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = false,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }
                            },
                            new Contact
                            {
                                Name = "Jane Doe",
                                Description = "Jane Doe is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = false,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }
                            },
                            new Contact
                            {
                                Name = "John Smith",
                                Description = "John Smith is a fictional character",
                                Email = "",
                                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
                                IsFavorite = false,
                                Phones = new List<Phone>
                                {
                                    new Phone
                                    {
                                        Number = "123456789",
                                        Address = "1234 Main St"
                                    },
                                    new Phone
                                    {
                                        Number = "987654321",
                                        Address = "1234 Main St"
                                    }
                                }
                            }
                        };

                        
                    context?.Contacts.AddRange(contacts);

                    // for (var i = 1; i < 7; i++)
                    // {
                    //     context.Phones.Add(new Phone
                    //     {
                    //         Number = $"123456789{i}",
                    //         ContactId = i
                    //     });
                    // }


                    context?.SaveChanges();
                }
            }


        }
        // public void Seed()
        // {
        //     _modelBuilder.Entity<Contact>()
        //         .HasMany<Phone>(c => c.Phones)
        //         .WithOne(p => p.Contact);

        //     _modelBuilder.Entity<Contact>().HasData(
        //         new Contact
        //         {
        //             Id = 1,
        //             Name = "John Doe",
        //             Description = "John Doe is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,

        //         },
        //         new Contact
        //         {
        //             Id = 2,
        //             Name = "Jane Doe",
        //             Description = "Jane Doe is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,
        //         },
        //         new Contact
        //         {
        //             Id = 3,
        //             Name = "John Smith",
        //             Description = "John Smith is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,
        //         },
        //         new Contact
        //         {
        //             Id = 4,
        //             Name = "Jane Smith",
        //             Description = "Jane Smith is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,
        //         },
        //         new Contact
        //         {
        //             Id = 5,
        //             Name = "John Doe",
        //             Description = "John Doe is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,
        //         },
        //         new Contact
        //         {
        //             Id = 6,
        //             Name = "Jane Doe",
        //             Description = "Jane Doe is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,
        //         },
        //         new Contact
        //         {
        //             Id = 7,
        //             Name = "John Smith",
        //             Description = "John Smith is a fictional character",
        //             Email = "",
        //             Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/John_Doe_%28The_Brotherhood_of_Light%29.jpg/220px-John_Doe_%28The_Brotherhood_of_Light%29.jpg",
        //             IsFavorite = true,
        //         }
        //     );

        //     _modelBuilder.Entity<Phone>().HasData(
        //         new Phone
        //         {
        //             Id = 1,
        //             Number = "123456789",
        //             ContactId = 1
        //         },
        //         new Phone
        //         {
        //             Id = 2,
        //             Number = "123456789",
        //             ContactId = 2
        //         },
        //         new Phone
        //         {
        //             Id = 3,
        //             Number = "123456789",
        //             ContactId = 3
        //         },
        //         new Phone
        //         {
        //             Id = 4,
        //             Number = "123456789",
        //             ContactId = 4
        //         },
        //         new Phone
        //         {
        //             Id = 5,
        //             Number = "123456789",
        //             ContactId = 5
        //         },
        //         new Phone
        //         {
        //             Id = 6,
        //             Number = "123456789",
        //             ContactId = 6
        //         },
        //         new Phone
        //         {
        //             Id = 7,
        //             Number = "123456789",
        //             ContactId = 7
        //         }
        //     );
        // }
    }
}