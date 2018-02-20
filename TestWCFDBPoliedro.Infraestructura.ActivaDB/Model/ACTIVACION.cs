namespace TestWCFDBPoliedro.Infraestructura.ActivaDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXTRANET.ACTIVACION")]
    public partial class ACTIVACION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SALUDO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NOMBRES { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string APELLIDO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(70)]
        public string DIRECCION { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CIUDAD_DEPARTAMENTO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string INDICATIVO { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string TELEFONO { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string TIPO_DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string NUMERO_DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string ESN { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string CODIGO_DISTRIBUIDOR { get; set; }

        [StringLength(50)]
        public string HLR { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string PLAN_TARIFAS { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string CODMIN { get; set; }

        public DateTime? FECHA_VENTA { get; set; }

        [StringLength(50)]
        public string PLANILLA_DISTIBUIDOR { get; set; }

        [StringLength(50)]
        public string VALOR_CFM { get; set; }

        [StringLength(50)]
        public string IVA_CFM { get; set; }

        [StringLength(50)]
        public string EQUIPO { get; set; }

        [StringLength(50)]
        public string IVA_EQUIPO { get; set; }

        [StringLength(50)]
        public string TOTAL_VENTA { get; set; }

        [StringLength(50)]
        public string NUMERO_CONTRATO { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string MODELO_EQUIPO { get; set; }

        [StringLength(50)]
        public string TIPO_CONTRATO { get; set; }

        [StringLength(50)]
        public string NO_INCLUSION_GUIA { get; set; }

        [StringLength(50)]
        public string COMBO { get; set; }

        [StringLength(50)]
        public string WIP { get; set; }

        [StringLength(50)]
        public string WAP { get; set; }

        [StringLength(50)]
        public string LID_WAP { get; set; }

        [StringLength(50)]
        public string COMSEGURO { get; set; }

        [StringLength(50)]
        public string ANDIASISTENCIA { get; set; }

        [StringLength(50)]
        public string OCUPACION_CLIENTE { get; set; }

        public DateTime? FECHA_NACIMIENTO { get; set; }

        [StringLength(50)]
        public string SEXO { get; set; }

        [StringLength(50)]
        public string SECTOR_COMERCIAL { get; set; }

        [StringLength(50)]
        public string GRUPO_CLIENTES { get; set; }

        [StringLength(50)]
        public string CENTRO_COSTO { get; set; }

        [StringLength(50)]
        public string EFECTIVO { get; set; }

        [StringLength(50)]
        public string TARJETA_CREDITO { get; set; }

        [StringLength(50)]
        public string COMPANIA_TC { get; set; }

        [StringLength(50)]
        public string NRO_TC { get; set; }

        [StringLength(50)]
        public string CUPO_TC { get; set; }

        [StringLength(50)]
        public string VENCE_TC { get; set; }

        [StringLength(50)]
        public string PRIMER_APELLIDO_CONYUGE { get; set; }

        [StringLength(50)]
        public string SEGUNDO_APELLIDO_CONYUGE { get; set; }

        [StringLength(50)]
        public string NOMBRE_CONYUGE { get; set; }

        [StringLength(50)]
        public string NUMERO_DOCUMENTO1 { get; set; }

        [StringLength(50)]
        public string EMPRESA_CONYUGE { get; set; }

        [StringLength(50)]
        public string DIRECCION_EMPRESA_CONYUGE { get; set; }

        [StringLength(50)]
        public string TELEFONO_CONYUGE { get; set; }

        [StringLength(50)]
        public string PROFESION_CONYUGE { get; set; }

        [StringLength(50)]
        public string EMPRESA_TRABAJO_CLIENTE { get; set; }

        [StringLength(50)]
        public string DIRECCION_EMPRESA { get; set; }

        [StringLength(50)]
        public string TELEFONO_EMPRESA { get; set; }

        public DateTime? FECHA_INGRESO { get; set; }

        [StringLength(50)]
        public string INGRESO_MENSUAL { get; set; }

        [StringLength(50)]
        public string ESTADO_CIVIL_CLIENTE { get; set; }

        [StringLength(50)]
        public string ACTIVIDAD_ECONOMICA { get; set; }

        [StringLength(50)]
        public string TIPO_VIVIENDA { get; set; }

        [StringLength(50)]
        public string REFERENCIA_PERSONAL { get; set; }

        [StringLength(50)]
        public string TELEFONO_REFERENCIA { get; set; }

        [StringLength(50)]
        public string NOMBRE_BANCO { get; set; }

        [StringLength(50)]
        public string SUCURSAL_BANCO { get; set; }

        [StringLength(50)]
        public string NUMERO_CUENTA { get; set; }

        [StringLength(50)]
        public string TARJETA_ENTIDAD { get; set; }

        [StringLength(50)]
        public string NUMERO_TC { get; set; }

        [StringLength(50)]
        public string TC_CUPO { get; set; }

        [StringLength(101)]
        public string RB_VENCIMIENTO_TC { get; set; }

        [StringLength(50)]
        public string TARJETA_TIPO { get; set; }

        [StringLength(50)]
        public string COLGAR_A_MAESTRA { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime FECREGIS { get; set; }

        public bool? RMIN { get; set; }

        public byte? RESN { get; set; }

        public byte? RTAR { get; set; }

        public byte? RDTC { get; set; }

        public byte? RCAR { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string LINEACT { get; set; }

        [StringLength(50)]
        public string LINEPORACT { get; set; }

        [StringLength(50)]
        public string MORACONCOM { get; set; }

        [StringLength(50)]
        public string TRAJO_EQUIPO { get; set; }

        [StringLength(50)]
        public string PLANILLA { get; set; }

        public DateTime? FECPLANILLA { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string CREDITO { get; set; }

        [StringLength(10)]
        public string SPCODE { get; set; }

        [StringLength(10)]
        public string TMCODE { get; set; }

        [StringLength(50)]
        public string DISTRIBUIDOR1 { get; set; }

        public decimal? CO_ID { get; set; }

        [StringLength(50)]
        public string CODMINEXT { get; set; }

        [StringLength(50)]
        public string COMSEGUROEXT { get; set; }

        [StringLength(50)]
        public string ANDIASISTENCIAEXT { get; set; }

        [StringLength(50)]
        public string ESNEXT { get; set; }

        [StringLength(50)]
        public string PLAN_TARIFASEXT { get; set; }

        [StringLength(50)]
        public string MODELO_EQUIPOEXT { get; set; }

        [StringLength(50)]
        public string VALOR_CFMEXT { get; set; }

        [StringLength(50)]
        public string IVA_CFMEXT { get; set; }

        [StringLength(50)]
        public string EQUIPOEXT { get; set; }

        [StringLength(50)]
        public string IVA_EQUIPOEXT { get; set; }

        [StringLength(50)]
        public string TOTAL_VENTAEXT { get; set; }

        [StringLength(10)]
        public string SPCODEEXT { get; set; }

        [StringLength(10)]
        public string TMCODEEXT { get; set; }

        [StringLength(50)]
        public string TEXT1 { get; set; }

        [StringLength(50)]
        public string TEXT2 { get; set; }

        [StringLength(80)]
        public string TEXT3 { get; set; }

        [StringLength(50)]
        public string TEXT4 { get; set; }

        [StringLength(50)]
        public string TEXT5 { get; set; }

        [StringLength(50)]
        public string TEXT6 { get; set; }

        [StringLength(50)]
        public string TEXT7 { get; set; }

        [StringLength(50)]
        public string TEXT8 { get; set; }

        [StringLength(50)]
        public string TEXT9 { get; set; }

        [StringLength(50)]
        public string TEXT10 { get; set; }

        public DateTime? FECHA1 { get; set; }

        public DateTime? FECHA2 { get; set; }

        public DateTime? FECHA3 { get; set; }

        public DateTime? FECBSCS { get; set; }

        public DateTime? FECHA4 { get; set; }

        public DateTime? FECHA5 { get; set; }

        public DateTime? FECHA6 { get; set; }

        [StringLength(50)]
        public string TEXT11 { get; set; }

        [StringLength(50)]
        public string TEXT12 { get; set; }

        [StringLength(200)]
        public string TEXT13 { get; set; }

        [StringLength(50)]
        public string TEXT14 { get; set; }

        [StringLength(50)]
        public string TEXT15 { get; set; }

        public decimal? SCCODE { get; set; }

        [StringLength(15)]
        public string IMEI { get; set; }

        public decimal? MENSAJES { get; set; }

        public decimal? DATOS { get; set; }

        public decimal? MMS { get; set; }

        [StringLength(15)]
        public string IP { get; set; }

        [StringLength(50)]
        public string TEXT16 { get; set; }

        [StringLength(50)]
        public string TEXT17 { get; set; }

        [StringLength(50)]
        public string VALOR_CARD { get; set; }

        [StringLength(50)]
        public string IVA_CARD { get; set; }

        [StringLength(15)]
        public string REVISTA { get; set; }

        [StringLength(50)]
        public string TRAJO_ICCID { get; set; }

        [StringLength(50)]
        public string TEXT18 { get; set; }

        [StringLength(50)]
        public string TEXT19 { get; set; }

        [StringLength(50)]
        public string TEXT20 { get; set; }

        public int? OCC { get; set; }

        [StringLength(50)]
        public string OBSERVACION { get; set; }

        public decimal? CONSECUTIVO { get; set; }

        [StringLength(50)]
        public string ILIMITADO { get; set; }

        [StringLength(50)]
        public string CFM_ANT { get; set; }

        [StringLength(50)]
        public string VRILIMITADO { get; set; }

        [StringLength(50)]
        public string IVAILIMITADO { get; set; }

        public short? PRODUCTO { get; set; }

        public byte? FIANZA { get; set; }

        public int? CUOTA_MENSUAL { get; set; }

        public int? VALOR_PAGAR { get; set; }

        public int? VALOR_PAGARSIM { get; set; }

        [StringLength(15)]
        public string IMEIOFQ { get; set; }

        [StringLength(50)]
        public string MODELO_EQUIPO_OFQ { get; set; }

        public int? ID_PAGO { get; set; }

        [StringLength(1)]
        public string CICLO_CORPORATIVO { get; set; }

        [StringLength(15)]
        public string ID_VENDEDOR { get; set; }

        [StringLength(100)]
        public string BARRIO { get; set; }

        [StringLength(15)]
        public string DIRECTORIO { get; set; }

        [StringLength(8)]
        public string PROMOCION { get; set; }

        [StringLength(1)]
        public string CONEXION_SAP { get; set; }

        [StringLength(50)]
        public string VALOR_EQUIPO_ESPECIAL { get; set; }

        [StringLength(50)]
        public string VALOR_IVA_EQUIPO_ESPECIAL { get; set; }

        [StringLength(50)]
        public string VALOR_ICCID_ESPECIAL { get; set; }

        [StringLength(50)]
        public string VALOR_IVA_ICCID_ESPECIAL { get; set; }

        [StringLength(15)]
        public string ID_CONSULTOR { get; set; }

        public DateTime? FECHA_PRIMERA_CARGA { get; set; }

        public int? ID_ACTIVACION { get; set; }

        [StringLength(4)]
        public string DIAS_PAGO_ORD_COMPRA { get; set; }

        [StringLength(11)]
        public string SERIAL_CDMA_TDMA { get; set; }

        [StringLength(2)]
        public string TECNOLOGIA_CDMA_TDMA { get; set; }

        [StringLength(255)]
        public string MODELO_EQUIPO_CDMA_TDMA { get; set; }

        [StringLength(16)]
        public string DIJIN { get; set; }

        [StringLength(50)]
        public string NUMERO_PAGARE { get; set; }

        [StringLength(20)]
        public string NUS { get; set; }

        public decimal? SPCODE_PAQ { get; set; }

        [StringLength(50)]
        public string MODELO_EQUIPO_ANTERIOR { get; set; }

        [StringLength(15)]
        public string IMEI_ANTERIOR { get; set; }

        public decimal? ID_REPOSICION { get; set; }

        [StringLength(50)]
        public string VR_RECARGA_UNICO { get; set; }

        [StringLength(50)]
        public string DCTO_RECARGA_UNICO { get; set; }

        [StringLength(50)]
        public string VR_RECARGA_TELEMIC { get; set; }

        [StringLength(50)]
        public string DCTO_RECARGA_TELEMIC { get; set; }

        public int? ENTREGA_FACTURA { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_FACT_ELECT { get; set; }

        [StringLength(20)]
        public string TIENDA { get; set; }
    }
}
