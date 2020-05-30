using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KaVoo.Entity
{
    public class DataInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Psikolog", Description = "Psikolog"},
                new Category(){ Name = "Psikolojik Danışman", Description = "Psikolojik Danışman"},
                new Category(){ Name = "Uzman Klinik Psikolog", Description = "Uzman Klinik Psikolog"},
                new Category(){ Name = "Psikolog / Cinsel Terapist", Description = "Psikolog / Cinsel Terapist"},
                new Category(){ Name = "Terapist", Description = "Terapist"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Psikolog>()
            {
                new Psikolog(){ Name = "Volkan Yaşar  Ustaoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "1.jpg"},
                new Psikolog(){ Name = "Osman Kaan Şahinkoç",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "2.jpg"},
                new Psikolog(){ Name = "Brad Pitt",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome = true,Image = "3.jpg"},
                new Psikolog(){ Name = "Volkan",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "4.jpg"},
                new Psikolog(){ Name = "Kadir İnanır",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,Image = "5.jpg"},

                new Psikolog(){ Name = "Ediz Hun", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2},
                new Psikolog(){ Name = "Serhan Kahraman",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =4500 , Stock =1200 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "1.jpg"},
                new Psikolog(){ Name = "Cahit Büyükcelasun",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome = true,Image = "2.jpg"},
                new Psikolog(){ Name = "Samet Gürkan Ustaoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 2,Image = "3.jpg"},
                new Psikolog(){ Name = "Yeliz Emine Sevilmiş",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 2,Image = "4.jpg"},

                new Psikolog(){ Name = "Necdet Ataman Ustaoğlu", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 3,Image = "1.jpg"},
                new Psikolog(){ Name = "Fahri Baklavacıoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 3,Image = "2.jpg"},
                new Psikolog(){ Name = "Mevlüt Kamil Ustaoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId =3,IsHome = true,Image = "3.jpg"},
                new Psikolog(){ Name = "Ahmet Ahmetoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "4.jpg"},
                new Psikolog(){ Name = "Veli Ali Sancak",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 3,Image = "5.jpg"},

                new Psikolog(){ Name = "Ezgi Kürdü", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 4,Image = "1.jpg"},
                new Psikolog(){ Name = "Naciye Şevkat",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "2.jpg"},
                new Psikolog(){ Name = "Samet Yatak",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId =4,IsHome = true,Image = "3.jpg"},
                new Psikolog(){ Name = "Mehmet Can Ustaoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 4,Image = "4.jpg"},
                new Psikolog(){ Name = "Bedirhan Yiğit Ustaoğlu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 4,Image = "5.jpg"},

            };

            foreach (var urun in urunler)
            {
                context.Psikologlar.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}