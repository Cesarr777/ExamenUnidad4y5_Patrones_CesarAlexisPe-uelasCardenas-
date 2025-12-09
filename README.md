# 🖥️ Sistema de Gestión de Equipos  
## **Examen Unidad 4 y 5 – Patrones de Diseño**

---

## 📋 Información del Proyecto

**Alumno:** Cesar Alexis Peñuelas Cardenas  
**Número de Control:** 22210335  
**Materia:** Patrones de Diseño  
**Examen:** Unidad 4 y 5  

---

## 📖 Descripción

Sistema de gestión de equipos que implementa múltiples patrones de diseño, organizado bajo una arquitectura de capas.  
Permite ocupar y liberar equipos, gestionando estados y recursos de forma óptima mediante patrones creacionales, estructurales y de comportamiento.

---

# 🏗️ Arquitectura

Se aplicó una **Arquitectura en Capas (Layered Architecture)** estructurada así:

📦 Sistema de Gestión de Equipos
├── 🖥️ Capa de Presentación (CapaPresentacion)
│ └── Interfaz de usuario y menús
├── ⚙️ Capa de Aplicación (CapaAplicacion)
│ └── Casos de uso y coordinación del sistema
├── 💼 Capa de Negocio (CapaNegocio)
│ └── Entidades, reglas y lógica de dominio
└── 💾 Capa de Datos (CapaDatos)
└── Repositorios, Singleton y Object Pool

---

# 🎨 Patrones de Diseño Implementados

## **1️⃣ Patrones Creacionales**

### 🟦 Singleton (2.5)
**Archivo:** `AdministradorEquipos.cs`  
**Propósito:** Garantiza una única instancia del administrador de equipos.  
**Implementación:** `Lazy<T>` (thread-safe).  

---

### 🟩 Object Pool (2.6)
**Archivo:** `PoolEquipos.cs`  
**Propósito:** Reutiliza objetos del tipo `Equipos` para evitar creación/destrucción innecesaria.  
**Beneficio:** Optimización de recursos.  

---

## **2️⃣ Patrón Estructural**

### 🟧 Facade (3.5)
**Archivo:** `SistemaEquiposFacade.cs`  
**Propósito:** Simplifica el acceso al sistema.  
**Beneficio:** Oculta complejidad interna del Singleton, Pool y State.  

---

## **3️⃣ Patrón de Comportamiento**

### 🟨 State (4.2)
**Archivos:**  
- `IEstadoEquipo.cs`  
- `EstadoDisponible.cs`  
- `EstadoOcupado.cs`

**Estados:**  
- Disponible  
- Ocupado  

**Propósito:** Cambiar comportamiento del equipo dinámicamente sin condicionales.  

---

## **4️⃣ Patrón Arquitectónico**

### 🏛️ Arquitectura en Capas (5.1.1)
**Ubicación:** En toda la estructura del proyecto.  
**Beneficio:** Alta cohesión, bajo acoplamiento.  

---

# 📂 Estructura del Proyecto

Examen_Unidad4y5_PeñuelasCardenasCesarAlexis/
│
├── CapaPresentacion/
│ └── Program.cs # Punto de entrada
│
├── CapaAplicacion/
│ └── SistemaEquiposFacade.cs # Implementación de Facade
│
├── CapaNegocio/
│ ├── Equipos.cs # Entidad principal
│ ├── IEstadoEquipo.cs # Interface del patrón State
│ ├── EstadoDisponible.cs # Estado concreto
│ └── EstadoOcupado.cs # Estado concreto
│
└── CapaDatos/
├── AdministradorEquipos.cs # Singleton
└── PoolEquipos.cs # Object Pool

🚀 Funcionalidades
✔ Mostrar estatus de equipos

✔ Ocupar un equipo asignándolo a un cliente

✔ Liberar un equipo

✔ Gestión automática entre estados

✔ Validaciones según el estado actual

💻 Tecnologías Usadas
Lenguaje: C# (.NET)

IDE: VS Code

Framework: .NET 6+

🏆 Conclusión
Este proyecto demuestra la implementación exitosa de:

2 Patrones Creacionales (Singleton, Object Pool)

1 Patrón Estructural (Facade)

1 Patrón de Comportamiento (State)

1 Patrón Arquitectónico (Capas)

El sistema es escalable, mantenible y flexible, cumpliendo completamente con los requerimientos de la Unidad 4 y 5.


