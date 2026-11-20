using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002CC RID: 716
[apc("hunchbackMutant")]
public sealed class js : esk
{
	// Token: 0x06001546 RID: 5446 RVA: 0x00062B28 File Offset: 0x00060D28
	public override bool h3()
	{
		return false;
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00062B2C File Offset: 0x00060D2C
	public js()
	{
		this.ds.Add("triedToPickUpObject");
		this.a = new ej0();
		this.c = new ej0();
		this.b = new TryInvokeSpecialAbilityNode<b0t>();
		this.b.b = new Func<e1k, object>(js.a.a.a);
		this.d = new TryInvokeSpecialAbilityNode<cv5>();
		this.d.a = e8t.b;
		this.d.a = this.a;
		this.d.b = this.p.a;
		this.c.a = new Action<ej0>(js.a.a.a);
		arr arr = Enumerable.FirstOrDefault<arr>(this.a.a, new Func<arr, bool>(this.a));
		if (arr != null)
		{
			this.a.a.Remove(arr);
		}
		this.a.a.InsertRange(1, new arr[]
		{
			new arr(this.d, new Func<e1k, bool>(this.c)),
			new arr(this.b, new Func<e1k, bool>(this.b)),
			new arr(this.a, new Func<e1k, bool>(this.a))
		});
		this.a.a = new Action<ej0>(this.a);
		this.a.a = this.a;
		this.c.a = this.a;
		this.b.a = this.c;
		this.b.b = this.c;
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00062D00 File Offset: 0x00060F00
	private new c5x a(e1k A_0, double A_1 = 3.0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null && amc.a8() != null)
		{
			d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
			HashSet<r0> hashSet = A_0.c().b(serviceOrThrow);
			if (hashSet != null)
			{
				List<KeyValuePair<double, c5x>> list = new List<KeyValuePair<double, c5x>>();
				foreach (r0 r in hashSet)
				{
					ak1 ak = A_0.g().a8().Area.a(r.a.a());
					if (ak != null && aw1.a(A_0.g().a8(), ak) <= A_1)
					{
						foreach (b0b b0b in ak.Entities)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.GetAspect<c5i>() != null)
							{
								double num = aw1.b(A_0.g().a8(), c5x);
								list.Add(new KeyValuePair<double, c5x>(num * 1000.0 - (double)c5x.h, c5x));
							}
						}
					}
				}
				if (list.Count > 0)
				{
					c5x c5x2 = Enumerable.FirstOrDefault<c5x>(Enumerable.Select<KeyValuePair<double, c5x>, c5x>(Enumerable.OrderBy<KeyValuePair<double, c5x>, double>(list, new Func<KeyValuePair<double, c5x>, double>(js.a.a.a)), new Func<KeyValuePair<double, c5x>, c5x>(js.a.a.b)));
					if (c5x2 != null)
					{
						return c5x2;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x00062ED4 File Offset: 0x000610D4
	[CompilerGenerated]
	private new bool a(arr A_0)
	{
		return A_0.a == this.c5;
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00062EE4 File Offset: 0x000610E4
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (ckw.a(A_0.g().a8()) != null)
		{
			return false;
		}
		if (!this.d.b(A_0))
		{
			return false;
		}
		bzv bzv = new bzv(A_0.c().y6());
		amc amc = bzv.g();
		if (amc != null)
		{
			blk blk = bzv.c(amc.a8().qe());
			double num = aw1.b(A_0.g().a8(), amc.a8());
			if (blk != null && blk.b() && num > 3.0 && num <= (double)(cv5.f - 1) && !amc.aa().StatusEffects.a(ef2.a))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00062FB0 File Offset: 0x000611B0
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (this.b.b(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			string classPropertyValue = A_0.g().aa().CustomProperties.GetClassPropertyValue<string>(ddm.i);
			if (!string.IsNullOrEmpty(classPropertyValue) && ckw.a(classPropertyValue) != null)
			{
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					float num = cmb.b((int)A_0.g().aa().Offense.u().TypedDefinition.ad());
					if (num > 2f || num == -1f)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00063060 File Offset: 0x00061260
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		bool flag = !A_0.d().GetPrimitivePropertyValue<bool>("triedToPickUpObject", new bool?(false)).Value;
		double a_ = 3.0;
		amc amc = new bzv(A_0.c().y6()).g();
		string classPropertyValue = A_0.g().aa().CustomProperties.GetClassPropertyValue<string>(ddm.i);
		if (amc != null && amc.aa().Vehicle != null && string.IsNullOrEmpty(classPropertyValue))
		{
			a_ = 10.0;
		}
		return flag && ckw.a(A_0.g().a8()) == null && this.a(A_0, a_) != null;
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x0006311C File Offset: 0x0006131C
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		A_0.b().d()["triedToPickUpObject"] = true;
		double a_ = 3.0;
		amc amc = new bzv(A_0.b().c().y6()).g();
		A_0.b().g().aa().CustomProperties.GetClassPropertyValue<string>(ddm.i);
		if (amc != null && amc.aa().Vehicle != null)
		{
			a_ = 10.0;
		}
		c5x c5x = this.a(A_0.b(), a_);
		if (c5x != null)
		{
			dtb dtb = new dtb();
			dtb.a(m7.k);
			dtb.ad().Add(new bm3(5 * dz6.b(100)));
			dtb.ad().Add(new a4s(new dyq(), new ar7(A_0.b().g().a8()), new ar7(c5x), null));
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			awx.a(false);
			awx.ad().Add(new fk(A_0.b().g().a8().k.b, c5x, null, true, 0));
			awx.ad().Add(new ez4(new a55(c5x.Zone), dtb, atp.a));
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom3, dz6.b(100), 0, null, 1));
			A_0.b().i().b(awx, atp.a);
		}
	}

	// Token: 0x04000BFF RID: 3071
	private new ej0 a;

	// Token: 0x04000C00 RID: 3072
	private new TryInvokeSpecialAbilityNode<b0t> b;

	// Token: 0x04000C01 RID: 3073
	private new ej0 c;

	// Token: 0x04000C02 RID: 3074
	public new TryInvokeSpecialAbilityNode<cv5> d;

	// Token: 0x020002CD RID: 717
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x000632E0 File Offset: 0x000614E0
		internal object a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00063348 File Offset: 0x00061548
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("triedToPickUpObject");
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00063360 File Offset: 0x00061560
		internal double a(KeyValuePair<double, c5x> A_0)
		{
			return A_0.Key;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0006336C File Offset: 0x0006156C
		internal c5x b(KeyValuePair<double, c5x> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x04000C03 RID: 3075
		public static readonly js.a a = new js.a();

		// Token: 0x04000C04 RID: 3076
		public static Func<e1k, object> b;

		// Token: 0x04000C05 RID: 3077
		public static Action<ej0> c;

		// Token: 0x04000C06 RID: 3078
		public static Func<KeyValuePair<double, c5x>, double> d;

		// Token: 0x04000C07 RID: 3079
		public static Func<KeyValuePair<double, c5x>, c5x> e;
	}
}
