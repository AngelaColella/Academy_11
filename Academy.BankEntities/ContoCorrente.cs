using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BankEntities
{
    public class ContoCorrente
    {
        private string numeroConto;
        private double saldo;
        private Cliente owner;

        public List<Movimento> Movimenti;

        public ContoCorrente()
        {
        }
        public ContoCorrente(Cliente owner)
        {
            this.owner = owner;
            // Movimenti = new List<Movimento>();
            // serve perchè è responsabilità di questa classe rendere List<Movimento> non nullo. 
            // se lo lasciassi qui avrei eccezione NullReferenceException
        }
        public ContoCorrente(string numeroConto)
        {
            this.numeroConto = numeroConto;
            saldo = 0;
        }
        public Cliente GetOwner()
        {
            return this.owner;
        }

        public string GetNumeroConto()
        {
            return numeroConto;
        }
        public double GetSaldo()
        {
            return saldo;
        }

        public double Deposita(double cifra)
        {
            saldo += cifra;
            Movimento deposito = new Movimento()
            {
                Tipo = TipoMovimento.Deposito,
                Importo = cifra,
                Data = DateTime.Now
            };

            Movimenti = new List<Movimento>();
            Movimenti.Add(deposito);
            return saldo;
        }

        public double Preleva(double cifra)
        {
            if (saldo >= cifra)
            {
                saldo -= cifra;

                //Movimenti.Add(new Movimento()
                //{
                //    Tipo = TipoMovimento.Prelievo,
                //    Importo = cifra,
                //    Data = DateTime.Now
                //});

                return saldo;
            }
            else
            {
                return -1; // così come ho costruito il programma, il saldo non può andare in negativo
            }
        }
        
        public double Bonifico(double cifra)
        {
            if (saldo >= cifra)
            {
                saldo -= cifra;

                //Movimenti.Add(new Movimento()
                //{
                //    Tipo = TipoMovimento.Prelievo,
                //    Importo = cifra,
                //    Data = DateTime.Now
                //});

                return saldo;
            }
            else
            {
                return -1; // così come ho costruito il programma, il saldo non può andare in negativo
            }
        }
        
    }
}
