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
    public class CitaDALImpl : ICitaDAL
    {
        private CONSULTORIOContext context;
        public CitaDALImpl(CONSULTORIOContext _context)
        {
            context = _context;
        }
        public bool Add(Cita entity)
        {
            try
            {

                using (UnidadDeTrabajo<Cita> unidad = new UnidadDeTrabajo<Cita>(context))
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

        public void AddRange(IEnumerable<Cita> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cita> Find(Expression<Func<Cita, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Cita Get(int id)
        {
            Cita shipper;
            using (UnidadDeTrabajo<Cita> unidad = new UnidadDeTrabajo<Cita>(context))
            {
                shipper = unidad.genericDAL.Get(id);
            }
            return shipper;
        }

        public IEnumerable<Cita> GetAll()
        {
            IEnumerable<Cita> shippers;
            using (UnidadDeTrabajo<Cita> unidad = new UnidadDeTrabajo<Cita>(context))
            {
                shippers = unidad.genericDAL.GetAll();
            }
            return shippers;
        }

        public bool Remove(Cita entity)
        {
            try
            {

                using (UnidadDeTrabajo<Cita> unidad = new UnidadDeTrabajo<Cita>(context))
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

        public void RemoveRange(IEnumerable<Cita> entities)
        {
            throw new NotImplementedException();
        }

        public Cita SingleOrDefault(Expression<Func<Cita, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cita entity)
        {
            try
            {

                using (UnidadDeTrabajo<Cita> unidad = new UnidadDeTrabajo<Cita>(context))
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
