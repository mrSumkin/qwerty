using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002BA RID: 698
[apc("buffalo")]
public sealed class des : cqw
{
	// Token: 0x06001459 RID: 5209 RVA: 0x000585E0 File Offset: 0x000567E0
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x000585E4 File Offset: 0x000567E4
	public des()
	{
		this.a = new fh(new arr[0]);
		this.b = new ej0();
		this.c = new ej0();
		this.d = new TryInvokeSpecialAttackNode<cto>();
		this.a.a(new arr[]
		{
			new arr(this.c, new Func<e1k, bool>(this.a)),
			new arr(this.b, null)
		});
		this.b.a = this.p.a;
		this.p.a = this.a;
		this.b.a = new Action<ej0>(des.a.a.a);
		this.c.a.Add(new Action<aij>(des.a.a.a));
		this.c.a = new Action<ej0>(this.a);
		this.c.a = this.d;
		this.d.b = this.b;
		this.d.a = this.b;
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00058734 File Offset: 0x00056934
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.d.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null)
			{
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					d4n d4n = base.e();
					if (d4n != null && d4n.d >= 10.0 && d4n.c >= 40.0)
					{
						int num = (int)(d4n.d + (d4n.c - 40.0) + 25.0);
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

	// Token: 0x0600145C RID: 5212 RVA: 0x00058848 File Offset: 0x00056A48
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
					A_0.b().g().aa().StatusEffects.a(new da6(0.5f, 30, (double)num * 0.65, true), false, false, false);
					d4n.d += 30.0;
					A_0.b().g().@as = new CharacterState?(CharacterState.Custom2);
					awx awx = new awx();
					awx.a(m7.b);
					awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
					A_0.b().g().a8().i.b.b(awx, atp.a);
				}
			}
		}
	}

	// Token: 0x04000B27 RID: 2855
	private new fh a;

	// Token: 0x04000B28 RID: 2856
	private new ej0 b;

	// Token: 0x04000B29 RID: 2857
	private new ej0 c;

	// Token: 0x04000B2A RID: 2858
	private new TryInvokeSpecialAttackNode<cto> d;

	// Token: 0x020002BB RID: 699
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x000589D4 File Offset: 0x00056BD4
		internal void a(ej0 A_0)
		{
			foreach (da6 a_ in Enumerable.ToList<da6>(Enumerable.OfType<da6>(A_0.b().g().aa().StatusEffects.d())))
			{
				A_0.b().g().aa().StatusEffects.d(a_);
			}
			A_0.b().g().@as = null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00058A78 File Offset: 0x00056C78
		internal void a(aij A_0)
		{
			foreach (da6 a_ in Enumerable.ToList<da6>(Enumerable.OfType<da6>(A_0.b().g().aa().StatusEffects.d())))
			{
				A_0.b().g().aa().StatusEffects.d(a_);
			}
			A_0.b().g().@as = null;
		}

		// Token: 0x04000B2B RID: 2859
		public static readonly des.a a = new des.a();

		// Token: 0x04000B2C RID: 2860
		public static Action<ej0> b;

		// Token: 0x04000B2D RID: 2861
		public static Action<aij> c;
	}
}
