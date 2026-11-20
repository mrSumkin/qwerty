using System;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000975 RID: 2421
[eiz("Dc_ArkeStationOpenGate")]
[Serializable]
public sealed class b7 : bdw, ISerializable
{
	// Token: 0x06003ACF RID: 15055 RVA: 0x0015CF7C File Offset: 0x0015B17C
	private b7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AD0 RID: 15056 RVA: 0x0015CF84 File Offset: 0x0015B184
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x0015CF88 File Offset: 0x0015B188
	public b7()
	{
	}

	// Token: 0x06003AD2 RID: 15058 RVA: 0x0015CF94 File Offset: 0x0015B194
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("dc-pp_e");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("32cb9d75-23cb-499b-8e5d-1573cc8544e7"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("d9573bb2-40fe-4a0e-ace9-b8ff6d806feb"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("5c779702-e461-4aab-a989-c1dd9e6180f6"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("1d823e5c-34a1-4df4-b096-49555b5f0f44"), aud).ao() as c5x;
				Point b = new Point(5, 0);
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers.c();
					c5x.z();
					if (aspect != null)
					{
						aspect.b = b;
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect2 = c5x2.GetAspect<cd0>();
					c5x2.TileFormationModifiers.c();
					c5x2.z();
					if (aspect2 != null)
					{
						aspect2.b = b;
					}
				}
				if (c5x3 != null)
				{
					cd0 aspect3 = c5x3.GetAspect<cd0>();
					c5x3.TileFormationModifiers.c();
					c5x3.z();
					if (aspect3 != null)
					{
						aspect3.b = b;
					}
				}
				if (c5x4 != null)
				{
					cd0 aspect4 = c5x4.GetAspect<cd0>();
					c5x4.TileFormationModifiers.c();
					c5x4.z();
					if (aspect4 != null)
					{
						aspect4.b = b;
					}
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "dc-pp_e_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
