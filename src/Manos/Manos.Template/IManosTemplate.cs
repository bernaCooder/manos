

using System;

using Mango;
using Mango.Server;

namespace Mango.Templates {
	
	
	public interface IMangoTemplate
	{
		void Render (IManosContext context, object the_arg);
		void RenderToResponse (IHttpResponse response, object the_arg);
	}
	
}

