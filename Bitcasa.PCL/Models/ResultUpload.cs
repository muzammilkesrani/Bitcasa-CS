/*
 * Bitcasa.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 07/19/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Bitcasa.PCL;

namespace Bitcasa.PCL.Models
{
    public class ResultUpload : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string parentId;
        private string type;
        private string name;
        private string extension;
        private double dateCreated;
        private double dateMetaLastModified;
        private double dateContentLastModified;
        private string mime;
        private double size;
        private string version;
        private List<string> applicationData;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId 
        { 
            get 
            {
                return this.parentId; 
            } 
            set 
            {
                this.parentId = value;
                onPropertyChanged("ParentId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("extension")]
        public string Extension 
        { 
            get 
            {
                return this.extension; 
            } 
            set 
            {
                this.extension = value;
                onPropertyChanged("Extension");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("date_created")]
        public double DateCreated 
        { 
            get 
            {
                return this.dateCreated; 
            } 
            set 
            {
                this.dateCreated = value;
                onPropertyChanged("DateCreated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("date_meta_last_modified")]
        public double DateMetaLastModified 
        { 
            get 
            {
                return this.dateMetaLastModified; 
            } 
            set 
            {
                this.dateMetaLastModified = value;
                onPropertyChanged("DateMetaLastModified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("date_content_last_modified")]
        public double DateContentLastModified 
        { 
            get 
            {
                return this.dateContentLastModified; 
            } 
            set 
            {
                this.dateContentLastModified = value;
                onPropertyChanged("DateContentLastModified");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mime")]
        public string Mime 
        { 
            get 
            {
                return this.mime; 
            } 
            set 
            {
                this.mime = value;
                onPropertyChanged("Mime");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("size")]
        public double Size 
        { 
            get 
            {
                return this.size; 
            } 
            set 
            {
                this.size = value;
                onPropertyChanged("Size");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("version")]
        public string Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("application_data")]
        public List<string> ApplicationData 
        { 
            get 
            {
                return this.applicationData; 
            } 
            set 
            {
                this.applicationData = value;
                onPropertyChanged("ApplicationData");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 