/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente: Persona
	{
		private int idCliente;
		private string tipo;
		
		public Cliente():base()
		{
			idCliente = 1;
			tipo = "Regular";
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DEL CLIENTE");
			base.Leer();
			bool sw = true;
			do{
				try {
					Console.Write("ID Cliente: ");
					idCliente = int.Parse(Console.ReadLine());
					sw = false;
				} catch (OverflowException) {
					Console.WriteLine("Valor fuera de rango");
				}
				catch (FormatException) {
					Console.WriteLine("Error formato no valido");
				}
			}while (sw);
			
			do{
				try {
					Console.Write("Tipo de Cliente: ");
					tipo = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(tipo)){
						throw new ArgumentException();
					}
					sw = false;
				} catch (ArgumentException) {
					Console.WriteLine("El texto no puede estar vacio");
				}
			}while (sw);
		}
		
		public void Mostrar()
		{
			Console.WriteLine("");
			Console.WriteLine("DATOS DEL CLIENTE");
			base.Mostrar();
			Console.WriteLine("ID Cliente: " + idCliente);
			Console.WriteLine("Tipo: " + tipo);
		}
		
		// Propiedades
		public int IDCLIENTE
		{
			get { return idCliente; }
			set {
				if(value < 0){
					throw new ArgumentException("El ID no puede ser negativo");
				}
				idCliente = value;
			}
		}
		
		public string TIPO
		{
			get { return tipo; }
			set {
				try {
					if(string.IsNullOrWhiteSpace(value)){
						throw new ArgumentNullException();
					}
					tipo = value;
				} catch (ArgumentNullException) {
					Console.WriteLine("El tipo no puede estar vacío");
					throw;
				}
			}
		}
	}
}
