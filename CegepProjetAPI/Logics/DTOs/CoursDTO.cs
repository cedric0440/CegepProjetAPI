﻿using APIGestionCegep.Logics.Modeles;

/// <summary>
/// Namespace pour les objets de type DTO.
/// </summary>
namespace APIGestionCegep.Logics.DTOs
{
    /// <summary>
    /// Classe de DTO pour le cours.
    /// </summary>
    public class CoursDTO
    {
        #region Proprietes
        /// <summary>
        /// Propriété représentant le no du cours.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// Propriété représentant le nom du cours.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Propriété représentant la description du cours.
        /// </summary>
        public string Description { get; set; }

        #endregion Proprietes

        #region Constructeurs

		public CoursDTO(){}
		
        /// <summary>
        /// Constructeur avec paramètres.
        /// </summary>
        /// <param name="no">No du cours.</param>
        /// <param name="nom">Nom du cours.</param>
        /// <param name="description">Description du cours.</param>
        public CoursDTO(string no = "", string nom = "", string description = "")
        {
            No = no;
            Nom = nom;
            Description = description;
        }

        /// <summary>
        /// Constructeur avec le modèle Cours en paramètre.
        /// </summary>
        /// <param name="leCours">L'objet du modèle Cours.</param>
        public CoursDTO(Cours leCours)
        {
            No = leCours.No;
            Nom = leCours.Nom;
            Description = leCours.Description;
        }

        #endregion Constructeurs
    }
}
