SELECT c.dni, c.nombre, p.nombre FROM cientifico c
JOIN cientifico_x_proyecto cp ON c.dni = cp.idcientificoF
JOIN proyecto p ON cp.idproyectoF = p.id; /*1*/

SELECT c.dni, c.nombre, COUNT(cp.idproyectoF) AS total_proyectos FROM cientifico c
JOIN cientifico_x_proyecto cp ON c.dni = cp.idcientificoF
JOIN proyecto p ON cp.idproyectoF = p.id
GROUP BY c.dni, c.nombre
ORDER BY total_proyectos DESC; /*2*/

SELECT p.nombre, COUNT(cp.idcientificoF) AS total_laburantes FROM proyecto p
JOIN cientifico_x_proyecto cp ON p.id = cp.idproyectoF
JOIN cientifico c ON cp.idcientificoF = c.dni
GROUP BY p.nombre
ORDER BY total_laburantes DESC; /*3*/

SELECT 
    c.dni, 
    c.nombre AS nombre_cientifico, 
    SUM(cp.horas) AS total_horas
FROM cientifico c
JOIN cientifico_x_proyecto cp ON c.dni = cp.idcientificoF
GROUP BY c.dni, c.nombre
ORDER BY total_horas DESC; /*4*/

SELECT 
    c.dni, 
    c.nombre AS nombre_cientifico,
    AVG(cp.horas) AS promedio
FROM cientifico c
JOIN cientifico_x_proyecto cp ON c.dni = cp.idcientificoF
GROUP BY c.dni, c.nombre
HAVING COUNT(cp.idproyectoF) > 1 AND promedio > 80
ORDER BY promedio DESC; /*5*/