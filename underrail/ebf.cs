using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001A78 RID: 6776
[eiz("GHSE0")]
[Serializable]
public sealed class ebf : els, ISerializable
{
	// Token: 0x06009328 RID: 37672 RVA: 0x003A1560 File Offset: 0x0039F760
	private ebf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009329 RID: 37673 RVA: 0x003A156C File Offset: 0x0039F76C
	public ebf(int A_0, int A_1, int A_2, float A_3) : base("gunnersHigh", "Тяжёлая стрельба", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.137";
		base.MaxStacks = A_2;
		base.Stacking = axm.b;
		base.Power = A_1;
		base.TickPeriod = d0u.b;
		base.DynamicEffects.Add(new a7i(A_1, A_3));
		this.a();
	}

	// Token: 0x0600932A RID: 37674 RVA: 0x003A15D8 File Offset: 0x0039F7D8
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x0600932B RID: 37675 RVA: 0x003A15E8 File Offset: 0x0039F7E8
	private void a()
	{
		a7i a7i = Enumerable.FirstOrDefault<a7i>(Enumerable.OfType<a7i>(base.DynamicEffects));
		if (a7i != null)
		{
			a7i.Amount = base.Stacks;
		}
	}

	// Token: 0x0600932C RID: 37676 RVA: 0x003A1618 File Offset: 0x0039F818
	public override string cb(ll A_0)
	{
		a7i a7i = Enumerable.FirstOrDefault<a7i>(Enumerable.OfType<a7i>(base.DynamicEffects));
		if (a7i == null)
		{
			return "";
		}
		return qv.a("StatusEffects/GunnersHigh", new object[]
		{
			a7i.Amount,
			Convert.ToInt32(a7i.Limit * 100f)
		});
	}
}
