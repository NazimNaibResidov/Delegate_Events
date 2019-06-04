using Events_and_Delegate.Core;
using System;


namespace Events_and_Delegate.Model
{
    public delegate void EnteryHendler(object sender,EnteryArgs e);
   
   public class Pepole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private double vize;

        public double Vize
        {
            get { return vize; }
            set { vize = value; SituationControl(); }
        }

        private double final;

        public double Final
        {
            get { return final; }
            set { final = value;SituationControl(); }
        }

        public double Ortalama { get {return Vize * 0.4 + final * 0.6; } }
        public event EnteryHendler Kecdi;
        public event EnteryHendler Qaldi;
        void SituationControl()
        {
            if (Ortalama>=70)
            {
                if(Kecdi!=null)
                Kecdi(this, new EnteryArgs { NameSurname=Name+" "+Surname, Oratlama = Ortalama });
            }
            else
            {
                if(Qaldi!=null)
                Qaldi(this, new EnteryArgs { NameSurname = Name + " " + Surname, Oratlama = Ortalama });
            }
        }
        public override string ToString()
        {
            return Name + Surname ;
        }

    }
}
