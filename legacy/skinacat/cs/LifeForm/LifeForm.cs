using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeFormCS {

    /// <summary>
    /// This is the Base Class for the LifeForm Application. 
    /// All other LifeForms will inherit from this class.
    /// </summary>
	public class LifeForm : iLifeForm
	{
	
        //
        // Initialize variables. These will be 'protected' so they will retain their values 
        //  while still remaining accessible when inherited. This protected status is also 
        // the reason we will need to create separate public get and set methods, as the get
        // and set methods implied in the variables will only be accessible internally 
        // within the class, and those that inherit from it.
        // 	
		protected int _id { set; get; }
		protected string _kingdom { set; get; }
		protected string _phylum { set; get; }
		protected string _class { set; get; }
		protected string _order { set; get; }
		protected string _family { set; get; }
		protected string _genus { set; get; }
		protected string _species { set; get; }
		

        /// <summary>
        /// Base class constructor
        /// </summary>
        /// <param name="_id">int</param>
        public LifeForm(int _id)
        {
            this._construct(_id);
        } 
        
        /// <summary>
        /// This method actually does the work of the constructor.
        /// </summary>
        /// <param name="_id">int</param        
        public void _construct(int _id)
        {
            this._id = _id;
        }
        
        /// <summary>
        /// Sets the value of the _kingdom variable. Accepts one int parameter.
        /// </summary>
        /// <param name="_kingdom">string</param>
        public void set_kingdom(string _kingdom)
        {
            this._kingdom = _kingdom;
        }
        
        /// <summary>
        /// Gets the value of the _kingdom variable. Accepts one string parameter.
        /// </summary>
        /// <returns>string</returns>        
        public string get_kingdom()
        {
            return this._kingdom;
        }
        
        /// <summary>
        /// Sets the value of the _phylum variable. Accepts one string parameter.
        /// </summary>
        /// <param name="_class"></param>        
        public void set_phylum(string _phylum)
        {
            this._phylum = _phylum;
        }
        
        /// <summary>
        /// Gets the value of the _phylum variable.
        /// </summary>
        /// <returns>string</returns>        
        public string get_phylum()
        {
            return this._phylum;
        }
        
        /// <summary>
        /// Sets the value of the _class variable. Accepts one string parameter.
        /// </summary>
        /// <param name="_order">string</param>        
        public void set_class(string _class)
        {
            this._class = _class;
        }
        
        /// <summary>
        /// Gets the value of the _class variable.
        /// </summary>
        /// <returns>string</returns>
        public string get_class()
        {
            return this._class;
        }
        
        /// <summary>
        /// Sets the value of the _order variable. Accepts one string parameter.
        /// </summary>
        /// <param name="_family">string</param>        
        public void set_order(string _order)
        {
            this._order = _order;
        }
        
        /// <summary>
        /// Gets the value of the _order variable.
        /// </summary>
        /// <returns>string</returns>
        public string get_order()
        {
            return this._order;
        }
        
        /// <summary>
        /// Sets the value of the _family variable. Accepts one string parameter.
        /// </summary>
        /// <param name="_family"></param>        
        public void set_family(string _family)
        {
            this._family = _family;
        }
        
		/// <summary>
        /// Gets the value of the _family variable.
        /// </summary>
        /// <returns>string</returns>
        public string get_family()
        {
            return this._family;
        }
        
        /// <summary>
        /// Sets the value of the _genus variable. Accepts one string parameter.
        /// </summary>
        /// <param name="_genus">string</param>
        public void set_genus(string _genus)
        {
            this._genus = _genus;
        }
        
        /// <summary>
        /// Gets the value of the _genus variable.
        /// </summary>
        /// <returns>string</returns>
        public string get_genus()
        {
            return this._genus;
        }
        
        /// <summary>
        /// Sets the value of the _species variable. Accepts one string parameter.
        /// </summary>
        /// <param name="_species">string</param>
        public void set_species(string _species)
        {
            this._species = _species;
        }
        
        /// <summary>
        /// Gets the value of the _species variable.
        /// </summary>
        /// <returns>string</returns>
        public string get_species()
        {
            return this._species;
        }
		
		
	}
	
}
