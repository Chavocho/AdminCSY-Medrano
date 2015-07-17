-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-07-2015 a las 21:40:48
-- Versión del servidor: 5.6.24
-- Versión de PHP: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `admincsy_general`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `abono`
--

CREATE TABLE IF NOT EXISTS `abono` (
  `id` int(11) NOT NULL,
  `venta_id` int(11) DEFAULT NULL,
  `id_trabajador` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `abono` decimal(10,2) DEFAULT NULL,
  `tipo_pago` int(11) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `saldo` decimal(10,2) DEFAULT NULL,
  `folio` varchar(45) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacen`
--

CREATE TABLE IF NOT EXISTS `almacen` (
  `id` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  `num_alm` int(11) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `sucursal_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `banco`
--

CREATE TABLE IF NOT EXISTS `banco` (
  `id` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `voucher` decimal(10,2) NOT NULL,
  `num_cheque` int(11) NOT NULL,
  `beneficiario` varchar(55) NOT NULL,
  `cuenta_propia` int(11) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `tipo_movimiento` int(11) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `banco`
--

INSERT INTO `banco` (`id`, `id_sucursal`, `voucher`, `num_cheque`, `beneficiario`, `cuenta_propia`, `descripcion`, `tipo_movimiento`, `create_user`, `create_time`) VALUES
(1, 1, '300.00', 0, '', 0, 'entrada', 0, 1, '2015-07-15 14:41:50'),
(2, 1, '-200.00', 0, '', 0, 'salida', 1, 1, '2015-07-15 15:38:28'),
(3, 1, '174.00', 0, '', 0, 'VENTA MOSTRADOR', 0, 1, '2015-07-16 12:58:37'),
(4, 0, '-100.00', 0, '', 0, 'COMPRA DE PRODUCTOS CON FOLIO: 2', 1, 1, '2015-07-16 14:10:32'),
(5, 0, '-110.00', 0, '', 0, 'COMPRA DE PRODUCTOS CON FOLIO: 4', 1, 1, '2015-07-17 12:49:42'),
(6, 1, '-500.00', 0, '', 0, 'Salida', 1, 1, '2015-07-17 13:25:02');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caja`
--

CREATE TABLE IF NOT EXISTS `caja` (
  `id` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `efectivo` decimal(10,2) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `tipo_movimiento` int(11) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `caja`
--

INSERT INTO `caja` (`id`, `id_sucursal`, `efectivo`, `descripcion`, `tipo_movimiento`, `create_user`, `create_time`) VALUES
(1, 1, '1234.00', 'APERTURA DE CAJA', 0, 1, '2015-07-15 13:24:50'),
(2, 1, '-1234.00', 'CIERRE DE CAJA', 0, 1, '2015-07-15 13:30:19'),
(3, 1, '1234.00', 'APERTURA DE CAJA', 0, 1, '2015-07-15 13:30:26'),
(4, 1, '-1234.00', 'CIERRE DE CAJA', 0, 1, '2015-07-15 13:30:32'),
(5, 1, '200.00', '20', 0, 1, '2015-07-15 14:42:15'),
(6, 1, '0.00', 'APERTURA DE CAJA', 0, 1, '2015-07-15 15:37:14'),
(7, 1, '-200.00', 'salida', 1, 1, '2015-07-15 15:37:24'),
(8, 1, '0.00', 'VENTA MOSTRADOR', 0, 1, '2015-07-16 12:29:41'),
(9, 0, '-10.00', 'COMPRA DE PRODUCTOS CON FOLIO: 1', 1, 1, '2015-07-16 13:06:05'),
(10, 0, '-800.00', 'COMPRA DE PRODUCTOS CON FOLIO: 3', 1, 1, '2015-07-16 14:13:19');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`id`, `nombre`, `descripcion`) VALUES
(1, 'Categoria1', 'Descripcion');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `cuenta_id` int(11) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `razon_social` varchar(45) DEFAULT NULL,
  `rfc` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `num_ext` varchar(15) DEFAULT NULL,
  `num_int` varchar(15) DEFAULT NULL,
  `colonia` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `cp` varchar(11) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `lada1` varchar(45) DEFAULT NULL,
  `lada2` varchar(45) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL COMMENT 'Tipos de clientes-Cliente con crédit',
  `limite_credito` decimal(10,2) NOT NULL DEFAULT '0.00',
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
  `id` int(11) NOT NULL,
  `id_proveedor` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_comprador` int(11) DEFAULT NULL COMMENT 'Utilizar trabajador_id',
  `estado` int(11) NOT NULL DEFAULT '0',
  `subtotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `impuesto` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descuento` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `tipo_pago` int(11) NOT NULL,
  `remision` tinyint(1) NOT NULL,
  `factura` tinyint(1) NOT NULL,
  `folio_remision` varchar(100) DEFAULT NULL,
  `folio_factura` varchar(100) DEFAULT NULL,
  `cancelada` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `compra`
--

INSERT INTO `compra` (`id`, `id_proveedor`, `id_sucursal`, `id_comprador`, `estado`, `subtotal`, `impuesto`, `descuento`, `total`, `tipo_pago`, `remision`, `factura`, `folio_remision`, `folio_factura`, `cancelada`, `create_user`, `create_time`, `update_user`, `update_time`, `cancel_user`, `cancel_time`) VALUES
(1, 1, 1, 1, 0, '10.00', '0.00', '0.00', '10.00', 2, 1, 0, '12', '', 0, 1, '2015-07-16 13:06:05', NULL, NULL, NULL, NULL),
(2, 1, 1, 1, 0, '100.00', '0.00', '0.00', '100.00', 2, 1, 0, '123', '', 0, 1, '2015-07-16 14:10:32', NULL, NULL, NULL, NULL),
(3, 1, 1, 2, 0, '800.00', '0.00', '0.00', '800.00', 0, 1, 0, '123344', '', 0, 1, '2015-07-16 14:13:19', NULL, NULL, NULL, NULL),
(4, 1, 1, 1, 0, '110.00', '0.00', '0.00', '110.00', 4, 1, 0, '23', '', 0, 1, '2015-07-17 12:49:42', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra_detallada`
--

CREATE TABLE IF NOT EXISTS `compra_detallada` (
  `id_compra` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` int(11) NOT NULL,
  `unidad` int(11) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `compra_detallada`
--

INSERT INTO `compra_detallada` (`id_compra`, `id_producto`, `cant`, `unidad`, `precio`, `descuento`) VALUES
(1, 1, 1, 4, '10.00', '0.00'),
(2, 2, 1, 4, '100.00', '0.00'),
(3, 2, 8, 4, '100.00', '0.00'),
(4, 1, 1, 4, '10.00', '0.00'),
(4, 2, 1, 4, '100.00', '0.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contacto_cliente`
--

CREATE TABLE IF NOT EXISTS `contacto_cliente` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `extension` varchar(45) DEFAULT NULL,
  `celular` varchar(45) DEFAULT NULL,
  `lada1` varchar(45) DEFAULT NULL,
  `lada2` varchar(45) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contacto_proveedor`
--

CREATE TABLE IF NOT EXISTS `contacto_proveedor` (
  `id` int(11) NOT NULL,
  `id_proveedor` int(11) NOT NULL,
  `nombre` varchar(75) DEFAULT NULL,
  `apellidos` varchar(75) DEFAULT NULL,
  `telefono1` varchar(50) DEFAULT NULL,
  `telefono2` varchar(50) DEFAULT NULL,
  `extension` varchar(10) DEFAULT NULL,
  `celular` varchar(50) DEFAULT NULL,
  `lada1` varchar(10) DEFAULT NULL,
  `lada2` varchar(10) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE IF NOT EXISTS `cotizacion` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_vendedor` int(11) DEFAULT NULL COMMENT 'Utilizar trabajador_id',
  `estado` int(11) NOT NULL DEFAULT '0',
  `abierta` tinyint(1) NOT NULL DEFAULT '1',
  `subtotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `impuesto` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descuento` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `remision` tinyint(1) DEFAULT NULL,
  `factura` tinyint(1) DEFAULT NULL,
  `folio_factura` varchar(30) DEFAULT NULL,
  `tipo_pago` int(11) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_detallada`
--

CREATE TABLE IF NOT EXISTS `cotizacion_detallada` (
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` decimal(10,2) NOT NULL,
  `unidad` int(11) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE IF NOT EXISTS `cuenta` (
  `id` int(11) NOT NULL,
  `clabe` varchar(50) DEFAULT NULL,
  `banco` varchar(70) DEFAULT NULL,
  `beneficiario` varchar(100) DEFAULT NULL,
  `sucursal` varchar(20) DEFAULT NULL,
  `num_cuenta` int(11) DEFAULT NULL,
  `tipo` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion`
--

CREATE TABLE IF NOT EXISTS `devolucion` (
  `id` int(11) NOT NULL,
  `id_venta` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `saldo` decimal(10,2) NOT NULL,
  `create_user` int(11) NOT NULL,
  `create_time` datetime NOT NULL,
  `update_user` int(11) NOT NULL,
  `update_time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_detallada`
--

CREATE TABLE IF NOT EXISTS `devolucion_detallada` (
  `id_devolucion` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `cant` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccion`
--

CREATE TABLE IF NOT EXISTS `direccion` (
  `id` int(11) NOT NULL,
  `calle` varchar(100) NOT NULL,
  `num_ext` varchar(30) NOT NULL,
  `num_int` varchar(30) NOT NULL,
  `cp` varchar(10) NOT NULL,
  `colonia` varchar(50) NOT NULL,
  `ciudad` varchar(75) NOT NULL,
  `estado` varchar(75) NOT NULL,
  `eliminado` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado_caja`
--

CREATE TABLE IF NOT EXISTS `estado_caja` (
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `estado_caja`
--

INSERT INTO `estado_caja` (`estado`) VALUES
(1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gasto`
--

CREATE TABLE IF NOT EXISTS `gasto` (
  `id` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL,
  `folio` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE IF NOT EXISTS `inventario` (
  `id` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `cant` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `precio_medio_mayoreo` decimal(10,2) NOT NULL,
  `precio_mayoreo` decimal(10,2) NOT NULL,
  `create_user` int(11) NOT NULL,
  `create_time` datetime NOT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`id`, `id_producto`, `id_sucursal`, `cant`, `precio`, `precio_medio_mayoreo`, `precio_mayoreo`, `create_user`, `create_time`, `update_user`, `update_time`) VALUES
(1, 1, 1, 11, '20.00', '0.00', '0.00', 1, '2015-07-16 12:03:20', NULL, NULL),
(2, 2, 1, 19, '150.00', '0.00', '0.00', 1, '2015-07-16 12:03:46', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paquete`
--

CREATE TABLE IF NOT EXISTS `paquete` (
  `id` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `privilegios`
--

CREATE TABLE IF NOT EXISTS `privilegios` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `caja` tinyint(1) NOT NULL,
  `abrir_cerrar_caja` tinyint(1) NOT NULL,
  `movimientos_caja` tinyint(1) NOT NULL,
  `configuracion` tinyint(1) NOT NULL,
  `correo` tinyint(1) NOT NULL,
  `base_datos` tinyint(1) NOT NULL,
  `compra` tinyint(1) NOT NULL,
  `cliente` tinyint(1) NOT NULL,
  `eliminar_cliente` tinyint(1) NOT NULL,
  `proveedor` tinyint(1) NOT NULL,
  `eliminar_proveedor` tinyint(1) NOT NULL,
  `cotizacion` tinyint(1) NOT NULL,
  `producto` tinyint(1) NOT NULL,
  `editar_producto` tinyint(1) NOT NULL,
  `eliminar_producto` tinyint(1) NOT NULL,
  `sucursal` tinyint(1) NOT NULL,
  `trabajador` tinyint(1) NOT NULL,
  `crear_trabajador` tinyint(1) NOT NULL,
  `editar_trabajador` tinyint(1) NOT NULL,
  `eliminar_trabajador` tinyint(1) NOT NULL,
  `pago_trabajador` tinyint(1) NOT NULL,
  `usuario` tinyint(1) NOT NULL,
  `venta` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
  `id` int(11) NOT NULL,
  `proveedor_id` int(11) NOT NULL,
  `categoria` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `codigo` varchar(45) DEFAULT NULL,
  `descripcion1` varchar(45) DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `unidad` int(11) DEFAULT NULL COMMENT 'Unidades para el producto\n-Pieza\n-Paquete',
  `imagen01` longblob,
  `imagen02` longblob,
  `imagen03` longblob,
  `eliminado` tinyint(1) DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id`, `proveedor_id`, `categoria`, `nombre`, `marca`, `codigo`, `descripcion1`, `costo`, `unidad`, `imagen01`, `imagen02`, `imagen03`, `eliminado`, `create_user`, `create_time`, `update_user`, `update_time`, `delete_user`, `delete_time`) VALUES
(1, 1, 1, 'Producto1', 'Marca1', '1', '', '10.00', 4, NULL, NULL, NULL, 0, 1, '2015-07-16 12:03:20', NULL, NULL, NULL, NULL),
(2, 1, 1, 'Producto2', 'Marca2', '2', '', '100.00', 4, NULL, NULL, NULL, 0, 1, '2015-07-16 12:03:46', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `promocion`
--

CREATE TABLE IF NOT EXISTS `promocion` (
  `id` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `existencias` tinyint(1) NOT NULL,
  `fecha_ini` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `cant` int(11) NOT NULL,
  `cant_prod` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE IF NOT EXISTS `proveedor` (
  `id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `cuenta_id` int(11) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `razon_social` varchar(45) DEFAULT NULL,
  `rfc` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `num_ext` varchar(20) DEFAULT NULL,
  `num_int` varchar(20) DEFAULT NULL,
  `colonia` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `cp` varchar(11) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `lada1` varchar(45) DEFAULT NULL,
  `lada2` varchar(45) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL COMMENT 'Tipos de proveedores-Proveedor con crédito-Proveedor sin crédi',
  `limite_credito` decimal(10,2) NOT NULL DEFAULT '0.00',
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id`, `sucursal_id`, `cuenta_id`, `nombre`, `razon_social`, `rfc`, `calle`, `num_ext`, `num_int`, `colonia`, `ciudad`, `estado`, `cp`, `telefono1`, `telefono2`, `email`, `lada1`, `lada2`, `tipo`, `limite_credito`, `eliminado`, `create_user`, `create_time`, `update_user`, `update_time`, `delete_user`, `delete_time`) VALUES
(1, 1, 0, 'Proveedor1', '', '', 'Calle1', '1', '', '', '', '', '', '22334455', '', '', '', '', 1, '0.00', 0, 1, '2015-07-16 12:02:22', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE IF NOT EXISTS `puesto` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `departamento` varchar(45) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `puesto`
--

INSERT INTO `puesto` (`id`, `nombre`, `departamento`, `create_user`, `create_time`, `update_user`, `update_time`) VALUES
(1, 'Puesto1', 'Departamento1', 1, '2015-07-16 12:04:36', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE IF NOT EXISTS `sucursal` (
  `id` int(11) NOT NULL,
  `id_domicilio` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `numero_ext` int(11) DEFAULT NULL,
  `numero_int` int(11) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  `colonia` varchar(75) NOT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `fax` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `logotipo` longblob,
  `web` varchar(45) DEFAULT NULL,
  `rfc` varchar(45) DEFAULT NULL,
  `asignada` tinyint(1) NOT NULL DEFAULT '0',
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `sucursal`
--

INSERT INTO `sucursal` (`id`, `id_domicilio`, `nombre`, `calle`, `numero_ext`, `numero_int`, `cp`, `colonia`, `estado`, `ciudad`, `telefono1`, `telefono2`, `fax`, `email`, `logotipo`, `web`, `rfc`, `asignada`, `eliminado`, `create_user`, `create_time`, `update_user`, `update_time`) VALUES
(1, 0, 'Sucursal1', 'Calle1', 1, 0, 0, '', '', '', '33221122', '', '', '', NULL, '', '', 0, 0, 1, '2015-07-16 12:01:06', NULL, NULL),
(2, 0, 'Sucursal2', 'Calle2', 2, 0, 0, '', '', '', '22334455', '', '', '', NULL, '', '', 0, 0, 1, '2015-07-16 12:01:28', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajador`
--

CREATE TABLE IF NOT EXISTS `trabajador` (
  `id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `puesto` int(11) NOT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `celular` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  `sueldo` decimal(10,2) DEFAULT NULL,
  `nomina` int(11) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `imagen` longblob,
  `huella` longblob,
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `trabajador`
--

INSERT INTO `trabajador` (`id`, `sucursal_id`, `nombre`, `apellidos`, `puesto`, `telefono`, `celular`, `email`, `direccion`, `ciudad`, `estado`, `cp`, `sueldo`, `nomina`, `fecha_inicio`, `fecha_fin`, `imagen`, `huella`, `eliminado`, `create_user`, `create_time`, `update_user`, `update_time`, `delete_user`, `delete_time`) VALUES
(1, 1, 'Trabajador1', 'Trabajador', 1, '22334422', '3344556666', '', '', '', '', 0, '0.00', NULL, '2015-07-16', NULL, NULL, NULL, 0, 1, '2015-07-16 12:05:12', NULL, NULL, NULL, NULL),
(2, 1, 'trabajador2', 'trabajador22', 1, '332212232', '', '', '', '', '', 0, '0.00', NULL, '2015-07-16', NULL, NULL, NULL, 0, 1, '2015-07-16 12:05:35', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `traspaso`
--

CREATE TABLE IF NOT EXISTS `traspaso` (
  `id` int(11) NOT NULL,
  `id_sucursal_solicito` int(11) NOT NULL,
  `id_sucursal_origen` int(11) NOT NULL,
  `id_sucursal_destino` int(11) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `estado` int(1) NOT NULL,
  `create_user` int(11) NOT NULL,
  `create_time` datetime NOT NULL,
  `accept_user` int(11) NOT NULL,
  `accept_time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `traspaso_detallado`
--

CREATE TABLE IF NOT EXISTS `traspaso_detallado` (
  `id_traspaso` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `pass` varchar(150) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `nivel` int(11) DEFAULT NULL COMMENT 'Niveles de usuario',
  `email` varchar(100) DEFAULT NULL,
  `eliminado` tinyint(1) DEFAULT '0',
  `num_aut` int(11) DEFAULT NULL,
  `imagen` longblob,
  `huella` longblob,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `sucursal_id`, `username`, `pass`, `nombre`, `apellidos`, `nivel`, `email`, `eliminado`, `num_aut`, `imagen`, `huella`, `create_user`, `create_time`, `update_user`, `update_time`, `delete_user`, `delete_time`) VALUES
(1, 1, 'Admin', 'Oi9skIVYt3M=', 'Administrador', 'Usuario', 0, 'usuario@example.om', 0, NULL, NULL, NULL, 1, '2015-07-15 13:08:05', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE IF NOT EXISTS `venta` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_vendedor` int(11) DEFAULT NULL COMMENT 'Utilizar trabajador_id',
  `cancelada` tinyint(1) NOT NULL DEFAULT '0',
  `abierta` tinyint(1) NOT NULL DEFAULT '1',
  `subtotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `impuesto` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descuento` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `remision` tinyint(1) NOT NULL DEFAULT '1',
  `factura` tinyint(1) NOT NULL DEFAULT '0',
  `folio_factura` varchar(30) DEFAULT NULL,
  `tipo_pago` int(11) DEFAULT NULL,
  `terminacion_tarjeta` varchar(50) NOT NULL,
  `terminal_tarjeta` varchar(50) NOT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL,
  `cargo_tarjeta` decimal(10,2) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id`, `id_cliente`, `id_sucursal`, `id_vendedor`, `cancelada`, `abierta`, `subtotal`, `impuesto`, `descuento`, `total`, `remision`, `factura`, `folio_factura`, `tipo_pago`, `terminacion_tarjeta`, `terminal_tarjeta`, `create_user`, `create_time`, `update_user`, `update_time`, `cancel_user`, `cancel_time`, `cargo_tarjeta`) VALUES
(1, 0, 1, -1, 0, 1, '0.00', '0.00', '0.00', '0.00', 1, 0, NULL, 0, '', '', 1, '2015-07-16 12:05:50', NULL, NULL, NULL, NULL, '0.00'),
(2, 0, 1, -1, 0, 1, '0.00', '0.00', '0.00', '0.00', 1, 0, NULL, 0, '', '', 1, '2015-07-16 12:18:54', NULL, NULL, NULL, NULL, '0.00'),
(3, 0, 1, 1, 0, 0, '20.00', '0.00', '0.00', '23.20', 1, 0, NULL, 2, '2233134123', '12', 1, '2015-07-16 12:29:00', 1, '2015-07-16 12:29:41', NULL, NULL, '3.20'),
(4, 0, 1, 2, 0, 0, '150.00', '0.00', '0.00', '174.00', 1, 0, NULL, 2, '12341243123', '12', 1, '2015-07-16 12:57:28', 1, '2015-07-16 12:58:37', NULL, NULL, '24.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta_detallada`
--

CREATE TABLE IF NOT EXISTS `venta_detallada` (
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL,
  `unidad` int(11) DEFAULT NULL,
  `paquete` tinyint(1) NOT NULL DEFAULT '0',
  `id_promocion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `venta_detallada`
--

INSERT INTO `venta_detallada` (`id_venta`, `id_producto`, `cant`, `precio`, `descuento`, `unidad`, `paquete`, `id_promocion`) VALUES
(3, 1, 1, '20.00', '0.00', 4, 0, -1),
(4, 2, 1, '150.00', '0.00', 4, 0, -1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `abono`
--
ALTER TABLE `abono`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `almacen`
--
ALTER TABLE `almacen`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `banco`
--
ALTER TABLE `banco`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `caja`
--
ALTER TABLE `caja`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`,`sucursal_id`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`id`,`id_sucursal`);

--
-- Indices de la tabla `compra_detallada`
--
ALTER TABLE `compra_detallada`
  ADD PRIMARY KEY (`id_compra`,`id_producto`);

--
-- Indices de la tabla `contacto_cliente`
--
ALTER TABLE `contacto_cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `contacto_proveedor`
--
ALTER TABLE `contacto_proveedor`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cotizacion_detallada`
--
ALTER TABLE `cotizacion_detallada`
  ADD PRIMARY KEY (`id_venta`,`id_producto`);

--
-- Indices de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `devolucion_detallada`
--
ALTER TABLE `devolucion_detallada`
  ADD PRIMARY KEY (`id_devolucion`,`id_producto`);

--
-- Indices de la tabla `direccion`
--
ALTER TABLE `direccion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `gasto`
--
ALTER TABLE `gasto`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `paquete`
--
ALTER TABLE `paquete`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `privilegios`
--
ALTER TABLE `privilegios`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `codigo` (`codigo`);

--
-- Indices de la tabla `promocion`
--
ALTER TABLE `promocion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id`,`sucursal_id`);

--
-- Indices de la tabla `puesto`
--
ALTER TABLE `puesto`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `trabajador`
--
ALTER TABLE `trabajador`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `traspaso`
--
ALTER TABLE `traspaso`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `traspaso_detallado`
--
ALTER TABLE `traspaso_detallado`
  ADD PRIMARY KEY (`id_traspaso`,`id_producto`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`,`sucursal_id`), ADD UNIQUE KEY `username_UNIQUE` (`username`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id`,`id_sucursal`);

--
-- Indices de la tabla `venta_detallada`
--
ALTER TABLE `venta_detallada`
  ADD PRIMARY KEY (`id_venta`,`id_producto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `abono`
--
ALTER TABLE `abono`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `almacen`
--
ALTER TABLE `almacen`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `banco`
--
ALTER TABLE `banco`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `caja`
--
ALTER TABLE `caja`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `contacto_cliente`
--
ALTER TABLE `contacto_cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `contacto_proveedor`
--
ALTER TABLE `contacto_proveedor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `direccion`
--
ALTER TABLE `direccion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `gasto`
--
ALTER TABLE `gasto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `paquete`
--
ALTER TABLE `paquete`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `privilegios`
--
ALTER TABLE `privilegios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `promocion`
--
ALTER TABLE `promocion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `puesto`
--
ALTER TABLE `puesto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `trabajador`
--
ALTER TABLE `trabajador`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `traspaso`
--
ALTER TABLE `traspaso`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
