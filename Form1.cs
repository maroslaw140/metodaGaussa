using Microsoft.VisualBasic.Logging;
using System.Numerics;
using System.Windows.Forms;

namespace LAB01_metody_num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Generacja();
        }

        ushort dokladnoscZaokr = 5;
        bool zespolenie = true;
        int N;
        int blad = 0;
        Complex[,] A = new Complex[6, 6];
        Complex[] B, X = new Complex[6];

        public static string[] Komunikat =
        { /*0*/ "Brak b³êdu",
          /*1 */ "Niezgodnoœæ wymiarów macierzy w metodzie SkalRowMacTyp ",
          /*2 */ "Niezgodnoœæ wymiarów macierzy w metodzie RozRowMacGaussa ",
          /*3 */ "Warunek przerwania poszukiwania elementu g³ównego"+
                 " metody eliminacji Gaussa w metodzie RozRowMacGaussa "
        };

        public static void PiszKomunikat(int k)
        {
            MessageBox.Show(Komunikat[k]);
        }

        void Generacja()
        {
            N = (int)wymiaryMacierzy.Value;

            macierzA.ColumnCount = N;
            macierzA.RowCount = N;

            //macierzX.ColumnCount = 1;
            macierzX.RowCount = N;

            //macierzB.ColumnCount = 1;
            macierzB.RowCount = N;

            macierzA.ColumnHeadersHeight = 50;
            macierzX.ColumnHeadersHeight = 50;
            macierzB.ColumnHeadersHeight = 50;
            for (int i = 0; i < N; i++)
            {
                macierzA.Columns[i].HeaderText = (i + 1).ToString();
                macierzA.Rows[i].HeaderCell.Value = (i + 1).ToString();
                macierzX.Rows[i].HeaderCell.Value = (i + 1).ToString();
                macierzB.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        void WalidacjaZakresu()
        {
            minimum.Maximum = maksimum.Value;
            maksimum.Minimum = minimum.Value;

            if (maksimum.Value < minimum.Value)
            {
                generacjaLiczb.Text = "Z³y zakres";
                generacjaLiczb.Enabled = false;
            }
            else
            {
                generacjaLiczb.Text = "Generacja Liczb";
                generacjaLiczb.Enabled = true;
            }
        }

        private void wymiaryMacierzy_ValueChanged(object sender, EventArgs e)
        {
            Generacja();
        }

        void Wyczysc()
        {
            for(int i = 0; i < macierzX.RowCount; i++)
            {
                macierzX[0, i].Value = null;
            }
        }

        string Wypisz(Complex liczba)
        {
            if (zespolenie)
            {
                if(Math.Round(liczba.Imaginary, dokladnoscZaokr) == 0)
                {
                    return Math.Round(liczba.Real, dokladnoscZaokr).ToString();
                }
                else
                {
                    if(Math.Round(liczba.Real, dokladnoscZaokr) == 0)
                    {
                        return (Math.Round(liczba.Imaginary, dokladnoscZaokr).ToString() + "i");
                    }
                    else
                    {
                        if(Math.Round(liczba.Imaginary, dokladnoscZaokr) > 0)
                        {
                            return (Math.Round(liczba.Real, dokladnoscZaokr).ToString() + "+" + Math.Round(liczba.Imaginary, dokladnoscZaokr).ToString() + "i");
                        }
                        else
                        {
                            return (Math.Round(liczba.Real, dokladnoscZaokr).ToString() + Math.Round(liczba.Imaginary, dokladnoscZaokr).ToString() + "i");
                        }
                    }
                }
            }
            else
            {
                return Math.Round(liczba.Real, dokladnoscZaokr).ToString();
            }

        }

        private void generacjaLiczb_Click(object sender, EventArgs e)
        {
            Wyczysc();
            zespolenie = zespolone.Checked;
            int min = (int)minimum.Value;
            int maks = (int)maksimum.Value;
            Random los = new Random();

            A = new Complex[N + 1, N + 1];
            B = new Complex[N + 1];

            if (zespolenie)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        Complex liczbaA = new Complex(los.Next(min, maks), los.Next(min, maks));
                        A[i, j] = liczbaA;
                        macierzA[j - 1, i - 1].Value = Wypisz(liczbaA);

                    }
                    Complex liczbaB = new Complex(los.Next(min, maks), los.Next(min, maks));
                    B[i] = liczbaB;
                    macierzB[0, i - 1].Value = Wypisz(liczbaB);
                }
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        Complex liczbaA = new Complex(los.Next(min, maks), 0);
                        A[i, j] = liczbaA;
                        macierzA[j - 1, i - 1].Value = Wypisz(liczbaA);

                    }
                    Complex liczbaB = new Complex(los.Next(min, maks), 0);
                    B[i] = liczbaB;
                    macierzB[0, i - 1].Value = Wypisz(liczbaB);
                }
            }
            

            gaussTest.Enabled = true;
            wynik.Enabled = true;
        }

        public static int RozRowMacGaussa(Complex[,] A, Complex[] B, ref Complex[] X, double eps)
        {
            int i, j, k, blad, N, M, R;
            double T, MA, a1 = 1.0;
            Complex ZT, ZS;
            N = A.GetLength(0) - 1; M = A.GetLength(1) - 1; R = B.Length - 1;
            if (N == M && N == R)
            {
                //Konstrukcja ciagu macierzy A(i)  oraz ciagu macierzy B(i)
                for (i = 1; i <= N; i++)
                {
                    //Wybór elementu g³ównego
                    T = A[i, i].Magnitude; k = i;
                    for (j = i + 1; j <= N; j++)
                    {
                        MA = A[j, i].Magnitude;
                        if (MA > T) { T = MA; k = j; };
                    }
                    if (T < eps)
                    { //Warunek przerwania poszukiwania elementu g³ównego
                        // nie istnieje rozwi¹zanie równania macierzowego, detA=0
                        blad = 3;
                        return blad;
                    }
                    if (i == k) { ZT = A[i, i]; }
                    else
                    {
                        //Zamiana wiersza k-tego z i-tym macierzy MacB
                        ZS = B[k]; B[k] = B[i]; B[i] = ZS;
                        ZT = A[k, i];
                        for (j = N; j >= i; j--)
                        { //Zamiana wiersza k-tego z i-tym macierzy MacA
                            ZS = A[k, j]; A[k, j] = A[i, j]; A[i, j] = ZS;
                        }//j
                    }
                    ZT = a1 / ZT;
                    A[i, i] = ZT;
                    for (j = i + 1; j <= N; j++)
                    {
                        ZS = A[j, i] * ZT;
                        B[j] -= B[i] * ZS;
                        for (k = i + 1; k <= N; k++)
                            A[j, k] -= A[i, k] * ZS;
                    }//j
                }//i;
                // Rozwi¹zywanie uk³adu trójk¹tnego metod¹ postêpowania wstecz
                for (i = N; i >= 1; i--)
                {
                    ZT = B[i];
                    for (j = i + 1; j <= N; j++) ZT -= A[i, j] * X[j];
                    X[i] = ZT * A[i, i];
                }//i;
                blad = 0;
            }
            else blad = 2;
            return blad;
        }//Koniec RozRowMacGaussa

        
        private void maksimum_ValueChanged(object sender, EventArgs e)
        {
            WalidacjaZakresu();
        }

        private void minimum_ValueChanged(object sender, EventArgs e)
        {
            WalidacjaZakresu();
        }

        private void gaussTest_Click(object sender, EventArgs e)
        {
            Wyczysc();
            Complex suma = new Complex(0, 0);

            for (int i = 1; i <= N; i++)
            {
                suma = 0;
                for (int j = 1; j <= N; j++)
                {
                    suma += A[i, j];
                }
                B[i] = suma;
                macierzB[0, i - 1].Value = Wypisz(suma);
            }

            wynik.Enabled = true;
        }

        private void zespolone_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rzeczywiste_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void zaokraglanie_ValueChanged(object sender, EventArgs e)
        {
            dokladnoscZaokr = (ushort) zaokraglanie.Value;
            if (macierzX[0, 2].Value != null)
            {
                for (int i = 1; i <= N; i++)
                {
                    macierzX[0, i - 1].Value = Wypisz(X[i]);
                }
            }
        }

        private void wynik_Click_1(object sender, EventArgs e)
        {
            X = new Complex[N + 1];
            blad = RozRowMacGaussa(A, B, ref X, 1e-30);

            if (blad == 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    macierzX[0, i - 1].Value = Wypisz(X[i]);
                }
            }
            else
            {
                PiszKomunikat(blad);
            }

            wynik.Enabled = false;
        }
    }
}