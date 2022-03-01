﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class PhoneBook
    {
        public List<IPhoneBookItem> PhoneBookEntries { get; set; }

        public PhoneBook()
        {
            PhoneBookEntries = new List<IPhoneBookItem>();
        }
        public string GetPhoneBook()
        {
            string phonebook = "";
            foreach (string item in PhoneBookEntries)
            {
                phonebook += item.GetContactSummary() + "\n\n";
            }
            return phonebook;
        }

    }
}
