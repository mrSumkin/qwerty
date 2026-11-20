using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000332 RID: 818
[apc("savageKing")]
public sealed class cds : esk
{
	// Token: 0x06001755 RID: 5973 RVA: 0x0007577C File Offset: 0x0007397C
	public cds()
	{
		this.d = new TryInvokeSpecialAttackNode<d8i>();
		this.a = new ej0();
		this.b = new ej0();
		this.c = new TryInvokeSpecialAttackNode<cto>();
		this.a.a = this.d.a;
		this.d.a.Insert(0, new arr(this.b, new Func<e1k, bool>(this.c)));
		this.c.b = this.a;
		this.c.a = this.a;
		this.d.a.Insert(1, new arr(this.d, new Func<e1k, bool>(this.b)));
		this.d.a = this.ay.a;
		this.d.b = this.ay.b;
		this.a.a = new Action<ej0>(cds.a.a.a);
		this.b.a = new Action<ej0>(this.a);
		this.b.a = this.c;
		arr arr = Enumerable.FirstOrDefault<arr>(Enumerable.Where<arr>(this.j.a, new Func<arr, bool>(this.a)));
		if (arr != null)
		{
			arr.b = new Func<e1k, bool>(this.a);
		}
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x00075900 File Offset: 0x00073B00
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (this.c.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null)
			{
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					d4n d4n = base.e();
					if (d4n != null && d4n.d >= 10.0 && d4n.c >= 35.0)
					{
						int num = (int)(d4n.d + (d4n.c - 35.0) + 25.0);
						float num2 = classPropertyValue.b(0);
						double num3 = aw1.b(A_0.g().a8(), amc.a8());
						if ((double)(num2 + 1f) <= num3 && num2 != -1f && num2 >= 3f && num2 * 10f <= (float)num)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x00075A14 File Offset: 0x00073C14
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (this.d.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (!euf.b(A_0.g().aa().Offense.u().TypedDefinition))
			{
				cmb cmb = bzv.d();
				if (cmb == null || cmb.b((int)as3.bk) > 3f)
				{
					return false;
				}
			}
			if (amc != null && !amc.aa().b(d8o.e) && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x00075AC0 File Offset: 0x00073CC0
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		amc amc = new bzv(A_0.b().c().y6()).g();
		if (amc != null && amc.a8() != null)
		{
			aw1.b(A_0.b().g().a8(), amc.a8(), false);
			d4n d4n = base.e();
			if (d4n != null && A_0.b().g().a8().i.b != null)
			{
				cmb classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					float num = classPropertyValue.b(0);
					A_0.b().g().aa().StatusEffects.a(new da6(1f, 30, (double)num * 0.4, false), false, false, false);
					d4n.d += 30.0;
					A_0.b().g().@as = new CharacterState?(CharacterState.Custom1);
					awx awx = new awx();
					awx.a(m7.b);
					A_0.b().g().a8().i.b.b(awx, atp.a);
				}
			}
		}
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x00075C00 File Offset: 0x00073E00
	[CompilerGenerated]
	private new bool a(arr A_0)
	{
		return A_0.a == this.ad;
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x00075C14 File Offset: 0x00073E14
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.ad.a(A_0) && A_0.g().aa().IsInCombat && new bzv(A_0.c().y6()).g() != null && bpo.GetServiceOrThrow<d02>().ahu(A_0.g().aa()).c < 50.0;
	}

	// Token: 0x04000DE2 RID: 3554
	private new ej0 a;

	// Token: 0x04000DE3 RID: 3555
	private new ej0 b;

	// Token: 0x04000DE4 RID: 3556
	private new TryInvokeSpecialAttackNode<cto> c;

	// Token: 0x04000DE5 RID: 3557
	protected new TryInvokeSpecialAttackNode<d8i> d;

	// Token: 0x02000333 RID: 819
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x00075CA0 File Offset: 0x00073EA0
		internal void a(ej0 A_0)
		{
			foreach (da6 a_ in Enumerable.ToList<da6>(Enumerable.OfType<da6>(A_0.b().g().aa().StatusEffects.d())))
			{
				A_0.b().g().aa().StatusEffects.d(a_);
			}
			A_0.b().g().@as = null;
		}

		// Token: 0x04000DE6 RID: 3558
		public static readonly cds.a a = new cds.a();

		// Token: 0x04000DE7 RID: 3559
		public static Action<ej0> b;
	}
}
