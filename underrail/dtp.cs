using System;
using System.Runtime.Serialization;

// Token: 0x020019ED RID: 6637
[eiz("VRS")]
[Serializable]
public sealed class dtp : d3e, ISerializable, em0
{
	// Token: 0x06008ED2 RID: 36562 RVA: 0x0039670C File Offset: 0x0039490C
	private dtp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008ED3 RID: 36563 RVA: 0x00396718 File Offset: 0x00394918
	public dtp()
	{
	}

	// Token: 0x06008ED4 RID: 36564 RVA: 0x00396724 File Offset: 0x00394924
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		csn csn = null;
		foreach (Type a_ in new Type[]
		{
			typeof(ct7),
			typeof(e8k),
			typeof(jk),
			typeof(e5n)
		})
		{
			csn csn2 = A_0.a().Skills.a(a_);
			if (csn2 != null && (csn == null || csn2.g() > csn.g()))
			{
				csn = csn2;
			}
		}
		double num = a3p.a + (double)A_0.a().GetSpecializationValue<ag2>(true) * ag2.a;
		awc microfeat = A_0.a().GetMicrofeat<awc>();
		if (microfeat != null)
		{
			num = Math.Max(0.0, num + microfeat.a());
		}
		if (num > 0.0)
		{
			int num2 = Convert.ToInt32((double)csn.g() * num);
			foreach (Type type in new Type[]
			{
				typeof(ct7),
				typeof(e8k),
				typeof(jk),
				typeof(e5n)
			})
			{
				if (type != csn.GetType())
				{
					csn csn3 = A_0.a().Skills.a(type);
					if (csn3 != null && csn3.g() < num2)
					{
						csn3.b(num2);
					}
				}
			}
		}
	}

	// Token: 0x06008ED5 RID: 36565 RVA: 0x003968CC File Offset: 0x00394ACC
	public override d3e b3()
	{
		dtp dtp = new dtp();
		this.xx(dtp);
		return dtp;
	}

	// Token: 0x06008ED6 RID: 36566 RVA: 0x003968E8 File Offset: 0x00394AE8
	public override string b2()
	{
		return "Versatility";
	}
}
