using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x020009E6 RID: 2534
[eiz("XPHWEXOBVS")]
[Serializable]
public sealed class ecp : bdw, ISerializable
{
	// Token: 0x06003C97 RID: 15511 RVA: 0x00166F94 File Offset: 0x00165194
	private ecp(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x00166F9C File Offset: 0x0016519C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C99 RID: 15513 RVA: 0x00166FA0 File Offset: 0x001651A0
	public ecp()
	{
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x00166FAC File Offset: 0x001651AC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null || serviceOrThrow.aqw() == null || serviceOrThrow.aqw().Areas.Count < 1 || serviceOrThrow.aqu().v() == null)
		{
			return;
		}
		d60 d = serviceOrThrow.aqw().a();
		if (d != null)
		{
			c5x c5x = d.ab5("torchEntity") as c5x;
			if (c5x != null)
			{
				c5x.ae = new float?(0f);
				serviceOrThrow.aqu().v().a("monolithTorch", true);
			}
		}
		foreach (b0b b0b in serviceOrThrow.aqw().Areas[0].Entities)
		{
			c5x c5x2 = (c5x)b0b;
			if (c5x2.a("voidLantern"))
			{
				bsf bsf = Enumerable.FirstOrDefault<ejt>(c5x2.RaysEmitters) as bsf;
				if (bsf != null)
				{
					bsf.Definition.Enabled = false;
					bsf.Definition.Light = new ae8(bsf.Definition.Light.d(), 0f, LightType.Increment);
					bsf.b();
				}
			}
			else
			{
				if (c5x2.o.b != null)
				{
					string a = c5x2.o.b.a;
					if (string.IsNullOrEmpty(a))
					{
						continue;
					}
					if (a.StartsWith("Objects\\Compositions\\xphw_voidtile_", StringComparison.OrdinalIgnoreCase))
					{
						c5x2.ae = new float?(0f);
					}
					if (a.StartsWith("Objects\\Compositions\\xphw_void_bunkerslab_1", StringComparison.OrdinalIgnoreCase))
					{
						etz etz = c5x2.o.b as etz;
						if (etz != null)
						{
							c5x2.SetAspect<cd0>(new cd0(c5x2)
							{
								a = etz.a,
								b = new Point(0, etz.b.Y - 1)
							});
						}
					}
					if (a.StartsWith("Walls\\xphw_bunker_large_rubble", StringComparison.OrdinalIgnoreCase))
					{
						c5x2.ae = new float?(0f);
					}
				}
				h4 aspect = c5x2.GetAspect<h4>();
				if (aspect != null)
				{
					aspect.b(false);
				}
				ws aspect2 = c5x2.GetAspect<ws>();
				if (aspect2 != null)
				{
					aspect2.a(false);
				}
			}
		}
		c5x c5x3 = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x3 == null)
		{
			return;
		}
		edk edk = new edk();
		edk.b().Add("center1");
		edk.ym(c5x3, null, null);
		c5x c5x4 = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), c5x3.Area).ao() as c5x;
		if (c5x4 != null)
		{
			amc aspect3 = c5x3.GetAspect<amc>();
			if (aspect3 != null)
			{
				aspect3.aa().b("monolithTorch", 1, false);
				if (aspect3.aa().b("monolithTorch", 1, true).Count > 0)
				{
					c5x4.b("shard");
				}
				aiw aiw = Enumerable.FirstOrDefault<aiw>(c5x3.h.b.aa().StatusEffects.Get<aiw>());
				if (aiw != null)
				{
					c5x3.h.b.aa().StatusEffects.d(aiw);
				}
				if (Enumerable.FirstOrDefault<a3w>(c5x3.h.b.aa().StatusEffects.Get<a3w>()) != null)
				{
					c5x3.h.b.aa().StatusEffects.d(aiw);
				}
				if (Enumerable.FirstOrDefault<alf>(c5x3.h.b.aa().StatusEffects.Get<alf>()) != null)
				{
					c5x3.h.b.aa().StatusEffects.d(aiw);
				}
			}
		}
	}
}
