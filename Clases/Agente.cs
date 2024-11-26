/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Agente.
	/// </summary>
	public class Agente: Persona
	{
		private int idAgente;
		private float sueldo;
		private List<Terreno> terrenosAsignados;

		public Agente(Terreno t): base()
		{
			idAgente = 1;
			sueldo = 2000.0f;
			
			int cant_terrenos = 2;
			terrenosAsignados = new List<Terreno>();
			for(int i = 0; i < cant_terrenos; i++){
				terrenosAsignados.Add(t);
			}
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DEL AGENTE");
			base.Leer();
			bool sw = true;
			do{
				try {
					Console.Write("ID Agente: ");
					idAgente = int.Parse(Console.ReadLine());
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
					Console.Write("Sueldo: ");
					sueldo = float.Parse(Console.ReadLine());
					if(sueldo < 0){
						throw new ArgumentException("El sueldo no puede ser negativo");
					}
					sw = false;
				} catch (FormatException) {
					Console.WriteLine("Formato no válido");
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
		}
		
		public void Mostrar()
		{
			Console.WriteLine("");
			Console.WriteLine("DATOS DEL AGENTE");
			base.Mostrar();
			Console.WriteLine("ID Agente: " + idAgente);
			Console.WriteLine("Sueldo: " + sueldo);
			Console.WriteLine("Cantidad de Terrenos Asignados: " + terrenosAsignados.Count);
			for(int i = 0; i < terrenosAsignados.Count; i++){
				Console.WriteLine("");
				Console.WriteLine("TERRENO " + (i + 1));
				terrenosAsignados[i].Mostrar();
			}
		}
		
		// Propiedades
		public int IDAGENTE
		{
			get { return idAgente; }
			set {
				if(value < 0){
					throw new ArgumentException("El ID no puede ser negativo");
				}
				idAgente = value;
			}
		}
		
		public float SUELDO
		{
			get { return sueldo; }
			set {
				if(value < 0){
					throw new ArgumentException("El sueldo no puede ser negativo");
				}
				sueldo = value;
			}
		}
		
		public List<Terreno> TERRENOSASIGNADOS
		{
			get { return terrenosAsignados; }
			set { terrenosAsignados = value; }
		}
	}
}
