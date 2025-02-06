using Microsoft.AspNetCore.Mvc;
using APIGestionCegep.Logics.DTOs;
using APIGestionCegep.Logics.Modeles;
using APIGestionCegep.Logics.DAOs;
using APIGestionCegep.Logics.Controleurs;

namespace CegepProjetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CegepController : ControllerBase
    {
        [Route("/ObtenirListeCegeps")]
        [HttpGet]
        public IEnumerable<CegepDTO>ObtenirListeCegep()
        {
            try
            {
                List<CegepDTO> cegepDTOs = CegepControleur.Instance.ObtenirListeCegep();
                return cegepDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("/ObtenirCegep")]
        [HttpGet]
        public CegepDTO ObtenirCegep([FromQuery]string nomCegep)
        {
            try
            {
                CegepDTO cegepDTO = CegepControleur.Instance.ObtenirCegep(nomCegep);
                return cegepDTO;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [Route("AjouterCegep")]
        [HttpPost]
        public void AjouterCegep([FromBody] CegepDTO cegepDTO)
        {
            try
            {
                CegepControleur.Instance.AjouterCegep(cegepDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ModifierCegep")]
        [HttpPost]
        public void ModifierCegep([FromBody] CegepDTO cegepDTO)
        {
            try
            {
                CegepControleur.Instance.ModifierCegep(cegepDTO);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("SupprimerCegep")]
        [HttpPost]
        public void SupprimerCegep([FromQuery] string nomCegep)
        {
            try
            {
                CegepControleur.Instance.SupprimerCegep(nomCegep);
            }
            catch (Exception ex)
            {
            }
        }

        [Route("ViderListeCegep")]
        [HttpPost]
        public void ViderListeCegep()
        {
            try
            {
                CegepRepository.Instance.ViderListeCegep();
            }
            catch (Exception ex)
            {
            }
        }
    }
}


