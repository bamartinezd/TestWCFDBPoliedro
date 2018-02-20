namespace TestWCFDBPoliedro.Infraestructura.ActivaDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXTRANET.ACTIVACIONPRE")]
    public partial class ACTIVACIONPRE
    {
        [StringLength(5)]
        public string SALUDO { get; set; }

        [StringLength(40)]
        public string NOMBRES { get; set; }

        [StringLength(40)]
        public string APELLIDO { get; set; }

        [StringLength(20)]
        public string NUMERO_DOCUMENTO { get; set; }

        [StringLength(20)]
        public string TELEFONO { get; set; }

        [StringLength(70)]
        public string DIRECCION { get; set; }

        [StringLength(40)]
        public string CIUDAD_DEPARTAMENTO { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ICCID { get; set; }

        [StringLength(15)]
        public string IMEI { get; set; }

        public decimal? TECNOLOGIA { get; set; }

        [StringLength(24)]
        public string CODIGO_DISTRIBUIDOR { get; set; }

        [StringLength(20)]
        public string USUARIO { get; set; }

        public decimal? TMCODE { get; set; }

        public decimal? SPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CODMIN { get; set; }

        [StringLength(30)]
        public string HLR { get; set; }

        [StringLength(10)]
        public string GRUPO_CLIENTES { get; set; }

        [StringLength(30)]
        public string CENTRO_COSTO { get; set; }

        [StringLength(40)]
        public string SECTOR_COMERCIAL { get; set; }

        [StringLength(2)]
        public string EFECTIVO { get; set; }

        public DateTime? FECREGIS { get; set; }

        public DateTime? FECBSCS { get; set; }

        public DateTime? FECIN { get; set; }

        [StringLength(10)]
        public string CARGA { get; set; }

        [StringLength(5)]
        public string VIGENCIA { get; set; }

        public decimal? MO { get; set; }

        public decimal? RESN { get; set; }

        public decimal? RTAR { get; set; }

        [StringLength(15)]
        public string ESTADO { get; set; }

        [StringLength(15)]
        public string ESTADOIN { get; set; }

        public decimal? CO_ID { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        [StringLength(20)]
        public string TEXT1 { get; set; }

        [StringLength(20)]
        public string TEXT2 { get; set; }

        [StringLength(20)]
        public string TEXT3 { get; set; }

        public DateTime? FECHA1 { get; set; }

        public DateTime? FECHA2 { get; set; }

        [StringLength(15)]
        public string ESTADOMO { get; set; }

        public DateTime? FECMO { get; set; }

        [StringLength(100)]
        public string NOMBRE_EQUIPO { get; set; }

        public decimal? ID_ACTIVACION { get; set; }

        [StringLength(50)]
        public string PLANILLA { get; set; }

        public DateTime? FECPLANILLA { get; set; }

        [StringLength(50)]
        public string INDICATIVO { get; set; }

        [StringLength(50)]
        public string TIPO_DOCUMENTO { get; set; }

        [StringLength(50)]
        public string SEXO { get; set; }

        [StringLength(100)]
        public string BARRIO { get; set; }

        [StringLength(15)]
        public string ID_VENDEDOR { get; set; }

        public DateTime? FECHA_VENTA { get; set; }

        [StringLength(200)]
        public string GENERAR_TICKLER { get; set; }

        public bool? ACTUALIZACION_BDO { get; set; }
    }
}
