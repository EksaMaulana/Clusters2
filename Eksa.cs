using System;

class Program
{
    static void Main()
    {
      Console.Write("Masukkan nama: ");
              string nama = Console.ReadLine();

              Console.Write("Masukkan nomor KTP: ");
              string nomorKTP = Console.ReadLine();

              Console.Write("Masukkan jumlah malam menginap: ");
              int jumlahMalam = Convert.ToInt32(Console.ReadLine());

              
              Console.WriteLine("Pilih tipe kamar:");
              Console.WriteLine("a. VIP (1.000.000/malam)");
              Console.WriteLine("b. Deluxe (800.000/malam)");
              Console.WriteLine("c. Standar (500.000/malam)");

              Console.Write("Masukkan pilihan (a/b/c): ");
              char pilihanKamar = Convert.ToChar(Console.ReadLine());

              
              int hargaPerMalam = 0;
              switch (pilihanKamar)
              {
                  case 'a':
                      hargaPerMalam = 1000000;
                      break;
                  case 'b':
                      hargaPerMalam = 800000;
                      break;
                  case 'c':
                      hargaPerMalam = 500000;
                      break;
                  default:
                      Console.WriteLine("Pilihan tidak valid.");
                      return;
              }

              // Hitung jumlah biaya sebelum diskon
              int jumlahBiaya = jumlahMalam * hargaPerMalam;

              // Hitung diskon
              double diskon = 0;
              if (jumlahMalam >= 2 && jumlahMalam <= 3)
              {
                  diskon = 0.05;
              }
              else if (jumlahMalam >= 4 && jumlahMalam <= 6)
              {
                  diskon = 0.1;
              }
              else if (jumlahMalam > 6)
              {
                  diskon = 0.15;
              }

             
              double jumlahBayar = jumlahBiaya - (jumlahBiaya * diskon);

             
              Console.WriteLine("\n--- Invoice ---");
              Console.WriteLine($"Nama: {nama}");
              Console.WriteLine($"Nomor KTP: {nomorKTP}");
              Console.WriteLine($"Lama menginap: {jumlahMalam} malam");
              Console.WriteLine($"Tipe kamar: {pilihanKamar}");
              Console.WriteLine($"Harga per malam: {hargaPerMalam}");
              Console.WriteLine($"Jumlah biaya: {jumlahBiaya}");
              Console.WriteLine($"Diskon: {diskon * 100}%");
              Console.WriteLine($"Jumlah bayar: {jumlahBayar}");

              Console.ReadLine(); 
          }
      }