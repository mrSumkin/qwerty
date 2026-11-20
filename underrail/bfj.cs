using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002D6 RID: 726
[apc("strider")]
public sealed class bfj : cqw
{
	// Token: 0x06001580 RID: 5504 RVA: 0x00065128 File Offset: 0x00063328
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x0006512C File Offset: 0x0006332C
	public override bool jy()
	{
		return true;
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00065130 File Offset: 0x00063330
	public override string jw()
	{
		return "xpbl_StriderChitter" + cuo.a.Next(1, 4).ToString();
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x0006515C File Offset: 0x0006335C
	public override CharacterState? jv()
	{
		return new CharacterState?(CharacterState.Custom1);
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x00065168 File Offset: 0x00063368
	public override int jx()
	{
		return 1;
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x0006516C File Offset: 0x0006336C
	public bfj()
	{
		this.c = new fh(new arr[0]);
		this.a = new ej0(new Action<ej0>(bfj.a.a.a));
		this.a.a = this.i.b;
		this.b = new ej0(new Action<ej0>(bfj.a.a.b));
		this.b.a = this.i.b;
		fh fh = this.c;
		arr[] array = new arr[2];
		array[0] = new arr(this.a, new Func<e1k, bool>(bfj.a.a.a));
		array[1] = new arr(this.b, null);
		fh.a(array);
		this.i.b = this.c;
		this.h.b = this.c;
	}

	// Token: 0x04000C33 RID: 3123
	private new ej0 a;

	// Token: 0x04000C34 RID: 3124
	private new ej0 b;

	// Token: 0x04000C35 RID: 3125
	private new fh c;

	// Token: 0x020002D7 RID: 727
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x0006529C File Offset: 0x0006349C
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x000652C4 File Offset: 0x000634C4
		internal void b(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x000652EC File Offset: 0x000634EC
		internal bool a(e1k A_0)
		{
			bool flag = false;
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
				if (classPropertyValue != null)
				{
					if (classPropertyValue.b(0) < 2f)
					{
						flag = true;
					}
				}
				else
				{
					flag = aw1.a(A_0.g().a8(), 1).Contains(amc);
				}
			}
			return flag && cuo.a.NextDouble() < 0.5;
		}

		// Token: 0x04000C36 RID: 3126
		public static readonly bfj.a a = new bfj.a();

		// Token: 0x04000C37 RID: 3127
		public static Action<ej0> b;

		// Token: 0x04000C38 RID: 3128
		public static Action<ej0> c;

		// Token: 0x04000C39 RID: 3129
		public static Func<e1k, bool> d;
	}
}
