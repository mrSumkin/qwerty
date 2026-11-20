using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000347 RID: 839
[eiz("CE2")]
[Serializable]
public abstract class bjs : aeq, ISerializable
{
	// Token: 0x060017B1 RID: 6065 RVA: 0x0007881C File Offset: 0x00076A1C
	protected bjs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ap9)A_0.GetValue("CE2:A", typeof(ap9));
			return;
		}
		if (base.GetType() == typeof(bjs))
		{
			this.a = (ap9)A_0.GetValue("_Attacker", typeof(ap9));
			return;
		}
		this.a = (ap9)A_0.GetValue("CombatEvent+_Attacker", typeof(ap9));
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x000788B8 File Offset: 0x00076AB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CE2:A", this.a);
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x000788D4 File Offset: 0x00076AD4
	public ap9 f()
	{
		return this.a;
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x000788DC File Offset: 0x00076ADC
	public virtual bool a()
	{
		return false;
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x000788E0 File Offset: 0x00076AE0
	protected bjs(ap9 A_0, ap9 A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x000788F4 File Offset: 0x00076AF4
	public virtual List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x0007891C File Offset: 0x00076B1C
	protected static void a(dl6 A_0, List<csk> A_1)
	{
		if (A_1 == null || A_1.Count <= 0)
		{
			A_0.a.Add(new bph(bvm.a(), "нет урона", null));
			return;
		}
		if (A_1.Count > 1)
		{
			int num = 0;
			for (int i = 0; i < A_1.Count; i++)
			{
				csk csk = A_1[i];
				num += csk.Amount;
				A_0.a.Add(new bph(bvm.a(adi.af[csk.DamageType]), string.Format("{0}{1} {2}", (i == 0) ? "" : " ", csk.Amount, csk.DamageType), null));
			}
			A_0.a.Insert(1, new bph(bvm.a(), string.Format("{0} урона (", num), null));
			A_0.a.Add(new bph(bvm.a(), ")", null));
			return;
		}
		csk csk2 = Enumerable.First<csk>(A_1);
		A_0.a.Add(new bph(bvm.a(adi.af[csk2.DamageType]), string.Format("{0} {1} урона", csk2.Amount, csk2.DamageType.ToString().ToLowerInvariant()), null));
	}

	// Token: 0x04000E0D RID: 3597
	private ap9 a;
}
