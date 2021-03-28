-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-08-2020 a las 04:10:32
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inventario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacen`
--

CREATE TABLE `almacen` (
  `id` int(11) NOT NULL,
  `almacen` varchar(65) NOT NULL,
  `ubicacion` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `almacen`
--

INSERT INTO `almacen` (`id`, `almacen`, `ubicacion`) VALUES
(1, 'Ropa y Accesorio', 'Planta 3'),
(2, 'Deporte', 'Planta 1'),
(3, 'Electrodomesticos', 'Planta 2'),
(10, 'Andres', 'Planta 2'),
(11, 'Deporte', 'Planta 5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargo`
--

CREATE TABLE `cargo` (
  `id_cargo` int(11) NOT NULL,
  `cargo` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cargo`
--

INSERT INTO `cargo` (`id_cargo`, `cargo`) VALUES
(1, 'Administrador'),
(2, 'Gerente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `claseproducto`
--

CREATE TABLE `claseproducto` (
  `id` int(11) NOT NULL,
  `tipo` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `claseproducto`
--

INSERT INTO `claseproducto` (`id`, `tipo`) VALUES
(1, 'Ropa'),
(2, 'Accesorio'),
(3, 'Articulos del hogar'),
(4, 'Entrenamiento');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `id` int(11) NOT NULL,
  `nombre` varchar(120) NOT NULL,
  `apellido` varchar(120) NOT NULL,
  `email` varchar(200) NOT NULL,
  `sexo` varchar(65) NOT NULL,
  `user` varchar(120) NOT NULL,
  `password` varchar(120) NOT NULL,
  `cargoFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`id`, `nombre`, `apellido`, `email`, `sexo`, `user`, `password`, `cargoFK`) VALUES
(2, 'BMO', 'BMO', 'male', 'BMO@gmailcom', 'Admin', '12345678', 2),
(3, 'Andres', 'Guanipa', 'andreseguanipa1@gmail.com', 'male', 'andres_guanipa', '123456', 1),
(8, 'Rafael', 'Velazco', 'rjvelazco_7@hotmail.com', 'male', 'rjvelazco', 'hermanos12', 2),
(11, 'Virginia', 'Sánchez', 'vgsr1009@hotmail.com', 'female', 'virginiagsr', 'hola12345', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entrega`
--

CREATE TABLE `entrega` (
  `id` int(11) NOT NULL,
  `proveedorFK` int(11) NOT NULL,
  `productoFK` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `descripcion` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `entrega`
--

INSERT INTO `entrega` (`id`, `proveedorFK`, `productoFK`, `fecha`, `descripcion`) VALUES
(7, 3, 242631, '2020-08-04', 'Cantidad de Producto entregado: 150'),
(8, 3, 242631, '2020-08-05', 'Cantidad de producto entrega: 0'),
(9, 3, 142315, '2020-08-04', 'Cantidad de Producto entregado: 30'),
(10, 3, 142315, '2020-08-05', 'Cantidad de Producto entregado: 60'),
(11, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(12, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(13, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(14, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(15, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(16, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(17, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(18, 3, 143016, '2020-08-06', 'Cantidad de Producto entregado: 50'),
(19, 3, 142315, '2020-08-06', 'Cantidad de Producto entregado: 60'),
(20, 3, 122352, '2020-08-06', 'Cantidad de Producto entregado: 35'),
(21, 3, 122352, '2020-08-06', 'Cantidad de Producto entregado: 35'),
(22, 3, 142315, '2020-08-09', 'Cantidad de Producto entregado: 60'),
(23, 3, 142315, '2020-08-09', 'Cantidad de Producto entregado: 60'),
(24, 3, 142315, '2020-08-09', 'Cantidad de Producto entregado: 60'),
(25, 3, 142315, '2020-08-09', 'Cantidad de Producto entregado: 60');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id` int(11) NOT NULL,
  `marca` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id`, `marca`) VALUES
(1, 'ESNTLS'),
(2, 'RG&B'),
(3, 'Under'),
(4, 'Nike'),
(5, 'Oster'),
(6, 'Samsung'),
(15, 'Adidas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(120) NOT NULL,
  `claseFK` int(11) NOT NULL,
  `marcaFK` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `almacenFK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`codigo`, `nombre`, `claseFK`, `marcaFK`, `precio`, `cantidad`, `almacenFK`) VALUES
