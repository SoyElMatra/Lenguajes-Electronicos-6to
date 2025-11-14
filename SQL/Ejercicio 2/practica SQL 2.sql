SELECT nombre FROM pieza; /*1*/

SELECT * FROM proveedor; /*2*/

SELECT AVG(precio) AS precio_medio FROM suministro; /*3*/

SELECT pr.nombre 
FROM proveedor pr
JOIN suministro s ON pr.codigo = s.codigo_proveedor
WHERE s.codigo_pieza = 10; /*4*/

SELECT p.nombre
FROM pieza p
JOIN suministro s ON p.codigo = s.codigo_pieza
JOIN proveedor pr ON s.codigo_proveedor = pr.codigo
WHERE pr.nombre = 'SICA'; /*5*/

SELECT 
    pr.nombre AS proveedor,
    p.nombre AS pieza,
    s.precio
FROM suministro s
JOIN proveedor pr ON s.codigo_proveedor = pr.codigo
JOIN pieza p ON s.codigo_pieza = p.codigo
WHERE s.precio = (SELECT MAX(precio) FROM suministro); /*6*/