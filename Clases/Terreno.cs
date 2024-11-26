/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Terreno.
	/// </summary>
	public class Terreno
	{
		private int idTerreno;
		private float superficie;
		private float precio;
		private string estado;
		private List<Visita> visitas = new List<Visita>();
		private Ubicacion ubicacion = new Ubicacion(); //COMPOSICIÓN
		
		public Terreno()
		{
			idTerreno = 1;
			superficie = 0.0f;
			precio = 0.0f;
			estado = "Disponible";
			
			int cant_visitas = 2;
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DEL TERRENO");
			bool sw = true;
			do{
				try {
					Console.Write("ID Terreno: ");
					idTerreno = int.Parse(Console.ReadLine());
					if(idTerreno <= 0){
						throw new ArgumentException("El ID debe ser positivo");
					}
					sw = false;
				} catch (FormatException) {
					Console.WriteLine("Formato no válido");
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			sw = true;
			do{
				try {
					Console.Write("Superficie (m2): ");
					superficie = float.Parse(Console.ReadLine());
					if(superficie <= 0){
						throw new ArgumentException("La superficie debe ser positiva");
					}
					sw = false;
				} catch (FormatException) {
					Console.WriteLine("Formato no válido");
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			sw = true;
			do{
				try {
					Console.Write("Precio: ");
					precio = float.Parse(Console.ReadLine());
					if(precio <= 0){
						throw new ArgumentException("El precio debe ser positivo");
					}
					sw = false;
				} catch (FormatException) {
					Console.WriteLine("Formato no válido");
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			sw = true;
			do{
				try {
					Console.Write("Estado (Disponible/Reservado/Vendido): ");
					estado = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(estado)){
						throw new ArgumentException("El estado no puede estar vacío");
					}
					sw = false;
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			ubicacion.Leer();
		}
		
		public void Mostrar()
		{
			Console.WriteLine("");
			Console.WriteLine("DATOS DEL TERRENO");
			Console.WriteLine("ID: " + idTerreno);
			Console.WriteLine("Superficie: " + superficie + " m2");
			Console.WriteLine("Precio: " + precio);
			Console.WriteLine("Estado: " + estado);
			Console.WriteLine("Cantidad de visitas: " + visitas.Count);
			for(int i = 0; i < visitas.Count; i++){
				Console.WriteLine("");
				Console.WriteLine("VISITA " + (i + 1));
				visitas[i].Mostrar();
			}
			ubicacion.Mostrar();
		}
		
		// Propiedades
		public int IDTERRENO
		{
			get { return idTerreno; }
			set {
				if(value <= 0)
					throw new ArgumentException("El ID debe ser positivo");
				idTerreno = value;
			}
		}
		
		public float SUPERFICIE
		{
			get { return superficie; }
			set {
				if(value <= 0)
					throw new ArgumentException("La superficie debe ser positiva");
				superficie = value;
			}
		}
		
		public float PRECIO
		{
			get { return precio; }
			set {
				if(value <= 0)
					throw new ArgumentException("El precio debe ser positivo");
				precio = value;
			}
		}
	}
}
