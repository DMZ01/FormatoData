using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_PDF.Models;

namespace Mvc_PDF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Aluno _alunoModel = new Aluno();
            _alunoModel = AlunoRegistros();
            return View(_alunoModel);
        }
        [HttpPost]
        public ActionResult Index(Aluno _alunoModel)
        {
            return View(_alunoModel);
        }

        public Aluno AlunoRegistros()
        {
            Aluno _oAlunoModel = new Aluno();
            _oAlunoModel.AlunoLista = new List<Aluno>();
            _oAlunoModel.AlunoLista.Add(new Aluno { Nome = "Stanislau", Classe = "#3A", Email = "judson@yahoo.com" });
            _oAlunoModel.AlunoLista.Add(new Aluno { Nome = "Jefferson", Classe = "#3B", Email = "jeff@uol.com.br" });
            _oAlunoModel.AlunoLista.Add(new Aluno { Nome = "Miria Estela", Classe = "#2F", Email = "mimi@hotmail.com" });
            _oAlunoModel.AlunoLista.Add(new Aluno { Nome = "Janice Rachel", Classe = "#1H", Email = "janjan@bol.com.br" });
            _oAlunoModel.AlunoLista.Add(new Aluno { Nome = "Jessica Lang", Classe = "#2D", Email = "jesslang@bol.com.br" });
            return _oAlunoModel;
        }
    }
}