//
// System.Data.ObjectSpaces.ObjectKeyManager.cs
//
// Author:
//   Mark Easton (mark.easton@blinksoftware.co.uk)
//   Tim Coleman (tim@timcoleman.com)
//
// (C) BLiNK Software Ltd.  http://www.blinksoftware.co.uk
// Copyright (C) Tim Coleman, 2003
//

#if NET_1_2

namespace System.Data.ObjectSpaces {
        public abstract class ObjectKeyManager 
        {
                [MonoTODO]
                public override bool Equals (object obj) 
		{
			throw new NotImplementedException ();
		}

                [MonoTODO]
                public override int GetHashCode () 
		{
			throw new NotImplementedException ();
		}
        }
}

#endif
