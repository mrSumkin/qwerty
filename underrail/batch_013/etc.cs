using System;
using System.Runtime.Serialization;

// Token: 0x020019B4 RID: 6580
[eiz("TGHFEME")]
[Serializable]
public sealed class etc : cdh, ISerializable, d7s
{
	// Token: 0x06008CB1 RID: 36017 RVA: 0x00391954 File Offset: 0x0038FB54
	private etc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008CB2 RID: 36018 RVA: 0x00391960 File Offset: 0x0038FB60
	public etc()
	{
	}

	// Token: 0x06008CB3 RID: 36019 RVA: 0x00391968 File Offset: 0x0038FB68
	public override string b2()
	{
		return qv.a("StatusEffects/ToxicGasHealingForEnergyMicrofeat", new object[]
		{
			etc.a,
			etc.b,
			etc.d,
			Convert.ToInt32(etc.c * 100.0)
		});
	}

	// Token: 0x06008CB4 RID: 36020 RVA: 0x003919C8 File Offset: 0x0038FBC8
	public override d3e b3()
	{
		etc etc = new etc();
		this.xx(etc);
		return etc;
	}

	// Token: 0x06008CB5 RID: 36021 RVA: 0x003919E4 File Offset: 0x0038FBE4
	public void cn(d3e A_0)
	{
	}

	// Token: 0x06008CB6 RID: 36022 RVA: 0x003919E8 File Offset: 0x0038FBE8
	public bool co(d3e A_0)
	{
		return A_0 is etc;
	}

	// Token: 0x06008CB7 RID: 36023 RVA: 0x003919F4 File Offset: 0x0038FBF4
	public void a(efk A_0, int A_1)
	{
		if ((double)euf.f(A_0) < etc.c && A_0.Gear.g().Item != null && !A_0.SpecialStates.h && !A_0.StatusEffects.a(b34.c) && A_0.Gear.g().Item.Battery > 0.1)
		{
			int num = Convert.ToInt32((float)etc.a + (float)((etc.b - etc.a) * (A_1 - 1)) / 3f);
			int num2 = Convert.ToInt32((double)A_0.Defense.q().zm() * etc.c - (double)A_0.Defense.q().zo());
			bool a_ = false;
			if ((double)num * A_0.Defense.aa() > (double)num2)
			{
				num = num2;
				a_ = true;
			}
			double num3 = Math.Round((double)num / (double)etc.b * etc.d, 2);
			if (A_0.Gear.g().Item.Battery < num3)
			{
				double num4 = A_0.Gear.g().Item.Battery / num3;
				num = Math.Max(1, Convert.ToInt32(num4 * (double)num));
				num3 = A_0.Gear.g().Item.Battery;
			}
			A_0.Gear.g().Item.Battery = Math.Max(0.0, A_0.Gear.g().Item.Battery - num3);
			A_0.Defense.a(num, null, null, true, a_, false, null);
		}
	}

	// Token: 0x040037A3 RID: 14243
	public new static readonly int a = 10;

	// Token: 0x040037A4 RID: 14244
	public static readonly int b = 30;

	// Token: 0x040037A5 RID: 14245
	public static readonly double c = 0.75;

	// Token: 0x040037A6 RID: 14246
	public static readonly double d = 6.0;
}
