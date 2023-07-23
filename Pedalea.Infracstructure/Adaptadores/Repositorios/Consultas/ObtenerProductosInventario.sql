SELECT p.Id, 
	   p.Nombre, 
	   p.Descripcion,
	   p.IsOutlet,
	   p.Cantidad,
	   p.Color,
	   p.Talla,
	   p.Precio,
	   p.DepartamentoVentaId
FROM  [dbo].Producto p