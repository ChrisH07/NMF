﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Wenn der Code neu generiert wird, gehen alle Änderungen an dieser Datei verloren
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMF.Transformations.Example.FamilyRelations
{

    public class Root
    {
        public ICollection<Person> People
        {
            get;
            private set;
        }

        public Root()
        {
            People = new List<Person>();
        }

    }
}

