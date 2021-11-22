using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotacionesEventos
{
    public class Votacion
    {
        public delegate void AlHaberEmpate();
        public delegate void AlHaberGanador(byte ganador);

        public event AlHaberEmpate VotacionEmpatada;
        public event AlHaberGanador VotacionGanada;

        private byte votosCandidato1 = 0;

        private byte votosCandidato2 = 0;

        public byte TotalVotos { get; private set; }
    

        public void IniciarVotacion()
        {
            TotalVotos = 0;
            votosCandidato1 = 0;
            votosCandidato2 = 0;
        }

        public void Votar(byte candidato)
        {
            if (candidato==1)
            {
                votosCandidato1++;
                TotalVotos++;
            }
            else if (candidato==2)
            {
                votosCandidato2++;
                TotalVotos++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Solo 1 o 2");
            }
            if (TotalVotos==30)
            {
                if (votosCandidato1==votosCandidato2)
                {
                    VotacionEmpatada?.Invoke();
                }
                else
                {
                    if (votosCandidato1>votosCandidato2)
                    {
                        VotacionGanada?.Invoke(1);
                    }
                    else
                    {
                        VotacionGanada?.Invoke(2);
                    }
                }
            }
        }
    }
}
