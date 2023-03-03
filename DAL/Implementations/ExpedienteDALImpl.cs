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
    public class ExpedienteDALImpl : IExpedienteDAL
    {
        private CONSULTORIOContext context;
        public ExpedienteDALImpl(CONSULTORIOContext _context)
        {
            context = _context;
        }
        public bool Add(Expediente entity)
        {
            try
            {

                using (UnidadDeTrabajo<Expediente> unidad = new UnidadDeTrabajo<Expediente>(context))
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

        public void AddRange(IEnumerable<Expediente> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expediente> Find(Expression<Func<Expediente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Expediente Get(int id)
        {
            Expediente shipper;
            using (UnidadDeTrabajo<Expediente> unidad = new UnidadDeTrabajo<Expediente>(context))
            {
                shipper = unidad.genericDAL.Get(id);
            }
            return shipper;
        }

        public IEnumerable<Expediente> GetAll()
        {
            IEnumerable<Expediente> shippers;
            using (UnidadDeTrabajo<Expediente> unidad = new UnidadDeTrabajo<Expediente>(context))
            {
                shippers = unidad.genericDAL.GetAll();
            }
            return shippers;
        }

        public bool Remove(Expediente entity)
        {
            try
            {

                using (UnidadDeTrabajo<Expediente> unidad = new UnidadDeTrabajo<Expediente>(context))
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

        public void RemoveRange(IEnumerable<Expediente> entities)
        {
            throw new NotImplementedException();
        }

        public Expediente SingleOrDefault(Expression<Func<Expediente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Expediente entity)
        {
            try
            {

                using (UnidadDeTrabajo<Expediente> unidad = new UnidadDeTrabajo<Expediente>(context))
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
