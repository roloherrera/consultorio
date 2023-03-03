using DAL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class HorarioDALImpl : IHorarioDAL
    {
        private CONSULTORIOContext context;
        public HorarioDALImpl(CONSULTORIOContext _context)
        {
            context = _context;
        }
        public bool Add(Horario entity)
        {
            try
            {

                using (UnidadDeTrabajo<Horario> unidad = new UnidadDeTrabajo<Horario>(context))
                {
                    unidad.genericDAL.Add(entity);
                    unidad.Complete();
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public void AddRange(IEnumerable<Horario> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Horario> Find(Expression<Func<Horario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Horario Get(int id)
        {
            Horario shipper;
            using (UnidadDeTrabajo<Horario> unidad = new UnidadDeTrabajo<Horario>(context))
            {
                shipper = unidad.genericDAL.Get(id);
            }
            return shipper;
        }

        public IEnumerable<Horario> GetAll()
        {
            IEnumerable<Horario> shippers;
            using (UnidadDeTrabajo<Horario> unidad = new UnidadDeTrabajo<Horario>(context))
            {
                shippers = unidad.genericDAL.GetAll();
            }
            return shippers;
        }

        public bool Remove(Horario entity)
        {
            try
            {

                using (UnidadDeTrabajo<Horario> unidad = new UnidadDeTrabajo<Horario>(context))
                {
                    unidad.genericDAL.Remove(entity);
                    unidad.Complete();
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public void RemoveRange(IEnumerable<Horario> entities)
        {
            throw new NotImplementedException();
        }

        public Horario SingleOrDefault(Expression<Func<Horario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Horario entity)
        {
            try
            {

                using (UnidadDeTrabajo<Horario> unidad = new UnidadDeTrabajo<Horario>(context))
                {
                    unidad.genericDAL.Update(entity);
                    unidad.Complete();
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
