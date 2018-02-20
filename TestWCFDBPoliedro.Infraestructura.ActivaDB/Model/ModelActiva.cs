namespace TestWCFDBPoliedro.Infraestructura.ActivaDB.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelActiva : DbContext
    {
        public ModelActiva()
            : base("name=ModelActiva")
        {
        }

        public virtual DbSet<ACTIVACIONPRE> ACTIVACIONPRE { get; set; }
        public virtual DbSet<ACTIVACION> ACTIVACION { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.SALUDO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.NOMBRES)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CIUDAD_DEPARTAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.ICCID)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.IMEI)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TECNOLOGIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CODIGO_DISTRIBUIDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TMCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.SPCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CODMIN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.HLR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.GRUPO_CLIENTES)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CENTRO_COSTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.SECTOR_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.EFECTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CARGA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.VIGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.MO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.RESN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.RTAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.ESTADOIN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CO_ID)
                .HasPrecision(22, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(22, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TEXT1)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TEXT2)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TEXT3)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.ESTADOMO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.NOMBRE_EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.ID_ACTIVACION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.PLANILLA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.INDICATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.TIPO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.BARRIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.ID_VENDEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACIONPRE>()
                .Property(e => e.GENERAR_TICKLER)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SALUDO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NOMBRES)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CIUDAD_DEPARTAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.INDICATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TIPO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ESN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CODIGO_DISTRIBUIDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.HLR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PLAN_TARIFAS)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CODMIN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PLANILLA_DISTIBUIDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_CFM)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IVA_CFM)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IVA_EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TOTAL_VENTA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUMERO_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MODELO_EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TIPO_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NO_INCLUSION_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.COMBO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.WIP)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.WAP)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.LID_WAP)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.COMSEGURO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ANDIASISTENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.OCUPACION_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SECTOR_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.GRUPO_CLIENTES)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CENTRO_COSTO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.EFECTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TARJETA_CREDITO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.COMPANIA_TC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NRO_TC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CUPO_TC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VENCE_TC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PRIMER_APELLIDO_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SEGUNDO_APELLIDO_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NOMBRE_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUMERO_DOCUMENTO1)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.EMPRESA_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DIRECCION_EMPRESA_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TELEFONO_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PROFESION_CONYUGE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.EMPRESA_TRABAJO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DIRECCION_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TELEFONO_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.INGRESO_MENSUAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ESTADO_CIVIL_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ACTIVIDAD_ECONOMICA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TIPO_VIVIENDA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.REFERENCIA_PERSONAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TELEFONO_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NOMBRE_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SUCURSAL_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUMERO_CUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TARJETA_ENTIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUMERO_TC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TC_CUPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.RB_VENCIMIENTO_TC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TARJETA_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.COLGAR_A_MAESTRA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.LINEACT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.LINEPORACT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MORACONCOM)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TRAJO_EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PLANILLA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CREDITO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DISTRIBUIDOR1)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CO_ID)
                .HasPrecision(22, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CODMINEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.COMSEGUROEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ANDIASISTENCIAEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ESNEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PLAN_TARIFASEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MODELO_EQUIPOEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_CFMEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IVA_CFMEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.EQUIPOEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IVA_EQUIPOEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TOTAL_VENTAEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SPCODEEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TMCODEEXT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT1)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT2)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT3)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT4)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT5)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT6)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT7)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT8)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT9)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT10)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT11)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT12)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT13)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT14)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT15)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SCCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IMEI)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MENSAJES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DATOS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MMS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT16)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT17)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IVA_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.REVISTA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TRAJO_ICCID)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT18)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT19)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TEXT20)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CONSECUTIVO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ILIMITADO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CFM_ANT)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VRILIMITADO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IVAILIMITADO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IMEIOFQ)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MODELO_EQUIPO_OFQ)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CICLO_CORPORATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ID_VENDEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.BARRIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DIRECTORIO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.PROMOCION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.CONEXION_SAP)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_EQUIPO_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_IVA_EQUIPO_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_ICCID_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VALOR_IVA_ICCID_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ID_CONSULTOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DIAS_PAGO_ORD_COMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SERIAL_CDMA_TDMA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TECNOLOGIA_CDMA_TDMA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MODELO_EQUIPO_CDMA_TDMA)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DIJIN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUMERO_PAGARE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.NUS)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.SPCODE_PAQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.MODELO_EQUIPO_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.IMEI_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.ID_REPOSICION)
                .HasPrecision(20, 0);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VR_RECARGA_UNICO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DCTO_RECARGA_UNICO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.VR_RECARGA_TELEMIC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.DCTO_RECARGA_TELEMIC)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVACION>()
                .Property(e => e.TIENDA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.CODDISTRI)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.MINENTRA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.MINSALE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ESNENTRA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ESNSALE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.PLANENTRA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.PLANSALE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TIPOSERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.CAUSAL)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.NROSERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.DENUNCIA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.COMSEGURO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.GARANTIA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TEXT1)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TEXT2)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TEXT3)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TEXT4)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TEXT5)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.COSTO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.SCCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.CLAUSULA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.PLANILLA)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ICCID_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.IMEI_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ICCID_NUEVO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.IMEI_NUEVO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TRAJO_SIM)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TRAJO_EQUIPO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.TIPO_ACTIVACION)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.CUSTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.COD_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.CONEXION_SAP)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ID_REPOSICION)
                .HasPrecision(20, 0);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.ID_PERFIL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.CO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.PERM_PEND)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.IND_USUCPS)
                .IsUnicode(false);
        }
    }
}
