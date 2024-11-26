/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Pago.
	/// </summary>
	public class Pago
	{
		private int idPago;
		private float monto;
		private string fecha;
		
		public Pago()
		{
			idPago = 1;
			monto = 0.0f;
			fecha = "26/11/2024";
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DEL PAGO");
			bool sw = true;
			do{
				try {
					Console.Write("ID Pago: ");
					idPago = int.Parse(Console.ReadLine());
					if(idPago <= 0){
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
					Console.Write("Monto: ");
					monto = float.Parse(Console.ReadLine());
					if(monto <= 0){
						throw new ArgumentException("El monto debe ser positivo");
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
			Console.WriteLine("DATOS DEL PAGO");
			Console.WriteLine("ID Pago: " + idPago);
			Console.WriteLine("Monto: " + monto);
			Console.WriteLine("Fecha: " + fecha);
		}
		
		// Propiedades
		public int IDPAGO
		{
			get { return idPago; }
			set {
				if(value <= 0)
					throw new ArgumentException("El ID debe ser positivo");
				idPago = value;
			}
		}
		
		public float MONTO
		{
			get { return monto; }
			set {
				if(value <= 0)
					throw new ArgumentException("El monto debe ser positivo");
				monto = value;
			}
		}
		
		public string FECHA
		{
			get { return fecha; }
				set {
				if(DateTime.Parse(value) < DateTime.Now)
					throw new ArgumentException("La fecha no puede ser anterior a hoy");
				fecha = value;
			}	
		}
	}
}
