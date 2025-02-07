using Microsoft.AspNetCore.Mvc;
using APIGestionCegep.Logics.DTOs;
using APIGestionCegep.Logics.Modeles;
using APIGestionCegep.Logics.DAOs;
using APIGestionCegep.Logics.Controleurs;

namespace CegepProjetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartementController : Controller
    {
        [Route("/ObtenirListeDepartements")]
        [HttpGet]
        public IEnumerable<DepartementDTO> ObtenirListeDepartements([FromQuery] string nomCegep)
        {
            try
            {
                List<DepartementDTO> departementDTOs = CegepControleur.Instance.ObtenirListeDepartement(nomCegep);
                return departementDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("/ObtenirDepartement")]
        [HttpGet]
        public DepartementDTO ObtenirDepartement([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                DepartementDTO departementDTO = CegepControleur.Instance.ObtenirDepartement(nomCegep,nomDepartement);
                return departementDTO;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [Route("AjouterDepartement")]
        [HttpPost]
        public void AjouterDepartement([FromQuery] string nomCegep, [FromBody] DepartementDTO departementDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterDepartement(nomCegep,departementDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ModifierDepartement")]
        [HttpPost]
        public void ModifierDepartement([FromQuery] string nomCegep, [FromBody] DepartementDTO departementDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierDepartement(nomCegep,departementDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("SupprimerDepartement")]
        [HttpPost]
        public void SupprimerDepartement([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            try
            {
                CegepControleur.Instance.SupprimerDepartement(nomCegep,nomDepartement);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ViderListeDepartement")]
        [HttpPost]
        public void ViderListeDepartement([FromQuery] string nomCegep)
        {
            try
            {
                CegepControleur.Instance.ViderListeDepartement(nomCegep);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
