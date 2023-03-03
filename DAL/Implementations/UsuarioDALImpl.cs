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
    public class UsuarioDALImpl : IUsuarioDAL
    {
        private CONSULTORIOContext context;
        public UsuarioDALImpl(CONSULTORIOContext _context)
        {
            context = _context;
        }
        public bool Add(Usuario entity)
        {
            try
            {

                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
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

        public void AddRange(IEnumerable<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Find(Expression<Func<Usuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            Usuario shipper;
            using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
            {
                shipper = unidad.genericDAL.Get(id);
            }
            return shipper;
        }

        public IEnumerable<Usuario> GetAll()
        {
            IEnumerable<Usuario> shippers;
            using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
            {
                shippers = unidad.genericDAL.GetAll();
            }
            return shippers;
        }

        public bool Remove(Usuario entity)
        {
            try
            {

                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
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

        public void RemoveRange(IEnumerable<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public Usuario SingleOrDefault(Expression<Func<Usuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario entity)
        {
            try
            {

                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
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
