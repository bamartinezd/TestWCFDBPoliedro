namespace TestWCFDBPoliedro.Infraestructura.ActivaDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXTRANET.SERVICIOS")]
    public partial class SERVICIOS
    {
        [StringLength(20)]
        public string CODDISTRI { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MINENTRA { get; set; }

        [StringLength(10)]
        public string MINSALE { get; set; }

        [StringLength(50)]
        public string ESNENTRA { get; set; }

        [StringLength(50)]
        public string ESNSALE { get; set; }

        [StringLength(50)]
        public string PLANENTRA { get; set; }

        [StringLength(50)]
        public string PLANSALE { get; set; }

        [StringLength(1)]
        public string TIPOSERVICIO { get; set; }

        [StringLength(50)]
        public string CAUSAL { get; set; }

        [StringLength(50)]
        public string NROSERVICIO { get; set; }

        [StringLength(1)]
        public string DENUNCIA { get; set; }

        [StringLength(10)]
        public string ESTADO { get; set; }

        public DateTime? FECREGIS { get; set; }

        [StringLength(50)]
        public string EQUIPO { get; set; }

        public int? VR_EQUIPO { get; set; }

        public int? IVA_EQUIPO { get; set; }

        [StringLength(1)]
        public string COMSEGURO { get; set; }

        [StringLength(1)]
        public string GARANTIA { get; set; }

        [StringLength(50)]
        public string TEXT1 { get; set; }

        [StringLength(50)]
        public string TEXT2 { get; set; }

        [StringLength(50)]
        public string TEXT3 { get; set; }

        [StringLength(50)]
        public string TEXT4 { get; set; }

        [StringLength(50)]
        public string TEXT5 { get; set; }

        public DateTime? FECHA1 { get; set; }

        [StringLength(1)]
        public string COSTO { get; set; }

        [StringLength(1)]
        public string SCCODE { get; set; }

        [StringLength(2)]
        public string CLAUSULA { get; set; }

        public int? ID_PAGO { get; set; }

        public int? ID_SERVICIOS { get; set; }

        [StringLength(50)]
        public string PLANILLA { get; set; }

        public DateTime? FECPLANILLA { get; set; }

        [StringLength(50)]
        public string ICCID_ANTERIOR { get; set; }

        [StringLength(50)]
        public string IMEI_ANTERIOR { get; set; }

        [StringLength(50)]
        public string ICCID_NUEVO { get; set; }

        [StringLength(50)]
        public string IMEI_NUEVO { get; set; }

        [StringLength(50)]
        public string TRAJO_SIM { get; set; }

        [StringLength(50)]
        public string TRAJO_EQUIPO { get; set; }

        [StringLength(30)]
        public string TIPO_ACTIVACION { get; set; }

        [StringLength(50)]
        public string CUSTCODE { get; set; }

        [StringLength(50)]
        public string COD_USUARIO { get; set; }

        [StringLength(1)]
        public string CONEXION_SAP { get; set; }

        public decimal? ID_REPOSICION { get; set; }

        public decimal? ID_PERFIL { get; set; }

        public int? ENTREGA_FACTURA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_FACT_ELECT { get; set; }

        [StringLength(50)]
        public string CO_ID { get; set; }

        [StringLength(10)]
        public string PERM_PEND { get; set; }

        [StringLength(2)]
        public string IND_USUCPS { get; set; }

        public DateTime? FECHA_REAL { get; set; }
    }
}
