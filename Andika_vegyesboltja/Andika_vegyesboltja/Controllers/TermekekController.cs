using Andika_vegyesboltja.Models;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;

namespace Andika_vegyesboltja.Controllers
{
    public class TermekekController : Controller
    {
        static List<Termekek> termekek = new List<Termekek>()
{
    // =========================
    // TISZTÁLKODÁSI SZEREK (1-10)
    // =========================
    new Termekek { Id=1, Name="Kallos sampon 1L", Price=1550, Darab=2, Fajta="tisztalkodasiszerek", Link="Kepek/1.png" },
    new Termekek { Id=2, Name="Taft hajlakk", Price=1680, Darab=4, Fajta="tisztalkodasiszerek", Link="Kepek/2.png" },
    new Termekek { Id=3, Name="Kallos hajlakk 750ml", Price=3150, Darab=1, Fajta="tisztalkodasiszerek", Link="Kepek/3.png" },
    new Termekek { Id=4, Name="Nivea Deo", Price=1269, Darab=6, Fajta="tisztalkodasiszerek", Link="Kepek/4.png" },
    new Termekek { Id=5, Name="Fa Deo", Price=520, Darab=12, Fajta="tisztalkodasiszerek", Link="Kepek/5.png" },
    new Termekek { Id=6, Name="Axe Dark Temptation", Price=1399, Darab=18, Fajta="tisztalkodasiszerek", Link="Kepek/6.png" },
    new Termekek { Id=7, Name="Axe Apollo", Price=1399, Darab=10, Fajta="tisztalkodasiszerek", Link="Kepek/7.png" },
    new Termekek { Id=8, Name="Rexona Men", Price=1299, Darab=14, Fajta="tisztalkodasiszerek", Link="Kepek/8.png" },
    new Termekek { Id=9, Name="Denim tusfürdő", Price=789, Darab=9, Fajta="tisztalkodasiszerek", Link="Kepek/9.png" },
    new Termekek { Id=10, Name="Palmolive tusfürdő", Price=899, Darab=11, Fajta="tisztalkodasiszerek", Link="Kepek/10.png" },

    // =========================
    // ÉDESSÉG / NASI (11-30)
    // =========================
    new Termekek { Id=11, Name="Milka tejcsoki", Price=499, Darab=30, Fajta="edesseg", Link="Kepek/11.png" },
    new Termekek { Id=12, Name="Milka mogyorós", Price=529, Darab=25, Fajta="edesseg", Link="Kepek/12.png" },
    new Termekek { Id=13, Name="Tibi étcsoki", Price=399, Darab=18, Fajta="edesseg", Link="Kepek/13.png" },
    new Termekek { Id=14, Name="Kinder Bueno", Price=449, Darab=40, Fajta="nasik", Link="Kepek/14.png" },
    new Termekek { Id=15, Name="Kinder Maxi King", Price=389, Darab=20, Fajta="nasik", Link="Kepek/15.png" },
    new Termekek { Id=16, Name="Tic Tac narancs", Price=235, Darab=60, Fajta="nasik", Link="Kepek/16.png" },
    new Termekek { Id=17, Name="Haribo Goldbears", Price=329, Darab=45, Fajta="nasik", Link="Kepek/17.png" },
    new Termekek { Id=18, Name="Orbit rágó", Price=199, Darab=70, Fajta="nasik", Link="Kepek/18.png" },
    new Termekek { Id=19, Name="Chio Chips", Price=499, Darab=25, Fajta="nasik", Link="Kepek/19.png" },
    new Termekek { Id=20, Name="Pringles Original", Price=899, Darab=15, Fajta="nasik", Link="Kepek/20.png" },
    new Termekek { Id=21, Name="Snickers", Price=399, Darab=35, Fajta="edesseg", Link="Kepek/21.png" },
    new Termekek { Id=22, Name="Twix", Price=399, Darab=40, Fajta="edesseg", Link="Kepek/22.png" },
    new Termekek { Id=23, Name="Bounty", Price=399, Darab=20, Fajta="edesseg", Link="Kepek/23.png" },
    new Termekek { Id=24, Name="Mentos", Price=299, Darab=50, Fajta="edesseg", Link="Kepek/24.png" },
    new Termekek { Id=25, Name="Raffaello", Price=699, Darab=15, Fajta="edesseg", Link="Kepek/25.png" },
    new Termekek { Id=26, Name="Kinder csokoládé mix", Price=1499, Darab=12, Fajta="edesseg", Link="Kepek/26.png" },
    new Termekek { Id=27, Name="M&M's", Price=499, Darab=28, Fajta="edesseg", Link="Kepek/27.png" },
    new Termekek { Id=28, Name="Mars", Price=399, Darab=20, Fajta="edesseg", Link="Kepek/28.png" },
    new Termekek { Id=29, Name="KitKat", Price=399, Darab=30, Fajta="edesseg", Link="Kepek/29.png" },
    new Termekek { Id=30, Name="Balaton szelet", Price=189, Darab=40, Fajta="edesseg", Link="Kepek/30.png" },
        // =========================
    // ÜDÍTŐK (31-50)
    // =========================
    new Termekek { Id=31, Name="Coca-Cola 2L", Price=699, Darab=50, Fajta="uditok", Link="Kepek/31.png" },
    new Termekek { Id=32, Name="Coca-Cola Zero 2L", Price=699, Darab=40, Fajta="uditok", Link="Kepek/32.png" },
    new Termekek { Id=33, Name="Fanta narancs 2L", Price=699, Darab=35, Fajta="uditok", Link="Kepek/33.png" },
    new Termekek { Id=34, Name="Sprite 2L", Price=699, Darab=30, Fajta="uditok", Link="Kepek/34.png" },
    new Termekek { Id=35, Name="Pepsi 2L", Price=649, Darab=28, Fajta="uditok", Link="Kepek/35.png" },
    new Termekek { Id=36, Name="Hell energiaital", Price=299, Darab=80, Fajta="uditok", Link="Kepek/36.png" },
    new Termekek { Id=37, Name="Lipton Ice Tea", Price=399, Darab=45, Fajta="uditok", Link="Kepek/37.png" },
    new Termekek { Id=38, Name="Nestea", Price=399, Darab=40, Fajta="uditok", Link="Kepek/38.png" },
    new Termekek { Id=39, Name="Red Bull", Price=699, Darab=50, Fajta="uditok", Link="Kepek/39.png" },
    new Termekek { Id=40, Name="Schweppes", Price=499, Darab=35, Fajta="uditok", Link="Kepek/40.png" },
    new Termekek { Id=41, Name="Toma almalé", Price=599, Darab=25, Fajta="uditok", Link="Kepek/41.png" },
    new Termekek { Id=42, Name="Bravo narancslé", Price=599, Darab=28, Fajta="uditok", Link="Kepek/42.png" },
    new Termekek { Id=43, Name="Cappy multifruit", Price=649, Darab=30, Fajta="uditok", Link="Kepek/43.png" },
    new Termekek { Id=44, Name="Szentkirályi ásványvíz 1.5L", Price=179, Darab=100, Fajta="uditok", Link="Kepek/44.png" },
    new Termekek { Id=45, Name="Szentkirályi szénsavas 1.5L", Price=199, Darab=90, Fajta="uditok", Link="Kepek/45.png" },
    new Termekek { Id=46, Name="Vittel ásványvíz 0.5L", Price=149, Darab=80, Fajta="uditok", Link="Kepek/46.png" },
    new Termekek { Id=47, Name="Evian ásványvíz 0.5L", Price=199, Darab=60, Fajta="uditok", Link="Kepek/47.png" },
    new Termekek { Id=48, Name="Rauch Happy Day", Price=499, Darab=35, Fajta="uditok", Link="Kepek/48.png" },
    new Termekek { Id=49, Name="Bambi üdítő", Price=399, Darab=45, Fajta="uditok", Link="Kepek/49.png" },
    new Termekek { Id=50, Name="Frucade", Price=399, Darab=50, Fajta="uditok", Link="Kepek/50.png" },

    // =========================
    // TEJTERMÉK (51-70)
    // =========================
    new Termekek { Id=51, Name="Mizo tej 2.8%", Price=429, Darab=40, Fajta="tejtermek", Link="Kepek/51.png" },
    new Termekek { Id=52, Name="Trappista sajt", Price=2899, Darab=10, Fajta="tejtermek", Link="Kepek/52.png" },
    new Termekek { Id=53, Name="Túró Rudi", Price=159, Darab=100, Fajta="tejtermek", Link="Kepek/53.png" },
    new Termekek { Id=54, Name="Tejföl 20%", Price=399, Darab=35, Fajta="tejtermek", Link="Kepek/54.png" },
    new Termekek { Id=55, Name="Danone joghurt", Price=249, Darab=60, Fajta="tejtermek", Link="Kepek/55.png" },
    new Termekek { Id=56, Name="Pöttyös túró", Price=179, Darab=90, Fajta="tejtermek", Link="Kepek/56.png" },
    new Termekek { Id=57, Name="Alpro szójajoghurt", Price=599, Darab=50, Fajta="tejtermek", Link="Kepek/57.png" },
    new Termekek { Id=58, Name="Meggle vaj", Price=699, Darab=40, Fajta="tejtermek", Link="Kepek/58.png" },
    new Termekek { Id=59, Name="Rama margarin", Price=499, Darab=30, Fajta="tejtermek", Link="Kepek/59.png" },
    new Termekek { Id=60, Name="Mizo UHT 1L", Price=349, Darab=60, Fajta="tejtermek", Link="Kepek/60.png" },
    new Termekek { Id=61, Name="Préselt sajt", Price=1599, Darab=20, Fajta="tejtermek", Link="Kepek/61.png" },
    new Termekek { Id=62, Name="Mozzarella", Price=899, Darab=25, Fajta="tejtermek", Link="Kepek/62.png" },
    new Termekek { Id=63, Name="Feta sajt", Price=799, Darab=30, Fajta="tejtermek", Link="Kepek/63.png" },
    new Termekek { Id=64, Name="Kefir", Price=399, Darab=50, Fajta="tejtermek", Link="Kepek/64.png" },
    new Termekek { Id=65, Name="Mascarpone", Price=1099, Darab=15, Fajta="tejtermek", Link="Kepek/65.png" },
    new Termekek { Id=66, Name="Juhsajt", Price=1199, Darab=12, Fajta="tejtermek", Link="Kepek/66.png" },
    new Termekek { Id=67, Name="Edami sajt", Price=1299, Darab=18, Fajta="tejtermek", Link="Kepek/67.png" },
    new Termekek { Id=68, Name="Gouda sajt", Price=1499, Darab=14, Fajta="tejtermek", Link="Kepek/68.png" },
    new Termekek { Id=69, Name="Vajkarika 250g", Price=599, Darab=30, Fajta="tejtermek", Link="Kepek/69.png" },
    new Termekek { Id=70, Name="Körözött", Price=799, Darab=20, Fajta="tejtermek", Link="Kepek/70.png" },
    // =========================
    // HÚS (71-90)
    // =========================
    new Termekek { Id=71, Name="Csirkemell filé 1kg", Price=2199, Darab=15, Fajta="hus", Link="Kepek/71.png" },
    new Termekek { Id=72, Name="Sertéskaraj 1kg", Price=2399, Darab=12, Fajta="hus", Link="Kepek/72.png" },
    new Termekek { Id=73, Name="Marhahús darabolt 1kg", Price=3599, Darab=8, Fajta="hus", Link="Kepek/73.png" },
    new Termekek { Id=74, Name="Pulykamell szelet", Price=1999, Darab=10, Fajta="hus", Link="Kepek/74.png" },
    new Termekek { Id=75, Name="Szalámi 200g", Price=1299, Darab=25, Fajta="hus", Link="Kepek/75.png" },
    new Termekek { Id=76, Name="Parasztkolbász 300g", Price=1499, Darab=20, Fajta="hus", Link="Kepek/76.png" },
    new Termekek { Id=77, Name="Sonka 500g", Price=2199, Darab=15, Fajta="hus", Link="Kepek/77.png" },
    new Termekek { Id=78, Name="Bacon 250g", Price=1599, Darab=18, Fajta="hus", Link="Kepek/78.png" },
    new Termekek { Id=79, Name="Kolbász 400g", Price=1399, Darab=22, Fajta="hus", Link="Kepek/79.png" },
    new Termekek { Id=80, Name="Csirkeszárny 1kg", Price=1299, Darab=30, Fajta="hus", Link="Kepek/80.png" },

    // =========================
    // KONZERV (91-110)
    // =========================
    new Termekek { Id=81, Name="Babkonzerv 400g", Price=329, Darab=50, Fajta="konzerv", Link="Kepek/81.png" },
    new Termekek { Id=82, Name="Kukoricakonzerv 400g", Price=299, Darab=45, Fajta="konzerv", Link="Kepek/82.png" },
    new Termekek { Id=83, Name="Tonhal konzerv 185g", Price=599, Darab=30, Fajta="konzerv", Link="Kepek/83.png" },
    new Termekek { Id=84, Name="Paradicsom konzerv 400g", Price=349, Darab=35, Fajta="konzerv", Link="Kepek/84.png" },
    new Termekek { Id=85, Name="Zöldborsó konzerv 400g", Price=329, Darab=40, Fajta="konzerv", Link="Kepek/85.png" },
    new Termekek { Id=86, Name="Konzerv paprika 400g", Price=399, Darab=25, Fajta="konzerv", Link="Kepek/86.png" },
    new Termekek { Id=87, Name="Konzerv ananász 400g", Price=499, Darab=30, Fajta="konzerv", Link="Kepek/87.png" },
    new Termekek { Id=88, Name="Konzerv őszibarack 400g", Price=499, Darab=28, Fajta="konzerv", Link="Kepek/88.png" },
    new Termekek { Id=89, Name="Konzerv kukorica 250g", Price=299, Darab=50, Fajta="konzerv", Link="Kepek/89.png" },
    new Termekek { Id=90, Name="Konzerv zöldbab 400g", Price=349, Darab=35, Fajta="konzerv", Link="Kepek/90.png" },

    // =========================
    // GABONAFÉLE (111-130)
    // =========================
    new Termekek { Id=91, Name="Fehér kenyér 500g", Price=599, Darab=25, Fajta="gabonafele", Link="Kepek/91.png" },
    new Termekek { Id=92, Name="Zsemle 50g", Price=79, Darab=120, Fajta="gabonafele", Link="Kepek/92.png" },
    new Termekek { Id=93, Name="Rizs 1kg", Price=599, Darab=40, Fajta="gabonafele", Link="Kepek/93.png" },
    new Termekek { Id=94, Name="Tészta 500g", Price=399, Darab=60, Fajta="gabonafele", Link="Kepek/94.png" },
    new Termekek { Id=95, Name="Gabonapehely", Price=699, Darab=50, Fajta="gabonafele", Link="Kepek/95.png" },
    new Termekek { Id=96, Name="Müzli", Price=1299, Darab=35, Fajta="gabonafele", Link="Kepek/96.png" },
    new Termekek { Id=97, Name="Kukoricaliszt 1kg", Price=399, Darab=40, Fajta="gabonafele", Link="Kepek/97.png" },
    new Termekek { Id=98, Name="Búzaliszt 1kg", Price=399, Darab=50, Fajta="gabonafele", Link="Kepek/98.png" },
    new Termekek { Id=99, Name="Zabpehely 500g", Price=499, Darab=35, Fajta="gabonafele", Link="Kepek/99.png" },
    new Termekek { Id=100, Name="Édesburgonya liszt 1kg", Price=899, Darab=25, Fajta="gabonafele", Link="Kepek/100.png" },
    // =========================
    // ALKOHOL (101-120)
    // =========================
    new Termekek { Id=101, Name="Borsodi sör 0.5L", Price=299, Darab=90, Fajta="alkohol", Link="Kepek/101.png" },
    new Termekek { Id=102, Name="Heineken sör 0.5L", Price=399, Darab=70, Fajta="alkohol", Link="Kepek/102.png" },
    new Termekek { Id=103, Name="Dreher sör 0.5L", Price=349, Darab=60, Fajta="alkohol", Link="Kepek/103.png" },
    new Termekek { Id=104, Name="Soproni sör 0.5L", Price=349, Darab=65, Fajta="alkohol", Link="Kepek/104.png" },
    new Termekek { Id=105, Name="Asahi sör 0.33L", Price=499, Darab=40, Fajta="alkohol", Link="Kepek/105.png" },
    new Termekek { Id=106, Name="Jack Daniels 0.7L", Price=10999, Darab=5, Fajta="alkohol", Link="Kepek/106.png" },
    new Termekek { Id=107, Name="Jameson whiskey 0.7L", Price=10999, Darab=6, Fajta="alkohol", Link="Kepek/107.png" },
    new Termekek { Id=108, Name="Jim Beam 0.7L", Price=9999, Darab=7, Fajta="alkohol", Link="Kepek/108.png" },
    new Termekek { Id=109, Name="Vodka Smirnoff 0.7L", Price=7999, Darab=8, Fajta="alkohol", Link="Kepek/109.png" },
    new Termekek { Id=110, Name="Absolut Vodka 0.7L", Price=8999, Darab=5, Fajta="alkohol", Link="Kepek/110.png" },
    new Termekek { Id=111, Name="Ballantine's 0.7L", Price=10999, Darab=4, Fajta="alkohol", Link="Kepek/111.png" },
    new Termekek { Id=112, Name="Baileys 0.7L", Price=13999, Darab=3, Fajta="alkohol", Link="Kepek/112.png" },
    new Termekek { Id=113, Name="Captain Morgan 0.7L", Price=10999, Darab=6, Fajta="alkohol", Link="Kepek/113.png" },
    new Termekek { Id=114, Name="Bacardi 0.7L", Price=9999, Darab=7, Fajta="alkohol", Link="Kepek/114.png" },
    new Termekek { Id=115, Name="Félbarna sör 0.5L", Price=349, Darab=80, Fajta="alkohol", Link="Kepek/115.png" },
    new Termekek { Id=116, Name="Pilsner Urquell 0.5L", Price=399, Darab=70, Fajta="alkohol", Link="Kepek/116.png" },
    new Termekek { Id=117, Name="Guinness 0.5L", Price=499, Darab=50, Fajta="alkohol", Link="Kepek/117.png" },
    new Termekek { Id=118, Name="Heineken 0.33L", Price=299, Darab=90, Fajta="alkohol", Link="Kepek/118.png" },
    new Termekek { Id=119, Name="Corona 0.33L", Price=399, Darab=60, Fajta="alkohol", Link="Kepek/119.png" },
    new Termekek { Id=120, Name="Stella Artois 0.33L", Price=399, Darab=65, Fajta="alkohol", Link="Kepek/120.png" },

    // =========================
    // EGYÉB (121-140)
    // =========================
    new Termekek { Id=121, Name="WC papír 4db", Price=799, Darab=60, Fajta="egyeb", Link="Kepek/121.png" },
    new Termekek { Id=122, Name="Mosogatószer 500ml", Price=999, Darab=25, Fajta="egyeb", Link="Kepek/122.png" },
    new Termekek { Id=123, Name="Szén-monoxid érzékelő", Price=10650, Darab=3, Fajta="egyeb", Link="Kepek/123.png" },
    new Termekek { Id=124, Name="Papírzsebkendő 10db", Price=399, Darab=80, Fajta="egyeb", Link="Kepek/124.png" },
    new Termekek { Id=125, Name="Műanyag szemetes 50L", Price=1499, Darab=10, Fajta="egyeb", Link="Kepek/125.png" },
    new Termekek { Id=126, Name="Fényképező elemek AAA 4db", Price=799, Darab=30, Fajta="egyeb", Link="Kepek/126.png" },
    new Termekek { Id=127, Name="Öngyújtó", Price=399, Darab=60, Fajta="egyeb", Link="Kepek/127.png" },
    new Termekek { Id=128, Name="Tűzoltó készülék", Price=10999, Darab=5, Fajta="egyeb", Link="Kepek/128.png" },
    new Termekek { Id=129, Name="Ragasztószalag", Price=249, Darab=100, Fajta="egyeb", Link="Kepek/129.png" },
    new Termekek { Id=130, Name="Csomagolópapír tekercs", Price=499, Darab=40, Fajta="egyeb", Link="Kepek/130.png" },

    // =========================
    // ÉDESSÉG / NASI (141-170)
    // =========================
    new Termekek { Id=131, Name="Snickers", Price=399, Darab=35, Fajta="edesseg", Link="Kepek/131.png" },
    new Termekek { Id=132, Name="Twix", Price=399, Darab=40, Fajta="edesseg", Link="Kepek/132.png" },
    new Termekek { Id=133, Name="Bounty", Price=399, Darab=20, Fajta="edesseg", Link="Kepek/133.png" },
    new Termekek { Id=134, Name="Mentos", Price=299, Darab=50, Fajta="edesseg", Link="Kepek/134.png" },
    new Termekek { Id=135, Name="Raffaello", Price=699, Darab=15, Fajta="edesseg", Link="Kepek/135.png" },
    new Termekek { Id=136, Name="Kinder csokoládé mix", Price=1499, Darab=12, Fajta="edesseg", Link="Kepek/136.png" },
    new Termekek { Id=137, Name="M&M's", Price=499, Darab=28, Fajta="edesseg", Link="Kepek/137.png" },
    new Termekek { Id=138, Name="Mars", Price=399, Darab=20, Fajta="edesseg", Link="Kepek/138.png" },
    new Termekek { Id=139, Name="KitKat", Price=399, Darab=30, Fajta="edesseg", Link="Kepek/139.png" },
    new Termekek { Id=140, Name="Balaton szelet", Price=189, Darab=40, Fajta="edesseg", Link="Kepek/140.png" },
    new Termekek { Id=141, Name="Chio Chips", Price=499, Darab=25, Fajta="nasik", Link="Kepek/141.png" },
    new Termekek { Id=142, Name="Pringles Original", Price=899, Darab=15, Fajta="nasik", Link="Kepek/142.png" },
    new Termekek { Id=143, Name="Tic Tac narancs", Price=235, Darab=60, Fajta="nasik", Link="Kepek/143.png" },
    new Termekek { Id=144, Name="Haribo Goldbears", Price=329, Darab=45, Fajta="nasik", Link="Kepek/144.png" },
    new Termekek { Id=145, Name="Orbit rágó", Price=199, Darab=70, Fajta="nasik", Link="Kepek/145.png" },
    new Termekek { Id=146, Name="Milka tejcsoki", Price=499, Darab=30, Fajta="edesseg", Link="Kepek/146.png" },
    new Termekek { Id=147, Name="Milka mogyorós", Price=529, Darab=25, Fajta="edesseg", Link="Kepek/147.png" },
    new Termekek { Id=148, Name="Tibi étcsoki", Price=399, Darab=18, Fajta="edesseg", Link="Kepek/148.png" },
    new Termekek { Id=149, Name="Kinder Bueno", Price=449, Darab=40, Fajta="nasik", Link="Kepek/149.png" },
    new Termekek { Id=150, Name="Kinder Maxi King", Price=389, Darab=20, Fajta="nasik", Link="Kepek/150.png" },
   // =========================
    // MIRELIT (151-170)
    // =========================
    new Termekek { Id=151, Name="Frozen pizza 400g", Price=1299, Darab=20, Fajta="mirelit dolgok", Link="Kepek/151.png" },
    new Termekek { Id=152, Name="Frozen lasagna 500g", Price=1499, Darab=15, Fajta="mirelit dolgok", Link="Kepek/152.png" },
    new Termekek { Id=153, Name="Frozen zöldségmix 450g", Price=899, Darab=30, Fajta="mirelit dolgok", Link="Kepek/153.png" },
    new Termekek { Id=154, Name="Frozen sült krumpli 1kg", Price=999, Darab=25, Fajta="mirelit dolgok", Link="Kepek/154.png" },
    new Termekek { Id=155, Name="Frozen borsó 400g", Price=799, Darab=40, Fajta="mirelit dolgok", Link="Kepek/155.png" },
    new Termekek { Id=156, Name="Frozen kukorica 400g", Price=799, Darab=35, Fajta="mirelit dolgok", Link="Kepek/156.png" },
    new Termekek { Id=157, Name="Frozen gomba 400g", Price=899, Darab=25, Fajta="mirelit dolgok", Link="Kepek/157.png" },
    new Termekek { Id=158, Name="Frozen pulykamell szeletek 500g", Price=2199, Darab=10, Fajta="mirelit dolgok", Link="Kepek/158.png" },
    new Termekek { Id=159, Name="Frozen rántott csirke 500g", Price=1799, Darab=12, Fajta="mirelit dolgok", Link="Kepek/159.png" },
    new Termekek { Id=160, Name="Frozen zöldség pizza 400g", Price=1399, Darab=15, Fajta="mirelit dolgok", Link="Kepek/160.png" },
        };

        public IActionResult Index()
        {
            return View(termekek);
        }

        public IActionResult Reszletek(int id)
        {
            var termek = termekek.Find(e => e.Id == id);
            if (termek == null) return NotFound();

            return View(termek);
        }
        /*public IActionResult Rendeles(int id)
        {
            var termek = termekek.Find(t => t.Id == id);
            if (termek == null) return NotFound();

            var rendeles = new Rendeles
            {
                Termekek = termek.Nev,
                RegisztraltNev = regisztralt.Nev
            };

            return View(rendeles);
        }
        */
        [HttpPost]
        public IActionResult Visszajelzo(Rendeles model)
        {
            var termek = termekek.Find(t => t.Nev == model.RegisztraltNev);
            if (termek == null) return NotFound();

            var szak = egyetem.Szakok.Find(s => s.Nev == model.SzakNev);
            if (szak == null) return NotFound();

            if (szak.JelentkezettE)
            {
                ViewBag.Uzenet = "Már jelentkeztél erre a szakra!";
                return View(model);
            }

            szak.JelentkezettE = true;
            ViewBag.Uzenet = "Sikeres jelentkezés!";
            return View("Visszajelzes", model);
        }
    }
}