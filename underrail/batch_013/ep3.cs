using System;
using System.Runtime.Serialization;

// Token: 0x020019CF RID: 6607
[eiz("BMMDME")]
[Serializable]
public sealed class ep3 : cdh, ISerializable
{
	// Token: 0x06008D99 RID: 36249 RVA: 0x003939E8 File Offset: 0x00391BE8
	private ep3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("BMMDME:B");
		this.b = A_0.GetDouble("BMMDME:P");
		this.c = A_0.GetInt32("BMMDME:A");
		this.d = A_0.GetInt32("BMMDME:T");
		this.e = A_0.GetInt32("BMMDME:S");
	}

	// Token: 0x06008D9A RID: 36250 RVA: 0x00393A5C File Offset: 0x00391C5C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BMMDME:B", this.a);
		info.AddValue("BMMDME:P", this.b);
		info.AddValue("BMMDME:A", this.c);
		info.AddValue("BMMDME:T", this.d);
		info.AddValue("BMMDME:S", this.e);
	}

	// Token: 0x06008D9B RID: 36251 RVA: 0x00393AC8 File Offset: 0x00391CC8
	public override bool ae5()
	{
		return false;
	}

	// Token: 0x06008D9C RID: 36252 RVA: 0x00393ACC File Offset: 0x00391CCC
	public ep3()
	{
	}

	// Token: 0x06008D9D RID: 36253 RVA: 0x00393AE0 File Offset: 0x00391CE0
	public override string b2()
	{
		string arg;
		if (this.a > 0.0)
		{
			if (this.b > 0.0)
			{
				arg = string.Format("{0}% плюс дополнительно {1}% за {2} эффективный навык ближнего боя", Convert.ToInt32(this.a * 100.0), Convert.ToInt32(this.b * 100.0), this.e);
			}
			else
			{
				arg = string.Format("{0}%", this.a);
			}
		}
		else if (this.b > 0.0)
		{
			arg = string.Format("{0}% за {1} эффективный навык ближнего боя", Convert.ToInt32(this.b * 100.0), this.e);
		}
		else
		{
			arg = "0%";
		}
		string arg2;
		if (this.c > 0)
		{
			if (this.d > 0)
			{
				arg2 = string.Format("{0} плюс дополнительно {1} за {2} эффективный навык ближнего боя", this.c, this.d, this.e);
			}
			else
			{
				arg2 = this.c.ToString();
			}
		}
		else if (this.d > 0)
		{
			arg2 = string.Format("{0} за {1} эффективный навык ближнего боя", this.d, this.e);
		}
		else
		{
			arg2 = "0";
		}
		return string.Format("Даёт {0} шанс блока {1} механического урона ближнего боя", arg, arg2);
	}

	// Token: 0x06008D9E RID: 36254 RVA: 0x00393C6C File Offset: 0x00391E6C
	public void a(int A_0, out double A_1, out int A_2)
	{
		if (A_0 < 0)
		{
			A_0 = 0;
		}
		A_1 = this.a + this.b * (double)(A_0 / Math.Max(1, this.e));
		A_2 = this.c + this.d * (A_0 / Math.Max(1, this.e));
		A_1 = Math.Min(0.95, A_1);
	}

	// Token: 0x06008D9F RID: 36255 RVA: 0x00393CD4 File Offset: 0x00391ED4
	public override d3e b3()
	{
		ep3 ep = new ep3();
		this.xx(ep);
		return ep;
	}

	// Token: 0x06008DA0 RID: 36256 RVA: 0x00393CF0 File Offset: 0x00391EF0
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ep3 ep = (ep3)A_0;
		ep.a = this.a;
		ep.b = this.b;
		ep.c = this.c;
		ep.d = this.d;
		ep.e = this.e;
	}

	// Token: 0x040037BC RID: 14268
	public new double a;

	// Token: 0x040037BD RID: 14269
	public double b;

	// Token: 0x040037BE RID: 14270
	public int c;

	// Token: 0x040037BF RID: 14271
	public int d;

	// Token: 0x040037C0 RID: 14272
	public int e = 10;
}
