/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 26/11/2024
 * Time: 11:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BienesRaicesNoelia.Clases
{
	/// <summary>
	/// Description of Contrato.
	/// </summary>
	public class Contrato
	{
		private int idContrato;
		private Cliente cliente;
		private Terreno terreno;
		private float precioFinal;
		private string fecha;
		private List<Pago> pagos = new List<Pago>();
		
		public Contrato(Pago p, Cliente c, Terreno t)
		{
			idContrato = 1;
			cliente = c;
			terreno = t;
			precioFinal = 0.0f;
			fecha = "26/11/2024";
			
			int cant_pagos = 2;
			for(int i = 0; i < cant_pagos; i++){
				pagos.Add(p);
			}
		}
		
		public void Leer()
		{
			Console.WriteLine("");
			Console.WriteLine("INGRESE LOS DATOS DEL CONTRATO");
			bool sw = true;
			do{
				try {
					Console.Write("ID Contrato: ");
					idContrato = int.Parse(Console.ReadLine());
					if(idContrato <= 0){
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
					Console.Write("Precio Final: ");
					precioFinal = float.Parse(Console.ReadLine());
					if(precioFinal <= 0){
						throw new ArgumentException("El precio debe ser positivo");
					}
					sw = false;
				} catch (FormatException) {
					Console.WriteLine("Formato no válido");
				} catch (ArgumentException ex) {
					Console.WriteLine(ex.Message);
				}
			}while (sw);
			
			cliente.Leer();
			terreno.Leer();
		}
		
		public void Mostrar()
		{
			Console.WriteLine("");
			Console.WriteLine("DATOS DEL CONTRATO");
			Console.WriteLine("ID Contrato: " + idContrato);
			Console.WriteLine("Fecha: " + fecha);
			Console.WriteLine("Precio Final: $" + precioFinal);
			Console.WriteLine("Cantidad de Pagos: " + pagos.Count);
			for(int i = 0; i < pagos.Count; i++){
				Console.WriteLine("");
				Console.WriteLine("PAGO " + (i + 1));
				pagos[i].Mostrar();
			}
			cliente.Mostrar();
			terreno.Mostrar();
		}
		
		// Propiedades
		public int IDCONTRATO
		{
			get { return idContrato; }
			set {
				if(value <= 0)
					throw new ArgumentException("El ID debe ser positivo");
				idContrato = value;
			}
		}
		
		public float PRECIOFINAL
		{
			get { return precioFinal; }
			set {
				if(value <= 0)
					throw new ArgumentException("El precio debe ser positivo");
				precioFinal = value;
			}
		}
		
		public string FECHA
		{
			get { return fecha; }
			set { fecha = value; }
		}
		
		public Cliente CLIENTE
		{
			get { return cliente; }
			set { cliente = value; }
		}
		
		public Terreno TERRENO
		{
			get { return terreno; }
			set { terreno = value; }
		}
		
		public List<Pago> PAGOS
		{
			get { return pagos; }
			set { pagos = value; }
		}
	}
}
