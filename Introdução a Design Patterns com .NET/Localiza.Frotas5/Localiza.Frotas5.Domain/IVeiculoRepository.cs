﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Frotas5.Domain
{
    public interface IVeiculoRepository
    {
        Veiculo GetById(Guid id);
        IEnumerable<Veiculo> GetAll();
        void Add(Veiculo veiculo);  
        void Update(Veiculo veiculo); 
        void Delete(Veiculo veiculo);
    }
}
