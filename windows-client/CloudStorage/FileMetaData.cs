﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStorage
{
	[Serializable]
	public class FileMetaData
	{
		public string filepath { get; set;}

		public string owner { get; set;}

		public long filesize { get; set;}

		public List<string> sharedwithclients { get; set;}

		public long versionNumber {get;set;}
		
		public bool markedForDeletion {get; set;}
		
		public FileMetaData (string filepath, string owner)
		{
			this.sharedwithclients = new List<string> ();
			this.markedForDeletion = false;
			this.filesize = 0;
			this.owner = owner;
			this.filepath = filepath;
			this.versionNumber = -1;
		}
	
		public FileMetaData cloneMetaDataObject ()
		{
			FileMetaData retObj = new FileMetaData (this.filepath, this.owner);
			retObj.filesize = this.filesize;
			retObj.sharedwithclients = new List<string> (this.sharedwithclients);
			retObj.versionNumber = this.versionNumber;
			retObj.markedForDeletion = this.markedForDeletion;
			return retObj;
		}
	}
}
