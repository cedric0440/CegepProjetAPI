using Microsoft.AspNetCore.Mvc;
using APIGestionCegep.Logics.DTOs;
using APIGestionCegep.Logics.Modeles;
using APIGestionCegep.Logics.DAOs;
using APIGestionCegep.Logics.Controleurs;

namespace CegepProjetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnseignantController : Controller
    {
        [Route("/ObtenirListeEnseignant")]
        [HttpGet]
        public IEnumerable<EnseignantDTO> ObtenirListeEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                List<EnseignantDTO> enseignantDTO = CegepControleur.Instance.ObtenirListeEnseignant(nomCegep,nomDepartement);
                return enseignantDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("/ObtenirEnseignant")]
        [HttpGet]
        public EnseignantDTO ObtenirEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] int noEnseignant)
        {
            try
            {
                EnseignantDTO enseignantDTO = CegepControleur.Instance.ObtenirEnseignant(nomCegep, nomDepartement,noEnseignant);
                return enseignantDTO;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [Route("AjouterEnseignant")]
        [HttpPost]
        public void AjouterEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] EnseignantDTO enseignantDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterEnseignant(nomCegep, nomDepartement,enseignantDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ModifierEnseignant")]
        [HttpPost]
        public void ModifierEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] EnseignantDTO enseignantDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierEnseignant(nomCegep, nomDepartement,enseignantDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("SupprimerEnseignant")]
        [HttpPost]
        public void SupprimerEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] int noEnseignant)
        {
            try
            {
                CegepControleur.Instance.SupprimerEnseignant(nomCegep, nomDepartement,noEnseignant);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ViderListeEnseignant")]
        [HttpPost]
        public void ViderListeEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                CegepControleur.Instance.ViderListeEnseignant(nomCegep,nomDepartement);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
