using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000DE RID: 222
public class d93 : ISurrogateSelector
{
	// Token: 0x060004E2 RID: 1250 RVA: 0x000164E8 File Offset: 0x000146E8
	public void ChainSelector(ISurrogateSelector selector)
	{
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x000164EC File Offset: 0x000146EC
	public ISurrogateSelector GetNextSelector()
	{
		return null;
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x000164F4 File Offset: 0x000146F4
	public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
	{
		if (type == typeof(Color))
		{
			selector = this;
			return cxm.a;
		}
		if (type == typeof(Vector2))
		{
			selector = this;
			return sm.a;
		}
		if (type == typeof(Vector3))
		{
			selector = this;
			return fl.a;
		}
		if (type == typeof(Point))
		{
			selector = this;
			return ccx.a;
		}
		if (type == typeof(Matrix))
		{
			selector = this;
			return blz.a;
		}
		selector = null;
		return null;
	}
}
