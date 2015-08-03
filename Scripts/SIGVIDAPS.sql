/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     03/08/2015 1:18:25                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CALCULO') and o.name = 'FK_CALCULO_RELATIONS_FORMULAR')
alter table CALCULO
   drop constraint FK_CALCULO_RELATIONS_FORMULAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CARGO') and o.name = 'FK_CARGO_RELATIONS_NIVEL')
alter table CARGO
   drop constraint FK_CARGO_RELATIONS_NIVEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_CALCULO') and o.name = 'FK_DETALLE__RELATIONS_CALCULO')
alter table DETALLE_CALCULO
   drop constraint FK_DETALLE__RELATIONS_CALCULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_CALCULO') and o.name = 'FK_DETALLE__RELATIONS_OPCION_N')
alter table DETALLE_CALCULO
   drop constraint FK_DETALLE__RELATIONS_OPCION_N
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_FORMULARIO') and o.name = 'FK_DETALLE__RELATIONS_TIPO_TRA')
alter table DETALLE_FORMULARIO
   drop constraint FK_DETALLE__RELATIONS_TIPO_TRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_FORMULARIO') and o.name = 'FK_DETALLE__RELATIONS_FORMULAR1')
alter table DETALLE_FORMULARIO
   drop constraint FK_DETALLE__RELATIONS_FORMULAR1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_FORMULARIO') and o.name = 'FK_DETALLE__RELATIONS_RUTA')
alter table DETALLE_FORMULARIO
   drop constraint FK_DETALLE__RELATIONS_RUTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_FORMULARIO') and o.name = 'FK_DETALLE__RELATIONS_FORMULAR2')
alter table DETALLE_FORMULARIO
   drop constraint FK_DETALLE__RELATIONS_FORMULAR2
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLEADO') and o.name = 'FK_EMPLEADO_RELATIONS_CARGO')
alter table EMPLEADO
   drop constraint FK_EMPLEADO_RELATIONS_CARGO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURACION') and o.name = 'FK_FACTURAC_RELATIONS_FORMULAR')
alter table FACTURACION
   drop constraint FK_FACTURAC_RELATIONS_FORMULAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO_LIQUIDACION') and o.name = 'FK_FORMULAR_RELATIONS_EMPLEADO2')
alter table FORMULARIO_LIQUIDACION
   drop constraint FK_FORMULAR_RELATIONS_EMPLEADO2
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO__ANTICIPO') and o.name = 'FK_FORMULAR_RELATIONS_EMPLEADO1')
alter table FORMULARIO__ANTICIPO
   drop constraint FK_FORMULAR_RELATIONS_EMPLEADO1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FORMULARIO__ANTICIPO') and o.name = 'FK_FORMULAR_RELATIONS_COMBINAC')
alter table FORMULARIO__ANTICIPO
   drop constraint FK_FORMULAR_RELATIONS_COMBINAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MENU_PERFIL') and o.name = 'FK_MENU_PER_RELATIONS_PERFIL')
alter table MENU_PERFIL
   drop constraint FK_MENU_PER_RELATIONS_PERFIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OPCION_NIVEL') and o.name = 'FK_OPCION_N_RELATIONS_NIVEL')
alter table OPCION_NIVEL
   drop constraint FK_OPCION_N_RELATIONS_NIVEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OPCION_NIVEL') and o.name = 'FK_OPCION_N_RELATIONS_OPCIONES')
alter table OPCION_NIVEL
   drop constraint FK_OPCION_N_RELATIONS_OPCIONES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_RELATIONS_EMPLEADO')
alter table USUARIO
   drop constraint FK_USUARIO_RELATIONS_EMPLEADO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_RELATIONS_PERFIL')
