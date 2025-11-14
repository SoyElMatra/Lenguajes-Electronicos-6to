SELECT * FROM articulo; /*1*/

SELECT c.nombre AS Zona_1 FROM cliente c
JOIN zona z ON c.idZonaF = z.idZona
WHERE z.idzona = 1; /*2*/

SELECT c.nombre AS Zona_3 FROM cliente c
JOIN zona z ON c.idZonaF = z.idZona
WHERE z.idzona = 3; /*3*/

SELECT DISTINCT c.nombre AS cliente, COUNT(p.numPedido) AS total_pedidos FROM cliente c
JOIN pedido p ON c.codCliente = p.codClienteF
GROUP BY c.nombre
ORDER BY total_pedidos DESC; /*4 y 5*/

SELECT a.descripcion AS art_pedro FROM articulo a
JOIN pedido p ON a.codArt = p.codArtF
JOIN cliente c ON p.codClienteF = c.codCliente
WHERE c.nombre = 'Pedro'; /*6*/

SELECT c.direccion, c.codPostal, p.unidades FROM cliente c
JOIN pedido p ON c.codCliente = p.codClienteF
WHERE p.unidades = (SELECT MAX(unidades) FROM pedido); /*7*/

SELECT 
    p.*,
    c.nombre AS cliente,
    a.descripcion AS articulo
FROM pedido p
JOIN cliente c ON p.codClienteF = c.codCliente
JOIN articulo a ON p.codArtF = a.codArt
WHERE p.fechaPedido = (SELECT MIN(fechaPedido) FROM pedido); /*8*/