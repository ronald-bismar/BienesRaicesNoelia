/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 09:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of EmpresaTerrenos.
	/// </summary>
	public class EmpresaTerrenos
	{
		private string nombre;
		private string direccion;
		private List<Terreno> terrenos;
		private List<Agente> agentes;
		private List<Contrato> contratos;

		public EmpresaTerrenos(Terreno t, Agente a, Contrato co)
		{
			nombre = "Bienes Raíces Noelia";
			direccion = "Av. Principal #123";

			int cant_terrenos = 2, cant_agentes = 2, cant_contratos = 2;
			terrenos = new List<Terreno>();
			for(int i = 0; i < cant_terrenos; i++){
				terrenos.Add(t);
			}
			agentes = new List<Agente>();
			for(int i = 0; i < cant_agentes; i++){
				agentes.Add(a);
			}
			contratos = new List<Contrato>();
			for(int i = 0; i < cant_contratos; i++){
				contratos.Add(co);
			}
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INTRODUZCA LOS DATOS DE LA EMPRESA");
			bool sw = true;
			do{
				try {
					Console.Write("Nombre de la Empresa: ");
					nombre = Console.ReadLine();
					if(string.IsNullOrWhiteSpace(nombre)){
						throw new ArgumentException("El nombre no puede estar vacío");
					}
					sw = false;
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
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
		}
		
		public void Mostrar()
		{
			Console.WriteLine("");
			Console.WriteLine("DATOS DE LA EMPRESA");
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Dirección: " + direccion);
			Console.WriteLine("Cantidad de Terrenos: " + terrenos.Count);
			for(int i = 0; i < terrenos.Count; i++){
				Console.WriteLine("");
				Console.WriteLine("TERRENO " + (i + 1));
				terrenos[i].Mostrar();
			}
			Console.WriteLine("Cantidad de Agentes: " + agentes.Count);
			for(int i = 0; i < agentes.Count; i++){
				Console.WriteLine("");
				Console.WriteLine("AGENTE " + (i + 1));
				agentes[i].Mostrar();
			}
			Console.WriteLine("Cantidad de Contratos: " + contratos.Count);
			for(int i = 0; i < contratos.Count; i++){
				Console.WriteLine("");
				Console.WriteLine("CONTRATO " + (i + 1));
				contratos[i].Mostrar();
			}
		}
		
		// Propiedades
		public string NOMBRE
		{
			get { return nombre; }
			set {
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("El nombre no puede estar vacío");
				nombre = value;
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
		
		public List<Terreno> TERRENOS
		{
			get { return terrenos; }
			set { terrenos = value; }
		}
		
		public List<Agente> AGENTES
		{
			get { return agentes; }
			set { agentes = value; }
		}
		
		public List<Contrato> CONTRATOS
		{
			get { return contratos; }
			set { contratos = value; }
		}
	}
}
