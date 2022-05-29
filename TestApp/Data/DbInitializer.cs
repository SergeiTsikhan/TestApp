using TestApp.Models;


namespace TestApp.Data
{
    public static class DbInitializer
    {

        public static void Initialize(BooksContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any())
            {
                return;
            }
            var Authors = new Author[] {
                new Author{
                    Name = "Shea Hamilton",
                    Age = 38
                },
                new Author{
                    Name = "Damian Duke",
                    Age = 30
                },
                new Author{
                    Name = "Fredericka Carlson",
                    Age = 34
                },
                new Author{
                    Name = "Shana Watson",
                    Age = 43
                },
                new Author{
                    Name = "Jocelyn Dejesus",
                    Age = 49
                },
                new Author{
                    Name = "Angela Barber",
                    Age = 49
                },
                new Author{
                    Name = "Jin Lindsey",
                    Age = 38
                },
                new Author{
                    Name = "Forrest Cantu",
                    Age = 54
                },
                new Author{
                    Name = "Margaret Joyce",
                    Age = 32
                },
                new Author{
                    Name = "Sopoline Byrd",
                    Age = 50
                },
                new Author{
                    Name = "Nash Christian",
                    Age = 52
                },
                new Author{
                    Name = "Demetria Mathews",
                    Age = 54
                },
                new Author{
                    Name = "Todd Cleveland",
                    Age = 54
                },
                new Author{
                    Name = "Clio Joyce",
                    Age = 41
                },
                new Author{
                    Name = "Nicole Wynn",
                    Age = 33
                },
                new Author{
                    Name = "Debra Harris",
                    Age = 52
                },
                new Author{
                    Name = "Destiny Jacobson",
                    Age = 48
                },
                new Author{
                    Name = "Leroy Montgomery",
                    Age = 34
                },
                new Author{
                    Name = "Timon Pickett",
                    Age = 37
                },
                new Author{
                    Name = "Forrest Nicholson",
                    Age = 49
                },
                new Author{
                    Name = "Grady Raymond",
                    Age = 28
                },
                new Author{
                    Name = "Hammett Christensen",
                    Age = 49
                },
                new Author{
                    Name = "Lee Wolfe",
                    Age = 48
                },
                new Author{
                    Name = "Aidan Walters",
                    Age = 35
                },
                new Author{
                    Name = "Jack Fisher",
                    Age = 35
                },
                new Author{
                    Name = "Abbot Garcia",
                    Age = 32
                },
                new Author{
                    Name = "Rhona Kane",
                    Age = 30
                },
                new Author{
                    Name = "Eliana Rosa",
                    Age = 53
                },
                new Author{
                    Name = "Avye Moreno",
                    Age = 33
                },
                new Author{
                    Name = "Keane Camacho",
                    Age = 53
                },
                new Author{
                    Name = "Ray Goff",
                    Age = 28
                },
                new Author{
                    Name = "Warren Guthrie",
                    Age = 45
                }
            };
            foreach (var s in Authors)
            {
                context.Authors.Add(s);
            }
            context.SaveChanges();

