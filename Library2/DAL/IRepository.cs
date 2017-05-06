using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2.DAL
{
    interface IRepository<T> where T:class
    {
        //kombinowanie czy nie lepiej jeden interfejs dla repozytoriow?
    }
}
