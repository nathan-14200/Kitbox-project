﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Cabinet
    {
        private List<Box> boxComposition = new List<Box>();
        private float width = 0;
        private float depth = 0;
        private float height = 0;
        private Piece corniere;
        //value of the heighest Corniere
        private float maxHeight = 375;
        //private double height;
        private Dictionary<Piece, int> composition;


        public Cabinet(float width, float depth)
        {
            this.width = width;
            this.depth = depth;
            
            
        }

        public float GetWidth()
        {
            return this.width;
        }

        public float GetDepth()
        {
            return this.depth;
        }


        public float GetHeight()
        {
            return this.height;
        }
        

        public void SetHeight(float h)
        {
            this.height = h;
        }

        public void SetCorniere(Piece p)
        {
            this.corniere = p;
        }


        public List<Box> GetBoxComposition()
        {
            return this.boxComposition;
        }

        public int AddBox(Box box)
        {
            //Has to check if not more than 7 boxes and certain height limit.            
            float heightTest = box.GetHeight() + this.height;
            if(maxHeight > heightTest)  // + height limit
            {
                boxComposition.Add(box);
                this.height += box.GetHeight();

                return 0;
            }

            return 1;            
        }

        public void DeleteBox(Box box)
        {
            //To be changed (no print)

            if(boxComposition.Contains(box))
            {
                boxComposition.Remove(box);
            }
        }


        public Dictionary<Piece, int> GetComposition()
        {
            composition = new Dictionary<Piece, int>();
            
            //Adding corniere
            composition[this.corniere] = 4;

            foreach(Box box in boxComposition)
            {
                Dictionary<Piece, int> boxComp = box.GetComposition();
                foreach(var p in boxComp)
                {
                    if(!composition.ContainsKey(p.Key))
                    {
                        composition[p.Key] = p.Value;
                    }
                    else
                    {
                        composition[p.Key] += p.Value; 
                    }
                }
            }
            return composition;
        }

        public float GetPrice()
        {
            Dictionary<Piece, int> comp = GetComposition();
            float total = 0;

            foreach(var piece in comp)
            {
                total += piece.Key.GetPrice() * piece.Value;
            }

            return total;
        }
    }
}
