-- 1) Obtener los apellidos de los empleados
SELECT apellido FROM empleado;

-- 2) Obtener los apellidos de los empleados sin repeticiones
SELECT DISTINCT apellido FROM empleado;

-- 3) Obtener todos los datos de los empleados que se apellidan "López"
SELECT * FROM empleado WHERE apellido = 'López';

-- 4) Obtener todos los datos de los empleados que se apellidan "López" y "Pérez"
SELECT * FROM empleado WHERE apellido IN ('López', 'Pérez');

-- 5) Obtener todos los datos de los empleados que trabajan para el departamento Ventas y Logística
-- Nota: En la estructura actual no existe "Logística", se asume Ventas (código 3)
SELECT e.* 
FROM empleado e 
JOIN departamento d ON e.departamento = d.codigo 
WHERE d.nombre = 'Ventas';

-- 6) Obtener todos los datos de los empleados cuyo apellido comience por "P"
SELECT * FROM empleado WHERE apellido LIKE 'P%';

-- 7) Obtener el presupuesto total de todos los departamentos
SELECT SUM(presupuesto) AS presupuesto_total FROM departamento;

-- 8) Obtener el número de empleados en cada departamento
SELECT 
    d.nombre AS departamento,
    COUNT(e.dni) AS numero_empleados
FROM departamento d
LEFT JOIN empleado e ON d.codigo = e.departamento
GROUP BY d.codigo, d.nombre;

-- 9) Listado completo de empleados con nombre de departamento y presupuesto
SELECT 
    e.nombre,
    e.apellido,
    d.nombre AS departamento,
    d.presupuesto
FROM empleado e
JOIN departamento d ON e.departamento = d.codigo;

-- 10) Nombre y apellido de empleados en departamentos con presupuesto > 60000
SELECT 
    e.nombre,
    e.apellido
FROM empleado e
JOIN departamento d ON e.departamento = d.codigo
WHERE d.presupuesto > 60000;

-- 11) Datos de departamentos con presupuesto superior al promedio
SELECT *
FROM departamento
WHERE presupuesto > (SELECT AVG(presupuesto) FROM departamento);

-- 12) Nombres de departamentos con más de dos empleados
SELECT 
    d.nombre AS departamento
FROM departamento d
JOIN empleado e ON d.codigo = e.departamento
GROUP BY d.codigo, d.nombre
HAVING COUNT(e.dni) >= 2;