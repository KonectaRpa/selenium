// Maximizar Ventana //

driver.Manage().Window.Maximize();

// Cambiar Posicion del navegador //

driver.Manage().Window.Position = new Point(0, 0);

// Cambiar pestaña por Index
// la variable "index" corresponde a la posicion de la pestaña a la cual se cambiara el foco //

ArrayList tabs = new ArrayList(driver.WindowHandles);
driver.SwitchTo().Window(tabs[index].ToString());

// Cambiar a la ultima pestaña abierta //

ArrayList tabs = new ArrayList(driver.WindowHandles);
driver.SwitchTo().Window(tabs[tabs.Count - 1].ToString());

// Cerrar pop up con boton de aceptar //

driver.SwitchTo().Alert().Accept();