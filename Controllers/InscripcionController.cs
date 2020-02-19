using _1erParcialAplicada2.Data;
using _1erParcialAplicada2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1erParcialAplicada2.Controllers
{
    public class InscripcionController
    {
        public static bool Guardar(Inscripciones inscripcion )
        {
            bool paso=false;
            Contexto contexto = new Contexto();

            try
            {
               
                contexto.Inscripciones.Add(inscripcion);
                if (contexto.SaveChanges()>0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            contexto.Dispose();
            return paso;
        }

        public static bool Modificar(Inscripciones inscripcion)
        {
            Contexto c = new Contexto();
            bool paso = false;
            try
            {
                if (c.Entry(inscripcion).State == EntityState.Modified)
                {
                    paso = c.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            c.Dispose();
            return paso;
        }

        public Inscripciones Buscar(int id)
        {
            Inscripciones ins;
            Contexto c = new Contexto();
            try
            {
                
                ins = c.Inscripciones.Find(id);
                c.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            c.Dispose();
            return ins;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Ins
            Contexto c = new Contexto();
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
            c.Dispose();
            return paso;
        }
            
        
    }
}
