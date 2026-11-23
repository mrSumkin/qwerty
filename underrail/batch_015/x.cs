using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000385 RID: 901
[fe("coilSpider")]
public sealed class x : am2
{
	// Token: 0x060018EC RID: 6380 RVA: 0x00081458 File Offset: 0x0007F658
	public x(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("RepairWeb", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(x.a.a.a), null)
		{
			e = false
		});
		list.Add(new e1y("IdleMovement", new List<c96>
		{
			new c1j("Chitter")
			{
				c = 1f,
				d = new CharacterState?(CharacterState.Idle),
				a = 10000,
				b = "CoilSpiderChitter"
			},
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 5,
				c = 3
			},
			new aif("RestActivity")
		})
		{
			c = 0.57f
		});
		base.a(list);
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00081560 File Offset: 0x0007F760
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (base.h().aa().IsInCombat)
		{
			return false;
		}
		if (!(ecf.a(dgk.Get<dwz>(), new eru(new EntityAspectReference<amc, amc>(base.h())), null) is eu7))
		{
			return false;
		}
		d60 addon = this.Subject.a8().Zone.GetAddon<d60>();
		if (addon != null)
		{
			List<b0b> list = addon.ab4(new string[]
			{
				"coilSpiderWeb"
			});
			if (list.Count > 0)
			{
				float value = this.Subject.y6().GetPrimitivePropertyValue<float>("MaxRepairDistance", new float?(float.MaxValue)).Value;
				foreach (b0b b0b in list)
				{
					if (aw1.b(this.Subject.a8(), b0b) <= (double)value && b0b.Area == this.Subject.a8().Area)
					{
						b2x aspect = b0b.GetAspect<b2x>();
						if (aspect != null && !aspect.a())
						{
							ak1 ak = Enumerable.FirstOrDefault<ak1>(aspect.a8().l);
							if (ak != null && !ak.Formation.c(2L) && ak.f(null) == 0L)
							{
								return true;
							}
						}
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x000816EC File Offset: 0x0007F8EC
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		d60 addon = this.Subject.a8().Zone.GetAddon<d60>();
		if (addon != null)
		{
			List<b0b> list = addon.ab4(new string[]
			{
				"coilSpiderWeb"
			});
			if (list.Count > 0)
			{
				float value = this.Subject.y6().GetPrimitivePropertyValue<float>("MaxRepairDistance", new float?(float.MaxValue)).Value;
				b0b b0b = null;
				double maxValue = double.MaxValue;
				foreach (b0b b0b2 in list)
				{
					b2x aspect = b0b2.GetAspect<b2x>();
					if (aspect != null && !aspect.a())
					{
						double num = aw1.b(this.Subject.a8(), b0b2);
						if (num <= (double)value)
						{
							ak1 ak = Enumerable.FirstOrDefault<ak1>(b0b2.l);
							if (ak != null && !ak.Formation.c(2L) && ak.f(null) == 0L)
							{
								if (b0b == null)
								{
									b0b = b0b2;
								}
								else if (num < maxValue)
								{
									b0b = b0b2;
								}
							}
						}
					}
				}
				if (b0b != null)
				{
					eu7 eu = ecf.a(dgk.Get<dwz>(), new eru(new EntityAspectReference<amc, amc>(base.h())), null) as eu7;
					if (eu != null && eu.yw())
					{
						return cp.b(eu, this.Subject.a8(), b0b);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x02000387 RID: 903
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001914 RID: 6420 RVA: 0x00083334 File Offset: 0x00081534
		internal float a(bool A_0)
		{
			if (!A_0)
			{
				return 0.65f;
			}
			return 100f;
		}

		// Token: 0x04000E6A RID: 3690
		public static readonly x.a a = new x.a();

		// Token: 0x04000E6B RID: 3691
		public static Func<bool, float> b;
	}
}
