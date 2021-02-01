using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetGo3.Models;

namespace ProjetGo3.Controllers
{
    public class ProjetsController : Controller
    {
        private DotNetAppSqlDb_projetGoEntities db = new DotNetAppSqlDb_projetGoEntities();

        // GET: Projets
        public ActionResult Index()
        {
            var projets = db.Projets.Include(p => p.Equipe);
            return View(projets.ToList());
        }

        // GET: Projets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projet projet = db.Projets.Find(id);
            if (projet == null)
            {
                return HttpNotFound();
            }
            return View(projet);
        }

        // GET: Projets/Create
        public ActionResult Create()
        {
            ViewBag.codeProjet = new SelectList(db.Equipes, "codeProjet", "codeAdherent");
            return View();
        }

        // POST: Projets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codeProjet,titreProjet,descriptionProjet,sommaireProjet,statutProjet,dateDebutEstimeeProjet,dateFinEstimeeProjet,echeancierProjet,budgetProjet,totalFondsCollectesProjet,totalDepensesProjet,dateDebutRelleProjet,dateFinRelleProjet,realisationCompleteesProjet,risquesProjet,etatAvancementProjet,codeAdherentProposeProjet,codeAdherentCoopteProjet")] Projet projet)
        {
            if (ModelState.IsValid)
            {
                db.Projets.Add(projet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.codeProjet = new SelectList(db.Equipes, "codeProjet", "codeAdherent", projet.codeProjet);
            return View(projet);
        }

        // GET: Projets/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projet projet = db.Projets.Find(id);
            if (projet == null)
            {
                return HttpNotFound();
            }
            ViewBag.codeProjet = new SelectList(db.Equipes, "codeProjet", "codeAdherent", projet.codeProjet);
            return View(projet);
        }

        // POST: Projets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codeProjet,titreProjet,descriptionProjet,sommaireProjet,statutProjet,dateDebutEstimeeProjet,dateFinEstimeeProjet,echeancierProjet,budgetProjet,totalFondsCollectesProjet,totalDepensesProjet,dateDebutRelleProjet,dateFinRelleProjet,realisationCompleteesProjet,risquesProjet,etatAvancementProjet,codeAdherentProposeProjet,codeAdherentCoopteProjet")] Projet projet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.codeProjet = new SelectList(db.Equipes, "codeProjet", "codeAdherent", projet.codeProjet);
            return View(projet);
        }

        // GET: Projets/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projet projet = db.Projets.Find(id);
            if (projet == null)
            {
                return HttpNotFound();
            }
            return View(projet);
        }

        // POST: Projets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Projet projet = db.Projets.Find(id);
            db.Projets.Remove(projet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