alter table USUARIO
   drop constraint FK_USUARIO_RELATIONS_PERFIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CALCULO')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index CALCULO.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CALCULO')
            and   type = 'U')
   drop table CALCULO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CARGO')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index CARGO.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CARGO')
            and   type = 'U')
   drop table CARGO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMBINACION_VIATICOS')
            and   type = 'U')
   drop table COMBINACION_VIATICOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_CALCULO')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_CALCULO.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_CALCULO')
            and   name  = 'RELATIONSHIP_15_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_CALCULO.RELATIONSHIP_15_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLE_CALCULO')
            and   type = 'U')
   drop table DETALLE_CALCULO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_FORMULARIO')
            and   name  = 'RELATIONSHIP_20_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_FORMULARIO.RELATIONSHIP_20_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_FORMULARIO')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_FORMULARIO.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_FORMULARIO')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_FORMULARIO.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_FORMULARIO')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_FORMULARIO.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLE_FORMULARIO')
            and   type = 'U')
   drop table DETALLE_FORMULARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLEADO')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLEADO.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLEADO')
            and   type = 'U')
   drop table EMPLEADO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FACTURACION')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index FACTURACION.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURACION')
            and   type = 'U')
   drop table FACTURACION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULARIO_LIQUIDACION')
            and   name  = 'RELATIONSHIP_23_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO_LIQUIDACION.RELATIONSHIP_23_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FORMULARIO_LIQUIDACION')
            and   type = 'U')
   drop table FORMULARIO_LIQUIDACION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULARIO__ANTICIPO')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO__ANTICIPO.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FORMULARIO__ANTICIPO')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index FORMULARIO__ANTICIPO.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FORMULARIO__ANTICIPO')
            and   type = 'U')
   drop table FORMULARIO__ANTICIPO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MENU_PERFIL')
            and   name  = 'RELATIONSHIP_24_FK'
            and   indid > 0
            and   indid < 255)
   drop index MENU_PERFIL.RELATIONSHIP_24_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MENU_PERFIL')
            and   type = 'U')
   drop table MENU_PERFIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NIVEL')
            and   type = 'U')
   drop table NIVEL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPCIONES_VIATICOS')
            and   type = 'U')
   drop table OPCIONES_VIATICOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OPCION_NIVEL')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index OPCION_NIVEL.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OPCION_NIVEL')
            and   name  = 'RELATIONSHIP_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index OPCION_NIVEL.RELATIONSHIP_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPCION_NIVEL')
            and   type = 'U')
   drop table OPCION_NIVEL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERFIL')
            and   type = 'U')
   drop table PERFIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RUTA')
            and   type = 'U')
   drop table RUTA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_TRANSPORTE')
            and   type = 'U')
   drop table TIPO_TRANSPORTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'RELATIONSHIP_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.RELATIONSHIP_22_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'RELATIONSHIP_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.RELATIONSHIP_21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: CALCULO                                               */
