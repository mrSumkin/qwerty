using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A6D RID: 2669
[eiz("TSTTJ")]
[Serializable]
public sealed class cp4 : cze, ISerializable
{
	// Token: 0x06003EFC RID: 16124 RVA: 0x0017D17C File Offset: 0x0017B37C
	private cp4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x0017D188 File Offset: 0x0017B388
	public cp4()
	{
	}

	// Token: 0x06003EFE RID: 16126 RVA: 0x0017D194 File Offset: 0x0017B394
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_tchb_tentacleTrueDeathTime", new bool?(false)).Value;
			if (!value && !value2)
			{
				c5x c5x = A_1 as c5x;
				if (c5x != null)
				{
					Vector3 a_ = A_1.Location;
					aud aud = A_1.Area;
					HorizontalDirection a_2 = A_1.VisualDirection;
					c5x c5x2 = vq.a("object\\natural\\TentacleTumor", aud.Zone, new bt4(aud.y8(), a_), false);
					if (c5x2 != null)
					{
						a3f aspect = c5x.GetAspect<a3f>();
						if (aspect != null)
						{
							int? primitivePropertyValue = aspect.a().GetPrimitivePropertyValue<int>("TentacleType", null);
							if (primitivePropertyValue != null)
							{
								a3f aspect2 = c5x2.GetAspect<a3f>();
								if (aspect2 != null)
								{
									aspect2.a()["TentacleType"] = primitivePropertyValue.Value;
								}
							}
						}
						c5x2.VisualDirection = a_2;
						c5x2.ae = new float?(0f);
						dm aspect3 = c5x2.GetAspect<dm>();
						if (aspect3 != null)
						{
							List<cze> list = aspect3.d();
							ch3 ch = new ch3();
							ch.a(null);
							list.Add(ch);
							aspect3.d().Add(new vn());
						}
						e3l e3l = c5x2.GetAspect<e3l>();
						if (e3l == null)
						{
							e3l = new e3l(c5x2);
							c5x2.SetAspect<e3l>(e3l);
						}
						e3l.a.Add("tentacleTumor");
						e3l.a();
					}
				}
			}
		}
	}
}
