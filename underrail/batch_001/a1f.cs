using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000974 RID: 2420
[eiz("Dc_OpenArkePlantToOfficeGate")]
[Serializable]
public sealed class a1f : bdw, ISerializable
{
	// Token: 0x06003ACB RID: 15051 RVA: 0x0015CEE4 File Offset: 0x0015B0E4
	private a1f(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003ACC RID: 15052 RVA: 0x0015CEEC File Offset: 0x0015B0EC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003ACD RID: 15053 RVA: 0x0015CEF0 File Offset: 0x0015B0F0
	public a1f()
	{
	}

	// Token: 0x06003ACE RID: 15054 RVA: 0x0015CEFC File Offset: 0x0015B0FC
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("dc-pp_m");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("f4f65901-4c84-4be0-ae73-c3e13a257a68"), aud).ao() as c5x;
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers.c();
					c5x.z();
					if (aspect != null)
					{
						aspect.b = new Point(3, 0);
					}
				}
			}
		}
	}
}
