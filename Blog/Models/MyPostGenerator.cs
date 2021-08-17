using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Blog.Models
{
    public class MyPostGenerator
    {
        public List<MyPost> GeneratePost()
        {
            List<MyPost> blogItems = new List<MyPost>();


            //Image propertysi içerisine oluşturduğum img padding çalışmıyor. Onun yerine görüntüde hoş dursun diye ekstradan background color ekledim.
            blogItems.Add(new MyPost
            {
                Id = 1,
                Author = "Uzman Diyetisyen Gülin KANAT ÇOLAK",
                Title = "Sınav Öncesi Beslenme",
                Desc = "Gelin hep birlikte sınav günü ve öncesinde nasıl beslenmeliyiz, nelere dikkat etmeliyiz inceleyelim…",
                Date = "17 Haziran 2021",
                Detail = @"<p>Her yıl olduğu gibi bir eğitim-öğretim yılının daha sonuna geldik. Lise öğrencilerinin heyecanla beklediği üniversite sınavı da bu hafta sonu gerçekleşecek. Ancak bu yıl her yılkinden farklı olarak hepimiz sınav tarihini dünyaca yaşanan pandemi nedeni ile yakından takip ediyor ve tarihsel olarak biliyoruz. Hafta sonu yaşanacak sokağa çıkma yasağı iş düzeni anlamında sınavla ilgisi olmayan bireyleri bile alakadar ederken, bu yıl sınava girecek öğrencilerimiz, biraz talihsiz, epeyce karmaşık bir süreçten geçtiler. Okul ve dershane düzenleri, çalışma sistemleri dünya da yaşanan durum sebebi ile istemsiz olarak etkilendi ve çocuklar ekstra bir stres altındalar.</p>

                <p>Sınav anını etkileyen birçok faktör mevcut. Çocuklar yıl boyunca ellerinden geleni yaparak bu sınava hazırlandılar ise bunun sadece bir başarı değerlendirilmesi olarak adlandırılmadan, ellerinden gelenin yapıldığına kalanın ise o anki duygu durum, stres yönetebilme becerisi ve biraz da kader ile ilgili olduğuna ikna edilmelidirler. Beslenme ise önceki gününden itibaren ilgilenilmesi gereken ve sınav anını metabolik olarak içeriden etkileyen faktörlerden ve hatta en önemli faktörlerden birisidir.</p>

                <h2 class=""section - heading"" style=""color:Tomato; "">Gelin hep birlikte sınav günü ve öncesinde nasıl beslenmeliyiz, nelere dikkat etmeliyiz inceleyelim…</h2>

                <h2 class=""section-heading"" style=""color:Tomato; "">Sınav günü öncesi nelere dikkat edilmeli!</h2>

                <ul>
                    <li>Her bireyin damak zevki ve yeme alışkanlıkları birbirinden farklıdır.Dolayısı ile çocukların öncelikle sadece sınav var mantığıyla normalde yediklerinden çok farklı besinler tüketerek, zaten var olan sınav streslerine bir de bununla katkı yapmak istemeyiz.Bu sebeple günlük beslenme alışkanlıklarından en zararsızlarını mutlaka tabaklarda bulundurmalıyız.</li>
                    <li>Dışarıdan yemek yeme alışkanlıkları olan çocuklar için, zehirlenme riski, herhangi bir baharatın bile o anki mide durumunu rahatsız etme riski göz önüne alınarak sınav günü ve öncesinde dışarıdan yemek yememeye özen gösterilmelidir.</li>
                    <li>Karışık içerikli, bol yağlı, kızartma, mayonez gibi ürünlerden uzak durmalı, daha hafif beslenme ürünleri tercih edilmeye çalışılmalıdır.</li>
                    <li>Stresle yönetim biçimi olarak iştahta değişiklikler yaşanabilir, bu sebeple çocuklar çok zorlanmadan, uygun porsiyonlarca beslenmelidir.Kimi çocuk iştah kaybı yaşarken bu sınav öncesi aşırı yemek yemeye zorlanmasıyla beraber istifraya ve akabinde hastaymış hissine bile yol açabilir.</li>
                    <li>Sınavdan önceki gün gaz yapıcı veya hazımsızlık yaratabilecek besinlerden kaçınılmaya özen gösterilmelidir. Baklagiller, bulgur, lahana, brokoli gibi ürünler sindirim sisteminde gaz ve hazımsızlık yaratabilecek besinlerin başında gelmektedir.</li>
                    <li>Sınavdan bir gün önce ilk defa tadacakları bir ürünü o gün için denemeyi ertelemelidirler. Daha önce tüketmedikleri bir besini o gün için ilk deneme yapılmamalıdır, alerjik reaksiyonlar ve istenmeyen oluşabilecek rahatsızlıklar ağız kuruluğu, bireyde gaz yapma gibi durumların önüne geçilmeye çalışılmalıdır.</li>
                    <li>Sınav gecesi öncesi strese bağlı çay kahve gibi uyaranları tüketme isteği gece uyku düzenini negatif etkileyip, sınav anında uykusuzluk yaratabilir. Bu sebeple bu ürünlerden kaçınırken, melisa, papatya, ıhlamur gibi bitki çayları ile hem su takviyesi hem yatıştırıcı etkileri ile çocukların rahat bir uyku geçirmesi sağlanabilir.</li>
                </ul>

                <br />

                <h2 class=""section-heading"" style=""color:Tomato; "">Sınav sabahı hangi besinler tercih edilmelidir?</h2>

                <ul>
                    <li>Sınav sabahı güne mutlaka kaliteli bir kahvaltı ile başlanmalıdır.</li>
                    <li>Basit şekerlerden uzak, içeriği zengin, besin kalitesi yüksek, kompleks kahbonhidratlar ile zenginleştirilmiş bir öğün tercih edilmelidir.</li>
                    <li>Kahvaltıda çok tuzlu olmayan peynir çeşitleri, tercihen haşlanmış yumurta ya da yağsız pişmiş bir yumurta, taze ve mevsiminde sebze meyve ürünleri, süt gibi ile dengelenmiş, 1 tatlı kaşığını çok fazla aşmadan bal, reçel, pekmez ile tatlandırılmış ve tercihen tam buğday ekmeği ile kan şekeri dengelenmesi sağlanan, sağlıklı yağ alternatiflerinden ceviz, badem, fındık gibi ürünler ile zenginleştirilmiş bir kahvaltı uygun olabilmektedir.</li>
                    <li>Sınav sabahı çay ya da kahve, kafein ve tanen içerikleri ile uyarıcı olmalarına rağmen diüretik ürünler olduğundan tuvalet ihtiyacını arttırabilirler.Bu sebeple kaçınılmalıdır.Ancak bir önceki akşam gibi sakinleştirici etkileri olan bitki çayları da sınav anında konsantrasyon bozukluğuna sebep olabilir, bu sebeple sınav sabahı bu ürünlerden de kaçınılmalıdır.Kahvaltı süt ile sıvı dengesi açısından zenginleştirilebilir.</li>
                    <li>Sıvı tüketimi önemlidir, ancak heyecanla beraber aşırı su tüketimi yine tuvalet ihtiyacını arttıracağından, sıcağın etkisiyle beraber lıkır lıkır içmenin ötesinde ılık bir su ile yudum yudum tüketilmelidir.</li>
                    <li>Bunula beraber bilinen ve inanılanın aksine sınav öncesi şekerli besinlerin aşırı tüketimi sınav sürecindeki kan şekeri regülasyonunu olumsuz etkilememektedir.Bu sebeple sınav öncesi aşırı çikolata ve tatlı ürünler tüketimi sınav anında kan şekerini olumsuz etkilemesiyle sınav konsantrasyonun negatif etkilemektedir.</li>
                    <li>

                      Yine strese bağlı mide bulantısı ile aşırı tuzlu-baharatlı kraker tüketimi susamaya sebep olabilir.

                      Sonuç olarak sınav öncesinde ve esnasında tüketilecek bir yiyecek veya içeceğin mucize yaratmayacağını bilmelisiniz. Diyet Kapımda Ailesi olarak bu yıl sınava girecek tüm çocuklara başarılar diler, mesleklerini kazanmak üzere girecekleri bu sınavda sevebilecekleri ve mutlu olabilecekleri okullar kazanmaları dileriz.
                    </li>
                </ul>

                <p>

                  Placeholder text by
                  <a href=""https://www.diyetkapimda.com/""> Diyet Kapımda</a>
                    &middot; Images by
                  <a href= ""https://unsplash.com/"" > Editorial, Food & Drink, Health & Wellness</a>
                </p>",
                Image = @"../assets/img/post1.jpg",
                Color ="tomato"
            });

            blogItems.Add(new MyPost
            {
                Id = 2,
                Author = "Uzman Diyetisyen İpek Ağaca Özger",
                Title = "Kinoa mı Bulgur mu?",
                Desc = "Kinoa, Güney Amerika’da binlerce yıldır tüketilen ve İnka İmparatorluğu’nun temel besinlerinden biri olan bir gıda maddesidir..." +
                "Bulgur, tam buğday tanelerinin kaynatma, kuruma, kırılma ve öğütme aşamalarından sonra elde edilen yarı pişmiş bir gıdadır...",
                Date = "17 Nisan 2021",
                Detail = @"<p>Kinoa, Güney Amerika’da binlerce yıldır tüketilen ve İnka İmparatorluğu’nun temel besinlerinden biri olan bir gıda maddesidir. Kinoa, aslında bir tahıl değil, Chenopodiaceae familyasından geniş yapraklı bir bitkinin tohumlarıdır. Besin içeriği tahıllara benzerlik gösterdiğinden pseudo-tahıl olarak sınıflandırılmaktadır. Renkleri beyazdan kırmızıya ve mordan siyaha değişen yüzlerce çeşit kinoa vardır. İklim koşullarına dayanıklı ve küçük hacimde yüksek besin değerine sahip olması ile açlık sorunlarına çözüm olabilecek bir bitki olduğu düşünülmektedir. Bu nedenle 2013 yılı Birleşmiş Milletler tarafından Uluslararası Kinoa Yılı ilan etmiştir.</p>

                <p>Bulgur, tam buğday tanelerinin kaynatma, kuruma, kırılma ve öğütme aşamalarından sonra elde edilen yarı pişmiş bir gıdadır.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Hangisinin besin içeriği daha zengindir?</h2>

                <p>Kinoa ve bulgurun kalori içeriği benzerdir ancak bulgurun kalori içeriği biraz daha azdır. Bir küçük kase pişmiş kinoa 222 kalori iken bulgur 122 kaloridir.</p>

                <p>Kinoanın protein içeriği bulgurdan yüksektir. Kinoanın öne çıkan özelliği öncelikle yüksek protein içeriği ve kalitesidir. Kinoada bulunan aminoasitler (protein yapıtaşları), esansiyel aminoasitler açısından iyi bir dengeye sahiptir. Kinoanın, bitkisel besinlerde genellikle az miktarda bulunan bir amino asit olan lizin aminoasiti bakımından zengin içeriği vardır. Metiyonin ve sistin aminoasitleri bakımından fakir olan baklagiller için de iyi bir tamamlayıcıdır. Baklagiller ile birlikte tüketildiğinde esansiyel aminoasitlerden daha bütün şekilde yararlanılabilir. Bu özelliğiyle vegan ve vejetaryen kişiler için protein ve karbonhidrat ihtiyaçlarını karşılayan besleyici bir alternatiftir.</p>

                <p>Bulgurun yağ içeriği kinoadan daha düşüktür. Bulgur 100 gramda 2 gram yağ içerirken kinoa 6,7 gram yağ içerir. Kinoa, lineloeik ve linolenik doymamış esansiyel yağ asitleri bakımından zengindir.</p>

                <p>Kinoa, yüksek fenolik bileşik içeren besinlerden biridir. Kinoa, yüksek antioksidan özellikte fenolik bileşikler içerir.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Vitamin İçerikleri:</h2>

                <p>Kinoanın vitamin içeriğine bakıldığında ise hücre farklılaşmasını sağlayan bağışıklıkla ilgili mekanizmalarla ilişkili olan A vitamini türevi olan olan karoten bakımından oldukça zengindir. Antioksidan özellikte olan ve yağda eriyen E vitamini türevleri (alfa-tocopherol ve beta-tocopherol ) yönünden zengin bir içeriğe sahiptir.  B grubu vitaminlerinden zengindir.</p>

                <p>Bulgur,  tiamin, niasin, riboflavin gibi B vitamileri yönünden zengindir. Özellikle niasin vitamini yönünden daha zengin olan bulgur, sinir ve sindirim sistemi için önemlidir. Diyette yeterli niasin almak için bulgur tüketilebilir.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Mineral İçerikleri:</h2>

                <p>Kinoa, demir, magnezyum, potasyum ve çinko mineralleri bakımından birçok tahıldan daha zengindir.</p>

                <p>Kinoanın sodyum içeriği bulgura göre oldukça düşüktür. Kinoada 115 ppm sodyum minerali bulunurken bulgurda 900 ppm sodyum minerali bulunmaktadır. Bu özelliği ile sodyum kısıtlı beslenen kişiler tercih edebilir.</p>

                <p>Yüksek miktarda magnezyum içeriği sayesinde kinoa kalp damar hastalıklarından korunmak ve kronik migren için yararlı olabilmektedir. Bulgurun magnezyum içeriği kinoaya göre düşüktür.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Kinoa ve bulgur kan şekerini nasıl etkiler?</h2>

                <p>Kinoanın lif içeriği karabuğday hariç, diğer tahıllardan daha yüksektir. Kinoa 100 gramında 10-16 grama kadar diyet lifi içerebilmektedir. Diyet lifi içeriği büyük bir oranda çözünmez diyet lifi olsa da 100 gramında 1.5 gram çözünür lif içerir. Çözünür lif sindirim sistemini desteklemede, kan şekeri yönetimine, kolesterol seviyelerinin yönetimine destek olur.</p>

                <p>Bulgurun lif içeriği kinoaya göre neredeyse 2 kat daha düşüktür fakat pirince göre biraz daha yüksektir. Her ikisi de günlük diyet lifi alımına katkı sağlar.</p>

                <p>Bulgur ve kinoanın glisemik indeksleri düşüktür. Kinoanın glisemik indeksi 53’tür bulgurun glisemik indeksi 48’dir. Her ikisinin de glisemik indeksinin düşük olması sebebiyle tokluk süresini uzun tutar ve kana daha yavaş karışarak kan şekerinde ani yükselmeye neden olmaz.</p>

                <p>Bunun yanında her ikisinin de karbonhidrat kaynağı besinler olduklarından; fazla miktarda tüketildiklerinde ‘glisemik yükleri’ artar. Bu durumda kan şekerinin yükselmesine ve kalori alımına artmasına etki edeceği unutulmamalıdır.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Kinoa gluten içermez</h2>

                <p>Kinoa, glüten içermez. Glütene duyarlı kişiler ve olan çölyak hastalarının rahatça tüketebileceği bir alternatiftir. Bulgurda ise glüten bulunur. Bu nedenle çölyak hastaları bulgur tüketmemelidir. Bulgur yerine kinoa tercih edebilirler. Pilav yaparken buğday yerine kinoa kullanabilirler. Unlu mamulleri pişirirken buğday unu yerine kinoa unları kullanılan tarifleri deneyebilirler.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Kinoanın antibesin özellikleri</h2>

                <p>Kinoa, yüksek miktarda fitik asit içerir. Fitik asit demir, çinko gibi minerallerin emilimini düşürür. Fitik asiti azaltmak için suda bekletmek iyi bir yöntemdir.</p>

                <p>Kinoa, oksalat içerir. Kalsiyumoksalat böbrek taşı oluşumuna yatkın kişiler kinoa tüketmekten kaçınmalıdır.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Kullanım alanları</h2>

                <p>Bulgur uzun zamandır ülkemizde kullanılan bir gıdadır kinoa ise mutfaklarımıza yeni girmektedir. Kinoa, bulgur ve pirinç kullanılan tüm yemeklerde kullanılabilir. Kinoanın kabuğunun ayıklanması için suda bekletilebilir. Kabukları ayıklandıktan sonra pilav, kısır, sarma, dolma gibi yemeklerin yapımında, salatalarda, güveçlerde, yemeklerde, çorbalarda ve fermente edilerek boza benzeri içeceklerde kullanılabilir. Kinoanın unu ile makarna, krep, ekmek, bisküvi, kek ve kraker yapılabilir.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Kinoa ve bulgurun 100 gramındaki besin değeri</h2>

                <p>Kinoa çeşitlerinin ortalama %13.8 protein, %5.0 yağ, %59.7 karbonhidrat, %4.1 lif ve %3.4 kül’dür. Bulgur ise %13.0 protein,  %1.6 yağ , %70.0 karbonhidrat, % 2.7 lif,  %1.8 kül’dür.</p>

                <h2 class=""section - heading"" style=""color:MediumSeaGreen;"">Sonuç olarak</h2>

                <p>Hem protein, vitamin, mineral, diyet lifi, biyoaktif bileşenlerden zengin olmaları hem de bunları yeterli ve dengeli bir şekilde bulunduruyor olmaları bu iki besini de değerli kılmaktadır. Beslenmesinin vitamin, mineral, diyet lifi içeriğini arttırmak isteyen kişiler için beyaz pirinci bulgur veya kinoa ile ara ara değiştirmek iyi bir başlangıç olabilir.</p>

                <p>Örneğin kabak dolması yaparken bulgur veya pirinç yerine kinoa koyarsanız daha fazla posa, daha fazla doymamış yağ asidi, daha fazla demir minerali alırsınız ayrıca daha az sodyum minerali almış olursunuz. Dolmaları, pilavları ve sarmaları kinoalı veya bulgur ile denemeye ne dersiniz?</p>

                <p>

                  Placeholder text by
                  <a href=""https://www.renklidiyet.com/"">Renkli Diyet</a>
                    &middot; Images by
                  <a href= ""https://unsplash.com/"" > Editorial, Food & Drink, Health & Wellness</a>
                </p>",

              Image = "~/assets/img/post2.jpg",
              Color = "MediumSeaGreen"
            });

            blogItems.Add(new MyPost
            {
                Id = 3,
                Author = "Uzman Diyetisyen Dilara Koçak",
                Title = "5 Adımda Değişim",
                Desc = "Hayatımız geçmişte tekrar tekrar yaptığımız eylem ve düşüncelerin toplamından oluşur. Journal of Personality’de yayınlanmış bir çalışmaya göre verdiğimiz kararların %45’inden fazlası gerçek kararlar değil, alışkanlıklarla veriliyor. Ve alışkanlıklar otomatik hale gelmediği sürece vazgeçiliyor. Bir alışkanlığı değiştirmek ise her zaman zor bir süreçtir ve çaba ister. Çünkü birey yıllardır içinde bulunduğu rahatlık alanının dışına çıkmak zorundadır..." +
                "Bulgur, tam buğday tanelerinin kaynatma, kuruma, kırılma ve öğütme aşamalarından sonra elde edilen yarı pişmiş bir gıdadır...",
                Date = "17 Mart 2021",
                Detail = @"<p>Hayatımız geçmişte tekrar tekrar yaptığımız eylem ve düşüncelerin toplamından oluşur. Journal of Personality’de yayınlanmış bir çalışmaya göre verdiğimiz kararların %45’inden fazlası gerçek kararlar değil, alışkanlıklarla veriliyor. Ve alışkanlıklar otomatik hale gelmediği sürece vazgeçiliyor.</p>

                <p>Bir alışkanlığı değiştirmek ise her zaman zor bir süreçtir ve çaba ister. Çünkü birey yıllardır içinde bulunduğu rahatlık alanının dışına çıkmak zorundadır.  Bu cümlem sizi şaşırtacak olabilir ama yapılan çalışmalar bir alışkanlığın gelişmesi için gerekli sürenin çok farklı olabileceğini ve bu sürenin 18 ile 254 gün arasında değişebileceğini söylüyor.</p>

                <p>Daha önce hiç hayatınızda bazı şeyleri değiştirmek istediniz mi? İstediyseniz bu süreç size neler hissettirdi? Başarısızlık korkusu, risk alma korkusu bunlardan bazıları olabilir.</p>

                <p>Kısacası yaşam tarzı değişikliği 1 adımda gerçekleşmez. Bu sürecin temelinde yatan kritik bir varsayım, bu sürecin bir adımda değil ama belirgin ve önceden kestirilebilen aşamalar dizisinden geçerek gerçekleşebileceği. Sizin de hangi değişim aşamasında olduğunuzun farkına varmanız, başarınıza yardımcı olabilir. Değişimin 5 aşamasını biraz da beslenmeyle ilişkilendirerek sizlere özetlemek istedim;</p>

                <p>Bahsedeceğim beş aşama sağlıksız beslenme, egzersiz yapmama, yeni bir aktiviteye veya kursa başlayamama gibi davranışları değiştirmek için de geçerli olabilir.</p>

                <ul>
                <li>
                    <h2 class=""section - heading"" style=""color:CornflowerBlue;"">İnkar Aşaması</h2>
                </li>
                </ul>

                <p>Bu aşamadaki insanlar alışkanlıklarında herhangi bir değişiklik yapmak istemez ve bir sorunları olduğunun farkında değildir. Değişme konusunda kendilerinin bir yeteneği olduğu konusunda karamsar olabilirler. Hatta var olan yaşam tarzı alışkanlıklarının kötü etkilerini inkâr ederler.</p>

                <p>Örneğin egzersiz yapmama kararlarını onaylamalarına yardım eden bilgileri büyük bir dikkatle filtrelerler. Bu aşama çoğu zaman onların “inkâr etme” aşamalarıdır.</p>

                <p>Zaman ayırıp bu yazıyı okuduğunuza göre, büyük bir olasılıkla siz bu aşamada değilsiniz.</p>

                <p>Ne yazık ki, bu aşamasındaki insanlara ulaşmak veya yardım etmek zordur. İnsanların inkâr etmelerini durdurmak için duygusal bir tetikleme ya da bir çeşit olay gerekir.</p>

                 <ul>
                <li>
                    <h2 class=""section - heading"" style=""color:CornflowerBlue;"">Niyetlenme</h2>
                </li>
                </ul>

                <p>Bu aşama süresince siz yaşam tarzı değişiminin çaba, zaman, maliyet bedeli ile yararlarını ölçersiniz. Değecek bir şey olup olamadığını anlamak için gözlemlersiniz. İnsanlar harekete geçmek için bir hazırlık yapmaksızın, yıllarca bu aşamada kalabilirler.</p>

                <p>Güçlü, motive eden hedefler konulması ve sonuçlarınızı gözünüzde canlandırmanın bu aşamayı tamamlamaya çok yardımcı olacağına inanıyorum. Eğer yararınıza olacak yeni değişik yolları tespit edebilirseniz, yararlar maliyete ağır basar. Biz genelde acıyı azaltmak için, haz almaya meyilliyizdir. O nedenle değişiklikten ne kadar keyif alırsanız, o kadar fazla eyleme geçecek ve eyleminiz o kadar fazla başarılı olacak.</p>

                <ul>
                <li>
                    <h2 class=""section - heading"" style=""color:CornflowerBlue;"">Hazırlık</h2>
                </li>
                </ul>

                <p>Hazırlık aşamasında olan kişiler, negatif alışkanlıklarını bir ay içinde değiştirmeye karar verirler. Bu kategorideyseniz, tebrikler! Büyük bir olasılıkla bir beslenme uzmanı ile randevu yapmak, egzersiz yapma yolları aramak üzeresinizdir. Belki de bir spor salonuna üye olmuşsunuzdur bile…</p>

                <ul>
                <li>
                    <h2 class=""section - heading"" style=""color:CornflowerBlue;"">Eylem</h2>
                </li>
                </ul>

                <p>Eylem aşaması, yaşam tarzınızı değiştirme işlemidir. İster daha düzenli egzersiz yapıyor olun, ister daha sağlıklı yiyor olun, bu aşamadaki bireyler eski hallerine dönme riski taşırlar.  O nedenle motive kalmanız için teknikler öğrenmenizi öneriyorum.</p>

                <ul>
                <li>
                    <h2 class=""section - heading"" style=""color:CornflowerBlue;"">Devamlılık</h2>
                </li>
                </ul>

                <p>Bu başarılı, kalıcı yaşam tarzı değişikliğinin aşamasıdır. Eğer yıllardır istikrarlı olarak egzersiz yapıyorsanız ve olumlu alışkanlıkları yaşamınıza harmanladıysanız,  o zaman siz “devamlılık” aşamasındasınız.</p>

                <p>Deneyimlerime göre inkar aşaması ile niyetlenme aşaması arasında gidip gelenler, diğer bir deyişle kilo verip geri alan birçok insan egzersize bir başlayıp bir bırakıyor. Bu kısır döngüden kurtulmanın yolu, alışkanlıklarınızda zamanla çok daha büyük anlam kazanabilecek küçük değişiklikler yapmanız.</p>

                <p>Sizin için doğru olan bir seviyedeki fiziksel aktiviteyi sadece istikrarlı olarak devam ettirmek o kadar da zor değil. (çok yüksek seviyede değilseniz). Ama vücudunuzu değiştirmek için hazırlık yapmak ve eyleme geçmek çok zor. Vücudumuz değişime karşı dirençlidir. O nedenle onu değiştirmek hem fiziksel hem de zihinsel olarak önemli ölçüde kararlılık gerektiren önemli bir çaba ister.  Vücudunuzu bir kere değiştirdiğinizde, durmayın. Onun yerine seviyenizi düşürüp devam edin. Egzersizi bırakmak bir seçim olmamalı.</p>

                <p>Umarım değişimin bu 5 aşaması yaşamınızda herhangi bir değişiklik yapmak istediğinizde başvurabileceğiniz bir kaynak olmuştur.</p>

                
                  Placeholder text by
                  <a href=""https://www.dilarakocak.com.tr/"">Dilara Koçak</a>
                    &middot; Images by
                  <a href= ""https://unsplash.com/"" > Editorial, Food & Drink, Health & Wellness</a>
                </p>",

                Image = "~/assets/img/post3.jpg",
                Color = "CornflowerBlue"
            });

            blogItems.Add(new MyPost
            {
                Id = 3,
                Author = "Diyetlif",
                Title = "İnsülin Direnci ve Beslenme",
                Desc = "İnsülin vücutta bulunan pankreas isimli organdan salgılanan bir hormondur ve başlıca görevi kan şekeri metabolizmasında yer almasıdır...",
                Date = "17 Şubat 2021",
                Detail = @"<p>İnsülin vücutta bulunan pankreas isimli organdan salgılanan bir hormondur ve başlıca görevi kan şekeri metabolizmasında yer almasıdır. Yemek yenildiği zaman vücuda giren karbonhidrat miktarıyla beraber kan şekeri artar, buna karşılık olarak pankreastan insülin salgılanır. İnsülin sayesinde kanda bulunan şekerin hücre içine girmesi ve böylece kan şekerinin normal seviyelere inmesi sağlanır.</p>

                <p>Son yıllarda sıklıkla rastlanan insülin direnci ise çeşitli nedenlerden dolayı gerekli miktarda salgılanan insülinin gereken etkisini gösterememesi durumudur. Hücrelerin insüline karşı gösterdiği bu dirençten dolayı pankreastan daha fazla insülin salgılanır, bu insüline karşılık olarak da kan şekeri daha da yükselir. Bu durumun devam etmesi halinde ise gereken sınırı aşan kan şekeri değerleri kişide Tip 2 diyabetin oluşumuna neden olmaktadır.</p>

                <p>İnsülin direncine neden olan etmenlerin başında aşırı kilo veya obezite sonucunda gelişen ve göbek çevresini saran iç organ yağlanması gelmektedir. Bunun dışında genetik faktörler, yüksek düzeyde fruktoz tüketimi, uyku bozuklukları ve fiziksel aktivite yoksunluğu da insülin direncine neden olabilmektedir. İnsülin direnci ise Tip 2 diyabet başta olmak üzere kalp-damar hastalıkları, çeşitli kanser türleri, yüksek tansiyon, kan yağ seviyelerinde yükselme ve polikistik over gibi hastalıkların oluşumunda etkendir.</p>

                <p>İnsülin direncinin tedavisinde kişinin kan bulgularına göre düzenlenen bireye özgü ilaç tedavisinin yanı sıra beslenme ve egzersiz de çok önemlidir. Beslenme tedavisinde sofra şekeri olarak bilinen basit şekerin tüketiminden kaçınılmalıdır. Kesinlikle uzun süre aç kalınmadan 2-2.5 saat aralıklarla günde 3 ana öğün ve  bu öğünler arasında 3-4 ara öğün yapılmalıdır. Meyve suyu yerine meyvelerin kendisi tercih edilerek günlük lif alımı arttırılmalıdır, bu kan şekerinin hızlı yükselmesine engel olacaktır. Günlük gerekli posa alımını sağlamak için haftada 2 gün mutlaka kurubaklagil, her gün sebze ve her öğünün yanında da salata tüketilmelidir. Beyaz un ile yapılan ekmek ve hamur işleri yerine tam tahıllı ekmek, pirinç yerine bulgur tercih edilmelidir. Karbonhidrat kaynaklı besinlerin tek başına tüketilmesindense süt, yoğurt, peynir ya da ceviz/fındık/badem ile beraber tüketilmesi kan şekerinin daha yavaş yükselmesini sağlayacaktır. Göbek çevresi yağlanmayı azaltarak insülinin duyarlılığını arttırmak için ise mutlaka kilo vermek ve ideal kiloyu korumak gerekmektedir. Düzenli egzersiz yapmak ise salgılanan insülinin duyarlılığını arttırarak insülin direncini kırmaktadır. İnsülin direncinin tedavisinde asıl amaç yaşam tarzı değişikliği sağlamaktır.</p>

                <p>Sağlıklı ve zinde günler dileriz.</p>

                
                  Placeholder text by
                  <a href=""https://diyetlif.com.tr/""> Diyetlif</a>
                    &middot; Images by
                  <a href= ""https://diyetlif.com.tr/"" >İnsülin Direnci ve Beslenme</a>
                </p>",

                Image = "~/assets/img/post4.jpg",
                Color = "MediumPurple"
            });

            return blogItems;
        }
    }
}
