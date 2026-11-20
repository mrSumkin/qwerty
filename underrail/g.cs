using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000A6C RID: 2668
[eiz("TTTJ")]
[Serializable]
public sealed class g : cze, ISerializable
{
	// Token: 0x06003EF9 RID: 16121 RVA: 0x0017CF18 File Offset: 0x0017B118
	private g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EFA RID: 16122 RVA: 0x0017CF24 File Offset: 0x0017B124
	public g()
	{
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x0017CF30 File Offset: 0x0017B130
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				a3f aspect = c5x.GetAspect<a3f>();
				if (aspect != null)
				{
					int? primitivePropertyValue = aspect.a().GetPrimitivePropertyValue<int>("TentacleType", null);
					if (primitivePropertyValue != null)
					{
						object obj = null;
						if (A_2 != null)
						{
							A_2.TryGetValue("tickCount", out obj);
						}
						int num = (obj is int) ? ((int)obj) : 0;
						bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
						int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_tchortRegenTanksDestroyed", new int?(0)).Value;
						int num2 = 4 + value2 * 2;
						if (value2 >= 4)
						{
							num2 += 8;
						}
						if (!value && num >= num2)
						{
							Vector3 vector = A_1.Location;
							aud aud = A_1.Area;
							HorizontalDirection a_ = A_1.VisualDirection;
							A_1.w();
							A_1.an();
							c5x c5x2 = vq.a("creature\\critters\\PrimeTentacle" + primitivePropertyValue.Value.ToString(), aud.Zone, new bt4(aud.y8(), vector), false);
							if (c5x2 != null)
							{
								aud a_2 = aud;
								Vector3 a_3 = vector;
								HorizontalDirection? a_4 = null;
								string a_5 = "TentacleTumorBurst";
								int a_6 = 1;
								double maxValue = double.MaxValue;
								float? a_7 = dz6.b();
								boj.a(a_2, a_3, a_4, a_5, a_6, maxValue, null, null, a_7, null);
								c5x2.c().a("TentacleTumorBurst");
								c5x2.VisualDirection = a_;
								if (c5x2.i.b != null && c5x2.h.b != null)
								{
									awx awx = new awx();
									awx awx2 = awx;
									awx2.a(awx2.kh() | (m7.b | m7.k));
									awx.ad().Add(new e4t(c5x2.h.b, CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
									c5x2.i.b.b(awx, atp.a);
								}
							}
						}
					}
				}
			}
		}
	}
}
