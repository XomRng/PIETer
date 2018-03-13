using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    public partial class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atrybuty>()
                .Property(e => e.Atr_Wartosc)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_Opis)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_Format)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_SQL)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_Domyslna)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_DomyslnaAPI)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_DomyslnaSQL)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .Property(e => e.AtK_DomyslnaAPISQL)
                .IsUnicode(false);

            modelBuilder.Entity<AtrybutyKlasy>()
                .HasMany(e => e.Atrybuty)
                .WithOptional(e => e.AtrybutyKlasy)
                .HasForeignKey(e => e.Atr_AtkId);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Akronim)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Nazwa1)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Nazwa2)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Nazwa3)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_KodP)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Miasto)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Ulica)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Adres)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_NipE)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Nip)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_NipPrefiks)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Regon)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Pesel)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_KontoDostawcy)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_KontoOdbiorcy)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Kraj)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Powiat)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Gmina)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Wojewodztwo)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_GLN)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Telefon1)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Telefon2)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Modem)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Telex)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_EMail)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_NrRachunku)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_Odleglosc)
                .HasPrecision(10, 2);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_DokumentTozsamosci)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_OrganWydajacy)
                .IsUnicode(false);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_GPSSz)
                .HasPrecision(9, 6);

            modelBuilder.Entity<KntAdresy>()
                .Property(e => e.KnA_GPSDl)
                .HasPrecision(9, 6);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Akronim)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_AkronimFormat)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_FppKod)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Nazwa1)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Nazwa2)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Nazwa3)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_KodP)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Miasto)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Ulica)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Adres)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_NipE)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Nip)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_NipPrefiks)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Regon)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Pesel)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_KontoDostawcy)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_KontoOdbiorcy)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Kraj)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Powiat)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Gmina)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Wojewodztwo)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_GLN)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Telefon1)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Telefon2)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Modem)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Telex)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_EMail)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_URL)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_NrRachunku)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Soundex)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Rabat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_LimitWart)
                .HasPrecision(15, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_MaxLimitWart)
                .HasPrecision(15, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_LimitPoTerminie)
                .HasPrecision(15, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Marza)
                .HasPrecision(5, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_NumerKarty)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Ean)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_SeriaFa)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_SposobDostawy)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_HasloChk)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_HasloKontrahent)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Atrybut1)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Wartosc1)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Atrybut2)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Wartosc2)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Atrybut3)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Wartosc3)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_AkwProwizja)
                .HasPrecision(7, 4);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Umowa)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_FaVATOsw)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_CechaOpis)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_OutlookUrl)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Odleglosc)
                .HasPrecision(10, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_PIN)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_DokumentTozsamosci)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_OrganWydajacy)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_Punkty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_EFaVatOsw)
                .IsUnicode(false);

            modelBuilder.Entity<KntKarty>()
                .Property(e => e.Knt_EFaVatEMail)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Kod)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_KodP)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Miasto)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Ulica)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Pojemnosc)
                .HasPrecision(15, 2);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Konto)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_KontoInw)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_Kraj)
                .IsUnicode(false);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_AnalizaA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_AnalizaB)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_AnalizaX)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Magazyny>()
                .Property(e => e.MAG_AnalizaY)
                .HasPrecision(5, 2);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_TwrKod)
                .IsUnicode(false);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_Cecha)
                .IsUnicode(false);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_Cecha2)
                .IsUnicode(false);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_Ean)
                .IsUnicode(false);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_Ilosc)
                .HasPrecision(11, 4);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_JmZ)
                .IsUnicode(false);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_PrzeliczM)
                .HasPrecision(15, 0);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_PrzeliczL)
                .HasPrecision(15, 0);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_Opis)
                .IsUnicode(false);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_IloscMin)
                .HasPrecision(11, 4);

            modelBuilder.Entity<MagElem>()
                .Property(e => e.MaE_IloscMax)
                .HasPrecision(11, 4);

            modelBuilder.Entity<MagNag>()
                .Property(e => e.MaN_TrNSeria)
                .IsUnicode(false);

            modelBuilder.Entity<MagNag>()
                .Property(e => e.MaN_CechaOpis)
                .IsUnicode(false);

            modelBuilder.Entity<MagNag>()
                .Property(e => e.MaN_SposobDostawy)
                .IsUnicode(false);

            modelBuilder.Entity<MagNag>()
                .HasMany(e => e.MagElem)
                .WithRequired(e => e.MagNag)
                .HasForeignKey(e => e.MaE_GIDNumer);

            modelBuilder.Entity<MagSElem>()
                .Property(e => e.MaS_Ilosc)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_TwrNazwa)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_TwrKod)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Punkty)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Ilosc)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_JmZ)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_PrzeliczM)
                .HasPrecision(15, 0);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_PrzeliczL)
                .HasPrecision(15, 0);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_GrupaPod)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_StawkaPod)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Zrodlowa)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Akcyza)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Waluta)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KursM)
                .HasPrecision(5, 0);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KursL)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Poczatkowa)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_FlagaNB)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Rabat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_WartoscPoRabacie)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KsiegowaNetto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KsiegowaBrutto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_RzeczywistaNetto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KosztKsiegowy)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KosztRzeczywisty)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Prog)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Upust)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_UpustKnt)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_IloscDPPrzed)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KsiegowyDPPrzed)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Cena)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_RzeczywistyDPPrzed)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_PCN)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KrajPoch)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_RabatPromocyjny)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_RabatKorekta)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KosztBazowy)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_WartoscBazowa)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_CenaPoRabacie)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_Cecha)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_KGOJednostkowe)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_IloscMin)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_IloscMax)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_IloscPrzedKorekta)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_CenaPrzedKorekta)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_WartoscPrzedKorekta)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_GrupaPodPrzedKorekta)
                .IsUnicode(false);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_StawkaPodPrzedKorekta)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_ZrodlowaPrzedKorekta)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_AkcyzaPrzedKorekta)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraElem>()
                .Property(e => e.TrE_PrzyczynaKorekty)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_Dziennik)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_TrNSeria)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_VatRejestr)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_DokumentObcy)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_ZamDokumentObcy)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_NrKorekty)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_FlagaNB)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_FormaNazwa)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_FormaRabat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_Rabat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_Zaokraglenie)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_SposobDostawy)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_Waluta)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KursM)
                .HasPrecision(5, 0);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KursL)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_NettoR)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_NettoP)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_VatR)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_VatP)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_CechaOpis)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_WartoscDPPrzed)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_WartoscDPPo)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_Url)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_RabatW)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_MiejsceZaladunku)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_MiejscePrzeznaczenia)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_RodzajTransportu)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_InfoDlaUC)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_Waga)
                .HasPrecision(12, 3);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_WJm)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_NumerSAD)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_WartoscWal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_IncotermsSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_IncotermsMiejsce)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_WagaBrutto)
                .HasPrecision(12, 3);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KrajPrzezWys)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KodRodzajuTransportu)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KodRodzajuTransakcji)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KursMPierw)
                .HasPrecision(5, 0);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_KursLPierw)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_RabatPromocyjnyGlobalny)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_WsDziennik)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .Property(e => e.TrN_PrzyczynaKorekty)
                .IsUnicode(false);

            modelBuilder.Entity<TraNag>()
                .HasMany(e => e.TraElem)
                .WithRequired(e => e.TraNag)
                .HasForeignKey(e => e.TrE_GIDNumer);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Kod)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_KodFormat)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_FPPKod)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Nazwa1)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Certyfikat)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Sww)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Ean)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Jm)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Waga)
                .HasPrecision(9, 3);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_WJm)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_IloscZam)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_IloscMin)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_IloscMax)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Ubytek)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_IloscAZam)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_GrupaPod)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Akcyza)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Cel)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Atrybut1)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Wartosc1)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Atrybut2)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Wartosc2)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Atrybut3)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Wartosc3)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Punkty)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Konto1)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Konto2)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Konto3)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Polozenie)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Katalog)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_URL)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Warunek)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_ObjetoscL)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_ObjetoscM)
                .HasPrecision(5, 0);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_MarzaMin)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_KosztUslugi)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Clo)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_PodatekImp)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_StanInfoMax)
                .HasPrecision(15, 4);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_StanInfoProcent)
                .HasPrecision(3, 0);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_PCN)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_WagaBrutto)
                .HasPrecision(9, 3);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_WJmBrutto)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_StawkaPod)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Zrodlowa)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_GrupaPodSpr)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_StawkaPodSpr)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_ZrodlowaSpr)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_KrajPoch)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_WspFin)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_WymJm)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_OpisUrzadzenia)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_KategoriaABCXYZ)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Techniczna1)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Techniczna2)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Techniczna3)
                .IsUnicode(false);

            modelBuilder.Entity<TwrKarty>()
                .Property(e => e.Twr_Techniczna4)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_TwrNazwa)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_TwrKod)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Ilosc)
                .HasPrecision(11, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_JmZ)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_PrzeliczM)
                .HasPrecision(15, 0);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_PrzeliczL)
                .HasPrecision(15, 0);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_GrupaPod)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_StawkaPod)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Zrodlowa)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Waluta)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Rabat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Cecha)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_CenaKatalogowa)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_CenaOferowana)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_CenaUzgodniona)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Prog)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_Upust)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_UpustKnt)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_WartoscPoRabacie)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_FlagaNB)
                .IsUnicode(false);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_RabatPromocyjny)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_RabatKorekta)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_KGOJednostkowe)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_IloscMin)
                .HasPrecision(11, 4);

            modelBuilder.Entity<ZamElem>()
                .Property(e => e.ZaE_IloscMax)
                .HasPrecision(11, 4);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_FormaNazwa)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_FormaRabat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_ZamSeria)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_PomSeria)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_DokumentObcy)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_DokumentObcyP)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_Waluta)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_KursM)
                .HasPrecision(5, 0);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_KursL)
                .HasPrecision(7, 2);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_Rabat)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_SpDostawy)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_CechaOpis)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_Url)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_RabatW)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_FlagaNB)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_IncotermsSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_IncotermsMiejsce)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_KrajPrzezWys)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_KodRodzajuTransportu)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_KodRodzajuTransakcji)
                .IsUnicode(false);

            modelBuilder.Entity<ZamNag>()
                .Property(e => e.ZaN_RabatPromocyjnyGlobalny)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ZamNag>()
                .HasMany(e => e.ZamElem)
                .WithRequired(e => e.ZamNag)
                .HasForeignKey(e => e.ZaE_GIDNumer);
        }
    }
}