(121212, 'Tablet', 3, 6, '200.00', 15, 3),
(122352, 'Talisman Necklace', 2, 2, '51.00', 85, 1),
(142315, 'Sweat Pant', 1, 1, '60.00', 61, 1),
(143016, 'Franela Corta', 1, 1, '25.00', 50, 1),
(151515, 'Speakers', 3, 6, '25.00', 11, 3),
(151685, 'Cartuchera', 3, 2, '12.00', 10, 1),
(161616, 'Monitor', 3, 6, '200.00', 15, 3),
(239412, 'Boxer Brief', 1, 1, '25.00', 40, 1),
(242631, 'Sudadera Nike Air', 4, 4, '45.99', 200, 2),
(242632, 'Short', 4, 3, '42.00', 98, 2),
(242633, 'Cafetera', 3, 5, '130.00', 29, 3),
(242634, 'Nevera', 3, 6, '600.00', 40, 3),
(242635, 'Mancuerna 5kg', 4, 3, '20.00', 100, 2),
(242636, 'Licuadora', 3, 5, '50.00', 115, 3),
(242637, 'Televisor', 3, 6, '100.00', 12, 3),
(242638, 'Tenis deportivos', 4, 3, '24.00', 22, 2),
(242639, 'Lavadora', 3, 6, '85.00', 78, 3),
(242641, 'Secador de pelo', 3, 5, '70.00', 100, 3),
(242642, 'Reloj de pulsera', 2, 2, '10.00', 99, 1),
(252525, 'Radio', 3, 6, '12.00', 25, 3),
(412352, 'Minimal Bar Necklace', 2, 2, '39.00', 45, 1),
(491023, 'Lava Stone Bead Bracelet', 2, 2, '29.00', 25, 1),
(525374, 'Roku', 3, 6, '55.00', 50, 3),
(2426317, 'Cargador', 2, 6, '34.00', 57, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `id` int(11) NOT NULL,
  `proveedor` varchar(120) NOT NULL,
  `pais` varchar(64) NOT NULL,
  `ciudad` varchar(120) NOT NULL,
  `calle` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id`, `proveedor`, `pais`, `ciudad`, `calle`) VALUES
(3, 'Nike Company', 'Estados Unidos', 'San Francisco', '50st');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `almacen`
--
ALTER TABLE `almacen`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`id_cargo`);

--
-- Indices de la tabla `claseproducto`
--
ALTER TABLE `claseproducto`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `user` (`user`),
  ADD KEY `cargoFK` (`cargoFK`);

--
-- Indices de la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`id`),
  ADD KEY `proveedorFK` (`proveedorFK`),
  ADD KEY `productoFK` (`productoFK`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `claseFK` (`claseFK`),
  ADD KEY `marcaFK` (`marcaFK`),
  ADD KEY `almacenFK` (`almacenFK`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id`) USING BTREE;

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `almacen`
--
ALTER TABLE `almacen`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `cargo`
--
ALTER TABLE `cargo`
  MODIFY `id_cargo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `claseproducto`
--
ALTER TABLE `claseproducto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `entrega`
--
ALTER TABLE `entrega`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`cargoFK`) REFERENCES `cargo` (`id_cargo`);

--
-- Filtros para la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD CONSTRAINT `entrega_ibfk_1` FOREIGN KEY (`proveedorFK`) REFERENCES `proveedor` (`id`),
  ADD CONSTRAINT `entrega_ibfk_2` FOREIGN KEY (`productoFK`) REFERENCES `producto` (`codigo`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`claseFK`) REFERENCES `claseproducto` (`id`),
  ADD CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`marcaFK`) REFERENCES `marca` (`id`),
  ADD CONSTRAINT `producto_ibfk_3` FOREIGN KEY (`almacenFK`) REFERENCES `almacen` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
