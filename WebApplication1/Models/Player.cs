using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Player
    {
		private int ID;

		public int id
		{
			get { return ID; }
			set { ID = value; }
		}

		private string Nome;

		public string nome
		{
			get { return Nome; }
			set { Nome = value; }
		}


		private string Classe;

		public string classe
		{
			get { return Classe; }
			set { Classe = value; }
		}

		private string Login;

		public string login
		{
			get { return Login; }
			set { Login = value; }
		}

		private string Senha;

		public string senha
		{
			get { return Senha; }
			set { Senha = value; }
		}


	}
}