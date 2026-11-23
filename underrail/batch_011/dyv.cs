using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AA6 RID: 6822
[eiz("CHSE")]
[Serializable]
public sealed class dyv : els, ISerializable
{
	// Token: 0x06009403 RID: 37891 RVA: 0x003A4AF0 File Offset: 0x003A2CF0
	private dyv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009404 RID: 37892 RVA: 0x003A4AFC File Offset: 0x003A2CFC
	public dyv(int A_0) : base(dyv.a, "Химопастность", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.108";
		base.MaxStacks = dyv.b;
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Chemhaze"));
		base.StaticEffects.Add(new etj(-dyv.c));
		base.StaticEffects.Add(new ae6(-dyv.d));
	}

	// Token: 0x06009405 RID: 37893 RVA: 0x003A4B80 File Offset: 0x003A2D80
	public override string cb(ll A_0)
	{
		double num = 0.0;
		double num2 = 0.0;
		etj etj = Enumerable.FirstOrDefault<etj>(Enumerable.OfType<etj>(base.StaticEffects));
		if (etj != null)
		{
			num = Math.Abs(etj.b());
		}
		ae6 ae = Enumerable.FirstOrDefault<ae6>(Enumerable.OfType<ae6>(base.StaticEffects));
		if (ae != null)
		{
			num2 = Math.Abs(ae.b());
		}
		return qv.a("StatusEffects/Chemhaze", new object[]
		{
			Convert.ToInt32(num * 100.0),
			Convert.ToInt32(num2 * 100.0)
		});
	}

	// Token: 0x06009406 RID: 37894 RVA: 0x003A4C28 File Offset: 0x003A2E28
	protected override void c8()
	{
		base.c8();
		etj etj = Enumerable.FirstOrDefault<etj>(Enumerable.OfType<etj>(base.StaticEffects));
		if (etj != null)
		{
			etj.a(-dyv.c * (double)base.Stacks);
		}
		ae6 ae = Enumerable.FirstOrDefault<ae6>(Enumerable.OfType<ae6>(base.StaticEffects));
		if (ae != null)
		{
			ae.a(-dyv.d * (double)base.Stacks);
		}
	}

	// Token: 0x040038E0 RID: 14560
	public new static readonly string a = "chemhaze";

	// Token: 0x040038E1 RID: 14561
	public static readonly int b = 5;

	// Token: 0x040038E2 RID: 14562
	public new static readonly double c = 0.07;

	// Token: 0x040038E3 RID: 14563
	public new static readonly double d = 0.03;

	// Token: 0x040038E4 RID: 14564
	public new static readonly int e = 2;
}
