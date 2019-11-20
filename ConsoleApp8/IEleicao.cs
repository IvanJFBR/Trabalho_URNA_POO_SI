interface IEleicao
{
    void criaCandidato(Candidato candidato);
    Candidato retornaCandidatos();
    void votar(Voto voto);
    Voto retornaVotos(Voto voto);
}