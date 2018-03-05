using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestWCFDBPoliedro.Application.ServicesRest.Models
{
    public class ContractAllModel
    {
        [Key]
        [Column(Order = 0)]
        public decimal CO_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal CUSTOMER_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal REC_VERSION { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }

        public decimal? OHXACT { get; set; }

        public decimal? PLCODE { get; set; }

        public decimal? SCCODE { get; set; }

        public decimal? SUBM_ID { get; set; }

        public DateTime? CO_SIGNED { get; set; }

        [StringLength(20)]
        public string CO_EQU_TYPE { get; set; }

        [StringLength(40)]
        public string CO_REP_BILL { get; set; }

        [StringLength(40)]
        public string CO_REP { get; set; }

        [StringLength(30)]
        public string CO_REP_BILL_IDNO { get; set; }

        [StringLength(30)]
        public string CO_REP_IDNO { get; set; }

        public DateTime? CO_INSTALLED { get; set; }

        [StringLength(1)]
        public string CO_ITEMIZED_BILL { get; set; }

        public decimal? CO_IB_CATEGORIES { get; set; }

        [Column(TypeName = "float")]
        public decimal? CO_IB_THRESHOLD { get; set; }

        [StringLength(1)]
        public string CO_ARCHIVE { get; set; }

        [StringLength(1)]
        public string CO_DIR_ENTRY { get; set; }

        [StringLength(1)]
        public string CO_OPERATOR_DIR { get; set; }

        [StringLength(1)]
        public string CO_PSTN_DIR { get; set; }

        [StringLength(1)]
        public string CO_CALLS_ANONYM { get; set; }

        [StringLength(1)]
        public string CO_ASS_SERV { get; set; }

        [StringLength(1)]
        public string CO_ASS_EQU { get; set; }

        [StringLength(1)]
        public string CO_ASS_CBB { get; set; }

        [StringLength(1)]
        public string CO_CRD_CHECK { get; set; }

        public DateTime? CO_CRD_CHK_END { get; set; }

        public DateTime? CO_CRD_CHK_START { get; set; }

        public decimal? CO_CRD_CLICKS { get; set; }

        public decimal? CO_CRD_CLICKS_DAY { get; set; }

        public decimal? CO_CRD_DAYS { get; set; }

        [StringLength(60)]
        public string CO_COMMENT { get; set; }

        [Column(TypeName = "float")]
        public decimal? CO_DURATION { get; set; }

        public DateTime? CO_RESERVED { get; set; }

        public DateTime? CO_EXPIR_DATE { get; set; }

        public DateTime? CO_ACTIVATED { get; set; }

        public DateTime? CO_ENTDATE { get; set; }

        public DateTime? CO_MODDATE { get; set; }

        [StringLength(16)]
        public string CO_USERLASTMOD { get; set; }

        [StringLength(1)]
        public string CO_TOLLRATING { get; set; }

        public decimal? TMCODE { get; set; }

        public DateTime? TMCODE_DATE { get; set; }

        public decimal? CO_CRD_D_TR1 { get; set; }

        public decimal? CO_CRD_D_TR2 { get; set; }

        public decimal? CO_CRD_D_TR3 { get; set; }

        public decimal? CO_CRD_P_TR1 { get; set; }

        public decimal? CO_CRD_P_TR2 { get; set; }

        public decimal? CO_CRD_P_TR3 { get; set; }

        public decimal? IXCODE { get; set; }

        public decimal? PENDING_IXCODE { get; set; }

        public decimal? CO_REQUEST { get; set; }

        [StringLength(2000)]
        public string CO_INPREPAY { get; set; }

        [StringLength(2000)]
        public string CO_INPREPAY_PENDING { get; set; }

        public DateTime? MAKE_CALLS_DATE { get; set; }
    }
}