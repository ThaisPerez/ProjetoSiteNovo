using ProWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProWebSite.Dao
{
    public class PessoaDao : DaoBase
    {
        public void Gravar(Pessoa objPessoa)
        {
            banco.Pessoas.Add(objPessoa);
            banco.SaveChanges();
        }
        public void Alterar(Pessoa objPessoa)
        {
            var entry = banco.Entry(objPessoa);
            banco.Set<Pessoa>().Attach(objPessoa);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }
        public Pessoa Buscar(int id)
        {
            return banco.Pessoas.FirstOrDefault(t => t.PessoaId == id);
        }
        public void Excluir(int id)
        {
            Pessoa objPessoa = Buscar(id);
            banco.Pessoas.Remove(objPessoa);
            banco.SaveChanges();
        }
        public IEnumerable<Pessoa> Buscar()
        {
            return banco.Pessoas.ToList();
        }
    }
}