﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
	public interface IReproductor
	{
		void CargarDatosDeCancionActual();
		void Bloquear();
		void Desbloquear();
	}
}
