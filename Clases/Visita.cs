/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Visita.
	/// </summary>
	public class Visita
	{
		private int idVisita;
		private string fechaVisita;
		private string estado;
		public Visita()
		{
			idVisita = 1;
			fechaVisita = "30/11/2024";
			estado = "Programada";
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DE LA VISITA");
			bool sw = true;
			do{
				try {
					Console.Write("ID Visita: ");
					idVisita = int.Parse(Console.ReadLine());
					if(idVisita <= 0){
						throw new ArgumentException("El ID debe ser positivo");
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
			Console.WriteLine("DATOS DE LA VISITA");
			Console.WriteLine("ID Visita: " + idVisita);
			Console.WriteLine("Fecha: " + fechaVisita);
			Console.WriteLine("Estado: " + estado);
		}
		
		// Propiedades
		public int IDVISITA
		{
			get { return idVisita; }
			set {
				if(value <= 0)
					throw new ArgumentException("El ID debe ser positivo");
				idVisita = value;
			}
		}
		
		public string FECHAVISITA
		{
			get { return fechaVisita; }
			set {
				if(DateTime.Parse(value) < DateTime.Now)
					throw new ArgumentException("La fecha no puede ser anterior a hoy");
				fechaVisita = value;
			}
		}
		
		public string ESTADO
		{
			get { return estado; }
			set {
				estado = value;
			}
		}
	}
}
