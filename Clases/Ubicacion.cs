/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Ubicacion.
	/// </summary>
	public class Ubicacion
	{
		private int idUbicacion;
		private string direccion;
		private string ciudad;
		private string zona;
		public Ubicacion()
		{
			idUbicacion = 1;
			direccion = "";
			ciudad = "";
			zona = "";
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DE UBICACIÓN");

			bool sw = true;
			do{
				try {
					Console.Write("ID Ubicación: ");
					idUbicacion = int.Parse(Console.ReadLine());
					sw = false;
				} catch (OverflowException) {
					Console.WriteLine("Valor fuera de rango");
				}
			}while (sw);

			sw = true;
			do{
				try {
					Console.Write("Dirección: ");
					direccion = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(direccion)){
						throw new ArgumentException("La dirección no puede estar vacía");
					}
					sw = false;
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			sw = true;
			do{
				try {
					Console.Write("Ciudad: ");
					ciudad = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(ciudad)){
						throw new ArgumentException("La ciudad no puede estar vacía");
					}
					sw = false;
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			sw = true;
			do{
				try {
					Console.Write("Zona: ");
					zona = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(zona)){
						throw new ArgumentException("La zona no puede estar vacía");
					}
					sw = false;
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
		}
		
		public void Mostrar()
		{
			Console.WriteLine("");
			Console.WriteLine("DATOS DE UBICACIÓN");
			Console.WriteLine("ID Ubicación: " + idUbicacion);
			Console.WriteLine("Dirección: " + direccion);
			Console.WriteLine("Ciudad: " + ciudad);
			Console.WriteLine("Zona: " + zona);
		}
		

		// Propiedades

		public int IDUBICACION
		{
			get { return idUbicacion; }
			set { 
				if(value <= 0)
					throw new ArgumentException("El ID de ubicación no puede ser negativo");
				idUbicacion = value; 
			}
		}

		public string DIRECCION
		{
			get { return direccion; }
			set {
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("La dirección no puede estar vacía");
				direccion = value;
			}
		}
		
		public string CIUDAD
		{
			get { return ciudad; }
			set {
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("La ciudad no puede estar vacía");
				ciudad = value;
			}
		}
		
		public string ZONA
		{
			get { return zona; }
			set {
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("La zona no puede estar vacía");
				zona = value;
			}
		}
	}
}
