using System;

namespace TrackMobile.Models
{
    public class APPAppareil
    {
        public int IdappTypeEtalon { get; set; }
        public int IdappStatut { get; set; }
        public int IdappFamille { get; set; }
        public int IdappAppareil { get; set; }
        public string NumeroAppareil { get; set; }
        public string DesignationAppareil { get; set; }
        public string NumeroSerie { get; set; }
        public decimal Prix { get; set; }
        public decimal Amortissement { get; set; }
        public int TypeAmortissement { get; set; }
        public DateTime DateFutureOperation { get; set; }
        public string Remarque { get; set; }
        public int IdResponsable { get; set; }
        public string PeriodeGarantie { get; set; }
        public string SuiviAutomatique { get; set; }
        public string AuditCRE { get; set; }
        public DateTime AuditDCRE { get; set; }
        public string AuditMOD { get; set; }
        public DateTime AuditDMOD { get; set; }
        public string NumeroFacture { get; set; }
        public DateTime DateAcquisition { get; set; }
        public string MarqueAppareil { get; set; }
        public string ModeleAppareil { get; set; }
        public int TypeEtiquette { get; set; }
        public int IdenvSalle { get; set; }
        public DateTime DateDerniereOperation { get; set; }
        public string EnrARCHIVE { get; set; }
        public int IdenvService { get; set; }
        public int IdappDomaine { get; set; }
        public int TypeAppareil { get; set; }
        public int IdIndisponibilite { get; set; }
        public DateTime DateMiseEnService { get; set; }
        public string EnregistrementAppareil { get; set; }
        public string Declassement { get; set; }
        public int VerrouOperation { get; set; }
        public string NumeroExterneAppareil { get; set; }
        public string DateRenouvellement { get; set; }
        public decimal BudgetRenouvellement { get; set; }
        public int IdappCriticite { get; set; }
        public int NotifMail { get; set; }
        public string InfoEtiquette { get; set; }
        public string DateFinGarantie { get; set; }
        public int AlerteGarantie { get; set; }
        public int PropagationStatutSalle { get; set; }
        public string Champ01 { get; set; }
        public string Champ02 { get; set; }
        public string Champ03 { get; set; }
        public string Champ04 { get; set; }
        public string Champ05 { get; set; }
        public int DestinationAppareil { get; set; }
        public string NumeroSalle { get; set; }
        public string CodeService { get; set; }
        public int IdClient { get; set; }
        public int EnrVerrou { get; set; }
        public string AuditVERROU { get; set; }
        public string AuditDVERROU { get; set; }
        public int IdappSourceEnergie { get; set; }
        public int IdappSourcePrise { get; set; }
        public decimal PuissanceElectrique { get; set; }
        public string LocalisationPosition { get; set; }
        public int IdappType { get; set; }
        public string NumeroImmo { get; set; }
        public string NumeroCommande { get; set; }
        public string Reference { get; set; }
        public string Firmware { get; set; }
        public string Joker { get; set; }
        public string RemarqueHTML { get; set; }
    }
}
