using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInventoryManagement
{
    class InventoryFactory
    {

        //operations on Rice data --------------------------------------------
        public List<Rice> AddToInventory(List<Rice> ricelist)
        {
            Rice rc = new Rice();

            Console.Write(" Enter Brand : ");
            rc.Brand = Console.ReadLine();
            string searchTerm = rc.Brand;
            int newAdd = 1;
            foreach (Rice r in ricelist)
            {
                if ((r.Brand).ToUpper().Equals(searchTerm.ToUpper()))
                {
                    Console.WriteLine(" New Brand already present.");
                    newAdd = 0;
                    break;
                }
            }
            if (newAdd == 1)
            {
                Console.Write(" Enter price of 1kg : ");
                rc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight : ");
                rc.Weight = Convert.ToInt32(Console.ReadLine());
                ricelist.Add(rc);
                Console.WriteLine(" Added. ");
            }
            return ricelist;
        }

        public void DisplayInventory(List<Rice> ricelist)
        {
            string riceDisplay;

            foreach (Rice r in ricelist)
            {
                riceDisplay = " Brand : " + r.Brand + "\t Weight in kg : " + r.Weight + "\t Price : " + r.PricePerKg + "\t Total : " + (r.PricePerKg * r.Weight);
                Console.WriteLine(riceDisplay);
            }
        }

        public List<Rice> RemoveFromInventory(List<Rice> ricelist)
        {
            Console.Write(" Enter Rice Brand to be deleted : ");
            string searchTerm = Console.ReadLine();
            if (ricelist.Remove(ricelist.Find(term => term.Brand.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.WriteLine(" {0} info Deleted. ", searchTerm);
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return ricelist;
        }

        public List<Rice> EditInventory(List<Rice> ricelist)
        {
            Rice rc = new Rice();

            Console.Write(" Enter brand name of rice to update : ");
            string searchTerm = Console.ReadLine();
            if (ricelist.Remove(ricelist.Find(term => term.Brand.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.Write(" Enter Brand : ");
                rc.Brand = Console.ReadLine();
                Console.Write(" Enter price of 1kg : ");
                rc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight  : ");
                rc.Weight = Convert.ToInt32(Console.ReadLine());
                ricelist.Add(rc);
                Console.WriteLine(" Edit Success. ");
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return ricelist;
        }


        //operations on pulses data --------------------------------------------

        public List<Pulses> AddToInventory(List<Pulses> pulseslist)
        {
            Pulses pc = new Pulses();

            Console.Write(" Enter Brand : ");
            pc.Brand = Console.ReadLine();
            string searchTerm = pc.Brand;
            int newAdd = 1;
            foreach (Pulses p in pulseslist)
            {
                if ((pc.Brand).ToUpper().Equals(searchTerm.ToUpper()))
                {
                    Console.WriteLine(" New Brand already present.");
                    newAdd = 0;
                    break;
                }
            }
            if (newAdd == 1)
            {
                Console.Write(" Enter price of 1kg : ");
                pc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight : ");
                pc.Weight = Convert.ToInt32(Console.ReadLine());
                pulseslist.Add(pc);
                Console.WriteLine(" Added. ");
            }
            return pulseslist;
        }

        public void DisplayInventory(List<Pulses> pulseslist)
        {
            string pulsesDisplay = string.Empty;

            foreach (Pulses p in pulseslist)
            {
                pulsesDisplay = " Brand : " + p.Brand + "\t Weight in kg : " + p.Weight + "\t Price : " + p.PricePerKg + "\t Total : " + (p.PricePerKg * p.Weight);
                Console.WriteLine(pulsesDisplay);
            }
        }

        public List<Pulses> EditInventory(List<Pulses> pulseslist)
        {
            Pulses pc = new Pulses();

            Console.Write(" Enter Pulses Brand to update : ");
            string searchTerm = Console.ReadLine();
            if (pulseslist.Remove(pulseslist.Find(term => term.Brand.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.Write(" Enter Brand : ");
                pc.Brand = Console.ReadLine();
                Console.Write(" Enter price of 1kg : ");
                pc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight  : ");
                pc.Weight = Convert.ToInt32(Console.ReadLine());
                pulseslist.Add(pc);
                Console.WriteLine(" Edit Success. ");
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return pulseslist;
        }

        public List<Pulses> RemoveFromInventory(List<Pulses> pulseslist)
        {
            Console.Write(" Enter Pulses Brand to be deleted : ");
            string searchTerm = Console.ReadLine();
            if (pulseslist.Remove(pulseslist.Find(term => term.Brand.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.WriteLine(" {0} info Deleted. ", searchTerm);
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return pulseslist;
        }


        //operations on wheat data --------------------------------------------

        public List<Wheat> AddToInventory(List<Wheat> wheatlist)
        {
            Wheat wc = new Wheat();

            Console.Write(" Enter Brand : ");
            wc.Brand = Console.ReadLine();
            string searchTerm = wc.Brand;
            int newAdd = 1;
            foreach (Wheat p in wheatlist)
            {
                if ((p.Brand).ToUpper().Equals(searchTerm.ToUpper()))
                {
                    Console.WriteLine(" New Brand already present.");
                    newAdd = 0;
                    break;
                }
            }
            if (newAdd == 1)
            {
                Console.Write(" Enter price of 1kg : ");
                wc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight : ");
                wc.Weight = Convert.ToInt32(Console.ReadLine());
                wheatlist.Add(wc);
                Console.WriteLine(" Added. ");
            }
            return wheatlist;
        }

        public void DisplayInventory(List<Wheat> wheatlist)
        {
            string wheatDisplay;

            foreach (Wheat w in wheatlist)
            {
                wheatDisplay = " Brand : " + w.Brand + "\t Weight in kg : " + w.Weight + "\t Price : " + w.PricePerKg + "\t Total : " + (w.PricePerKg * w.Weight);
                Console.WriteLine(wheatDisplay);
            }
        }

        public List<Wheat> EditInventory(List<Wheat> wheatlist)
        {
            Wheat wc = new Wheat();

            Console.Write(" Enter Wheat Brand to update : ");
            string searchTerm = Console.ReadLine();
            if (wheatlist.Remove(wheatlist.Find(term => term.Brand.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.Write(" Enter Brand : ");
                wc.Brand = Console.ReadLine();
                Console.Write(" Enter price of 1kg : ");
                wc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight  : ");
                wc.Weight = Convert.ToInt32(Console.ReadLine());
                wheatlist.Add(wc);
                Console.WriteLine(" Edit Success. ");
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return wheatlist;
        }

        public List<Wheat> RemoveFromInventory(List<Wheat> wheatlist)
        {
            Console.Write(" Enter Wheat Brand to be deleted : ");
            string searchTerm = Console.ReadLine();
            if (wheatlist.Remove(wheatlist.Find(term => term.Brand.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.WriteLine(" {0} info Deleted. ", searchTerm);
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return wheatlist;
        }

    }
}