using Microsoft.AspNetCore.Mvc;
using APIGestionCegep.Logics.DTOs;
using APIGestionCegep.Logics.Modeles;
using APIGestionCegep.Logics.DAOs;
using APIGestionCegep.Logics.Controleurs;
namespace CegepProjetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursController : Controller
    {
        [Route("/ObtenirListeCours")]
        [HttpGet]
        public IEnumerable<CoursDTO> ObtenirListeCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                List<CoursDTO> coursDTO = CegepControleur.Instance.ObtenirListeCours(nomCegep, nomDepartement);
                return coursDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("/ObtenirCours")]
        [HttpGet]
        public CoursDTO ObtenirCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] string nomCours)
        {
            try
            {
                CoursDTO coursDTO = CegepControleur.Instance.ObtenirCours(nomCegep, nomDepartement, nomCours);
                return coursDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("AjouterCours")]
        [HttpPost]
        public void AjouterCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] CoursDTO coursDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterCours(nomCegep, nomDepartement, coursDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ModifierCours")]
        [HttpPost]
        public void ModifierCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] CoursDTO coursDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierCours(nomCegep, nomDepartement, coursDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("SupprimerCours")]
        [HttpPost]
        public void SupprimerCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] string nomCours)
        {
            try
            {
                CegepControleur.Instance.SupprimerCours(nomCegep, nomDepartement, nomCours);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ViderListeCours")]
        [HttpPost]
        public void ViderListeCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                CegepControleur.Instance.ViderListeCours(nomCegep, nomDepartement);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
