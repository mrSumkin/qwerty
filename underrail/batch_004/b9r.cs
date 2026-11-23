using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200147E RID: 5246
[eiz("XF")]
[Serializable]
public sealed class b9r : a6k, ISerializable
{
	// Token: 0x0600765A RID: 30298 RVA: 0x00320814 File Offset: 0x0031EA14
	private b9r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600765B RID: 30299 RVA: 0x00320820 File Offset: 0x0031EA20
	public b9r()
	{
	}

	// Token: 0x0600765C RID: 30300 RVA: 0x0032082C File Offset: 0x0031EA2C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null && serviceOrThrow.aqu() != null)
		{
			eym.a(c5x, (double)aju.br);
			ei7 aspect = c5x.GetAspect<ei7>();
			if (aspect != null)
			{
				if (aspect.d())
				{
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value && cuo.a.NextDouble() < aspect.a())
					{
						this.a(c5x);
						List<ak1> list = aw1.a(c5x, true);
						HashSet<c5x> hashSet = new HashSet<c5x>();
						foreach (ak1 ak in list)
						{
							foreach (b0b b0b in ak.c.Values)
							{
								c5x c5x2 = (c5x)b0b;
								if (!hashSet.Contains(c5x2))
								{
									ei7 aspect2 = c5x2.GetAspect<ei7>();
									if (aspect2 != null && aspect2.d() && cuo.a.NextDouble() < aspect2.a())
									{
										this.a(c5x2);
									}
									hashSet.Add(c5x2);
								}
							}
						}
						return dc4.c;
					}
					if (cuo.a.NextDouble() < 0.75)
					{
						List<ak1> list2 = aw1.b(c5x, true);
						int num = 1 + cuo.a.Next(3);
						for (int i = 0; i <= num; i++)
						{
							if (list2.Count > 0)
							{
								int index = cuo.a.Next(list2.Count);
								ak1 ak2 = list2[index];
								vq.a("creatures\\borer", ak2.Zone, new bt4(ak2.Area.y8(), ak2.Location.a()), false);
								list2.RemoveAt(index);
							}
						}
					}
					coh coh = new d48(new LibraryItemDefinitionProvider<dj3>("Plot\\ImpureChromiumBlade"));
					coh.Stacks = 1 + cuo.a.Next(3);
					mk mk = new mk();
					mk.StaticItems.z3(coh, true);
					mk.GiveTo = bvl.c;
					mk.ym(null, base.vg().q(), null);
					aspect.b(false);
					aspect.a(new TimeSpan?(serviceOrThrow.aqu().p() + TimeSpan.FromHours(2.5)));
					c5x.c().a("ChromiumBladeChip");
					return dc4.c;
				}
			}
			else if (c5x.h.b != null && c5x.h.b.aa().Passive)
			{
				c5x.h.b.a(null, false);
			}
		}
		return dc4.e;
	}

	// Token: 0x0600765D RID: 30301 RVA: 0x00320B38 File Offset: 0x0031ED38
	private bool a(c5x A_0)
	{
		c1a a_ = A_0.Zone;
		aud aud = A_0.Area;
		Vector3 a_2 = A_0.Location;
		HorizontalDirection a_3 = A_0.VisualDirection;
		int num = 1;
		if (A_0.o.b != null)
		{
			int.TryParse(A_0.o.b.a.Substring(A_0.o.b.a.Length - 1, 1), NumberStyles.Number, CultureInfo.InvariantCulture, out num);
			if (num <= 0)
			{
				num = 1;
			}
		}
		c5x c5x = vq.a("creatures\\bladeling", a_, new bt4(aud.y8(), a_2), false);
		if (c5x != null)
		{
			A_0.w();
			A_0.an();
			c5x.VisualDirection = a_3;
			if (c5x.h.b != null && c5x.i.b != null && c5x.t.b != null)
			{
				c5x.h.b.a("bladeling" + num.ToString());
				c5x.t.b.a(false);
				c5x.h.b.ap = new CharacterState?(CharacterState.Custom2);
				c5x.h.b.aq = new int?(0);
				awx awx = new awx();
				awx.b(false);
				awx.c(false);
				awx.a(false);
				awx.ad().Add(new e4t(c5x.h.b, CharacterState.Custom2, cux.a, 0, null, 1));
				awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x), null));
				awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x), null));
				awx.ad().Add(new a4s(new clv(true), null, new ar7(c5x), null));
				c5x.i.b.b(awx, atp.a);
			}
			return true;
		}
		return false;
	}
}
