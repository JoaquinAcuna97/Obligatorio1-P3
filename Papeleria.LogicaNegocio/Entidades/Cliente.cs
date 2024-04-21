using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.ValueObject;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Cliente : IValidable<Cliente>
	{
        #region Properties
        public int Id { get; set; }

		public long RUT { get; set; }

        public string RazonSocial { get; set; }

        public Direccion Direccion { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public double TotalAcumulado { get; set; }
        #endregion

        #region Constructors
        public Cliente(int id, long rUT, string razonSocial, Direccion direccion, List<Usuario> usuarios, double totalAcumulado)
        {
            this.Id = id;
            this.RUT = rUT;
            this.RazonSocial = razonSocial;
            this.Direccion = direccion;
            this.Usuarios = usuarios;
            this.TotalAcumulado = totalAcumulado;
        }

        public Cliente() { }
        #endregion

        #region Methods
        public void EsValido()
        {
			//TODO: Validaciones necesarias
        }
        #endregion
    }

}

