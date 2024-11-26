/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected int ci;
		protected string nombre;
		protected string apellido;
		protected int telefono;
		
		
		public Persona()
		{
			ci= 5434553;
			nombre = "Oscar";
			apellido = "Layme Garcia";
			telefono = 73045244;
		}
		
		protected void Leer(){
			Console.WriteLine("");
			Console.WriteLine("INTRODUZCA LOS DATOS DE LA PERSONA");
			bool sw = true;
			do{
				try {
					Console.Write("Nombre: ");
					nombre = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(nombre)){
						throw new ArgumentException();
					}
					sw = false;
				} catch (ArgumentException) {
					Console.WriteLine("El texto no puede estar vacio");
				}
			}while (sw);
			do{
				try {
					Console.Write("Apellido: ");
					apellido = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(apellido)){
						throw new ArgumentException();
					}
					sw = false;
				} catch (ArgumentException) {
					Console.WriteLine("El texto no puede estar vacio");
				}
			}while (sw);
			do{
				try {
					Console.Write("Ci: ");
					ci = int.Parse(Console.ReadLine());
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
					Console.Write("Telefono: ");
					telefono = int.Parse(Console.ReadLine());
					sw = false;
				} catch (OverflowException) {
					Console.WriteLine("Valor fuera de rango");
				}
				catch (FormatException) {
					Console.WriteLine("Error formato no valido");
				}
			}while (sw);
		}
		
		protected void Mostrar(){
			Console.WriteLine("");
			Console.WriteLine("DATOS DE LA PERSONA");
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Apellido: " + apellido);
			Console.WriteLine("Cedula de identidad: " + ci);
			Console.WriteLine("Telefono: " + telefono);
		}

		//Propiedades
		protected string NOMBRE{
			get {
				return nombre;
			}
			set{
				try {
					if(string.IsNullOrWhiteSpace(value)){
						throw new ArgumentNullException();
					}
					nombre = value;
				} catch (ArgumentNullException) {
					Console.WriteLine("El texto no puede estar vacio");
					throw;
				}catch (Exception){
					Console.WriteLine("Error en la lectura de datos");
				}
			}
		}
		protected string APELLIDO{
			get {
				return apellido;
			}
			set{
				try {
					if(string.IsNullOrWhiteSpace(value)){
						throw new ArgumentNullException();
					}
					apellido = value;
				} catch (ArgumentNullException) {
					Console.WriteLine("El texto no puede estar vacio");
					throw;
				}catch (Exception){
					Console.WriteLine("Error en la lectura de datos");
				}
			}
		}
		protected int CI{
			get {
				return ci;
			}
			set{
				if(value < int.MinValue || value > int.MaxValue){
					throw new OverflowException();
					throw new FormatException();
				}
				ci = value;
			}
		}
		protected int TELEFONO{
			get {
				return telefono;
			}
			set{
				if(value < int.MinValue || value > int.MaxValue){
					throw new OverflowException();
					throw new FormatException();
				}
				telefono = value;
			}
		}
	}
}