/*==============================================================*/
create table CALCULO (
   IDCALCULO            numeric              identity,
   IDFORMANTICIPO       numeric              null,
   MONTOCALCULO         money                null,
   constraint PK_CALCULO primary key nonclustered (IDCALCULO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_11_FK on CALCULO (
IDFORMANTICIPO ASC
)
go

/*==============================================================*/
/* Table: CARGO                                                 */
/*==============================================================*/
create table CARGO (
   IDCARGO              numeric              identity,
   IDNIVEL              numeric              null,
   NOMCARGO             varchar(30)          null,
   ESTCARGO             bit                  null,
   constraint PK_CARGO primary key nonclustered (IDCARGO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on CARGO (
IDNIVEL ASC
)
go

/*==============================================================*/
/* Table: COMBINACION_VIATICOS                                  */
/*==============================================================*/
create table COMBINACION_VIATICOS (
   IDCOMBINACION        numeric              identity,
   NOMCOMBINACION       varchar(40)          null,
   constraint PK_COMBINACION_VIATICOS primary key nonclustered (IDCOMBINACION)
)
go

/*==============================================================*/
/* Table: DETALLE_CALCULO                                       */
/*==============================================================*/
create table DETALLE_CALCULO (
   IDDETALLECALCULO     numeric              identity,
   IDCALCULO            numeric              null,
   IDOPCIONN            numeric              null,
   SUBTOTALMONTO        money                null,
   constraint PK_DETALLE_CALCULO primary key nonclustered (IDDETALLECALCULO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_15_FK on DETALLE_CALCULO (
IDCALCULO ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on DETALLE_CALCULO (
IDOPCIONN ASC
)
go

/*==============================================================*/
/* Table: DETALLE_FORMULARIO                                    */
/*==============================================================*/
create table DETALLE_FORMULARIO (
   IDDETFORM            numeric              identity,
   IDFORMANTICIPO       numeric              null,
   IDFORMLIQ            numeric              null,
   IDTIPOTRANSPORTE     numeric              null,
   IDRUTA               numeric              null,
   NOMBRETRANSPORTE     varchar(50)          null,
   SALIDATRANSPORTE     datetime             null,
   LLEGADATRANSPORTE    datetime             null,
   MONTOTRANSPORTE      money                null,
   constraint PK_DETALLE_FORMULARIO primary key nonclustered (IDDETFORM)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on DETALLE_FORMULARIO (
IDFORMANTICIPO ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_6_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_6_FK on DETALLE_FORMULARIO (
IDRUTA ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_8_FK on DETALLE_FORMULARIO (
IDFORMLIQ ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on DETALLE_FORMULARIO (
IDTIPOTRANSPORTE ASC
)
go

/*==============================================================*/
/* Table: EMPLEADO                                              */
/*==============================================================*/
create table EMPLEADO (
   IDEMP                numeric              identity,
   IDCARGO              numeric              null,
   CEDULAEMP            varchar(10)          null,
   NOMBREEMP            varchar(100)         null,
   APELLIDOEMP          varchar(100)         null,
   DIREMP               varchar(50)          null,
   TELEMP               varchar(15)          null,
   ESTEMP               bit                  null,
   constraint PK_EMPLEADO primary key nonclustered (IDEMP)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on EMPLEADO (
IDCARGO ASC
)
go

/*==============================================================*/
/* Table: FACTURACION                                           */
/*==============================================================*/
create table FACTURACION (
   IDFACTURACION        numeric              identity,
   IDFORMLIQ            numeric              null,
   PATHIMAGENFACTURA    varchar(300)         null,
   FECHAFACTURA         datetime             null,
   EMISORFACTURA        varchar(50)          null,
   MONTOFACTURA         money                null,
   constraint PK_FACTURACION primary key nonclustered (IDFACTURACION)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on FACTURACION (
IDFORMLIQ ASC
)
go

/*==============================================================*/
/* Table: FORMULARIO_LIQUIDACION                                */
/*==============================================================*/
create table FORMULARIO_LIQUIDACION (
   IDFORMLIQ            numeric              identity,
   IDEMP                numeric              null,
   NUMFORMLIQ           varchar(15)          null,
   FECHAFORMLIQ         datetime             null,
   CIUDADFORMLIQ        varchar(50)          null,
   UNIDADFORMLIQ        varchar(50)          null,
   SALIDAITINFORMLIQ    datetime             null,
   LLEGADAITINFORMLIQ   datetime             null,
   ESTADOFORMLIQ        varchar(30)          null,
   constraint PK_FORMULARIO_LIQUIDACION primary key nonclustered (IDFORMLIQ)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_23_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_23_FK on FORMULARIO_LIQUIDACION (
IDEMP ASC
)
go

/*==============================================================*/
/* Table: FORMULARIO__ANTICIPO                                  */
/*==============================================================*/
create table FORMULARIO__ANTICIPO (
   IDFORMANTICIPO       numeric              identity,
   IDCOMBINACION        numeric              null,
   IDEMP                numeric              null,
   NUMFORMANTICIPO      varchar(30)          null,
   FECFORMANTICIPO      datetime             null,
   CIUDADFORMANTICIPO   varchar(50)          null,
   UNIDADFORMANTICIPO   varchar(50)          null,
   SALIDAFORMANTICIPO   datetime             null,
   LLEGADAFORMANTICIPO  datetime             null,
   DESCRIPCIONFORMANTICIPO varchar(500)         null,
   BANCOFORMANTICIPO    varchar(50)          null,
   TIPOCUENTAFORMANTICIPO varchar(50)          null,
   NUMCUENTAFORMANTICIPO varchar(30)          null,
   ESTADOFORMANTICIPO   varchar(30)          null,
   MONTOTOTAL           money                null,
   constraint PK_FORMULARIO__ANTICIPO primary key nonclustered (IDFORMANTICIPO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on FORMULARIO__ANTICIPO (
IDEMP ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on FORMULARIO__ANTICIPO (
IDCOMBINACION ASC
)
go

/*==============================================================*/
/* Table: MENU_PERFIL                                           */
/*==============================================================*/
create table MENU_PERFIL (
   IDMENUPERFIL         numeric              identity,
   IDPERFIL             numeric              null,
   MENUPERFIL           varchar(50)          null,
   constraint PK_MENU_PERFIL primary key nonclustered (IDMENUPERFIL)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_24_FK on MENU_PERFIL (
IDPERFIL ASC
)
go

/*==============================================================*/
/* Table: NIVEL                                                 */
/*==============================================================*/
create table NIVEL (
   IDNIVEL              numeric              identity,
   COD_NIVEL            varchar(30)          not null,
   NIVEL                int                  not null,
   constraint PK_NIVEL primary key nonclustered (IDNIVEL)
)
go

/*==============================================================*/
/* Table: OPCIONES_VIATICOS                                     */
/*==============================================================*/
create table OPCIONES_VIATICOS (
   IDOPCION             numeric              identity,
   NOMBREOPCION         varchar(30)          null,
   constraint PK_OPCIONES_VIATICOS primary key nonclustered (IDOPCION)
)
go

/*==============================================================*/
/* Table: OPCION_NIVEL                                          */
/*==============================================================*/
create table OPCION_NIVEL (
   IDOPCIONN            numeric              identity,
   IDOPCION             numeric              null,
   IDNIVEL              numeric              null,
   VALOROPCION          decimal              null,
   constraint PK_OPCION_NIVEL primary key nonclustered (IDOPCIONN)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_14_FK on OPCION_NIVEL (
IDNIVEL ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on OPCION_NIVEL (
IDOPCION ASC
)
go

/*==============================================================*/
/* Table: PERFIL                                                */
/*==============================================================*/
create table PERFIL (
   IDPERFIL             numeric              identity,
   NOMBREPERFIL         varchar(30)          null,
   constraint PK_PERFIL primary key nonclustered (IDPERFIL)
)
go

/*==============================================================*/
/* Table: RUTA                                                  */
/*==============================================================*/
create table RUTA (
   IDRUTA               numeric              identity,
   LUGARSALIDA          varchar(30)          null,
   LUGARLLEGADA         varchar(30)          null,
   CODRUTA              varchar(15)          null,
   ESTRUTA              bit                  null,
   constraint PK_RUTA primary key nonclustered (IDRUTA)
)
go

/*==============================================================*/
/* Table: TIPO_TRANSPORTE                                       */
/*==============================================================*/
create table TIPO_TRANSPORTE (
   IDTIPOTRANSPORTE     numeric              identity,
   TIPOTRANSPORTE       varchar(50)          null,
   constraint PK_TIPO_TRANSPORTE primary key nonclustered (IDTIPOTRANSPORTE)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   IDUSUARIO            numeric              identity,
   IDEMP                numeric              null,
   IDPERFIL             numeric              null,
   NOMBREUSUARIO        varchar(30)          not null,
   CONTRASENAUSUARIO    varchar(30)          not null,
   ESTUSUARIO           bit                  null,
   constraint PK_USUARIO primary key nonclustered (IDUSUARIO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on USUARIO (
IDEMP ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_22_FK on USUARIO (
IDPERFIL ASC
)
go

alter table CALCULO
   add constraint FK_CALCULO_RELATIONS_FORMULAR foreign key (IDFORMANTICIPO)
      references FORMULARIO__ANTICIPO (IDFORMANTICIPO)
go

alter table CARGO
   add constraint FK_CARGO_RELATIONS_NIVEL foreign key (IDNIVEL)
      references NIVEL (IDNIVEL)
go

alter table DETALLE_CALCULO
   add constraint FK_DETALLE__RELATIONS_CALCULO foreign key (IDCALCULO)
      references CALCULO (IDCALCULO)
go

alter table DETALLE_CALCULO
   add constraint FK_DETALLE__RELATIONS_OPCION_N foreign key (IDOPCIONN)
      references OPCION_NIVEL (IDOPCIONN)
go

alter table DETALLE_FORMULARIO
   add constraint FK_DETALLE__RELATIONS_TIPO_TRA foreign key (IDTIPOTRANSPORTE)
      references TIPO_TRANSPORTE (IDTIPOTRANSPORTE)
go

alter table DETALLE_FORMULARIO
   add constraint FK_DETALLE__RELATIONS_FORMULAR1 foreign key (IDFORMANTICIPO)
      references FORMULARIO__ANTICIPO (IDFORMANTICIPO)
go

alter table DETALLE_FORMULARIO
   add constraint FK_DETALLE__RELATIONS_RUTA foreign key (IDRUTA)
      references RUTA (IDRUTA)
go

alter table DETALLE_FORMULARIO
   add constraint FK_DETALLE__RELATIONS_FORMULAR2 foreign key (IDFORMLIQ)
      references FORMULARIO_LIQUIDACION (IDFORMLIQ)
go

alter table EMPLEADO
   add constraint FK_EMPLEADO_RELATIONS_CARGO foreign key (IDCARGO)
      references CARGO (IDCARGO)
go

alter table FACTURACION
   add constraint FK_FACTURAC_RELATIONS_FORMULAR foreign key (IDFORMLIQ)
      references FORMULARIO_LIQUIDACION (IDFORMLIQ)
go

alter table FORMULARIO_LIQUIDACION
   add constraint FK_FORMULAR_RELATIONS_EMPLEADO2 foreign key (IDEMP)
      references EMPLEADO (IDEMP)
go

alter table FORMULARIO__ANTICIPO
   add constraint FK_FORMULAR_RELATIONS_EMPLEADO1 foreign key (IDEMP)
      references EMPLEADO (IDEMP)
go

alter table FORMULARIO__ANTICIPO
   add constraint FK_FORMULAR_RELATIONS_COMBINAC foreign key (IDCOMBINACION)
      references COMBINACION_VIATICOS (IDCOMBINACION)
go

alter table MENU_PERFIL
   add constraint FK_MENU_PER_RELATIONS_PERFIL foreign key (IDPERFIL)
      references PERFIL (IDPERFIL)
go

alter table OPCION_NIVEL
   add constraint FK_OPCION_N_RELATIONS_NIVEL foreign key (IDNIVEL)
      references NIVEL (IDNIVEL)
go

alter table OPCION_NIVEL
   add constraint FK_OPCION_N_RELATIONS_OPCIONES foreign key (IDOPCION)
      references OPCIONES_VIATICOS (IDOPCION)
go

alter table USUARIO
   add constraint FK_USUARIO_RELATIONS_EMPLEADO foreign key (IDEMP)
      references EMPLEADO (IDEMP)
go

alter table USUARIO
   add constraint FK_USUARIO_RELATIONS_PERFIL foreign key (IDPERFIL)
      references PERFIL (IDPERFIL)
go