            var Books = new Book[] {
                new Book{
                    Title = "Integer sem elit, pharetra ut, pharetra sed,",
                    AuthorId = 2
                },
                new Book{
                    Title = "fringilla. Donec feugiat metus sit",
                    AuthorId = 3
                },
                new Book{
                    Title = "luctus, ipsum leo elementum sem, vitae",
                    AuthorId = 3
                },
                new Book{
                    Title = "non leo. Vivamus nibh",
                    AuthorId = 5
                },
                new Book{
                    Title = "laoreet ipsum. Curabitur consequat, lectus sit amet",
                    AuthorId = 5
                },
                new Book{
                    Title = "nonummy ut, molestie in, tempus eu,",
                    AuthorId = 2
                },
                new Book{
                    Title = "mattis. Integer eu lacus. Quisque",
                    AuthorId = 5
                },
                new Book{
                    Title = "vitae purus gravida sagittis. Duis gravida. Praesent",
                    AuthorId = 9
                },
                new Book{
                    Title = "dignissim tempor arcu. Vestibulum ut eros non enim",
                    AuthorId = 3
                },
                new Book{
                    Title = "ante. Nunc",
                    AuthorId = 4
                },
                new Book{
                    Title = "malesuada malesuada. Integer id magna et ipsum cursus",
                    AuthorId = 6
                },
                new Book{
                    Title = "molestie tortor nibh sit",
                    AuthorId = 6
                },
                new Book{
                    Title = "sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer",
                    AuthorId = 2
                },
                new Book{
                    Title = "Cras convallis convallis",
                    AuthorId = 9
                },
                new Book{
                    Title = "neque sed dictum eleifend, nunc",
                    AuthorId = 10
                },
                new Book{
                    Title = "Integer sem elit, pharetra ut, pharetra sed, hendrerit",
                    AuthorId = 2
                },
                new Book{
                    Title = "vitae nibh. Donec est mauris, rhoncus id, mollis nec,",
                    AuthorId = 7
                },
                new Book{
                    Title = "Donec",
                    AuthorId = 4
                },
                new Book{
                    Title = "tincidunt nibh. Phasellus",
                    AuthorId = 7
                },
                new Book{
                    Title = "elementum,",
                    AuthorId = 8
                },
                new Book{
                    Title = "nunc nulla vulputate dui, nec tempus mauris erat",
                    AuthorId = 1
                },
                new Book{
                    Title = "eget nisi",
                    AuthorId = 9
                },
                new Book{
                    Title = "mattis velit justo",
                    AuthorId = 1
                },
                new Book{
                    Title = "bibendum sed, est.",
                    AuthorId = 5
                },
                new Book{
                    Title = "mauris, rhoncus id, mollis nec, cursus",
                    AuthorId = 8
                },
                new Book{
                    Title = "a ultricies adipiscing, enim",
                    AuthorId = 8
                },
                new Book{
                    Title = "imperdiet dictum magna. Ut tincidunt",
                    AuthorId = 2
                },
                new Book{
                    Title = "In ornare sagittis felis. Donec tempor, est",
                    AuthorId = 1
                },
                new Book{
                    Title = "Aliquam tincidunt, nunc ac mattis ornare, lectus ante",
                    AuthorId = 4
                },
                new Book{
                    Title = "dignissim pharetra. Nam",
                    AuthorId = 9
                },
                new Book{
                    Title = "ornare placerat, orci lacus vestibulum",
                    AuthorId = 3
                },
                new Book{
                    Title = "orci luctus et ultrices posuere cubilia Curae Donec tincidunt.",
                    AuthorId = 8
                },
                new Book{
                    Title = "dis parturient montes, nascetur ridiculus mus. Aenean eget",
                    AuthorId = 6
                },
                new Book{
                    Title = "lectus convallis est, vitae sodales nisi",
                    AuthorId = 2
                },
                new Book{
                    Title = "vitae sodales nisi magna sed dui.",
                    AuthorId = 2
                },
                new Book{
                    Title = "enim, gravida sit amet, dapibus id, blandit at,",
                    AuthorId = 9
                },
                new Book{
                    Title = "Mauris magna. Duis",
                    AuthorId = 9
                },
                new Book{
                    Title = "volutpat. Nulla facilisis. Suspendisse",
                    AuthorId = 1
                },
                new Book{
                    Title = "at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu",
                    AuthorId = 4
                },
                new Book{
                    Title = "lacus. Etiam bibendum fermentum metus. Aenean sed pede",
                    AuthorId = 1
                },
                new Book{
                    Title = "tristique senectus et",
                    AuthorId = 9
                },
                new Book{
                    Title = "velit justo nec ante. Maecenas mi",
                    AuthorId = 4
                },
                new Book{
                    Title = "facilisis, magna",
                    AuthorId = 1
                },
                new Book{
                    Title = "consectetuer rhoncus. Nullam velit dui,",
                    AuthorId = 1
                },
                new Book{
                    Title = "et arcu imperdiet ullamcorper. Duis at",
                    AuthorId = 10
                },
                new Book{
                    Title = "sed pede. Cum sociis natoque penatibus et magnis dis",
                    AuthorId = 5
                },
                new Book{
                    Title = "eu, placerat eget, venenatis a, magna. Lorem ipsum dolor sit",
                    AuthorId = 6
                },
                new Book{
                    Title = "tincidunt vehicula risus. Nulla eget metus eu erat",
                    AuthorId = 4
                },
                new Book{
                    Title = "ligula. Nullam feugiat placerat velit. Quisque",
                    AuthorId = 1
                },
                new Book{
                    Title = "Morbi sit amet massa. Quisque porttitor eros nec",
                    AuthorId = 8
                },
                new Book{
                    Title = "sociosqu ad litora",
                    AuthorId = 7
                },
                new Book{
                    Title = "facilisis, magna tellus faucibus",
                    AuthorId = 4
                },
                new Book{
                    Title = "natoque penatibus et magnis dis parturient",
                    AuthorId = 2
                },
                new Book{
                    Title = "convallis est, vitae sodales nisi magna sed dui. Fusce",
                    AuthorId = 4
                },
                new Book{
                    Title = "vehicula risus.",
                    AuthorId = 1
                },
                new Book{
                    Title = "quis urna. Nunc quis arcu vel quam dignissim pharetra. Nam",
                    AuthorId = 6
                },
                new Book{
                    Title = "commodo hendrerit. Donec porttitor tellus non magna.",
                    AuthorId = 5
                },
                new Book{
                    Title = "Curabitur consequat, lectus sit amet luctus",
                    AuthorId = 3
                },
                new Book{
                    Title = "nec quam. Curabitur vel lectus. Cum sociis natoque penatibus et",
                    AuthorId = 2
                },
                new Book{
                    Title = "amet, consectetuer adipiscing elit. Curabitur sed tortor.",
                    AuthorId = 3
                },
                new Book{
                    Title = "fermentum arcu. Vestibulum ante ipsum primis in faucibus orci luctus",
                    AuthorId = 6
                },
                new Book{
                    Title = "eu dolor egestas rhoncus. Proin nisl sem, consequat",
                    AuthorId = 4
                },
                new Book{
                    Title = "amet orci. Ut sagittis lobortis mauris.",
                    AuthorId = 1
                },
                new Book{
                    Title = "ac mattis ornare, lectus ante dictum mi, ac",
                    AuthorId = 8
                },
                new Book{
                    Title = "id, mollis nec, cursus a,",
                    AuthorId = 9
                },
                new Book{
                    Title = "neque. Morbi quis urna. Nunc quis arcu",
                    AuthorId = 6
                },
                new Book{
                    Title = "interdum enim non nisi. Aenean eget",
                    AuthorId = 3
                },
                new Book{
                    Title = "facilisis, magna tellus",
                    AuthorId = 3
                },
                new Book{
                    Title = "dui, semper et, lacinia vitae, sodales at, velit.",
                    AuthorId = 4
                },
                new Book{
                    Title = "dictum magna. Ut tincidunt orci",
                    AuthorId = 7
                },
                new Book{
                    Title = "ante. Vivamus non lorem vitae odio sagittis",
                    AuthorId = 8
                },
                new Book{
                    Title = "neque. Nullam nisl. Maecenas",
                    AuthorId = 2
                },
                new Book{
                    Title = "ac libero nec ligula consectetuer rhoncus. Nullam velit",
                    AuthorId = 6
                },
                new Book{
                    Title = "adipiscing elit. Aliquam auctor, velit eget laoreet",
                    AuthorId = 1
                },
                new Book{
                    Title = "libero. Donec consectetuer mauris id sapien. Cras dolor dolor,",
                    AuthorId = 1
                },
                new Book{
                    Title = "tincidunt. Donec vitae erat vel pede blandit congue.",
                    AuthorId = 5
                },
                new Book{
                    Title = "erat, in consectetuer ipsum nunc id",
                    AuthorId = 1
                },
                new Book{
                    Title = "arcu.",
                    AuthorId = 6
                },
                new Book{
                    Title = "ut cursus luctus, ipsum leo elementum",
                    AuthorId = 9
                },
                new Book{
                    Title = "at, velit. Pellentesque ultricies dignissim lacus. Aliquam",
                    AuthorId = 10
                },
                new Book{
                    Title = "pede blandit congue. In",
                    AuthorId = 7
                },
                new Book{
                    Title = "a, scelerisque",
                    AuthorId = 1
                },
                new Book{
                    Title = "sapien, cursus in, hendrerit consectetuer, cursus et, magna.",
                    AuthorId = 6
                },
                new Book{
                    Title = "pharetra nibh. Aliquam ornare,",
                    AuthorId = 3
                },
                new Book{
                    Title = "nec orci. Donec nibh. Quisque nonummy",
                    AuthorId = 7
                },
                new Book{
                    Title = "Donec fringilla. Donec feugiat metus sit amet ante.",
                    AuthorId = 9
                },
                new Book{
                    Title = "Aliquam rutrum lorem ac risus. Morbi metus.",
                    AuthorId = 10
                },
                new Book{
                    Title = "Phasellus elit pede, malesuada vel, venenatis vel, faucibus id,",
                    AuthorId = 5
                },
                new Book{
                    Title = "Nunc quis arcu",
                    AuthorId = 4
                },
                new Book{
                    Title = "ut nisi a",
                    AuthorId = 4
                },
                new Book{
                    Title = "elementum at, egestas a, scelerisque sed, sapien. Nunc",
                    AuthorId = 6
                },
                new Book{
                    Title = "iaculis aliquet diam. Sed diam lorem, auctor quis,",
                    AuthorId = 4
                },
                new Book{
                    Title = "quis, pede. Praesent eu dui. Cum",
                    AuthorId = 6
                },
                new Book{
                    Title = "lorem",
                    AuthorId = 6
                },
                new Book{
                    Title = "Nunc quis arcu vel quam dignissim pharetra. Nam ac",
                    AuthorId = 1
                },
                new Book{
                    Title = "Sed eu eros. Nam consequat dolor vitae dolor. Donec fringilla.",
                    AuthorId = 5
                },
                new Book{
                    Title = "id, mollis nec, cursus a, enim.",
                    AuthorId = 4
                },
                new Book{
                    Title = "risus. Duis a",
                    AuthorId = 5
                },
                new Book{
                    Title = "a tortor. Nunc commodo",
                    AuthorId = 9
                },
                new Book{
                    Title = "augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan",
                    AuthorId = 9
                }
            };
            foreach (var s in Books)
            {
                context.Books.Add(s);
            }
            context.SaveChanges();
        }

    }
}
