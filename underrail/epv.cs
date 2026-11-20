using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002D2 RID: 722
[apc("lemurianStrongman")]
public sealed class epv : esk
{
	// Token: 0x06001571 RID: 5489 RVA: 0x000645C4 File Offset: 0x000627C4
	public epv()
	{
		this.ds.Add("triedToPickUpObject");
		this.a = new ej0();
		this.c = new ej0();
		this.b = new TryInvokeSpecialAbilityNode<b0t>();
		this.b.b = new Func<e1k, object>(epv.a.a.a);
		this.c.a = new Action<ej0>(epv.a.a.a);
		this.a.a.InsertRange(1, new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.b)),
			new arr(this.a, new Func<e1k, bool>(this.a))
		});
		this.a.a = new Action<ej0>(this.a);
		this.a.a = this.a;
		this.c.a = this.a;
		this.b.a = this.c;
		this.b.b = this.c;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x00064708 File Offset: 0x00062908
	private new c5x c(e1k A_0)
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
					if (ak != null && aw1.a(A_0.g().a8(), ak) <= 3.0)
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
					c5x c5x2 = Enumerable.FirstOrDefault<c5x>(Enumerable.Select<KeyValuePair<double, c5x>, c5x>(Enumerable.OrderBy<KeyValuePair<double, c5x>, double>(list, new Func<KeyValuePair<double, c5x>, double>(epv.a.a.a)), new Func<KeyValuePair<double, c5x>, c5x>(epv.a.a.b)));
					if (c5x2 != null)
					{
						return c5x2;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x000648E4 File Offset: 0x00062AE4
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
				if (cmb != null && cmb.b((int)A_0.g().aa().Offense.u().TypedDefinition.ad()) > 2f)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00064984 File Offset: 0x00062B84
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return !A_0.d().GetPrimitivePropertyValue<bool>("triedToPickUpObject", new bool?(false)).Value && ckw.a(A_0.g().a8()) == null && this.c(A_0) != null;
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x000649D8 File Offset: 0x00062BD8
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		A_0.b().d()["triedToPickUpObject"] = true;
		c5x c5x = this.c(A_0.b());
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

	// Token: 0x04000C29 RID: 3113
	private new ej0 a;

	// Token: 0x04000C2A RID: 3114
	private new TryInvokeSpecialAbilityNode<b0t> b;

	// Token: 0x04000C2B RID: 3115
	private new ej0 c;

	// Token: 0x020002D3 RID: 723
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x00064B30 File Offset: 0x00062D30
		internal object a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00064B98 File Offset: 0x00062D98
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("triedToPickUpObject");
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00064BB0 File Offset: 0x00062DB0
		internal double a(KeyValuePair<double, c5x> A_0)
		{
			return A_0.Key;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00064BBC File Offset: 0x00062DBC
		internal c5x b(KeyValuePair<double, c5x> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x04000C2C RID: 3116
		public static readonly epv.a a = new epv.a();

		// Token: 0x04000C2D RID: 3117
		public static Func<e1k, object> b;

		// Token: 0x04000C2E RID: 3118
		public static Action<ej0> c;

		// Token: 0x04000C2F RID: 3119
		public static Func<KeyValuePair<double, c5x>, double> d;

		// Token: 0x04000C30 RID: 3120
		public static Func<KeyValuePair<double, c5x>, c5x> e;
	}
}
