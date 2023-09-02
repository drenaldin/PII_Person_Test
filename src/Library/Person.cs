//-------------------------------------------------------------------------
// <copyright file="Person.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace Ucu.Poo.Persons
{
    /// <summary>
    /// Esta clase representa una persona con clase y apellido.
    /// </summary>
    public class Person
    {
        private string name;

        private string familyName;

        private string id;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Person"/> con el nombre y apellidos recibidos como argumento.
        /// </summary>
        /// <param name="name">El nombre de la persona.</param>
        /// <param name="familyName">El apellido de la persona.</param>
        public Person(string name, string familyName)
        {
            this.Name = name;
            this.FamilyName = familyName;
        }

        /// <summary>
        /// Obtiene o establece el nombre de la persona. El texto no tiene espacios al comienzo ni al final -los espacios son removidos al asignar el texto-.
        /// </summary>
        /// <value>El nombre de la persona.</value>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece el apellido de la persona. El texto no tiene espacios al comienzo ni al final -los espacios son removidos al asignar el texto-.
        /// </summary>
        /// <value>El apellido de la persona.</value>
        public string FamilyName
        {
            get
            {
                return this.familyName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.familyName = value;
                }
            }
        }

        /// <summary>
        ///  Obtiene el nombre completo de la persona concatenando el nombre y el apellido.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{this.Name} {this.FamilyName}";
            }
        }

        /// <summary>
        /// Obtiene o establece la cédula de identidad de la persona.
        /// </summary>
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (!IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        /// <summary>
        /// Esta persona se presenta con otra.
        /// </summary>
        /// <param name="person">La persona a la cual presentarse.</param>
        public void IntroduceTo(Person person)
        {
            if (person != null)
            {
                Console.WriteLine($"Hola, {person.Name}, mi nombre es {this.Name}");
            }
        }
    }
}
